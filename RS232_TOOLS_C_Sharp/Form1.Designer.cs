namespace RS232_TOOLS_C_Sharp
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnComPortConnet = new System.Windows.Forms.Button();
            this.btnPortDisConnect = new System.Windows.Forms.Button();
            this.cboComPort = new System.Windows.Forms.ComboBox();
            this.cboBaudRate = new System.Windows.Forms.ComboBox();
            this.lblCOMPORT = new System.Windows.Forms.Label();
            this.lblBAUDRATE = new System.Windows.Forms.Label();
            this.btnFormExit = new System.Windows.Forms.Button();
            this.gprMainPage = new System.Windows.Forms.GroupBox();
            this.lblI2CID = new System.Windows.Forms.Label();
            this.txtWriteREGData = new System.Windows.Forms.TextBox();
            this.txtWriteREGAddr = new System.Windows.Forms.TextBox();
            this.txtReadREGData = new System.Windows.Forms.TextBox();
            this.txtReadREGAddr = new System.Windows.Forms.TextBox();
            this.btnWriteRegister = new System.Windows.Forms.Button();
            this.btnReadRegister = new System.Windows.Forms.Button();
            this.chkRepeatCMD = new System.Windows.Forms.CheckBox();
            this.cboChipID = new System.Windows.Forms.ComboBox();
            this.cboSecond = new System.Windows.Forms.ComboBox();
            this.btnSendCMD = new System.Windows.Forms.Button();
            this.txtI2CAddr = new System.Windows.Forms.TextBox();
            this.txtCMDDATA = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.rtfMessage = new System.Windows.Forms.RichTextBox();
            this.rtfMessage2 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimeClock = new System.Windows.Forms.Label();
            this.btnClearMessage = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbaAddrAndData = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtREG00 = new System.Windows.Forms.TextBox();
            this.txtREG01 = new System.Windows.Forms.TextBox();
            this.txtREG02 = new System.Windows.Forms.TextBox();
            this.txtREG03 = new System.Windows.Forms.TextBox();
            this.txtREG04 = new System.Windows.Forms.TextBox();
            this.txtREG05 = new System.Windows.Forms.TextBox();
            this.txtREG06 = new System.Windows.Forms.TextBox();
            this.txtREG07 = new System.Windows.Forms.TextBox();
            this.txtREG08 = new System.Windows.Forms.TextBox();
            this.txtREG09 = new System.Windows.Forms.TextBox();
            this.txtREG0A = new System.Windows.Forms.TextBox();
            this.txtREG0B = new System.Windows.Forms.TextBox();
            this.txtREG0C = new System.Windows.Forms.TextBox();
            this.txtREG0D = new System.Windows.Forms.TextBox();
            this.txtREG0E = new System.Windows.Forms.TextBox();
            this.txtREG0F = new System.Windows.Forms.TextBox();
            this.txtREG10 = new System.Windows.Forms.TextBox();
            this.txtREG18 = new System.Windows.Forms.TextBox();
            this.txtREG11 = new System.Windows.Forms.TextBox();
            this.txtREG19 = new System.Windows.Forms.TextBox();
            this.txtREG12 = new System.Windows.Forms.TextBox();
            this.txtREG1A = new System.Windows.Forms.TextBox();
            this.txtREG13 = new System.Windows.Forms.TextBox();
            this.txtREG1B = new System.Windows.Forms.TextBox();
            this.txtREG14 = new System.Windows.Forms.TextBox();
            this.txtREG1C = new System.Windows.Forms.TextBox();
            this.txtREG15 = new System.Windows.Forms.TextBox();
            this.txtREG1D = new System.Windows.Forms.TextBox();
            this.txtREG16 = new System.Windows.Forms.TextBox();
            this.txtREG1E = new System.Windows.Forms.TextBox();
            this.txtREG17 = new System.Windows.Forms.TextBox();
            this.txtREG1F = new System.Windows.Forms.TextBox();
            this.txtREG20 = new System.Windows.Forms.TextBox();
            this.txtREG28 = new System.Windows.Forms.TextBox();
            this.txtREG21 = new System.Windows.Forms.TextBox();
            this.txtREG29 = new System.Windows.Forms.TextBox();
            this.txtREG22 = new System.Windows.Forms.TextBox();
            this.txtREG2A = new System.Windows.Forms.TextBox();
            this.txtREG23 = new System.Windows.Forms.TextBox();
            this.txtREG2B = new System.Windows.Forms.TextBox();
            this.txtREG24 = new System.Windows.Forms.TextBox();
            this.txtREG2C = new System.Windows.Forms.TextBox();
            this.txtREG25 = new System.Windows.Forms.TextBox();
            this.txtREG2D = new System.Windows.Forms.TextBox();
            this.txtREG26 = new System.Windows.Forms.TextBox();
            this.txtREG2E = new System.Windows.Forms.TextBox();
            this.txtREG27 = new System.Windows.Forms.TextBox();
            this.txtREG2F = new System.Windows.Forms.TextBox();
            this.txtREG30 = new System.Windows.Forms.TextBox();
            this.txtREG38 = new System.Windows.Forms.TextBox();
            this.txtREG31 = new System.Windows.Forms.TextBox();
            this.txtREG39 = new System.Windows.Forms.TextBox();
            this.txtREG32 = new System.Windows.Forms.TextBox();
            this.txtREG3A = new System.Windows.Forms.TextBox();
            this.txtREG33 = new System.Windows.Forms.TextBox();
            this.txtREG3B = new System.Windows.Forms.TextBox();
            this.txtREG34 = new System.Windows.Forms.TextBox();
            this.txtREG3C = new System.Windows.Forms.TextBox();
            this.txtREG35 = new System.Windows.Forms.TextBox();
            this.txtREG3D = new System.Windows.Forms.TextBox();
            this.txtREG36 = new System.Windows.Forms.TextBox();
            this.txtREG3E = new System.Windows.Forms.TextBox();
            this.txtREG37 = new System.Windows.Forms.TextBox();
            this.txtREG3F = new System.Windows.Forms.TextBox();
            this.txtREG40 = new System.Windows.Forms.TextBox();
            this.txtREG50 = new System.Windows.Forms.TextBox();
            this.txtREG60 = new System.Windows.Forms.TextBox();
            this.txtREG70 = new System.Windows.Forms.TextBox();
            this.txtREG48 = new System.Windows.Forms.TextBox();
            this.txtREG58 = new System.Windows.Forms.TextBox();
            this.txtREG68 = new System.Windows.Forms.TextBox();
            this.txtREG78 = new System.Windows.Forms.TextBox();
            this.txtREG41 = new System.Windows.Forms.TextBox();
            this.txtREG51 = new System.Windows.Forms.TextBox();
            this.txtREG61 = new System.Windows.Forms.TextBox();
            this.txtREG71 = new System.Windows.Forms.TextBox();
            this.txtREG49 = new System.Windows.Forms.TextBox();
            this.txtREG59 = new System.Windows.Forms.TextBox();
            this.txtREG69 = new System.Windows.Forms.TextBox();
            this.txtREG79 = new System.Windows.Forms.TextBox();
            this.txtREG42 = new System.Windows.Forms.TextBox();
            this.txtREG52 = new System.Windows.Forms.TextBox();
            this.txtREG62 = new System.Windows.Forms.TextBox();
            this.txtREG72 = new System.Windows.Forms.TextBox();
            this.txtREG4A = new System.Windows.Forms.TextBox();
            this.txtREG5A = new System.Windows.Forms.TextBox();
            this.txtREG6A = new System.Windows.Forms.TextBox();
            this.txtREG7A = new System.Windows.Forms.TextBox();
            this.txtREG43 = new System.Windows.Forms.TextBox();
            this.txtREG53 = new System.Windows.Forms.TextBox();
            this.txtREG63 = new System.Windows.Forms.TextBox();
            this.txtREG73 = new System.Windows.Forms.TextBox();
            this.txtREG4B = new System.Windows.Forms.TextBox();
            this.txtREG5B = new System.Windows.Forms.TextBox();
            this.txtREG6B = new System.Windows.Forms.TextBox();
            this.txtREG7B = new System.Windows.Forms.TextBox();
            this.txtREG44 = new System.Windows.Forms.TextBox();
            this.txtREG54 = new System.Windows.Forms.TextBox();
            this.txtREG64 = new System.Windows.Forms.TextBox();
            this.txtREG74 = new System.Windows.Forms.TextBox();
            this.txtREG4C = new System.Windows.Forms.TextBox();
            this.txtREG5C = new System.Windows.Forms.TextBox();
            this.txtREG6C = new System.Windows.Forms.TextBox();
            this.txtREG7C = new System.Windows.Forms.TextBox();
            this.txtREG45 = new System.Windows.Forms.TextBox();
            this.txtREG55 = new System.Windows.Forms.TextBox();
            this.txtREG65 = new System.Windows.Forms.TextBox();
            this.txtREG75 = new System.Windows.Forms.TextBox();
            this.txtREG4D = new System.Windows.Forms.TextBox();
            this.txtREG5D = new System.Windows.Forms.TextBox();
            this.txtREG6D = new System.Windows.Forms.TextBox();
            this.txtREG7D = new System.Windows.Forms.TextBox();
            this.txtREG46 = new System.Windows.Forms.TextBox();
            this.txtREG56 = new System.Windows.Forms.TextBox();
            this.txtREG66 = new System.Windows.Forms.TextBox();
            this.txtREG76 = new System.Windows.Forms.TextBox();
            this.txtREG4E = new System.Windows.Forms.TextBox();
            this.txtREG5E = new System.Windows.Forms.TextBox();
            this.txtREG6E = new System.Windows.Forms.TextBox();
            this.txtREG7E = new System.Windows.Forms.TextBox();
            this.txtREG47 = new System.Windows.Forms.TextBox();
            this.txtREG57 = new System.Windows.Forms.TextBox();
            this.txtREG67 = new System.Windows.Forms.TextBox();
            this.txtREG77 = new System.Windows.Forms.TextBox();
            this.txtREG4F = new System.Windows.Forms.TextBox();
            this.txtREG5F = new System.Windows.Forms.TextBox();
            this.txtREG6F = new System.Windows.Forms.TextBox();
            this.txtREG7F = new System.Windows.Forms.TextBox();
            this.txtREG80 = new System.Windows.Forms.TextBox();
            this.txtREGC0 = new System.Windows.Forms.TextBox();
            this.txtREG90 = new System.Windows.Forms.TextBox();
            this.txtREGD0 = new System.Windows.Forms.TextBox();
            this.txtREGA0 = new System.Windows.Forms.TextBox();
            this.txtREGE0 = new System.Windows.Forms.TextBox();
            this.txtREGB0 = new System.Windows.Forms.TextBox();
            this.txtREGF0 = new System.Windows.Forms.TextBox();
            this.txtREG88 = new System.Windows.Forms.TextBox();
            this.txtREGC8 = new System.Windows.Forms.TextBox();
            this.txtREG98 = new System.Windows.Forms.TextBox();
            this.txtREGD8 = new System.Windows.Forms.TextBox();
            this.txtREGA8 = new System.Windows.Forms.TextBox();
            this.txtREGE8 = new System.Windows.Forms.TextBox();
            this.txtREGB8 = new System.Windows.Forms.TextBox();
            this.txtREGF8 = new System.Windows.Forms.TextBox();
            this.txtREG81 = new System.Windows.Forms.TextBox();
            this.txtREGC1 = new System.Windows.Forms.TextBox();
            this.txtREG91 = new System.Windows.Forms.TextBox();
            this.txtREGD1 = new System.Windows.Forms.TextBox();
            this.txtREGA1 = new System.Windows.Forms.TextBox();
            this.txtREGE1 = new System.Windows.Forms.TextBox();
            this.txtREGB1 = new System.Windows.Forms.TextBox();
            this.txtREGF1 = new System.Windows.Forms.TextBox();
            this.txtREG89 = new System.Windows.Forms.TextBox();
            this.txtREGC9 = new System.Windows.Forms.TextBox();
            this.txtREG99 = new System.Windows.Forms.TextBox();
            this.txtREGD9 = new System.Windows.Forms.TextBox();
            this.txtREGA9 = new System.Windows.Forms.TextBox();
            this.txtREGE9 = new System.Windows.Forms.TextBox();
            this.txtREGB9 = new System.Windows.Forms.TextBox();
            this.txtREGF9 = new System.Windows.Forms.TextBox();
            this.txtREG82 = new System.Windows.Forms.TextBox();
            this.txtREGC2 = new System.Windows.Forms.TextBox();
            this.txtREG92 = new System.Windows.Forms.TextBox();
            this.txtREGD2 = new System.Windows.Forms.TextBox();
            this.txtREGA2 = new System.Windows.Forms.TextBox();
            this.txtREGE2 = new System.Windows.Forms.TextBox();
            this.txtREGB2 = new System.Windows.Forms.TextBox();
            this.txtREGF2 = new System.Windows.Forms.TextBox();
            this.txtREG8A = new System.Windows.Forms.TextBox();
            this.txtREGCA = new System.Windows.Forms.TextBox();
            this.txtREG9A = new System.Windows.Forms.TextBox();
            this.txtREGDA = new System.Windows.Forms.TextBox();
            this.txtREGAA = new System.Windows.Forms.TextBox();
            this.txtREGEA = new System.Windows.Forms.TextBox();
            this.txtREGBA = new System.Windows.Forms.TextBox();
            this.txtREGFA = new System.Windows.Forms.TextBox();
            this.txtREG83 = new System.Windows.Forms.TextBox();
            this.txtREGC3 = new System.Windows.Forms.TextBox();
            this.txtREG93 = new System.Windows.Forms.TextBox();
            this.txtREGD3 = new System.Windows.Forms.TextBox();
            this.txtREGA3 = new System.Windows.Forms.TextBox();
            this.txtREGE3 = new System.Windows.Forms.TextBox();
            this.txtREGB3 = new System.Windows.Forms.TextBox();
            this.txtREGF3 = new System.Windows.Forms.TextBox();
            this.txtREG8B = new System.Windows.Forms.TextBox();
            this.txtREGCB = new System.Windows.Forms.TextBox();
            this.txtREG9B = new System.Windows.Forms.TextBox();
            this.txtREGDB = new System.Windows.Forms.TextBox();
            this.txtREGAB = new System.Windows.Forms.TextBox();
            this.txtREGEB = new System.Windows.Forms.TextBox();
            this.txtREGBB = new System.Windows.Forms.TextBox();
            this.txtREGFB = new System.Windows.Forms.TextBox();
            this.txtREG84 = new System.Windows.Forms.TextBox();
            this.txtREGC4 = new System.Windows.Forms.TextBox();
            this.txtREG94 = new System.Windows.Forms.TextBox();
            this.txtREGD4 = new System.Windows.Forms.TextBox();
            this.txtREGA4 = new System.Windows.Forms.TextBox();
            this.txtREGE4 = new System.Windows.Forms.TextBox();
            this.txtREGB4 = new System.Windows.Forms.TextBox();
            this.txtREGF4 = new System.Windows.Forms.TextBox();
            this.txtREG8C = new System.Windows.Forms.TextBox();
            this.txtREGCC = new System.Windows.Forms.TextBox();
            this.txtREG9C = new System.Windows.Forms.TextBox();
            this.txtREGDC = new System.Windows.Forms.TextBox();
            this.txtREGAC = new System.Windows.Forms.TextBox();
            this.txtREGEC = new System.Windows.Forms.TextBox();
            this.txtREGBC = new System.Windows.Forms.TextBox();
            this.txtREGFC = new System.Windows.Forms.TextBox();
            this.txtREG85 = new System.Windows.Forms.TextBox();
            this.txtREGC5 = new System.Windows.Forms.TextBox();
            this.txtREG95 = new System.Windows.Forms.TextBox();
            this.txtREGD5 = new System.Windows.Forms.TextBox();
            this.txtREGA5 = new System.Windows.Forms.TextBox();
            this.txtREGE5 = new System.Windows.Forms.TextBox();
            this.txtREGB5 = new System.Windows.Forms.TextBox();
            this.txtREGF5 = new System.Windows.Forms.TextBox();
            this.txtREG8D = new System.Windows.Forms.TextBox();
            this.txtREGCD = new System.Windows.Forms.TextBox();
            this.txtREG9D = new System.Windows.Forms.TextBox();
            this.txtREGDD = new System.Windows.Forms.TextBox();
            this.txtREGAD = new System.Windows.Forms.TextBox();
            this.txtREGED = new System.Windows.Forms.TextBox();
            this.txtREGBD = new System.Windows.Forms.TextBox();
            this.txtREGFD = new System.Windows.Forms.TextBox();
            this.txtREG86 = new System.Windows.Forms.TextBox();
            this.txtREGC6 = new System.Windows.Forms.TextBox();
            this.txtREG96 = new System.Windows.Forms.TextBox();
            this.txtREGD6 = new System.Windows.Forms.TextBox();
            this.txtREGA6 = new System.Windows.Forms.TextBox();
            this.txtREGE6 = new System.Windows.Forms.TextBox();
            this.txtREGB6 = new System.Windows.Forms.TextBox();
            this.txtREGF6 = new System.Windows.Forms.TextBox();
            this.txtREG8E = new System.Windows.Forms.TextBox();
            this.txtREGCE = new System.Windows.Forms.TextBox();
            this.txtREG9E = new System.Windows.Forms.TextBox();
            this.txtREGDE = new System.Windows.Forms.TextBox();
            this.txtREGAE = new System.Windows.Forms.TextBox();
            this.txtREGEE = new System.Windows.Forms.TextBox();
            this.txtREGBE = new System.Windows.Forms.TextBox();
            this.txtREGFE = new System.Windows.Forms.TextBox();
            this.txtREG87 = new System.Windows.Forms.TextBox();
            this.txtREGC7 = new System.Windows.Forms.TextBox();
            this.txtREG97 = new System.Windows.Forms.TextBox();
            this.txtREGD7 = new System.Windows.Forms.TextBox();
            this.txtREGA7 = new System.Windows.Forms.TextBox();
            this.txtREGE7 = new System.Windows.Forms.TextBox();
            this.txtREGB7 = new System.Windows.Forms.TextBox();
            this.txtREGF7 = new System.Windows.Forms.TextBox();
            this.txtREG8F = new System.Windows.Forms.TextBox();
            this.txtREGCF = new System.Windows.Forms.TextBox();
            this.txtREG9F = new System.Windows.Forms.TextBox();
            this.txtREGDF = new System.Windows.Forms.TextBox();
            this.txtREGAF = new System.Windows.Forms.TextBox();
            this.txtREGEF = new System.Windows.Forms.TextBox();
            this.txtREGBF = new System.Windows.Forms.TextBox();
            this.txtREGFF = new System.Windows.Forms.TextBox();
            this.lbl_REG00 = new System.Windows.Forms.Label();
            this.lbl_REG01 = new System.Windows.Forms.Label();
            this.lbl_REG02 = new System.Windows.Forms.Label();
            this.lbl_REG03 = new System.Windows.Forms.Label();
            this.lbl_REG04 = new System.Windows.Forms.Label();
            this.lbl_REG05 = new System.Windows.Forms.Label();
            this.lbl_REG06 = new System.Windows.Forms.Label();
            this.lbl_REG07 = new System.Windows.Forms.Label();
            this.lbl_REG08 = new System.Windows.Forms.Label();
            this.lbl_REG09 = new System.Windows.Forms.Label();
            this.lbl_REG0A = new System.Windows.Forms.Label();
            this.lbl_REG0B = new System.Windows.Forms.Label();
            this.lbl_REG0C = new System.Windows.Forms.Label();
            this.lbl_REG0D = new System.Windows.Forms.Label();
            this.lbl_REG0E = new System.Windows.Forms.Label();
            this.lbl_REG0F = new System.Windows.Forms.Label();
            this.lbl_REG00_2 = new System.Windows.Forms.Label();
            this.lbl_REG10 = new System.Windows.Forms.Label();
            this.lbl_REG20 = new System.Windows.Forms.Label();
            this.lbl_REG30 = new System.Windows.Forms.Label();
            this.lbl_REG40 = new System.Windows.Forms.Label();
            this.lbl_REG50 = new System.Windows.Forms.Label();
            this.lbl_REG60 = new System.Windows.Forms.Label();
            this.lbl_REG70 = new System.Windows.Forms.Label();
            this.lbl_REG80 = new System.Windows.Forms.Label();
            this.lbl_REG90 = new System.Windows.Forms.Label();
            this.lbl_REGA0 = new System.Windows.Forms.Label();
            this.lbl_REGB0 = new System.Windows.Forms.Label();
            this.lbl_REGC0 = new System.Windows.Forms.Label();
            this.lbl_REGE0 = new System.Windows.Forms.Label();
            this.lbl_REGD0 = new System.Windows.Forms.Label();
            this.lbl_REGF0 = new System.Windows.Forms.Label();
            this.lblREGAddr = new System.Windows.Forms.Label();
            this.gprMainPage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btnComPortConnet
            // 
            this.btnComPortConnet.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnComPortConnet.Location = new System.Drawing.Point(283, 12);
            this.btnComPortConnet.Name = "btnComPortConnet";
            this.btnComPortConnet.Size = new System.Drawing.Size(81, 34);
            this.btnComPortConnet.TabIndex = 1;
            this.btnComPortConnet.Text = "連接";
            this.btnComPortConnet.UseVisualStyleBackColor = true;
            this.btnComPortConnet.Click += new System.EventHandler(this.btnComPortConnet_Click);
            // 
            // btnPortDisConnect
            // 
            this.btnPortDisConnect.Enabled = false;
            this.btnPortDisConnect.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPortDisConnect.Location = new System.Drawing.Point(283, 52);
            this.btnPortDisConnect.Name = "btnPortDisConnect";
            this.btnPortDisConnect.Size = new System.Drawing.Size(81, 36);
            this.btnPortDisConnect.TabIndex = 2;
            this.btnPortDisConnect.Text = "中斷";
            this.btnPortDisConnect.UseVisualStyleBackColor = true;
            this.btnPortDisConnect.Click += new System.EventHandler(this.btnPortDisConnect_Click);
            // 
            // cboComPort
            // 
            this.cboComPort.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboComPort.FormattingEnabled = true;
            this.cboComPort.Location = new System.Drawing.Point(145, 16);
            this.cboComPort.Name = "cboComPort";
            this.cboComPort.Size = new System.Drawing.Size(121, 28);
            this.cboComPort.TabIndex = 3;
            // 
            // cboBaudRate
            // 
            this.cboBaudRate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboBaudRate.FormattingEnabled = true;
            this.cboBaudRate.Items.AddRange(new object[] {
            "115200"});
            this.cboBaudRate.Location = new System.Drawing.Point(145, 60);
            this.cboBaudRate.Name = "cboBaudRate";
            this.cboBaudRate.Size = new System.Drawing.Size(121, 28);
            this.cboBaudRate.TabIndex = 4;
            // 
            // lblCOMPORT
            // 
            this.lblCOMPORT.AutoSize = true;
            this.lblCOMPORT.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCOMPORT.Location = new System.Drawing.Point(45, 19);
            this.lblCOMPORT.Name = "lblCOMPORT";
            this.lblCOMPORT.Size = new System.Drawing.Size(94, 20);
            this.lblCOMPORT.TabIndex = 5;
            this.lblCOMPORT.Text = "COM PORT";
            // 
            // lblBAUDRATE
            // 
            this.lblBAUDRATE.AutoSize = true;
            this.lblBAUDRATE.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBAUDRATE.Location = new System.Drawing.Point(42, 60);
            this.lblBAUDRATE.Name = "lblBAUDRATE";
            this.lblBAUDRATE.Size = new System.Drawing.Size(97, 20);
            this.lblBAUDRATE.TabIndex = 6;
            this.lblBAUDRATE.Text = "BAUD RATE";
            // 
            // btnFormExit
            // 
            this.btnFormExit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFormExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFormExit.Location = new System.Drawing.Point(793, 16);
            this.btnFormExit.Name = "btnFormExit";
            this.btnFormExit.Size = new System.Drawing.Size(75, 35);
            this.btnFormExit.TabIndex = 8;
            this.btnFormExit.Text = "離開";
            this.btnFormExit.UseVisualStyleBackColor = true;
            this.btnFormExit.Click += new System.EventHandler(this.btnFormExit_Click);
            // 
            // gprMainPage
            // 
            this.gprMainPage.Controls.Add(this.tabControl1);
            this.gprMainPage.Controls.Add(this.lblMessage);
            this.gprMainPage.Controls.Add(this.rtfMessage);
            this.gprMainPage.Enabled = false;
            this.gprMainPage.Location = new System.Drawing.Point(12, 94);
            this.gprMainPage.Name = "gprMainPage";
            this.gprMainPage.Size = new System.Drawing.Size(862, 639);
            this.gprMainPage.TabIndex = 11;
            this.gprMainPage.TabStop = false;
            // 
            // lblI2CID
            // 
            this.lblI2CID.AutoSize = true;
            this.lblI2CID.Location = new System.Drawing.Point(35, 67);
            this.lblI2CID.Name = "lblI2CID";
            this.lblI2CID.Size = new System.Drawing.Size(82, 12);
            this.lblI2CID.TabIndex = 22;
            this.lblI2CID.Text = "CHIP I2C Addr.";
            // 
            // txtWriteREGData
            // 
            this.txtWriteREGData.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtWriteREGData.Location = new System.Drawing.Point(225, 148);
            this.txtWriteREGData.MaxLength = 2;
            this.txtWriteREGData.Name = "txtWriteREGData";
            this.txtWriteREGData.Size = new System.Drawing.Size(50, 29);
            this.txtWriteREGData.TabIndex = 21;
            this.txtWriteREGData.Text = "00";
            this.txtWriteREGData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWriteREGData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWriteREGData_KeyPress);
            // 
            // txtWriteREGAddr
            // 
            this.txtWriteREGAddr.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtWriteREGAddr.Location = new System.Drawing.Point(133, 149);
            this.txtWriteREGAddr.MaxLength = 2;
            this.txtWriteREGAddr.Name = "txtWriteREGAddr";
            this.txtWriteREGAddr.Size = new System.Drawing.Size(50, 29);
            this.txtWriteREGAddr.TabIndex = 21;
            this.txtWriteREGAddr.Text = "00";
            this.txtWriteREGAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWriteREGAddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWriteREGAddr_KeyPress);
            // 
            // txtReadREGData
            // 
            this.txtReadREGData.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtReadREGData.Location = new System.Drawing.Point(225, 113);
            this.txtReadREGData.MaxLength = 2;
            this.txtReadREGData.Name = "txtReadREGData";
            this.txtReadREGData.ReadOnly = true;
            this.txtReadREGData.Size = new System.Drawing.Size(50, 29);
            this.txtReadREGData.TabIndex = 20;
            this.txtReadREGData.Text = "00";
            this.txtReadREGData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtReadREGAddr
            // 
            this.txtReadREGAddr.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtReadREGAddr.Location = new System.Drawing.Point(133, 114);
            this.txtReadREGAddr.MaxLength = 2;
            this.txtReadREGAddr.Name = "txtReadREGAddr";
            this.txtReadREGAddr.Size = new System.Drawing.Size(50, 29);
            this.txtReadREGAddr.TabIndex = 20;
            this.txtReadREGAddr.Text = "00";
            this.txtReadREGAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtReadREGAddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReadREGAddr_KeyPress);
            // 
            // btnWriteRegister
            // 
            this.btnWriteRegister.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWriteRegister.Location = new System.Drawing.Point(37, 149);
            this.btnWriteRegister.Name = "btnWriteRegister";
            this.btnWriteRegister.Size = new System.Drawing.Size(72, 29);
            this.btnWriteRegister.TabIndex = 19;
            this.btnWriteRegister.Text = "寫入";
            this.btnWriteRegister.UseVisualStyleBackColor = true;
            this.btnWriteRegister.Click += new System.EventHandler(this.btnWriteRegister_Click);
            // 
            // btnReadRegister
            // 
            this.btnReadRegister.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReadRegister.Location = new System.Drawing.Point(37, 113);
            this.btnReadRegister.Name = "btnReadRegister";
            this.btnReadRegister.Size = new System.Drawing.Size(72, 29);
            this.btnReadRegister.TabIndex = 18;
            this.btnReadRegister.Text = "讀取";
            this.btnReadRegister.UseVisualStyleBackColor = true;
            this.btnReadRegister.Click += new System.EventHandler(this.btnReadRegister_Click);
            // 
            // chkRepeatCMD
            // 
            this.chkRepeatCMD.AutoSize = true;
            this.chkRepeatCMD.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkRepeatCMD.Location = new System.Drawing.Point(393, 17);
            this.chkRepeatCMD.Name = "chkRepeatCMD";
            this.chkRepeatCMD.Size = new System.Drawing.Size(60, 24);
            this.chkRepeatCMD.TabIndex = 16;
            this.chkRepeatCMD.Text = "連續";
            this.chkRepeatCMD.UseVisualStyleBackColor = true;
            this.chkRepeatCMD.CheckedChanged += new System.EventHandler(this.chkRepeatCMD_CheckedChanged);
            // 
            // cboChipID
            // 
            this.cboChipID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboChipID.ForeColor = System.Drawing.Color.Red;
            this.cboChipID.FormattingEnabled = true;
            this.cboChipID.Items.AddRange(new object[] {
            "VS4210",
            "TP2824",
            "EEPROM",
            "VS8812"});
            this.cboChipID.Location = new System.Drawing.Point(133, 55);
            this.cboChipID.Name = "cboChipID";
            this.cboChipID.Size = new System.Drawing.Size(100, 28);
            this.cboChipID.TabIndex = 15;
            this.cboChipID.Text = "VS4210";
            this.cboChipID.SelectedIndexChanged += new System.EventHandler(this.cboChipID_SelectedIndexChanged);
            // 
            // cboSecond
            // 
            this.cboSecond.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboSecond.FormattingEnabled = true;
            this.cboSecond.Items.AddRange(new object[] {
            "0秒",
            "1秒",
            "2秒",
            "3秒",
            "4秒",
            "5秒",
            "6秒",
            "7秒",
            "8秒",
            "9秒",
            "10秒"});
            this.cboSecond.Location = new System.Drawing.Point(299, 16);
            this.cboSecond.Name = "cboSecond";
            this.cboSecond.Size = new System.Drawing.Size(73, 28);
            this.cboSecond.TabIndex = 15;
            this.cboSecond.SelectedIndexChanged += new System.EventHandler(this.cboSecond_SelectedIndexChanged);
            // 
            // btnSendCMD
            // 
            this.btnSendCMD.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSendCMD.Location = new System.Drawing.Point(37, 15);
            this.btnSendCMD.Name = "btnSendCMD";
            this.btnSendCMD.Size = new System.Drawing.Size(72, 29);
            this.btnSendCMD.TabIndex = 14;
            this.btnSendCMD.Text = "傳送";
            this.btnSendCMD.UseVisualStyleBackColor = true;
            this.btnSendCMD.Click += new System.EventHandler(this.btnSendCMD_Click);
            // 
            // txtI2CAddr
            // 
            this.txtI2CAddr.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtI2CAddr.Location = new System.Drawing.Point(292, 58);
            this.txtI2CAddr.MaxLength = 2;
            this.txtI2CAddr.Name = "txtI2CAddr";
            this.txtI2CAddr.Size = new System.Drawing.Size(50, 29);
            this.txtI2CAddr.TabIndex = 13;
            this.txtI2CAddr.Text = "40";
            this.txtI2CAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCMDDATA
            // 
            this.txtCMDDATA.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCMDDATA.Location = new System.Drawing.Point(133, 16);
            this.txtCMDDATA.MaxLength = 20;
            this.txtCMDDATA.Name = "txtCMDDATA";
            this.txtCMDDATA.Size = new System.Drawing.Size(142, 29);
            this.txtCMDDATA.TabIndex = 13;
            this.txtCMDDATA.Text = "FW";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMessage.Location = new System.Drawing.Point(509, 14);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(62, 16);
            this.lblMessage.TabIndex = 12;
            this.lblMessage.Text = "Message";
            // 
            // rtfMessage
            // 
            this.rtfMessage.BackColor = System.Drawing.SystemColors.InfoText;
            this.rtfMessage.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtfMessage.ForeColor = System.Drawing.SystemColors.Window;
            this.rtfMessage.Location = new System.Drawing.Point(512, 33);
            this.rtfMessage.Name = "rtfMessage";
            this.rtfMessage.Size = new System.Drawing.Size(344, 597);
            this.rtfMessage.TabIndex = 11;
            this.rtfMessage.Text = "";
            this.rtfMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtfMessage_KeyPress);
            // 
            // rtfMessage2
            // 
            this.rtfMessage2.BackColor = System.Drawing.SystemColors.InfoText;
            this.rtfMessage2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtfMessage2.ForeColor = System.Drawing.SystemColors.Window;
            this.rtfMessage2.Location = new System.Drawing.Point(6, 19);
            this.rtfMessage2.Name = "rtfMessage2";
            this.rtfMessage2.Size = new System.Drawing.Size(20, 21);
            this.rtfMessage2.TabIndex = 11;
            this.rtfMessage2.Text = "";
            this.rtfMessage2.Visible = false;
            this.rtfMessage2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtfMessage_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimeClock
            // 
            this.lblTimeClock.AutoSize = true;
            this.lblTimeClock.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTimeClock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTimeClock.Location = new System.Drawing.Point(469, 32);
            this.lblTimeClock.Name = "lblTimeClock";
            this.lblTimeClock.Size = new System.Drawing.Size(153, 26);
            this.lblTimeClock.TabIndex = 12;
            this.lblTimeClock.Text = "Day And Time";
            // 
            // btnClearMessage
            // 
            this.btnClearMessage.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClearMessage.Location = new System.Drawing.Point(793, 63);
            this.btnClearMessage.Name = "btnClearMessage";
            this.btnClearMessage.Size = new System.Drawing.Size(75, 31);
            this.btnClearMessage.TabIndex = 15;
            this.btnClearMessage.Text = "清除";
            this.btnClearMessage.UseVisualStyleBackColor = true;
            this.btnClearMessage.Click += new System.EventHandler(this.btnClearMessage_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lbaAddrAndData
            // 
            this.lbaAddrAndData.AutoSize = true;
            this.lbaAddrAndData.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbaAddrAndData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbaAddrAndData.Location = new System.Drawing.Point(140, 93);
            this.lbaAddrAndData.Name = "lbaAddrAndData";
            this.lbaAddrAndData.Size = new System.Drawing.Size(127, 17);
            this.lbaAddrAndData.TabIndex = 23;
            this.lbaAddrAndData.Text = "Addr.                  Data.";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(506, 620);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.rtfMessage2);
            this.tabPage1.Controls.Add(this.lbaAddrAndData);
            this.tabPage1.Controls.Add(this.txtCMDDATA);
            this.tabPage1.Controls.Add(this.lblI2CID);
            this.tabPage1.Controls.Add(this.txtWriteREGData);
            this.tabPage1.Controls.Add(this.btnSendCMD);
            this.tabPage1.Controls.Add(this.txtWriteREGAddr);
            this.tabPage1.Controls.Add(this.cboSecond);
            this.tabPage1.Controls.Add(this.txtReadREGData);
            this.tabPage1.Controls.Add(this.chkRepeatCMD);
            this.tabPage1.Controls.Add(this.txtReadREGAddr);
            this.tabPage1.Controls.Add(this.txtI2CAddr);
            this.tabPage1.Controls.Add(this.btnWriteRegister);
            this.tabPage1.Controls.Add(this.cboChipID);
            this.tabPage1.Controls.Add(this.btnReadRegister);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(498, 594);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "常用";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.lbl_REG0F);
            this.tabPage2.Controls.Add(this.lbl_REG07);
            this.tabPage2.Controls.Add(this.lbl_REG0E);
            this.tabPage2.Controls.Add(this.lbl_REG06);
            this.tabPage2.Controls.Add(this.lbl_REG0D);
            this.tabPage2.Controls.Add(this.lbl_REG05);
            this.tabPage2.Controls.Add(this.lbl_REG0C);
            this.tabPage2.Controls.Add(this.lbl_REG04);
            this.tabPage2.Controls.Add(this.lbl_REG0B);
            this.tabPage2.Controls.Add(this.lbl_REG03);
            this.tabPage2.Controls.Add(this.lbl_REG0A);
            this.tabPage2.Controls.Add(this.lbl_REG02);
            this.tabPage2.Controls.Add(this.lbl_REG09);
            this.tabPage2.Controls.Add(this.lbl_REG01);
            this.tabPage2.Controls.Add(this.lbl_REG08);
            this.tabPage2.Controls.Add(this.lbl_REGF0);
            this.tabPage2.Controls.Add(this.lbl_REG70);
            this.tabPage2.Controls.Add(this.lbl_REGD0);
            this.tabPage2.Controls.Add(this.lbl_REG50);
            this.tabPage2.Controls.Add(this.lbl_REGE0);
            this.tabPage2.Controls.Add(this.lbl_REG60);
            this.tabPage2.Controls.Add(this.lbl_REGC0);
            this.tabPage2.Controls.Add(this.lbl_REG40);
            this.tabPage2.Controls.Add(this.lbl_REGB0);
            this.tabPage2.Controls.Add(this.lbl_REG30);
            this.tabPage2.Controls.Add(this.lbl_REGA0);
            this.tabPage2.Controls.Add(this.lbl_REG20);
            this.tabPage2.Controls.Add(this.lbl_REG90);
            this.tabPage2.Controls.Add(this.lbl_REG10);
            this.tabPage2.Controls.Add(this.lbl_REG80);
            this.tabPage2.Controls.Add(this.lbl_REG00_2);
            this.tabPage2.Controls.Add(this.lbl_REG00);
            this.tabPage2.Controls.Add(this.txtREGFF);
            this.tabPage2.Controls.Add(this.txtREG7F);
            this.tabPage2.Controls.Add(this.txtREGBF);
            this.tabPage2.Controls.Add(this.txtREG3F);
            this.tabPage2.Controls.Add(this.txtREGEF);
            this.tabPage2.Controls.Add(this.txtREG6F);
            this.tabPage2.Controls.Add(this.txtREGAF);
            this.tabPage2.Controls.Add(this.txtREG2F);
            this.tabPage2.Controls.Add(this.txtREGDF);
            this.tabPage2.Controls.Add(this.txtREG5F);
            this.tabPage2.Controls.Add(this.txtREG9F);
            this.tabPage2.Controls.Add(this.txtREG1F);
            this.tabPage2.Controls.Add(this.txtREGCF);
            this.tabPage2.Controls.Add(this.txtREG4F);
            this.tabPage2.Controls.Add(this.txtREG8F);
            this.tabPage2.Controls.Add(this.txtREG0F);
            this.tabPage2.Controls.Add(this.txtREGF7);
            this.tabPage2.Controls.Add(this.txtREG77);
            this.tabPage2.Controls.Add(this.txtREGB7);
            this.tabPage2.Controls.Add(this.txtREG37);
            this.tabPage2.Controls.Add(this.txtREGE7);
            this.tabPage2.Controls.Add(this.txtREG67);
            this.tabPage2.Controls.Add(this.txtREGA7);
            this.tabPage2.Controls.Add(this.txtREG27);
            this.tabPage2.Controls.Add(this.txtREGD7);
            this.tabPage2.Controls.Add(this.txtREG57);
            this.tabPage2.Controls.Add(this.txtREG97);
            this.tabPage2.Controls.Add(this.txtREG17);
            this.tabPage2.Controls.Add(this.txtREGC7);
            this.tabPage2.Controls.Add(this.txtREG47);
            this.tabPage2.Controls.Add(this.txtREG87);
            this.tabPage2.Controls.Add(this.txtREG07);
            this.tabPage2.Controls.Add(this.txtREGFE);
            this.tabPage2.Controls.Add(this.txtREG7E);
            this.tabPage2.Controls.Add(this.txtREGBE);
            this.tabPage2.Controls.Add(this.txtREG3E);
            this.tabPage2.Controls.Add(this.txtREGEE);
            this.tabPage2.Controls.Add(this.txtREG6E);
            this.tabPage2.Controls.Add(this.txtREGAE);
            this.tabPage2.Controls.Add(this.txtREG2E);
            this.tabPage2.Controls.Add(this.txtREGDE);
            this.tabPage2.Controls.Add(this.txtREG5E);
            this.tabPage2.Controls.Add(this.txtREG9E);
            this.tabPage2.Controls.Add(this.txtREG1E);
            this.tabPage2.Controls.Add(this.txtREGCE);
            this.tabPage2.Controls.Add(this.txtREG4E);
            this.tabPage2.Controls.Add(this.txtREG8E);
            this.tabPage2.Controls.Add(this.txtREG0E);
            this.tabPage2.Controls.Add(this.txtREGF6);
            this.tabPage2.Controls.Add(this.txtREG76);
            this.tabPage2.Controls.Add(this.txtREGB6);
            this.tabPage2.Controls.Add(this.txtREG36);
            this.tabPage2.Controls.Add(this.txtREGE6);
            this.tabPage2.Controls.Add(this.txtREG66);
            this.tabPage2.Controls.Add(this.txtREGA6);
            this.tabPage2.Controls.Add(this.txtREG26);
            this.tabPage2.Controls.Add(this.txtREGD6);
            this.tabPage2.Controls.Add(this.txtREG56);
            this.tabPage2.Controls.Add(this.txtREG96);
            this.tabPage2.Controls.Add(this.txtREG16);
            this.tabPage2.Controls.Add(this.txtREGC6);
            this.tabPage2.Controls.Add(this.txtREG46);
            this.tabPage2.Controls.Add(this.txtREG86);
            this.tabPage2.Controls.Add(this.txtREG06);
            this.tabPage2.Controls.Add(this.txtREGFD);
            this.tabPage2.Controls.Add(this.txtREG7D);
            this.tabPage2.Controls.Add(this.txtREGBD);
            this.tabPage2.Controls.Add(this.txtREG3D);
            this.tabPage2.Controls.Add(this.txtREGED);
            this.tabPage2.Controls.Add(this.txtREG6D);
            this.tabPage2.Controls.Add(this.txtREGAD);
            this.tabPage2.Controls.Add(this.txtREG2D);
            this.tabPage2.Controls.Add(this.txtREGDD);
            this.tabPage2.Controls.Add(this.txtREG5D);
            this.tabPage2.Controls.Add(this.txtREG9D);
            this.tabPage2.Controls.Add(this.txtREG1D);
            this.tabPage2.Controls.Add(this.txtREGCD);
            this.tabPage2.Controls.Add(this.txtREG4D);
            this.tabPage2.Controls.Add(this.txtREG8D);
            this.tabPage2.Controls.Add(this.txtREG0D);
            this.tabPage2.Controls.Add(this.txtREGF5);
            this.tabPage2.Controls.Add(this.txtREG75);
            this.tabPage2.Controls.Add(this.txtREGB5);
            this.tabPage2.Controls.Add(this.txtREG35);
            this.tabPage2.Controls.Add(this.txtREGE5);
            this.tabPage2.Controls.Add(this.txtREG65);
            this.tabPage2.Controls.Add(this.txtREGA5);
            this.tabPage2.Controls.Add(this.txtREG25);
            this.tabPage2.Controls.Add(this.txtREGD5);
            this.tabPage2.Controls.Add(this.txtREG55);
            this.tabPage2.Controls.Add(this.txtREG95);
            this.tabPage2.Controls.Add(this.txtREG15);
            this.tabPage2.Controls.Add(this.txtREGC5);
            this.tabPage2.Controls.Add(this.txtREG45);
            this.tabPage2.Controls.Add(this.txtREG85);
            this.tabPage2.Controls.Add(this.txtREG05);
            this.tabPage2.Controls.Add(this.txtREGFC);
            this.tabPage2.Controls.Add(this.txtREG7C);
            this.tabPage2.Controls.Add(this.txtREGBC);
            this.tabPage2.Controls.Add(this.txtREG3C);
            this.tabPage2.Controls.Add(this.txtREGEC);
            this.tabPage2.Controls.Add(this.txtREG6C);
            this.tabPage2.Controls.Add(this.txtREGAC);
            this.tabPage2.Controls.Add(this.txtREG2C);
            this.tabPage2.Controls.Add(this.txtREGDC);
            this.tabPage2.Controls.Add(this.txtREG5C);
            this.tabPage2.Controls.Add(this.txtREG9C);
            this.tabPage2.Controls.Add(this.txtREG1C);
            this.tabPage2.Controls.Add(this.txtREGCC);
            this.tabPage2.Controls.Add(this.txtREG4C);
            this.tabPage2.Controls.Add(this.txtREG8C);
            this.tabPage2.Controls.Add(this.txtREG0C);
            this.tabPage2.Controls.Add(this.txtREGF4);
            this.tabPage2.Controls.Add(this.txtREG74);
            this.tabPage2.Controls.Add(this.txtREGB4);
            this.tabPage2.Controls.Add(this.txtREG34);
            this.tabPage2.Controls.Add(this.txtREGE4);
            this.tabPage2.Controls.Add(this.txtREG64);
            this.tabPage2.Controls.Add(this.txtREGA4);
            this.tabPage2.Controls.Add(this.txtREG24);
            this.tabPage2.Controls.Add(this.txtREGD4);
            this.tabPage2.Controls.Add(this.txtREG54);
            this.tabPage2.Controls.Add(this.txtREG94);
            this.tabPage2.Controls.Add(this.txtREG14);
            this.tabPage2.Controls.Add(this.txtREGC4);
            this.tabPage2.Controls.Add(this.txtREG44);
            this.tabPage2.Controls.Add(this.txtREG84);
            this.tabPage2.Controls.Add(this.txtREG04);
            this.tabPage2.Controls.Add(this.txtREGFB);
            this.tabPage2.Controls.Add(this.txtREG7B);
            this.tabPage2.Controls.Add(this.txtREGBB);
            this.tabPage2.Controls.Add(this.txtREG3B);
            this.tabPage2.Controls.Add(this.txtREGEB);
            this.tabPage2.Controls.Add(this.txtREG6B);
            this.tabPage2.Controls.Add(this.txtREGAB);
            this.tabPage2.Controls.Add(this.txtREG2B);
            this.tabPage2.Controls.Add(this.txtREGDB);
            this.tabPage2.Controls.Add(this.txtREG5B);
            this.tabPage2.Controls.Add(this.txtREG9B);
            this.tabPage2.Controls.Add(this.txtREG1B);
            this.tabPage2.Controls.Add(this.txtREGCB);
            this.tabPage2.Controls.Add(this.txtREG4B);
            this.tabPage2.Controls.Add(this.txtREG8B);
            this.tabPage2.Controls.Add(this.txtREG0B);
            this.tabPage2.Controls.Add(this.txtREGF3);
            this.tabPage2.Controls.Add(this.txtREG73);
            this.tabPage2.Controls.Add(this.txtREGB3);
            this.tabPage2.Controls.Add(this.txtREG33);
            this.tabPage2.Controls.Add(this.txtREGE3);
            this.tabPage2.Controls.Add(this.txtREG63);
            this.tabPage2.Controls.Add(this.txtREGA3);
            this.tabPage2.Controls.Add(this.txtREG23);
            this.tabPage2.Controls.Add(this.txtREGD3);
            this.tabPage2.Controls.Add(this.txtREG53);
            this.tabPage2.Controls.Add(this.txtREG93);
            this.tabPage2.Controls.Add(this.txtREG13);
            this.tabPage2.Controls.Add(this.txtREGC3);
            this.tabPage2.Controls.Add(this.txtREG43);
            this.tabPage2.Controls.Add(this.txtREG83);
            this.tabPage2.Controls.Add(this.txtREG03);
            this.tabPage2.Controls.Add(this.txtREGFA);
            this.tabPage2.Controls.Add(this.txtREG7A);
            this.tabPage2.Controls.Add(this.txtREGBA);
            this.tabPage2.Controls.Add(this.txtREG3A);
            this.tabPage2.Controls.Add(this.txtREGEA);
            this.tabPage2.Controls.Add(this.txtREG6A);
            this.tabPage2.Controls.Add(this.txtREGAA);
            this.tabPage2.Controls.Add(this.txtREG2A);
            this.tabPage2.Controls.Add(this.txtREGDA);
            this.tabPage2.Controls.Add(this.txtREG5A);
            this.tabPage2.Controls.Add(this.txtREG9A);
            this.tabPage2.Controls.Add(this.txtREG1A);
            this.tabPage2.Controls.Add(this.txtREGCA);
            this.tabPage2.Controls.Add(this.txtREG4A);
            this.tabPage2.Controls.Add(this.txtREG8A);
            this.tabPage2.Controls.Add(this.txtREG0A);
            this.tabPage2.Controls.Add(this.txtREGF2);
            this.tabPage2.Controls.Add(this.txtREG72);
            this.tabPage2.Controls.Add(this.txtREGB2);
            this.tabPage2.Controls.Add(this.txtREG32);
            this.tabPage2.Controls.Add(this.txtREGE2);
            this.tabPage2.Controls.Add(this.txtREG62);
            this.tabPage2.Controls.Add(this.txtREGA2);
            this.tabPage2.Controls.Add(this.txtREG22);
            this.tabPage2.Controls.Add(this.txtREGD2);
            this.tabPage2.Controls.Add(this.txtREG52);
            this.tabPage2.Controls.Add(this.txtREG92);
            this.tabPage2.Controls.Add(this.txtREG12);
            this.tabPage2.Controls.Add(this.txtREGC2);
            this.tabPage2.Controls.Add(this.txtREG42);
            this.tabPage2.Controls.Add(this.txtREG82);
            this.tabPage2.Controls.Add(this.txtREG02);
            this.tabPage2.Controls.Add(this.txtREGF9);
            this.tabPage2.Controls.Add(this.txtREG79);
            this.tabPage2.Controls.Add(this.txtREGB9);
            this.tabPage2.Controls.Add(this.txtREG39);
            this.tabPage2.Controls.Add(this.txtREGE9);
            this.tabPage2.Controls.Add(this.txtREG69);
            this.tabPage2.Controls.Add(this.txtREGA9);
            this.tabPage2.Controls.Add(this.txtREG29);
            this.tabPage2.Controls.Add(this.txtREGD9);
            this.tabPage2.Controls.Add(this.txtREG59);
            this.tabPage2.Controls.Add(this.txtREG99);
            this.tabPage2.Controls.Add(this.txtREG19);
            this.tabPage2.Controls.Add(this.txtREGC9);
            this.tabPage2.Controls.Add(this.txtREG49);
            this.tabPage2.Controls.Add(this.txtREG89);
            this.tabPage2.Controls.Add(this.txtREG09);
            this.tabPage2.Controls.Add(this.txtREGF1);
            this.tabPage2.Controls.Add(this.txtREG71);
            this.tabPage2.Controls.Add(this.txtREGB1);
            this.tabPage2.Controls.Add(this.txtREG31);
            this.tabPage2.Controls.Add(this.txtREGE1);
            this.tabPage2.Controls.Add(this.txtREG61);
            this.tabPage2.Controls.Add(this.txtREGA1);
            this.tabPage2.Controls.Add(this.txtREG21);
            this.tabPage2.Controls.Add(this.txtREGD1);
            this.tabPage2.Controls.Add(this.txtREG51);
            this.tabPage2.Controls.Add(this.txtREG91);
            this.tabPage2.Controls.Add(this.txtREG11);
            this.tabPage2.Controls.Add(this.txtREGC1);
            this.tabPage2.Controls.Add(this.txtREG41);
            this.tabPage2.Controls.Add(this.txtREG81);
            this.tabPage2.Controls.Add(this.txtREG01);
            this.tabPage2.Controls.Add(this.txtREGF8);
            this.tabPage2.Controls.Add(this.txtREG78);
            this.tabPage2.Controls.Add(this.txtREGB8);
            this.tabPage2.Controls.Add(this.txtREG38);
            this.tabPage2.Controls.Add(this.txtREGE8);
            this.tabPage2.Controls.Add(this.txtREG68);
            this.tabPage2.Controls.Add(this.txtREGA8);
            this.tabPage2.Controls.Add(this.txtREG28);
            this.tabPage2.Controls.Add(this.txtREGD8);
            this.tabPage2.Controls.Add(this.txtREG58);
            this.tabPage2.Controls.Add(this.txtREG98);
            this.tabPage2.Controls.Add(this.txtREG18);
            this.tabPage2.Controls.Add(this.txtREGC8);
            this.tabPage2.Controls.Add(this.txtREG48);
            this.tabPage2.Controls.Add(this.txtREG88);
            this.tabPage2.Controls.Add(this.txtREG08);
            this.tabPage2.Controls.Add(this.txtREGF0);
            this.tabPage2.Controls.Add(this.txtREG70);
            this.tabPage2.Controls.Add(this.txtREGB0);
            this.tabPage2.Controls.Add(this.txtREG30);
            this.tabPage2.Controls.Add(this.txtREGE0);
            this.tabPage2.Controls.Add(this.txtREG60);
            this.tabPage2.Controls.Add(this.txtREGA0);
            this.tabPage2.Controls.Add(this.txtREG20);
            this.tabPage2.Controls.Add(this.txtREGD0);
            this.tabPage2.Controls.Add(this.txtREG50);
            this.tabPage2.Controls.Add(this.txtREG90);
            this.tabPage2.Controls.Add(this.txtREG10);
            this.tabPage2.Controls.Add(this.txtREGC0);
            this.tabPage2.Controls.Add(this.txtREG40);
            this.tabPage2.Controls.Add(this.txtREG80);
            this.tabPage2.Controls.Add(this.txtREG00);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(498, 594);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "暫存器";
            // 
            // txtREG00
            // 
            this.txtREG00.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG00.Location = new System.Drawing.Point(43, 24);
            this.txtREG00.MaxLength = 2;
            this.txtREG00.Name = "txtREG00";
            this.txtREG00.Size = new System.Drawing.Size(27, 26);
            this.txtREG00.TabIndex = 0;
            this.txtREG00.Text = "FF";
            this.txtREG00.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG00.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG01
            // 
            this.txtREG01.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG01.Location = new System.Drawing.Point(71, 24);
            this.txtREG01.MaxLength = 2;
            this.txtREG01.Name = "txtREG01";
            this.txtREG01.Size = new System.Drawing.Size(27, 26);
            this.txtREG01.TabIndex = 0;
            this.txtREG01.Text = "00";
            this.txtREG01.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG01.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG02
            // 
            this.txtREG02.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG02.Location = new System.Drawing.Point(99, 24);
            this.txtREG02.MaxLength = 2;
            this.txtREG02.Name = "txtREG02";
            this.txtREG02.Size = new System.Drawing.Size(27, 26);
            this.txtREG02.TabIndex = 0;
            this.txtREG02.Text = "00";
            this.txtREG02.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG02.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG03
            // 
            this.txtREG03.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG03.Location = new System.Drawing.Point(127, 24);
            this.txtREG03.MaxLength = 2;
            this.txtREG03.Name = "txtREG03";
            this.txtREG03.Size = new System.Drawing.Size(27, 26);
            this.txtREG03.TabIndex = 0;
            this.txtREG03.Text = "00";
            this.txtREG03.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG03.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG04
            // 
            this.txtREG04.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG04.Location = new System.Drawing.Point(155, 24);
            this.txtREG04.MaxLength = 2;
            this.txtREG04.Name = "txtREG04";
            this.txtREG04.Size = new System.Drawing.Size(27, 26);
            this.txtREG04.TabIndex = 0;
            this.txtREG04.Text = "00";
            this.txtREG04.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG04.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG05
            // 
            this.txtREG05.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG05.Location = new System.Drawing.Point(183, 24);
            this.txtREG05.MaxLength = 2;
            this.txtREG05.Name = "txtREG05";
            this.txtREG05.Size = new System.Drawing.Size(27, 26);
            this.txtREG05.TabIndex = 0;
            this.txtREG05.Text = "00";
            this.txtREG05.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG05.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG06
            // 
            this.txtREG06.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG06.Location = new System.Drawing.Point(211, 24);
            this.txtREG06.MaxLength = 2;
            this.txtREG06.Name = "txtREG06";
            this.txtREG06.Size = new System.Drawing.Size(27, 26);
            this.txtREG06.TabIndex = 0;
            this.txtREG06.Text = "00";
            this.txtREG06.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG06.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG07
            // 
            this.txtREG07.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG07.Location = new System.Drawing.Point(239, 24);
            this.txtREG07.MaxLength = 2;
            this.txtREG07.Name = "txtREG07";
            this.txtREG07.Size = new System.Drawing.Size(27, 26);
            this.txtREG07.TabIndex = 0;
            this.txtREG07.Text = "00";
            this.txtREG07.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG07.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG08
            // 
            this.txtREG08.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG08.Location = new System.Drawing.Point(272, 24);
            this.txtREG08.MaxLength = 2;
            this.txtREG08.Name = "txtREG08";
            this.txtREG08.Size = new System.Drawing.Size(27, 26);
            this.txtREG08.TabIndex = 0;
            this.txtREG08.Text = "FF";
            this.txtREG08.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG08.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG09
            // 
            this.txtREG09.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG09.Location = new System.Drawing.Point(300, 24);
            this.txtREG09.MaxLength = 2;
            this.txtREG09.Name = "txtREG09";
            this.txtREG09.Size = new System.Drawing.Size(27, 26);
            this.txtREG09.TabIndex = 0;
            this.txtREG09.Text = "00";
            this.txtREG09.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG09.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG0A
            // 
            this.txtREG0A.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG0A.Location = new System.Drawing.Point(328, 24);
            this.txtREG0A.MaxLength = 2;
            this.txtREG0A.Name = "txtREG0A";
            this.txtREG0A.Size = new System.Drawing.Size(27, 26);
            this.txtREG0A.TabIndex = 0;
            this.txtREG0A.Text = "00";
            this.txtREG0A.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG0A.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG0B
            // 
            this.txtREG0B.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG0B.Location = new System.Drawing.Point(356, 24);
            this.txtREG0B.MaxLength = 2;
            this.txtREG0B.Name = "txtREG0B";
            this.txtREG0B.Size = new System.Drawing.Size(27, 26);
            this.txtREG0B.TabIndex = 0;
            this.txtREG0B.Text = "00";
            this.txtREG0B.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG0B.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG0C
            // 
            this.txtREG0C.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG0C.Location = new System.Drawing.Point(384, 24);
            this.txtREG0C.MaxLength = 2;
            this.txtREG0C.Name = "txtREG0C";
            this.txtREG0C.Size = new System.Drawing.Size(27, 26);
            this.txtREG0C.TabIndex = 0;
            this.txtREG0C.Text = "00";
            this.txtREG0C.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG0C.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG0D
            // 
            this.txtREG0D.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG0D.Location = new System.Drawing.Point(412, 24);
            this.txtREG0D.MaxLength = 2;
            this.txtREG0D.Name = "txtREG0D";
            this.txtREG0D.Size = new System.Drawing.Size(27, 26);
            this.txtREG0D.TabIndex = 0;
            this.txtREG0D.Text = "00";
            this.txtREG0D.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG0D.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG0E
            // 
            this.txtREG0E.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG0E.Location = new System.Drawing.Point(440, 24);
            this.txtREG0E.MaxLength = 2;
            this.txtREG0E.Name = "txtREG0E";
            this.txtREG0E.Size = new System.Drawing.Size(27, 26);
            this.txtREG0E.TabIndex = 0;
            this.txtREG0E.Text = "00";
            this.txtREG0E.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG0E.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG0F
            // 
            this.txtREG0F.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG0F.Location = new System.Drawing.Point(468, 24);
            this.txtREG0F.MaxLength = 2;
            this.txtREG0F.Name = "txtREG0F";
            this.txtREG0F.Size = new System.Drawing.Size(27, 26);
            this.txtREG0F.TabIndex = 0;
            this.txtREG0F.Text = "00";
            this.txtREG0F.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG0F.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG10
            // 
            this.txtREG10.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG10.Location = new System.Drawing.Point(43, 56);
            this.txtREG10.MaxLength = 2;
            this.txtREG10.Name = "txtREG10";
            this.txtREG10.Size = new System.Drawing.Size(27, 26);
            this.txtREG10.TabIndex = 0;
            this.txtREG10.Text = "FF";
            this.txtREG10.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG10.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG18
            // 
            this.txtREG18.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG18.Location = new System.Drawing.Point(272, 56);
            this.txtREG18.MaxLength = 2;
            this.txtREG18.Name = "txtREG18";
            this.txtREG18.Size = new System.Drawing.Size(27, 26);
            this.txtREG18.TabIndex = 0;
            this.txtREG18.Text = "FF";
            this.txtREG18.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG18.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG11
            // 
            this.txtREG11.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG11.Location = new System.Drawing.Point(71, 56);
            this.txtREG11.MaxLength = 2;
            this.txtREG11.Name = "txtREG11";
            this.txtREG11.Size = new System.Drawing.Size(27, 26);
            this.txtREG11.TabIndex = 0;
            this.txtREG11.Text = "00";
            this.txtREG11.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG11.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG19
            // 
            this.txtREG19.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG19.Location = new System.Drawing.Point(300, 56);
            this.txtREG19.MaxLength = 2;
            this.txtREG19.Name = "txtREG19";
            this.txtREG19.Size = new System.Drawing.Size(27, 26);
            this.txtREG19.TabIndex = 0;
            this.txtREG19.Text = "00";
            this.txtREG19.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG19.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG12
            // 
            this.txtREG12.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG12.Location = new System.Drawing.Point(99, 56);
            this.txtREG12.MaxLength = 2;
            this.txtREG12.Name = "txtREG12";
            this.txtREG12.Size = new System.Drawing.Size(27, 26);
            this.txtREG12.TabIndex = 0;
            this.txtREG12.Text = "00";
            this.txtREG12.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG12.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG1A
            // 
            this.txtREG1A.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG1A.Location = new System.Drawing.Point(328, 56);
            this.txtREG1A.MaxLength = 2;
            this.txtREG1A.Name = "txtREG1A";
            this.txtREG1A.Size = new System.Drawing.Size(27, 26);
            this.txtREG1A.TabIndex = 0;
            this.txtREG1A.Text = "00";
            this.txtREG1A.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG1A.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG13
            // 
            this.txtREG13.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG13.Location = new System.Drawing.Point(127, 56);
            this.txtREG13.MaxLength = 2;
            this.txtREG13.Name = "txtREG13";
            this.txtREG13.Size = new System.Drawing.Size(27, 26);
            this.txtREG13.TabIndex = 0;
            this.txtREG13.Text = "00";
            this.txtREG13.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG13.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG1B
            // 
            this.txtREG1B.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG1B.Location = new System.Drawing.Point(356, 56);
            this.txtREG1B.MaxLength = 2;
            this.txtREG1B.Name = "txtREG1B";
            this.txtREG1B.Size = new System.Drawing.Size(27, 26);
            this.txtREG1B.TabIndex = 0;
            this.txtREG1B.Text = "00";
            this.txtREG1B.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG1B.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG14
            // 
            this.txtREG14.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG14.Location = new System.Drawing.Point(155, 56);
            this.txtREG14.MaxLength = 2;
            this.txtREG14.Name = "txtREG14";
            this.txtREG14.Size = new System.Drawing.Size(27, 26);
            this.txtREG14.TabIndex = 0;
            this.txtREG14.Text = "00";
            this.txtREG14.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG14.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG1C
            // 
            this.txtREG1C.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG1C.Location = new System.Drawing.Point(384, 56);
            this.txtREG1C.MaxLength = 2;
            this.txtREG1C.Name = "txtREG1C";
            this.txtREG1C.Size = new System.Drawing.Size(27, 26);
            this.txtREG1C.TabIndex = 0;
            this.txtREG1C.Text = "00";
            this.txtREG1C.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG1C.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG15
            // 
            this.txtREG15.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG15.Location = new System.Drawing.Point(183, 56);
            this.txtREG15.MaxLength = 2;
            this.txtREG15.Name = "txtREG15";
            this.txtREG15.Size = new System.Drawing.Size(27, 26);
            this.txtREG15.TabIndex = 0;
            this.txtREG15.Text = "00";
            this.txtREG15.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG15.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG1D
            // 
            this.txtREG1D.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG1D.Location = new System.Drawing.Point(412, 56);
            this.txtREG1D.MaxLength = 2;
            this.txtREG1D.Name = "txtREG1D";
            this.txtREG1D.Size = new System.Drawing.Size(27, 26);
            this.txtREG1D.TabIndex = 0;
            this.txtREG1D.Text = "00";
            this.txtREG1D.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG1D.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG16
            // 
            this.txtREG16.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG16.Location = new System.Drawing.Point(211, 56);
            this.txtREG16.MaxLength = 2;
            this.txtREG16.Name = "txtREG16";
            this.txtREG16.Size = new System.Drawing.Size(27, 26);
            this.txtREG16.TabIndex = 0;
            this.txtREG16.Text = "00";
            this.txtREG16.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG16.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG1E
            // 
            this.txtREG1E.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG1E.Location = new System.Drawing.Point(440, 56);
            this.txtREG1E.MaxLength = 2;
            this.txtREG1E.Name = "txtREG1E";
            this.txtREG1E.Size = new System.Drawing.Size(27, 26);
            this.txtREG1E.TabIndex = 0;
            this.txtREG1E.Text = "00";
            this.txtREG1E.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG1E.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG17
            // 
            this.txtREG17.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG17.Location = new System.Drawing.Point(239, 56);
            this.txtREG17.MaxLength = 2;
            this.txtREG17.Name = "txtREG17";
            this.txtREG17.Size = new System.Drawing.Size(27, 26);
            this.txtREG17.TabIndex = 0;
            this.txtREG17.Text = "00";
            this.txtREG17.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG17.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG1F
            // 
            this.txtREG1F.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG1F.Location = new System.Drawing.Point(468, 56);
            this.txtREG1F.MaxLength = 2;
            this.txtREG1F.Name = "txtREG1F";
            this.txtREG1F.Size = new System.Drawing.Size(27, 26);
            this.txtREG1F.TabIndex = 0;
            this.txtREG1F.Text = "00";
            this.txtREG1F.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG1F.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG20
            // 
            this.txtREG20.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG20.Location = new System.Drawing.Point(43, 88);
            this.txtREG20.MaxLength = 2;
            this.txtREG20.Name = "txtREG20";
            this.txtREG20.Size = new System.Drawing.Size(27, 26);
            this.txtREG20.TabIndex = 0;
            this.txtREG20.Text = "FF";
            this.txtREG20.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG20.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG28
            // 
            this.txtREG28.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG28.Location = new System.Drawing.Point(272, 88);
            this.txtREG28.MaxLength = 2;
            this.txtREG28.Name = "txtREG28";
            this.txtREG28.Size = new System.Drawing.Size(27, 26);
            this.txtREG28.TabIndex = 0;
            this.txtREG28.Text = "FF";
            this.txtREG28.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG28.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG21
            // 
            this.txtREG21.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG21.Location = new System.Drawing.Point(71, 88);
            this.txtREG21.MaxLength = 2;
            this.txtREG21.Name = "txtREG21";
            this.txtREG21.Size = new System.Drawing.Size(27, 26);
            this.txtREG21.TabIndex = 0;
            this.txtREG21.Text = "00";
            this.txtREG21.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG21.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG29
            // 
            this.txtREG29.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG29.Location = new System.Drawing.Point(300, 88);
            this.txtREG29.MaxLength = 2;
            this.txtREG29.Name = "txtREG29";
            this.txtREG29.Size = new System.Drawing.Size(27, 26);
            this.txtREG29.TabIndex = 0;
            this.txtREG29.Text = "00";
            this.txtREG29.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG29.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG22
            // 
            this.txtREG22.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG22.Location = new System.Drawing.Point(99, 88);
            this.txtREG22.MaxLength = 2;
            this.txtREG22.Name = "txtREG22";
            this.txtREG22.Size = new System.Drawing.Size(27, 26);
            this.txtREG22.TabIndex = 0;
            this.txtREG22.Text = "00";
            this.txtREG22.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG22.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG2A
            // 
            this.txtREG2A.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG2A.Location = new System.Drawing.Point(328, 88);
            this.txtREG2A.MaxLength = 2;
            this.txtREG2A.Name = "txtREG2A";
            this.txtREG2A.Size = new System.Drawing.Size(27, 26);
            this.txtREG2A.TabIndex = 0;
            this.txtREG2A.Text = "00";
            this.txtREG2A.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG2A.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG23
            // 
            this.txtREG23.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG23.Location = new System.Drawing.Point(127, 88);
            this.txtREG23.MaxLength = 2;
            this.txtREG23.Name = "txtREG23";
            this.txtREG23.Size = new System.Drawing.Size(27, 26);
            this.txtREG23.TabIndex = 0;
            this.txtREG23.Text = "00";
            this.txtREG23.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG23.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG2B
            // 
            this.txtREG2B.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG2B.Location = new System.Drawing.Point(356, 88);
            this.txtREG2B.MaxLength = 2;
            this.txtREG2B.Name = "txtREG2B";
            this.txtREG2B.Size = new System.Drawing.Size(27, 26);
            this.txtREG2B.TabIndex = 0;
            this.txtREG2B.Text = "00";
            this.txtREG2B.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG2B.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG24
            // 
            this.txtREG24.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG24.Location = new System.Drawing.Point(155, 88);
            this.txtREG24.MaxLength = 2;
            this.txtREG24.Name = "txtREG24";
            this.txtREG24.Size = new System.Drawing.Size(27, 26);
            this.txtREG24.TabIndex = 0;
            this.txtREG24.Text = "00";
            this.txtREG24.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG24.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG2C
            // 
            this.txtREG2C.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG2C.Location = new System.Drawing.Point(384, 88);
            this.txtREG2C.MaxLength = 2;
            this.txtREG2C.Name = "txtREG2C";
            this.txtREG2C.Size = new System.Drawing.Size(27, 26);
            this.txtREG2C.TabIndex = 0;
            this.txtREG2C.Text = "00";
            this.txtREG2C.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG2C.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG25
            // 
            this.txtREG25.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG25.Location = new System.Drawing.Point(183, 88);
            this.txtREG25.MaxLength = 2;
            this.txtREG25.Name = "txtREG25";
            this.txtREG25.Size = new System.Drawing.Size(27, 26);
            this.txtREG25.TabIndex = 0;
            this.txtREG25.Text = "00";
            this.txtREG25.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG25.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG2D
            // 
            this.txtREG2D.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG2D.Location = new System.Drawing.Point(412, 88);
            this.txtREG2D.MaxLength = 2;
            this.txtREG2D.Name = "txtREG2D";
            this.txtREG2D.Size = new System.Drawing.Size(27, 26);
            this.txtREG2D.TabIndex = 0;
            this.txtREG2D.Text = "00";
            this.txtREG2D.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG2D.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG26
            // 
            this.txtREG26.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG26.Location = new System.Drawing.Point(211, 88);
            this.txtREG26.MaxLength = 2;
            this.txtREG26.Name = "txtREG26";
            this.txtREG26.Size = new System.Drawing.Size(27, 26);
            this.txtREG26.TabIndex = 0;
            this.txtREG26.Text = "00";
            this.txtREG26.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG26.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG2E
            // 
            this.txtREG2E.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG2E.Location = new System.Drawing.Point(440, 88);
            this.txtREG2E.MaxLength = 2;
            this.txtREG2E.Name = "txtREG2E";
            this.txtREG2E.Size = new System.Drawing.Size(27, 26);
            this.txtREG2E.TabIndex = 0;
            this.txtREG2E.Text = "00";
            this.txtREG2E.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG2E.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG27
            // 
            this.txtREG27.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG27.Location = new System.Drawing.Point(239, 88);
            this.txtREG27.MaxLength = 2;
            this.txtREG27.Name = "txtREG27";
            this.txtREG27.Size = new System.Drawing.Size(27, 26);
            this.txtREG27.TabIndex = 0;
            this.txtREG27.Text = "00";
            this.txtREG27.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG27.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG2F
            // 
            this.txtREG2F.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG2F.Location = new System.Drawing.Point(468, 88);
            this.txtREG2F.MaxLength = 2;
            this.txtREG2F.Name = "txtREG2F";
            this.txtREG2F.Size = new System.Drawing.Size(27, 26);
            this.txtREG2F.TabIndex = 0;
            this.txtREG2F.Text = "00";
            this.txtREG2F.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG2F.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG30
            // 
            this.txtREG30.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG30.Location = new System.Drawing.Point(43, 120);
            this.txtREG30.MaxLength = 2;
            this.txtREG30.Name = "txtREG30";
            this.txtREG30.Size = new System.Drawing.Size(27, 26);
            this.txtREG30.TabIndex = 0;
            this.txtREG30.Text = "FF";
            this.txtREG30.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG30.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG38
            // 
            this.txtREG38.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG38.Location = new System.Drawing.Point(272, 120);
            this.txtREG38.MaxLength = 2;
            this.txtREG38.Name = "txtREG38";
            this.txtREG38.Size = new System.Drawing.Size(27, 26);
            this.txtREG38.TabIndex = 0;
            this.txtREG38.Text = "FF";
            this.txtREG38.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG38.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG31
            // 
            this.txtREG31.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG31.Location = new System.Drawing.Point(71, 120);
            this.txtREG31.MaxLength = 2;
            this.txtREG31.Name = "txtREG31";
            this.txtREG31.Size = new System.Drawing.Size(27, 26);
            this.txtREG31.TabIndex = 0;
            this.txtREG31.Text = "00";
            this.txtREG31.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG31.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG39
            // 
            this.txtREG39.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG39.Location = new System.Drawing.Point(300, 120);
            this.txtREG39.MaxLength = 2;
            this.txtREG39.Name = "txtREG39";
            this.txtREG39.Size = new System.Drawing.Size(27, 26);
            this.txtREG39.TabIndex = 0;
            this.txtREG39.Text = "00";
            this.txtREG39.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG39.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG32
            // 
            this.txtREG32.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG32.Location = new System.Drawing.Point(99, 120);
            this.txtREG32.MaxLength = 2;
            this.txtREG32.Name = "txtREG32";
            this.txtREG32.Size = new System.Drawing.Size(27, 26);
            this.txtREG32.TabIndex = 0;
            this.txtREG32.Text = "00";
            this.txtREG32.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG32.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG3A
            // 
            this.txtREG3A.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG3A.Location = new System.Drawing.Point(328, 120);
            this.txtREG3A.MaxLength = 2;
            this.txtREG3A.Name = "txtREG3A";
            this.txtREG3A.Size = new System.Drawing.Size(27, 26);
            this.txtREG3A.TabIndex = 0;
            this.txtREG3A.Text = "00";
            this.txtREG3A.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG3A.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG33
            // 
            this.txtREG33.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG33.Location = new System.Drawing.Point(127, 120);
            this.txtREG33.MaxLength = 2;
            this.txtREG33.Name = "txtREG33";
            this.txtREG33.Size = new System.Drawing.Size(27, 26);
            this.txtREG33.TabIndex = 0;
            this.txtREG33.Text = "00";
            this.txtREG33.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG33.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG3B
            // 
            this.txtREG3B.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG3B.Location = new System.Drawing.Point(356, 120);
            this.txtREG3B.MaxLength = 2;
            this.txtREG3B.Name = "txtREG3B";
            this.txtREG3B.Size = new System.Drawing.Size(27, 26);
            this.txtREG3B.TabIndex = 0;
            this.txtREG3B.Text = "00";
            this.txtREG3B.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG3B.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG34
            // 
            this.txtREG34.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG34.Location = new System.Drawing.Point(155, 120);
            this.txtREG34.MaxLength = 2;
            this.txtREG34.Name = "txtREG34";
            this.txtREG34.Size = new System.Drawing.Size(27, 26);
            this.txtREG34.TabIndex = 0;
            this.txtREG34.Text = "00";
            this.txtREG34.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG34.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG3C
            // 
            this.txtREG3C.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG3C.Location = new System.Drawing.Point(384, 120);
            this.txtREG3C.MaxLength = 2;
            this.txtREG3C.Name = "txtREG3C";
            this.txtREG3C.Size = new System.Drawing.Size(27, 26);
            this.txtREG3C.TabIndex = 0;
            this.txtREG3C.Text = "00";
            this.txtREG3C.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG3C.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG35
            // 
            this.txtREG35.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG35.Location = new System.Drawing.Point(183, 120);
            this.txtREG35.MaxLength = 2;
            this.txtREG35.Name = "txtREG35";
            this.txtREG35.Size = new System.Drawing.Size(27, 26);
            this.txtREG35.TabIndex = 0;
            this.txtREG35.Text = "00";
            this.txtREG35.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG35.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG3D
            // 
            this.txtREG3D.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG3D.Location = new System.Drawing.Point(412, 120);
            this.txtREG3D.MaxLength = 2;
            this.txtREG3D.Name = "txtREG3D";
            this.txtREG3D.Size = new System.Drawing.Size(27, 26);
            this.txtREG3D.TabIndex = 0;
            this.txtREG3D.Text = "00";
            this.txtREG3D.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG3D.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG36
            // 
            this.txtREG36.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG36.Location = new System.Drawing.Point(211, 120);
            this.txtREG36.MaxLength = 2;
            this.txtREG36.Name = "txtREG36";
            this.txtREG36.Size = new System.Drawing.Size(27, 26);
            this.txtREG36.TabIndex = 0;
            this.txtREG36.Text = "00";
            this.txtREG36.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG36.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG3E
            // 
            this.txtREG3E.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG3E.Location = new System.Drawing.Point(440, 120);
            this.txtREG3E.MaxLength = 2;
            this.txtREG3E.Name = "txtREG3E";
            this.txtREG3E.Size = new System.Drawing.Size(27, 26);
            this.txtREG3E.TabIndex = 0;
            this.txtREG3E.Text = "00";
            this.txtREG3E.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG3E.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG37
            // 
            this.txtREG37.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG37.Location = new System.Drawing.Point(239, 120);
            this.txtREG37.MaxLength = 2;
            this.txtREG37.Name = "txtREG37";
            this.txtREG37.Size = new System.Drawing.Size(27, 26);
            this.txtREG37.TabIndex = 0;
            this.txtREG37.Text = "00";
            this.txtREG37.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG37.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG3F
            // 
            this.txtREG3F.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG3F.Location = new System.Drawing.Point(468, 120);
            this.txtREG3F.MaxLength = 2;
            this.txtREG3F.Name = "txtREG3F";
            this.txtREG3F.Size = new System.Drawing.Size(27, 26);
            this.txtREG3F.TabIndex = 0;
            this.txtREG3F.Text = "00";
            this.txtREG3F.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG3F.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG40
            // 
            this.txtREG40.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG40.Location = new System.Drawing.Point(43, 152);
            this.txtREG40.MaxLength = 2;
            this.txtREG40.Name = "txtREG40";
            this.txtREG40.Size = new System.Drawing.Size(27, 26);
            this.txtREG40.TabIndex = 0;
            this.txtREG40.Text = "FF";
            this.txtREG40.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG40.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG50
            // 
            this.txtREG50.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG50.Location = new System.Drawing.Point(43, 184);
            this.txtREG50.MaxLength = 2;
            this.txtREG50.Name = "txtREG50";
            this.txtREG50.Size = new System.Drawing.Size(27, 26);
            this.txtREG50.TabIndex = 0;
            this.txtREG50.Text = "FF";
            this.txtREG50.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG50.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG60
            // 
            this.txtREG60.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG60.Location = new System.Drawing.Point(43, 216);
            this.txtREG60.MaxLength = 2;
            this.txtREG60.Name = "txtREG60";
            this.txtREG60.Size = new System.Drawing.Size(27, 26);
            this.txtREG60.TabIndex = 0;
            this.txtREG60.Text = "FF";
            this.txtREG60.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG60.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG70
            // 
            this.txtREG70.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG70.Location = new System.Drawing.Point(43, 248);
            this.txtREG70.MaxLength = 2;
            this.txtREG70.Name = "txtREG70";
            this.txtREG70.Size = new System.Drawing.Size(27, 26);
            this.txtREG70.TabIndex = 0;
            this.txtREG70.Text = "FF";
            this.txtREG70.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG70.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG48
            // 
            this.txtREG48.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG48.Location = new System.Drawing.Point(272, 152);
            this.txtREG48.MaxLength = 2;
            this.txtREG48.Name = "txtREG48";
            this.txtREG48.Size = new System.Drawing.Size(27, 26);
            this.txtREG48.TabIndex = 0;
            this.txtREG48.Text = "FF";
            this.txtREG48.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG48.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG58
            // 
            this.txtREG58.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG58.Location = new System.Drawing.Point(272, 184);
            this.txtREG58.MaxLength = 2;
            this.txtREG58.Name = "txtREG58";
            this.txtREG58.Size = new System.Drawing.Size(27, 26);
            this.txtREG58.TabIndex = 0;
            this.txtREG58.Text = "FF";
            this.txtREG58.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG58.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG68
            // 
            this.txtREG68.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG68.Location = new System.Drawing.Point(272, 216);
            this.txtREG68.MaxLength = 2;
            this.txtREG68.Name = "txtREG68";
            this.txtREG68.Size = new System.Drawing.Size(27, 26);
            this.txtREG68.TabIndex = 0;
            this.txtREG68.Text = "FF";
            this.txtREG68.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG68.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG78
            // 
            this.txtREG78.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG78.Location = new System.Drawing.Point(272, 248);
            this.txtREG78.MaxLength = 2;
            this.txtREG78.Name = "txtREG78";
            this.txtREG78.Size = new System.Drawing.Size(27, 26);
            this.txtREG78.TabIndex = 0;
            this.txtREG78.Text = "FF";
            this.txtREG78.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG78.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG41
            // 
            this.txtREG41.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG41.Location = new System.Drawing.Point(71, 152);
            this.txtREG41.MaxLength = 2;
            this.txtREG41.Name = "txtREG41";
            this.txtREG41.Size = new System.Drawing.Size(27, 26);
            this.txtREG41.TabIndex = 0;
            this.txtREG41.Text = "00";
            this.txtREG41.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG41.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG51
            // 
            this.txtREG51.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG51.Location = new System.Drawing.Point(71, 184);
            this.txtREG51.MaxLength = 2;
            this.txtREG51.Name = "txtREG51";
            this.txtREG51.Size = new System.Drawing.Size(27, 26);
            this.txtREG51.TabIndex = 0;
            this.txtREG51.Text = "00";
            this.txtREG51.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG51.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG61
            // 
            this.txtREG61.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG61.Location = new System.Drawing.Point(71, 216);
            this.txtREG61.MaxLength = 2;
            this.txtREG61.Name = "txtREG61";
            this.txtREG61.Size = new System.Drawing.Size(27, 26);
            this.txtREG61.TabIndex = 0;
            this.txtREG61.Text = "00";
            this.txtREG61.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG61.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG71
            // 
            this.txtREG71.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG71.Location = new System.Drawing.Point(71, 248);
            this.txtREG71.MaxLength = 2;
            this.txtREG71.Name = "txtREG71";
            this.txtREG71.Size = new System.Drawing.Size(27, 26);
            this.txtREG71.TabIndex = 0;
            this.txtREG71.Text = "00";
            this.txtREG71.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG71.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG49
            // 
            this.txtREG49.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG49.Location = new System.Drawing.Point(300, 152);
            this.txtREG49.MaxLength = 2;
            this.txtREG49.Name = "txtREG49";
            this.txtREG49.Size = new System.Drawing.Size(27, 26);
            this.txtREG49.TabIndex = 0;
            this.txtREG49.Text = "00";
            this.txtREG49.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG49.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG59
            // 
            this.txtREG59.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG59.Location = new System.Drawing.Point(300, 184);
            this.txtREG59.MaxLength = 2;
            this.txtREG59.Name = "txtREG59";
            this.txtREG59.Size = new System.Drawing.Size(27, 26);
            this.txtREG59.TabIndex = 0;
            this.txtREG59.Text = "00";
            this.txtREG59.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG59.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG69
            // 
            this.txtREG69.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG69.Location = new System.Drawing.Point(300, 216);
            this.txtREG69.MaxLength = 2;
            this.txtREG69.Name = "txtREG69";
            this.txtREG69.Size = new System.Drawing.Size(27, 26);
            this.txtREG69.TabIndex = 0;
            this.txtREG69.Text = "00";
            this.txtREG69.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG69.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG79
            // 
            this.txtREG79.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG79.Location = new System.Drawing.Point(300, 248);
            this.txtREG79.MaxLength = 2;
            this.txtREG79.Name = "txtREG79";
            this.txtREG79.Size = new System.Drawing.Size(27, 26);
            this.txtREG79.TabIndex = 0;
            this.txtREG79.Text = "00";
            this.txtREG79.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG79.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG42
            // 
            this.txtREG42.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG42.Location = new System.Drawing.Point(99, 152);
            this.txtREG42.MaxLength = 2;
            this.txtREG42.Name = "txtREG42";
            this.txtREG42.Size = new System.Drawing.Size(27, 26);
            this.txtREG42.TabIndex = 0;
            this.txtREG42.Text = "00";
            this.txtREG42.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG42.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG52
            // 
            this.txtREG52.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG52.Location = new System.Drawing.Point(99, 184);
            this.txtREG52.MaxLength = 2;
            this.txtREG52.Name = "txtREG52";
            this.txtREG52.Size = new System.Drawing.Size(27, 26);
            this.txtREG52.TabIndex = 0;
            this.txtREG52.Text = "00";
            this.txtREG52.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG52.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG62
            // 
            this.txtREG62.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG62.Location = new System.Drawing.Point(99, 216);
            this.txtREG62.MaxLength = 2;
            this.txtREG62.Name = "txtREG62";
            this.txtREG62.Size = new System.Drawing.Size(27, 26);
            this.txtREG62.TabIndex = 0;
            this.txtREG62.Text = "00";
            this.txtREG62.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG62.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG72
            // 
            this.txtREG72.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG72.Location = new System.Drawing.Point(99, 248);
            this.txtREG72.MaxLength = 2;
            this.txtREG72.Name = "txtREG72";
            this.txtREG72.Size = new System.Drawing.Size(27, 26);
            this.txtREG72.TabIndex = 0;
            this.txtREG72.Text = "00";
            this.txtREG72.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG72.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG4A
            // 
            this.txtREG4A.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG4A.Location = new System.Drawing.Point(328, 152);
            this.txtREG4A.MaxLength = 2;
            this.txtREG4A.Name = "txtREG4A";
            this.txtREG4A.Size = new System.Drawing.Size(27, 26);
            this.txtREG4A.TabIndex = 0;
            this.txtREG4A.Text = "00";
            this.txtREG4A.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG4A.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG5A
            // 
            this.txtREG5A.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG5A.Location = new System.Drawing.Point(328, 184);
            this.txtREG5A.MaxLength = 2;
            this.txtREG5A.Name = "txtREG5A";
            this.txtREG5A.Size = new System.Drawing.Size(27, 26);
            this.txtREG5A.TabIndex = 0;
            this.txtREG5A.Text = "00";
            this.txtREG5A.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG5A.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG6A
            // 
            this.txtREG6A.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG6A.Location = new System.Drawing.Point(328, 216);
            this.txtREG6A.MaxLength = 2;
            this.txtREG6A.Name = "txtREG6A";
            this.txtREG6A.Size = new System.Drawing.Size(27, 26);
            this.txtREG6A.TabIndex = 0;
            this.txtREG6A.Text = "00";
            this.txtREG6A.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG6A.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG7A
            // 
            this.txtREG7A.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG7A.Location = new System.Drawing.Point(328, 248);
            this.txtREG7A.MaxLength = 2;
            this.txtREG7A.Name = "txtREG7A";
            this.txtREG7A.Size = new System.Drawing.Size(27, 26);
            this.txtREG7A.TabIndex = 0;
            this.txtREG7A.Text = "00";
            this.txtREG7A.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG7A.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG43
            // 
            this.txtREG43.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG43.Location = new System.Drawing.Point(127, 152);
            this.txtREG43.MaxLength = 2;
            this.txtREG43.Name = "txtREG43";
            this.txtREG43.Size = new System.Drawing.Size(27, 26);
            this.txtREG43.TabIndex = 0;
            this.txtREG43.Text = "00";
            this.txtREG43.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG43.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG53
            // 
            this.txtREG53.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG53.Location = new System.Drawing.Point(127, 184);
            this.txtREG53.MaxLength = 2;
            this.txtREG53.Name = "txtREG53";
            this.txtREG53.Size = new System.Drawing.Size(27, 26);
            this.txtREG53.TabIndex = 0;
            this.txtREG53.Text = "00";
            this.txtREG53.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG53.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG63
            // 
            this.txtREG63.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG63.Location = new System.Drawing.Point(127, 216);
            this.txtREG63.MaxLength = 2;
            this.txtREG63.Name = "txtREG63";
            this.txtREG63.Size = new System.Drawing.Size(27, 26);
            this.txtREG63.TabIndex = 0;
            this.txtREG63.Text = "00";
            this.txtREG63.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG63.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG73
            // 
            this.txtREG73.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG73.Location = new System.Drawing.Point(127, 248);
            this.txtREG73.MaxLength = 2;
            this.txtREG73.Name = "txtREG73";
            this.txtREG73.Size = new System.Drawing.Size(27, 26);
            this.txtREG73.TabIndex = 0;
            this.txtREG73.Text = "00";
            this.txtREG73.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG73.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG4B
            // 
            this.txtREG4B.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG4B.Location = new System.Drawing.Point(356, 152);
            this.txtREG4B.MaxLength = 2;
            this.txtREG4B.Name = "txtREG4B";
            this.txtREG4B.Size = new System.Drawing.Size(27, 26);
            this.txtREG4B.TabIndex = 0;
            this.txtREG4B.Text = "00";
            this.txtREG4B.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG4B.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG5B
            // 
            this.txtREG5B.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG5B.Location = new System.Drawing.Point(356, 184);
            this.txtREG5B.MaxLength = 2;
            this.txtREG5B.Name = "txtREG5B";
            this.txtREG5B.Size = new System.Drawing.Size(27, 26);
            this.txtREG5B.TabIndex = 0;
            this.txtREG5B.Text = "00";
            this.txtREG5B.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG5B.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG6B
            // 
            this.txtREG6B.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG6B.Location = new System.Drawing.Point(356, 216);
            this.txtREG6B.MaxLength = 2;
            this.txtREG6B.Name = "txtREG6B";
            this.txtREG6B.Size = new System.Drawing.Size(27, 26);
            this.txtREG6B.TabIndex = 0;
            this.txtREG6B.Text = "00";
            this.txtREG6B.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG6B.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG7B
            // 
            this.txtREG7B.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG7B.Location = new System.Drawing.Point(356, 248);
            this.txtREG7B.MaxLength = 2;
            this.txtREG7B.Name = "txtREG7B";
            this.txtREG7B.Size = new System.Drawing.Size(27, 26);
            this.txtREG7B.TabIndex = 0;
            this.txtREG7B.Text = "00";
            this.txtREG7B.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG7B.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG44
            // 
            this.txtREG44.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG44.Location = new System.Drawing.Point(155, 152);
            this.txtREG44.MaxLength = 2;
            this.txtREG44.Name = "txtREG44";
            this.txtREG44.Size = new System.Drawing.Size(27, 26);
            this.txtREG44.TabIndex = 0;
            this.txtREG44.Text = "00";
            this.txtREG44.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG44.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG54
            // 
            this.txtREG54.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG54.Location = new System.Drawing.Point(155, 184);
            this.txtREG54.MaxLength = 2;
            this.txtREG54.Name = "txtREG54";
            this.txtREG54.Size = new System.Drawing.Size(27, 26);
            this.txtREG54.TabIndex = 0;
            this.txtREG54.Text = "00";
            this.txtREG54.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG54.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG64
            // 
            this.txtREG64.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG64.Location = new System.Drawing.Point(155, 216);
            this.txtREG64.MaxLength = 2;
            this.txtREG64.Name = "txtREG64";
            this.txtREG64.Size = new System.Drawing.Size(27, 26);
            this.txtREG64.TabIndex = 0;
            this.txtREG64.Text = "00";
            this.txtREG64.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG64.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG74
            // 
            this.txtREG74.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG74.Location = new System.Drawing.Point(155, 248);
            this.txtREG74.MaxLength = 2;
            this.txtREG74.Name = "txtREG74";
            this.txtREG74.Size = new System.Drawing.Size(27, 26);
            this.txtREG74.TabIndex = 0;
            this.txtREG74.Text = "00";
            this.txtREG74.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG74.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG4C
            // 
            this.txtREG4C.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG4C.Location = new System.Drawing.Point(384, 152);
            this.txtREG4C.MaxLength = 2;
            this.txtREG4C.Name = "txtREG4C";
            this.txtREG4C.Size = new System.Drawing.Size(27, 26);
            this.txtREG4C.TabIndex = 0;
            this.txtREG4C.Text = "00";
            this.txtREG4C.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG4C.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG5C
            // 
            this.txtREG5C.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG5C.Location = new System.Drawing.Point(384, 184);
            this.txtREG5C.MaxLength = 2;
            this.txtREG5C.Name = "txtREG5C";
            this.txtREG5C.Size = new System.Drawing.Size(27, 26);
            this.txtREG5C.TabIndex = 0;
            this.txtREG5C.Text = "00";
            this.txtREG5C.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG5C.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG6C
            // 
            this.txtREG6C.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG6C.Location = new System.Drawing.Point(384, 216);
            this.txtREG6C.MaxLength = 2;
            this.txtREG6C.Name = "txtREG6C";
            this.txtREG6C.Size = new System.Drawing.Size(27, 26);
            this.txtREG6C.TabIndex = 0;
            this.txtREG6C.Text = "00";
            this.txtREG6C.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG6C.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG7C
            // 
            this.txtREG7C.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG7C.Location = new System.Drawing.Point(384, 248);
            this.txtREG7C.MaxLength = 2;
            this.txtREG7C.Name = "txtREG7C";
            this.txtREG7C.Size = new System.Drawing.Size(27, 26);
            this.txtREG7C.TabIndex = 0;
            this.txtREG7C.Text = "00";
            this.txtREG7C.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG7C.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG45
            // 
            this.txtREG45.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG45.Location = new System.Drawing.Point(183, 152);
            this.txtREG45.MaxLength = 2;
            this.txtREG45.Name = "txtREG45";
            this.txtREG45.Size = new System.Drawing.Size(27, 26);
            this.txtREG45.TabIndex = 0;
            this.txtREG45.Text = "00";
            this.txtREG45.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG45.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG55
            // 
            this.txtREG55.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG55.Location = new System.Drawing.Point(183, 184);
            this.txtREG55.MaxLength = 2;
            this.txtREG55.Name = "txtREG55";
            this.txtREG55.Size = new System.Drawing.Size(27, 26);
            this.txtREG55.TabIndex = 0;
            this.txtREG55.Text = "00";
            this.txtREG55.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG55.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG65
            // 
            this.txtREG65.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG65.Location = new System.Drawing.Point(183, 216);
            this.txtREG65.MaxLength = 2;
            this.txtREG65.Name = "txtREG65";
            this.txtREG65.Size = new System.Drawing.Size(27, 26);
            this.txtREG65.TabIndex = 0;
            this.txtREG65.Text = "00";
            this.txtREG65.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG65.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG75
            // 
            this.txtREG75.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG75.Location = new System.Drawing.Point(183, 248);
            this.txtREG75.MaxLength = 2;
            this.txtREG75.Name = "txtREG75";
            this.txtREG75.Size = new System.Drawing.Size(27, 26);
            this.txtREG75.TabIndex = 0;
            this.txtREG75.Text = "00";
            this.txtREG75.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG75.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG4D
            // 
            this.txtREG4D.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG4D.Location = new System.Drawing.Point(412, 152);
            this.txtREG4D.MaxLength = 2;
            this.txtREG4D.Name = "txtREG4D";
            this.txtREG4D.Size = new System.Drawing.Size(27, 26);
            this.txtREG4D.TabIndex = 0;
            this.txtREG4D.Text = "00";
            this.txtREG4D.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG4D.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG5D
            // 
            this.txtREG5D.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG5D.Location = new System.Drawing.Point(412, 184);
            this.txtREG5D.MaxLength = 2;
            this.txtREG5D.Name = "txtREG5D";
            this.txtREG5D.Size = new System.Drawing.Size(27, 26);
            this.txtREG5D.TabIndex = 0;
            this.txtREG5D.Text = "00";
            this.txtREG5D.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG5D.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG6D
            // 
            this.txtREG6D.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG6D.Location = new System.Drawing.Point(412, 216);
            this.txtREG6D.MaxLength = 2;
            this.txtREG6D.Name = "txtREG6D";
            this.txtREG6D.Size = new System.Drawing.Size(27, 26);
            this.txtREG6D.TabIndex = 0;
            this.txtREG6D.Text = "00";
            this.txtREG6D.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG6D.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG7D
            // 
            this.txtREG7D.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG7D.Location = new System.Drawing.Point(412, 248);
            this.txtREG7D.MaxLength = 2;
            this.txtREG7D.Name = "txtREG7D";
            this.txtREG7D.Size = new System.Drawing.Size(27, 26);
            this.txtREG7D.TabIndex = 0;
            this.txtREG7D.Text = "00";
            this.txtREG7D.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG7D.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG46
            // 
            this.txtREG46.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG46.Location = new System.Drawing.Point(211, 152);
            this.txtREG46.MaxLength = 2;
            this.txtREG46.Name = "txtREG46";
            this.txtREG46.Size = new System.Drawing.Size(27, 26);
            this.txtREG46.TabIndex = 0;
            this.txtREG46.Text = "00";
            this.txtREG46.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG46.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG56
            // 
            this.txtREG56.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG56.Location = new System.Drawing.Point(211, 184);
            this.txtREG56.MaxLength = 2;
            this.txtREG56.Name = "txtREG56";
            this.txtREG56.Size = new System.Drawing.Size(27, 26);
            this.txtREG56.TabIndex = 0;
            this.txtREG56.Text = "00";
            this.txtREG56.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG56.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG66
            // 
            this.txtREG66.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG66.Location = new System.Drawing.Point(211, 216);
            this.txtREG66.MaxLength = 2;
            this.txtREG66.Name = "txtREG66";
            this.txtREG66.Size = new System.Drawing.Size(27, 26);
            this.txtREG66.TabIndex = 0;
            this.txtREG66.Text = "00";
            this.txtREG66.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG66.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG76
            // 
            this.txtREG76.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG76.Location = new System.Drawing.Point(211, 248);
            this.txtREG76.MaxLength = 2;
            this.txtREG76.Name = "txtREG76";
            this.txtREG76.Size = new System.Drawing.Size(27, 26);
            this.txtREG76.TabIndex = 0;
            this.txtREG76.Text = "00";
            this.txtREG76.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG76.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG4E
            // 
            this.txtREG4E.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG4E.Location = new System.Drawing.Point(440, 152);
            this.txtREG4E.MaxLength = 2;
            this.txtREG4E.Name = "txtREG4E";
            this.txtREG4E.Size = new System.Drawing.Size(27, 26);
            this.txtREG4E.TabIndex = 0;
            this.txtREG4E.Text = "00";
            this.txtREG4E.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG4E.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG5E
            // 
            this.txtREG5E.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG5E.Location = new System.Drawing.Point(440, 184);
            this.txtREG5E.MaxLength = 2;
            this.txtREG5E.Name = "txtREG5E";
            this.txtREG5E.Size = new System.Drawing.Size(27, 26);
            this.txtREG5E.TabIndex = 0;
            this.txtREG5E.Text = "00";
            this.txtREG5E.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG5E.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG6E
            // 
            this.txtREG6E.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG6E.Location = new System.Drawing.Point(440, 216);
            this.txtREG6E.MaxLength = 2;
            this.txtREG6E.Name = "txtREG6E";
            this.txtREG6E.Size = new System.Drawing.Size(27, 26);
            this.txtREG6E.TabIndex = 0;
            this.txtREG6E.Text = "00";
            this.txtREG6E.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG6E.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG7E
            // 
            this.txtREG7E.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG7E.Location = new System.Drawing.Point(440, 248);
            this.txtREG7E.MaxLength = 2;
            this.txtREG7E.Name = "txtREG7E";
            this.txtREG7E.Size = new System.Drawing.Size(27, 26);
            this.txtREG7E.TabIndex = 0;
            this.txtREG7E.Text = "00";
            this.txtREG7E.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG7E.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG47
            // 
            this.txtREG47.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG47.Location = new System.Drawing.Point(239, 152);
            this.txtREG47.MaxLength = 2;
            this.txtREG47.Name = "txtREG47";
            this.txtREG47.Size = new System.Drawing.Size(27, 26);
            this.txtREG47.TabIndex = 0;
            this.txtREG47.Text = "00";
            this.txtREG47.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG47.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG57
            // 
            this.txtREG57.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG57.Location = new System.Drawing.Point(239, 184);
            this.txtREG57.MaxLength = 2;
            this.txtREG57.Name = "txtREG57";
            this.txtREG57.Size = new System.Drawing.Size(27, 26);
            this.txtREG57.TabIndex = 0;
            this.txtREG57.Text = "00";
            this.txtREG57.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG57.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG67
            // 
            this.txtREG67.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG67.Location = new System.Drawing.Point(239, 216);
            this.txtREG67.MaxLength = 2;
            this.txtREG67.Name = "txtREG67";
            this.txtREG67.Size = new System.Drawing.Size(27, 26);
            this.txtREG67.TabIndex = 0;
            this.txtREG67.Text = "00";
            this.txtREG67.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG67.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG77
            // 
            this.txtREG77.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG77.Location = new System.Drawing.Point(239, 248);
            this.txtREG77.MaxLength = 2;
            this.txtREG77.Name = "txtREG77";
            this.txtREG77.Size = new System.Drawing.Size(27, 26);
            this.txtREG77.TabIndex = 0;
            this.txtREG77.Text = "00";
            this.txtREG77.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG77.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG4F
            // 
            this.txtREG4F.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG4F.Location = new System.Drawing.Point(468, 152);
            this.txtREG4F.MaxLength = 2;
            this.txtREG4F.Name = "txtREG4F";
            this.txtREG4F.Size = new System.Drawing.Size(27, 26);
            this.txtREG4F.TabIndex = 0;
            this.txtREG4F.Text = "00";
            this.txtREG4F.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG4F.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG5F
            // 
            this.txtREG5F.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG5F.Location = new System.Drawing.Point(468, 184);
            this.txtREG5F.MaxLength = 2;
            this.txtREG5F.Name = "txtREG5F";
            this.txtREG5F.Size = new System.Drawing.Size(27, 26);
            this.txtREG5F.TabIndex = 0;
            this.txtREG5F.Text = "00";
            this.txtREG5F.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG5F.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG6F
            // 
            this.txtREG6F.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG6F.Location = new System.Drawing.Point(468, 216);
            this.txtREG6F.MaxLength = 2;
            this.txtREG6F.Name = "txtREG6F";
            this.txtREG6F.Size = new System.Drawing.Size(27, 26);
            this.txtREG6F.TabIndex = 0;
            this.txtREG6F.Text = "00";
            this.txtREG6F.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG6F.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG7F
            // 
            this.txtREG7F.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG7F.Location = new System.Drawing.Point(468, 248);
            this.txtREG7F.MaxLength = 2;
            this.txtREG7F.Name = "txtREG7F";
            this.txtREG7F.Size = new System.Drawing.Size(27, 26);
            this.txtREG7F.TabIndex = 0;
            this.txtREG7F.Text = "00";
            this.txtREG7F.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG7F.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG80
            // 
            this.txtREG80.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG80.Location = new System.Drawing.Point(43, 280);
            this.txtREG80.MaxLength = 2;
            this.txtREG80.Name = "txtREG80";
            this.txtREG80.Size = new System.Drawing.Size(27, 26);
            this.txtREG80.TabIndex = 0;
            this.txtREG80.Text = "FF";
            this.txtREG80.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG80.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGC0
            // 
            this.txtREGC0.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGC0.Location = new System.Drawing.Point(43, 408);
            this.txtREGC0.MaxLength = 2;
            this.txtREGC0.Name = "txtREGC0";
            this.txtREGC0.Size = new System.Drawing.Size(27, 26);
            this.txtREGC0.TabIndex = 0;
            this.txtREGC0.Text = "FF";
            this.txtREGC0.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGC0.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG90
            // 
            this.txtREG90.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG90.Location = new System.Drawing.Point(43, 312);
            this.txtREG90.MaxLength = 2;
            this.txtREG90.Name = "txtREG90";
            this.txtREG90.Size = new System.Drawing.Size(27, 26);
            this.txtREG90.TabIndex = 0;
            this.txtREG90.Text = "FF";
            this.txtREG90.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG90.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGD0
            // 
            this.txtREGD0.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGD0.Location = new System.Drawing.Point(43, 440);
            this.txtREGD0.MaxLength = 2;
            this.txtREGD0.Name = "txtREGD0";
            this.txtREGD0.Size = new System.Drawing.Size(27, 26);
            this.txtREGD0.TabIndex = 0;
            this.txtREGD0.Text = "FF";
            this.txtREGD0.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGD0.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGA0
            // 
            this.txtREGA0.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGA0.Location = new System.Drawing.Point(43, 344);
            this.txtREGA0.MaxLength = 2;
            this.txtREGA0.Name = "txtREGA0";
            this.txtREGA0.Size = new System.Drawing.Size(27, 26);
            this.txtREGA0.TabIndex = 0;
            this.txtREGA0.Text = "FF";
            this.txtREGA0.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGA0.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGE0
            // 
            this.txtREGE0.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGE0.Location = new System.Drawing.Point(43, 472);
            this.txtREGE0.MaxLength = 2;
            this.txtREGE0.Name = "txtREGE0";
            this.txtREGE0.Size = new System.Drawing.Size(27, 26);
            this.txtREGE0.TabIndex = 0;
            this.txtREGE0.Text = "FF";
            this.txtREGE0.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGE0.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGB0
            // 
            this.txtREGB0.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGB0.Location = new System.Drawing.Point(43, 376);
            this.txtREGB0.MaxLength = 2;
            this.txtREGB0.Name = "txtREGB0";
            this.txtREGB0.Size = new System.Drawing.Size(27, 26);
            this.txtREGB0.TabIndex = 0;
            this.txtREGB0.Text = "FF";
            this.txtREGB0.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGB0.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGF0
            // 
            this.txtREGF0.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGF0.Location = new System.Drawing.Point(43, 504);
            this.txtREGF0.MaxLength = 2;
            this.txtREGF0.Name = "txtREGF0";
            this.txtREGF0.Size = new System.Drawing.Size(27, 26);
            this.txtREGF0.TabIndex = 0;
            this.txtREGF0.Text = "FF";
            this.txtREGF0.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGF0.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG88
            // 
            this.txtREG88.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG88.Location = new System.Drawing.Point(272, 280);
            this.txtREG88.MaxLength = 2;
            this.txtREG88.Name = "txtREG88";
            this.txtREG88.Size = new System.Drawing.Size(27, 26);
            this.txtREG88.TabIndex = 0;
            this.txtREG88.Text = "FF";
            this.txtREG88.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG88.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGC8
            // 
            this.txtREGC8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGC8.Location = new System.Drawing.Point(272, 408);
            this.txtREGC8.MaxLength = 2;
            this.txtREGC8.Name = "txtREGC8";
            this.txtREGC8.Size = new System.Drawing.Size(27, 26);
            this.txtREGC8.TabIndex = 0;
            this.txtREGC8.Text = "FF";
            this.txtREGC8.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGC8.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG98
            // 
            this.txtREG98.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG98.Location = new System.Drawing.Point(272, 312);
            this.txtREG98.MaxLength = 2;
            this.txtREG98.Name = "txtREG98";
            this.txtREG98.Size = new System.Drawing.Size(27, 26);
            this.txtREG98.TabIndex = 0;
            this.txtREG98.Text = "FF";
            this.txtREG98.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG98.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGD8
            // 
            this.txtREGD8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGD8.Location = new System.Drawing.Point(272, 440);
            this.txtREGD8.MaxLength = 2;
            this.txtREGD8.Name = "txtREGD8";
            this.txtREGD8.Size = new System.Drawing.Size(27, 26);
            this.txtREGD8.TabIndex = 0;
            this.txtREGD8.Text = "FF";
            this.txtREGD8.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGD8.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGA8
            // 
            this.txtREGA8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGA8.Location = new System.Drawing.Point(272, 344);
            this.txtREGA8.MaxLength = 2;
            this.txtREGA8.Name = "txtREGA8";
            this.txtREGA8.Size = new System.Drawing.Size(27, 26);
            this.txtREGA8.TabIndex = 0;
            this.txtREGA8.Text = "FF";
            this.txtREGA8.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGA8.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGE8
            // 
            this.txtREGE8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGE8.Location = new System.Drawing.Point(272, 472);
            this.txtREGE8.MaxLength = 2;
            this.txtREGE8.Name = "txtREGE8";
            this.txtREGE8.Size = new System.Drawing.Size(27, 26);
            this.txtREGE8.TabIndex = 0;
            this.txtREGE8.Text = "FF";
            this.txtREGE8.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGE8.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGB8
            // 
            this.txtREGB8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGB8.Location = new System.Drawing.Point(272, 376);
            this.txtREGB8.MaxLength = 2;
            this.txtREGB8.Name = "txtREGB8";
            this.txtREGB8.Size = new System.Drawing.Size(27, 26);
            this.txtREGB8.TabIndex = 0;
            this.txtREGB8.Text = "FF";
            this.txtREGB8.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGB8.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGF8
            // 
            this.txtREGF8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGF8.Location = new System.Drawing.Point(272, 504);
            this.txtREGF8.MaxLength = 2;
            this.txtREGF8.Name = "txtREGF8";
            this.txtREGF8.Size = new System.Drawing.Size(27, 26);
            this.txtREGF8.TabIndex = 0;
            this.txtREGF8.Text = "FF";
            this.txtREGF8.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGF8.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG81
            // 
            this.txtREG81.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG81.Location = new System.Drawing.Point(71, 280);
            this.txtREG81.MaxLength = 2;
            this.txtREG81.Name = "txtREG81";
            this.txtREG81.Size = new System.Drawing.Size(27, 26);
            this.txtREG81.TabIndex = 0;
            this.txtREG81.Text = "00";
            this.txtREG81.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG81.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGC1
            // 
            this.txtREGC1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGC1.Location = new System.Drawing.Point(71, 408);
            this.txtREGC1.MaxLength = 2;
            this.txtREGC1.Name = "txtREGC1";
            this.txtREGC1.Size = new System.Drawing.Size(27, 26);
            this.txtREGC1.TabIndex = 0;
            this.txtREGC1.Text = "00";
            this.txtREGC1.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGC1.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG91
            // 
            this.txtREG91.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG91.Location = new System.Drawing.Point(71, 312);
            this.txtREG91.MaxLength = 2;
            this.txtREG91.Name = "txtREG91";
            this.txtREG91.Size = new System.Drawing.Size(27, 26);
            this.txtREG91.TabIndex = 0;
            this.txtREG91.Text = "00";
            this.txtREG91.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG91.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGD1
            // 
            this.txtREGD1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGD1.Location = new System.Drawing.Point(71, 440);
            this.txtREGD1.MaxLength = 2;
            this.txtREGD1.Name = "txtREGD1";
            this.txtREGD1.Size = new System.Drawing.Size(27, 26);
            this.txtREGD1.TabIndex = 0;
            this.txtREGD1.Text = "00";
            this.txtREGD1.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGD1.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGA1
            // 
            this.txtREGA1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGA1.Location = new System.Drawing.Point(71, 344);
            this.txtREGA1.MaxLength = 2;
            this.txtREGA1.Name = "txtREGA1";
            this.txtREGA1.Size = new System.Drawing.Size(27, 26);
            this.txtREGA1.TabIndex = 0;
            this.txtREGA1.Text = "00";
            this.txtREGA1.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGA1.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGE1
            // 
            this.txtREGE1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGE1.Location = new System.Drawing.Point(71, 472);
            this.txtREGE1.MaxLength = 2;
            this.txtREGE1.Name = "txtREGE1";
            this.txtREGE1.Size = new System.Drawing.Size(27, 26);
            this.txtREGE1.TabIndex = 0;
            this.txtREGE1.Text = "00";
            this.txtREGE1.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGE1.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGB1
            // 
            this.txtREGB1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGB1.Location = new System.Drawing.Point(71, 376);
            this.txtREGB1.MaxLength = 2;
            this.txtREGB1.Name = "txtREGB1";
            this.txtREGB1.Size = new System.Drawing.Size(27, 26);
            this.txtREGB1.TabIndex = 0;
            this.txtREGB1.Text = "00";
            this.txtREGB1.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGB1.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGF1
            // 
            this.txtREGF1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGF1.Location = new System.Drawing.Point(71, 504);
            this.txtREGF1.MaxLength = 2;
            this.txtREGF1.Name = "txtREGF1";
            this.txtREGF1.Size = new System.Drawing.Size(27, 26);
            this.txtREGF1.TabIndex = 0;
            this.txtREGF1.Text = "00";
            this.txtREGF1.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGF1.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG89
            // 
            this.txtREG89.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG89.Location = new System.Drawing.Point(300, 280);
            this.txtREG89.MaxLength = 2;
            this.txtREG89.Name = "txtREG89";
            this.txtREG89.Size = new System.Drawing.Size(27, 26);
            this.txtREG89.TabIndex = 0;
            this.txtREG89.Text = "00";
            this.txtREG89.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG89.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGC9
            // 
            this.txtREGC9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGC9.Location = new System.Drawing.Point(300, 408);
            this.txtREGC9.MaxLength = 2;
            this.txtREGC9.Name = "txtREGC9";
            this.txtREGC9.Size = new System.Drawing.Size(27, 26);
            this.txtREGC9.TabIndex = 0;
            this.txtREGC9.Text = "00";
            this.txtREGC9.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGC9.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG99
            // 
            this.txtREG99.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG99.Location = new System.Drawing.Point(300, 312);
            this.txtREG99.MaxLength = 2;
            this.txtREG99.Name = "txtREG99";
            this.txtREG99.Size = new System.Drawing.Size(27, 26);
            this.txtREG99.TabIndex = 0;
            this.txtREG99.Text = "00";
            this.txtREG99.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG99.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGD9
            // 
            this.txtREGD9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGD9.Location = new System.Drawing.Point(300, 440);
            this.txtREGD9.MaxLength = 2;
            this.txtREGD9.Name = "txtREGD9";
            this.txtREGD9.Size = new System.Drawing.Size(27, 26);
            this.txtREGD9.TabIndex = 0;
            this.txtREGD9.Text = "00";
            this.txtREGD9.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGD9.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGA9
            // 
            this.txtREGA9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGA9.Location = new System.Drawing.Point(300, 344);
            this.txtREGA9.MaxLength = 2;
            this.txtREGA9.Name = "txtREGA9";
            this.txtREGA9.Size = new System.Drawing.Size(27, 26);
            this.txtREGA9.TabIndex = 0;
            this.txtREGA9.Text = "00";
            this.txtREGA9.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGA9.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGE9
            // 
            this.txtREGE9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGE9.Location = new System.Drawing.Point(300, 472);
            this.txtREGE9.MaxLength = 2;
            this.txtREGE9.Name = "txtREGE9";
            this.txtREGE9.Size = new System.Drawing.Size(27, 26);
            this.txtREGE9.TabIndex = 0;
            this.txtREGE9.Text = "00";
            this.txtREGE9.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGE9.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGB9
            // 
            this.txtREGB9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGB9.Location = new System.Drawing.Point(300, 376);
            this.txtREGB9.MaxLength = 2;
            this.txtREGB9.Name = "txtREGB9";
            this.txtREGB9.Size = new System.Drawing.Size(27, 26);
            this.txtREGB9.TabIndex = 0;
            this.txtREGB9.Text = "00";
            this.txtREGB9.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGB9.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGF9
            // 
            this.txtREGF9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGF9.Location = new System.Drawing.Point(300, 504);
            this.txtREGF9.MaxLength = 2;
            this.txtREGF9.Name = "txtREGF9";
            this.txtREGF9.Size = new System.Drawing.Size(27, 26);
            this.txtREGF9.TabIndex = 0;
            this.txtREGF9.Text = "00";
            this.txtREGF9.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGF9.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG82
            // 
            this.txtREG82.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG82.Location = new System.Drawing.Point(99, 280);
            this.txtREG82.MaxLength = 2;
            this.txtREG82.Name = "txtREG82";
            this.txtREG82.Size = new System.Drawing.Size(27, 26);
            this.txtREG82.TabIndex = 0;
            this.txtREG82.Text = "00";
            this.txtREG82.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG82.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGC2
            // 
            this.txtREGC2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGC2.Location = new System.Drawing.Point(99, 408);
            this.txtREGC2.MaxLength = 2;
            this.txtREGC2.Name = "txtREGC2";
            this.txtREGC2.Size = new System.Drawing.Size(27, 26);
            this.txtREGC2.TabIndex = 0;
            this.txtREGC2.Text = "00";
            this.txtREGC2.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGC2.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG92
            // 
            this.txtREG92.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG92.Location = new System.Drawing.Point(99, 312);
            this.txtREG92.MaxLength = 2;
            this.txtREG92.Name = "txtREG92";
            this.txtREG92.Size = new System.Drawing.Size(27, 26);
            this.txtREG92.TabIndex = 0;
            this.txtREG92.Text = "00";
            this.txtREG92.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG92.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGD2
            // 
            this.txtREGD2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGD2.Location = new System.Drawing.Point(99, 440);
            this.txtREGD2.MaxLength = 2;
            this.txtREGD2.Name = "txtREGD2";
            this.txtREGD2.Size = new System.Drawing.Size(27, 26);
            this.txtREGD2.TabIndex = 0;
            this.txtREGD2.Text = "00";
            this.txtREGD2.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGD2.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGA2
            // 
            this.txtREGA2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGA2.Location = new System.Drawing.Point(99, 344);
            this.txtREGA2.MaxLength = 2;
            this.txtREGA2.Name = "txtREGA2";
            this.txtREGA2.Size = new System.Drawing.Size(27, 26);
            this.txtREGA2.TabIndex = 0;
            this.txtREGA2.Text = "00";
            this.txtREGA2.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGA2.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGE2
            // 
            this.txtREGE2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGE2.Location = new System.Drawing.Point(99, 472);
            this.txtREGE2.MaxLength = 2;
            this.txtREGE2.Name = "txtREGE2";
            this.txtREGE2.Size = new System.Drawing.Size(27, 26);
            this.txtREGE2.TabIndex = 0;
            this.txtREGE2.Text = "00";
            this.txtREGE2.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGE2.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGB2
            // 
            this.txtREGB2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGB2.Location = new System.Drawing.Point(99, 376);
            this.txtREGB2.MaxLength = 2;
            this.txtREGB2.Name = "txtREGB2";
            this.txtREGB2.Size = new System.Drawing.Size(27, 26);
            this.txtREGB2.TabIndex = 0;
            this.txtREGB2.Text = "00";
            this.txtREGB2.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGB2.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGF2
            // 
            this.txtREGF2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGF2.Location = new System.Drawing.Point(99, 504);
            this.txtREGF2.MaxLength = 2;
            this.txtREGF2.Name = "txtREGF2";
            this.txtREGF2.Size = new System.Drawing.Size(27, 26);
            this.txtREGF2.TabIndex = 0;
            this.txtREGF2.Text = "00";
            this.txtREGF2.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGF2.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG8A
            // 
            this.txtREG8A.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG8A.Location = new System.Drawing.Point(328, 280);
            this.txtREG8A.MaxLength = 2;
            this.txtREG8A.Name = "txtREG8A";
            this.txtREG8A.Size = new System.Drawing.Size(27, 26);
            this.txtREG8A.TabIndex = 0;
            this.txtREG8A.Text = "00";
            this.txtREG8A.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG8A.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGCA
            // 
            this.txtREGCA.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGCA.Location = new System.Drawing.Point(328, 408);
            this.txtREGCA.MaxLength = 2;
            this.txtREGCA.Name = "txtREGCA";
            this.txtREGCA.Size = new System.Drawing.Size(27, 26);
            this.txtREGCA.TabIndex = 0;
            this.txtREGCA.Text = "00";
            this.txtREGCA.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGCA.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG9A
            // 
            this.txtREG9A.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG9A.Location = new System.Drawing.Point(328, 312);
            this.txtREG9A.MaxLength = 2;
            this.txtREG9A.Name = "txtREG9A";
            this.txtREG9A.Size = new System.Drawing.Size(27, 26);
            this.txtREG9A.TabIndex = 0;
            this.txtREG9A.Text = "00";
            this.txtREG9A.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG9A.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGDA
            // 
            this.txtREGDA.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGDA.Location = new System.Drawing.Point(328, 440);
            this.txtREGDA.MaxLength = 2;
            this.txtREGDA.Name = "txtREGDA";
            this.txtREGDA.Size = new System.Drawing.Size(27, 26);
            this.txtREGDA.TabIndex = 0;
            this.txtREGDA.Text = "00";
            this.txtREGDA.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGDA.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGAA
            // 
            this.txtREGAA.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGAA.Location = new System.Drawing.Point(328, 344);
            this.txtREGAA.MaxLength = 2;
            this.txtREGAA.Name = "txtREGAA";
            this.txtREGAA.Size = new System.Drawing.Size(27, 26);
            this.txtREGAA.TabIndex = 0;
            this.txtREGAA.Text = "00";
            this.txtREGAA.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGAA.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGEA
            // 
            this.txtREGEA.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGEA.Location = new System.Drawing.Point(328, 472);
            this.txtREGEA.MaxLength = 2;
            this.txtREGEA.Name = "txtREGEA";
            this.txtREGEA.Size = new System.Drawing.Size(27, 26);
            this.txtREGEA.TabIndex = 0;
            this.txtREGEA.Text = "00";
            this.txtREGEA.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGEA.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGBA
            // 
            this.txtREGBA.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGBA.Location = new System.Drawing.Point(328, 376);
            this.txtREGBA.MaxLength = 2;
            this.txtREGBA.Name = "txtREGBA";
            this.txtREGBA.Size = new System.Drawing.Size(27, 26);
            this.txtREGBA.TabIndex = 0;
            this.txtREGBA.Text = "00";
            this.txtREGBA.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGBA.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGFA
            // 
            this.txtREGFA.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGFA.Location = new System.Drawing.Point(328, 504);
            this.txtREGFA.MaxLength = 2;
            this.txtREGFA.Name = "txtREGFA";
            this.txtREGFA.Size = new System.Drawing.Size(27, 26);
            this.txtREGFA.TabIndex = 0;
            this.txtREGFA.Text = "00";
            this.txtREGFA.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGFA.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG83
            // 
            this.txtREG83.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG83.Location = new System.Drawing.Point(127, 280);
            this.txtREG83.MaxLength = 2;
            this.txtREG83.Name = "txtREG83";
            this.txtREG83.Size = new System.Drawing.Size(27, 26);
            this.txtREG83.TabIndex = 0;
            this.txtREG83.Text = "00";
            this.txtREG83.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG83.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGC3
            // 
            this.txtREGC3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGC3.Location = new System.Drawing.Point(127, 408);
            this.txtREGC3.MaxLength = 2;
            this.txtREGC3.Name = "txtREGC3";
            this.txtREGC3.Size = new System.Drawing.Size(27, 26);
            this.txtREGC3.TabIndex = 0;
            this.txtREGC3.Text = "00";
            this.txtREGC3.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGC3.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG93
            // 
            this.txtREG93.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG93.Location = new System.Drawing.Point(127, 312);
            this.txtREG93.MaxLength = 2;
            this.txtREG93.Name = "txtREG93";
            this.txtREG93.Size = new System.Drawing.Size(27, 26);
            this.txtREG93.TabIndex = 0;
            this.txtREG93.Text = "00";
            this.txtREG93.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG93.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGD3
            // 
            this.txtREGD3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGD3.Location = new System.Drawing.Point(127, 440);
            this.txtREGD3.MaxLength = 2;
            this.txtREGD3.Name = "txtREGD3";
            this.txtREGD3.Size = new System.Drawing.Size(27, 26);
            this.txtREGD3.TabIndex = 0;
            this.txtREGD3.Text = "00";
            this.txtREGD3.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGD3.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGA3
            // 
            this.txtREGA3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGA3.Location = new System.Drawing.Point(127, 344);
            this.txtREGA3.MaxLength = 2;
            this.txtREGA3.Name = "txtREGA3";
            this.txtREGA3.Size = new System.Drawing.Size(27, 26);
            this.txtREGA3.TabIndex = 0;
            this.txtREGA3.Text = "00";
            this.txtREGA3.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGA3.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGE3
            // 
            this.txtREGE3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGE3.Location = new System.Drawing.Point(127, 472);
            this.txtREGE3.MaxLength = 2;
            this.txtREGE3.Name = "txtREGE3";
            this.txtREGE3.Size = new System.Drawing.Size(27, 26);
            this.txtREGE3.TabIndex = 0;
            this.txtREGE3.Text = "00";
            this.txtREGE3.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGE3.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGB3
            // 
            this.txtREGB3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGB3.Location = new System.Drawing.Point(127, 376);
            this.txtREGB3.MaxLength = 2;
            this.txtREGB3.Name = "txtREGB3";
            this.txtREGB3.Size = new System.Drawing.Size(27, 26);
            this.txtREGB3.TabIndex = 0;
            this.txtREGB3.Text = "00";
            this.txtREGB3.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGB3.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGF3
            // 
            this.txtREGF3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGF3.Location = new System.Drawing.Point(127, 504);
            this.txtREGF3.MaxLength = 2;
            this.txtREGF3.Name = "txtREGF3";
            this.txtREGF3.Size = new System.Drawing.Size(27, 26);
            this.txtREGF3.TabIndex = 0;
            this.txtREGF3.Text = "00";
            this.txtREGF3.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGF3.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG8B
            // 
            this.txtREG8B.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG8B.Location = new System.Drawing.Point(356, 280);
            this.txtREG8B.MaxLength = 2;
            this.txtREG8B.Name = "txtREG8B";
            this.txtREG8B.Size = new System.Drawing.Size(27, 26);
            this.txtREG8B.TabIndex = 0;
            this.txtREG8B.Text = "00";
            this.txtREG8B.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG8B.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGCB
            // 
            this.txtREGCB.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGCB.Location = new System.Drawing.Point(356, 408);
            this.txtREGCB.MaxLength = 2;
            this.txtREGCB.Name = "txtREGCB";
            this.txtREGCB.Size = new System.Drawing.Size(27, 26);
            this.txtREGCB.TabIndex = 0;
            this.txtREGCB.Text = "00";
            this.txtREGCB.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGCB.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG9B
            // 
            this.txtREG9B.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG9B.Location = new System.Drawing.Point(356, 312);
            this.txtREG9B.MaxLength = 2;
            this.txtREG9B.Name = "txtREG9B";
            this.txtREG9B.Size = new System.Drawing.Size(27, 26);
            this.txtREG9B.TabIndex = 0;
            this.txtREG9B.Text = "00";
            this.txtREG9B.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG9B.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGDB
            // 
            this.txtREGDB.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGDB.Location = new System.Drawing.Point(356, 440);
            this.txtREGDB.MaxLength = 2;
            this.txtREGDB.Name = "txtREGDB";
            this.txtREGDB.Size = new System.Drawing.Size(27, 26);
            this.txtREGDB.TabIndex = 0;
            this.txtREGDB.Text = "00";
            this.txtREGDB.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGDB.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGAB
            // 
            this.txtREGAB.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGAB.Location = new System.Drawing.Point(356, 344);
            this.txtREGAB.MaxLength = 2;
            this.txtREGAB.Name = "txtREGAB";
            this.txtREGAB.Size = new System.Drawing.Size(27, 26);
            this.txtREGAB.TabIndex = 0;
            this.txtREGAB.Text = "00";
            this.txtREGAB.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGAB.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGEB
            // 
            this.txtREGEB.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGEB.Location = new System.Drawing.Point(356, 472);
            this.txtREGEB.MaxLength = 2;
            this.txtREGEB.Name = "txtREGEB";
            this.txtREGEB.Size = new System.Drawing.Size(27, 26);
            this.txtREGEB.TabIndex = 0;
            this.txtREGEB.Text = "00";
            this.txtREGEB.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGEB.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGBB
            // 
            this.txtREGBB.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGBB.Location = new System.Drawing.Point(356, 376);
            this.txtREGBB.MaxLength = 2;
            this.txtREGBB.Name = "txtREGBB";
            this.txtREGBB.Size = new System.Drawing.Size(27, 26);
            this.txtREGBB.TabIndex = 0;
            this.txtREGBB.Text = "00";
            this.txtREGBB.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGBB.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGFB
            // 
            this.txtREGFB.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGFB.Location = new System.Drawing.Point(356, 504);
            this.txtREGFB.MaxLength = 2;
            this.txtREGFB.Name = "txtREGFB";
            this.txtREGFB.Size = new System.Drawing.Size(27, 26);
            this.txtREGFB.TabIndex = 0;
            this.txtREGFB.Text = "00";
            this.txtREGFB.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGFB.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG84
            // 
            this.txtREG84.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG84.Location = new System.Drawing.Point(155, 280);
            this.txtREG84.MaxLength = 2;
            this.txtREG84.Name = "txtREG84";
            this.txtREG84.Size = new System.Drawing.Size(27, 26);
            this.txtREG84.TabIndex = 0;
            this.txtREG84.Text = "00";
            this.txtREG84.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG84.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGC4
            // 
            this.txtREGC4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGC4.Location = new System.Drawing.Point(155, 408);
            this.txtREGC4.MaxLength = 2;
            this.txtREGC4.Name = "txtREGC4";
            this.txtREGC4.Size = new System.Drawing.Size(27, 26);
            this.txtREGC4.TabIndex = 0;
            this.txtREGC4.Text = "00";
            this.txtREGC4.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGC4.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG94
            // 
            this.txtREG94.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG94.Location = new System.Drawing.Point(155, 312);
            this.txtREG94.MaxLength = 2;
            this.txtREG94.Name = "txtREG94";
            this.txtREG94.Size = new System.Drawing.Size(27, 26);
            this.txtREG94.TabIndex = 0;
            this.txtREG94.Text = "00";
            this.txtREG94.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG94.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGD4
            // 
            this.txtREGD4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGD4.Location = new System.Drawing.Point(155, 440);
            this.txtREGD4.MaxLength = 2;
            this.txtREGD4.Name = "txtREGD4";
            this.txtREGD4.Size = new System.Drawing.Size(27, 26);
            this.txtREGD4.TabIndex = 0;
            this.txtREGD4.Text = "00";
            this.txtREGD4.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGD4.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGA4
            // 
            this.txtREGA4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGA4.Location = new System.Drawing.Point(155, 344);
            this.txtREGA4.MaxLength = 2;
            this.txtREGA4.Name = "txtREGA4";
            this.txtREGA4.Size = new System.Drawing.Size(27, 26);
            this.txtREGA4.TabIndex = 0;
            this.txtREGA4.Text = "00";
            this.txtREGA4.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGA4.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGE4
            // 
            this.txtREGE4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGE4.Location = new System.Drawing.Point(155, 472);
            this.txtREGE4.MaxLength = 2;
            this.txtREGE4.Name = "txtREGE4";
            this.txtREGE4.Size = new System.Drawing.Size(27, 26);
            this.txtREGE4.TabIndex = 0;
            this.txtREGE4.Text = "00";
            this.txtREGE4.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGE4.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGB4
            // 
            this.txtREGB4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGB4.Location = new System.Drawing.Point(155, 376);
            this.txtREGB4.MaxLength = 2;
            this.txtREGB4.Name = "txtREGB4";
            this.txtREGB4.Size = new System.Drawing.Size(27, 26);
            this.txtREGB4.TabIndex = 0;
            this.txtREGB4.Text = "00";
            this.txtREGB4.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGB4.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGF4
            // 
            this.txtREGF4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGF4.Location = new System.Drawing.Point(155, 504);
            this.txtREGF4.MaxLength = 2;
            this.txtREGF4.Name = "txtREGF4";
            this.txtREGF4.Size = new System.Drawing.Size(27, 26);
            this.txtREGF4.TabIndex = 0;
            this.txtREGF4.Text = "00";
            this.txtREGF4.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGF4.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG8C
            // 
            this.txtREG8C.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG8C.Location = new System.Drawing.Point(384, 280);
            this.txtREG8C.MaxLength = 2;
            this.txtREG8C.Name = "txtREG8C";
            this.txtREG8C.Size = new System.Drawing.Size(27, 26);
            this.txtREG8C.TabIndex = 0;
            this.txtREG8C.Text = "00";
            this.txtREG8C.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG8C.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGCC
            // 
            this.txtREGCC.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGCC.Location = new System.Drawing.Point(384, 408);
            this.txtREGCC.MaxLength = 2;
            this.txtREGCC.Name = "txtREGCC";
            this.txtREGCC.Size = new System.Drawing.Size(27, 26);
            this.txtREGCC.TabIndex = 0;
            this.txtREGCC.Text = "00";
            this.txtREGCC.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGCC.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG9C
            // 
            this.txtREG9C.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG9C.Location = new System.Drawing.Point(384, 312);
            this.txtREG9C.MaxLength = 2;
            this.txtREG9C.Name = "txtREG9C";
            this.txtREG9C.Size = new System.Drawing.Size(27, 26);
            this.txtREG9C.TabIndex = 0;
            this.txtREG9C.Text = "00";
            this.txtREG9C.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG9C.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGDC
            // 
            this.txtREGDC.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGDC.Location = new System.Drawing.Point(384, 440);
            this.txtREGDC.MaxLength = 2;
            this.txtREGDC.Name = "txtREGDC";
            this.txtREGDC.Size = new System.Drawing.Size(27, 26);
            this.txtREGDC.TabIndex = 0;
            this.txtREGDC.Text = "00";
            this.txtREGDC.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGDC.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGAC
            // 
            this.txtREGAC.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGAC.Location = new System.Drawing.Point(384, 344);
            this.txtREGAC.MaxLength = 2;
            this.txtREGAC.Name = "txtREGAC";
            this.txtREGAC.Size = new System.Drawing.Size(27, 26);
            this.txtREGAC.TabIndex = 0;
            this.txtREGAC.Text = "00";
            this.txtREGAC.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGAC.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGEC
            // 
            this.txtREGEC.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGEC.Location = new System.Drawing.Point(384, 472);
            this.txtREGEC.MaxLength = 2;
            this.txtREGEC.Name = "txtREGEC";
            this.txtREGEC.Size = new System.Drawing.Size(27, 26);
            this.txtREGEC.TabIndex = 0;
            this.txtREGEC.Text = "00";
            this.txtREGEC.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGEC.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGBC
            // 
            this.txtREGBC.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGBC.Location = new System.Drawing.Point(384, 376);
            this.txtREGBC.MaxLength = 2;
            this.txtREGBC.Name = "txtREGBC";
            this.txtREGBC.Size = new System.Drawing.Size(27, 26);
            this.txtREGBC.TabIndex = 0;
            this.txtREGBC.Text = "00";
            this.txtREGBC.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGBC.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGFC
            // 
            this.txtREGFC.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGFC.Location = new System.Drawing.Point(384, 504);
            this.txtREGFC.MaxLength = 2;
            this.txtREGFC.Name = "txtREGFC";
            this.txtREGFC.Size = new System.Drawing.Size(27, 26);
            this.txtREGFC.TabIndex = 0;
            this.txtREGFC.Text = "00";
            this.txtREGFC.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGFC.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG85
            // 
            this.txtREG85.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG85.Location = new System.Drawing.Point(183, 280);
            this.txtREG85.MaxLength = 2;
            this.txtREG85.Name = "txtREG85";
            this.txtREG85.Size = new System.Drawing.Size(27, 26);
            this.txtREG85.TabIndex = 0;
            this.txtREG85.Text = "00";
            this.txtREG85.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG85.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGC5
            // 
            this.txtREGC5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGC5.Location = new System.Drawing.Point(183, 408);
            this.txtREGC5.MaxLength = 2;
            this.txtREGC5.Name = "txtREGC5";
            this.txtREGC5.Size = new System.Drawing.Size(27, 26);
            this.txtREGC5.TabIndex = 0;
            this.txtREGC5.Text = "00";
            this.txtREGC5.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGC5.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG95
            // 
            this.txtREG95.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG95.Location = new System.Drawing.Point(183, 312);
            this.txtREG95.MaxLength = 2;
            this.txtREG95.Name = "txtREG95";
            this.txtREG95.Size = new System.Drawing.Size(27, 26);
            this.txtREG95.TabIndex = 0;
            this.txtREG95.Text = "00";
            this.txtREG95.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG95.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGD5
            // 
            this.txtREGD5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGD5.Location = new System.Drawing.Point(183, 440);
            this.txtREGD5.MaxLength = 2;
            this.txtREGD5.Name = "txtREGD5";
            this.txtREGD5.Size = new System.Drawing.Size(27, 26);
            this.txtREGD5.TabIndex = 0;
            this.txtREGD5.Text = "00";
            this.txtREGD5.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGD5.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGA5
            // 
            this.txtREGA5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGA5.Location = new System.Drawing.Point(183, 344);
            this.txtREGA5.MaxLength = 2;
            this.txtREGA5.Name = "txtREGA5";
            this.txtREGA5.Size = new System.Drawing.Size(27, 26);
            this.txtREGA5.TabIndex = 0;
            this.txtREGA5.Text = "00";
            this.txtREGA5.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGA5.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGE5
            // 
            this.txtREGE5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGE5.Location = new System.Drawing.Point(183, 472);
            this.txtREGE5.MaxLength = 2;
            this.txtREGE5.Name = "txtREGE5";
            this.txtREGE5.Size = new System.Drawing.Size(27, 26);
            this.txtREGE5.TabIndex = 0;
            this.txtREGE5.Text = "00";
            this.txtREGE5.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGE5.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGB5
            // 
            this.txtREGB5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGB5.Location = new System.Drawing.Point(183, 376);
            this.txtREGB5.MaxLength = 2;
            this.txtREGB5.Name = "txtREGB5";
            this.txtREGB5.Size = new System.Drawing.Size(27, 26);
            this.txtREGB5.TabIndex = 0;
            this.txtREGB5.Text = "00";
            this.txtREGB5.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGB5.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGF5
            // 
            this.txtREGF5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGF5.Location = new System.Drawing.Point(183, 504);
            this.txtREGF5.MaxLength = 2;
            this.txtREGF5.Name = "txtREGF5";
            this.txtREGF5.Size = new System.Drawing.Size(27, 26);
            this.txtREGF5.TabIndex = 0;
            this.txtREGF5.Text = "00";
            this.txtREGF5.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGF5.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG8D
            // 
            this.txtREG8D.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG8D.Location = new System.Drawing.Point(412, 280);
            this.txtREG8D.MaxLength = 2;
            this.txtREG8D.Name = "txtREG8D";
            this.txtREG8D.Size = new System.Drawing.Size(27, 26);
            this.txtREG8D.TabIndex = 0;
            this.txtREG8D.Text = "00";
            this.txtREG8D.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG8D.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGCD
            // 
            this.txtREGCD.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGCD.Location = new System.Drawing.Point(412, 408);
            this.txtREGCD.MaxLength = 2;
            this.txtREGCD.Name = "txtREGCD";
            this.txtREGCD.Size = new System.Drawing.Size(27, 26);
            this.txtREGCD.TabIndex = 0;
            this.txtREGCD.Text = "00";
            this.txtREGCD.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGCD.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG9D
            // 
            this.txtREG9D.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG9D.Location = new System.Drawing.Point(412, 312);
            this.txtREG9D.MaxLength = 2;
            this.txtREG9D.Name = "txtREG9D";
            this.txtREG9D.Size = new System.Drawing.Size(27, 26);
            this.txtREG9D.TabIndex = 0;
            this.txtREG9D.Text = "00";
            this.txtREG9D.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG9D.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGDD
            // 
            this.txtREGDD.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGDD.Location = new System.Drawing.Point(412, 440);
            this.txtREGDD.MaxLength = 2;
            this.txtREGDD.Name = "txtREGDD";
            this.txtREGDD.Size = new System.Drawing.Size(27, 26);
            this.txtREGDD.TabIndex = 0;
            this.txtREGDD.Text = "00";
            this.txtREGDD.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGDD.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGAD
            // 
            this.txtREGAD.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGAD.Location = new System.Drawing.Point(412, 344);
            this.txtREGAD.MaxLength = 2;
            this.txtREGAD.Name = "txtREGAD";
            this.txtREGAD.Size = new System.Drawing.Size(27, 26);
            this.txtREGAD.TabIndex = 0;
            this.txtREGAD.Text = "00";
            this.txtREGAD.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGAD.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGED
            // 
            this.txtREGED.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGED.Location = new System.Drawing.Point(412, 472);
            this.txtREGED.MaxLength = 2;
            this.txtREGED.Name = "txtREGED";
            this.txtREGED.Size = new System.Drawing.Size(27, 26);
            this.txtREGED.TabIndex = 0;
            this.txtREGED.Text = "00";
            this.txtREGED.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGED.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGBD
            // 
            this.txtREGBD.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGBD.Location = new System.Drawing.Point(412, 376);
            this.txtREGBD.MaxLength = 2;
            this.txtREGBD.Name = "txtREGBD";
            this.txtREGBD.Size = new System.Drawing.Size(27, 26);
            this.txtREGBD.TabIndex = 0;
            this.txtREGBD.Text = "00";
            this.txtREGBD.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGBD.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGFD
            // 
            this.txtREGFD.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGFD.Location = new System.Drawing.Point(412, 504);
            this.txtREGFD.MaxLength = 2;
            this.txtREGFD.Name = "txtREGFD";
            this.txtREGFD.Size = new System.Drawing.Size(27, 26);
            this.txtREGFD.TabIndex = 0;
            this.txtREGFD.Text = "00";
            this.txtREGFD.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGFD.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG86
            // 
            this.txtREG86.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG86.Location = new System.Drawing.Point(211, 280);
            this.txtREG86.MaxLength = 2;
            this.txtREG86.Name = "txtREG86";
            this.txtREG86.Size = new System.Drawing.Size(27, 26);
            this.txtREG86.TabIndex = 0;
            this.txtREG86.Text = "00";
            this.txtREG86.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG86.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGC6
            // 
            this.txtREGC6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGC6.Location = new System.Drawing.Point(211, 408);
            this.txtREGC6.MaxLength = 2;
            this.txtREGC6.Name = "txtREGC6";
            this.txtREGC6.Size = new System.Drawing.Size(27, 26);
            this.txtREGC6.TabIndex = 0;
            this.txtREGC6.Text = "00";
            this.txtREGC6.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGC6.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG96
            // 
            this.txtREG96.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG96.Location = new System.Drawing.Point(211, 312);
            this.txtREG96.MaxLength = 2;
            this.txtREG96.Name = "txtREG96";
            this.txtREG96.Size = new System.Drawing.Size(27, 26);
            this.txtREG96.TabIndex = 0;
            this.txtREG96.Text = "00";
            this.txtREG96.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG96.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGD6
            // 
            this.txtREGD6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGD6.Location = new System.Drawing.Point(211, 440);
            this.txtREGD6.MaxLength = 2;
            this.txtREGD6.Name = "txtREGD6";
            this.txtREGD6.Size = new System.Drawing.Size(27, 26);
            this.txtREGD6.TabIndex = 0;
            this.txtREGD6.Text = "00";
            this.txtREGD6.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGD6.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGA6
            // 
            this.txtREGA6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGA6.Location = new System.Drawing.Point(211, 344);
            this.txtREGA6.MaxLength = 2;
            this.txtREGA6.Name = "txtREGA6";
            this.txtREGA6.Size = new System.Drawing.Size(27, 26);
            this.txtREGA6.TabIndex = 0;
            this.txtREGA6.Text = "00";
            this.txtREGA6.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGA6.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGE6
            // 
            this.txtREGE6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGE6.Location = new System.Drawing.Point(211, 472);
            this.txtREGE6.MaxLength = 2;
            this.txtREGE6.Name = "txtREGE6";
            this.txtREGE6.Size = new System.Drawing.Size(27, 26);
            this.txtREGE6.TabIndex = 0;
            this.txtREGE6.Text = "00";
            this.txtREGE6.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGE6.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGB6
            // 
            this.txtREGB6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGB6.Location = new System.Drawing.Point(211, 376);
            this.txtREGB6.MaxLength = 2;
            this.txtREGB6.Name = "txtREGB6";
            this.txtREGB6.Size = new System.Drawing.Size(27, 26);
            this.txtREGB6.TabIndex = 0;
            this.txtREGB6.Text = "00";
            this.txtREGB6.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGB6.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGF6
            // 
            this.txtREGF6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGF6.Location = new System.Drawing.Point(211, 504);
            this.txtREGF6.MaxLength = 2;
            this.txtREGF6.Name = "txtREGF6";
            this.txtREGF6.Size = new System.Drawing.Size(27, 26);
            this.txtREGF6.TabIndex = 0;
            this.txtREGF6.Text = "00";
            this.txtREGF6.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGF6.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG8E
            // 
            this.txtREG8E.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG8E.Location = new System.Drawing.Point(440, 280);
            this.txtREG8E.MaxLength = 2;
            this.txtREG8E.Name = "txtREG8E";
            this.txtREG8E.Size = new System.Drawing.Size(27, 26);
            this.txtREG8E.TabIndex = 0;
            this.txtREG8E.Text = "00";
            this.txtREG8E.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG8E.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGCE
            // 
            this.txtREGCE.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGCE.Location = new System.Drawing.Point(440, 408);
            this.txtREGCE.MaxLength = 2;
            this.txtREGCE.Name = "txtREGCE";
            this.txtREGCE.Size = new System.Drawing.Size(27, 26);
            this.txtREGCE.TabIndex = 0;
            this.txtREGCE.Text = "00";
            this.txtREGCE.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGCE.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG9E
            // 
            this.txtREG9E.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG9E.Location = new System.Drawing.Point(440, 312);
            this.txtREG9E.MaxLength = 2;
            this.txtREG9E.Name = "txtREG9E";
            this.txtREG9E.Size = new System.Drawing.Size(27, 26);
            this.txtREG9E.TabIndex = 0;
            this.txtREG9E.Text = "00";
            this.txtREG9E.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG9E.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGDE
            // 
            this.txtREGDE.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGDE.Location = new System.Drawing.Point(440, 440);
            this.txtREGDE.MaxLength = 2;
            this.txtREGDE.Name = "txtREGDE";
            this.txtREGDE.Size = new System.Drawing.Size(27, 26);
            this.txtREGDE.TabIndex = 0;
            this.txtREGDE.Text = "00";
            this.txtREGDE.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGDE.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGAE
            // 
            this.txtREGAE.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGAE.Location = new System.Drawing.Point(440, 344);
            this.txtREGAE.MaxLength = 2;
            this.txtREGAE.Name = "txtREGAE";
            this.txtREGAE.Size = new System.Drawing.Size(27, 26);
            this.txtREGAE.TabIndex = 0;
            this.txtREGAE.Text = "00";
            this.txtREGAE.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGAE.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGEE
            // 
            this.txtREGEE.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGEE.Location = new System.Drawing.Point(440, 472);
            this.txtREGEE.MaxLength = 2;
            this.txtREGEE.Name = "txtREGEE";
            this.txtREGEE.Size = new System.Drawing.Size(27, 26);
            this.txtREGEE.TabIndex = 0;
            this.txtREGEE.Text = "00";
            this.txtREGEE.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGEE.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGBE
            // 
            this.txtREGBE.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGBE.Location = new System.Drawing.Point(440, 376);
            this.txtREGBE.MaxLength = 2;
            this.txtREGBE.Name = "txtREGBE";
            this.txtREGBE.Size = new System.Drawing.Size(27, 26);
            this.txtREGBE.TabIndex = 0;
            this.txtREGBE.Text = "00";
            this.txtREGBE.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGBE.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGFE
            // 
            this.txtREGFE.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGFE.Location = new System.Drawing.Point(440, 504);
            this.txtREGFE.MaxLength = 2;
            this.txtREGFE.Name = "txtREGFE";
            this.txtREGFE.Size = new System.Drawing.Size(27, 26);
            this.txtREGFE.TabIndex = 0;
            this.txtREGFE.Text = "00";
            this.txtREGFE.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGFE.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG87
            // 
            this.txtREG87.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG87.Location = new System.Drawing.Point(239, 280);
            this.txtREG87.MaxLength = 2;
            this.txtREG87.Name = "txtREG87";
            this.txtREG87.Size = new System.Drawing.Size(27, 26);
            this.txtREG87.TabIndex = 0;
            this.txtREG87.Text = "00";
            this.txtREG87.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG87.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGC7
            // 
            this.txtREGC7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGC7.Location = new System.Drawing.Point(239, 408);
            this.txtREGC7.MaxLength = 2;
            this.txtREGC7.Name = "txtREGC7";
            this.txtREGC7.Size = new System.Drawing.Size(27, 26);
            this.txtREGC7.TabIndex = 0;
            this.txtREGC7.Text = "00";
            this.txtREGC7.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGC7.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG97
            // 
            this.txtREG97.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG97.Location = new System.Drawing.Point(239, 312);
            this.txtREG97.MaxLength = 2;
            this.txtREG97.Name = "txtREG97";
            this.txtREG97.Size = new System.Drawing.Size(27, 26);
            this.txtREG97.TabIndex = 0;
            this.txtREG97.Text = "00";
            this.txtREG97.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG97.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGD7
            // 
            this.txtREGD7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGD7.Location = new System.Drawing.Point(239, 440);
            this.txtREGD7.MaxLength = 2;
            this.txtREGD7.Name = "txtREGD7";
            this.txtREGD7.Size = new System.Drawing.Size(27, 26);
            this.txtREGD7.TabIndex = 0;
            this.txtREGD7.Text = "00";
            this.txtREGD7.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGD7.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGA7
            // 
            this.txtREGA7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGA7.Location = new System.Drawing.Point(239, 344);
            this.txtREGA7.MaxLength = 2;
            this.txtREGA7.Name = "txtREGA7";
            this.txtREGA7.Size = new System.Drawing.Size(27, 26);
            this.txtREGA7.TabIndex = 0;
            this.txtREGA7.Text = "00";
            this.txtREGA7.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGA7.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGE7
            // 
            this.txtREGE7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGE7.Location = new System.Drawing.Point(239, 472);
            this.txtREGE7.MaxLength = 2;
            this.txtREGE7.Name = "txtREGE7";
            this.txtREGE7.Size = new System.Drawing.Size(27, 26);
            this.txtREGE7.TabIndex = 0;
            this.txtREGE7.Text = "00";
            this.txtREGE7.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGE7.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGB7
            // 
            this.txtREGB7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGB7.Location = new System.Drawing.Point(239, 376);
            this.txtREGB7.MaxLength = 2;
            this.txtREGB7.Name = "txtREGB7";
            this.txtREGB7.Size = new System.Drawing.Size(27, 26);
            this.txtREGB7.TabIndex = 0;
            this.txtREGB7.Text = "00";
            this.txtREGB7.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGB7.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGF7
            // 
            this.txtREGF7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGF7.Location = new System.Drawing.Point(239, 504);
            this.txtREGF7.MaxLength = 2;
            this.txtREGF7.Name = "txtREGF7";
            this.txtREGF7.Size = new System.Drawing.Size(27, 26);
            this.txtREGF7.TabIndex = 0;
            this.txtREGF7.Text = "00";
            this.txtREGF7.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGF7.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG8F
            // 
            this.txtREG8F.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG8F.Location = new System.Drawing.Point(468, 280);
            this.txtREG8F.MaxLength = 2;
            this.txtREG8F.Name = "txtREG8F";
            this.txtREG8F.Size = new System.Drawing.Size(27, 26);
            this.txtREG8F.TabIndex = 0;
            this.txtREG8F.Text = "00";
            this.txtREG8F.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG8F.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGCF
            // 
            this.txtREGCF.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGCF.Location = new System.Drawing.Point(468, 408);
            this.txtREGCF.MaxLength = 2;
            this.txtREGCF.Name = "txtREGCF";
            this.txtREGCF.Size = new System.Drawing.Size(27, 26);
            this.txtREGCF.TabIndex = 0;
            this.txtREGCF.Text = "00";
            this.txtREGCF.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGCF.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREG9F
            // 
            this.txtREG9F.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREG9F.Location = new System.Drawing.Point(468, 312);
            this.txtREG9F.MaxLength = 2;
            this.txtREG9F.Name = "txtREG9F";
            this.txtREG9F.Size = new System.Drawing.Size(27, 26);
            this.txtREG9F.TabIndex = 0;
            this.txtREG9F.Text = "00";
            this.txtREG9F.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREG9F.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGDF
            // 
            this.txtREGDF.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGDF.Location = new System.Drawing.Point(468, 440);
            this.txtREGDF.MaxLength = 2;
            this.txtREGDF.Name = "txtREGDF";
            this.txtREGDF.Size = new System.Drawing.Size(27, 26);
            this.txtREGDF.TabIndex = 0;
            this.txtREGDF.Text = "00";
            this.txtREGDF.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGDF.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGAF
            // 
            this.txtREGAF.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGAF.Location = new System.Drawing.Point(468, 344);
            this.txtREGAF.MaxLength = 2;
            this.txtREGAF.Name = "txtREGAF";
            this.txtREGAF.Size = new System.Drawing.Size(27, 26);
            this.txtREGAF.TabIndex = 0;
            this.txtREGAF.Text = "00";
            this.txtREGAF.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGAF.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGEF
            // 
            this.txtREGEF.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGEF.Location = new System.Drawing.Point(468, 472);
            this.txtREGEF.MaxLength = 2;
            this.txtREGEF.Name = "txtREGEF";
            this.txtREGEF.Size = new System.Drawing.Size(27, 26);
            this.txtREGEF.TabIndex = 0;
            this.txtREGEF.Text = "00";
            this.txtREGEF.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGEF.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGBF
            // 
            this.txtREGBF.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGBF.Location = new System.Drawing.Point(468, 376);
            this.txtREGBF.MaxLength = 2;
            this.txtREGBF.Name = "txtREGBF";
            this.txtREGBF.Size = new System.Drawing.Size(27, 26);
            this.txtREGBF.TabIndex = 0;
            this.txtREGBF.Text = "00";
            this.txtREGBF.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGBF.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // txtREGFF
            // 
            this.txtREGFF.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREGFF.Location = new System.Drawing.Point(468, 504);
            this.txtREGFF.MaxLength = 2;
            this.txtREGFF.Name = "txtREGFF";
            this.txtREGFF.Size = new System.Drawing.Size(27, 26);
            this.txtREGFF.TabIndex = 0;
            this.txtREGFF.Text = "00";
            this.txtREGFF.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.txtREGFF.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // lbl_REG00
            // 
            this.lbl_REG00.AutoSize = true;
            this.lbl_REG00.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_REG00.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_REG00.Location = new System.Drawing.Point(43, 3);
            this.lbl_REG00.Name = "lbl_REG00";
            this.lbl_REG00.Size = new System.Drawing.Size(28, 18);
            this.lbl_REG00.TabIndex = 1;
            this.lbl_REG00.Text = "00";
            // 
            // lbl_REG01
            // 
            this.lbl_REG01.AutoSize = true;
            this.lbl_REG01.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_REG01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_REG01.Location = new System.Drawing.Point(70, 3);
            this.lbl_REG01.Name = "lbl_REG01";
            this.lbl_REG01.Size = new System.Drawing.Size(28, 18);
            this.lbl_REG01.TabIndex = 1;
            this.lbl_REG01.Text = "01";
            // 
            // lbl_REG02
            // 
            this.lbl_REG02.AutoSize = true;
            this.lbl_REG02.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_REG02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_REG02.Location = new System.Drawing.Point(97, 3);
            this.lbl_REG02.Name = "lbl_REG02";
            this.lbl_REG02.Size = new System.Drawing.Size(28, 18);
            this.lbl_REG02.TabIndex = 1;
            this.lbl_REG02.Text = "02";
            // 
            // lbl_REG03
            // 
            this.lbl_REG03.AutoSize = true;
            this.lbl_REG03.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_REG03.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_REG03.Location = new System.Drawing.Point(124, 3);
            this.lbl_REG03.Name = "lbl_REG03";
            this.lbl_REG03.Size = new System.Drawing.Size(28, 18);
            this.lbl_REG03.TabIndex = 1;
            this.lbl_REG03.Text = "03";
            // 
            // lbl_REG04
            // 
            this.lbl_REG04.AutoSize = true;
            this.lbl_REG04.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_REG04.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_REG04.Location = new System.Drawing.Point(154, 3);
            this.lbl_REG04.Name = "lbl_REG04";
            this.lbl_REG04.Size = new System.Drawing.Size(28, 18);
            this.lbl_REG04.TabIndex = 1;
            this.lbl_REG04.Text = "04";
            // 
            // lbl_REG05
            // 
            this.lbl_REG05.AutoSize = true;
            this.lbl_REG05.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_REG05.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_REG05.Location = new System.Drawing.Point(182, 3);
            this.lbl_REG05.Name = "lbl_REG05";
            this.lbl_REG05.Size = new System.Drawing.Size(28, 18);
            this.lbl_REG05.TabIndex = 1;
            this.lbl_REG05.Text = "05";
            // 
            // lbl_REG06
            // 
            this.lbl_REG06.AutoSize = true;
            this.lbl_REG06.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_REG06.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_REG06.Location = new System.Drawing.Point(210, 3);
            this.lbl_REG06.Name = "lbl_REG06";
            this.lbl_REG06.Size = new System.Drawing.Size(28, 18);
            this.lbl_REG06.TabIndex = 1;
            this.lbl_REG06.Text = "06";
            // 
            // lbl_REG07
            // 
            this.lbl_REG07.AutoSize = true;
            this.lbl_REG07.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_REG07.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_REG07.Location = new System.Drawing.Point(238, 3);
            this.lbl_REG07.Name = "lbl_REG07";
            this.lbl_REG07.Size = new System.Drawing.Size(28, 18);
            this.lbl_REG07.TabIndex = 1;
            this.lbl_REG07.Text = "07";
            // 
            // lbl_REG08
            // 
            this.lbl_REG08.AutoSize = true;
            this.lbl_REG08.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_REG08.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_REG08.Location = new System.Drawing.Point(272, 3);
            this.lbl_REG08.Name = "lbl_REG08";
            this.lbl_REG08.Size = new System.Drawing.Size(28, 18);
            this.lbl_REG08.TabIndex = 1;
            this.lbl_REG08.Text = "08";
            // 
            // lbl_REG09
            // 
            this.lbl_REG09.AutoSize = true;
            this.lbl_REG09.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_REG09.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_REG09.Location = new System.Drawing.Point(299, 3);
            this.lbl_REG09.Name = "lbl_REG09";
            this.lbl_REG09.Size = new System.Drawing.Size(28, 18);
            this.lbl_REG09.TabIndex = 1;
            this.lbl_REG09.Text = "09";
            // 
            // lbl_REG0A
            // 
            this.lbl_REG0A.AutoSize = true;
            this.lbl_REG0A.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_REG0A.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_REG0A.Location = new System.Drawing.Point(326, 3);
            this.lbl_REG0A.Name = "lbl_REG0A";
            this.lbl_REG0A.Size = new System.Drawing.Size(29, 18);
            this.lbl_REG0A.TabIndex = 1;
            this.lbl_REG0A.Text = "0A";
            // 
            // lbl_REG0B
            // 
            this.lbl_REG0B.AutoSize = true;
            this.lbl_REG0B.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_REG0B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_REG0B.Location = new System.Drawing.Point(353, 3);
            this.lbl_REG0B.Name = "lbl_REG0B";
            this.lbl_REG0B.Size = new System.Drawing.Size(29, 18);
            this.lbl_REG0B.TabIndex = 1;
            this.lbl_REG0B.Text = "0B";
            // 
            // lbl_REG0C
            // 
            this.lbl_REG0C.AutoSize = true;
            this.lbl_REG0C.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_REG0C.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_REG0C.Location = new System.Drawing.Point(383, 3);
            this.lbl_REG0C.Name = "lbl_REG0C";
            this.lbl_REG0C.Size = new System.Drawing.Size(29, 18);
            this.lbl_REG0C.TabIndex = 1;
            this.lbl_REG0C.Text = "0C";
            // 
            // lbl_REG0D
            // 
            this.lbl_REG0D.AutoSize = true;
            this.lbl_REG0D.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_REG0D.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_REG0D.Location = new System.Drawing.Point(411, 3);
            this.lbl_REG0D.Name = "lbl_REG0D";
            this.lbl_REG0D.Size = new System.Drawing.Size(30, 18);
            this.lbl_REG0D.TabIndex = 1;
            this.lbl_REG0D.Text = "0D";
            // 
            // lbl_REG0E
            // 
            this.lbl_REG0E.AutoSize = true;
            this.lbl_REG0E.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_REG0E.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_REG0E.Location = new System.Drawing.Point(439, 3);
            this.lbl_REG0E.Name = "lbl_REG0E";
            this.lbl_REG0E.Size = new System.Drawing.Size(28, 18);
            this.lbl_REG0E.TabIndex = 1;
            this.lbl_REG0E.Text = "0E";
            // 
            // lbl_REG0F
            // 
            this.lbl_REG0F.AutoSize = true;
            this.lbl_REG0F.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_REG0F.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_REG0F.Location = new System.Drawing.Point(467, 3);
            this.lbl_REG0F.Name = "lbl_REG0F";
            this.lbl_REG0F.Size = new System.Drawing.Size(27, 18);
            this.lbl_REG0F.TabIndex = 1;
            this.lbl_REG0F.Text = "0F";
            // 
            // lbl_REG00_2
            // 
            this.lbl_REG00_2.AutoSize = true;
            this.lbl_REG00_2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_REG00_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_REG00_2.Location = new System.Drawing.Point(9, 27);
            this.lbl_REG00_2.Name = "lbl_REG00_2";
            this.lbl_REG00_2.Size = new System.Drawing.Size(28, 18);
            this.lbl_REG00_2.TabIndex = 1;
            this.lbl_REG00_2.Text = "00";
            // 
            // lbl_REG10
            // 
            this.lbl_REG10.AutoSize = true;
            this.lbl_REG10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_REG10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_REG10.Location = new System.Drawing.Point(9, 59);
            this.lbl_REG10.Name = "lbl_REG10";
            this.lbl_REG10.Size = new System.Drawing.Size(28, 18);
            this.lbl_REG10.TabIndex = 1;
            this.lbl_REG10.Text = "10";
            // 
            // lbl_REG20
            // 
            this.lbl_REG20.AutoSize = true;
            this.lbl_REG20.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_REG20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_REG20.Location = new System.Drawing.Point(9, 91);
            this.lbl_REG20.Name = "lbl_REG20";
            this.lbl_REG20.Size = new System.Drawing.Size(28, 18);
            this.lbl_REG20.TabIndex = 1;
            this.lbl_REG20.Text = "20";
            // 
            // lbl_REG30
            // 
            this.lbl_REG30.AutoSize = true;
            this.lbl_REG30.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_REG30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_REG30.Location = new System.Drawing.Point(9, 123);
            this.lbl_REG30.Name = "lbl_REG30";
            this.lbl_REG30.Size = new System.Drawing.Size(28, 18);
            this.lbl_REG30.TabIndex = 1;
            this.lbl_REG30.Text = "30";
            // 
            // lbl_REG40
            // 
            this.lbl_REG40.AutoSize = true;
            this.lbl_REG40.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_REG40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_REG40.Location = new System.Drawing.Point(9, 155);
            this.lbl_REG40.Name = "lbl_REG40";
            this.lbl_REG40.Size = new System.Drawing.Size(28, 18);
            this.lbl_REG40.TabIndex = 1;
            this.lbl_REG40.Text = "40";
            // 
            // lbl_REG50
            // 
            this.lbl_REG50.AutoSize = true;
            this.lbl_REG50.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_REG50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_REG50.Location = new System.Drawing.Point(9, 187);
            this.lbl_REG50.Name = "lbl_REG50";
            this.lbl_REG50.Size = new System.Drawing.Size(28, 18);
            this.lbl_REG50.TabIndex = 1;
            this.lbl_REG50.Text = "50";
            // 
            // lbl_REG60
            // 
            this.lbl_REG60.AutoSize = true;
            this.lbl_REG60.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_REG60.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_REG60.Location = new System.Drawing.Point(9, 219);
            this.lbl_REG60.Name = "lbl_REG60";
            this.lbl_REG60.Size = new System.Drawing.Size(28, 18);
            this.lbl_REG60.TabIndex = 1;
            this.lbl_REG60.Text = "60";
            // 
            // lbl_REG70
            // 
            this.lbl_REG70.AutoSize = true;
            this.lbl_REG70.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_REG70.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_REG70.Location = new System.Drawing.Point(9, 251);
            this.lbl_REG70.Name = "lbl_REG70";
            this.lbl_REG70.Size = new System.Drawing.Size(28, 18);
            this.lbl_REG70.TabIndex = 1;
            this.lbl_REG70.Text = "70";
            // 
            // lbl_REG80
            // 
            this.lbl_REG80.AutoSize = true;
            this.lbl_REG80.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_REG80.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_REG80.Location = new System.Drawing.Point(9, 283);
            this.lbl_REG80.Name = "lbl_REG80";
            this.lbl_REG80.Size = new System.Drawing.Size(28, 18);
            this.lbl_REG80.TabIndex = 1;
            this.lbl_REG80.Text = "80";
            // 
            // lbl_REG90
            // 
            this.lbl_REG90.AutoSize = true;
            this.lbl_REG90.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_REG90.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_REG90.Location = new System.Drawing.Point(9, 315);
            this.lbl_REG90.Name = "lbl_REG90";
            this.lbl_REG90.Size = new System.Drawing.Size(28, 18);
            this.lbl_REG90.TabIndex = 1;
            this.lbl_REG90.Text = "90";
            // 
            // lbl_REGA0
            // 
            this.lbl_REGA0.AutoSize = true;
            this.lbl_REGA0.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_REGA0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_REGA0.Location = new System.Drawing.Point(9, 347);
            this.lbl_REGA0.Name = "lbl_REGA0";
            this.lbl_REGA0.Size = new System.Drawing.Size(29, 18);
            this.lbl_REGA0.TabIndex = 1;
            this.lbl_REGA0.Text = "A0";
            // 
            // lbl_REGB0
            // 
            this.lbl_REGB0.AutoSize = true;
            this.lbl_REGB0.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_REGB0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_REGB0.Location = new System.Drawing.Point(9, 379);
            this.lbl_REGB0.Name = "lbl_REGB0";
            this.lbl_REGB0.Size = new System.Drawing.Size(29, 18);
            this.lbl_REGB0.TabIndex = 1;
            this.lbl_REGB0.Text = "B0";
            // 
            // lbl_REGC0
            // 
            this.lbl_REGC0.AutoSize = true;
            this.lbl_REGC0.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_REGC0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_REGC0.Location = new System.Drawing.Point(9, 411);
            this.lbl_REGC0.Name = "lbl_REGC0";
            this.lbl_REGC0.Size = new System.Drawing.Size(29, 18);
            this.lbl_REGC0.TabIndex = 1;
            this.lbl_REGC0.Text = "C0";
            // 
            // lbl_REGE0
            // 
            this.lbl_REGE0.AutoSize = true;
            this.lbl_REGE0.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_REGE0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_REGE0.Location = new System.Drawing.Point(9, 475);
            this.lbl_REGE0.Name = "lbl_REGE0";
            this.lbl_REGE0.Size = new System.Drawing.Size(28, 18);
            this.lbl_REGE0.TabIndex = 1;
            this.lbl_REGE0.Text = "E0";
            // 
            // lbl_REGD0
            // 
            this.lbl_REGD0.AutoSize = true;
            this.lbl_REGD0.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_REGD0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_REGD0.Location = new System.Drawing.Point(9, 443);
            this.lbl_REGD0.Name = "lbl_REGD0";
            this.lbl_REGD0.Size = new System.Drawing.Size(30, 18);
            this.lbl_REGD0.TabIndex = 1;
            this.lbl_REGD0.Text = "D0";
            this.lbl_REGD0.MouseLeave += new System.EventHandler(this.txtREG00_MouseLeave);
            this.lbl_REGD0.MouseHover += new System.EventHandler(this.txtREG00_MouseHover);
            // 
            // lbl_REGF0
            // 
            this.lbl_REGF0.AutoSize = true;
            this.lbl_REGF0.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_REGF0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_REGF0.Location = new System.Drawing.Point(9, 507);
            this.lbl_REGF0.Name = "lbl_REGF0";
            this.lbl_REGF0.Size = new System.Drawing.Size(27, 18);
            this.lbl_REGF0.TabIndex = 1;
            this.lbl_REGF0.Text = "F0";
            // 
            // lblREGAddr
            // 
            this.lblREGAddr.AutoSize = true;
            this.lblREGAddr.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblREGAddr.ForeColor = System.Drawing.Color.Red;
            this.lblREGAddr.Location = new System.Drawing.Point(380, 19);
            this.lblREGAddr.Name = "lblREGAddr";
            this.lblREGAddr.Size = new System.Drawing.Size(0, 61);
            this.lblREGAddr.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 740);
            this.Controls.Add(this.lblREGAddr);
            this.Controls.Add(this.btnClearMessage);
            this.Controls.Add(this.lblTimeClock);
            this.Controls.Add(this.gprMainPage);
            this.Controls.Add(this.btnFormExit);
            this.Controls.Add(this.lblBAUDRATE);
            this.Controls.Add(this.lblCOMPORT);
            this.Controls.Add(this.cboBaudRate);
            this.Controls.Add(this.cboComPort);
            this.Controls.Add(this.btnPortDisConnect);
            this.Controls.Add(this.btnComPortConnet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "RS232 Tools";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gprMainPage.ResumeLayout(false);
            this.gprMainPage.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnComPortConnet;
        private System.Windows.Forms.Button btnPortDisConnect;
        private System.Windows.Forms.ComboBox cboComPort;
        private System.Windows.Forms.ComboBox cboBaudRate;
        private System.Windows.Forms.Label lblCOMPORT;
        private System.Windows.Forms.Label lblBAUDRATE;
        private System.Windows.Forms.Button btnFormExit;
        private System.Windows.Forms.GroupBox gprMainPage;
        private System.Windows.Forms.TextBox txtCMDDATA;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.RichTextBox rtfMessage;
        private System.Windows.Forms.Button btnSendCMD;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimeClock;
        private System.Windows.Forms.Button btnClearMessage;
        private System.Windows.Forms.CheckBox chkRepeatCMD;
        private System.Windows.Forms.ComboBox cboSecond;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnReadRegister;
        private System.Windows.Forms.Button btnWriteRegister;
        private System.Windows.Forms.TextBox txtWriteREGData;
        private System.Windows.Forms.TextBox txtWriteREGAddr;
        private System.Windows.Forms.TextBox txtReadREGData;
        private System.Windows.Forms.TextBox txtReadREGAddr;
        private System.Windows.Forms.ComboBox cboChipID;
        private System.Windows.Forms.TextBox txtI2CAddr;
        private System.Windows.Forms.RichTextBox rtfMessage2;
        private System.Windows.Forms.Label lblI2CID;
        private System.Windows.Forms.Label lbaAddrAndData;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtREG00;
        private System.Windows.Forms.TextBox txtREGFF;
        private System.Windows.Forms.TextBox txtREG7F;
        private System.Windows.Forms.TextBox txtREGBF;
        private System.Windows.Forms.TextBox txtREG3F;
        private System.Windows.Forms.TextBox txtREGEF;
        private System.Windows.Forms.TextBox txtREG6F;
        private System.Windows.Forms.TextBox txtREGAF;
        private System.Windows.Forms.TextBox txtREG2F;
        private System.Windows.Forms.TextBox txtREGDF;
        private System.Windows.Forms.TextBox txtREG5F;
        private System.Windows.Forms.TextBox txtREG9F;
        private System.Windows.Forms.TextBox txtREG1F;
        private System.Windows.Forms.TextBox txtREGCF;
        private System.Windows.Forms.TextBox txtREG4F;
        private System.Windows.Forms.TextBox txtREG8F;
        private System.Windows.Forms.TextBox txtREG0F;
        private System.Windows.Forms.TextBox txtREGF7;
        private System.Windows.Forms.TextBox txtREG77;
        private System.Windows.Forms.TextBox txtREGB7;
        private System.Windows.Forms.TextBox txtREG37;
        private System.Windows.Forms.TextBox txtREGE7;
        private System.Windows.Forms.TextBox txtREG67;
        private System.Windows.Forms.TextBox txtREGA7;
        private System.Windows.Forms.TextBox txtREG27;
        private System.Windows.Forms.TextBox txtREGD7;
        private System.Windows.Forms.TextBox txtREG57;
        private System.Windows.Forms.TextBox txtREG97;
        private System.Windows.Forms.TextBox txtREG17;
        private System.Windows.Forms.TextBox txtREGC7;
        private System.Windows.Forms.TextBox txtREG47;
        private System.Windows.Forms.TextBox txtREG87;
        private System.Windows.Forms.TextBox txtREG07;
        private System.Windows.Forms.TextBox txtREGFE;
        private System.Windows.Forms.TextBox txtREG7E;
        private System.Windows.Forms.TextBox txtREGBE;
        private System.Windows.Forms.TextBox txtREG3E;
        private System.Windows.Forms.TextBox txtREGEE;
        private System.Windows.Forms.TextBox txtREG6E;
        private System.Windows.Forms.TextBox txtREGAE;
        private System.Windows.Forms.TextBox txtREG2E;
        private System.Windows.Forms.TextBox txtREGDE;
        private System.Windows.Forms.TextBox txtREG5E;
        private System.Windows.Forms.TextBox txtREG9E;
        private System.Windows.Forms.TextBox txtREG1E;
        private System.Windows.Forms.TextBox txtREGCE;
        private System.Windows.Forms.TextBox txtREG4E;
        private System.Windows.Forms.TextBox txtREG8E;
        private System.Windows.Forms.TextBox txtREG0E;
        private System.Windows.Forms.TextBox txtREGF6;
        private System.Windows.Forms.TextBox txtREG76;
        private System.Windows.Forms.TextBox txtREGB6;
        private System.Windows.Forms.TextBox txtREG36;
        private System.Windows.Forms.TextBox txtREGE6;
        private System.Windows.Forms.TextBox txtREG66;
        private System.Windows.Forms.TextBox txtREGA6;
        private System.Windows.Forms.TextBox txtREG26;
        private System.Windows.Forms.TextBox txtREGD6;
        private System.Windows.Forms.TextBox txtREG56;
        private System.Windows.Forms.TextBox txtREG96;
        private System.Windows.Forms.TextBox txtREG16;
        private System.Windows.Forms.TextBox txtREGC6;
        private System.Windows.Forms.TextBox txtREG46;
        private System.Windows.Forms.TextBox txtREG86;
        private System.Windows.Forms.TextBox txtREG06;
        private System.Windows.Forms.TextBox txtREGFD;
        private System.Windows.Forms.TextBox txtREG7D;
        private System.Windows.Forms.TextBox txtREGBD;
        private System.Windows.Forms.TextBox txtREG3D;
        private System.Windows.Forms.TextBox txtREGED;
        private System.Windows.Forms.TextBox txtREG6D;
        private System.Windows.Forms.TextBox txtREGAD;
        private System.Windows.Forms.TextBox txtREG2D;
        private System.Windows.Forms.TextBox txtREGDD;
        private System.Windows.Forms.TextBox txtREG5D;
        private System.Windows.Forms.TextBox txtREG9D;
        private System.Windows.Forms.TextBox txtREG1D;
        private System.Windows.Forms.TextBox txtREGCD;
        private System.Windows.Forms.TextBox txtREG4D;
        private System.Windows.Forms.TextBox txtREG8D;
        private System.Windows.Forms.TextBox txtREG0D;
        private System.Windows.Forms.TextBox txtREGF5;
        private System.Windows.Forms.TextBox txtREG75;
        private System.Windows.Forms.TextBox txtREGB5;
        private System.Windows.Forms.TextBox txtREG35;
        private System.Windows.Forms.TextBox txtREGE5;
        private System.Windows.Forms.TextBox txtREG65;
        private System.Windows.Forms.TextBox txtREGA5;
        private System.Windows.Forms.TextBox txtREG25;
        private System.Windows.Forms.TextBox txtREGD5;
        private System.Windows.Forms.TextBox txtREG55;
        private System.Windows.Forms.TextBox txtREG95;
        private System.Windows.Forms.TextBox txtREG15;
        private System.Windows.Forms.TextBox txtREGC5;
        private System.Windows.Forms.TextBox txtREG45;
        private System.Windows.Forms.TextBox txtREG85;
        private System.Windows.Forms.TextBox txtREG05;
        private System.Windows.Forms.TextBox txtREGFC;
        private System.Windows.Forms.TextBox txtREG7C;
        private System.Windows.Forms.TextBox txtREGBC;
        private System.Windows.Forms.TextBox txtREG3C;
        private System.Windows.Forms.TextBox txtREGEC;
        private System.Windows.Forms.TextBox txtREG6C;
        private System.Windows.Forms.TextBox txtREGAC;
        private System.Windows.Forms.TextBox txtREG2C;
        private System.Windows.Forms.TextBox txtREGDC;
        private System.Windows.Forms.TextBox txtREG5C;
        private System.Windows.Forms.TextBox txtREG9C;
        private System.Windows.Forms.TextBox txtREG1C;
        private System.Windows.Forms.TextBox txtREGCC;
        private System.Windows.Forms.TextBox txtREG4C;
        private System.Windows.Forms.TextBox txtREG8C;
        private System.Windows.Forms.TextBox txtREG0C;
        private System.Windows.Forms.TextBox txtREGF4;
        private System.Windows.Forms.TextBox txtREG74;
        private System.Windows.Forms.TextBox txtREGB4;
        private System.Windows.Forms.TextBox txtREG34;
        private System.Windows.Forms.TextBox txtREGE4;
        private System.Windows.Forms.TextBox txtREG64;
        private System.Windows.Forms.TextBox txtREGA4;
        private System.Windows.Forms.TextBox txtREG24;
        private System.Windows.Forms.TextBox txtREGD4;
        private System.Windows.Forms.TextBox txtREG54;
        private System.Windows.Forms.TextBox txtREG94;
        private System.Windows.Forms.TextBox txtREG14;
        private System.Windows.Forms.TextBox txtREGC4;
        private System.Windows.Forms.TextBox txtREG44;
        private System.Windows.Forms.TextBox txtREG84;
        private System.Windows.Forms.TextBox txtREG04;
        private System.Windows.Forms.TextBox txtREGFB;
        private System.Windows.Forms.TextBox txtREG7B;
        private System.Windows.Forms.TextBox txtREGBB;
        private System.Windows.Forms.TextBox txtREG3B;
        private System.Windows.Forms.TextBox txtREGEB;
        private System.Windows.Forms.TextBox txtREG6B;
        private System.Windows.Forms.TextBox txtREGAB;
        private System.Windows.Forms.TextBox txtREG2B;
        private System.Windows.Forms.TextBox txtREGDB;
        private System.Windows.Forms.TextBox txtREG5B;
        private System.Windows.Forms.TextBox txtREG9B;
        private System.Windows.Forms.TextBox txtREG1B;
        private System.Windows.Forms.TextBox txtREGCB;
        private System.Windows.Forms.TextBox txtREG4B;
        private System.Windows.Forms.TextBox txtREG8B;
        private System.Windows.Forms.TextBox txtREG0B;
        private System.Windows.Forms.TextBox txtREGF3;
        private System.Windows.Forms.TextBox txtREG73;
        private System.Windows.Forms.TextBox txtREGB3;
        private System.Windows.Forms.TextBox txtREG33;
        private System.Windows.Forms.TextBox txtREGE3;
        private System.Windows.Forms.TextBox txtREG63;
        private System.Windows.Forms.TextBox txtREGA3;
        private System.Windows.Forms.TextBox txtREG23;
        private System.Windows.Forms.TextBox txtREGD3;
        private System.Windows.Forms.TextBox txtREG53;
        private System.Windows.Forms.TextBox txtREG93;
        private System.Windows.Forms.TextBox txtREG13;
        private System.Windows.Forms.TextBox txtREGC3;
        private System.Windows.Forms.TextBox txtREG43;
        private System.Windows.Forms.TextBox txtREG83;
        private System.Windows.Forms.TextBox txtREG03;
        private System.Windows.Forms.TextBox txtREGFA;
        private System.Windows.Forms.TextBox txtREG7A;
        private System.Windows.Forms.TextBox txtREGBA;
        private System.Windows.Forms.TextBox txtREG3A;
        private System.Windows.Forms.TextBox txtREGEA;
        private System.Windows.Forms.TextBox txtREG6A;
        private System.Windows.Forms.TextBox txtREGAA;
        private System.Windows.Forms.TextBox txtREG2A;
        private System.Windows.Forms.TextBox txtREGDA;
        private System.Windows.Forms.TextBox txtREG5A;
        private System.Windows.Forms.TextBox txtREG9A;
        private System.Windows.Forms.TextBox txtREG1A;
        private System.Windows.Forms.TextBox txtREGCA;
        private System.Windows.Forms.TextBox txtREG4A;
        private System.Windows.Forms.TextBox txtREG8A;
        private System.Windows.Forms.TextBox txtREG0A;
        private System.Windows.Forms.TextBox txtREGF2;
        private System.Windows.Forms.TextBox txtREG72;
        private System.Windows.Forms.TextBox txtREGB2;
        private System.Windows.Forms.TextBox txtREG32;
        private System.Windows.Forms.TextBox txtREGE2;
        private System.Windows.Forms.TextBox txtREG62;
        private System.Windows.Forms.TextBox txtREGA2;
        private System.Windows.Forms.TextBox txtREG22;
        private System.Windows.Forms.TextBox txtREGD2;
        private System.Windows.Forms.TextBox txtREG52;
        private System.Windows.Forms.TextBox txtREG92;
        private System.Windows.Forms.TextBox txtREG12;
        private System.Windows.Forms.TextBox txtREGC2;
        private System.Windows.Forms.TextBox txtREG42;
        private System.Windows.Forms.TextBox txtREG82;
        private System.Windows.Forms.TextBox txtREG02;
        private System.Windows.Forms.TextBox txtREGF9;
        private System.Windows.Forms.TextBox txtREG79;
        private System.Windows.Forms.TextBox txtREGB9;
        private System.Windows.Forms.TextBox txtREG39;
        private System.Windows.Forms.TextBox txtREGE9;
        private System.Windows.Forms.TextBox txtREG69;
        private System.Windows.Forms.TextBox txtREGA9;
        private System.Windows.Forms.TextBox txtREG29;
        private System.Windows.Forms.TextBox txtREGD9;
        private System.Windows.Forms.TextBox txtREG59;
        private System.Windows.Forms.TextBox txtREG99;
        private System.Windows.Forms.TextBox txtREG19;
        private System.Windows.Forms.TextBox txtREGC9;
        private System.Windows.Forms.TextBox txtREG49;
        private System.Windows.Forms.TextBox txtREG89;
        private System.Windows.Forms.TextBox txtREG09;
        private System.Windows.Forms.TextBox txtREGF1;
        private System.Windows.Forms.TextBox txtREG71;
        private System.Windows.Forms.TextBox txtREGB1;
        private System.Windows.Forms.TextBox txtREG31;
        private System.Windows.Forms.TextBox txtREGE1;
        private System.Windows.Forms.TextBox txtREG61;
        private System.Windows.Forms.TextBox txtREGA1;
        private System.Windows.Forms.TextBox txtREG21;
        private System.Windows.Forms.TextBox txtREGD1;
        private System.Windows.Forms.TextBox txtREG51;
        private System.Windows.Forms.TextBox txtREG91;
        private System.Windows.Forms.TextBox txtREG11;
        private System.Windows.Forms.TextBox txtREGC1;
        private System.Windows.Forms.TextBox txtREG41;
        private System.Windows.Forms.TextBox txtREG81;
        private System.Windows.Forms.TextBox txtREG01;
        private System.Windows.Forms.TextBox txtREGF8;
        private System.Windows.Forms.TextBox txtREG78;
        private System.Windows.Forms.TextBox txtREGB8;
        private System.Windows.Forms.TextBox txtREG38;
        private System.Windows.Forms.TextBox txtREGE8;
        private System.Windows.Forms.TextBox txtREG68;
        private System.Windows.Forms.TextBox txtREGA8;
        private System.Windows.Forms.TextBox txtREG28;
        private System.Windows.Forms.TextBox txtREGD8;
        private System.Windows.Forms.TextBox txtREG58;
        private System.Windows.Forms.TextBox txtREG98;
        private System.Windows.Forms.TextBox txtREG18;
        private System.Windows.Forms.TextBox txtREGC8;
        private System.Windows.Forms.TextBox txtREG48;
        private System.Windows.Forms.TextBox txtREG88;
        private System.Windows.Forms.TextBox txtREG08;
        private System.Windows.Forms.TextBox txtREGF0;
        private System.Windows.Forms.TextBox txtREG70;
        private System.Windows.Forms.TextBox txtREGB0;
        private System.Windows.Forms.TextBox txtREG30;
        private System.Windows.Forms.TextBox txtREGE0;
        private System.Windows.Forms.TextBox txtREG60;
        private System.Windows.Forms.TextBox txtREGA0;
        private System.Windows.Forms.TextBox txtREG20;
        private System.Windows.Forms.TextBox txtREGD0;
        private System.Windows.Forms.TextBox txtREG50;
        private System.Windows.Forms.TextBox txtREG90;
        private System.Windows.Forms.TextBox txtREG10;
        private System.Windows.Forms.TextBox txtREGC0;
        private System.Windows.Forms.TextBox txtREG40;
        private System.Windows.Forms.TextBox txtREG80;
        private System.Windows.Forms.Label lbl_REG0F;
        private System.Windows.Forms.Label lbl_REG07;
        private System.Windows.Forms.Label lbl_REG0E;
        private System.Windows.Forms.Label lbl_REG06;
        private System.Windows.Forms.Label lbl_REG0D;
        private System.Windows.Forms.Label lbl_REG05;
        private System.Windows.Forms.Label lbl_REG0C;
        private System.Windows.Forms.Label lbl_REG04;
        private System.Windows.Forms.Label lbl_REG0B;
        private System.Windows.Forms.Label lbl_REG03;
        private System.Windows.Forms.Label lbl_REG0A;
        private System.Windows.Forms.Label lbl_REG02;
        private System.Windows.Forms.Label lbl_REG09;
        private System.Windows.Forms.Label lbl_REG01;
        private System.Windows.Forms.Label lbl_REG08;
        private System.Windows.Forms.Label lbl_REGF0;
        private System.Windows.Forms.Label lbl_REG70;
        private System.Windows.Forms.Label lbl_REGD0;
        private System.Windows.Forms.Label lbl_REG50;
        private System.Windows.Forms.Label lbl_REGE0;
        private System.Windows.Forms.Label lbl_REG60;
        private System.Windows.Forms.Label lbl_REGC0;
        private System.Windows.Forms.Label lbl_REG40;
        private System.Windows.Forms.Label lbl_REGB0;
        private System.Windows.Forms.Label lbl_REG30;
        private System.Windows.Forms.Label lbl_REGA0;
        private System.Windows.Forms.Label lbl_REG20;
        private System.Windows.Forms.Label lbl_REG90;
        private System.Windows.Forms.Label lbl_REG10;
        private System.Windows.Forms.Label lbl_REG80;
        private System.Windows.Forms.Label lbl_REG00_2;
        private System.Windows.Forms.Label lbl_REG00;
        private System.Windows.Forms.Label lblREGAddr;
    }
}

