using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SharpPcap测试
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.OutputBox = new TextBox();
            this.DeviceList = new ListBox();
            this.DeviceListLabel = new Label();
            this.SplitLine = new Label();
            this.SourceIP1 = new TextBox();
            this.SourceIPDot1 = new Label();
            this.SourceIP2 = new TextBox();
            this.SourceIPDot2 = new Label();
            this.SourceIP4 = new TextBox();
            this.SourceIP3 = new TextBox();
            this.SourceIPDot3 = new Label();
            this.SourceIPGroupBox = new GroupBox();
            this.DestIPGroupBox = new GroupBox();
            this.DestIP1 = new TextBox();
            this.DestIP2 = new TextBox();
            this.DestIP3 = new TextBox();
            this.DestIP4 = new TextBox();
            this.DestIPDot2 = new Label();
            this.DestIPDot3 = new Label();
            this.DestIPDot1 = new Label();
            this.SourceMACGroupBox = new GroupBox();
            this.SourceMAC6 = new TextBox();
            this.SourceMAC5 = new TextBox();
            this.SourceMAC1 = new TextBox();
            this.SourceMAC2 = new TextBox();
            this.SourceMAC3 = new TextBox();
            this.SourceMAC4 = new TextBox();
            this.SourceMACColon2 = new Label();
            this.SourceMACColon3 = new Label();
            this.SourceMACColon1 = new Label();
            this.SourceMACColon4 = new Label();
            this.SourceMACColon5 = new Label();
            this.DestMACGroupBox = new GroupBox();
            this.DestMAC6 = new TextBox();
            this.DestMAC5 = new TextBox();
            this.DestMAC1 = new TextBox();
            this.DestMAC2 = new TextBox();
            this.DestMAC3 = new TextBox();
            this.DestMAC4 = new TextBox();
            this.DestMACColon2 = new Label();
            this.DestMACColon3 = new Label();
            this.DestMACColon1 = new Label();
            this.DestMACColon4 = new Label();
            this.DestMACColon5 = new Label();
            this.NetworkLayerComboBox = new ComboBox();
            this.NetworkLayerLabel = new Label();
            this.TransportLayerLabel = new Label();
            this.TransportLayerComboBox = new ComboBox();
            this.SourcePortLabel = new Label();
            this.SourcePortTextBox = new TextBox();
            this.DestPortTextBox = new TextBox();
            this.DestPortLabel = new Label();
            this.SendPacketButton = new Button();
            this.PayloadTextBox = new TextBox();
            this.PayloadLabel = new Label();
            this.IPv4GroupBox = new GroupBox();
            this.FragmentFlagsTextBox = new TextBox();
            this.FragmentFlagsLabel = new Label();
            this.IdentifierTextbox = new TextBox();
            this.IdentifierLabel = new Label();
            this.TOSTextBox = new TextBox();
            this.TOSLabel = new Label();
            this.FragmentOffsetTextBox = new TextBox();
            this.FragmentOffsetLabel = new Label();
            this.TTLTextBox = new TextBox();
            this.TTLLabel = new Label();
            this.TCPGroupBox = new GroupBox();
            this.UrgPointerTextBox = new TextBox();
            this.UrgPointerLabel = new Label();
            this.WindowSizeTextBox = new TextBox();
            this.WindowSizeLabel = new Label();
            this.AcknowledgmentTextBox = new TextBox();
            this.AcknowledgmentNumberLabel = new Label();
            this.SequenceTextBox = new TextBox();
            this.SequenceNumberLabel = new Label();
            this.TCPFlagsCheckedListBox = new CheckedListBox();
            this.ARPGroupBox = new GroupBox();
            this.ARPOperationComboBox = new ComboBox();
            this.ARPOperationLabel = new Label();
            this.SourceIPGroupBox.SuspendLayout();
            this.DestIPGroupBox.SuspendLayout();
            this.SourceMACGroupBox.SuspendLayout();
            this.DestMACGroupBox.SuspendLayout();
            this.IPv4GroupBox.SuspendLayout();
            this.TCPGroupBox.SuspendLayout();
            this.ARPGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputBox
            // 
            this.OutputBox.BackColor = SystemColors.MenuText;
            this.OutputBox.ForeColor = SystemColors.Window;
            this.OutputBox.Location = new Point(12, 120);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.ScrollBars = ScrollBars.Vertical;
            this.OutputBox.Size = new Size(535, 475);
            this.OutputBox.TabIndex = 0;
            this.OutputBox.TabStop = false;
            // 
            // DeviceList
            // 
            this.DeviceList.Font = new Font("宋体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.DeviceList.FormattingEnabled = true;
            this.DeviceList.HorizontalScrollbar = true;
            this.DeviceList.ItemHeight = 14;
            this.DeviceList.Location = new Point(12, 26);
            this.DeviceList.Name = "DeviceList";
            this.DeviceList.Size = new Size(535, 88);
            this.DeviceList.TabIndex = 1;
            this.DeviceList.TabStop = false;
            this.DeviceList.MouseMove += new MouseEventHandler(this.DeviceList_MouseMove);
            // 
            // DeviceListLabel
            // 
            this.DeviceListLabel.AutoSize = true;
            this.DeviceListLabel.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.DeviceListLabel.Location = new Point(12, 9);
            this.DeviceListLabel.Name = "DeviceListLabel";
            this.DeviceListLabel.Size = new Size(63, 14);
            this.DeviceListLabel.TabIndex = 2;
            this.DeviceListLabel.Text = "设备列表";
            // 
            // SplitLine
            // 
            this.SplitLine.BorderStyle = BorderStyle.Fixed3D;
            this.SplitLine.Location = new Point(558, 9);
            this.SplitLine.Name = "SplitLine";
            this.SplitLine.Size = new Size(2, 586);
            this.SplitLine.TabIndex = 4;
            // 
            // SourceIP1
            // 
            this.SourceIP1.Font = new Font("宋体", 9F);
            this.SourceIP1.Location = new Point(6, 20);
            this.SourceIP1.MaxLength = 3;
            this.SourceIP1.Name = "SourceIP1";
            this.SourceIP1.Size = new Size(24, 21);
            this.SourceIP1.TabIndex = 5;
            this.SourceIP1.Text = "0";
            this.SourceIP1.MouseClick += new MouseEventHandler(this.TextboxMouseClick);
            this.SourceIP1.TextChanged += new EventHandler(this.JumpToNextByteTextbox);
            this.SourceIP1.Enter += new EventHandler(this.TextboxEnter);
            this.SourceIP1.KeyPress += new KeyPressEventHandler(this.DecInputLimit);
            this.SourceIP1.Leave += new EventHandler(this.TextboxLeave);
            // 
            // SourceIPDot1
            // 
            this.SourceIPDot1.AutoSize = true;
            this.SourceIPDot1.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.SourceIPDot1.Location = new Point(30, 27);
            this.SourceIPDot1.Name = "SourceIPDot1";
            this.SourceIPDot1.Size = new Size(14, 14);
            this.SourceIPDot1.TabIndex = 6;
            this.SourceIPDot1.Text = ".";
            // 
            // SourceIP2
            // 
            this.SourceIP2.Font = new Font("宋体", 9F);
            this.SourceIP2.Location = new Point(40, 20);
            this.SourceIP2.MaxLength = 3;
            this.SourceIP2.Name = "SourceIP2";
            this.SourceIP2.Size = new Size(24, 21);
            this.SourceIP2.TabIndex = 7;
            this.SourceIP2.Text = "0";
            this.SourceIP2.MouseClick += new MouseEventHandler(this.TextboxMouseClick);
            this.SourceIP2.TextChanged += new EventHandler(this.JumpToNextByteTextbox);
            this.SourceIP2.Enter += new EventHandler(this.TextboxEnter);
            this.SourceIP2.KeyPress += new KeyPressEventHandler(this.DecInputLimit);
            this.SourceIP2.Leave += new EventHandler(this.TextboxLeave);
            // 
            // SourceIPDot2
            // 
            this.SourceIPDot2.AutoSize = true;
            this.SourceIPDot2.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.SourceIPDot2.Location = new Point(64, 27);
            this.SourceIPDot2.Name = "SourceIPDot2";
            this.SourceIPDot2.Size = new Size(14, 14);
            this.SourceIPDot2.TabIndex = 8;
            this.SourceIPDot2.Text = ".";
            // 
            // SourceIP4
            // 
            this.SourceIP4.Font = new Font("宋体", 9F);
            this.SourceIP4.Location = new Point(107, 20);
            this.SourceIP4.MaxLength = 3;
            this.SourceIP4.Name = "SourceIP4";
            this.SourceIP4.Size = new Size(24, 21);
            this.SourceIP4.TabIndex = 11;
            this.SourceIP4.Text = "0";
            this.SourceIP4.MouseClick += new MouseEventHandler(this.TextboxMouseClick);
            this.SourceIP4.TextChanged += new EventHandler(this.JumpToNextByteTextbox);
            this.SourceIP4.Enter += new EventHandler(this.TextboxEnter);
            this.SourceIP4.KeyPress += new KeyPressEventHandler(this.DecInputLimit);
            this.SourceIP4.Leave += new EventHandler(this.TextboxLeave);
            // 
            // SourceIP3
            // 
            this.SourceIP3.Font = new Font("宋体", 9F);
            this.SourceIP3.Location = new Point(73, 20);
            this.SourceIP3.MaxLength = 3;
            this.SourceIP3.Name = "SourceIP3";
            this.SourceIP3.Size = new Size(24, 21);
            this.SourceIP3.TabIndex = 9;
            this.SourceIP3.Text = "0";
            this.SourceIP3.MouseClick += new MouseEventHandler(this.TextboxMouseClick);
            this.SourceIP3.TextChanged += new EventHandler(this.JumpToNextByteTextbox);
            this.SourceIP3.Enter += new EventHandler(this.TextboxEnter);
            this.SourceIP3.KeyPress += new KeyPressEventHandler(this.DecInputLimit);
            this.SourceIP3.Leave += new EventHandler(this.TextboxLeave);
            // 
            // SourceIPDot3
            // 
            this.SourceIPDot3.AutoSize = true;
            this.SourceIPDot3.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.SourceIPDot3.Location = new Point(97, 27);
            this.SourceIPDot3.Name = "SourceIPDot3";
            this.SourceIPDot3.Size = new Size(14, 14);
            this.SourceIPDot3.TabIndex = 10;
            this.SourceIPDot3.Text = ".";
            // 
            // SourceIPGroupBox
            // 
            this.SourceIPGroupBox.Controls.Add(this.SourceIP1);
            this.SourceIPGroupBox.Controls.Add(this.SourceIP2);
            this.SourceIPGroupBox.Controls.Add(this.SourceIP3);
            this.SourceIPGroupBox.Controls.Add(this.SourceIP4);
            this.SourceIPGroupBox.Controls.Add(this.SourceIPDot2);
            this.SourceIPGroupBox.Controls.Add(this.SourceIPDot3);
            this.SourceIPGroupBox.Controls.Add(this.SourceIPDot1);
            this.SourceIPGroupBox.Font = new Font("黑体", 10.5F);
            this.SourceIPGroupBox.Location = new Point(562, 12);
            this.SourceIPGroupBox.Name = "SourceIPGroupBox";
            this.SourceIPGroupBox.Size = new Size(137, 47);
            this.SourceIPGroupBox.TabIndex = 20;
            this.SourceIPGroupBox.TabStop = false;
            this.SourceIPGroupBox.Text = "源IP";
            // 
            // DestIPGroupBox
            // 
            this.DestIPGroupBox.Controls.Add(this.DestIP1);
            this.DestIPGroupBox.Controls.Add(this.DestIP2);
            this.DestIPGroupBox.Controls.Add(this.DestIP3);
            this.DestIPGroupBox.Controls.Add(this.DestIP4);
            this.DestIPGroupBox.Controls.Add(this.DestIPDot2);
            this.DestIPGroupBox.Controls.Add(this.DestIPDot3);
            this.DestIPGroupBox.Controls.Add(this.DestIPDot1);
            this.DestIPGroupBox.Font = new Font("黑体", 10.5F);
            this.DestIPGroupBox.Location = new Point(562, 67);
            this.DestIPGroupBox.Name = "DestIPGroupBox";
            this.DestIPGroupBox.Size = new Size(137, 47);
            this.DestIPGroupBox.TabIndex = 21;
            this.DestIPGroupBox.TabStop = false;
            this.DestIPGroupBox.Text = "目的IP";
            // 
            // DestIP1
            // 
            this.DestIP1.Font = new Font("宋体", 9F);
            this.DestIP1.Location = new Point(6, 20);
            this.DestIP1.MaxLength = 3;
            this.DestIP1.Name = "DestIP1";
            this.DestIP1.Size = new Size(24, 21);
            this.DestIP1.TabIndex = 5;
            this.DestIP1.Text = "0";
            this.DestIP1.MouseClick += new MouseEventHandler(this.TextboxMouseClick);
            this.DestIP1.TextChanged += new EventHandler(this.JumpToNextByteTextbox);
            this.DestIP1.Enter += new EventHandler(this.TextboxEnter);
            this.DestIP1.KeyPress += new KeyPressEventHandler(this.DecInputLimit);
            this.DestIP1.Leave += new EventHandler(this.TextboxLeave);
            // 
            // DestIP2
            // 
            this.DestIP2.Font = new Font("宋体", 9F);
            this.DestIP2.Location = new Point(40, 20);
            this.DestIP2.MaxLength = 3;
            this.DestIP2.Name = "DestIP2";
            this.DestIP2.Size = new Size(24, 21);
            this.DestIP2.TabIndex = 7;
            this.DestIP2.Text = "0";
            this.DestIP2.MouseClick += new MouseEventHandler(this.TextboxMouseClick);
            this.DestIP2.TextChanged += new EventHandler(this.JumpToNextByteTextbox);
            this.DestIP2.Enter += new EventHandler(this.TextboxEnter);
            this.DestIP2.KeyPress += new KeyPressEventHandler(this.DecInputLimit);
            this.DestIP2.Leave += new EventHandler(this.TextboxLeave);
            // 
            // DestIP3
            // 
            this.DestIP3.Font = new Font("宋体", 9F);
            this.DestIP3.Location = new Point(73, 20);
            this.DestIP3.MaxLength = 3;
            this.DestIP3.Name = "DestIP3";
            this.DestIP3.Size = new Size(24, 21);
            this.DestIP3.TabIndex = 9;
            this.DestIP3.Text = "0";
            this.DestIP3.MouseClick += new MouseEventHandler(this.TextboxMouseClick);
            this.DestIP3.TextChanged += new EventHandler(this.JumpToNextByteTextbox);
            this.DestIP3.Enter += new EventHandler(this.TextboxEnter);
            this.DestIP3.KeyPress += new KeyPressEventHandler(this.DecInputLimit);
            this.DestIP3.Leave += new EventHandler(this.TextboxLeave);
            // 
            // DestIP4
            // 
            this.DestIP4.Font = new Font("宋体", 9F);
            this.DestIP4.Location = new Point(107, 20);
            this.DestIP4.MaxLength = 3;
            this.DestIP4.Name = "DestIP4";
            this.DestIP4.Size = new Size(24, 21);
            this.DestIP4.TabIndex = 11;
            this.DestIP4.Text = "0";
            this.DestIP4.MouseClick += new MouseEventHandler(this.TextboxMouseClick);
            this.DestIP4.TextChanged += new EventHandler(this.JumpToNextByteTextbox);
            this.DestIP4.Enter += new EventHandler(this.TextboxEnter);
            this.DestIP4.KeyPress += new KeyPressEventHandler(this.DecInputLimit);
            this.DestIP4.Leave += new EventHandler(this.TextboxLeave);
            // 
            // DestIPDot2
            // 
            this.DestIPDot2.AutoSize = true;
            this.DestIPDot2.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.DestIPDot2.Location = new Point(64, 27);
            this.DestIPDot2.Name = "DestIPDot2";
            this.DestIPDot2.Size = new Size(14, 14);
            this.DestIPDot2.TabIndex = 8;
            this.DestIPDot2.Text = ".";
            // 
            // DestIPDot3
            // 
            this.DestIPDot3.AutoSize = true;
            this.DestIPDot3.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.DestIPDot3.Location = new Point(97, 27);
            this.DestIPDot3.Name = "DestIPDot3";
            this.DestIPDot3.Size = new Size(14, 14);
            this.DestIPDot3.TabIndex = 10;
            this.DestIPDot3.Text = ".";
            // 
            // DestIPDot1
            // 
            this.DestIPDot1.AutoSize = true;
            this.DestIPDot1.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.DestIPDot1.Location = new Point(30, 27);
            this.DestIPDot1.Name = "DestIPDot1";
            this.DestIPDot1.Size = new Size(14, 14);
            this.DestIPDot1.TabIndex = 6;
            this.DestIPDot1.Text = ".";
            // 
            // SourceMACGroupBox
            // 
            this.SourceMACGroupBox.Controls.Add(this.SourceMAC6);
            this.SourceMACGroupBox.Controls.Add(this.SourceMAC5);
            this.SourceMACGroupBox.Controls.Add(this.SourceMAC1);
            this.SourceMACGroupBox.Controls.Add(this.SourceMAC2);
            this.SourceMACGroupBox.Controls.Add(this.SourceMAC3);
            this.SourceMACGroupBox.Controls.Add(this.SourceMAC4);
            this.SourceMACGroupBox.Controls.Add(this.SourceMACColon2);
            this.SourceMACGroupBox.Controls.Add(this.SourceMACColon3);
            this.SourceMACGroupBox.Controls.Add(this.SourceMACColon1);
            this.SourceMACGroupBox.Controls.Add(this.SourceMACColon4);
            this.SourceMACGroupBox.Controls.Add(this.SourceMACColon5);
            this.SourceMACGroupBox.Font = new Font("黑体", 10.5F);
            this.SourceMACGroupBox.Location = new Point(706, 12);
            this.SourceMACGroupBox.Name = "SourceMACGroupBox";
            this.SourceMACGroupBox.Size = new Size(176, 47);
            this.SourceMACGroupBox.TabIndex = 22;
            this.SourceMACGroupBox.TabStop = false;
            this.SourceMACGroupBox.Text = "源MAC";
            // 
            // SourceMAC6
            // 
            this.SourceMAC6.Font = new Font("宋体", 9F);
            this.SourceMAC6.Location = new Point(151, 20);
            this.SourceMAC6.MaxLength = 2;
            this.SourceMAC6.Name = "SourceMAC6";
            this.SourceMAC6.Size = new Size(18, 21);
            this.SourceMAC6.TabIndex = 15;
            this.SourceMAC6.Text = "00";
            this.SourceMAC6.MouseClick += new MouseEventHandler(this.TextboxMouseClick);
            this.SourceMAC6.TextChanged += new EventHandler(this.JumpToNextMacTextbox);
            this.SourceMAC6.Enter += new EventHandler(this.TextboxEnter);
            this.SourceMAC6.KeyPress += new KeyPressEventHandler(this.HexInputLimit);
            this.SourceMAC6.Leave += new EventHandler(this.TextboxLeave);
            // 
            // SourceMAC5
            // 
            this.SourceMAC5.Font = new Font("宋体", 9F);
            this.SourceMAC5.Location = new Point(122, 20);
            this.SourceMAC5.MaxLength = 2;
            this.SourceMAC5.Name = "SourceMAC5";
            this.SourceMAC5.Size = new Size(18, 21);
            this.SourceMAC5.TabIndex = 13;
            this.SourceMAC5.Text = "00";
            this.SourceMAC5.MouseClick += new MouseEventHandler(this.TextboxMouseClick);
            this.SourceMAC5.TextChanged += new EventHandler(this.JumpToNextMacTextbox);
            this.SourceMAC5.Enter += new EventHandler(this.TextboxEnter);
            this.SourceMAC5.KeyPress += new KeyPressEventHandler(this.HexInputLimit);
            this.SourceMAC5.Leave += new EventHandler(this.TextboxLeave);
            // 
            // SourceMAC1
            // 
            this.SourceMAC1.Font = new Font("宋体", 9F);
            this.SourceMAC1.Location = new Point(6, 20);
            this.SourceMAC1.MaxLength = 2;
            this.SourceMAC1.Name = "SourceMAC1";
            this.SourceMAC1.Size = new Size(18, 21);
            this.SourceMAC1.TabIndex = 5;
            this.SourceMAC1.Text = "00";
            this.SourceMAC1.MouseClick += new MouseEventHandler(this.TextboxMouseClick);
            this.SourceMAC1.TextChanged += new EventHandler(this.JumpToNextMacTextbox);
            this.SourceMAC1.Enter += new EventHandler(this.TextboxEnter);
            this.SourceMAC1.KeyPress += new KeyPressEventHandler(this.HexInputLimit);
            this.SourceMAC1.Leave += new EventHandler(this.TextboxLeave);
            // 
            // SourceMAC2
            // 
            this.SourceMAC2.Font = new Font("宋体", 9F);
            this.SourceMAC2.Location = new Point(35, 20);
            this.SourceMAC2.MaxLength = 2;
            this.SourceMAC2.Name = "SourceMAC2";
            this.SourceMAC2.Size = new Size(18, 21);
            this.SourceMAC2.TabIndex = 7;
            this.SourceMAC2.Text = "00";
            this.SourceMAC2.MouseClick += new MouseEventHandler(this.TextboxMouseClick);
            this.SourceMAC2.TextChanged += new EventHandler(this.JumpToNextMacTextbox);
            this.SourceMAC2.Enter += new EventHandler(this.TextboxEnter);
            this.SourceMAC2.KeyPress += new KeyPressEventHandler(this.HexInputLimit);
            this.SourceMAC2.Leave += new EventHandler(this.TextboxLeave);
            // 
            // SourceMAC3
            // 
            this.SourceMAC3.Font = new Font("宋体", 9F);
            this.SourceMAC3.Location = new Point(64, 20);
            this.SourceMAC3.MaxLength = 2;
            this.SourceMAC3.Name = "SourceMAC3";
            this.SourceMAC3.Size = new Size(18, 21);
            this.SourceMAC3.TabIndex = 9;
            this.SourceMAC3.Text = "00";
            this.SourceMAC3.MouseClick += new MouseEventHandler(this.TextboxMouseClick);
            this.SourceMAC3.TextChanged += new EventHandler(this.JumpToNextMacTextbox);
            this.SourceMAC3.Enter += new EventHandler(this.TextboxEnter);
            this.SourceMAC3.KeyPress += new KeyPressEventHandler(this.HexInputLimit);
            this.SourceMAC3.Leave += new EventHandler(this.TextboxLeave);
            // 
            // SourceMAC4
            // 
            this.SourceMAC4.Font = new Font("宋体", 9F);
            this.SourceMAC4.Location = new Point(93, 20);
            this.SourceMAC4.MaxLength = 2;
            this.SourceMAC4.Name = "SourceMAC4";
            this.SourceMAC4.Size = new Size(18, 21);
            this.SourceMAC4.TabIndex = 11;
            this.SourceMAC4.Text = "00";
            this.SourceMAC4.MouseClick += new MouseEventHandler(this.TextboxMouseClick);
            this.SourceMAC4.TextChanged += new EventHandler(this.JumpToNextMacTextbox);
            this.SourceMAC4.Enter += new EventHandler(this.TextboxEnter);
            this.SourceMAC4.KeyPress += new KeyPressEventHandler(this.HexInputLimit);
            this.SourceMAC4.Leave += new EventHandler(this.TextboxLeave);
            // 
            // SourceMACColon2
            // 
            this.SourceMACColon2.AutoSize = true;
            this.SourceMACColon2.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.SourceMACColon2.Location = new Point(52, 22);
            this.SourceMACColon2.Name = "SourceMACColon2";
            this.SourceMACColon2.Size = new Size(14, 14);
            this.SourceMACColon2.TabIndex = 8;
            this.SourceMACColon2.Text = ":";
            // 
            // SourceMACColon3
            // 
            this.SourceMACColon3.AutoSize = true;
            this.SourceMACColon3.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.SourceMACColon3.Location = new Point(81, 23);
            this.SourceMACColon3.Name = "SourceMACColon3";
            this.SourceMACColon3.Size = new Size(14, 14);
            this.SourceMACColon3.TabIndex = 10;
            this.SourceMACColon3.Text = ":";
            // 
            // SourceMACColon1
            // 
            this.SourceMACColon1.AutoSize = true;
            this.SourceMACColon1.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.SourceMACColon1.Location = new Point(23, 23);
            this.SourceMACColon1.Name = "SourceMACColon1";
            this.SourceMACColon1.Size = new Size(14, 14);
            this.SourceMACColon1.TabIndex = 6;
            this.SourceMACColon1.Text = ":";
            // 
            // SourceMACColon4
            // 
            this.SourceMACColon4.AutoSize = true;
            this.SourceMACColon4.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.SourceMACColon4.Location = new Point(110, 23);
            this.SourceMACColon4.Name = "SourceMACColon4";
            this.SourceMACColon4.Size = new Size(14, 14);
            this.SourceMACColon4.TabIndex = 23;
            this.SourceMACColon4.Text = ":";
            // 
            // SourceMACColon5
            // 
            this.SourceMACColon5.AutoSize = true;
            this.SourceMACColon5.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.SourceMACColon5.Location = new Point(139, 24);
            this.SourceMACColon5.Name = "SourceMACColon5";
            this.SourceMACColon5.Size = new Size(14, 14);
            this.SourceMACColon5.TabIndex = 23;
            this.SourceMACColon5.Text = ":";
            // 
            // DestMACGroupBox
            // 
            this.DestMACGroupBox.Controls.Add(this.DestMAC6);
            this.DestMACGroupBox.Controls.Add(this.DestMAC5);
            this.DestMACGroupBox.Controls.Add(this.DestMAC1);
            this.DestMACGroupBox.Controls.Add(this.DestMAC2);
            this.DestMACGroupBox.Controls.Add(this.DestMAC3);
            this.DestMACGroupBox.Controls.Add(this.DestMAC4);
            this.DestMACGroupBox.Controls.Add(this.DestMACColon2);
            this.DestMACGroupBox.Controls.Add(this.DestMACColon3);
            this.DestMACGroupBox.Controls.Add(this.DestMACColon1);
            this.DestMACGroupBox.Controls.Add(this.DestMACColon4);
            this.DestMACGroupBox.Controls.Add(this.DestMACColon5);
            this.DestMACGroupBox.Font = new Font("黑体", 10.5F);
            this.DestMACGroupBox.Location = new Point(706, 67);
            this.DestMACGroupBox.Name = "DestMACGroupBox";
            this.DestMACGroupBox.Size = new Size(176, 47);
            this.DestMACGroupBox.TabIndex = 23;
            this.DestMACGroupBox.TabStop = false;
            this.DestMACGroupBox.Text = "目的MAC";
            // 
            // DestMAC6
            // 
            this.DestMAC6.Font = new Font("宋体", 9F);
            this.DestMAC6.Location = new Point(151, 20);
            this.DestMAC6.MaxLength = 2;
            this.DestMAC6.Name = "DestMAC6";
            this.DestMAC6.Size = new Size(18, 21);
            this.DestMAC6.TabIndex = 15;
            this.DestMAC6.Text = "00";
            this.DestMAC6.MouseClick += new MouseEventHandler(this.TextboxMouseClick);
            this.DestMAC6.TextChanged += new EventHandler(this.JumpToNextMacTextbox);
            this.DestMAC6.Enter += new EventHandler(this.TextboxEnter);
            this.DestMAC6.KeyPress += new KeyPressEventHandler(this.HexInputLimit);
            this.DestMAC6.Leave += new EventHandler(this.TextboxLeave);
            // 
            // DestMAC5
            // 
            this.DestMAC5.Font = new Font("宋体", 9F);
            this.DestMAC5.Location = new Point(122, 20);
            this.DestMAC5.MaxLength = 2;
            this.DestMAC5.Name = "DestMAC5";
            this.DestMAC5.Size = new Size(18, 21);
            this.DestMAC5.TabIndex = 13;
            this.DestMAC5.Text = "00";
            this.DestMAC5.MouseClick += new MouseEventHandler(this.TextboxMouseClick);
            this.DestMAC5.TextChanged += new EventHandler(this.JumpToNextMacTextbox);
            this.DestMAC5.Enter += new EventHandler(this.TextboxEnter);
            this.DestMAC5.KeyPress += new KeyPressEventHandler(this.HexInputLimit);
            this.DestMAC5.Leave += new EventHandler(this.TextboxLeave);
            // 
            // DestMAC1
            // 
            this.DestMAC1.Font = new Font("宋体", 9F);
            this.DestMAC1.Location = new Point(6, 20);
            this.DestMAC1.MaxLength = 2;
            this.DestMAC1.Name = "DestMAC1";
            this.DestMAC1.Size = new Size(18, 21);
            this.DestMAC1.TabIndex = 5;
            this.DestMAC1.Text = "00";
            this.DestMAC1.MouseClick += new MouseEventHandler(this.TextboxMouseClick);
            this.DestMAC1.TextChanged += new EventHandler(this.JumpToNextMacTextbox);
            this.DestMAC1.Enter += new EventHandler(this.TextboxEnter);
            this.DestMAC1.KeyPress += new KeyPressEventHandler(this.HexInputLimit);
            this.DestMAC1.Leave += new EventHandler(this.TextboxLeave);
            // 
            // DestMAC2
            // 
            this.DestMAC2.Font = new Font("宋体", 9F);
            this.DestMAC2.Location = new Point(35, 20);
            this.DestMAC2.MaxLength = 2;
            this.DestMAC2.Name = "DestMAC2";
            this.DestMAC2.Size = new Size(18, 21);
            this.DestMAC2.TabIndex = 7;
            this.DestMAC2.Text = "00";
            this.DestMAC2.MouseClick += new MouseEventHandler(this.TextboxMouseClick);
            this.DestMAC2.TextChanged += new EventHandler(this.JumpToNextMacTextbox);
            this.DestMAC2.Enter += new EventHandler(this.TextboxEnter);
            this.DestMAC2.KeyPress += new KeyPressEventHandler(this.HexInputLimit);
            this.DestMAC2.Leave += new EventHandler(this.TextboxLeave);
            // 
            // DestMAC3
            // 
            this.DestMAC3.Font = new Font("宋体", 9F);
            this.DestMAC3.Location = new Point(64, 20);
            this.DestMAC3.MaxLength = 2;
            this.DestMAC3.Name = "DestMAC3";
            this.DestMAC3.Size = new Size(18, 21);
            this.DestMAC3.TabIndex = 9;
            this.DestMAC3.Text = "00";
            this.DestMAC3.MouseClick += new MouseEventHandler(this.TextboxMouseClick);
            this.DestMAC3.TextChanged += new EventHandler(this.JumpToNextMacTextbox);
            this.DestMAC3.Enter += new EventHandler(this.TextboxEnter);
            this.DestMAC3.KeyPress += new KeyPressEventHandler(this.HexInputLimit);
            this.DestMAC3.Leave += new EventHandler(this.TextboxLeave);
            // 
            // DestMAC4
            // 
            this.DestMAC4.Font = new Font("宋体", 9F);
            this.DestMAC4.Location = new Point(93, 20);
            this.DestMAC4.MaxLength = 2;
            this.DestMAC4.Name = "DestMAC4";
            this.DestMAC4.Size = new Size(18, 21);
            this.DestMAC4.TabIndex = 11;
            this.DestMAC4.Text = "00";
            this.DestMAC4.MouseClick += new MouseEventHandler(this.TextboxMouseClick);
            this.DestMAC4.TextChanged += new EventHandler(this.JumpToNextMacTextbox);
            this.DestMAC4.Enter += new EventHandler(this.TextboxEnter);
            this.DestMAC4.KeyPress += new KeyPressEventHandler(this.HexInputLimit);
            this.DestMAC4.Leave += new EventHandler(this.TextboxLeave);
            // 
            // DestMACColon2
            // 
            this.DestMACColon2.AutoSize = true;
            this.DestMACColon2.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.DestMACColon2.Location = new Point(52, 22);
            this.DestMACColon2.Name = "DestMACColon2";
            this.DestMACColon2.Size = new Size(14, 14);
            this.DestMACColon2.TabIndex = 8;
            this.DestMACColon2.Text = ":";
            // 
            // DestMACColon3
            // 
            this.DestMACColon3.AutoSize = true;
            this.DestMACColon3.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.DestMACColon3.Location = new Point(81, 23);
            this.DestMACColon3.Name = "DestMACColon3";
            this.DestMACColon3.Size = new Size(14, 14);
            this.DestMACColon3.TabIndex = 10;
            this.DestMACColon3.Text = ":";
            // 
            // DestMACColon1
            // 
            this.DestMACColon1.AutoSize = true;
            this.DestMACColon1.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.DestMACColon1.Location = new Point(23, 23);
            this.DestMACColon1.Name = "DestMACColon1";
            this.DestMACColon1.Size = new Size(14, 14);
            this.DestMACColon1.TabIndex = 6;
            this.DestMACColon1.Text = ":";
            // 
            // DestMACColon4
            // 
            this.DestMACColon4.AutoSize = true;
            this.DestMACColon4.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.DestMACColon4.Location = new Point(110, 23);
            this.DestMACColon4.Name = "DestMACColon4";
            this.DestMACColon4.Size = new Size(14, 14);
            this.DestMACColon4.TabIndex = 23;
            this.DestMACColon4.Text = ":";
            // 
            // DestMACColon5
            // 
            this.DestMACColon5.AutoSize = true;
            this.DestMACColon5.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.DestMACColon5.Location = new Point(139, 24);
            this.DestMACColon5.Name = "DestMACColon5";
            this.DestMACColon5.Size = new Size(14, 14);
            this.DestMACColon5.TabIndex = 23;
            this.DestMACColon5.Text = ":";
            // 
            // NetworkLayerComboBox
            // 
            this.NetworkLayerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.NetworkLayerComboBox.FormattingEnabled = true;
            this.NetworkLayerComboBox.Items.AddRange(new object[] {
            "IPv4",
            "ARP/RARP"});
            this.NetworkLayerComboBox.Location = new Point(649, 126);
            this.NetworkLayerComboBox.Name = "NetworkLayerComboBox";
            this.NetworkLayerComboBox.Size = new Size(81, 20);
            this.NetworkLayerComboBox.TabIndex = 24;
            this.NetworkLayerComboBox.SelectedIndexChanged += new EventHandler(this.NetworkLayerComboBox_SelectedIndexChanged);
            // 
            // NetworkLayerLabel
            // 
            this.NetworkLayerLabel.AutoSize = true;
            this.NetworkLayerLabel.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.NetworkLayerLabel.Location = new Point(562, 129);
            this.NetworkLayerLabel.Name = "NetworkLayerLabel";
            this.NetworkLayerLabel.Size = new Size(91, 14);
            this.NetworkLayerLabel.TabIndex = 25;
            this.NetworkLayerLabel.Text = "网络层协议：";
            // 
            // TransportLayerLabel
            // 
            this.TransportLayerLabel.AutoSize = true;
            this.TransportLayerLabel.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.TransportLayerLabel.Location = new Point(562, 155);
            this.TransportLayerLabel.Name = "TransportLayerLabel";
            this.TransportLayerLabel.Size = new Size(91, 14);
            this.TransportLayerLabel.TabIndex = 26;
            this.TransportLayerLabel.Text = "运输层协议：";
            // 
            // TransportLayerComboBox
            // 
            this.TransportLayerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.TransportLayerComboBox.Enabled = false;
            this.TransportLayerComboBox.FormattingEnabled = true;
            this.TransportLayerComboBox.Items.AddRange(new object[] {
            "TCP",
            "UDP"});
            this.TransportLayerComboBox.Location = new Point(649, 152);
            this.TransportLayerComboBox.Name = "TransportLayerComboBox";
            this.TransportLayerComboBox.Size = new Size(81, 20);
            this.TransportLayerComboBox.TabIndex = 27;
            this.TransportLayerComboBox.SelectedIndexChanged += new EventHandler(this.TransportLayerComboBox_SelectedIndexChanged);
            // 
            // SourcePortLabel
            // 
            this.SourcePortLabel.AutoSize = true;
            this.SourcePortLabel.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.SourcePortLabel.Location = new Point(732, 129);
            this.SourcePortLabel.Name = "SourcePortLabel";
            this.SourcePortLabel.Size = new Size(63, 14);
            this.SourcePortLabel.TabIndex = 28;
            this.SourcePortLabel.Text = "源端口：";
            // 
            // SourcePortTextBox
            // 
            this.SourcePortTextBox.Location = new Point(819, 126);
            this.SourcePortTextBox.MaxLength = 5;
            this.SourcePortTextBox.Name = "SourcePortTextBox";
            this.SourcePortTextBox.Size = new Size(63, 21);
            this.SourcePortTextBox.TabIndex = 29;
            this.SourcePortTextBox.Text = "0";
            this.SourcePortTextBox.TextAlign = HorizontalAlignment.Right;
            this.SourcePortTextBox.MouseClick += new MouseEventHandler(this.TextboxMouseClick);
            this.SourcePortTextBox.TextChanged += new EventHandler(this.JumpToNextWordTextbox);
            this.SourcePortTextBox.Enter += new EventHandler(this.TextboxEnter);
            this.SourcePortTextBox.KeyPress += new KeyPressEventHandler(this.DecInputLimit);
            this.SourcePortTextBox.Leave += new EventHandler(this.TextboxLeave);
            // 
            // DestPortTextBox
            // 
            this.DestPortTextBox.Location = new Point(819, 152);
            this.DestPortTextBox.MaxLength = 5;
            this.DestPortTextBox.Name = "DestPortTextBox";
            this.DestPortTextBox.Size = new Size(63, 21);
            this.DestPortTextBox.TabIndex = 31;
            this.DestPortTextBox.Text = "0";
            this.DestPortTextBox.TextAlign = HorizontalAlignment.Right;
            this.DestPortTextBox.MouseClick += new MouseEventHandler(this.TextboxMouseClick);
            this.DestPortTextBox.TextChanged += new EventHandler(this.JumpToNextWordTextbox);
            this.DestPortTextBox.Enter += new EventHandler(this.TextboxEnter);
            this.DestPortTextBox.KeyPress += new KeyPressEventHandler(this.DecInputLimit);
            this.DestPortTextBox.Leave += new EventHandler(this.TextboxLeave);
            // 
            // DestPortLabel
            // 
            this.DestPortLabel.AutoSize = true;
            this.DestPortLabel.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.DestPortLabel.Location = new Point(732, 155);
            this.DestPortLabel.Name = "DestPortLabel";
            this.DestPortLabel.Size = new Size(77, 14);
            this.DestPortLabel.TabIndex = 30;
            this.DestPortLabel.Text = "目的端口：";
            // 
            // SendPacketButton
            // 
            this.SendPacketButton.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.SendPacketButton.Location = new Point(790, 567);
            this.SendPacketButton.Name = "SendPacketButton";
            this.SendPacketButton.Size = new Size(92, 28);
            this.SendPacketButton.TabIndex = 41;
            this.SendPacketButton.Text = "发送数据包";
            this.SendPacketButton.UseVisualStyleBackColor = true;
            this.SendPacketButton.Click += new EventHandler(this.SendPacketButton_Click);
            // 
            // PayloadTextBox
            // 
            this.PayloadTextBox.ImeMode = ImeMode.Off;
            this.PayloadTextBox.Location = new Point(568, 478);
            this.PayloadTextBox.MaxLength = 1000;
            this.PayloadTextBox.Multiline = true;
            this.PayloadTextBox.Name = "PayloadTextBox";
            this.PayloadTextBox.Size = new Size(314, 83);
            this.PayloadTextBox.TabIndex = 40;
            this.PayloadTextBox.MouseClick += new MouseEventHandler(this.TextboxMouseClick);
            this.PayloadTextBox.Enter += new EventHandler(this.TextboxEnter);
            // 
            // PayloadLabel
            // 
            this.PayloadLabel.AutoSize = true;
            this.PayloadLabel.Font = new Font("黑体", 10.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.PayloadLabel.Location = new Point(568, 461);
            this.PayloadLabel.Name = "PayloadLabel";
            this.PayloadLabel.Size = new Size(77, 14);
            this.PayloadLabel.TabIndex = 33;
            this.PayloadLabel.Text = "数据内容：";
            // 
            // IPv4GroupBox
            // 
            this.IPv4GroupBox.Controls.Add(this.FragmentFlagsTextBox);
            this.IPv4GroupBox.Controls.Add(this.FragmentFlagsLabel);
            this.IPv4GroupBox.Controls.Add(this.IdentifierTextbox);
            this.IPv4GroupBox.Controls.Add(this.IdentifierLabel);
            this.IPv4GroupBox.Controls.Add(this.TOSTextBox);
            this.IPv4GroupBox.Controls.Add(this.TOSLabel);
            this.IPv4GroupBox.Controls.Add(this.FragmentOffsetTextBox);
            this.IPv4GroupBox.Controls.Add(this.FragmentOffsetLabel);
            this.IPv4GroupBox.Controls.Add(this.TTLTextBox);
            this.IPv4GroupBox.Controls.Add(this.TTLLabel);
            this.IPv4GroupBox.Enabled = false;
            this.IPv4GroupBox.Font = new Font("黑体", 10.5F);
            this.IPv4GroupBox.Location = new Point(562, 186);
            this.IPv4GroupBox.Name = "IPv4GroupBox";
            this.IPv4GroupBox.Size = new Size(184, 102);
            this.IPv4GroupBox.TabIndex = 32;
            this.IPv4GroupBox.TabStop = false;
            this.IPv4GroupBox.Text = "IPv4参数设置";
            // 
            // FragmentFlagsTextBox
            // 
            this.FragmentFlagsTextBox.Font = new Font("宋体", 9F);
            this.FragmentFlagsTextBox.Location = new Point(156, 19);
            this.FragmentFlagsTextBox.MaxLength = 5;
            this.FragmentFlagsTextBox.Name = "FragmentFlagsTextBox";
            this.FragmentFlagsTextBox.Size = new Size(18, 21);
            this.FragmentFlagsTextBox.TabIndex = 9;
            this.FragmentFlagsTextBox.Text = "0";
            this.FragmentFlagsTextBox.TextAlign = HorizontalAlignment.Right;
            this.FragmentFlagsTextBox.MouseClick += new MouseEventHandler(this.TextboxMouseClick);
            this.FragmentFlagsTextBox.TextChanged += new EventHandler(this.JumpToNextFragmentFlagsTextbox);
            this.FragmentFlagsTextBox.Enter += new EventHandler(this.TextboxEnter);
            this.FragmentFlagsTextBox.KeyPress += new KeyPressEventHandler(this.DecInputLimit);
            this.FragmentFlagsTextBox.Leave += new EventHandler(this.TextboxLeave);
            // 
            // FragmentFlagsLabel
            // 
            this.FragmentFlagsLabel.AutoSize = true;
            this.FragmentFlagsLabel.Font = new Font("黑体", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.FragmentFlagsLabel.Location = new Point(98, 23);
            this.FragmentFlagsLabel.Name = "FragmentFlagsLabel";
            this.FragmentFlagsLabel.Size = new Size(53, 12);
            this.FragmentFlagsLabel.TabIndex = 41;
            this.FragmentFlagsLabel.Text = "分片标志";
            // 
            // IdentifierTextbox
            // 
            this.IdentifierTextbox.Font = new Font("宋体", 9F);
            this.IdentifierTextbox.Location = new Point(136, 44);
            this.IdentifierTextbox.MaxLength = 5;
            this.IdentifierTextbox.Name = "IdentifierTextbox";
            this.IdentifierTextbox.Size = new Size(38, 21);
            this.IdentifierTextbox.TabIndex = 11;
            this.IdentifierTextbox.Text = "0";
            this.IdentifierTextbox.TextAlign = HorizontalAlignment.Right;
            this.IdentifierTextbox.MouseClick += new MouseEventHandler(this.TextboxMouseClick);
            this.IdentifierTextbox.TextChanged += new EventHandler(this.JumpToNextWordTextbox);
            this.IdentifierTextbox.Enter += new EventHandler(this.TextboxEnter);
            this.IdentifierTextbox.KeyPress += new KeyPressEventHandler(this.DecInputLimit);
            this.IdentifierTextbox.Leave += new EventHandler(this.TextboxLeave);
            // 
            // IdentifierLabel
            // 
            this.IdentifierLabel.AutoSize = true;
            this.IdentifierLabel.Font = new Font("黑体", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.IdentifierLabel.Location = new Point(98, 48);
            this.IdentifierLabel.Name = "IdentifierLabel";
            this.IdentifierLabel.Size = new Size(29, 12);
            this.IdentifierLabel.TabIndex = 39;
            this.IdentifierLabel.Text = "标识";
            // 
            // TOSTextBox
            // 
            this.TOSTextBox.Font = new Font("宋体", 9F);
            this.TOSTextBox.Location = new Point(64, 19);
            this.TOSTextBox.MaxLength = 3;
            this.TOSTextBox.Name = "TOSTextBox";
            this.TOSTextBox.Size = new Size(25, 21);
            this.TOSTextBox.TabIndex = 5;
            this.TOSTextBox.Text = "0";
            this.TOSTextBox.TextAlign = HorizontalAlignment.Right;
            this.TOSTextBox.MouseClick += new MouseEventHandler(this.TextboxMouseClick);
            this.TOSTextBox.TextChanged += new EventHandler(this.JumpToNextByteTextbox);
            this.TOSTextBox.Enter += new EventHandler(this.TextboxEnter);
            this.TOSTextBox.KeyPress += new KeyPressEventHandler(this.DecInputLimit);
            this.TOSTextBox.Leave += new EventHandler(this.TextboxLeave);
            // 
            // TOSLabel
            // 
            this.TOSLabel.AutoSize = true;
            this.TOSLabel.Font = new Font("黑体", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.TOSLabel.Location = new Point(6, 23);
            this.TOSLabel.Name = "TOSLabel";
            this.TOSLabel.Size = new Size(53, 12);
            this.TOSLabel.TabIndex = 37;
            this.TOSLabel.Text = "服务类型";
            // 
            // FragmentOffsetTextBox
            // 
            this.FragmentOffsetTextBox.Font = new Font("宋体", 9F);
            this.FragmentOffsetTextBox.Location = new Point(140, 69);
            this.FragmentOffsetTextBox.MaxLength = 4;
            this.FragmentOffsetTextBox.Name = "FragmentOffsetTextBox";
            this.FragmentOffsetTextBox.Size = new Size(34, 21);
            this.FragmentOffsetTextBox.TabIndex = 13;
            this.FragmentOffsetTextBox.Text = "0";
            this.FragmentOffsetTextBox.TextAlign = HorizontalAlignment.Right;
            this.FragmentOffsetTextBox.MouseClick += new MouseEventHandler(this.TextboxMouseClick);
            this.FragmentOffsetTextBox.TextChanged += new EventHandler(this.JumpToNextFragmentTextbox);
            this.FragmentOffsetTextBox.Enter += new EventHandler(this.TextboxEnter);
            this.FragmentOffsetTextBox.KeyPress += new KeyPressEventHandler(this.DecInputLimit);
            this.FragmentOffsetTextBox.Leave += new EventHandler(this.TextboxLeave);
            // 
            // FragmentOffsetLabel
            // 
            this.FragmentOffsetLabel.AutoSize = true;
            this.FragmentOffsetLabel.Font = new Font("黑体", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.FragmentOffsetLabel.Location = new Point(98, 73);
            this.FragmentOffsetLabel.Name = "FragmentOffsetLabel";
            this.FragmentOffsetLabel.Size = new Size(41, 12);
            this.FragmentOffsetLabel.TabIndex = 35;
            this.FragmentOffsetLabel.Text = "片偏移";
            // 
            // TTLTextBox
            // 
            this.TTLTextBox.Font = new Font("宋体", 9F);
            this.TTLTextBox.Location = new Point(64, 44);
            this.TTLTextBox.MaxLength = 3;
            this.TTLTextBox.Name = "TTLTextBox";
            this.TTLTextBox.Size = new Size(25, 21);
            this.TTLTextBox.TabIndex = 7;
            this.TTLTextBox.Text = "20";
            this.TTLTextBox.TextAlign = HorizontalAlignment.Right;
            this.TTLTextBox.MouseClick += new MouseEventHandler(this.TextboxMouseClick);
            this.TTLTextBox.TextChanged += new EventHandler(this.JumpToNextByteTextbox);
            this.TTLTextBox.Enter += new EventHandler(this.TextboxEnter);
            this.TTLTextBox.KeyPress += new KeyPressEventHandler(this.DecInputLimit);
            this.TTLTextBox.Leave += new EventHandler(this.TextboxLeave);
            // 
            // TTLLabel
            // 
            this.TTLLabel.AutoSize = true;
            this.TTLLabel.Font = new Font("黑体", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.TTLLabel.Location = new Point(6, 48);
            this.TTLLabel.Name = "TTLLabel";
            this.TTLLabel.Size = new Size(53, 12);
            this.TTLLabel.TabIndex = 32;
            this.TTLLabel.Text = "生存时间";
            // 
            // TCPGroupBox
            // 
            this.TCPGroupBox.Controls.Add(this.UrgPointerTextBox);
            this.TCPGroupBox.Controls.Add(this.UrgPointerLabel);
            this.TCPGroupBox.Controls.Add(this.WindowSizeTextBox);
            this.TCPGroupBox.Controls.Add(this.WindowSizeLabel);
            this.TCPGroupBox.Controls.Add(this.AcknowledgmentTextBox);
            this.TCPGroupBox.Controls.Add(this.AcknowledgmentNumberLabel);
            this.TCPGroupBox.Controls.Add(this.SequenceTextBox);
            this.TCPGroupBox.Controls.Add(this.SequenceNumberLabel);
            this.TCPGroupBox.Controls.Add(this.TCPFlagsCheckedListBox);
            this.TCPGroupBox.Enabled = false;
            this.TCPGroupBox.Font = new Font("黑体", 10.5F);
            this.TCPGroupBox.Location = new Point(562, 294);
            this.TCPGroupBox.Name = "TCPGroupBox";
            this.TCPGroupBox.Size = new Size(184, 142);
            this.TCPGroupBox.TabIndex = 33;
            this.TCPGroupBox.TabStop = false;
            this.TCPGroupBox.Text = "TCP参数设置";
            // 
            // UrgPointerTextBox
            // 
            this.UrgPointerTextBox.Font = new Font("宋体", 9F);
            this.UrgPointerTextBox.Location = new Point(140, 106);
            this.UrgPointerTextBox.MaxLength = 5;
            this.UrgPointerTextBox.Name = "UrgPointerTextBox";
            this.UrgPointerTextBox.Size = new Size(38, 21);
            this.UrgPointerTextBox.TabIndex = 4;
            this.UrgPointerTextBox.Text = "0";
            this.UrgPointerTextBox.TextAlign = HorizontalAlignment.Right;
            this.UrgPointerTextBox.MouseClick += new MouseEventHandler(this.TextboxMouseClick);
            this.UrgPointerTextBox.TextChanged += new EventHandler(this.JumpToNextWordTextbox);
            this.UrgPointerTextBox.Enter += new EventHandler(this.TextboxEnter);
            this.UrgPointerTextBox.KeyPress += new KeyPressEventHandler(this.DecInputLimit);
            this.UrgPointerTextBox.Leave += new EventHandler(this.TextboxLeave);
            // 
            // UrgPointerLabel
            // 
            this.UrgPointerLabel.AutoSize = true;
            this.UrgPointerLabel.Font = new Font("黑体", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.UrgPointerLabel.Location = new Point(66, 110);
            this.UrgPointerLabel.Name = "UrgPointerLabel";
            this.UrgPointerLabel.Size = new Size(53, 12);
            this.UrgPointerLabel.TabIndex = 40;
            this.UrgPointerLabel.Text = "紧急指针";
            // 
            // WindowSizeTextBox
            // 
            this.WindowSizeTextBox.Font = new Font("宋体", 9F);
            this.WindowSizeTextBox.Location = new Point(140, 78);
            this.WindowSizeTextBox.MaxLength = 5;
            this.WindowSizeTextBox.Name = "WindowSizeTextBox";
            this.WindowSizeTextBox.Size = new Size(38, 21);
            this.WindowSizeTextBox.TabIndex = 3;
            this.WindowSizeTextBox.Text = "0";
            this.WindowSizeTextBox.TextAlign = HorizontalAlignment.Right;
            this.WindowSizeTextBox.MouseClick += new MouseEventHandler(this.TextboxMouseClick);
            this.WindowSizeTextBox.TextChanged += new EventHandler(this.JumpToNextWordTextbox);
            this.WindowSizeTextBox.Enter += new EventHandler(this.TextboxEnter);
            this.WindowSizeTextBox.KeyPress += new KeyPressEventHandler(this.DecInputLimit);
            this.WindowSizeTextBox.Leave += new EventHandler(this.TextboxLeave);
            // 
            // WindowSizeLabel
            // 
            this.WindowSizeLabel.AutoSize = true;
            this.WindowSizeLabel.Font = new Font("黑体", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.WindowSizeLabel.Location = new Point(66, 82);
            this.WindowSizeLabel.Name = "WindowSizeLabel";
            this.WindowSizeLabel.Size = new Size(53, 12);
            this.WindowSizeLabel.TabIndex = 38;
            this.WindowSizeLabel.Text = "窗口大小";
            // 
            // AcknowledgmentTextBox
            // 
            this.AcknowledgmentTextBox.Font = new Font("宋体", 9F);
            this.AcknowledgmentTextBox.Location = new Point(108, 50);
            this.AcknowledgmentTextBox.MaxLength = 10;
            this.AcknowledgmentTextBox.Name = "AcknowledgmentTextBox";
            this.AcknowledgmentTextBox.Size = new Size(70, 21);
            this.AcknowledgmentTextBox.TabIndex = 2;
            this.AcknowledgmentTextBox.Text = "0";
            this.AcknowledgmentTextBox.TextAlign = HorizontalAlignment.Right;
            this.AcknowledgmentTextBox.MouseClick += new MouseEventHandler(this.TextboxMouseClick);
            this.AcknowledgmentTextBox.TextChanged += new EventHandler(this.JumpToNextDWordTextbox);
            this.AcknowledgmentTextBox.Enter += new EventHandler(this.TextboxEnter);
            this.AcknowledgmentTextBox.KeyPress += new KeyPressEventHandler(this.DecInputLimit);
            this.AcknowledgmentTextBox.Leave += new EventHandler(this.TextboxLeave);
            // 
            // AcknowledgmentNumberLabel
            // 
            this.AcknowledgmentNumberLabel.AutoSize = true;
            this.AcknowledgmentNumberLabel.Font = new Font("黑体", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.AcknowledgmentNumberLabel.Location = new Point(66, 54);
            this.AcknowledgmentNumberLabel.Name = "AcknowledgmentNumberLabel";
            this.AcknowledgmentNumberLabel.Size = new Size(41, 12);
            this.AcknowledgmentNumberLabel.TabIndex = 36;
            this.AcknowledgmentNumberLabel.Text = "确认号";
            // 
            // SequenceTextBox
            // 
            this.SequenceTextBox.Font = new Font("宋体", 9F);
            this.SequenceTextBox.Location = new Point(108, 22);
            this.SequenceTextBox.MaxLength = 10;
            this.SequenceTextBox.Name = "SequenceTextBox";
            this.SequenceTextBox.Size = new Size(70, 21);
            this.SequenceTextBox.TabIndex = 1;
            this.SequenceTextBox.Text = "0";
            this.SequenceTextBox.TextAlign = HorizontalAlignment.Right;
            this.SequenceTextBox.MouseClick += new MouseEventHandler(this.TextboxMouseClick);
            this.SequenceTextBox.TextChanged += new EventHandler(this.JumpToNextDWordTextbox);
            this.SequenceTextBox.Enter += new EventHandler(this.TextboxEnter);
            this.SequenceTextBox.KeyPress += new KeyPressEventHandler(this.DecInputLimit);
            this.SequenceTextBox.Leave += new EventHandler(this.TextboxLeave);
            // 
            // SequenceNumberLabel
            // 
            this.SequenceNumberLabel.AutoSize = true;
            this.SequenceNumberLabel.Font = new Font("黑体", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));
            this.SequenceNumberLabel.Location = new Point(66, 26);
            this.SequenceNumberLabel.Name = "SequenceNumberLabel";
            this.SequenceNumberLabel.Size = new Size(29, 12);
            this.SequenceNumberLabel.TabIndex = 34;
            this.SequenceNumberLabel.Text = "序号";
            // 
            // TCPFlagsCheckedListBox
            // 
            this.TCPFlagsCheckedListBox.FormattingEnabled = true;
            this.TCPFlagsCheckedListBox.Items.AddRange(new object[] {
            "URG",
            "ACK",
            "PSH",
            "RST",
            "SYN",
            "FIN"});
            this.TCPFlagsCheckedListBox.Location = new Point(8, 22);
            this.TCPFlagsCheckedListBox.Name = "TCPFlagsCheckedListBox";
            this.TCPFlagsCheckedListBox.Size = new Size(51, 112);
            this.TCPFlagsCheckedListBox.TabIndex = 0;
            // 
            // ARPGroupBox
            // 
            this.ARPGroupBox.Controls.Add(this.ARPOperationComboBox);
            this.ARPGroupBox.Controls.Add(this.ARPOperationLabel);
            this.ARPGroupBox.Enabled = false;
            this.ARPGroupBox.Font = new Font("黑体", 10.5F);
            this.ARPGroupBox.Location = new Point(752, 186);
            this.ARPGroupBox.Name = "ARPGroupBox";
            this.ARPGroupBox.Size = new Size(130, 46);
            this.ARPGroupBox.TabIndex = 34;
            this.ARPGroupBox.TabStop = false;
            this.ARPGroupBox.Text = "ARP参数设置";
            // 
            // ARPOperationComboBox
            // 
            this.ARPOperationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ARPOperationComboBox.Font = new Font("宋体", 8.8F);
            this.ARPOperationComboBox.FormattingEnabled = true;
            this.ARPOperationComboBox.Items.AddRange(new object[] {
            "ARP请求",
            "ARP响应",
            "RARP请求",
            "RARP响应"});
            this.ARPOperationComboBox.Location = new Point(54, 18);
            this.ARPOperationComboBox.Name = "ARPOperationComboBox";
            this.ARPOperationComboBox.Size = new Size(71, 20);
            this.ARPOperationComboBox.TabIndex = 0;
            // 
            // ARPOperationLabel
            // 
            this.ARPOperationLabel.AutoSize = true;
            this.ARPOperationLabel.Font = new Font("黑体", 9F);
            this.ARPOperationLabel.Location = new Point(2, 23);
            this.ARPOperationLabel.Name = "ARPOperationLabel";
            this.ARPOperationLabel.Size = new Size(53, 12);
            this.ARPOperationLabel.TabIndex = 27;
            this.ARPOperationLabel.Text = "操作类型";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(6F, 12F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(893, 607);
            this.Controls.Add(this.ARPGroupBox);
            this.Controls.Add(this.TCPGroupBox);
            this.Controls.Add(this.IPv4GroupBox);
            this.Controls.Add(this.PayloadTextBox);
            this.Controls.Add(this.PayloadLabel);
            this.Controls.Add(this.SendPacketButton);
            this.Controls.Add(this.DestPortTextBox);
            this.Controls.Add(this.DestPortLabel);
            this.Controls.Add(this.SourcePortTextBox);
            this.Controls.Add(this.SourcePortLabel);
            this.Controls.Add(this.TransportLayerComboBox);
            this.Controls.Add(this.TransportLayerLabel);
            this.Controls.Add(this.NetworkLayerComboBox);
            this.Controls.Add(this.DestMACGroupBox);
            this.Controls.Add(this.SourceMACGroupBox);
            this.Controls.Add(this.DestIPGroupBox);
            this.Controls.Add(this.SourceIPGroupBox);
            this.Controls.Add(this.SplitLine);
            this.Controls.Add(this.DeviceListLabel);
            this.Controls.Add(this.DeviceList);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.NetworkLayerLabel);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "SharpPcap网络发包";
            this.SourceIPGroupBox.ResumeLayout(false);
            this.SourceIPGroupBox.PerformLayout();
            this.DestIPGroupBox.ResumeLayout(false);
            this.DestIPGroupBox.PerformLayout();
            this.SourceMACGroupBox.ResumeLayout(false);
            this.SourceMACGroupBox.PerformLayout();
            this.DestMACGroupBox.ResumeLayout(false);
            this.DestMACGroupBox.PerformLayout();
            this.IPv4GroupBox.ResumeLayout(false);
            this.IPv4GroupBox.PerformLayout();
            this.TCPGroupBox.ResumeLayout(false);
            this.TCPGroupBox.PerformLayout();
            this.ARPGroupBox.ResumeLayout(false);
            this.ARPGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox OutputBox;
        private ListBox DeviceList;
        private Label DeviceListLabel;
        private Label SplitLine;
        private TextBox SourceIP1;
        private Label SourceIPDot1;
        private TextBox SourceIP2;
        private Label SourceIPDot2;
        private TextBox SourceIP4;
        private TextBox SourceIP3;
        private Label SourceIPDot3;
        private GroupBox SourceIPGroupBox;
        private GroupBox DestIPGroupBox;
        private TextBox DestIP1;
        private TextBox DestIP2;
        private TextBox DestIP3;
        private TextBox DestIP4;
        private Label DestIPDot2;
        private Label DestIPDot3;
        private Label DestIPDot1;
        private GroupBox SourceMACGroupBox;
        private TextBox SourceMAC6;
        private TextBox SourceMAC5;
        private TextBox SourceMAC1;
        private TextBox SourceMAC2;
        private TextBox SourceMAC3;
        private TextBox SourceMAC4;
        private Label SourceMACColon2;
        private Label SourceMACColon3;
        private Label SourceMACColon1;
        private Label SourceMACColon4;
        private Label SourceMACColon5;
        private GroupBox DestMACGroupBox;
        private TextBox DestMAC6;
        private TextBox DestMAC5;
        private TextBox DestMAC1;
        private TextBox DestMAC2;
        private TextBox DestMAC3;
        private TextBox DestMAC4;
        private Label DestMACColon2;
        private Label DestMACColon3;
        private Label DestMACColon1;
        private Label DestMACColon4;
        private Label DestMACColon5;
        private ComboBox NetworkLayerComboBox;
        private Label NetworkLayerLabel;
        private Label TransportLayerLabel;
        private ComboBox TransportLayerComboBox;
        private Label SourcePortLabel;
        private TextBox SourcePortTextBox;
        private TextBox DestPortTextBox;
        private Label DestPortLabel;
        private Button SendPacketButton;
        private TextBox PayloadTextBox;
        private Label PayloadLabel;
        private GroupBox IPv4GroupBox;
        private TextBox TTLTextBox;
        private Label TTLLabel;
        private TextBox FragmentOffsetTextBox;
        private Label FragmentOffsetLabel;
        private TextBox TOSTextBox;
        private Label TOSLabel;
        private TextBox IdentifierTextbox;
        private Label IdentifierLabel;
        private TextBox FragmentFlagsTextBox;
        private Label FragmentFlagsLabel;
        private GroupBox TCPGroupBox;
        private CheckedListBox TCPFlagsCheckedListBox;
        private TextBox UrgPointerTextBox;
        private Label UrgPointerLabel;
        private TextBox WindowSizeTextBox;
        private Label WindowSizeLabel;
        private TextBox AcknowledgmentTextBox;
        private Label AcknowledgmentNumberLabel;
        private TextBox SequenceTextBox;
        private Label SequenceNumberLabel;
        private GroupBox ARPGroupBox;
        private ComboBox ARPOperationComboBox;
        private Label ARPOperationLabel;
    }
}

