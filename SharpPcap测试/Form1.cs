using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using SharpPcap;
using PacketDotNet;
using PacketDotNet.Utils;

namespace SharpPcap测试
{
    public partial class MainForm : Form
    {
        // 全局变量定义在此处
        static ToolTip DeviceListTooltip = new ToolTip();               // 设备列表鼠标悬停弹出窗口
        static List<string> DeviceListInfo = new List<string>();        // 设备列表描述信息，用于鼠标悬停弹出窗口中显示
        static int DeviceListTempIndex = -1;                            // 鼠标最后一次悬停的项的索引号，用于防止反复更新鼠标悬停弹出窗口
        static bool NeedSelectAll = false,                              // 全选标志，用于MouseClick事件
                    IsChangedByProgram = false;                         // 程序规范化更改标志，用于JumpToNextIPTextbox事件

        // 主窗口入口点
        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;    // 取消线程安全检测
            ARPOperationComboBox.SelectedIndex = 0;

            try
            {
                // 打印SharpPcap版本  
                string ver = SharpPcap.Version.VersionString;
                OutputBox.AppendText("SharpPcap " + ver + "\r\n\r\n");

                // 转存设备列表信息  
                var devices = CaptureDeviceList.Instance;

                // 未发现设备是丢掷出错误  
                if (devices.Count < 1)
                {
                    throw new Exception("No devices were found on this machine.");
                }

                //OutputBox.AppendText("\r\nThe following devices are available on this machine:\r\n");
                //OutputBox.AppendText("\r\n----------------------------------------------------\r\n");

                // 设置DeviceListTooltip参数
                DeviceListTooltip.AutoPopDelay = 5000;
                DeviceListTooltip.InitialDelay = 1000;
                DeviceListTooltip.ReshowDelay = 500;

                // 打印设备列表信息
                foreach (var dev in devices)
                {
                    DeviceList.Items.Add(dev.Description.Remove(dev.Description.LastIndexOf("'")).Substring(dev.Description.IndexOf("'") + 1));
                    string buf = dev.ToString();
                    buf = buf.Replace("\n\n", "\n");
                    buf = buf.Replace("\n", "\r\n");
                    //OutputBox.AppendText(buf);
                    //OutputBox.AppendText("\r\n----------------------------------------------------\r\n");
                    DeviceListInfo.Add(buf);            
                }
            }
            catch(Exception e)
            {
                // 处理丢掷出的异常消息
                OutputBox.AppendText("Error:" + e.Message);
            }
        }

        // 设备列表鼠标移动事件，显示ToolTip
        private void DeviceList_MouseMove(object sender, MouseEventArgs e)
        {
            int Index = ((ListBox)sender).IndexFromPoint(e.Location);
            if (Index < 0)
            {
                DeviceListTempIndex = -1;
                return;
            }
            if (DeviceListTempIndex == -1 || DeviceListTempIndex != Index)
            {
                DeviceListTempIndex = Index;
                DeviceListTooltip.SetToolTip(DeviceList, DeviceListInfo[Index]);
            }
        }

        // 8位字段输入窗口TextChanged事件，自动规范化并切换到下个输入
        private void JumpToNextByteTextbox(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;
            if (temp.Text.Length == 3 && !IsChangedByProgram)
            {
                if (Convert.ToInt32(temp.Text) > 255)
                {
                    IsChangedByProgram = true;
                    temp.Text = "255";
                }
                SelectNextControl(temp, true, true, true, true);
            }
            else
            {
                IsChangedByProgram = false;
            }
        }

        // 16位字段输入窗口TextChanged事件，自动规范化并切换到下个输入
        private void JumpToNextWordTextbox(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;
            if (temp.Text.Length == 5 && !IsChangedByProgram)
            {
                if (Convert.ToInt32(temp.Text) > 65535)
                {
                    IsChangedByProgram = true;
                    temp.Text = "65535";
                }
                SelectNextControl(temp, true, true, true, true);
            }
            else
            {
                IsChangedByProgram = false;
            }
        }

