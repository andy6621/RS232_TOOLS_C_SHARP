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
    public partial class Form1 : Form
    {

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
            if (this.txtReceiveData.InvokeRequired)
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
                            if ( (char ) ReadData[i] == '\n' )//取消換行
                            {
                            //txtReceiveData.Text += (char) ReadData[i];
                            }
                            else
                            {
                                txtReceiveData.Text += (char) ReadData[i];
                            }
                        }

                    }
               
                }
                catch (Exception )//ex //As Exception
                {
                    //MessageBox.Show("霈?隤歹?" + e.ToString(),
                    //                "RS485?航炊?",
                    //                MessageBoxButtons.OK,
                    //                MessageBoxIcon.Exclamation,
                    //                MessageBoxDefaultButton.Button1);
                }
                //txtReceiveHEX.SelectionStart = txtReceiveHEX.Text.Length;
                //txtReceiveASCII.SelectionStart = txtReceiveASCII.Text.Length;
                //txtReceiveHEX.ScrollToCaret();
                //txtReceiveASCII.ScrollToCaret();
                txtReceiveData.SelectionStart = txtReceiveData.Text.Length;
                txtReceiveData.ScrollToCaret();


            }
        }
        private void txtReceiveDataReset()
            {
            txtReceiveData.SelectionStart = txtReceiveData.Text.Length;
            txtReceiveData.ScrollToCaret();
            }

        private void Form1_Load(object sender, EventArgs e)
        {

            string[] ports = SerialPort.GetPortNames();

            DateTime localDate = DateTime.Now;
            TimeClock.Text = localDate.ToString();

            foreach (string port in ports)
            {
               comboBox1.Items.Add(port); 
            }

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            //StartUp();
        }

       
        private void StartUp()
         {
         string path = System.Windows.Forms.Application.StartupPath + "/rs232.ini";
         StreamReader sr = new StreamReader(path , Encoding.Default);
         String line;
         while ((line = sr.ReadLine()) != null)
             {
             //Console.WriteLine(line.ToString());
             PRINT (line.ToString());
             }
      
    
         }

        private void button3_Click(object sender, EventArgs e)
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
            {
            sw.Write(serialPort1.PortName + "\r");
            }

        //清空緩衝區
        sw.Flush();
        //關閉流
        sw.Close();
        fs.Close();

        serialPort1.Dispose();
        this.Close();
        }

        void PRINT(string str)
        {

            try
            {
                txtReceiveData.AppendText(str + "\n");
            }
            catch (Exception)
            {
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                //波特率
                serialPort1.BaudRate = 115200;
                //資料位
                serialPort1.DataBits = 8;
                serialPort1.PortName = comboBox1.Text;              
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
                  //  txtReceiveData.AppendText("埠" + comboBox1.Text + "開啟成功\r\n");
                }
                
                //serialPort1.DataReceived += serialPort1_DataReceived;

                groupBox1.Enabled = true;
                button1.Enabled = false;
                comboBox1.Enabled = false;
                button2.Enabled = true;
            }
            catch (Exception )
            {
                serialPort1.Dispose();
                //txtReceiveData.AppendText(ex.Message);
                MessageBox.Show(serialPort1.PortName + "埠開啟失敗");
            }
        }

  
        private void button2_Click(object sender, EventArgs e)
        {

            groupBox1.Enabled = false;

            try
            {
                serialPort1.Dispose();

            }
            catch (Exception)
            {
                ////MessageBox.Show("COM PORT 沒有開啟");
                //txtReceiveData.AppendText("COM PORT 沒有開啟\r\n");
            }

            txtReceiveData.Text = "";
            button1.Enabled = true;
            button2.Enabled = false;
            comboBox1.Enabled = true;
            //comboBox2.Enabled = false;
       }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.Write(textBox1.Text + " \r" );
            txtReceiveData.Text = "";   
        }

        private void timer1_Tick(object sender , EventArgs e)
            {
            DateTime localDate = DateTime.Now;
            TimeClock.Text = localDate.ToString();// DateTime.Now.ToString("HH:mm:ss");
            }

        private void txtReceiveData_KeyPress(object sender , KeyPressEventArgs e)
            {
            if (Convert.ToInt32(e.KeyChar) == 13)
                {
                //MessageBox.Show(" Enter pressed ");
                serialPort1.Write(textBox1.Text + " \r");
                textBox1.Text = "";

                txtReceiveDataReset();
                }
            else
                {
                textBox1.Text += e.KeyChar;         
                }
            }

    
       

              
    }
}
