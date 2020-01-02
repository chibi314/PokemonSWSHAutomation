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
using System.Threading;

namespace PokemonAutomation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort.BaudRate = 115200;
            serialPort.Parity = Parity.None;
            serialPort.DataBits = 8;
            serialPort.StopBits = StopBits.One;
            serialPort.PortName = "COM7";
            serialPort.DtrEnable = true;
            serialPort.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("A");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = serialPort.ReadExisting();	// ポートから文字列を受信する
                if (!string.IsNullOrEmpty(data))
                {
                    Invoke((MethodInvoker)(() =>	// 受信用スレッドから切り替えてデータを書き込む
                    {
                        textBox1.Text = data;	// ラベルを受信した文字列へ変更
                        Thread.Sleep(1);
                    }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