        // 32位字段输入窗口TextChanged事件，自动规范化并切换到下个输入
        private void JumpToNextDWordTextbox(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;
            if (temp.Text.Length == 10 && !IsChangedByProgram)
            {
                if (Convert.ToInt64(temp.Text) > 4294967295)
                {
                    IsChangedByProgram = true;
                    temp.Text = "4294967295";
                }
                SelectNextControl(temp, true, true, true, true);
            }
            else
            {
                IsChangedByProgram = false;
            }
        }

        // 3位偏移标志输入窗口TextChanged事件，自动规范化偏移量并切换到下个输入
        private void JumpToNextFragmentFlagsTextbox(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;
            if (temp.Text.Length == 1 && !IsChangedByProgram)
            {
                if (Convert.ToInt32(temp.Text) > 7)
                {
                    IsChangedByProgram = true;
                    temp.Text = "7";
                }
                SelectNextControl(temp, true, true, true, true);
            }
            else
            {
                IsChangedByProgram = false;
            }
        }

        // 13位偏移量输入窗口TextChanged事件，自动规范化偏移量并切换到下个输入
        private void JumpToNextFragmentTextbox(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;
            if (temp.Text.Length == 4 && !IsChangedByProgram)
            {
                if (Convert.ToInt32(temp.Text) > 8190)
                {
                    IsChangedByProgram = true;
                    temp.Text = "8191";
                }
                SelectNextControl(temp, true, true, true, true);
            }
            else
            {
                IsChangedByProgram = false;
            }
        }

        // 公用输入窗口Leave事件，失去焦点时自动在空输入框中填充0
        private void TextboxLeave(object sender,EventArgs e)
        {
            TextBox temp = (TextBox)sender;
            if (temp.Text == "")
            {
                temp.Text = "0";
            }
        }

        // MAC输入窗口TextChanged事件，自动切换到下个输入
        private void JumpToNextMACTextbox(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;
            if (temp.Text.Length == 2)
            {
                SelectNextControl(temp, true, true, true, true);
            }
        }

        // 公用输入窗口Enter事件，获得焦点时全选并设置全选标志
        private void TextboxEnter(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;
            NeedSelectAll = true;
            temp.SelectAll();
        }

        // 公用输入窗口MouseClick事件，鼠标点击时通过全选标志全选内容
        private void TextboxMouseClick(object sender, MouseEventArgs e)
        {
            TextBox temp = (TextBox)sender;
            if (NeedSelectAll)
            {
                temp.SelectAll();
                NeedSelectAll = false;
            }
        }

