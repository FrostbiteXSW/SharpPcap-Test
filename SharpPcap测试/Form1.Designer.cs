namespace SharpPcap测试
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.DeviceList = new System.Windows.Forms.ListBox();
            this.DeviceListLabel = new System.Windows.Forms.Label();
            this.SplitLine = new System.Windows.Forms.Label();
            this.SourceIP1 = new System.Windows.Forms.TextBox();
            this.SourceIPDot1 = new System.Windows.Forms.Label();
            this.SourceIP2 = new System.Windows.Forms.TextBox();
            this.SourceIPDot2 = new System.Windows.Forms.Label();
            this.SourceIP4 = new System.Windows.Forms.TextBox();
            this.SourceIP3 = new System.Windows.Forms.TextBox();
            this.SourceIPDot3 = new System.Windows.Forms.Label();
            this.SourceIPGroupBox = new System.Windows.Forms.GroupBox();
            this.DestIPGroupBox = new System.Windows.Forms.GroupBox();
            this.DestIP1 = new System.Windows.Forms.TextBox();
            this.DestIP2 = new System.Windows.Forms.TextBox();
            this.DestIP3 = new System.Windows.Forms.TextBox();
            this.DestIP4 = new System.Windows.Forms.TextBox();
            this.DestIPDot2 = new System.Windows.Forms.Label();
            this.DestIPDot3 = new System.Windows.Forms.Label();
            this.DestIPDot1 = new System.Windows.Forms.Label();
            this.SourceMACGroupBox = new System.Windows.Forms.GroupBox();
            this.SourceMAC6 = new System.Windows.Forms.TextBox();
            this.SourceMAC5 = new System.Windows.Forms.TextBox();
            this.SourceMAC1 = new System.Windows.Forms.TextBox();
            this.SourceMAC2 = new System.Windows.Forms.TextBox();
            this.SourceMAC3 = new System.Windows.Forms.TextBox();
            this.SourceMAC4 = new System.Windows.Forms.TextBox();
            this.SourceMACColon2 = new System.Windows.Forms.Label();
            this.SourceMACColon3 = new System.Windows.Forms.Label();
            this.SourceMACColon1 = new System.Windows.Forms.Label();
            this.SourceMACColon4 = new System.Windows.Forms.Label();
            this.SourceMACColon5 = new System.Windows.Forms.Label();
            this.DestMACGroupBox = new System.Windows.Forms.GroupBox();
            this.DestMAC6 = new System.Windows.Forms.TextBox();
            this.DestMAC5 = new System.Windows.Forms.TextBox();
            this.DestMAC1 = new System.Windows.Forms.TextBox();
            this.DestMAC2 = new System.Windows.Forms.TextBox();
            this.DestMAC3 = new System.Windows.Forms.TextBox();
            this.DestMAC4 = new System.Windows.Forms.TextBox();
            this.DestMACColon2 = new System.Windows.Forms.Label();
            this.DestMACColon3 = new System.Windows.Forms.Label();
            this.DestMACColon1 = new System.Windows.Forms.Label();
            this.DestMACColon4 = new System.Windows.Forms.Label();
            this.DestMACColon5 = new System.Windows.Forms.Label();
            this.NetworkLayerComboBox = new System.Windows.Forms.ComboBox();
            this.NetworkLayerLabel = new System.Windows.Forms.Label();
            this.TransportLayerLabel = new System.Windows.Forms.Label();
            this.TransportLayerComboBox = new System.Windows.Forms.ComboBox();
            this.SourcePortLabel = new System.Windows.Forms.Label();
            this.SourcePortTextBox = new System.Windows.Forms.TextBox();
            this.DestPortTextBox = new System.Windows.Forms.TextBox();
            this.DestPortLabel = new System.Windows.Forms.Label();
            this.SendPacketButton = new System.Windows.Forms.Button();
            this.PayloadTextBox = new System.Windows.Forms.TextBox();
            this.PayloadLabel = new System.Windows.Forms.Label();
            this.IPv4GroupBox = new System.Windows.Forms.GroupBox();
            this.FragmentFlagsTextBox = new System.Windows.Forms.TextBox();
            this.FragmentFlagsLabel = new System.Windows.Forms.Label();
            this.IdentifierTextbox = new System.Windows.Forms.TextBox();
            this.IdentifierLabel = new System.Windows.Forms.Label();
            this.TOSTextBox = new System.Windows.Forms.TextBox();
            this.TOSLabel = new System.Windows.Forms.Label();
            this.FragmentOffsetTextBox = new System.Windows.Forms.TextBox();
            this.FragmentOffsetLabel = new System.Windows.Forms.Label();
            this.TTLTextBox = new System.Windows.Forms.TextBox();
            this.TTLLabel = new System.Windows.Forms.Label();
            this.TCPGroupBox = new System.Windows.Forms.GroupBox();
            this.UrgPointerTextBox = new System.Windows.Forms.TextBox();
            this.UrgPointerLabel = new System.Windows.Forms.Label();
            this.WindowSizeTextBox = new System.Windows.Forms.TextBox();
            this.WindowSizeLabel = new System.Windows.Forms.Label();
            this.AcknowledgmentTextBox = new System.Windows.Forms.TextBox();
            this.AcknowledgmentNumberLabel = new System.Windows.Forms.Label();
            this.SequenceTextBox = new System.Windows.Forms.TextBox();
            this.SequenceNumberLabel = new System.Windows.Forms.Label();
            this.TCPFlagsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.ARPGroupBox = new System.Windows.Forms.GroupBox();
            this.ARPOperationComboBox = new System.Windows.Forms.ComboBox();
            this.ARPOperationLabel = new System.Windows.Forms.Label();
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
            this.OutputBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.OutputBox.ForeColor = System.Drawing.SystemColors.Window;
            this.OutputBox.Location = new System.Drawing.Point(12, 120);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputBox.Size = new System.Drawing.Size(535, 475);
            this.OutputBox.TabIndex = 0;
            this.OutputBox.TabStop = false;
            // 
            // DeviceList
            // 
            this.DeviceList.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeviceList.FormattingEnabled = true;
            this.DeviceList.HorizontalScrollbar = true;
            this.DeviceList.ItemHeight = 14;
            this.DeviceList.Location = new System.Drawing.Point(12, 26);
            this.DeviceList.Name = "DeviceList";
            this.DeviceList.Size = new System.Drawing.Size(535, 88);
            this.DeviceList.TabIndex = 1;
            this.DeviceList.TabStop = false;
            this.DeviceList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DeviceList_MouseMove);
            // 
            // DeviceListLabel
            // 
            this.DeviceListLabel.AutoSize = true;
            this.DeviceListLabel.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeviceListLabel.Location = new System.Drawing.Point(12, 9);
            this.DeviceListLabel.Name = "DeviceListLabel";
            this.DeviceListLabel.Size = new System.Drawing.Size(63, 14);
            this.DeviceListLabel.TabIndex = 2;
            this.DeviceListLabel.Text = "设备列表";
            // 
            // SplitLine
            // 
            this.SplitLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SplitLine.Location = new System.Drawing.Point(558, 9);
            this.SplitLine.Name = "SplitLine";
            this.SplitLine.Size = new System.Drawing.Size(2, 586);
            this.SplitLine.TabIndex = 4;
            // 
            // SourceIP1
            // 
            this.SourceIP1.Font = new System.Drawing.Font("宋体", 9F);
            this.SourceIP1.Location = new System.Drawing.Point(6, 20);
            this.SourceIP1.MaxLength = 3;
            this.SourceIP1.Name = "SourceIP1";
            this.SourceIP1.Size = new System.Drawing.Size(24, 21);
            this.SourceIP1.TabIndex = 5;
            this.SourceIP1.Text = "0";
            this.SourceIP1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxMouseClick);
            this.SourceIP1.TextChanged += new System.EventHandler(this.JumpToNextByteTextbox);
            this.SourceIP1.Enter += new System.EventHandler(this.TextboxEnter);
            this.SourceIP1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInputLimit);
            this.SourceIP1.Leave += new System.EventHandler(this.TextboxLeave);
            // 
            // SourceIPDot1
            // 
            this.SourceIPDot1.AutoSize = true;
            this.SourceIPDot1.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SourceIPDot1.Location = new System.Drawing.Point(30, 27);
            this.SourceIPDot1.Name = "SourceIPDot1";
            this.SourceIPDot1.Size = new System.Drawing.Size(14, 14);
            this.SourceIPDot1.TabIndex = 6;
            this.SourceIPDot1.Text = ".";
            // 
            // SourceIP2
            // 
            this.SourceIP2.Font = new System.Drawing.Font("宋体", 9F);
            this.SourceIP2.Location = new System.Drawing.Point(40, 20);
            this.SourceIP2.MaxLength = 3;
            this.SourceIP2.Name = "SourceIP2";
            this.SourceIP2.Size = new System.Drawing.Size(24, 21);
            this.SourceIP2.TabIndex = 7;
            this.SourceIP2.Text = "0";
            this.SourceIP2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxMouseClick);
            this.SourceIP2.TextChanged += new System.EventHandler(this.JumpToNextByteTextbox);
            this.SourceIP2.Enter += new System.EventHandler(this.TextboxEnter);
            this.SourceIP2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInputLimit);
            this.SourceIP2.Leave += new System.EventHandler(this.TextboxLeave);
            // 
            // SourceIPDot2
            // 
            this.SourceIPDot2.AutoSize = true;
            this.SourceIPDot2.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SourceIPDot2.Location = new System.Drawing.Point(64, 27);
            this.SourceIPDot2.Name = "SourceIPDot2";
            this.SourceIPDot2.Size = new System.Drawing.Size(14, 14);
            this.SourceIPDot2.TabIndex = 8;
            this.SourceIPDot2.Text = ".";
            // 
            // SourceIP4
            // 
            this.SourceIP4.Font = new System.Drawing.Font("宋体", 9F);
            this.SourceIP4.Location = new System.Drawing.Point(107, 20);
            this.SourceIP4.MaxLength = 3;
            this.SourceIP4.Name = "SourceIP4";
            this.SourceIP4.Size = new System.Drawing.Size(24, 21);
            this.SourceIP4.TabIndex = 11;
            this.SourceIP4.Text = "0";
            this.SourceIP4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxMouseClick);
            this.SourceIP4.TextChanged += new System.EventHandler(this.JumpToNextByteTextbox);
            this.SourceIP4.Enter += new System.EventHandler(this.TextboxEnter);
            this.SourceIP4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInputLimit);
            this.SourceIP4.Leave += new System.EventHandler(this.TextboxLeave);
            // 
            // SourceIP3
            // 
            this.SourceIP3.Font = new System.Drawing.Font("宋体", 9F);
            this.SourceIP3.Location = new System.Drawing.Point(73, 20);
            this.SourceIP3.MaxLength = 3;
            this.SourceIP3.Name = "SourceIP3";
            this.SourceIP3.Size = new System.Drawing.Size(24, 21);
            this.SourceIP3.TabIndex = 9;
            this.SourceIP3.Text = "0";
            this.SourceIP3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxMouseClick);
            this.SourceIP3.TextChanged += new System.EventHandler(this.JumpToNextByteTextbox);
            this.SourceIP3.Enter += new System.EventHandler(this.TextboxEnter);
            this.SourceIP3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInputLimit);
            this.SourceIP3.Leave += new System.EventHandler(this.TextboxLeave);
            // 
            // SourceIPDot3
            // 
            this.SourceIPDot3.AutoSize = true;
            this.SourceIPDot3.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SourceIPDot3.Location = new System.Drawing.Point(97, 27);
            this.SourceIPDot3.Name = "SourceIPDot3";
            this.SourceIPDot3.Size = new System.Drawing.Size(14, 14);
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
            this.SourceIPGroupBox.Font = new System.Drawing.Font("黑体", 10.5F);
            this.SourceIPGroupBox.Location = new System.Drawing.Point(562, 12);
            this.SourceIPGroupBox.Name = "SourceIPGroupBox";
            this.SourceIPGroupBox.Size = new System.Drawing.Size(137, 47);
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
            this.DestIPGroupBox.Font = new System.Drawing.Font("黑体", 10.5F);
            this.DestIPGroupBox.Location = new System.Drawing.Point(562, 67);
            this.DestIPGroupBox.Name = "DestIPGroupBox";
            this.DestIPGroupBox.Size = new System.Drawing.Size(137, 47);
            this.DestIPGroupBox.TabIndex = 21;
            this.DestIPGroupBox.TabStop = false;
            this.DestIPGroupBox.Text = "目的IP";
            // 
            // DestIP1
            // 
            this.DestIP1.Font = new System.Drawing.Font("宋体", 9F);
            this.DestIP1.Location = new System.Drawing.Point(6, 20);
            this.DestIP1.MaxLength = 3;
            this.DestIP1.Name = "DestIP1";
            this.DestIP1.Size = new System.Drawing.Size(24, 21);
            this.DestIP1.TabIndex = 5;
            this.DestIP1.Text = "0";
            this.DestIP1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxMouseClick);
            this.DestIP1.TextChanged += new System.EventHandler(this.JumpToNextByteTextbox);
            this.DestIP1.Enter += new System.EventHandler(this.TextboxEnter);
            this.DestIP1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInputLimit);
            this.DestIP1.Leave += new System.EventHandler(this.TextboxLeave);
            // 
            // DestIP2
            // 
            this.DestIP2.Font = new System.Drawing.Font("宋体", 9F);
            this.DestIP2.Location = new System.Drawing.Point(40, 20);
            this.DestIP2.MaxLength = 3;
            this.DestIP2.Name = "DestIP2";
            this.DestIP2.Size = new System.Drawing.Size(24, 21);
            this.DestIP2.TabIndex = 7;
            this.DestIP2.Text = "0";
            this.DestIP2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxMouseClick);
            this.DestIP2.TextChanged += new System.EventHandler(this.JumpToNextByteTextbox);
            this.DestIP2.Enter += new System.EventHandler(this.TextboxEnter);
            this.DestIP2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInputLimit);
            this.DestIP2.Leave += new System.EventHandler(this.TextboxLeave);
            // 
            // DestIP3
            // 
            this.DestIP3.Font = new System.Drawing.Font("宋体", 9F);
            this.DestIP3.Location = new System.Drawing.Point(73, 20);
            this.DestIP3.MaxLength = 3;
            this.DestIP3.Name = "DestIP3";
            this.DestIP3.Size = new System.Drawing.Size(24, 21);
            this.DestIP3.TabIndex = 9;
            this.DestIP3.Text = "0";
            this.DestIP3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxMouseClick);
            this.DestIP3.TextChanged += new System.EventHandler(this.JumpToNextByteTextbox);
            this.DestIP3.Enter += new System.EventHandler(this.TextboxEnter);
            this.DestIP3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInputLimit);
            this.DestIP3.Leave += new System.EventHandler(this.TextboxLeave);
            // 
            // DestIP4
            // 
            this.DestIP4.Font = new System.Drawing.Font("宋体", 9F);
            this.DestIP4.Location = new System.Drawing.Point(107, 20);
            this.DestIP4.MaxLength = 3;
            this.DestIP4.Name = "DestIP4";
            this.DestIP4.Size = new System.Drawing.Size(24, 21);
            this.DestIP4.TabIndex = 11;
            this.DestIP4.Text = "0";
            this.DestIP4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxMouseClick);
            this.DestIP4.TextChanged += new System.EventHandler(this.JumpToNextByteTextbox);
            this.DestIP4.Enter += new System.EventHandler(this.TextboxEnter);
            this.DestIP4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInputLimit);
            this.DestIP4.Leave += new System.EventHandler(this.TextboxLeave);
            // 
            // DestIPDot2
            // 
            this.DestIPDot2.AutoSize = true;
            this.DestIPDot2.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DestIPDot2.Location = new System.Drawing.Point(64, 27);
            this.DestIPDot2.Name = "DestIPDot2";
            this.DestIPDot2.Size = new System.Drawing.Size(14, 14);
            this.DestIPDot2.TabIndex = 8;
            this.DestIPDot2.Text = ".";
            // 
            // DestIPDot3
            // 
            this.DestIPDot3.AutoSize = true;
            this.DestIPDot3.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DestIPDot3.Location = new System.Drawing.Point(97, 27);
            this.DestIPDot3.Name = "DestIPDot3";
            this.DestIPDot3.Size = new System.Drawing.Size(14, 14);
            this.DestIPDot3.TabIndex = 10;
            this.DestIPDot3.Text = ".";
            // 
            // DestIPDot1
            // 
            this.DestIPDot1.AutoSize = true;
            this.DestIPDot1.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DestIPDot1.Location = new System.Drawing.Point(30, 27);
            this.DestIPDot1.Name = "DestIPDot1";
            this.DestIPDot1.Size = new System.Drawing.Size(14, 14);
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
            this.SourceMACGroupBox.Font = new System.Drawing.Font("黑体", 10.5F);
            this.SourceMACGroupBox.Location = new System.Drawing.Point(706, 12);
            this.SourceMACGroupBox.Name = "SourceMACGroupBox";
            this.SourceMACGroupBox.Size = new System.Drawing.Size(176, 47);
            this.SourceMACGroupBox.TabIndex = 22;
            this.SourceMACGroupBox.TabStop = false;
            this.SourceMACGroupBox.Text = "源MAC";
            // 
            // SourceMAC6
            // 
            this.SourceMAC6.Font = new System.Drawing.Font("宋体", 9F);
            this.SourceMAC6.Location = new System.Drawing.Point(151, 20);
            this.SourceMAC6.MaxLength = 2;
            this.SourceMAC6.Name = "SourceMAC6";
            this.SourceMAC6.Size = new System.Drawing.Size(18, 21);
            this.SourceMAC6.TabIndex = 15;
            this.SourceMAC6.Text = "00";
            this.SourceMAC6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxMouseClick);
            this.SourceMAC6.TextChanged += new System.EventHandler(this.JumpToNextMACTextbox);
            this.SourceMAC6.Enter += new System.EventHandler(this.TextboxEnter);
            this.SourceMAC6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexInputLimit);
            this.SourceMAC6.Leave += new System.EventHandler(this.TextboxLeave);
            // 
            // SourceMAC5
            // 
            this.SourceMAC5.Font = new System.Drawing.Font("宋体", 9F);
            this.SourceMAC5.Location = new System.Drawing.Point(122, 20);
            this.SourceMAC5.MaxLength = 2;
            this.SourceMAC5.Name = "SourceMAC5";
            this.SourceMAC5.Size = new System.Drawing.Size(18, 21);
            this.SourceMAC5.TabIndex = 13;
            this.SourceMAC5.Text = "00";
            this.SourceMAC5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxMouseClick);
            this.SourceMAC5.TextChanged += new System.EventHandler(this.JumpToNextMACTextbox);
            this.SourceMAC5.Enter += new System.EventHandler(this.TextboxEnter);
            this.SourceMAC5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexInputLimit);
            this.SourceMAC5.Leave += new System.EventHandler(this.TextboxLeave);
            // 
            // SourceMAC1
            // 
            this.SourceMAC1.Font = new System.Drawing.Font("宋体", 9F);
            this.SourceMAC1.Location = new System.Drawing.Point(6, 20);
            this.SourceMAC1.MaxLength = 2;
            this.SourceMAC1.Name = "SourceMAC1";
            this.SourceMAC1.Size = new System.Drawing.Size(18, 21);
            this.SourceMAC1.TabIndex = 5;
            this.SourceMAC1.Text = "00";
            this.SourceMAC1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxMouseClick);
            this.SourceMAC1.TextChanged += new System.EventHandler(this.JumpToNextMACTextbox);
            this.SourceMAC1.Enter += new System.EventHandler(this.TextboxEnter);
            this.SourceMAC1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexInputLimit);
            this.SourceMAC1.Leave += new System.EventHandler(this.TextboxLeave);
            // 
            // SourceMAC2
            // 
            this.SourceMAC2.Font = new System.Drawing.Font("宋体", 9F);
            this.SourceMAC2.Location = new System.Drawing.Point(35, 20);
            this.SourceMAC2.MaxLength = 2;
            this.SourceMAC2.Name = "SourceMAC2";
            this.SourceMAC2.Size = new System.Drawing.Size(18, 21);
            this.SourceMAC2.TabIndex = 7;
            this.SourceMAC2.Text = "00";
            this.SourceMAC2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxMouseClick);
            this.SourceMAC2.TextChanged += new System.EventHandler(this.JumpToNextMACTextbox);
            this.SourceMAC2.Enter += new System.EventHandler(this.TextboxEnter);
            this.SourceMAC2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexInputLimit);
            this.SourceMAC2.Leave += new System.EventHandler(this.TextboxLeave);
            // 
            // SourceMAC3
            // 
            this.SourceMAC3.Font = new System.Drawing.Font("宋体", 9F);
            this.SourceMAC3.Location = new System.Drawing.Point(64, 20);
            this.SourceMAC3.MaxLength = 2;
            this.SourceMAC3.Name = "SourceMAC3";
            this.SourceMAC3.Size = new System.Drawing.Size(18, 21);
            this.SourceMAC3.TabIndex = 9;
            this.SourceMAC3.Text = "00";
            this.SourceMAC3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxMouseClick);
            this.SourceMAC3.TextChanged += new System.EventHandler(this.JumpToNextMACTextbox);
            this.SourceMAC3.Enter += new System.EventHandler(this.TextboxEnter);
            this.SourceMAC3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexInputLimit);
            this.SourceMAC3.Leave += new System.EventHandler(this.TextboxLeave);
            // 
            // SourceMAC4
            // 
            this.SourceMAC4.Font = new System.Drawing.Font("宋体", 9F);
            this.SourceMAC4.Location = new System.Drawing.Point(93, 20);
            this.SourceMAC4.MaxLength = 2;
            this.SourceMAC4.Name = "SourceMAC4";
            this.SourceMAC4.Size = new System.Drawing.Size(18, 21);
            this.SourceMAC4.TabIndex = 11;
            this.SourceMAC4.Text = "00";
            this.SourceMAC4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxMouseClick);
            this.SourceMAC4.TextChanged += new System.EventHandler(this.JumpToNextMACTextbox);
            this.SourceMAC4.Enter += new System.EventHandler(this.TextboxEnter);
            this.SourceMAC4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexInputLimit);
            this.SourceMAC4.Leave += new System.EventHandler(this.TextboxLeave);
            // 
            // SourceMACColon2
            // 
            this.SourceMACColon2.AutoSize = true;
            this.SourceMACColon2.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SourceMACColon2.Location = new System.Drawing.Point(52, 22);
            this.SourceMACColon2.Name = "SourceMACColon2";
            this.SourceMACColon2.Size = new System.Drawing.Size(14, 14);
            this.SourceMACColon2.TabIndex = 8;
            this.SourceMACColon2.Text = ":";
            // 
            // SourceMACColon3
            // 
            this.SourceMACColon3.AutoSize = true;
            this.SourceMACColon3.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SourceMACColon3.Location = new System.Drawing.Point(81, 23);
            this.SourceMACColon3.Name = "SourceMACColon3";
            this.SourceMACColon3.Size = new System.Drawing.Size(14, 14);
            this.SourceMACColon3.TabIndex = 10;
            this.SourceMACColon3.Text = ":";
            // 
            // SourceMACColon1
            // 
            this.SourceMACColon1.AutoSize = true;
            this.SourceMACColon1.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SourceMACColon1.Location = new System.Drawing.Point(23, 23);
            this.SourceMACColon1.Name = "SourceMACColon1";
            this.SourceMACColon1.Size = new System.Drawing.Size(14, 14);
            this.SourceMACColon1.TabIndex = 6;
            this.SourceMACColon1.Text = ":";
            // 
            // SourceMACColon4
            // 
            this.SourceMACColon4.AutoSize = true;
            this.SourceMACColon4.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SourceMACColon4.Location = new System.Drawing.Point(110, 23);
            this.SourceMACColon4.Name = "SourceMACColon4";
            this.SourceMACColon4.Size = new System.Drawing.Size(14, 14);
            this.SourceMACColon4.TabIndex = 23;
            this.SourceMACColon4.Text = ":";
            // 
            // SourceMACColon5
            // 
            this.SourceMACColon5.AutoSize = true;
            this.SourceMACColon5.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SourceMACColon5.Location = new System.Drawing.Point(139, 24);
            this.SourceMACColon5.Name = "SourceMACColon5";
            this.SourceMACColon5.Size = new System.Drawing.Size(14, 14);
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
            this.DestMACGroupBox.Font = new System.Drawing.Font("黑体", 10.5F);
            this.DestMACGroupBox.Location = new System.Drawing.Point(706, 67);
            this.DestMACGroupBox.Name = "DestMACGroupBox";
            this.DestMACGroupBox.Size = new System.Drawing.Size(176, 47);
            this.DestMACGroupBox.TabIndex = 23;
            this.DestMACGroupBox.TabStop = false;
            this.DestMACGroupBox.Text = "目的MAC";
            // 
            // DestMAC6
            // 
            this.DestMAC6.Font = new System.Drawing.Font("宋体", 9F);
            this.DestMAC6.Location = new System.Drawing.Point(151, 20);
            this.DestMAC6.MaxLength = 2;
            this.DestMAC6.Name = "DestMAC6";
            this.DestMAC6.Size = new System.Drawing.Size(18, 21);
            this.DestMAC6.TabIndex = 15;
            this.DestMAC6.Text = "00";
            this.DestMAC6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxMouseClick);
            this.DestMAC6.TextChanged += new System.EventHandler(this.JumpToNextMACTextbox);
            this.DestMAC6.Enter += new System.EventHandler(this.TextboxEnter);
            this.DestMAC6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexInputLimit);
            this.DestMAC6.Leave += new System.EventHandler(this.TextboxLeave);
            // 
            // DestMAC5
            // 
            this.DestMAC5.Font = new System.Drawing.Font("宋体", 9F);
            this.DestMAC5.Location = new System.Drawing.Point(122, 20);
            this.DestMAC5.MaxLength = 2;
            this.DestMAC5.Name = "DestMAC5";
            this.DestMAC5.Size = new System.Drawing.Size(18, 21);
            this.DestMAC5.TabIndex = 13;
            this.DestMAC5.Text = "00";
            this.DestMAC5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxMouseClick);
            this.DestMAC5.TextChanged += new System.EventHandler(this.JumpToNextMACTextbox);
            this.DestMAC5.Enter += new System.EventHandler(this.TextboxEnter);
            this.DestMAC5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexInputLimit);
            this.DestMAC5.Leave += new System.EventHandler(this.TextboxLeave);
            // 
            // DestMAC1
            // 
            this.DestMAC1.Font = new System.Drawing.Font("宋体", 9F);
            this.DestMAC1.Location = new System.Drawing.Point(6, 20);
            this.DestMAC1.MaxLength = 2;
            this.DestMAC1.Name = "DestMAC1";
            this.DestMAC1.Size = new System.Drawing.Size(18, 21);
            this.DestMAC1.TabIndex = 5;
            this.DestMAC1.Text = "00";
            this.DestMAC1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxMouseClick);
            this.DestMAC1.TextChanged += new System.EventHandler(this.JumpToNextMACTextbox);
            this.DestMAC1.Enter += new System.EventHandler(this.TextboxEnter);
            this.DestMAC1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexInputLimit);
            this.DestMAC1.Leave += new System.EventHandler(this.TextboxLeave);
            // 
            // DestMAC2
            // 
            this.DestMAC2.Font = new System.Drawing.Font("宋体", 9F);
            this.DestMAC2.Location = new System.Drawing.Point(35, 20);
            this.DestMAC2.MaxLength = 2;
            this.DestMAC2.Name = "DestMAC2";
            this.DestMAC2.Size = new System.Drawing.Size(18, 21);
            this.DestMAC2.TabIndex = 7;
            this.DestMAC2.Text = "00";
            this.DestMAC2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxMouseClick);
            this.DestMAC2.TextChanged += new System.EventHandler(this.JumpToNextMACTextbox);
            this.DestMAC2.Enter += new System.EventHandler(this.TextboxEnter);
            this.DestMAC2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexInputLimit);
            this.DestMAC2.Leave += new System.EventHandler(this.TextboxLeave);
            // 
            // DestMAC3
            // 
            this.DestMAC3.Font = new System.Drawing.Font("宋体", 9F);
            this.DestMAC3.Location = new System.Drawing.Point(64, 20);
            this.DestMAC3.MaxLength = 2;
            this.DestMAC3.Name = "DestMAC3";
            this.DestMAC3.Size = new System.Drawing.Size(18, 21);
            this.DestMAC3.TabIndex = 9;
            this.DestMAC3.Text = "00";
            this.DestMAC3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxMouseClick);
            this.DestMAC3.TextChanged += new System.EventHandler(this.JumpToNextMACTextbox);
            this.DestMAC3.Enter += new System.EventHandler(this.TextboxEnter);
            this.DestMAC3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexInputLimit);
            this.DestMAC3.Leave += new System.EventHandler(this.TextboxLeave);
            // 
            // DestMAC4
            // 
            this.DestMAC4.Font = new System.Drawing.Font("宋体", 9F);
            this.DestMAC4.Location = new System.Drawing.Point(93, 20);
            this.DestMAC4.MaxLength = 2;
            this.DestMAC4.Name = "DestMAC4";
            this.DestMAC4.Size = new System.Drawing.Size(18, 21);
            this.DestMAC4.TabIndex = 11;
            this.DestMAC4.Text = "00";
            this.DestMAC4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxMouseClick);
            this.DestMAC4.TextChanged += new System.EventHandler(this.JumpToNextMACTextbox);
            this.DestMAC4.Enter += new System.EventHandler(this.TextboxEnter);
            this.DestMAC4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexInputLimit);
            this.DestMAC4.Leave += new System.EventHandler(this.TextboxLeave);
            // 
            // DestMACColon2
            // 
            this.DestMACColon2.AutoSize = true;
            this.DestMACColon2.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DestMACColon2.Location = new System.Drawing.Point(52, 22);
            this.DestMACColon2.Name = "DestMACColon2";
            this.DestMACColon2.Size = new System.Drawing.Size(14, 14);
            this.DestMACColon2.TabIndex = 8;
            this.DestMACColon2.Text = ":";
            // 
            // DestMACColon3
            // 
            this.DestMACColon3.AutoSize = true;
            this.DestMACColon3.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DestMACColon3.Location = new System.Drawing.Point(81, 23);
            this.DestMACColon3.Name = "DestMACColon3";
            this.DestMACColon3.Size = new System.Drawing.Size(14, 14);
            this.DestMACColon3.TabIndex = 10;
            this.DestMACColon3.Text = ":";
            // 
            // DestMACColon1
            // 
            this.DestMACColon1.AutoSize = true;
            this.DestMACColon1.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DestMACColon1.Location = new System.Drawing.Point(23, 23);
            this.DestMACColon1.Name = "DestMACColon1";
            this.DestMACColon1.Size = new System.Drawing.Size(14, 14);
            this.DestMACColon1.TabIndex = 6;
            this.DestMACColon1.Text = ":";
            // 
            // DestMACColon4
            // 
            this.DestMACColon4.AutoSize = true;
            this.DestMACColon4.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DestMACColon4.Location = new System.Drawing.Point(110, 23);
            this.DestMACColon4.Name = "DestMACColon4";
            this.DestMACColon4.Size = new System.Drawing.Size(14, 14);
            this.DestMACColon4.TabIndex = 23;
            this.DestMACColon4.Text = ":";
            // 
            // DestMACColon5
            // 
            this.DestMACColon5.AutoSize = true;
            this.DestMACColon5.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DestMACColon5.Location = new System.Drawing.Point(139, 24);
            this.DestMACColon5.Name = "DestMACColon5";
            this.DestMACColon5.Size = new System.Drawing.Size(14, 14);
            this.DestMACColon5.TabIndex = 23;
            this.DestMACColon5.Text = ":";
            // 
            // NetworkLayerComboBox
            // 
            this.NetworkLayerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NetworkLayerComboBox.FormattingEnabled = true;
            this.NetworkLayerComboBox.Items.AddRange(new object[] {
            "IPv4",
            "ARP/RARP"});
            this.NetworkLayerComboBox.Location = new System.Drawing.Point(649, 126);
            this.NetworkLayerComboBox.Name = "NetworkLayerComboBox";
            this.NetworkLayerComboBox.Size = new System.Drawing.Size(81, 20);
            this.NetworkLayerComboBox.TabIndex = 24;
            this.NetworkLayerComboBox.SelectedIndexChanged += new System.EventHandler(this.NetworkLayerComboBox_SelectedIndexChanged);
            // 
            // NetworkLayerLabel
            // 
            this.NetworkLayerLabel.AutoSize = true;
            this.NetworkLayerLabel.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NetworkLayerLabel.Location = new System.Drawing.Point(562, 129);
            this.NetworkLayerLabel.Name = "NetworkLayerLabel";
            this.NetworkLayerLabel.Size = new System.Drawing.Size(91, 14);
            this.NetworkLayerLabel.TabIndex = 25;
            this.NetworkLayerLabel.Text = "网络层协议：";
            // 
            // TransportLayerLabel
            // 
            this.TransportLayerLabel.AutoSize = true;
            this.TransportLayerLabel.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TransportLayerLabel.Location = new System.Drawing.Point(562, 155);
            this.TransportLayerLabel.Name = "TransportLayerLabel";
            this.TransportLayerLabel.Size = new System.Drawing.Size(91, 14);
            this.TransportLayerLabel.TabIndex = 26;
            this.TransportLayerLabel.Text = "运输层协议：";
            // 
            // TransportLayerComboBox
            // 
            this.TransportLayerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TransportLayerComboBox.Enabled = false;
            this.TransportLayerComboBox.FormattingEnabled = true;
            this.TransportLayerComboBox.Items.AddRange(new object[] {
            "TCP",
            "UDP"});
            this.TransportLayerComboBox.Location = new System.Drawing.Point(649, 152);
            this.TransportLayerComboBox.Name = "TransportLayerComboBox";
            this.TransportLayerComboBox.Size = new System.Drawing.Size(81, 20);
            this.TransportLayerComboBox.TabIndex = 27;
            this.TransportLayerComboBox.SelectedIndexChanged += new System.EventHandler(this.TransportLayerComboBox_SelectedIndexChanged);
            // 
            // SourcePortLabel
            // 
            this.SourcePortLabel.AutoSize = true;
            this.SourcePortLabel.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SourcePortLabel.Location = new System.Drawing.Point(732, 129);
            this.SourcePortLabel.Name = "SourcePortLabel";
            this.SourcePortLabel.Size = new System.Drawing.Size(63, 14);
            this.SourcePortLabel.TabIndex = 28;
            this.SourcePortLabel.Text = "源端口：";
            // 
            // SourcePortTextBox
            // 
            this.SourcePortTextBox.Location = new System.Drawing.Point(819, 126);
            this.SourcePortTextBox.MaxLength = 5;
            this.SourcePortTextBox.Name = "SourcePortTextBox";
            this.SourcePortTextBox.Size = new System.Drawing.Size(63, 21);
            this.SourcePortTextBox.TabIndex = 29;
            this.SourcePortTextBox.Text = "0";
            this.SourcePortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SourcePortTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxMouseClick);
            this.SourcePortTextBox.TextChanged += new System.EventHandler(this.JumpToNextWordTextbox);
            this.SourcePortTextBox.Enter += new System.EventHandler(this.TextboxEnter);
            this.SourcePortTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInputLimit);
            this.SourcePortTextBox.Leave += new System.EventHandler(this.TextboxLeave);
            // 
            // DestPortTextBox
            // 
            this.DestPortTextBox.Location = new System.Drawing.Point(819, 152);
            this.DestPortTextBox.MaxLength = 5;
            this.DestPortTextBox.Name = "DestPortTextBox";
            this.DestPortTextBox.Size = new System.Drawing.Size(63, 21);
            this.DestPortTextBox.TabIndex = 31;
            this.DestPortTextBox.Text = "0";
            this.DestPortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DestPortTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxMouseClick);
            this.DestPortTextBox.TextChanged += new System.EventHandler(this.JumpToNextWordTextbox);
            this.DestPortTextBox.Enter += new System.EventHandler(this.TextboxEnter);
            this.DestPortTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInputLimit);
            this.DestPortTextBox.Leave += new System.EventHandler(this.TextboxLeave);
            // 
            // DestPortLabel
            // 
            this.DestPortLabel.AutoSize = true;
            this.DestPortLabel.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DestPortLabel.Location = new System.Drawing.Point(732, 155);
            this.DestPortLabel.Name = "DestPortLabel";
            this.DestPortLabel.Size = new System.Drawing.Size(77, 14);
            this.DestPortLabel.TabIndex = 30;
            this.DestPortLabel.Text = "目的端口：";
            // 
            // SendPacketButton
            // 
            this.SendPacketButton.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SendPacketButton.Location = new System.Drawing.Point(790, 567);
            this.SendPacketButton.Name = "SendPacketButton";
            this.SendPacketButton.Size = new System.Drawing.Size(92, 28);
            this.SendPacketButton.TabIndex = 41;
            this.SendPacketButton.Text = "发送数据包";
            this.SendPacketButton.UseVisualStyleBackColor = true;
            this.SendPacketButton.Click += new System.EventHandler(this.SendPacketButton_Click);
            // 
            // PayloadTextBox
            // 
            this.PayloadTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.PayloadTextBox.Location = new System.Drawing.Point(568, 478);
            this.PayloadTextBox.MaxLength = 1000;
            this.PayloadTextBox.Multiline = true;
            this.PayloadTextBox.Name = "PayloadTextBox";
            this.PayloadTextBox.Size = new System.Drawing.Size(314, 83);
            this.PayloadTextBox.TabIndex = 40;
            this.PayloadTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxMouseClick);
            this.PayloadTextBox.Enter += new System.EventHandler(this.TextboxEnter);
            // 
            // PayloadLabel
            // 
            this.PayloadLabel.AutoSize = true;
            this.PayloadLabel.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PayloadLabel.Location = new System.Drawing.Point(568, 461);
            this.PayloadLabel.Name = "PayloadLabel";
            this.PayloadLabel.Size = new System.Drawing.Size(77, 14);
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
            this.IPv4GroupBox.Font = new System.Drawing.Font("黑体", 10.5F);
            this.IPv4GroupBox.Location = new System.Drawing.Point(562, 186);
            this.IPv4GroupBox.Name = "IPv4GroupBox";
            this.IPv4GroupBox.Size = new System.Drawing.Size(184, 102);
            this.IPv4GroupBox.TabIndex = 32;
            this.IPv4GroupBox.TabStop = false;
            this.IPv4GroupBox.Text = "IPv4参数设置";
            // 
            // FragmentFlagsTextBox
            // 
            this.FragmentFlagsTextBox.Font = new System.Drawing.Font("宋体", 9F);
            this.FragmentFlagsTextBox.Location = new System.Drawing.Point(156, 19);
            this.FragmentFlagsTextBox.MaxLength = 5;
            this.FragmentFlagsTextBox.Name = "FragmentFlagsTextBox";
            this.FragmentFlagsTextBox.Size = new System.Drawing.Size(18, 21);
            this.FragmentFlagsTextBox.TabIndex = 9;
            this.FragmentFlagsTextBox.Text = "0";
            this.FragmentFlagsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FragmentFlagsTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxMouseClick);
            this.FragmentFlagsTextBox.TextChanged += new System.EventHandler(this.JumpToNextFragmentFlagsTextbox);
            this.FragmentFlagsTextBox.Enter += new System.EventHandler(this.TextboxEnter);
            this.FragmentFlagsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInputLimit);
            this.FragmentFlagsTextBox.Leave += new System.EventHandler(this.TextboxLeave);
            // 
            // FragmentFlagsLabel
            // 
            this.FragmentFlagsLabel.AutoSize = true;
            this.FragmentFlagsLabel.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FragmentFlagsLabel.Location = new System.Drawing.Point(98, 23);
            this.FragmentFlagsLabel.Name = "FragmentFlagsLabel";
            this.FragmentFlagsLabel.Size = new System.Drawing.Size(53, 12);
            this.FragmentFlagsLabel.TabIndex = 41;
            this.FragmentFlagsLabel.Text = "分片标志";
            // 
            // IdentifierTextbox
            // 
            this.IdentifierTextbox.Font = new System.Drawing.Font("宋体", 9F);
            this.IdentifierTextbox.Location = new System.Drawing.Point(136, 44);
            this.IdentifierTextbox.MaxLength = 5;
            this.IdentifierTextbox.Name = "IdentifierTextbox";
            this.IdentifierTextbox.Size = new System.Drawing.Size(38, 21);
            this.IdentifierTextbox.TabIndex = 11;
            this.IdentifierTextbox.Text = "0";
            this.IdentifierTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.IdentifierTextbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxMouseClick);
            this.IdentifierTextbox.TextChanged += new System.EventHandler(this.JumpToNextWordTextbox);
            this.IdentifierTextbox.Enter += new System.EventHandler(this.TextboxEnter);
            this.IdentifierTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInputLimit);
            this.IdentifierTextbox.Leave += new System.EventHandler(this.TextboxLeave);
            // 
            // IdentifierLabel
            // 
            this.IdentifierLabel.AutoSize = true;
            this.IdentifierLabel.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IdentifierLabel.Location = new System.Drawing.Point(98, 48);
            this.IdentifierLabel.Name = "IdentifierLabel";
            this.IdentifierLabel.Size = new System.Drawing.Size(29, 12);
            this.IdentifierLabel.TabIndex = 39;
            this.IdentifierLabel.Text = "标识";
            // 
            // TOSTextBox
            // 
            this.TOSTextBox.Font = new System.Drawing.Font("宋体", 9F);
            this.TOSTextBox.Location = new System.Drawing.Point(64, 19);
            this.TOSTextBox.MaxLength = 3;
            this.TOSTextBox.Name = "TOSTextBox";
            this.TOSTextBox.Size = new System.Drawing.Size(25, 21);
            this.TOSTextBox.TabIndex = 5;
            this.TOSTextBox.Text = "0";
            this.TOSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TOSTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxMouseClick);
            this.TOSTextBox.TextChanged += new System.EventHandler(this.JumpToNextByteTextbox);
            this.TOSTextBox.Enter += new System.EventHandler(this.TextboxEnter);
            this.TOSTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInputLimit);
            this.TOSTextBox.Leave += new System.EventHandler(this.TextboxLeave);
            // 
            // TOSLabel
            // 
            this.TOSLabel.AutoSize = true;
            this.TOSLabel.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TOSLabel.Location = new System.Drawing.Point(6, 23);
            this.TOSLabel.Name = "TOSLabel";
            this.TOSLabel.Size = new System.Drawing.Size(53, 12);
            this.TOSLabel.TabIndex = 37;
            this.TOSLabel.Text = "服务类型";
            // 
            // FragmentOffsetTextBox
            // 
            this.FragmentOffsetTextBox.Font = new System.Drawing.Font("宋体", 9F);
            this.FragmentOffsetTextBox.Location = new System.Drawing.Point(140, 69);
            this.FragmentOffsetTextBox.MaxLength = 4;
            this.FragmentOffsetTextBox.Name = "FragmentOffsetTextBox";
            this.FragmentOffsetTextBox.Size = new System.Drawing.Size(34, 21);
            this.FragmentOffsetTextBox.TabIndex = 13;
            this.FragmentOffsetTextBox.Text = "0";
            this.FragmentOffsetTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FragmentOffsetTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxMouseClick);
            this.FragmentOffsetTextBox.TextChanged += new System.EventHandler(this.JumpToNextFragmentTextbox);
            this.FragmentOffsetTextBox.Enter += new System.EventHandler(this.TextboxEnter);
            this.FragmentOffsetTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInputLimit);
            this.FragmentOffsetTextBox.Leave += new System.EventHandler(this.TextboxLeave);
            // 
            // FragmentOffsetLabel
            // 
            this.FragmentOffsetLabel.AutoSize = true;
            this.FragmentOffsetLabel.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FragmentOffsetLabel.Location = new System.Drawing.Point(98, 73);
            this.FragmentOffsetLabel.Name = "FragmentOffsetLabel";
            this.FragmentOffsetLabel.Size = new System.Drawing.Size(41, 12);
            this.FragmentOffsetLabel.TabIndex = 35;
            this.FragmentOffsetLabel.Text = "片偏移";
            // 
            // TTLTextBox
            // 
            this.TTLTextBox.Font = new System.Drawing.Font("宋体", 9F);
            this.TTLTextBox.Location = new System.Drawing.Point(64, 44);
            this.TTLTextBox.MaxLength = 3;
            this.TTLTextBox.Name = "TTLTextBox";
            this.TTLTextBox.Size = new System.Drawing.Size(25, 21);
            this.TTLTextBox.TabIndex = 7;
            this.TTLTextBox.Text = "20";
            this.TTLTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TTLTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxMouseClick);
            this.TTLTextBox.TextChanged += new System.EventHandler(this.JumpToNextByteTextbox);
            this.TTLTextBox.Enter += new System.EventHandler(this.TextboxEnter);
            this.TTLTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInputLimit);
            this.TTLTextBox.Leave += new System.EventHandler(this.TextboxLeave);
            // 
            // TTLLabel
            // 
            this.TTLLabel.AutoSize = true;
            this.TTLLabel.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TTLLabel.Location = new System.Drawing.Point(6, 48);
            this.TTLLabel.Name = "TTLLabel";
            this.TTLLabel.Size = new System.Drawing.Size(53, 12);
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
            this.TCPGroupBox.Font = new System.Drawing.Font("黑体", 10.5F);
            this.TCPGroupBox.Location = new System.Drawing.Point(562, 294);
            this.TCPGroupBox.Name = "TCPGroupBox";
            this.TCPGroupBox.Size = new System.Drawing.Size(184, 142);
            this.TCPGroupBox.TabIndex = 33;
            this.TCPGroupBox.TabStop = false;
            this.TCPGroupBox.Text = "TCP参数设置";
            // 
            // UrgPointerTextBox
            // 
            this.UrgPointerTextBox.Font = new System.Drawing.Font("宋体", 9F);
            this.UrgPointerTextBox.Location = new System.Drawing.Point(140, 106);
            this.UrgPointerTextBox.MaxLength = 5;
            this.UrgPointerTextBox.Name = "UrgPointerTextBox";
            this.UrgPointerTextBox.Size = new System.Drawing.Size(38, 21);
            this.UrgPointerTextBox.TabIndex = 4;
            this.UrgPointerTextBox.Text = "0";
            this.UrgPointerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.UrgPointerTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxMouseClick);
            this.UrgPointerTextBox.TextChanged += new System.EventHandler(this.JumpToNextWordTextbox);
            this.UrgPointerTextBox.Enter += new System.EventHandler(this.TextboxEnter);
            this.UrgPointerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInputLimit);
            this.UrgPointerTextBox.Leave += new System.EventHandler(this.TextboxLeave);
            // 
            // UrgPointerLabel
            // 
            this.UrgPointerLabel.AutoSize = true;
            this.UrgPointerLabel.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UrgPointerLabel.Location = new System.Drawing.Point(66, 110);
            this.UrgPointerLabel.Name = "UrgPointerLabel";
            this.UrgPointerLabel.Size = new System.Drawing.Size(53, 12);
            this.UrgPointerLabel.TabIndex = 40;
            this.UrgPointerLabel.Text = "紧急指针";
            // 
            // WindowSizeTextBox
            // 
            this.WindowSizeTextBox.Font = new System.Drawing.Font("宋体", 9F);
            this.WindowSizeTextBox.Location = new System.Drawing.Point(140, 78);
            this.WindowSizeTextBox.MaxLength = 5;
            this.WindowSizeTextBox.Name = "WindowSizeTextBox";
            this.WindowSizeTextBox.Size = new System.Drawing.Size(38, 21);
            this.WindowSizeTextBox.TabIndex = 3;
            this.WindowSizeTextBox.Text = "0";
            this.WindowSizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.WindowSizeTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxMouseClick);
            this.WindowSizeTextBox.TextChanged += new System.EventHandler(this.JumpToNextWordTextbox);
            this.WindowSizeTextBox.Enter += new System.EventHandler(this.TextboxEnter);
            this.WindowSizeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInputLimit);
            this.WindowSizeTextBox.Leave += new System.EventHandler(this.TextboxLeave);
            // 
            // WindowSizeLabel
            // 
            this.WindowSizeLabel.AutoSize = true;
            this.WindowSizeLabel.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.WindowSizeLabel.Location = new System.Drawing.Point(66, 82);
            this.WindowSizeLabel.Name = "WindowSizeLabel";
            this.WindowSizeLabel.Size = new System.Drawing.Size(53, 12);
            this.WindowSizeLabel.TabIndex = 38;
            this.WindowSizeLabel.Text = "窗口大小";
            // 
            // AcknowledgmentTextBox
            // 
            this.AcknowledgmentTextBox.Font = new System.Drawing.Font("宋体", 9F);
            this.AcknowledgmentTextBox.Location = new System.Drawing.Point(108, 50);
            this.AcknowledgmentTextBox.MaxLength = 10;
            this.AcknowledgmentTextBox.Name = "AcknowledgmentTextBox";
            this.AcknowledgmentTextBox.Size = new System.Drawing.Size(70, 21);
            this.AcknowledgmentTextBox.TabIndex = 2;
            this.AcknowledgmentTextBox.Text = "0";
            this.AcknowledgmentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AcknowledgmentTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxMouseClick);
            this.AcknowledgmentTextBox.TextChanged += new System.EventHandler(this.JumpToNextDWordTextbox);
            this.AcknowledgmentTextBox.Enter += new System.EventHandler(this.TextboxEnter);
            this.AcknowledgmentTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInputLimit);
            this.AcknowledgmentTextBox.Leave += new System.EventHandler(this.TextboxLeave);
            // 
            // AcknowledgmentNumberLabel
            // 
            this.AcknowledgmentNumberLabel.AutoSize = true;
            this.AcknowledgmentNumberLabel.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AcknowledgmentNumberLabel.Location = new System.Drawing.Point(66, 54);
            this.AcknowledgmentNumberLabel.Name = "AcknowledgmentNumberLabel";
            this.AcknowledgmentNumberLabel.Size = new System.Drawing.Size(41, 12);
            this.AcknowledgmentNumberLabel.TabIndex = 36;
            this.AcknowledgmentNumberLabel.Text = "确认号";
            // 
            // SequenceTextBox
            // 
            this.SequenceTextBox.Font = new System.Drawing.Font("宋体", 9F);
            this.SequenceTextBox.Location = new System.Drawing.Point(108, 22);
            this.SequenceTextBox.MaxLength = 10;
            this.SequenceTextBox.Name = "SequenceTextBox";
            this.SequenceTextBox.Size = new System.Drawing.Size(70, 21);
            this.SequenceTextBox.TabIndex = 1;
            this.SequenceTextBox.Text = "0";
            this.SequenceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SequenceTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextboxMouseClick);
            this.SequenceTextBox.TextChanged += new System.EventHandler(this.JumpToNextDWordTextbox);
            this.SequenceTextBox.Enter += new System.EventHandler(this.TextboxEnter);
            this.SequenceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecInputLimit);
            this.SequenceTextBox.Leave += new System.EventHandler(this.TextboxLeave);
            // 
            // SequenceNumberLabel
            // 
            this.SequenceNumberLabel.AutoSize = true;
            this.SequenceNumberLabel.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SequenceNumberLabel.Location = new System.Drawing.Point(66, 26);
            this.SequenceNumberLabel.Name = "SequenceNumberLabel";
            this.SequenceNumberLabel.Size = new System.Drawing.Size(29, 12);
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
            this.TCPFlagsCheckedListBox.Location = new System.Drawing.Point(8, 22);
            this.TCPFlagsCheckedListBox.Name = "TCPFlagsCheckedListBox";
            this.TCPFlagsCheckedListBox.Size = new System.Drawing.Size(51, 112);
            this.TCPFlagsCheckedListBox.TabIndex = 0;
            // 
            // ARPGroupBox
            // 
            this.ARPGroupBox.Controls.Add(this.ARPOperationComboBox);
            this.ARPGroupBox.Controls.Add(this.ARPOperationLabel);
            this.ARPGroupBox.Enabled = false;
            this.ARPGroupBox.Font = new System.Drawing.Font("黑体", 10.5F);
            this.ARPGroupBox.Location = new System.Drawing.Point(752, 186);
            this.ARPGroupBox.Name = "ARPGroupBox";
            this.ARPGroupBox.Size = new System.Drawing.Size(130, 46);
            this.ARPGroupBox.TabIndex = 34;
            this.ARPGroupBox.TabStop = false;
            this.ARPGroupBox.Text = "ARP参数设置";
            // 
            // ARPOperationComboBox
            // 
            this.ARPOperationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ARPOperationComboBox.Font = new System.Drawing.Font("宋体", 8.8F);
            this.ARPOperationComboBox.FormattingEnabled = true;
            this.ARPOperationComboBox.Items.AddRange(new object[] {
            "ARP请求",
            "ARP响应",
            "RARP请求",
            "RARP响应"});
            this.ARPOperationComboBox.Location = new System.Drawing.Point(54, 18);
            this.ARPOperationComboBox.Name = "ARPOperationComboBox";
            this.ARPOperationComboBox.Size = new System.Drawing.Size(71, 20);
            this.ARPOperationComboBox.TabIndex = 0;
            // 
            // ARPOperationLabel
            // 
            this.ARPOperationLabel.AutoSize = true;
            this.ARPOperationLabel.Font = new System.Drawing.Font("黑体", 9F);
            this.ARPOperationLabel.Location = new System.Drawing.Point(2, 23);
            this.ARPOperationLabel.Name = "ARPOperationLabel";
            this.ARPOperationLabel.Size = new System.Drawing.Size(53, 12);
            this.ARPOperationLabel.TabIndex = 27;
            this.ARPOperationLabel.Text = "操作类型";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 607);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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

        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.ListBox DeviceList;
        private System.Windows.Forms.Label DeviceListLabel;
        private System.Windows.Forms.Label SplitLine;
        private System.Windows.Forms.TextBox SourceIP1;
        private System.Windows.Forms.Label SourceIPDot1;
        private System.Windows.Forms.TextBox SourceIP2;
        private System.Windows.Forms.Label SourceIPDot2;
        private System.Windows.Forms.TextBox SourceIP4;
        private System.Windows.Forms.TextBox SourceIP3;
        private System.Windows.Forms.Label SourceIPDot3;
        private System.Windows.Forms.GroupBox SourceIPGroupBox;
        private System.Windows.Forms.GroupBox DestIPGroupBox;
        private System.Windows.Forms.TextBox DestIP1;
        private System.Windows.Forms.TextBox DestIP2;
        private System.Windows.Forms.TextBox DestIP3;
        private System.Windows.Forms.TextBox DestIP4;
        private System.Windows.Forms.Label DestIPDot2;
        private System.Windows.Forms.Label DestIPDot3;
        private System.Windows.Forms.Label DestIPDot1;
        private System.Windows.Forms.GroupBox SourceMACGroupBox;
        private System.Windows.Forms.TextBox SourceMAC6;
        private System.Windows.Forms.TextBox SourceMAC5;
        private System.Windows.Forms.TextBox SourceMAC1;
        private System.Windows.Forms.TextBox SourceMAC2;
        private System.Windows.Forms.TextBox SourceMAC3;
        private System.Windows.Forms.TextBox SourceMAC4;
        private System.Windows.Forms.Label SourceMACColon2;
        private System.Windows.Forms.Label SourceMACColon3;
        private System.Windows.Forms.Label SourceMACColon1;
        private System.Windows.Forms.Label SourceMACColon4;
        private System.Windows.Forms.Label SourceMACColon5;
        private System.Windows.Forms.GroupBox DestMACGroupBox;
        private System.Windows.Forms.TextBox DestMAC6;
        private System.Windows.Forms.TextBox DestMAC5;
        private System.Windows.Forms.TextBox DestMAC1;
        private System.Windows.Forms.TextBox DestMAC2;
        private System.Windows.Forms.TextBox DestMAC3;
        private System.Windows.Forms.TextBox DestMAC4;
        private System.Windows.Forms.Label DestMACColon2;
        private System.Windows.Forms.Label DestMACColon3;
        private System.Windows.Forms.Label DestMACColon1;
        private System.Windows.Forms.Label DestMACColon4;
        private System.Windows.Forms.Label DestMACColon5;
        private System.Windows.Forms.ComboBox NetworkLayerComboBox;
        private System.Windows.Forms.Label NetworkLayerLabel;
        private System.Windows.Forms.Label TransportLayerLabel;
        private System.Windows.Forms.ComboBox TransportLayerComboBox;
        private System.Windows.Forms.Label SourcePortLabel;
        private System.Windows.Forms.TextBox SourcePortTextBox;
        private System.Windows.Forms.TextBox DestPortTextBox;
        private System.Windows.Forms.Label DestPortLabel;
        private System.Windows.Forms.Button SendPacketButton;
        private System.Windows.Forms.TextBox PayloadTextBox;
        private System.Windows.Forms.Label PayloadLabel;
        private System.Windows.Forms.GroupBox IPv4GroupBox;
        private System.Windows.Forms.TextBox TTLTextBox;
        private System.Windows.Forms.Label TTLLabel;
        private System.Windows.Forms.TextBox FragmentOffsetTextBox;
        private System.Windows.Forms.Label FragmentOffsetLabel;
        private System.Windows.Forms.TextBox TOSTextBox;
        private System.Windows.Forms.Label TOSLabel;
        private System.Windows.Forms.TextBox IdentifierTextbox;
        private System.Windows.Forms.Label IdentifierLabel;
        private System.Windows.Forms.TextBox FragmentFlagsTextBox;
        private System.Windows.Forms.Label FragmentFlagsLabel;
        private System.Windows.Forms.GroupBox TCPGroupBox;
        private System.Windows.Forms.CheckedListBox TCPFlagsCheckedListBox;
        private System.Windows.Forms.TextBox UrgPointerTextBox;
        private System.Windows.Forms.Label UrgPointerLabel;
        private System.Windows.Forms.TextBox WindowSizeTextBox;
        private System.Windows.Forms.Label WindowSizeLabel;
        private System.Windows.Forms.TextBox AcknowledgmentTextBox;
        private System.Windows.Forms.Label AcknowledgmentNumberLabel;
        private System.Windows.Forms.TextBox SequenceTextBox;
        private System.Windows.Forms.Label SequenceNumberLabel;
        private System.Windows.Forms.GroupBox ARPGroupBox;
        private System.Windows.Forms.ComboBox ARPOperationComboBox;
        private System.Windows.Forms.Label ARPOperationLabel;
    }
}

