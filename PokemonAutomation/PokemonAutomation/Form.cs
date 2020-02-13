using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace PokemonAutomation
{
    public partial class PokemonAutomation : Form
    {
        enum ButtonType : byte
        {
            RIGHT = 0,
            LEFT,
            UP,
            DOWN,
            A,
            B,
            X,
            Y,
            R,
            L,
            ZR,
            ZL,
            RSTICK,
            LSTICK,
            RCLICK,
            LCLICK,
            HOME,
            CAPTURE,
            PLUS,
            MINUS
        }

        enum ButtonState : byte
        {
            PRESS = 0,
            RELEASE
        }

        enum Stick : byte
        {
            MIN = 0,
            CENTER = 128,
            MAX = 255
        }

        private CancellationTokenSource token_source;
        private CancellationToken cancel_token;
        private uint day_count;
        private DateTime current_date;


        public PokemonAutomation()
        {
            InitializeComponent();
        }

        private void getSerialPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            comPortComboBox.Items.Clear();
            foreach (string port in ports)
            {
                comPortComboBox.Items.Add(port);
            }
            if (comPortComboBox.Items.Count > 0)
            {
                comPortComboBox.SelectedIndex = 0;
            }
        }

        private delegate void delegateUpdateDateLabel();

        private void updateDateLabel()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new delegateUpdateDateLabel(this.updateDateLabel));
                return;
            }
            LabelDate.Text = "Date: " + current_date.ToString("yyyy/MM/dd");
        }

        private delegate void delegateUpdateCountLabel(int count, int max);

        private void updateCountLabel(int count, int max)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new delegateUpdateCountLabel(this.updateCountLabel), count, max);
                return;
            }
            CountLabel.Text = "count: " + count.ToString() + "/" + max.ToString();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            getSerialPorts();
            YearComboBox.SelectedIndex = 0;
            MonthComboBox.SelectedIndex = 0;
            DayComboBox.SelectedIndex = 0;

            updateDateLabel();
        }

        private void comPortComboBox_Click(object sender, EventArgs e)
        {
            getSerialPorts();
        }

        private void connectSerial()
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
            serialPort.BaudRate = 115200;
            serialPort.Parity = Parity.None;
            serialPort.DataBits = 8;
            serialPort.StopBits = StopBits.One;
            serialPort.PortName = comPortComboBox.Text;
            serialPort.Open();
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                
                //int data_len = serialPort.BytesToRead;
                //Byte[] data = new Byte[data_len];
                //serialPort.Read(data, 0, data_len);
                
                String data = serialPort.ReadExisting();

                Invoke((MethodInvoker)(() =>	// 受信用スレッドから切り替えてデータを書き込む
                {
                    Console.Write(data);
                    Thread.Sleep(1);
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comPortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            connectSerial();
        }

        private void pressButton(ButtonType button)
        {
            if (serialPort.IsOpen)
            {
                Byte[] data = new byte[2];
                data[0] = (Byte)button;
                data[1] = (Byte)ButtonState.PRESS;

                serialPort.Write(data, 0, 2);
            }
        }

        private void releaseButton(ButtonType button)
        {
            if (serialPort.IsOpen)
            {
                Byte[] data = new byte[2];
                data[0] = (Byte)button;
                data[1] = (Byte)ButtonState.RELEASE;

                serialPort.Write(data, 0, 2);
            }
        }

        private void left_MouseDown(object sender, MouseEventArgs e)
        {
            pressButton(ButtonType.LEFT);
        }

        private void left_MouseUp(object sender, MouseEventArgs e)
        {
            releaseButton(ButtonType.LEFT);
        }

        private void right_MouseDown(object sender, MouseEventArgs e)
        {
            pressButton(ButtonType.RIGHT);
        }

        private void right_MouseUp(object sender, MouseEventArgs e)
        {
            releaseButton(ButtonType.RIGHT);
        }

        private void up_MouseDown(object sender, MouseEventArgs e)
        {
            pressButton(ButtonType.UP);
        }

        private void up_MouseUp(object sender, MouseEventArgs e)
        {
            releaseButton(ButtonType.UP);
        }

        private void down_MouseDown(object sender, MouseEventArgs e)
        {
            pressButton(ButtonType.DOWN);
        }

        private void down_MouseUp(object sender, MouseEventArgs e)
        {
            releaseButton(ButtonType.DOWN);
        }

        private void ButtonA_MouseDown(object sender, MouseEventArgs e)
        {
            pressButton(ButtonType.A);
        }

        private void ButtonA_MouseUp(object sender, MouseEventArgs e)
        {
            releaseButton(ButtonType.A);
        }

        private void ButtonB_MouseDown(object sender, MouseEventArgs e)
        {
            pressButton(ButtonType.B);
        }

        private void ButtonB_MouseUp(object sender, MouseEventArgs e)
        {
            releaseButton(ButtonType.B);
        }

        private void ButtonY_MouseDown(object sender, MouseEventArgs e)
        {
            pressButton(ButtonType.Y);
        }

        private void ButtonY_MouseUp(object sender, MouseEventArgs e)
        {
            releaseButton(ButtonType.Y);
        }

        private void ButtonX_MouseDown(object sender, MouseEventArgs e)
        {
            pressButton(ButtonType.X);
        }

        private void ButtonX_MouseUp(object sender, MouseEventArgs e)
        {
            releaseButton(ButtonType.X);
        }

        private void ButtonZR_MouseDown(object sender, MouseEventArgs e)
        {
            pressButton(ButtonType.ZR);
        }

        private void ButtonZR_MouseUp(object sender, MouseEventArgs e)
        {
            releaseButton(ButtonType.ZR);
        }

        private void ButtonZL_MouseDown(object sender, MouseEventArgs e)
        {
            pressButton(ButtonType.ZL);
        }

        private void ButtonZL_MouseUp(object sender, MouseEventArgs e)
        {
            releaseButton(ButtonType.ZL);
        }

        private void ButtonR_MouseDown(object sender, MouseEventArgs e)
        {
            pressButton(ButtonType.R);
        }

        private void ButtonR_MouseUp(object sender, MouseEventArgs e)
        {
            releaseButton(ButtonType.R);
        }

        private void ButtonL_MouseDown(object sender, MouseEventArgs e)
        {
            pressButton(ButtonType.L);
        }

        private void ButtonL_MouseUp(object sender, MouseEventArgs e)
        {
            releaseButton(ButtonType.L);
        }

        private void ButtonPlus_MouseDown(object sender, MouseEventArgs e)
        {
            pressButton(ButtonType.PLUS);
        }

        private void ButtonPlus_MouseUp(object sender, MouseEventArgs e)
        {
            releaseButton(ButtonType.PLUS);
        }

        private void ButtonMinus_MouseDown(object sender, MouseEventArgs e)
        {
            pressButton(ButtonType.MINUS);
        }

        private void ButtonMinus_MouseUp(object sender, MouseEventArgs e)
        {
            releaseButton(ButtonType.MINUS);
        }

        private void ButtonHome_MouseDown(object sender, MouseEventArgs e)
        {
            pressButton(ButtonType.HOME);
        }

        private void ButtonHome_MouseUp(object sender, MouseEventArgs e)
        {
            releaseButton(ButtonType.HOME);
        }

        private void ButtonCapture_MouseDown(object sender, MouseEventArgs e)
        {
            pressButton(ButtonType.CAPTURE);
        }

        private void ButtonCapture_MouseUp(object sender, MouseEventArgs e)
        {
            releaseButton(ButtonType.CAPTURE);
        }

        private void moveStick(ButtonType button, Stick x_stick, Stick y_stick)
        {
            if (serialPort.IsOpen)
            {
                Byte[] data = new byte[3];
                data[0] = (Byte)button;
                data[1] = (Byte)x_stick;
                data[2] = (Byte)y_stick;

                serialPort.Write(data, 0, 3);
            }
        }
        private void moveStick(ButtonType button, byte x_stick, byte y_stick)
        {
            if (serialPort.IsOpen)
            {
                Byte[] data = new byte[3];
                data[0] = (Byte)button;
                data[1] = x_stick;
                data[2] = y_stick;

                serialPort.Write(data, 0, 3);
            }
        }
        private void releaseStick(ButtonType button)
        {
            if (serialPort.IsOpen)
            {
                Byte[] data = new byte[3];
                data[0] = (Byte)button;
                data[1] = (Byte)Stick.CENTER;
                data[2] = (Byte)Stick.CENTER;

                serialPort.Write(data, 0, 3);
            }
        }

        private void LeftN_MouseDown(object sender, MouseEventArgs e)
        {
            moveStick(ButtonType.LSTICK, Stick.CENTER, Stick.MIN);
        }

        private void LeftN_MouseUp(object sender, MouseEventArgs e)
        {
            releaseStick(ButtonType.LSTICK);
        }

        private void LeftS_MouseDown(object sender, MouseEventArgs e)
        {
            moveStick(ButtonType.LSTICK, Stick.CENTER, Stick.MAX);
        }

        private void LeftS_MouseUp(object sender, MouseEventArgs e)
        {
            releaseStick(ButtonType.LSTICK);
        }

        private void LeftE_MouseDown(object sender, MouseEventArgs e)
        {
            moveStick(ButtonType.LSTICK, Stick.MAX, Stick.CENTER);
        }

        private void LeftE_MouseUp(object sender, MouseEventArgs e)
        {
            releaseStick(ButtonType.LSTICK);
        }

        private void LeftW_MouseDown(object sender, MouseEventArgs e)
        {
            moveStick(ButtonType.LSTICK, Stick.MIN, Stick.CENTER);
        }

        private void LeftW_MouseUp(object sender, MouseEventArgs e)
        {
            releaseStick(ButtonType.LSTICK);
        }

        private void LeftNE_MouseDown(object sender, MouseEventArgs e)
        {
            moveStick(ButtonType.LSTICK, Stick.MAX, Stick.MIN);
        }

        private void LeftNE_MouseUp(object sender, MouseEventArgs e)
        {
            releaseStick(ButtonType.LSTICK);
        }

        private void LeftNW_MouseDown(object sender, MouseEventArgs e)
        {
            moveStick(ButtonType.LSTICK, Stick.MIN, Stick.MIN);
        }

        private void LeftNW_MouseUp(object sender, MouseEventArgs e)
        {
            releaseStick(ButtonType.LSTICK);
        }

        private void LeftSE_MouseDown(object sender, MouseEventArgs e)
        {
            moveStick(ButtonType.LSTICK, Stick.MAX, Stick.MAX);
        }

        private void LeftSE_MouseUp(object sender, MouseEventArgs e)
        {
            releaseStick(ButtonType.LSTICK);
        }

        private void LeftSW_MouseDown(object sender, MouseEventArgs e)
        {
            moveStick(ButtonType.LSTICK, Stick.MIN, Stick.MAX);
        }

        private void LeftSW_MouseUp(object sender, MouseEventArgs e)
        {
            releaseStick(ButtonType.LSTICK);
        }

        private void RightN_MouseDown(object sender, MouseEventArgs e)
        {
            moveStick(ButtonType.RSTICK, Stick.CENTER, Stick.MIN);
        }

        private void RightN_MouseUp(object sender, MouseEventArgs e)
        {
            releaseStick(ButtonType.RSTICK);
        }

        private void RightS_MouseDown(object sender, MouseEventArgs e)
        {
            moveStick(ButtonType.RSTICK, Stick.CENTER, Stick.MAX);
        }

        private void RightS_MouseUp(object sender, MouseEventArgs e)
        {
            releaseStick(ButtonType.RSTICK);
        }

        private void RightE_MouseDown(object sender, MouseEventArgs e)
        {
            moveStick(ButtonType.RSTICK, Stick.MAX, Stick.CENTER);
        }

        private void RightE_MouseUp(object sender, MouseEventArgs e)
        {
            releaseStick(ButtonType.RSTICK);
        }

        private void RightW_MouseDown(object sender, MouseEventArgs e)
        {
            moveStick(ButtonType.RSTICK, Stick.MIN, Stick.CENTER);
        }

        private void RightW_MouseUp(object sender, MouseEventArgs e)
        {
            releaseStick(ButtonType.RSTICK);
        }

        private void RightNE_MouseDown(object sender, MouseEventArgs e)
        {
            moveStick(ButtonType.RSTICK, Stick.MAX, Stick.MIN);
        }

        private void RightNE_MouseUp(object sender, MouseEventArgs e)
        {
            releaseStick(ButtonType.RSTICK);
        }

        private void RightSE_MouseDown(object sender, MouseEventArgs e)
        {
            moveStick(ButtonType.RSTICK, Stick.MAX, Stick.MAX);
        }

        private void RightSE_MouseUp(object sender, MouseEventArgs e)
        {
            releaseStick(ButtonType.RSTICK);
        }

        private void RightSW_MouseDown(object sender, MouseEventArgs e)
        {
            moveStick(ButtonType.RSTICK, Stick.MIN, Stick.MAX);
        }

        private void RightSW_MouseUp(object sender, MouseEventArgs e)
        {
            releaseStick(ButtonType.RSTICK);
        }

        private void RightNW_MouseDown(object sender, MouseEventArgs e)
        {
            moveStick(ButtonType.RSTICK, Stick.MAX, Stick.MAX);
        }

        private void RightNW_MouseUp(object sender, MouseEventArgs e)
        {
            releaseStick(ButtonType.RSTICK);
        }

        private async Task increaseDate(bool rade_hole_mode = false)
        {
            TimeSpan oneday = new TimeSpan(1, 0, 0, 0);
            DateTime tommorow = current_date + oneday;
            int year_diff = tommorow.Year - current_date.Year;
            int month_diff = tommorow.Month - current_date.Month;
            current_date = current_date + oneday;

            int update_num = 1;
            if (year_diff == 1) update_num = 3;
            if (month_diff == 1) update_num = 2;

            pressButton(ButtonType.A);
            await Task.Delay(40);
            releaseButton(ButtonType.A);
            await Task.Delay(300);

            if (rade_hole_mode)
            {
                for (int i = 0; i < 2; ++i)
                {
                    pressButton(ButtonType.RIGHT);
                    await Task.Delay(40);
                    releaseButton(ButtonType.RIGHT);
                    await Task.Delay(40);
                }

                for (int i = 0; i < update_num; ++i)
                {
                    pressButton(ButtonType.UP);
                    await Task.Delay(40);
                    releaseButton(ButtonType.UP);
                    await Task.Delay(40);

                    if (i != update_num - 1)
                    {
                        pressButton(ButtonType.LEFT);
                        await Task.Delay(40);
                        releaseButton(ButtonType.LEFT);
                        await Task.Delay(40);
                    }
                }

                for (int i = 0; i < update_num + 3; ++i)
                {
                    pressButton(ButtonType.A);
                    await Task.Delay(40);
                    releaseButton(ButtonType.A);
                    await Task.Delay(40);
                }
            }
            else
            {
                for (int i = 0; i < 2; ++i)
                {
                    pressButton(ButtonType.LEFT);
                    await Task.Delay(40);
                    releaseButton(ButtonType.LEFT);
                    await Task.Delay(40);
                }

                for (int i = 0; i < update_num; ++i)
                {
                    pressButton(ButtonType.LEFT);
                    await Task.Delay(40);
                    releaseButton(ButtonType.LEFT);
                    await Task.Delay(40);
                    pressButton(ButtonType.UP);
                    await Task.Delay(40);
                    releaseButton(ButtonType.UP);
                    await Task.Delay(40);
                }

                for (int i = 0; i < 3 + update_num; ++i)
                {
                    pressButton(ButtonType.A);
                    await Task.Delay(40);
                    releaseButton(ButtonType.A);
                    await Task.Delay(40);
                }
                await Task.Delay(200);
            }
            updateDateLabel();
        }

        private async Task increaseDateWithRaidHole()
        {
            pressButton(ButtonType.A);
            await Task.Delay(50);
            releaseButton(ButtonType.A);
            await Task.Delay(500);
            pressButton(ButtonType.A);
            await Task.Delay(50);
            releaseButton(ButtonType.A);
            await Task.Delay(3000);

            
            pressButton(ButtonType.HOME);
            await Task.Delay(50);
            releaseButton(ButtonType.HOME);
            await Task.Delay(1000);
            pressButton(ButtonType.DOWN);
            await Task.Delay(50);
            for (int j = 0; j < 4; ++j)
            {
                pressButton(ButtonType.RIGHT);
                await Task.Delay(50);
                releaseButton(ButtonType.RIGHT);
                await Task.Delay(50);
            }
            pressButton(ButtonType.A);
            await Task.Delay(50);
            releaseButton(ButtonType.A);
            await Task.Delay(50);
            pressButton(ButtonType.DOWN);
            await Task.Delay(2200);
            releaseButton(ButtonType.DOWN);
            await Task.Delay(50);
            pressButton(ButtonType.A);
            await Task.Delay(50);
            releaseButton(ButtonType.A);
            await Task.Delay(50);

            for (int j = 0; j < 4; ++j)
            {
                pressButton(ButtonType.DOWN);
                await Task.Delay(50);
                releaseButton(ButtonType.DOWN);
                await Task.Delay(50);
            }

            pressButton(ButtonType.A);
            await Task.Delay(50);
            releaseButton(ButtonType.A);
            await Task.Delay(300);

            for (int j = 0; j < 2; ++j)
            {
                pressButton(ButtonType.DOWN);
                await Task.Delay(50);
                releaseButton(ButtonType.DOWN);
                await Task.Delay(50);
            }

            //increase date
            await increaseDate(true);

            pressButton(ButtonType.HOME);
            await Task.Delay(50);
            releaseButton(ButtonType.HOME);
            await Task.Delay(1000);
            pressButton(ButtonType.A);
            await Task.Delay(50);
            releaseButton(ButtonType.A);
            await Task.Delay(500);

            pressButton(ButtonType.B);
            await Task.Delay(100);
            releaseButton(ButtonType.B);
            await Task.Delay(1000);
            pressButton(ButtonType.A);
            await Task.Delay(50);
            releaseButton(ButtonType.A);
            await Task.Delay(4000);

            for (int j = 0; j < 2; ++j)
            {
                pressButton(ButtonType.A);
                await Task.Delay(50);
                releaseButton(ButtonType.A);
                await Task.Delay(500);
            }

            for (int j = 0; j < 3; ++j)
            {
                pressButton(ButtonType.A);
                await Task.Delay(50);
                releaseButton(ButtonType.A);
                await Task.Delay(100);
            }
        }
    
        private async void CheckboxPlus1Day_CheckedChanged(object sender, EventArgs e)
        {
            DayComboBox.Enabled = false;
            if (CheckboxPlus1Day.Checked)
            {
                try
                {
                    token_source = new CancellationTokenSource();
                    cancel_token = token_source.Token;

                    await Task.Run(async () =>
                    {
                        
                        if (cancel_token.IsCancellationRequested)
                        { 
                            return;
                        }
                        await increaseDateWithRaidHole();
                    }, cancel_token);

                }
                catch (System.Threading.Tasks.TaskCanceledException exception)
                {
                }
                CheckboxPlus1Day.Checked = false;
            }
            else
            {
                token_source.Cancel();
            }
            DayComboBox.Enabled = true;
        }

        private async void CheckboxPlus3Days_CheckedChanged(object sender, EventArgs e)
        {
            DayComboBox.Enabled = false;
            if (CheckboxPlus3Days.Checked)
            {
                try
                {
                    token_source = new CancellationTokenSource();
                    cancel_token = token_source.Token;

                    await Task.Run(async () =>
                    {
                        for (uint i = 0; i < 3; ++i)
                        {
                            if (cancel_token.IsCancellationRequested)
                            {
                                return;
                            }
                            
                            await increaseDateWithRaidHole();
                        }
                    }, cancel_token);

                }
                catch (System.Threading.Tasks.TaskCanceledException exception)
                {
                }
                CheckboxPlus3Days.Checked = false;
            }
            else
            {
                token_source.Cancel();
            }
            DayComboBox.Enabled = true;
        }

        private async void CheckboxPlus4Days_CheckedChanged(object sender, EventArgs e)
        {
            DayComboBox.Enabled = false;
            if (CheckboxPlus4Days.Checked)
            {
                try
                {
                    token_source = new CancellationTokenSource();
                    cancel_token = token_source.Token;

                    await Task.Run(async () =>
                    {
                        for (uint i = 0; i < 4; ++i)
                        {
                            if (cancel_token.IsCancellationRequested)
                            {
                                return;
                            }

                            await increaseDateWithRaidHole();
                        }
                    }, cancel_token);

                }
                catch (System.Threading.Tasks.TaskCanceledException exception)
                {
                }
                CheckboxPlus4Days.Checked = false;
            }
            else
            {
                token_source.Cancel();
            }
            DayComboBox.Enabled = true;
        }

        private async void CheckboxPlusNDays_CheckedChanged(object sender, EventArgs e)
        {
            DayComboBox.Enabled = false;
            if (CheckboxPlusNDays.Checked)
            {
                try
                {
                    token_source = new CancellationTokenSource();
                    cancel_token = token_source.Token;

                    int n_days = int.Parse(DayTextbox.Text);
                    updateCountLabel(0, n_days);

                    pressButton(ButtonType.A);
                    await Task.Delay(40);
                    releaseButton(ButtonType.A);
                    await Task.Delay(300);
                    pressButton(ButtonType.RIGHT);
                    await Task.Delay(1000);
                    releaseButton(ButtonType.RIGHT);
                    await Task.Delay(40);
                    pressButton(ButtonType.A);
                    await Task.Delay(40);
                    releaseButton(ButtonType.A);
                    await Task.Delay(300);

                    await Task.Run(async () =>
                    {
                        for (int i = 0; i < n_days; ++i)
                        { 
                            if (cancel_token.IsCancellationRequested)
                            {
                                return;
                            }

                            await increaseDate();
                            updateCountLabel(i + 1, n_days);
                        }
                    }, cancel_token);

                }
                catch (System.Threading.Tasks.TaskCanceledException exception)
                {
                }
                catch(System.FormatException formatException)
                {
                }
                CheckboxPlusNDays.Checked = false;
            }
            else
            {
                token_source.Cancel();
            }
            DayComboBox.Enabled = true;
        }

        private void YearComboBox_Click(object sender, EventArgs e)
        {
            DayComboBox.SelectedIndex = -1;
        }

        private void MonthComboBox_Click(object sender, EventArgs e)
        {
            DayComboBox.SelectedIndex = -1;
        }

        private void DayComboBox_Click(object sender, EventArgs e)
        {
            DayComboBox.Items.Clear();
            int year = int.Parse(YearComboBox.SelectedItem.ToString());
            int month = int.Parse(MonthComboBox.SelectedItem.ToString());

            int days = DateTime.DaysInMonth(year, month);

            for (uint i = 1; i <= days; ++i)
            {
                DayComboBox.Items.Add(i);
            }
        }

        private void DayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DayComboBox.SelectedIndex >= 0)
            {
                int year = int.Parse(YearComboBox.SelectedItem.ToString());
                int month = int.Parse(MonthComboBox.SelectedItem.ToString());
                int day = int.Parse(DayComboBox.SelectedItem.ToString());

                current_date = new DateTime(year, month, day, 0, 0, 0);
                updateDateLabel();
            }
        }

        private async void CheckboxLotoID_CheckedChanged(object sender, EventArgs e)
        {
            DayComboBox.Enabled = false;
            if (CheckboxLotoID.Checked)
            {
                try
                {
                    token_source = new CancellationTokenSource();
                    cancel_token = token_source.Token;

                    await Task.Run(async () =>
                    {
                        while (true)
                        {
                            if (cancel_token.IsCancellationRequested)
                            {
                                return;
                            }
                            pressButton(ButtonType.HOME);
                            await Task.Delay(100);
                            releaseButton(ButtonType.HOME);
                            await Task.Delay(1000);
                            pressButton(ButtonType.DOWN);
                            await Task.Delay(50);
                            for (int i = 0; i < 4; ++i)
                            {
                                pressButton(ButtonType.RIGHT);
                                await Task.Delay(50);
                                releaseButton(ButtonType.RIGHT);
                                await Task.Delay(50);
                            }
                            pressButton(ButtonType.A);
                            await Task.Delay(50);
                            releaseButton(ButtonType.A);
                            await Task.Delay(50);
                            pressButton(ButtonType.DOWN);
                            await Task.Delay(2200);
                            releaseButton(ButtonType.DOWN);
                            await Task.Delay(50);
                            pressButton(ButtonType.A);
                            await Task.Delay(50);
                            releaseButton(ButtonType.A);
                            await Task.Delay(50);

                            for (int i = 0; i < 4; ++i)
                            {
                                pressButton(ButtonType.DOWN);
                                await Task.Delay(50);
                                releaseButton(ButtonType.DOWN);
                                await Task.Delay(50);
                            }

                            pressButton(ButtonType.A);
                            await Task.Delay(50);
                            releaseButton(ButtonType.A);
                            await Task.Delay(300);

                            for (int i = 0; i < 2; ++i)
                            {
                                pressButton(ButtonType.DOWN);
                                await Task.Delay(50);
                                releaseButton(ButtonType.DOWN);
                                await Task.Delay(50);
                            }

                            await increaseDate(true);

                            pressButton(ButtonType.HOME);
                            await Task.Delay(50);
                            releaseButton(ButtonType.HOME);
                            await Task.Delay(1000);
                            pressButton(ButtonType.A);
                            await Task.Delay(50);
                            releaseButton(ButtonType.A);
                            await Task.Delay(500);

                            //loto
                            pressButton(ButtonType.A);
                            await Task.Delay(50);
                            releaseButton(ButtonType.A);
                            await Task.Delay(500);
                            pressButton(ButtonType.A);
                            await Task.Delay(50);
                            releaseButton(ButtonType.A);
                            await Task.Delay(600);
                            pressButton(ButtonType.DOWN);
                            await Task.Delay(250);
                            releaseButton(ButtonType.DOWN);
                            await Task.Delay(250);
                            pressButton(ButtonType.A);
                            await Task.Delay(100);
                            releaseButton(ButtonType.A);
                            await Task.Delay(800);

                            for (int i = 0; i < 4; ++i)
                            {
                                pressButton(ButtonType.A);
                                await Task.Delay(120);
                                releaseButton(ButtonType.A);
                                await Task.Delay(550);
                            }
                            await Task.Delay(1200);

                            for (int i = 0; i < 6; ++i)
                            {
                                pressButton(ButtonType.A);
                                await Task.Delay(100);
                                releaseButton(ButtonType.A);
                                await Task.Delay(500);
                            }
                            await Task.Delay(2200);

                            for (int i = 0; i < 6; ++i)
                            {
                                pressButton(ButtonType.A);
                                await Task.Delay(100);
                                releaseButton(ButtonType.A);
                                await Task.Delay(500);
                            }
                            await Task.Delay(2500);

                            for (int i = 0; i < 3; ++i)
                            {
                                pressButton(ButtonType.A);
                                await Task.Delay(100);
                                releaseButton(ButtonType.A);
                                await Task.Delay(500);
                            }
                        }
                    }, cancel_token);

                }
                catch (System.Threading.Tasks.TaskCanceledException exception)
                {
                }
                CheckboxLotoID.Checked = false;
            }
            else
            {
                token_source.Cancel();
            }
            DayComboBox.Enabled = true;
        }

        private async void CheckboxRapidA_CheckedChanged(object sender, EventArgs e)
        {
            DayComboBox.Enabled = false;
            if (CheckboxRapidA.Checked)
            {
                try
                {
                    token_source = new CancellationTokenSource();
                    cancel_token = token_source.Token;

                    await Task.Run(async () =>
                    {
                        while (true)
                        {
                            if (cancel_token.IsCancellationRequested)
                            {
                                return;
                            }
                            pressButton(ButtonType.A);
                            await Task.Delay(100);
                            releaseButton(ButtonType.A);
                            await Task.Delay(900);
                        }
                    }, cancel_token);

                }
                catch (TaskCanceledException)
                {
                }
                CheckboxLotoID.Checked = false;
            }
            else
            {
                token_source.Cancel();
            }
            DayComboBox.Enabled = true;
        }

        private async void CheckboxTournament_CheckedChanged(object sender, EventArgs e)
        {
            DayComboBox.Enabled = false;
            if (CheckboxTournament.Checked)
            {
                try
                {
                    token_source = new CancellationTokenSource();
                    cancel_token = token_source.Token;

                    await Task.Run(async () =>
                    {
                        while (true)
                        {
                            if (cancel_token.IsCancellationRequested)
                            {
                                releaseStick(ButtonType.LSTICK);
                                return;
                            }

                            moveStick(ButtonType.LSTICK, (byte)160, (byte)0);
                            await Task.Delay(500);
                            for (int i = 0; i < 15; i++)
                            {
                                pressButton(ButtonType.A);
                                await Task.Delay(100);
                                releaseButton(ButtonType.A);
                                await Task.Delay(900);
                            }
                            pressButton(ButtonType.B);
                            await Task.Delay(100);
                            releaseButton(ButtonType.B);
                            await Task.Delay(900);
                        }
                    }, cancel_token);

                }
                catch (TaskCanceledException)
                {
                }
                CheckboxTournament.Checked = false;
            }
            else
            {
                token_source.Cancel();
            }
            DayComboBox.Enabled = true;
        }

        private async void CheckboxTowerAuto_CheckedChanged(object sender, EventArgs e)
        {
            DayComboBox.Enabled = false;
            if (CheckboxTowerAuto.Checked)
            {
                try
                {
                    token_source = new CancellationTokenSource();
                    cancel_token = token_source.Token;

                    await Task.Run(async () =>
                    {
                        while (true)
                        {
                            if (cancel_token.IsCancellationRequested)
                            {
                                releaseStick(ButtonType.LSTICK);
                                return;
                            }
                            pressButton(ButtonType.ZL);
                            await Task.Delay(100);
                            releaseButton(ButtonType.ZL);
                            await Task.Delay(2900);
                            pressButton(ButtonType.A);
                            await Task.Delay(100);
                            releaseButton(ButtonType.A);
                            await Task.Delay(1400);
                            pressButton(ButtonType.A);
                            await Task.Delay(100);
                            releaseButton(ButtonType.A);
                            await Task.Delay(1400);
                            pressButton(ButtonType.B);
                            await Task.Delay(100);
                            releaseButton(ButtonType.B);
                            await Task.Delay(1400);
                            pressButton(ButtonType.UP);
                            await Task.Delay(100);
                            releaseButton(ButtonType.UP);
                            await Task.Delay(1400);
                            pressButton(ButtonType.ZL);
                            await Task.Delay(100);
                            releaseButton(ButtonType.ZL);
                            await Task.Delay(2900);
                            pressButton(ButtonType.A);
                            await Task.Delay(100);
                            releaseButton(ButtonType.A);
                            await Task.Delay(1400);
                            pressButton(ButtonType.ZL);
                            await Task.Delay(100);
                            releaseButton(ButtonType.ZL);
                            await Task.Delay(2900);
                            pressButton(ButtonType.A);
                            await Task.Delay(100);
                            releaseButton(ButtonType.A);
                            await Task.Delay(1400);
                            pressButton(ButtonType.UP);
                            await Task.Delay(100);
                            releaseButton(ButtonType.UP);
                            await Task.Delay(1400);
                            pressButton(ButtonType.ZL);
                            await Task.Delay(100);
                            releaseButton(ButtonType.ZL);
                            await Task.Delay(2900);
                            pressButton(ButtonType.A);
                            await Task.Delay(100);
                            releaseButton(ButtonType.A);
                            await Task.Delay(1400);
                            pressButton(ButtonType.UP);
                            await Task.Delay(100);
                            releaseButton(ButtonType.UP);
                            await Task.Delay(1400);
                            pressButton(ButtonType.ZL);
                            await Task.Delay(100);
                            releaseButton(ButtonType.ZL);
                            await Task.Delay(2900);
                        }
                    }, cancel_token);

                }
                catch (TaskCanceledException)
                {
                }
                CheckboxTournament.Checked = false;
            }
            else
            {
                token_source.Cancel();
            }
            DayComboBox.Enabled = true;
        }
    }
}