        // 十进制输入窗口KeyPress事件，限制输入格式为数字
        private void DecInputLimit(object sender, KeyPressEventArgs e)
        {
            TextBox temp = (TextBox)sender;
            if (e.KeyChar != '\b')
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                {
                    if (e.KeyChar == 13)
                    {
                        SelectNextControl(temp, true, true, true, true);
                    }
                    e.Handled = true;
                }
            }
        }

        // 网络层协议选择下拉菜单值改变事件，此处同时设置运输层协议选择下拉菜单的属性
        private void NetworkLayerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(NetworkLayerComboBox.SelectedIndex)
            {
                case 0:     // IPv4
                    TransportLayerComboBox.Enabled = true;
                    IPv4GroupBox.Enabled = true;
                    if (TransportLayerComboBox.SelectedIndex == 0)
                    {
                        TCPGroupBox.Enabled = true;
                    }
                    ARPGroupBox.Enabled = false;
                    break;
                case 1:     // ARP
                    TransportLayerComboBox.Enabled = false;
                    TransportLayerComboBox.SelectedIndex = -1;
                    TCPGroupBox.Enabled = false;
                    IPv4GroupBox.Enabled = false;
                    ARPGroupBox.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        // 运输层协议选择下拉菜单值改变事件，此处同时设置各输入框的属性
        private void TransportLayerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(TransportLayerComboBox.SelectedIndex)
            {
                case 0:     // TCP
                    TCPGroupBox.Enabled = true;
                    break;
                case 1:     // UDP
                    TCPGroupBox.Enabled = false;
                    break;
                default:
                    TCPGroupBox.Enabled = false;
                    break;
            }
        }

        // 发送数据包按钮按下事件，此处处理封包发包
        private void SendPacketButton_Click(object sender, EventArgs e)
        {
            // 打开网络设备
            int SelectedDeviceIndex = DeviceList.SelectedIndex;
            if (SelectedDeviceIndex < 0)
            {
                OutputBox.AppendText("请先选择网络设备。\r\n");
                return;
            }
            var devices = CaptureDeviceList.Instance;
            ICaptureDevice CurDev = null;
            foreach (var dev in devices)
            {
                if (SelectedDeviceIndex == 0)
                {
                    CurDev = dev;
                    break;
                }
                else
                {
                    SelectedDeviceIndex--;
                }
            }
            if (CurDev == null)
            {
                OutputBox.AppendText("错误出现在网络设备上，发送数据包失败。\r\n");
                return;
            }
            CurDev.Open();

            // 封装数据包
            int PacketType = NetworkLayerComboBox.SelectedIndex * 10 + TransportLayerComboBox.SelectedIndex;
            EthernetPacket ether = null;
            switch(PacketType)
            {
                case 0:     // IPv4 + TCP
                    ether = TCPonIPv4PacketMaker();
                    OutputBox.AppendText(ether.PrintHex() + "\r\n\r\n");
                    break;
                case 1:     // IPv4 + UDP
                    ether = UDPonIPv4PacketMaker();
                    OutputBox.AppendText(ether.PrintHex() + "\r\n\r\n");
                    break;
                case 9:    // ARP
                    ether = ARPorRARPPacketMaker();
                    OutputBox.AppendText(ether.PrintHex() + "\r\n\r\n");
                    break;
                default:
                    OutputBox.AppendText("错误出现在数据包协议上，发送数据包失败。\r\n");
                    return;
            }

            // 发送数据包
            if (ether == null)
            {
                OutputBox.AppendText("错误出现在数据包封装上，发送数据包失败。\r\n");
            }
            CurDev.SendPacket(ether);
        }

        // 十六进制及输入窗口KeyPress事件，限制输入格式为数字或A-F
        private void HexInputLimit(object sender, KeyPressEventArgs e)
        {
            TextBox temp = (TextBox)sender;
            if (e.KeyChar != '\b')
            {
                if (!((e.KeyChar >= '0') && (e.KeyChar <= '9')) && !((e.KeyChar >= 'a') && (e.KeyChar <= 'f')) && !((e.KeyChar >= 'A') && (e.KeyChar <= 'F')))
                {
                    if (e.KeyChar == 13)
                    {
                        SelectNextControl(temp, true, true, true, true);
                    }
                    e.Handled = true;
                }
            }
        }

        // IPv4 + TCP数据包封装函数
        private EthernetPacket TCPonIPv4PacketMaker()
        {
            // Ether封包
            EthernetPacket ether = new EthernetPacket(PhysicalAddress.Parse(MakeMACaddr(SourceMAC1.Text, SourceMAC2.Text, SourceMAC3.Text, SourceMAC4.Text, SourceMAC5.Text, SourceMAC6.Text)),
                                                      PhysicalAddress.Parse(MakeMACaddr(DestMAC1.Text, DestMAC2.Text, DestMAC3.Text, DestMAC4.Text, DestMAC5.Text, DestMAC6.Text)),
                                                      EthernetPacketType.IpV4);

            // TCP封包
            TcpPacket tcp = new TcpPacket(Convert.ToUInt16(SourcePortTextBox.Text), Convert.ToUInt16(DestPortTextBox.Text))
            {
                Urg = TCPFlagsCheckedListBox.GetItemChecked(0),
                Ack = TCPFlagsCheckedListBox.GetItemChecked(1),
                Psh = TCPFlagsCheckedListBox.GetItemChecked(2),
                Rst = TCPFlagsCheckedListBox.GetItemChecked(3),
                Syn = TCPFlagsCheckedListBox.GetItemChecked(4),
                Fin = TCPFlagsCheckedListBox.GetItemChecked(5),
                SequenceNumber = Convert.ToUInt32(SequenceTextBox.Text),
                AcknowledgmentNumber = Convert.ToUInt32(AcknowledgmentTextBox.Text),
                WindowSize = Convert.ToUInt16(WindowSizeTextBox.Text),
                UrgentPointer = Convert.ToInt32(UrgPointerTextBox.Text)
            };
            if (PayloadTextBox.Text.Length != 0)
            {
                tcp.PayloadData = Encoding.ASCII.GetBytes(PayloadTextBox.Text);
            }
            tcp.UpdateCalculatedValues();

            // IPv4封包
            IPv4Packet ipv4 = new IPv4Packet(IPAddress.Parse(MakeIPaddr(SourceIP1.Text, SourceIP2.Text, SourceIP3.Text, SourceIP4.Text)),
                                             IPAddress.Parse(MakeIPaddr(DestIP1.Text, DestIP2.Text, DestIP3.Text, DestIP4.Text)))
            {
                TimeToLive = Convert.ToInt32(TTLTextBox.Text),
                Protocol = IPProtocolType.TCP,
                Version = IpVersion.IPv4,
                FragmentFlags = Convert.ToInt16(FragmentFlagsTextBox.Text),
                FragmentOffset = Convert.ToInt32(FragmentOffsetTextBox.Text),
                TypeOfService = Convert.ToInt32(TOSTextBox.Text),
                Id = Convert.ToUInt16(IdentifierTextbox.Text),
                PayloadPacket = tcp
            };
            ether.PayloadPacket = ipv4;
            ipv4.ParentPacket = ether;
            ipv4.UpdateIPChecksum();

            tcp.ParentPacket = ipv4;
            tcp.UpdateTCPChecksum();

            return ether;
        }

        // IPv4 + UDP数据包封装函数
        private EthernetPacket UDPonIPv4PacketMaker()
        {
            // Ether封包
            EthernetPacket ether = new EthernetPacket(PhysicalAddress.Parse(MakeMACaddr(SourceMAC1.Text, SourceMAC2.Text, SourceMAC3.Text, SourceMAC4.Text, SourceMAC5.Text, SourceMAC6.Text)),
                                                      PhysicalAddress.Parse(MakeMACaddr(DestMAC1.Text, DestMAC2.Text, DestMAC3.Text, DestMAC4.Text, DestMAC5.Text, DestMAC6.Text)),
                                                      EthernetPacketType.IpV4);

            // UDP封包
            UdpPacket udp = new UdpPacket(Convert.ToUInt16(SourcePortTextBox.Text), Convert.ToUInt16(DestPortTextBox.Text));
            if (PayloadTextBox.Text.Length != 0)
            {
                udp.PayloadData = Encoding.ASCII.GetBytes(PayloadTextBox.Text);
            }
            udp.UpdateCalculatedValues();

            // IPv4封包
            IPv4Packet ipv4 = new IPv4Packet(IPAddress.Parse(MakeIPaddr(SourceIP1.Text, SourceIP2.Text, SourceIP3.Text, SourceIP4.Text)),
                                             IPAddress.Parse(MakeIPaddr(DestIP1.Text, DestIP2.Text, DestIP3.Text, DestIP4.Text)))
            {
                TimeToLive = Convert.ToInt32(TTLTextBox.Text),
                Protocol = IPProtocolType.UDP,
                Version = IpVersion.IPv4,
                FragmentFlags = Convert.ToInt16(FragmentFlagsTextBox.Text),
                FragmentOffset = Convert.ToInt32(FragmentOffsetTextBox.Text),
                TypeOfService = Convert.ToInt32(TOSTextBox.Text),
                Id = Convert.ToUInt16(IdentifierTextbox.Text),
                PayloadPacket = udp
            };
            ether.PayloadPacket = ipv4;
            ipv4.ParentPacket = ether;
            ipv4.UpdateIPChecksum();

            udp.ParentPacket = ipv4;
            udp.UpdateUDPChecksum();

            return ether;
        }


        // ARP/RARP数据包封装函数
        private EthernetPacket ARPorRARPPacketMaker()
        {
            EthernetPacket ether;
            ARPPacket arp;

            switch (ARPOperationComboBox.SelectedIndex)
            {
                case 0:     // ARP请求封包
                    ether = new EthernetPacket(PhysicalAddress.Parse(MakeMACaddr(SourceMAC1.Text, SourceMAC2.Text, SourceMAC3.Text, SourceMAC4.Text, SourceMAC5.Text, SourceMAC6.Text)),
                                               PhysicalAddress.Parse(MakeMACaddr(DestMAC1.Text, DestMAC2.Text, DestMAC3.Text, DestMAC4.Text, DestMAC5.Text, DestMAC6.Text)),
                                               EthernetPacketType.Arp);

                    arp = new ARPPacket(ARPOperation.Request,
                                        PhysicalAddress.Parse(MakeMACaddr(DestMAC1.Text, DestMAC2.Text, DestMAC3.Text, DestMAC4.Text, DestMAC5.Text, DestMAC6.Text)),
                                        IPAddress.Parse(MakeIPaddr(DestIP1.Text, DestIP2.Text, DestIP3.Text, DestIP4.Text)),
                                        PhysicalAddress.Parse(MakeMACaddr(SourceMAC1.Text, SourceMAC2.Text, SourceMAC3.Text, SourceMAC4.Text, SourceMAC5.Text, SourceMAC6.Text)),
                                        IPAddress.Parse(MakeIPaddr(SourceIP1.Text, SourceIP2.Text, SourceIP3.Text, SourceIP4.Text)))
                    {
                        HardwareAddressType = LinkLayers.Ethernet,
                        ProtocolAddressType=EthernetPacketType.IpV4
                    };

                    if (DestMAC1.Text.ToUpper() == "FF" && DestMAC2.Text.ToUpper() == "FF" && DestMAC3.Text.ToUpper() == "FF"
                        && DestMAC4.Text.ToUpper() == "FF" && DestMAC5.Text.ToUpper() == "FF" && DestMAC6.Text.ToUpper() == "FF")
                    {
                        arp.TargetHardwareAddress = PhysicalAddress.Parse(MakeMACaddr("00", "00", "00", "00", "00", "00"));
                    }

                    arp.UpdateCalculatedValues();

                    ether.PayloadPacket = arp;
                    arp.ParentPacket = ether;

                    return ether;
                case 1:     // ARP响应封包
                    ether = new EthernetPacket(PhysicalAddress.Parse(MakeMACaddr(SourceMAC1.Text, SourceMAC2.Text, SourceMAC3.Text, SourceMAC4.Text, SourceMAC5.Text, SourceMAC6.Text)),
                                               PhysicalAddress.Parse(MakeMACaddr(DestMAC1.Text, DestMAC2.Text, DestMAC3.Text, DestMAC4.Text, DestMAC5.Text, DestMAC6.Text)),
                                               EthernetPacketType.Arp);

                    arp = new ARPPacket(ARPOperation.Response,
                                        PhysicalAddress.Parse(MakeMACaddr(DestMAC1.Text, DestMAC2.Text, DestMAC3.Text, DestMAC4.Text, DestMAC5.Text, DestMAC6.Text)),
                                        IPAddress.Parse(MakeIPaddr(DestIP1.Text, DestIP2.Text, DestIP3.Text, DestIP4.Text)),
                                        PhysicalAddress.Parse(MakeMACaddr(SourceMAC1.Text, SourceMAC2.Text, SourceMAC3.Text, SourceMAC4.Text, SourceMAC5.Text, SourceMAC6.Text)),
                                        IPAddress.Parse(MakeIPaddr(SourceIP1.Text, SourceIP2.Text, SourceIP3.Text, SourceIP4.Text)))
                    {
                        HardwareAddressType = LinkLayers.Ethernet,
                        ProtocolAddressType = EthernetPacketType.IpV4
                    };

                    arp.UpdateCalculatedValues();

                    ether.PayloadPacket = arp;
                    arp.ParentPacket = ether;

                    return ether;
                case 2:     // RARP请求封包
                    ether = new EthernetPacket(PhysicalAddress.Parse(MakeMACaddr(SourceMAC1.Text, SourceMAC2.Text, SourceMAC3.Text, SourceMAC4.Text, SourceMAC5.Text, SourceMAC6.Text)),
                                               PhysicalAddress.Parse(MakeMACaddr(DestMAC1.Text, DestMAC2.Text, DestMAC3.Text, DestMAC4.Text, DestMAC5.Text, DestMAC6.Text)),
                                               EthernetPacketType.ReverseArp);

                    arp = new ARPPacket(ARPOperation.RequestReverse,
                                        PhysicalAddress.Parse(MakeMACaddr(DestMAC1.Text, DestMAC2.Text, DestMAC3.Text, DestMAC4.Text, DestMAC5.Text, DestMAC6.Text)),
                                        IPAddress.Parse(MakeIPaddr(DestIP1.Text, DestIP2.Text, DestIP3.Text, DestIP4.Text)),
                                        PhysicalAddress.Parse(MakeMACaddr(SourceMAC1.Text, SourceMAC2.Text, SourceMAC3.Text, SourceMAC4.Text, SourceMAC5.Text, SourceMAC6.Text)),
                                        IPAddress.Parse(MakeIPaddr(SourceIP1.Text, SourceIP2.Text, SourceIP3.Text, SourceIP4.Text)))
                    {
                        HardwareAddressType = LinkLayers.Ethernet,
                        ProtocolAddressType = EthernetPacketType.IpV4
                    };

                    arp.UpdateCalculatedValues();

                    ether.PayloadPacket = arp;
                    arp.ParentPacket = ether;

                    return ether;
                case 3:     // RARP响应封包
                    ether = new EthernetPacket(PhysicalAddress.Parse(MakeMACaddr(SourceMAC1.Text, SourceMAC2.Text, SourceMAC3.Text, SourceMAC4.Text, SourceMAC5.Text, SourceMAC6.Text)),
                                               PhysicalAddress.Parse(MakeMACaddr(DestMAC1.Text, DestMAC2.Text, DestMAC3.Text, DestMAC4.Text, DestMAC5.Text, DestMAC6.Text)),
                                               EthernetPacketType.ReverseArp);

                    arp = new ARPPacket(ARPOperation.ReplyReverse,
                                       PhysicalAddress.Parse(MakeMACaddr(DestMAC1.Text, DestMAC2.Text, DestMAC3.Text, DestMAC4.Text, DestMAC5.Text, DestMAC6.Text)),
                                       IPAddress.Parse(MakeIPaddr(DestIP1.Text, DestIP2.Text, DestIP3.Text, DestIP4.Text)),
                                       PhysicalAddress.Parse(MakeMACaddr(SourceMAC1.Text, SourceMAC2.Text, SourceMAC3.Text, SourceMAC4.Text, SourceMAC5.Text, SourceMAC6.Text)),
                                       IPAddress.Parse(MakeIPaddr(SourceIP1.Text, SourceIP2.Text, SourceIP3.Text, SourceIP4.Text)))
                    {
                        HardwareAddressType = LinkLayers.Ethernet,
                        ProtocolAddressType = EthernetPacketType.IpV4
                    };

                    arp.UpdateCalculatedValues();

                    ether.PayloadPacket = arp;
                    arp.ParentPacket = ether;

                    return ether;
                default:
                    OutputBox.AppendText("错误出现在ARP/RARP数据包上，封装数据包失败。\r\n");
                    return null;
            }
        }

        //构建点分法IP地址
        private string MakeIPaddr(string ip1, string ip2, string ip3, string ip4)
        {
            return ip1 + "." + ip2 + "." + ip3 + "." + ip4;
        }

        //构建六段MAC地址
        private string MakeMACaddr(string mac1, string mac2, string mac3, string mac4, string mac5, string mac6)
        {
            return mac1.ToUpper() + "-" + mac2.ToUpper() + "-" + mac3.ToUpper() + "-" + mac4.ToUpper() + "-" + mac5.ToUpper() + "-" + mac6.ToUpper();
        }
    }
}
