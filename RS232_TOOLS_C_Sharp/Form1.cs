using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace RS232_TOOLS_C_Sharp
{
  public enum Commands
        {
        SendCMD,
        CMDR ,
        CMDW ,
        WATER ,
        FIRE,
        WOOD,
        LIGHT,
        DARK
        }
 

    public partial class Form1 : Form
    {
     string strTEMP = "";

    //Dump 設定
    bool CMDR_Action = false;
    int Dump_Start=0;
    int Dump_End=0;
    int Dump_Loop=0;
    //Write REG 設定
    bool CMDW_Action = false;
    int WriteREGALL_Start = 0;
    int WriteREGALL_End = 0;
    int WriteREGALL_Loop = 0;

     //   SerialPort serialPort1 = new SerialPort();
        delegate void SetTextCallback(string text);

      

          public Form1()
        {
        

            InitializeComponent();

         
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            String test = "";
            if (serialPort1.BytesToRead > 0)
            {
                this.ReceiveAuto(test);
            }
        }

        private void ReceiveAuto(string test)
        {
            if (this.rtfMessage.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(ReceiveAuto);
                this.Invoke(d, new object[] { "" });
            }
            else
            {
                ReceiveData();
            }
        }

        private void ReceiveData()
        {
        TextBox[] txtREG = new TextBox[] { 
     txtREG00, txtREG01, txtREG02, txtREG03, txtREG04, txtREG05, txtREG06, txtREG07, txtREG08, txtREG09, txtREG0A, txtREG0B, txtREG0C, txtREG0D, txtREG0E, txtREG0F,  
     txtREG10, txtREG11, txtREG12, txtREG13, txtREG14, txtREG15, txtREG16, txtREG17, txtREG18, txtREG19, txtREG1A, txtREG1B, txtREG1C, txtREG1D, txtREG1E, txtREG1F, 
     txtREG20, txtREG21, txtREG22, txtREG23, txtREG24, txtREG25, txtREG26, txtREG27, txtREG28, txtREG29, txtREG2A, txtREG2B, txtREG2C, txtREG2D, txtREG2E, txtREG2F, 
     txtREG30, txtREG31, txtREG32, txtREG33, txtREG34, txtREG35, txtREG36, txtREG37, txtREG38, txtREG39, txtREG3A, txtREG3B, txtREG3C, txtREG3D, txtREG3E, txtREG3F, 
     txtREG40, txtREG41, txtREG42, txtREG43, txtREG44, txtREG45, txtREG46, txtREG47, txtREG48, txtREG49, txtREG4A, txtREG4B, txtREG4C, txtREG4D, txtREG4E, txtREG4F, 
     txtREG50, txtREG51, txtREG52, txtREG53, txtREG54, txtREG55, txtREG56, txtREG57, txtREG58, txtREG59, txtREG5A, txtREG5B, txtREG5C, txtREG5D, txtREG5E, txtREG5F, 
     txtREG60, txtREG61, txtREG62, txtREG63, txtREG64, txtREG65, txtREG66, txtREG67, txtREG68, txtREG69, txtREG6A, txtREG6B, txtREG6C, txtREG6D, txtREG6E, txtREG6F, 
     txtREG70, txtREG71, txtREG72, txtREG73, txtREG74, txtREG75, txtREG76, txtREG77, txtREG78, txtREG79, txtREG7A, txtREG7B, txtREG7C, txtREG7D, txtREG7E, txtREG7F, 
     txtREG80, txtREG81, txtREG82, txtREG83, txtREG84, txtREG85, txtREG86, txtREG87, txtREG88, txtREG89, txtREG8A, txtREG8B, txtREG8C, txtREG8D, txtREG8E, txtREG8F, 
     txtREG90, txtREG91, txtREG92, txtREG93, txtREG94, txtREG95, txtREG96, txtREG97, txtREG98, txtREG99, txtREG9A, txtREG9B, txtREG9C, txtREG9D, txtREG9E, txtREG9F, 
     txtREGA0, txtREGA1, txtREGA2, txtREGA3, txtREGA4, txtREGA5, txtREGA6, txtREGA7, txtREGA8, txtREGA9, txtREGAA, txtREGAB, txtREGAC, txtREGAD, txtREGAE, txtREGAF, 
     txtREGB0, txtREGB1, txtREGB2, txtREGB3, txtREGB4, txtREGB5, txtREGB6, txtREGB7, txtREGB8, txtREGB9, txtREGBA, txtREGBB, txtREGBC, txtREGBD, txtREGBE, txtREGBF, 
     txtREGC0, txtREGC1, txtREGC2, txtREGC3, txtREGC4, txtREGC5, txtREGC6, txtREGC7, txtREGC8, txtREGC9, txtREGCA, txtREGCB, txtREGCC, txtREGCD, txtREGCE, txtREGCF, 
     txtREGD0, txtREGD1, txtREGD2, txtREGD3, txtREGD4, txtREGD5, txtREGD6, txtREGD7, txtREGD8, txtREGD9, txtREGDA, txtREGDB, txtREGDC, txtREGDD, txtREGDE, txtREGDF, 
     txtREGE0, txtREGE1, txtREGE2, txtREGE3, txtREGE4, txtREGE5, txtREGE6, txtREGE7, txtREGE8, txtREGE9, txtREGEA, txtREGEB, txtREGEC, txtREGED, txtREGEE, txtREGEF, 
     txtREGF0, txtREGF1, txtREGF2, txtREGF3, txtREGF4, txtREGF5, txtREGF6, txtREGF7, txtREGF8, txtREGF9, txtREGFA, txtREGFB, txtREGFC, txtREGFD, txtREGFE, txtREGFF};      

            int GetValue;
            int k = serialPort1.BytesToRead;// -2;
            //if(k>0)
            byte[] ReadData = new byte[k];
            int i = 0;
            //string strTEMP = "";
            //if (AutoClean.Checked == true) //?芸?皜?交?孵?
            //{
            //    //txtReceiveHEX.
            //    if (CountLength >= CountLengthValue)
            //    //if (txtReceiveHEX.Text.Length >= CountLengthValue)
            //    {
            //        CountLength = 0;
            //        txtReceiveHEX.Text = "";
            //        txtReceiveASCII.Text = "";
            //    }
            //}
            //else
            //{
            //    if (AutoNewLine.Checked == true && txtReceiveHEX.Text == "")
            //    {
            //        txtReceiveHEX.Text += "\n";
            //        txtReceiveASCII.Text += "\n";
            //    }
            //}

            //PRINT("RS232有資料輸入\r\n");
        
            if (serialPort1.BytesToRead > 0)
            {
                try
                {
                    serialPort1.ReadTimeout = 1000;
                    GetValue = serialPort1.Read(ReadData, 0, k);

                    for (i = 0; i <= k - 1; i++)
                    {
                        {
                            //if (AutoClean.Checked == true) //?芸?皜?交?孵?
                            //{
                            //    CountLength++;
                            //    CountLengthValueDisplay.Text = Convert.ToString(CountLength);
                            //}
                            //txtReceiveHEX.Text += String.Format("{0:X2}", ReadData[i]) + ",";
                            //txtReceiveASCII.Text += (char)ReadData[i];// +",";
                        if ((char)ReadData[i] == '\n')//取消換行
                            {
                            //rtfMessage.Text += (char) ReadData[i];
                            }
                            else
                            {
                               rtfMessage.Text += (char) ReadData[i];
                               //rtfMessageTemp.Text += (char)ReadData[i];
                               strTEMP += (char)ReadData[i];
                               rtfMessage2.Text += (char)ReadData[i];
                            }
                        }

                    }



                    if ((rtfMessage2.Text.Contains("STX")) && (rtfMessage2.Text.Contains("ETX")))
                        {
                        //PRINT("Find STX and ETX");
                        //strTEMP.IndexOf("STX");
                        //STX4011223344ETX
                        txtReadREGData.Text = rtfMessage2.Text.Substring(rtfMessage2.Text.IndexOf("STX") + 5 , 2);
                        txtWriteREGAddr.Text = txtReadREGAddr.Text  = rtfMessage2.Text.Substring(rtfMessage2.Text.IndexOf("STX") + 3 , 2); //txtReadREGAddr.Text;
                        txtWriteREGData.Text = txtReadREGData.Text;

                        if (txtREG[Int32.Parse(txtReadREGAddr.Text , System.Globalization.NumberStyles.HexNumber)].Text != txtReadREGData.Text)
                            txtREG[Int32.Parse(txtReadREGAddr.Text , System.Globalization.NumberStyles.HexNumber)].ForeColor = Color.Red;
                        else
                            txtREG[Int32.Parse(txtReadREGAddr.Text , System.Globalization.NumberStyles.HexNumber)].ForeColor = Color.Empty;

                        txtREG[Int32.Parse(txtReadREGAddr.Text , System.Globalization.NumberStyles.HexNumber)].Text = txtReadREGData.Text;
                        txtREG[Int32.Parse(txtReadREGAddr.Text , System.Globalization.NumberStyles.HexNumber)].BackColor = Color.Empty;
                            ///dump 處理程序
                        if (CMDR_Action == true)  
                            {
                           // PRINT("Get Dump addr=" + txtReadREGAddr.Text + ",data=" + txtReadREGData.Text);

                            if (Dump_End > Dump_Loop)
                                {
                                //timer3.Interval = 5000; //dump處理程序預估5秒鐘
                                Dump_Loop++;
                                txtReadREGAddr.Text = Convert.ToString(Dump_Loop , 16).ToUpper();//轉成大寫16進位字串

                                if (txtReadREGAddr.Text.Length == 1)
                                    txtReadREGAddr.Text = "0" + txtReadREGAddr.Text;
                                
                                rtfMessage.Text = "";
                                SendCMDtoPort(Commands.CMDR);
                                }
                            else
                                {
                                CMDR_Action = false;
                                PRINT("Dump 程序結束..");
                                lblGetTime.Text = "_";
                                }
                            }
                        else if (CMDW_Action==true )
                            {
                            if (WriteREGALL_End  > WriteREGALL_Loop  )
                                {
                                //timer3.Interval = 5000; //dump處理程序預估5秒鐘
                                WriteREGALL_Loop++;                                                        

                                txtWriteREGAddr.Text = Convert.ToString(WriteREGALL_Loop , 16).ToUpper();//轉成大寫16進位字串

                                if (txtWriteREGAddr.Text.Length == 1)
                                    txtWriteREGAddr.Text = "0" + txtWriteREGAddr.Text;

                                txtWriteREGData.Text = txtREG[WriteREGALL_Loop].Text;                            

                                rtfMessage.Text = "";
                                SendCMDtoPort(Commands.CMDW);
                                }
                            else
                                {
                                CMDW_Action = false;
                                PRINT("Write REG 程序結束..");
                                lblGetTime.Text = "_";
                                }
                            }
                         //rtfMessageTemp.Text = "";
                        //PRINT("STX address=" + strTEMP.IndexOf("STX"));                        
                       // strTEMP.Remove(0 , strTEMP.IndexOf("STX")+13);
                      //  strTEMP = strTEMP.Trim().TrimEnd("ETX".ToCharArray());

                       // PRINT("strTEMP=" + strTEMP);
                        rtfMessage2.Text = "";
                        }

                    //rtfMessage2.Text = rtfMessage2.Text.Trim().TrimEnd("ETX".ToCharArray());                
                    rtfMessageReset();
                }
                catch (Exception )//ex //As Exception
                {
                    //MessageBox.Show("霈?隤歹?" + e.ToString(),
                    //                "RS485?航炊?",
                    //                MessageBoxButtons.OK,
                    //                MessageBoxIcon.Exclamation,
                    //                MessageBoxDefaultButton.btnComPortConnet);
                }
                //txtReceiveHEX.SelectionStart = txtReceiveHEX.Text.Length;
                //txtReceiveASCII.SelectionStart = txtReceiveASCII.Text.Length;
                //txtReceiveHEX.ScrollToCaret();
                //txtReceiveASCII.ScrollToCaret();
               // rtfMessage.SelectionStart = rtfMessage.Text.Length;
                //rtfMessage.ScrollToCaret();
               
            }


        }
        
        /// <summary>
        /// byte[] 轉 Hex String
        /// </summary>
        /// <param name="bytes">byte[]</param>
        /// <returns>Hex String</returns>
        protected string ToHexString(byte[] bytes)
        {
            string hexString = string.Empty;
            if (bytes != null)
            {
                StringBuilder str = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    str.Append(bytes[i].ToString("X2"));
                }
                hexString = str.ToString();
            }
            return hexString;
        }
        private void rtfMessageReset()
            {
            rtfMessage.SelectionStart = rtfMessage.Text.Length;
            rtfMessage.ScrollToCaret();

            }

        private void Form1_Load(object sender, EventArgs e)
        {

            string[] ports = SerialPort.GetPortNames();

            DateTime localDate = DateTime.Now;
            lblTimeClock.Text = localDate.ToString();

            foreach (string port in ports)
            {
               cboComPort.Items.Add(port); 
            }

            cboComPort.SelectedIndex = 0;
            cboBaudRate.SelectedIndex = 0;
            cboSecond.SelectedIndex = 0;
            txtI2CAddr2.Text = txtI2CAddr.Text;
            toolStripStatusLabel1 .Text = System.Windows.Forms.Application.StartupPath;
            StartUp();
        }

       
        private void StartUp()
         {
         //string path = System.Windows.Forms.Application.StartupPath + "/rs232.ini";
         //StreamReader sr = new StreamReader(path , Encoding.Default);
         //String line;
         //while ((line = sr.ReadLine()) != null)
         //    {
         //    //Console.WriteLine(line.ToString());
         //    PRINT (line.ToString());
         //    }
         string str = "";
         FileInfo f = new FileInfo(System.Windows.Forms.Application.StartupPath + "/rs232.ini");
         StreamReader sr = f.OpenText();
        while(sr.Peek()>=0)
                {
                
                str = sr.ReadLine();
                         
          //  if (str.Contains("COM21")                  

                   // foreach (string port in cboComPort.Items)
                        //{
                if (str.Contains("COM"))
                    {
                    // PRINT("Install COM PORT=" + str);

                    cboComPort.Text = str;
                    try
                        {
                        //波特率
                        serialPort1.BaudRate = 115200;
                        //資料位
                        serialPort1.DataBits = 8;
                        serialPort1.PortName = cboComPort.Text;
                        //兩個停止位
                        serialPort1.StopBits = System.IO.Ports.StopBits.One;
                        //無奇偶校驗位
                        serialPort1.Parity = System.IO.Ports.Parity.None;
                        serialPort1.ReadTimeout = 100;
                        serialPort1.Open();

                        if (!serialPort1.IsOpen)
                            {
                            MessageBox.Show("埠開啟失敗");
                            return;
                            }
                        else
                            {
                            //  rtfMessage.AppendText("埠" + cboComPort.Text + "開啟成功\r\n");
                            }

                        //serialPort1.DataReceived += serialPort1_DataReceived;

                        gprMainPage.Enabled = true;
                        btnComPortConnet.Enabled = false;
                        cboComPort.Enabled = false;
                        btnPortDisConnect.Enabled = true;
                        }
                    catch (Exception)
                        {
                        serialPort1.Dispose();
                        //rtfMessage.AppendText(ex.Message);
                        MessageBox.Show(serialPort1.PortName + "埠開啟失敗");
                        }
                    }
                else if (str.Contains("chkRepeatCMD.Checked"))
                    {
                    chkRepeatCMD.Checked = true;
                    }
                       // }
                   
                   
                }
        sr.Close();


         }

        private void btnFormExit_Click(object sender, EventArgs e)
        {
        DateTime localDate = DateTime.Now;
     
       string path = System.Windows.Forms.Application.StartupPath + "/rs232.ini";
        //FileStream fs = new FileStream(path  , FileMode.Create);
        ////獲得位元組陣列
        //byte[] data = System.Text.Encoding.Default.GetBytes("Hello World!");
        ////開始寫入
        //fs.Write(data , 0 , data.Length);

        //if (serialPort1.IsOpen == true)
        //    {
        //    fs.Write(serialPort1.na );
        //    }

        ////清空緩衝區、關閉流
        //fs.Flush();
        //fs.Close();

        FileStream fs = new FileStream(path , FileMode.Create);
        StreamWriter sw = new StreamWriter(fs);
        //開始寫入
        sw.Write(localDate.ToString() + "\r");
     
        if (serialPort1.IsOpen == true)
            sw.Write(serialPort1.PortName + "\r");

        if (chkRepeatCMD.Checked == true)
            sw.Write("chkRepeatCMD.Checked=true" + "\r");


        //清空緩衝區
        sw.Flush();
        //關閉流
        sw.Close();
        fs.Close();

        timer2.Enabled = false;
        btnSendCMD.Text = "傳送";
        btnSendCMD.BackColor = Color.Empty;

        serialPort1.Dispose();
        this.Close();
        }

        void PRINT(string str)
        {

            try
            {
                rtfMessage.AppendText( "\n" + str + "\n");
            }
            catch (Exception)
            {
            }

        }

        void PRINT2(string str)
            {

            try
                {
                rtfMessage.AppendText( str + "\n");
                }
            catch (Exception)
                {
                }

            }
        private void btnComPortConnet_Click(object sender, EventArgs e)
        {

            try
            {
                //波特率
                serialPort1.BaudRate = 115200;
                //資料位
                serialPort1.DataBits = 8;
                serialPort1.PortName = cboComPort.Text;              
                //兩個停止位
                serialPort1.StopBits = System.IO.Ports.StopBits.One;
                //無奇偶校驗位
                serialPort1.Parity = System.IO.Ports.Parity.None;
                serialPort1.ReadTimeout = 100;
                serialPort1.Open();

                if (!serialPort1.IsOpen)
                {
                    MessageBox.Show("埠開啟失敗");
                    return;
                }
                else
                {
                  //  rtfMessage.AppendText("埠" + cboComPort.Text + "開啟成功\r\n");
                }
                
                //serialPort1.DataReceived += serialPort1_DataReceived;

                gprMainPage.Enabled = true;
                btnComPortConnet.Enabled = false;
                cboComPort.Enabled = false;
                btnPortDisConnect.Enabled = true;
            }
            catch (Exception )
            {
                serialPort1.Dispose();
                //rtfMessage.AppendText(ex.Message);
                MessageBox.Show(serialPort1.PortName + "埠開啟失敗");
            }
        }

  
        private void btnPortDisConnect_Click(object sender, EventArgs e)
        {

            gprMainPage.Enabled = false;

            try
            {
                serialPort1.Dispose();

            }
            catch (Exception)
            {
                ////MessageBox.Show("COM PORT 沒有開啟");
                //rtfMessage.AppendText("COM PORT 沒有開啟\r\n");
            }

            rtfMessage.Text = "";
            btnComPortConnet.Enabled = true;
            btnPortDisConnect.Enabled = false;
            cboComPort.Enabled = true;

            timer2.Enabled = false;
            btnSendCMD.Text = "傳送";
            btnSendCMD.BackColor = Color.Empty;

            //cboBaudRate.Enabled = false;
       }

        private void btnSendCMD_Click(object sender, EventArgs e)
        {
           // serialPort1.Write(txtCMDDATA.Text + " \r" );
        if (btnSendCMD.Text == "停止")
            {
            timer2.Enabled = false ;
            btnSendCMD.Text = "傳送";
            btnSendCMD.BackColor = Color.Empty;
            }
        else
            {
            SendCMDtoPort(Commands.SendCMD);

            if ((chkRepeatCMD.Checked == true) && (cboSecond.SelectedIndex != 0))
                {
                timer2.Interval = (cboSecond.SelectedIndex * 1000);
                timer2.Enabled = true;
                btnSendCMD.Text = "停止";
                btnSendCMD.BackColor = Color.Red ;
                }
            }
        }

        public void SendCMDtoPort(Commands index )
            {
                switch(index)
                    {
                    case Commands.SendCMD:
                        //serialPort1.Write(str + " \r");
                        serialPort1.Write(txtCMDDATA.Text + " \r");
                        break;
                    case Commands.CMDR:
                        //serialPort1.Write(str + " \r");
                        serialPort1.Write("CMDR " + txtI2CAddr.Text + " " + txtReadREGAddr.Text + " \r");
                        break;
                    case Commands.CMDW:
                        //serialPort1.Write(str + " \r");
                        serialPort1.Write( "CMDW " + txtI2CAddr.Text + " " + txtWriteREGAddr.Text + " " + txtWriteREGData.Text + " \r");
                        break;
                    default :
                        break;
                    }
            
                //rtfMessage.Text = "";   
            }

        private void timer1_Tick(object sender , EventArgs e)
            {
            DateTime localDate = DateTime.Now;
            lblTimeClock.Text = localDate.ToString();// DateTime.Now.ToString("HH:mm:ss");
            //lblGetTime.Text = localDate.AddSeconds(15).ToString() ; 

            if (timer2.Enabled == true)
                {
                if (btnSendCMD.BackColor == Color.Red)
                    btnSendCMD.BackColor = Color.Empty;
                else
                    btnSendCMD.BackColor = Color.Red;
                }

            if (lblGetTime.Text == localDate.AddSeconds(0).ToString("HH:mm:ss"))
                {
                   if (CMDR_Action == true)
                    {
                    PRINT("Dump處理程序沒有完成..");
                    CMDR_Action = false;
                    }
                   else if (CMDW_Action == true)
                       {
                       PRINT("REG 寫入程序沒有完成..");
                       CMDW_Action = false;
                       }
                }

            }

        private void rtfMessage_KeyPress(object sender , KeyPressEventArgs e)
            {
            //if (Convert.ToInt32(e.KeyChar) == 13)
                if (e.KeyChar  == '\r')
                {
               // rtfMessage.Text.TrimEnd('\r');
                //MessageBox.Show(" Enter pressed ");
                serialPort1.Write(txtCMDDATA.Text + " \r");
                txtCMDDATA.Text = "";

                rtfMessageReset();
                }
            else if (e.KeyChar == '.')
                {
                serialPort1.Write("." + " \r");
                }
            else if (e.KeyChar == ',')
                {
                serialPort1.Write("," + " \r");
                }
            else
                {
                txtCMDDATA.Text += e.KeyChar;
                }
            }

        private void btnClearMessage_Click(object sender , EventArgs e)
            {
            rtfMessage.Text = "";
            rtfMessage2.Text = "";
            }

        private void timer2_Tick(object sender , EventArgs e)
            {

             SendCMDtoPort(Commands.SendCMD);

            if ((chkRepeatCMD.Checked == true) && (cboSecond.SelectedIndex != 0))
                {
                timer2.Interval = (cboSecond.SelectedIndex * 1000);
                timer2.Enabled = true;
                btnSendCMD.Text = "停止";
                }
            }

        private void cboChipID_SelectedIndexChanged(object sender , EventArgs e)
            {
            if (cboChipID.SelectedIndex == 0)
                txtI2CAddr.Text = txtI2CAddr2.Text = "40";
            else if (cboChipID.SelectedIndex == 1)
                txtI2CAddr.Text = txtI2CAddr2.Text = "88";
            else if (cboChipID.SelectedIndex == 2)
                txtI2CAddr.Text = txtI2CAddr2.Text = "A0";
            else if (cboChipID.SelectedIndex == 3)
                txtI2CAddr.Text = txtI2CAddr2.Text = "12";

            }

        private void btnReadRegister_Click(object sender , EventArgs e)
            {
            txtReadREGData.Text = "?";
            txtWriteREGData.Text = "?"; 
            SendCMDtoPort(Commands.CMDR  );
            }

        private void btnWriteRegister_Click(object sender , EventArgs e)
            {
            //txtReadREGData.Text = "?";
            //txtWriteREGData.Text = "?";
            SendCMDtoPort(Commands.CMDW );
            }

        private void txtWriteREGData_KeyPress(object sender , KeyPressEventArgs e)
            {
            TextBox txtbox = (TextBox)sender;
            if (e.KeyChar == '\r')
                {
                if (txtbox.TextLength <= 1)
                    {
                    txtbox.Text = "0" + txtbox.Text;
                    }

                txtbox.Text = txtbox.Text.ToUpper();
                SendCMDtoPort(Commands.CMDW );
                }
            else if (e.KeyChar == '.')
                {
                if (Convert.ToInt32(txtbox.Text , 16) >= 0xFF)
                    {
                    txtbox.Text = "FF";
                    }
                else
                    {
                    //String.Format("{0:X}" , value);
                    txtbox.Text = String.Format("{0:X}" , Convert.ToInt32(txtbox.Text , 16) + 1);
                    }

                SendCMDtoPort(Commands.CMDW);
                }
            else if (e.KeyChar == ',')
                {
                if (Convert.ToInt32(txtbox.Text , 16) <= 0)
                    {
                    txtbox.Text = "00";
                    }
                else
                    {
                    //String.Format("{0:X}" , value);
                    txtbox.Text = String.Format("{0:X}" , Convert.ToInt32(txtbox.Text , 16) - 1);
                    }

                SendCMDtoPort(Commands.CMDW );
                }
            else if (e.KeyChar == '<')
                {
                if (Convert.ToInt32(txtbox.Text , 16) < 16)
                    {
                    txtbox.Text = "00";
                    }
                else
                    {
                    //String.Format("{0:X}" , value);
                    txtbox.Text = String.Format("{0:X}" , Convert.ToInt32(txtbox.Text , 16) - 16);
                    }

                SendCMDtoPort(Commands.CMDW);
                }
            else if (e.KeyChar == '>')
                {
                if (Convert.ToInt32(txtbox.Text , 16) >= (0xFF-16))
                    {
                    txtbox.Text = "FF";
                    }
                else
                    {
                    //String.Format("{0:X}" , value);
                    txtbox.Text = String.Format("{0:X}" , Convert.ToInt32(txtbox.Text , 16) + 16);
                    }

                SendCMDtoPort(Commands.CMDW);
                }
            //PRINT("e.KeyChar=" + e.KeyChar);

            }

        private void cboSecond_SelectedIndexChanged(object sender , EventArgs e)
            {
            if ((cboSecond.SelectedIndex == 0) && btnSendCMD.Text == "停止")
                {
                    timer2.Enabled = false;
                    btnSendCMD.Text = "傳送";
                    btnSendCMD.BackColor = Color.Empty;
                }
            }

        private void chkRepeatCMD_CheckedChanged(object sender , EventArgs e)
            {
            if ((chkRepeatCMD.Checked  == false) && btnSendCMD.Text == "停止")
                {
                timer2.Enabled = false;
                btnSendCMD.Text = "傳送";
                btnSendCMD.BackColor = Color.Empty;
                }
            }

        private void txtReadREGAddr_KeyPress(object sender , KeyPressEventArgs e)
            {
            TextBox txtbox = (TextBox)sender;

            if (e.KeyChar == '\r')
                {
                if (txtbox.TextLength <= 1)
                    {
                    txtbox.Text = "0" + txtbox.Text;
                    }
                txtbox.Text=txtbox.Text.ToUpper(); 
                SendCMDtoPort(Commands.CMDR);
                }
            }

        private void txtWriteREGAddr_KeyPress(object sender , KeyPressEventArgs e)
            {
            TextBox txtbox = (TextBox)sender;

            if (e.KeyChar == '\r')
                {
                if (txtbox.TextLength <= 1)
                    {
                    txtbox.Text = "0" + txtbox.Text;
                    }
                txtbox.Text = txtbox.Text.ToUpper();
              //  SendCMDtoPort(Commands.CMDW);
                }
            }

        private void txtREG00_MouseHover(object sender , EventArgs e)
            {
            TextBox txtbox = (TextBox)sender;
            lblColorChange(txtbox , true);
            txtbox.BackColor = Color.Yellow; 
            }

        private void txtREG00_MouseLeave(object sender , EventArgs e)
            {
            TextBox txtbox = (TextBox)sender;
            lblColorChange(txtbox , false);
            txtbox.BackColor = Color.Empty; 
            }

        private void lblColorChange(TextBox  txtbox, bool action)
            {
            string name="", namelist="";

            //Substring(rtfMessage2.Text.IndexOf("STX") + 5 , 2)
            //switch (txtbox.Name )
            namelist = txtbox.Name.Remove(0 , 7);
            switch (txtbox.Name.Remove(0,7)  )
                {
                    //水平先顯示
                case "0":
                         if (action)
                           lbl_REG00.BackColor = Color.Yellow;
                            else
                           lbl_REG00.BackColor = Color.Empty;
                        break;
                case "1":
                         if (action)
                           lbl_REG01.BackColor = Color.Yellow;
                            else
                           lbl_REG01.BackColor = Color.Empty;
                        break;
                case "2":
                        if (action)
                            lbl_REG02.BackColor = Color.Yellow;
                        else
                            lbl_REG02.BackColor = Color.Empty;
                        break;
                case "3":
                        if (action)
                            lbl_REG03.BackColor = Color.Yellow;
                        else
                            lbl_REG03.BackColor = Color.Empty;
                        break;
                case "4":
                        if (action)
                            lbl_REG04.BackColor = Color.Yellow;
                        else
                            lbl_REG04.BackColor = Color.Empty;
                        break;
                case "5":
                        if (action)
                            lbl_REG05.BackColor = Color.Yellow;
                        else
                            lbl_REG05.BackColor = Color.Empty;
                        break;
                case "6":
                        if (action)
                            lbl_REG06.BackColor = Color.Yellow;
                        else
                            lbl_REG06.BackColor = Color.Empty;
                        break;
                case "7":
                        if (action)
                            lbl_REG07.BackColor = Color.Yellow;
                        else
                            lbl_REG07.BackColor = Color.Empty;
                        break;
                case "8":
                        if (action)
                            lbl_REG08.BackColor = Color.Yellow;
                        else
                            lbl_REG08.BackColor = Color.Empty;
                        break;
                case "9":
                        if (action)
                            lbl_REG09.BackColor = Color.Yellow;
                        else
                            lbl_REG09.BackColor = Color.Empty;
                        break;
                case "A":
                        if (action)
                            lbl_REG0A.BackColor = Color.Yellow;
                        else
                            lbl_REG0A.BackColor = Color.Empty;
                        break;
                case "B":
                        if (action)
                            lbl_REG0B.BackColor = Color.Yellow;
                        else
                            lbl_REG0B.BackColor = Color.Empty;
                        break;
                case "C":
                        if (action)
                            lbl_REG0C.BackColor = Color.Yellow;
                        else
                            lbl_REG0C.BackColor = Color.Empty;
                        break;
                case "D":
                        if (action)
                            lbl_REG0D.BackColor = Color.Yellow;
                        else
                            lbl_REG0D.BackColor = Color.Empty;
                        break;
                case "E":
                        if (action)
                            lbl_REG0E.BackColor = Color.Yellow;
                        else
                            lbl_REG0E.BackColor = Color.Empty;
                        break;
                case "F":
                        if (action)
                            lbl_REG0F.BackColor = Color.Yellow;
                        else
                            lbl_REG0F.BackColor = Color.Empty;
                        break;          
                default:
                    break;
                }

            name = txtbox.Name.Remove(0 , 6);
            namelist = name.Remove(1 , 1) + namelist;

            switch (name.Remove(1 , 1))
                {
                //垂直顯示
                case "0":
                       if (action)
                            lbl_REG00_2.BackColor = Color.Yellow;
                        else
                            lbl_REG00_2.BackColor =  Color.Empty;
                        break;
                case "1":
                        if (action)
                            lbl_REG10.BackColor = Color.Yellow;
                        else
                            lbl_REG10.BackColor = Color.Empty;
                        break;
                case "2":
                        if (action)
                            lbl_REG20.BackColor = Color.Yellow;
                        else
                            lbl_REG20.BackColor = Color.Empty;
                        break;
                case "3":
                        if (action)
                            lbl_REG30.BackColor = Color.Yellow;
                        else
                            lbl_REG30.BackColor = Color.Empty;
                        break;
                case "4":
                        if (action)
                            lbl_REG40.BackColor = Color.Yellow;
                        else
                            lbl_REG40.BackColor = Color.Empty;
                        break;
                case "5":
                        if (action)
                            lbl_REG50.BackColor = Color.Yellow;
                        else
                            lbl_REG50.BackColor = Color.Empty;
                        break;
                case "6":
                        if (action)
                            lbl_REG60.BackColor = Color.Yellow;
                        else
                            lbl_REG60.BackColor = Color.Empty;
                        break;
                case "7":
                        if (action)
                            lbl_REG70.BackColor = Color.Yellow;
                        else
                            lbl_REG70.BackColor = Color.Empty;
                        break;
                case "8":
                        if (action)
                            lbl_REG80.BackColor = Color.Yellow;
                        else
                            lbl_REG80.BackColor = Color.Empty;
                        break;
                case "9":
                        if (action)
                            lbl_REG90.BackColor = Color.Yellow;
                        else
                            lbl_REG90.BackColor = Color.Empty;
                        break;
                case "A":
                        if (action)
                            lbl_REGA0.BackColor = Color.Yellow;
                        else
                            lbl_REGA0.BackColor = Color.Empty;
                        break;
                case "B":
                        if (action)
                            lbl_REGB0.BackColor = Color.Yellow;
                        else
                            lbl_REGB0.BackColor = Color.Empty;
                        break;
                case "C":
                        if (action)
                            lbl_REGC0.BackColor = Color.Yellow;
                        else
                            lbl_REGC0.BackColor = Color.Empty;
                        break;
                case "D":
                        if (action)
                            lbl_REGD0.BackColor = Color.Yellow;
                        else
                            lbl_REGD0.BackColor = Color.Empty;
                        break;
                case "E":
                        if (action)
                            lbl_REGE0.BackColor = Color.Yellow;
                        else
                            lbl_REGE0.BackColor = Color.Empty;
                        break;
                case "F":
                        if (action)
                            lbl_REGF0.BackColor = Color.Yellow;
                        else
                            lbl_REGF0.BackColor = Color.Empty;
                        break;

                default:
                    break;
                }
            if (action)
           lblREGAddr.Text = namelist;
            else
                lblREGAddr.Text = "";
            }

        private void btnREGReadALL_Click(object sender , EventArgs e)
            {
            DateTime localDate = DateTime.Now;

            rtfMessage.Text = "";
            CMDR_Action = true;
            Dump_Start = 0; //dump 開始位置
            txtReadREGAddr.Text = Convert.ToString(Dump_Start , 16).ToUpper();//轉成大寫16進位字串
              if(txtReadREGAddr.Text.Length==1)
                  txtReadREGAddr.Text = "0" + txtReadREGAddr.Text;
            Dump_End = 0xFF;   //dump 結束位置 
            Dump_Loop = Dump_Start;  //dump 開始迴圈

            REG_ALL_READY(Dump_Start , Dump_End, Color.GreenYellow );

            SendCMDtoPort(Commands.CMDR);
            //timer3.Interval = 5000; //dump處理程序預估5秒鐘
            //timer3.Enabled = true;
           // lblGetTime.Text = TimeOfDay.AddSeconds(10).ToString("hh:mm:ss");

         
           // lblTimeClock.Text = localDate.ToString();// DateTime.Now.ToString("HH:mm:ss");
            //dump處理程序預估15秒鐘
             lblGetTime.Text = localDate.AddSeconds(15).ToString("hh:mm:ss"); 

            }
        private void REG_ALL_READY(int start, int end ,Color index)
            {
            TextBox[] txtREG = new TextBox[] { 
     txtREG00, txtREG01, txtREG02, txtREG03, txtREG04, txtREG05, txtREG06, txtREG07, txtREG08, txtREG09, txtREG0A, txtREG0B, txtREG0C, txtREG0D, txtREG0E, txtREG0F,  
     txtREG10, txtREG11, txtREG12, txtREG13, txtREG14, txtREG15, txtREG16, txtREG17, txtREG18, txtREG19, txtREG1A, txtREG1B, txtREG1C, txtREG1D, txtREG1E, txtREG1F, 
     txtREG20, txtREG21, txtREG22, txtREG23, txtREG24, txtREG25, txtREG26, txtREG27, txtREG28, txtREG29, txtREG2A, txtREG2B, txtREG2C, txtREG2D, txtREG2E, txtREG2F, 
     txtREG30, txtREG31, txtREG32, txtREG33, txtREG34, txtREG35, txtREG36, txtREG37, txtREG38, txtREG39, txtREG3A, txtREG3B, txtREG3C, txtREG3D, txtREG3E, txtREG3F, 
     txtREG40, txtREG41, txtREG42, txtREG43, txtREG44, txtREG45, txtREG46, txtREG47, txtREG48, txtREG49, txtREG4A, txtREG4B, txtREG4C, txtREG4D, txtREG4E, txtREG4F, 
     txtREG50, txtREG51, txtREG52, txtREG53, txtREG54, txtREG55, txtREG56, txtREG57, txtREG58, txtREG59, txtREG5A, txtREG5B, txtREG5C, txtREG5D, txtREG5E, txtREG5F, 
     txtREG60, txtREG61, txtREG62, txtREG63, txtREG64, txtREG65, txtREG66, txtREG67, txtREG68, txtREG69, txtREG6A, txtREG6B, txtREG6C, txtREG6D, txtREG6E, txtREG6F, 
     txtREG70, txtREG71, txtREG72, txtREG73, txtREG74, txtREG75, txtREG76, txtREG77, txtREG78, txtREG79, txtREG7A, txtREG7B, txtREG7C, txtREG7D, txtREG7E, txtREG7F, 
     txtREG80, txtREG81, txtREG82, txtREG83, txtREG84, txtREG85, txtREG86, txtREG87, txtREG88, txtREG89, txtREG8A, txtREG8B, txtREG8C, txtREG8D, txtREG8E, txtREG8F, 
     txtREG90, txtREG91, txtREG92, txtREG93, txtREG94, txtREG95, txtREG96, txtREG97, txtREG98, txtREG99, txtREG9A, txtREG9B, txtREG9C, txtREG9D, txtREG9E, txtREG9F, 
     txtREGA0, txtREGA1, txtREGA2, txtREGA3, txtREGA4, txtREGA5, txtREGA6, txtREGA7, txtREGA8, txtREGA9, txtREGAA, txtREGAB, txtREGAC, txtREGAD, txtREGAE, txtREGAF, 
     txtREGB0, txtREGB1, txtREGB2, txtREGB3, txtREGB4, txtREGB5, txtREGB6, txtREGB7, txtREGB8, txtREGB9, txtREGBA, txtREGBB, txtREGBC, txtREGBD, txtREGBE, txtREGBF, 
     txtREGC0, txtREGC1, txtREGC2, txtREGC3, txtREGC4, txtREGC5, txtREGC6, txtREGC7, txtREGC8, txtREGC9, txtREGCA, txtREGCB, txtREGCC, txtREGCD, txtREGCE, txtREGCF, 
     txtREGD0, txtREGD1, txtREGD2, txtREGD3, txtREGD4, txtREGD5, txtREGD6, txtREGD7, txtREGD8, txtREGD9, txtREGDA, txtREGDB, txtREGDC, txtREGDD, txtREGDE, txtREGDF, 
     txtREGE0, txtREGE1, txtREGE2, txtREGE3, txtREGE4, txtREGE5, txtREGE6, txtREGE7, txtREGE8, txtREGE9, txtREGEA, txtREGEB, txtREGEC, txtREGED, txtREGEE, txtREGEF, 
     txtREGF0, txtREGF1, txtREGF2, txtREGF3, txtREGF4, txtREGF5, txtREGF6, txtREGF7, txtREGF8, txtREGF9, txtREGFA, txtREGFB, txtREGFC, txtREGFD, txtREGFE, txtREGFF};

            for (int i = start ; i <= end ; i++)
                {
                txtREG[i].BackColor = index; 
                }

            }

        private void timer3_Tick(object sender , EventArgs e)
            {
            timer3.Enabled = false;

            if (CMDR_Action == true)
                {
                PRINT("Dump處理程序沒有完成..");
                CMDR_Action = false;
                }
            }

        private void button1_Click(object sender , EventArgs e)
            {
            TextBox[] txtREG = new TextBox[] { 
     txtREG00, txtREG01, txtREG02, txtREG03, txtREG04, txtREG05, txtREG06, txtREG07, txtREG08, txtREG09, txtREG0A, txtREG0B, txtREG0C, txtREG0D, txtREG0E, txtREG0F,  
     txtREG10, txtREG11, txtREG12, txtREG13, txtREG14, txtREG15, txtREG16, txtREG17, txtREG18, txtREG19, txtREG1A, txtREG1B, txtREG1C, txtREG1D, txtREG1E, txtREG1F, 
     txtREG20, txtREG21, txtREG22, txtREG23, txtREG24, txtREG25, txtREG26, txtREG27, txtREG28, txtREG29, txtREG2A, txtREG2B, txtREG2C, txtREG2D, txtREG2E, txtREG2F, 
     txtREG30, txtREG31, txtREG32, txtREG33, txtREG34, txtREG35, txtREG36, txtREG37, txtREG38, txtREG39, txtREG3A, txtREG3B, txtREG3C, txtREG3D, txtREG3E, txtREG3F, 
     txtREG40, txtREG41, txtREG42, txtREG43, txtREG44, txtREG45, txtREG46, txtREG47, txtREG48, txtREG49, txtREG4A, txtREG4B, txtREG4C, txtREG4D, txtREG4E, txtREG4F, 
     txtREG50, txtREG51, txtREG52, txtREG53, txtREG54, txtREG55, txtREG56, txtREG57, txtREG58, txtREG59, txtREG5A, txtREG5B, txtREG5C, txtREG5D, txtREG5E, txtREG5F, 
     txtREG60, txtREG61, txtREG62, txtREG63, txtREG64, txtREG65, txtREG66, txtREG67, txtREG68, txtREG69, txtREG6A, txtREG6B, txtREG6C, txtREG6D, txtREG6E, txtREG6F, 
     txtREG70, txtREG71, txtREG72, txtREG73, txtREG74, txtREG75, txtREG76, txtREG77, txtREG78, txtREG79, txtREG7A, txtREG7B, txtREG7C, txtREG7D, txtREG7E, txtREG7F, 
     txtREG80, txtREG81, txtREG82, txtREG83, txtREG84, txtREG85, txtREG86, txtREG87, txtREG88, txtREG89, txtREG8A, txtREG8B, txtREG8C, txtREG8D, txtREG8E, txtREG8F, 
     txtREG90, txtREG91, txtREG92, txtREG93, txtREG94, txtREG95, txtREG96, txtREG97, txtREG98, txtREG99, txtREG9A, txtREG9B, txtREG9C, txtREG9D, txtREG9E, txtREG9F, 
     txtREGA0, txtREGA1, txtREGA2, txtREGA3, txtREGA4, txtREGA5, txtREGA6, txtREGA7, txtREGA8, txtREGA9, txtREGAA, txtREGAB, txtREGAC, txtREGAD, txtREGAE, txtREGAF, 
     txtREGB0, txtREGB1, txtREGB2, txtREGB3, txtREGB4, txtREGB5, txtREGB6, txtREGB7, txtREGB8, txtREGB9, txtREGBA, txtREGBB, txtREGBC, txtREGBD, txtREGBE, txtREGBF, 
     txtREGC0, txtREGC1, txtREGC2, txtREGC3, txtREGC4, txtREGC5, txtREGC6, txtREGC7, txtREGC8, txtREGC9, txtREGCA, txtREGCB, txtREGCC, txtREGCD, txtREGCE, txtREGCF, 
     txtREGD0, txtREGD1, txtREGD2, txtREGD3, txtREGD4, txtREGD5, txtREGD6, txtREGD7, txtREGD8, txtREGD9, txtREGDA, txtREGDB, txtREGDC, txtREGDD, txtREGDE, txtREGDF, 
     txtREGE0, txtREGE1, txtREGE2, txtREGE3, txtREGE4, txtREGE5, txtREGE6, txtREGE7, txtREGE8, txtREGE9, txtREGEA, txtREGEB, txtREGEC, txtREGED, txtREGEE, txtREGEF, 
     txtREGF0, txtREGF1, txtREGF2, txtREGF3, txtREGF4, txtREGF5, txtREGF6, txtREGF7, txtREGF8, txtREGF9, txtREGFA, txtREGFB, txtREGFC, txtREGFD, txtREGFE, txtREGFF};
            for (int i = 0 ; i <= 255 ; i++)
                {
                txtREG[i].Text = "00";
                txtREG[i].ForeColor = Color.Empty;
                }
            }

        private void btnSaveFile_Click(object sender , EventArgs e)
            {
            TextBox[] txtREG = new TextBox[] { 
     txtREG00, txtREG01, txtREG02, txtREG03, txtREG04, txtREG05, txtREG06, txtREG07, txtREG08, txtREG09, txtREG0A, txtREG0B, txtREG0C, txtREG0D, txtREG0E, txtREG0F,  
     txtREG10, txtREG11, txtREG12, txtREG13, txtREG14, txtREG15, txtREG16, txtREG17, txtREG18, txtREG19, txtREG1A, txtREG1B, txtREG1C, txtREG1D, txtREG1E, txtREG1F, 
     txtREG20, txtREG21, txtREG22, txtREG23, txtREG24, txtREG25, txtREG26, txtREG27, txtREG28, txtREG29, txtREG2A, txtREG2B, txtREG2C, txtREG2D, txtREG2E, txtREG2F, 
     txtREG30, txtREG31, txtREG32, txtREG33, txtREG34, txtREG35, txtREG36, txtREG37, txtREG38, txtREG39, txtREG3A, txtREG3B, txtREG3C, txtREG3D, txtREG3E, txtREG3F, 
     txtREG40, txtREG41, txtREG42, txtREG43, txtREG44, txtREG45, txtREG46, txtREG47, txtREG48, txtREG49, txtREG4A, txtREG4B, txtREG4C, txtREG4D, txtREG4E, txtREG4F, 
     txtREG50, txtREG51, txtREG52, txtREG53, txtREG54, txtREG55, txtREG56, txtREG57, txtREG58, txtREG59, txtREG5A, txtREG5B, txtREG5C, txtREG5D, txtREG5E, txtREG5F, 
     txtREG60, txtREG61, txtREG62, txtREG63, txtREG64, txtREG65, txtREG66, txtREG67, txtREG68, txtREG69, txtREG6A, txtREG6B, txtREG6C, txtREG6D, txtREG6E, txtREG6F, 
     txtREG70, txtREG71, txtREG72, txtREG73, txtREG74, txtREG75, txtREG76, txtREG77, txtREG78, txtREG79, txtREG7A, txtREG7B, txtREG7C, txtREG7D, txtREG7E, txtREG7F, 
     txtREG80, txtREG81, txtREG82, txtREG83, txtREG84, txtREG85, txtREG86, txtREG87, txtREG88, txtREG89, txtREG8A, txtREG8B, txtREG8C, txtREG8D, txtREG8E, txtREG8F, 
     txtREG90, txtREG91, txtREG92, txtREG93, txtREG94, txtREG95, txtREG96, txtREG97, txtREG98, txtREG99, txtREG9A, txtREG9B, txtREG9C, txtREG9D, txtREG9E, txtREG9F, 
     txtREGA0, txtREGA1, txtREGA2, txtREGA3, txtREGA4, txtREGA5, txtREGA6, txtREGA7, txtREGA8, txtREGA9, txtREGAA, txtREGAB, txtREGAC, txtREGAD, txtREGAE, txtREGAF, 
     txtREGB0, txtREGB1, txtREGB2, txtREGB3, txtREGB4, txtREGB5, txtREGB6, txtREGB7, txtREGB8, txtREGB9, txtREGBA, txtREGBB, txtREGBC, txtREGBD, txtREGBE, txtREGBF, 
     txtREGC0, txtREGC1, txtREGC2, txtREGC3, txtREGC4, txtREGC5, txtREGC6, txtREGC7, txtREGC8, txtREGC9, txtREGCA, txtREGCB, txtREGCC, txtREGCD, txtREGCE, txtREGCF, 
     txtREGD0, txtREGD1, txtREGD2, txtREGD3, txtREGD4, txtREGD5, txtREGD6, txtREGD7, txtREGD8, txtREGD9, txtREGDA, txtREGDB, txtREGDC, txtREGDD, txtREGDE, txtREGDF, 
     txtREGE0, txtREGE1, txtREGE2, txtREGE3, txtREGE4, txtREGE5, txtREGE6, txtREGE7, txtREGE8, txtREGE9, txtREGEA, txtREGEB, txtREGEC, txtREGED, txtREGEE, txtREGEF, 
     txtREGF0, txtREGF1, txtREGF2, txtREGF3, txtREGF4, txtREGF5, txtREGF6, txtREGF7, txtREGF8, txtREGF9, txtREGFA, txtREGFB, txtREGFC, txtREGFD, txtREGFE, txtREGFF};

            DateTime localDate = DateTime.Now;
            string AddrTemp = "";
            string path = System.Windows.Forms.Application.StartupPath + "/dump.txt";
            //FileStream fs = new FileStream(path  , FileMode.Create);
            ////獲得位元組陣列
            //byte[] data = System.Text.Encoding.Default.GetBytes("Hello World!");
            ////開始寫入
            //fs.Write(data , 0 , data.Length);

            //if (serialPort1.IsOpen == true)
            //    {
            //    fs.Write(serialPort1.na );
            //    }

            ////清空緩衝區、關閉流
            //fs.Flush();
            //fs.Close();

            FileStream fs = new FileStream(path , FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            //開始寫入
            sw.Write(localDate.ToString() + "\r");

            for (int i = 0 ; i <= 255 ; i++)
                {
                AddrTemp = Convert.ToString(i , 16).ToUpper();
                if (AddrTemp.Length == 1)
                    AddrTemp = "0" + AddrTemp;
                sw.Write(txtI2CAddr.Text + "," + AddrTemp + "," + txtREG[i].Text + "\r");
                }

            //    if (serialPort1.IsOpen == true)
            //        sw.Write(serialPort1.PortName + "\r");

            //if (chkRepeatCMD.Checked == true)
            //    sw.Write("chkRepeatCMD.Checked=true" + "\r");


            //清空緩衝區
            sw.Flush();
            //關閉流
            sw.Close();
            fs.Close();

            //saveFileDialog1.AddExtension = true;
            //saveFileDialog1.InitialDirectory = Path.GetDirectoryName(strPartPath);

            saveFileDialog1.Filter = "文字檔(*.txt)|*.txt|所有文件|*.*"; //存檔類型
            saveFileDialog1.Title = "暫存器資料另存新檔";//標題

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                string fileName = saveFileDialog1.FileName;

                // string pathFile = "c://ere.txt"; //指定文件

                File.Copy(path , fileName , true); //複製

                toolStripStatusLabel1.Text = fileName;

                MessageBox.Show("存檔成功!");

                }

            else
                {

                MessageBox.Show("存檔取消!");

                }

            //MessageBox.Show("存檔完畢");
            }

        private void btnOpenFile_Click(object sender , EventArgs e)
            {

            TextBox[] txtREG = new TextBox[] { 
     txtREG00, txtREG01, txtREG02, txtREG03, txtREG04, txtREG05, txtREG06, txtREG07, txtREG08, txtREG09, txtREG0A, txtREG0B, txtREG0C, txtREG0D, txtREG0E, txtREG0F,  
     txtREG10, txtREG11, txtREG12, txtREG13, txtREG14, txtREG15, txtREG16, txtREG17, txtREG18, txtREG19, txtREG1A, txtREG1B, txtREG1C, txtREG1D, txtREG1E, txtREG1F, 
     txtREG20, txtREG21, txtREG22, txtREG23, txtREG24, txtREG25, txtREG26, txtREG27, txtREG28, txtREG29, txtREG2A, txtREG2B, txtREG2C, txtREG2D, txtREG2E, txtREG2F, 
     txtREG30, txtREG31, txtREG32, txtREG33, txtREG34, txtREG35, txtREG36, txtREG37, txtREG38, txtREG39, txtREG3A, txtREG3B, txtREG3C, txtREG3D, txtREG3E, txtREG3F, 
     txtREG40, txtREG41, txtREG42, txtREG43, txtREG44, txtREG45, txtREG46, txtREG47, txtREG48, txtREG49, txtREG4A, txtREG4B, txtREG4C, txtREG4D, txtREG4E, txtREG4F, 
     txtREG50, txtREG51, txtREG52, txtREG53, txtREG54, txtREG55, txtREG56, txtREG57, txtREG58, txtREG59, txtREG5A, txtREG5B, txtREG5C, txtREG5D, txtREG5E, txtREG5F, 
     txtREG60, txtREG61, txtREG62, txtREG63, txtREG64, txtREG65, txtREG66, txtREG67, txtREG68, txtREG69, txtREG6A, txtREG6B, txtREG6C, txtREG6D, txtREG6E, txtREG6F, 
     txtREG70, txtREG71, txtREG72, txtREG73, txtREG74, txtREG75, txtREG76, txtREG77, txtREG78, txtREG79, txtREG7A, txtREG7B, txtREG7C, txtREG7D, txtREG7E, txtREG7F, 
     txtREG80, txtREG81, txtREG82, txtREG83, txtREG84, txtREG85, txtREG86, txtREG87, txtREG88, txtREG89, txtREG8A, txtREG8B, txtREG8C, txtREG8D, txtREG8E, txtREG8F, 
     txtREG90, txtREG91, txtREG92, txtREG93, txtREG94, txtREG95, txtREG96, txtREG97, txtREG98, txtREG99, txtREG9A, txtREG9B, txtREG9C, txtREG9D, txtREG9E, txtREG9F, 
     txtREGA0, txtREGA1, txtREGA2, txtREGA3, txtREGA4, txtREGA5, txtREGA6, txtREGA7, txtREGA8, txtREGA9, txtREGAA, txtREGAB, txtREGAC, txtREGAD, txtREGAE, txtREGAF, 
     txtREGB0, txtREGB1, txtREGB2, txtREGB3, txtREGB4, txtREGB5, txtREGB6, txtREGB7, txtREGB8, txtREGB9, txtREGBA, txtREGBB, txtREGBC, txtREGBD, txtREGBE, txtREGBF, 
     txtREGC0, txtREGC1, txtREGC2, txtREGC3, txtREGC4, txtREGC5, txtREGC6, txtREGC7, txtREGC8, txtREGC9, txtREGCA, txtREGCB, txtREGCC, txtREGCD, txtREGCE, txtREGCF, 
     txtREGD0, txtREGD1, txtREGD2, txtREGD3, txtREGD4, txtREGD5, txtREGD6, txtREGD7, txtREGD8, txtREGD9, txtREGDA, txtREGDB, txtREGDC, txtREGDD, txtREGDE, txtREGDF, 
     txtREGE0, txtREGE1, txtREGE2, txtREGE3, txtREGE4, txtREGE5, txtREGE6, txtREGE7, txtREGE8, txtREGE9, txtREGEA, txtREGEB, txtREGEC, txtREGED, txtREGEE, txtREGEF, 
     txtREGF0, txtREGF1, txtREGF2, txtREGF3, txtREGF4, txtREGF5, txtREGF6, txtREGF7, txtREGF8, txtREGF9, txtREGFA, txtREGFB, txtREGFC, txtREGFD, txtREGFE, txtREGFF};

            openFileDialog1.Title = "檔案開啟";
            openFileDialog1.InitialDirectory = System.Windows.Forms.Application.StartupPath  ;
            openFileDialog1.Filter = "文字檔案(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                string str = "";
                FileInfo f = new FileInfo(openFileDialog1.FileName);
                StreamReader sr = f.OpenText();
                while (sr.Peek() >= 0)
                    {
                   // txtReadREGData.Text = rtfMessage2.Text.Substring(rtfMessage2.Text.IndexOf("STX") + 5 , 2);
                    str = sr.ReadLine();
                    //(str.Contains("COM")
                    //Convert.ToInt32("aa", 16)
                    if (str.Contains(txtI2CAddr.Text)==true )
                        {
                      //txtREG[Int32.Parse(str.Substring(3, 2) , System.Globalization.NumberStyles.HexNumber)].Text = str.Substring(str.IndexOf(txtI2CAddr.Text) + 7 , 2);
                        if (txtREG[Convert.ToInt32(str.Substring(3 , 2) , 16)].Text != str.Substring(6 , 2))
                            {
                            txtREG[Convert.ToInt32(str.Substring(3 , 2) , 16)].ForeColor = Color.Red;
                            txtREG[Convert.ToInt32(str.Substring(3 , 2) , 16)].Text = str.Substring(6 , 2);
                            }
                        }
                   // PRINT(str);
             
                  

                    }

                toolStripStatusLabel1.Text = openFileDialog1.FileName;

                sr.Close();

                MessageBox.Show("檔案開啟成功!");
                }
            else
                {
                MessageBox.Show("檔案開啟失敗!");
                }

            }

        private void btnREGWriteALL_Click(object sender , EventArgs e)
            {
        TextBox[] txtREG = new TextBox[] { 
     txtREG00, txtREG01, txtREG02, txtREG03, txtREG04, txtREG05, txtREG06, txtREG07, txtREG08, txtREG09, txtREG0A, txtREG0B, txtREG0C, txtREG0D, txtREG0E, txtREG0F,  
     txtREG10, txtREG11, txtREG12, txtREG13, txtREG14, txtREG15, txtREG16, txtREG17, txtREG18, txtREG19, txtREG1A, txtREG1B, txtREG1C, txtREG1D, txtREG1E, txtREG1F, 
     txtREG20, txtREG21, txtREG22, txtREG23, txtREG24, txtREG25, txtREG26, txtREG27, txtREG28, txtREG29, txtREG2A, txtREG2B, txtREG2C, txtREG2D, txtREG2E, txtREG2F, 
     txtREG30, txtREG31, txtREG32, txtREG33, txtREG34, txtREG35, txtREG36, txtREG37, txtREG38, txtREG39, txtREG3A, txtREG3B, txtREG3C, txtREG3D, txtREG3E, txtREG3F, 
     txtREG40, txtREG41, txtREG42, txtREG43, txtREG44, txtREG45, txtREG46, txtREG47, txtREG48, txtREG49, txtREG4A, txtREG4B, txtREG4C, txtREG4D, txtREG4E, txtREG4F, 
     txtREG50, txtREG51, txtREG52, txtREG53, txtREG54, txtREG55, txtREG56, txtREG57, txtREG58, txtREG59, txtREG5A, txtREG5B, txtREG5C, txtREG5D, txtREG5E, txtREG5F, 
     txtREG60, txtREG61, txtREG62, txtREG63, txtREG64, txtREG65, txtREG66, txtREG67, txtREG68, txtREG69, txtREG6A, txtREG6B, txtREG6C, txtREG6D, txtREG6E, txtREG6F, 
     txtREG70, txtREG71, txtREG72, txtREG73, txtREG74, txtREG75, txtREG76, txtREG77, txtREG78, txtREG79, txtREG7A, txtREG7B, txtREG7C, txtREG7D, txtREG7E, txtREG7F, 
     txtREG80, txtREG81, txtREG82, txtREG83, txtREG84, txtREG85, txtREG86, txtREG87, txtREG88, txtREG89, txtREG8A, txtREG8B, txtREG8C, txtREG8D, txtREG8E, txtREG8F, 
     txtREG90, txtREG91, txtREG92, txtREG93, txtREG94, txtREG95, txtREG96, txtREG97, txtREG98, txtREG99, txtREG9A, txtREG9B, txtREG9C, txtREG9D, txtREG9E, txtREG9F, 
     txtREGA0, txtREGA1, txtREGA2, txtREGA3, txtREGA4, txtREGA5, txtREGA6, txtREGA7, txtREGA8, txtREGA9, txtREGAA, txtREGAB, txtREGAC, txtREGAD, txtREGAE, txtREGAF, 
     txtREGB0, txtREGB1, txtREGB2, txtREGB3, txtREGB4, txtREGB5, txtREGB6, txtREGB7, txtREGB8, txtREGB9, txtREGBA, txtREGBB, txtREGBC, txtREGBD, txtREGBE, txtREGBF, 
     txtREGC0, txtREGC1, txtREGC2, txtREGC3, txtREGC4, txtREGC5, txtREGC6, txtREGC7, txtREGC8, txtREGC9, txtREGCA, txtREGCB, txtREGCC, txtREGCD, txtREGCE, txtREGCF, 
     txtREGD0, txtREGD1, txtREGD2, txtREGD3, txtREGD4, txtREGD5, txtREGD6, txtREGD7, txtREGD8, txtREGD9, txtREGDA, txtREGDB, txtREGDC, txtREGDD, txtREGDE, txtREGDF, 
     txtREGE0, txtREGE1, txtREGE2, txtREGE3, txtREGE4, txtREGE5, txtREGE6, txtREGE7, txtREGE8, txtREGE9, txtREGEA, txtREGEB, txtREGEC, txtREGED, txtREGEE, txtREGEF, 
     txtREGF0, txtREGF1, txtREGF2, txtREGF3, txtREGF4, txtREGF5, txtREGF6, txtREGF7, txtREGF8, txtREGF9, txtREGFA, txtREGFB, txtREGFC, txtREGFD, txtREGFE, txtREGFF};
  
            DateTime localDate = DateTime.Now;

            CMDW_Action = true ;
            WriteREGALL_Start = 0;
            WriteREGALL_End = 0xFF;         
            WriteREGALL_Loop = WriteREGALL_Start;
            rtfMessage.Text = "";
   
            //Dump_Start = 0; //dump 開始位置
            txtWriteREGAddr.Text = Convert.ToString(WriteREGALL_Start , 16).ToUpper();//轉成大寫16進位字串
            txtWriteREGData.Text = txtREG[WriteREGALL_Start].Text ;

            if (txtWriteREGAddr.Text.Length == 1)
                txtWriteREGAddr.Text = "0" + txtWriteREGAddr.Text;
            //Dump_End = 0xFF;   //dump 結束位置 
            //Dump_Loop = Dump_Start;  //dump 開始迴圈

            lblGetTime.Text = localDate.AddSeconds(15).ToString("hh:mm:ss");
            REG_ALL_READY(WriteREGALL_Start , WriteREGALL_End , Color.LightBlue  );

            SendCMDtoPort(Commands.CMDW);
            //timer3.Interval = 5000; //dump處理程序預估5秒鐘
            //timer3.Enabled = true;
            // lblGetTime.Text = TimeOfDay.AddSeconds(10).ToString("hh:mm:ss");


            // lblTimeClock.Text = localDate.ToString();// DateTime.Now.ToString("HH:mm:ss");
            //dump處理程序預估15秒鐘
    

            }

 

        
    }
}
