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
                        txtWriteREGAddr.Text = txtReadREGAddr.Text;
                        txtWriteREGData.Text = txtReadREGData.Text;
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
                rtfMessage.AppendText(str + "\n");
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

            if (timer2.Enabled == true)
                {
                if (btnSendCMD.BackColor == Color.Red)
                    btnSendCMD.BackColor = Color.Empty;
                else
                    btnSendCMD.BackColor = Color.Red;
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
                txtI2CAddr.Text = "40";
            else if (cboChipID.SelectedIndex == 1)
                txtI2CAddr.Text = "88";
            else if (cboChipID.SelectedIndex == 2)
                txtI2CAddr.Text = "A0";
            else if (cboChipID.SelectedIndex == 3)
                txtI2CAddr.Text = "12";

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
            }

        private void txtREG00_MouseLeave(object sender , EventArgs e)
            {
            TextBox txtbox = (TextBox)sender;
            lblColorChange(txtbox , false);
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

      


      






        
    }
}
