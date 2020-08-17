namespace PokemonAutomation
{
    partial class PokemonAutomation
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.up = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.down = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.comPortComboBox = new System.Windows.Forms.ComboBox();
            this.ButtonZR = new System.Windows.Forms.Button();
            this.ButtonA = new System.Windows.Forms.Button();
            this.ButtonB = new System.Windows.Forms.Button();
            this.ButtonY = new System.Windows.Forms.Button();
            this.ButtonX = new System.Windows.Forms.Button();
            this.LeftN = new System.Windows.Forms.Button();
            this.LeftS = new System.Windows.Forms.Button();
            this.LeftE = new System.Windows.Forms.Button();
            this.LeftNE = new System.Windows.Forms.Button();
            this.LeftSE = new System.Windows.Forms.Button();
            this.LeftW = new System.Windows.Forms.Button();
            this.LeftSW = new System.Windows.Forms.Button();
            this.LeftNW = new System.Windows.Forms.Button();
            this.RightNW = new System.Windows.Forms.Button();
            this.RightSW = new System.Windows.Forms.Button();
            this.RightW = new System.Windows.Forms.Button();
            this.RightSE = new System.Windows.Forms.Button();
            this.RightNE = new System.Windows.Forms.Button();
            this.RightE = new System.Windows.Forms.Button();
            this.RightS = new System.Windows.Forms.Button();
            this.RightN = new System.Windows.Forms.Button();
            this.ButtonR = new System.Windows.Forms.Button();
            this.ButtonL = new System.Windows.Forms.Button();
            this.ButtonZL = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.ButtonHome = new System.Windows.Forms.Button();
            this.ButtonCapture = new System.Windows.Forms.Button();
            this.CheckboxLotoID = new System.Windows.Forms.CheckBox();
            this.DayTextbox = new System.Windows.Forms.TextBox();
            this.LabelDate = new System.Windows.Forms.Label();
            this.CheckboxPlus3Days = new System.Windows.Forms.CheckBox();
            this.CheckboxPlus4Days = new System.Windows.Forms.CheckBox();
            this.CheckboxPlus1Day = new System.Windows.Forms.CheckBox();
            this.YearComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.DayComboBox = new System.Windows.Forms.ComboBox();
            this.CountLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CheckboxPlusNDays = new System.Windows.Forms.CheckBox();
            this.checkBoxWatt = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // up
            // 
            this.up.Location = new System.Drawing.Point(106, 296);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(75, 23);
            this.up.TabIndex = 0;
            this.up.Text = "↑";
            this.up.UseVisualStyleBackColor = true;
            this.up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.up_MouseDown);
            this.up.MouseUp += new System.Windows.Forms.MouseEventHandler(this.up_MouseUp);
            // 
            // serialPort
            // 
            this.serialPort.DtrEnable = true;
            this.serialPort.PortName = "COM7";
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // down
            // 
            this.down.Location = new System.Drawing.Point(106, 354);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(75, 23);
            this.down.TabIndex = 2;
            this.down.Text = "↓";
            this.down.UseVisualStyleBackColor = true;
            this.down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.down_MouseDown);
            this.down.MouseUp += new System.Windows.Forms.MouseEventHandler(this.down_MouseUp);
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(25, 325);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(75, 23);
            this.left.TabIndex = 3;
            this.left.Text = "←";
            this.left.UseVisualStyleBackColor = true;
            this.left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.left_MouseDown);
            this.left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.left_MouseUp);
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(187, 325);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(75, 23);
            this.right.TabIndex = 4;
            this.right.Text = "→";
            this.right.UseVisualStyleBackColor = true;
            this.right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.right_MouseDown);
            this.right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.right_MouseUp);
            // 
            // comPortComboBox
            // 
            this.comPortComboBox.FormattingEnabled = true;
            this.comPortComboBox.Location = new System.Drawing.Point(25, 24);
            this.comPortComboBox.Name = "comPortComboBox";
            this.comPortComboBox.Size = new System.Drawing.Size(121, 20);
            this.comPortComboBox.TabIndex = 5;
            this.comPortComboBox.SelectedIndexChanged += new System.EventHandler(this.comPortComboBox_SelectedIndexChanged);
            this.comPortComboBox.Click += new System.EventHandler(this.comPortComboBox_Click);
            // 
            // ButtonZR
            // 
            this.ButtonZR.Location = new System.Drawing.Point(452, 72);
            this.ButtonZR.Name = "ButtonZR";
            this.ButtonZR.Size = new System.Drawing.Size(75, 23);
            this.ButtonZR.TabIndex = 7;
            this.ButtonZR.Text = "ZR";
            this.ButtonZR.UseVisualStyleBackColor = true;
            this.ButtonZR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonZR_MouseDown);
            this.ButtonZR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonZR_MouseUp);
            // 
            // ButtonA
            // 
            this.ButtonA.Location = new System.Drawing.Point(452, 196);
            this.ButtonA.Name = "ButtonA";
            this.ButtonA.Size = new System.Drawing.Size(75, 23);
            this.ButtonA.TabIndex = 8;
            this.ButtonA.Text = "A";
            this.ButtonA.UseVisualStyleBackColor = true;
            this.ButtonA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonA_MouseDown);
            this.ButtonA.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonA_MouseUp);
            // 
            // ButtonB
            // 
            this.ButtonB.Location = new System.Drawing.Point(371, 219);
            this.ButtonB.Name = "ButtonB";
            this.ButtonB.Size = new System.Drawing.Size(75, 23);
            this.ButtonB.TabIndex = 9;
            this.ButtonB.Text = "B";
            this.ButtonB.UseVisualStyleBackColor = true;
            this.ButtonB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonB_MouseDown);
            this.ButtonB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonB_MouseUp);
            // 
            // ButtonY
            // 
            this.ButtonY.Location = new System.Drawing.Point(290, 196);
            this.ButtonY.Name = "ButtonY";
            this.ButtonY.Size = new System.Drawing.Size(75, 23);
            this.ButtonY.TabIndex = 10;
            this.ButtonY.Text = "Y";
            this.ButtonY.UseVisualStyleBackColor = true;
            this.ButtonY.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonY_MouseDown);
            this.ButtonY.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonY_MouseUp);
            // 
            // ButtonX
            // 
            this.ButtonX.Location = new System.Drawing.Point(371, 173);
            this.ButtonX.Name = "ButtonX";
            this.ButtonX.Size = new System.Drawing.Size(75, 23);
            this.ButtonX.TabIndex = 11;
            this.ButtonX.Text = "X";
            this.ButtonX.UseVisualStyleBackColor = true;
            this.ButtonX.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonX_MouseDown);
            this.ButtonX.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonX_MouseUp);
            // 
            // LeftN
            // 
            this.LeftN.Location = new System.Drawing.Point(106, 167);
            this.LeftN.Name = "LeftN";
            this.LeftN.Size = new System.Drawing.Size(75, 23);
            this.LeftN.TabIndex = 12;
            this.LeftN.Text = "↑";
            this.LeftN.UseVisualStyleBackColor = true;
            this.LeftN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftN_MouseDown);
            this.LeftN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftN_MouseUp);
            // 
            // LeftS
            // 
            this.LeftS.Location = new System.Drawing.Point(106, 225);
            this.LeftS.Name = "LeftS";
            this.LeftS.Size = new System.Drawing.Size(75, 23);
            this.LeftS.TabIndex = 14;
            this.LeftS.Text = "↓";
            this.LeftS.UseVisualStyleBackColor = true;
            this.LeftS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftS_MouseDown);
            this.LeftS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftS_MouseUp);
            // 
            // LeftE
            // 
            this.LeftE.Location = new System.Drawing.Point(187, 196);
            this.LeftE.Name = "LeftE";
            this.LeftE.Size = new System.Drawing.Size(75, 23);
            this.LeftE.TabIndex = 15;
            this.LeftE.Text = "→";
            this.LeftE.UseVisualStyleBackColor = true;
            this.LeftE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftE_MouseDown);
            this.LeftE.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftE_MouseUp);
            // 
            // LeftNE
            // 
            this.LeftNE.Location = new System.Drawing.Point(187, 167);
            this.LeftNE.Name = "LeftNE";
            this.LeftNE.Size = new System.Drawing.Size(75, 23);
            this.LeftNE.TabIndex = 16;
            this.LeftNE.Text = "↗";
            this.LeftNE.UseVisualStyleBackColor = true;
            this.LeftNE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftNE_MouseDown);
            this.LeftNE.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftNE_MouseUp);
            // 
            // LeftSE
            // 
            this.LeftSE.Location = new System.Drawing.Point(187, 225);
            this.LeftSE.Name = "LeftSE";
            this.LeftSE.Size = new System.Drawing.Size(75, 23);
            this.LeftSE.TabIndex = 17;
            this.LeftSE.Text = "↘";
            this.LeftSE.UseVisualStyleBackColor = true;
            this.LeftSE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftSE_MouseDown);
            this.LeftSE.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftSE_MouseUp);
            // 
            // LeftW
            // 
            this.LeftW.Location = new System.Drawing.Point(25, 196);
            this.LeftW.Name = "LeftW";
            this.LeftW.Size = new System.Drawing.Size(75, 23);
            this.LeftW.TabIndex = 18;
            this.LeftW.Text = "←";
            this.LeftW.UseVisualStyleBackColor = true;
            this.LeftW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftW_MouseDown);
            this.LeftW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftW_MouseUp);
            // 
            // LeftSW
            // 
            this.LeftSW.Location = new System.Drawing.Point(25, 225);
            this.LeftSW.Name = "LeftSW";
            this.LeftSW.Size = new System.Drawing.Size(75, 23);
            this.LeftSW.TabIndex = 19;
            this.LeftSW.Text = "↙";
            this.LeftSW.UseVisualStyleBackColor = true;
            this.LeftSW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftSW_MouseDown);
            this.LeftSW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftSW_MouseUp);
            // 
            // LeftNW
            // 
            this.LeftNW.Location = new System.Drawing.Point(25, 167);
            this.LeftNW.Name = "LeftNW";
            this.LeftNW.Size = new System.Drawing.Size(75, 23);
            this.LeftNW.TabIndex = 20;
            this.LeftNW.Text = "↖";
            this.LeftNW.UseVisualStyleBackColor = true;
            this.LeftNW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftNW_MouseDown);
            this.LeftNW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftNW_MouseUp);
            // 
            // RightNW
            // 
            this.RightNW.Location = new System.Drawing.Point(290, 296);
            this.RightNW.Name = "RightNW";
            this.RightNW.Size = new System.Drawing.Size(75, 23);
            this.RightNW.TabIndex = 28;
            this.RightNW.Text = "↖";
            this.RightNW.UseVisualStyleBackColor = true;
            this.RightNW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightNW_MouseDown);
            this.RightNW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightNW_MouseUp);
            // 
            // RightSW
            // 
            this.RightSW.Location = new System.Drawing.Point(290, 354);
            this.RightSW.Name = "RightSW";
            this.RightSW.Size = new System.Drawing.Size(75, 23);
            this.RightSW.TabIndex = 27;
            this.RightSW.Text = "↙";
            this.RightSW.UseVisualStyleBackColor = true;
            this.RightSW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightSW_MouseDown);
            this.RightSW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightSW_MouseUp);
            // 
            // RightW
            // 
            this.RightW.Location = new System.Drawing.Point(290, 325);
            this.RightW.Name = "RightW";
            this.RightW.Size = new System.Drawing.Size(75, 23);
            this.RightW.TabIndex = 26;
            this.RightW.Text = "←";
            this.RightW.UseVisualStyleBackColor = true;
            this.RightW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightW_MouseDown);
            this.RightW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightW_MouseUp);
            // 
            // RightSE
            // 
            this.RightSE.Location = new System.Drawing.Point(454, 354);
            this.RightSE.Name = "RightSE";
            this.RightSE.Size = new System.Drawing.Size(75, 23);
            this.RightSE.TabIndex = 25;
            this.RightSE.Text = "↘";
            this.RightSE.UseVisualStyleBackColor = true;
            this.RightSE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightSE_MouseDown);
            this.RightSE.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightSE_MouseUp);
            // 
            // RightNE
            // 
            this.RightNE.Location = new System.Drawing.Point(454, 296);
            this.RightNE.Name = "RightNE";
            this.RightNE.Size = new System.Drawing.Size(75, 23);
            this.RightNE.TabIndex = 24;
            this.RightNE.Text = "↗";
            this.RightNE.UseVisualStyleBackColor = true;
            this.RightNE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightNE_MouseDown);
            this.RightNE.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightNE_MouseUp);
            // 
            // RightE
            // 
            this.RightE.Location = new System.Drawing.Point(454, 325);
            this.RightE.Name = "RightE";
            this.RightE.Size = new System.Drawing.Size(75, 23);
            this.RightE.TabIndex = 23;
            this.RightE.Text = "→";
            this.RightE.UseVisualStyleBackColor = true;
            this.RightE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightE_MouseDown);
            this.RightE.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightE_MouseUp);
            // 
            // RightS
            // 
            this.RightS.Location = new System.Drawing.Point(373, 354);
            this.RightS.Name = "RightS";
            this.RightS.Size = new System.Drawing.Size(75, 23);
            this.RightS.TabIndex = 22;
            this.RightS.Text = "↓";
            this.RightS.UseVisualStyleBackColor = true;
            this.RightS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightS_MouseDown);
            this.RightS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightS_MouseUp);
            // 
            // RightN
            // 
            this.RightN.Location = new System.Drawing.Point(373, 296);
            this.RightN.Name = "RightN";
            this.RightN.Size = new System.Drawing.Size(75, 23);
            this.RightN.TabIndex = 21;
            this.RightN.Text = "↑";
            this.RightN.UseVisualStyleBackColor = true;
            this.RightN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightN_MouseDown);
            this.RightN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightN_MouseUp);
            // 
            // ButtonR
            // 
            this.ButtonR.Location = new System.Drawing.Point(452, 110);
            this.ButtonR.Name = "ButtonR";
            this.ButtonR.Size = new System.Drawing.Size(75, 23);
            this.ButtonR.TabIndex = 29;
            this.ButtonR.Text = "R";
            this.ButtonR.UseVisualStyleBackColor = true;
            this.ButtonR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonR_MouseDown);
            this.ButtonR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonR_MouseUp);
            // 
            // ButtonL
            // 
            this.ButtonL.Location = new System.Drawing.Point(25, 110);
            this.ButtonL.Name = "ButtonL";
            this.ButtonL.Size = new System.Drawing.Size(75, 23);
            this.ButtonL.TabIndex = 30;
            this.ButtonL.Text = "L";
            this.ButtonL.UseVisualStyleBackColor = true;
            this.ButtonL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonL_MouseDown);
            this.ButtonL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonL_MouseUp);
            // 
            // ButtonZL
            // 
            this.ButtonZL.Location = new System.Drawing.Point(25, 72);
            this.ButtonZL.Name = "ButtonZL";
            this.ButtonZL.Size = new System.Drawing.Size(75, 23);
            this.ButtonZL.TabIndex = 31;
            this.ButtonZL.Text = "ZL";
            this.ButtonZL.UseVisualStyleBackColor = true;
            this.ButtonZL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonZL_MouseDown);
            this.ButtonZL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonZL_MouseUp);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.Location = new System.Drawing.Point(187, 93);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(75, 23);
            this.ButtonMinus.TabIndex = 32;
            this.ButtonMinus.Text = "-";
            this.ButtonMinus.UseVisualStyleBackColor = true;
            this.ButtonMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonMinus_MouseDown);
            this.ButtonMinus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonMinus_MouseUp);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.Location = new System.Drawing.Point(290, 93);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(75, 23);
            this.ButtonPlus.TabIndex = 33;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = true;
            this.ButtonPlus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPlus_MouseDown);
            this.ButtonPlus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonPlus_MouseUp);
            // 
            // ButtonHome
            // 
            this.ButtonHome.Location = new System.Drawing.Point(290, 407);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(75, 23);
            this.ButtonHome.TabIndex = 34;
            this.ButtonHome.Text = "Home";
            this.ButtonHome.UseVisualStyleBackColor = true;
            this.ButtonHome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonHome_MouseDown);
            this.ButtonHome.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonHome_MouseUp);
            // 
            // ButtonCapture
            // 
            this.ButtonCapture.Location = new System.Drawing.Point(187, 407);
            this.ButtonCapture.Name = "ButtonCapture";
            this.ButtonCapture.Size = new System.Drawing.Size(75, 23);
            this.ButtonCapture.TabIndex = 35;
            this.ButtonCapture.Text = "Capture";
            this.ButtonCapture.UseVisualStyleBackColor = true;
            this.ButtonCapture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonCapture_MouseDown);
            this.ButtonCapture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonCapture_MouseUp);
            // 
            // CheckboxLotoID
            // 
            this.CheckboxLotoID.Appearance = System.Windows.Forms.Appearance.Button;
            this.CheckboxLotoID.Location = new System.Drawing.Point(623, 354);
            this.CheckboxLotoID.Name = "CheckboxLotoID";
            this.CheckboxLotoID.Size = new System.Drawing.Size(104, 34);
            this.CheckboxLotoID.TabIndex = 36;
            this.CheckboxLotoID.Text = "Loto ID";
            this.CheckboxLotoID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckboxLotoID.UseVisualStyleBackColor = true;
            this.CheckboxLotoID.CheckedChanged += new System.EventHandler(this.CheckboxLotoID_CheckedChanged);
            // 
            // DayTextbox
            // 
            this.DayTextbox.Location = new System.Drawing.Point(577, 264);
            this.DayTextbox.Name = "DayTextbox";
            this.DayTextbox.Size = new System.Drawing.Size(104, 19);
            this.DayTextbox.TabIndex = 40;
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Location = new System.Drawing.Point(556, 81);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(31, 12);
            this.LabelDate.TabIndex = 42;
            this.LabelDate.Text = "Date:";
            this.LabelDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CheckboxPlus3Days
            // 
            this.CheckboxPlus3Days.Appearance = System.Windows.Forms.Appearance.Button;
            this.CheckboxPlus3Days.Location = new System.Drawing.Point(623, 159);
            this.CheckboxPlus3Days.Name = "CheckboxPlus3Days";
            this.CheckboxPlus3Days.Size = new System.Drawing.Size(104, 32);
            this.CheckboxPlus3Days.TabIndex = 43;
            this.CheckboxPlus3Days.Text = "+3 Days";
            this.CheckboxPlus3Days.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckboxPlus3Days.UseVisualStyleBackColor = true;
            this.CheckboxPlus3Days.CheckedChanged += new System.EventHandler(this.CheckboxPlus3Days_CheckedChanged);
            // 
            // CheckboxPlus4Days
            // 
            this.CheckboxPlus4Days.Appearance = System.Windows.Forms.Appearance.Button;
            this.CheckboxPlus4Days.Location = new System.Drawing.Point(623, 206);
            this.CheckboxPlus4Days.Name = "CheckboxPlus4Days";
            this.CheckboxPlus4Days.Size = new System.Drawing.Size(104, 32);
            this.CheckboxPlus4Days.TabIndex = 44;
            this.CheckboxPlus4Days.Text = "+4 Days";
            this.CheckboxPlus4Days.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckboxPlus4Days.UseVisualStyleBackColor = true;
            this.CheckboxPlus4Days.CheckedChanged += new System.EventHandler(this.CheckboxPlus4Days_CheckedChanged);
            // 
            // CheckboxPlus1Day
            // 
            this.CheckboxPlus1Day.Appearance = System.Windows.Forms.Appearance.Button;
            this.CheckboxPlus1Day.Location = new System.Drawing.Point(623, 110);
            this.CheckboxPlus1Day.Name = "CheckboxPlus1Day";
            this.CheckboxPlus1Day.Size = new System.Drawing.Size(104, 32);
            this.CheckboxPlus1Day.TabIndex = 45;
            this.CheckboxPlus1Day.Text = "+1 Day";
            this.CheckboxPlus1Day.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckboxPlus1Day.UseVisualStyleBackColor = true;
            this.CheckboxPlus1Day.CheckedChanged += new System.EventHandler(this.CheckboxPlus1Day_CheckedChanged);
            // 
            // YearComboBox
            // 
            this.YearComboBox.FormattingEnabled = true;
            this.YearComboBox.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040",
            "2041",
            "2042",
            "2043",
            "2044",
            "2045",
            "2046",
            "2047",
            "2048",
            "2049",
            "2050",
            "2051",
            "2052",
            "2053",
            "2054",
            "2055",
            "2056",
            "2057",
            "2058",
            "2059",
            "2060"});
            this.YearComboBox.Location = new System.Drawing.Point(558, 47);
            this.YearComboBox.Name = "YearComboBox";
            this.YearComboBox.Size = new System.Drawing.Size(91, 20);
            this.YearComboBox.TabIndex = 46;
            this.YearComboBox.Click += new System.EventHandler(this.YearComboBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(556, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 12);
            this.label1.TabIndex = 47;
            this.label1.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(659, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 12);
            this.label2.TabIndex = 48;
            this.label2.Text = "Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(735, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 12);
            this.label3.TabIndex = 49;
            this.label3.Text = "Day";
            // 
            // MonthComboBox
            // 
            this.MonthComboBox.FormattingEnabled = true;
            this.MonthComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.MonthComboBox.Location = new System.Drawing.Point(661, 47);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(66, 20);
            this.MonthComboBox.TabIndex = 50;
            this.MonthComboBox.Click += new System.EventHandler(this.MonthComboBox_Click);
            // 
            // DayComboBox
            // 
            this.DayComboBox.FormattingEnabled = true;
            this.DayComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.DayComboBox.Location = new System.Drawing.Point(737, 47);
            this.DayComboBox.Name = "DayComboBox";
            this.DayComboBox.Size = new System.Drawing.Size(66, 20);
            this.DayComboBox.TabIndex = 51;
            this.DayComboBox.SelectedIndexChanged += new System.EventHandler(this.DayComboBox_SelectedIndexChanged);
            this.DayComboBox.Click += new System.EventHandler(this.DayComboBox_Click);
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(575, 296);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(35, 12);
            this.CountLabel.TabIndex = 52;
            this.CountLabel.Text = "count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 12);
            this.label4.TabIndex = 53;
            this.label4.Text = "Port";
            // 
            // CheckboxPlusNDays
            // 
            this.CheckboxPlusNDays.Appearance = System.Windows.Forms.Appearance.Button;
            this.CheckboxPlusNDays.Location = new System.Drawing.Point(687, 257);
            this.CheckboxPlusNDays.Name = "CheckboxPlusNDays";
            this.CheckboxPlusNDays.Size = new System.Drawing.Size(104, 32);
            this.CheckboxPlusNDays.TabIndex = 54;
            this.CheckboxPlusNDays.Text = "+ N Days";
            this.CheckboxPlusNDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckboxPlusNDays.UseVisualStyleBackColor = true;
            this.CheckboxPlusNDays.CheckedChanged += new System.EventHandler(this.CheckboxPlusNDays_CheckedChanged);
            // 
            // checkBoxWatt
            // 
            this.checkBoxWatt.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxWatt.Location = new System.Drawing.Point(623, 406);
            this.checkBoxWatt.Name = "checkBoxWatt";
            this.checkBoxWatt.Size = new System.Drawing.Size(104, 34);
            this.checkBoxWatt.TabIndex = 55;
            this.checkBoxWatt.Text = "Watt";
            this.checkBoxWatt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxWatt.UseVisualStyleBackColor = true;
            this.checkBoxWatt.CheckedChanged += new System.EventHandler(this.checkBoxWatt_CheckedChanged);
            // 
            // PokemonAutomation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 470);
            this.Controls.Add(this.checkBoxWatt);
            this.Controls.Add(this.CheckboxPlusNDays);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.DayComboBox);
            this.Controls.Add(this.MonthComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YearComboBox);
            this.Controls.Add(this.CheckboxPlus1Day);
            this.Controls.Add(this.CheckboxPlus4Days);
            this.Controls.Add(this.CheckboxPlus3Days);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.DayTextbox);
            this.Controls.Add(this.CheckboxLotoID);
            this.Controls.Add(this.ButtonCapture);
            this.Controls.Add(this.ButtonHome);
            this.Controls.Add(this.ButtonPlus);
            this.Controls.Add(this.ButtonMinus);
            this.Controls.Add(this.ButtonZL);
            this.Controls.Add(this.ButtonL);
            this.Controls.Add(this.ButtonR);
            this.Controls.Add(this.RightNW);
            this.Controls.Add(this.RightSW);
            this.Controls.Add(this.RightW);
            this.Controls.Add(this.RightSE);
            this.Controls.Add(this.RightNE);
            this.Controls.Add(this.RightE);
            this.Controls.Add(this.RightS);
            this.Controls.Add(this.RightN);
            this.Controls.Add(this.LeftNW);
            this.Controls.Add(this.LeftSW);
            this.Controls.Add(this.LeftW);
            this.Controls.Add(this.LeftSE);
            this.Controls.Add(this.LeftNE);
            this.Controls.Add(this.LeftE);
            this.Controls.Add(this.LeftS);
            this.Controls.Add(this.LeftN);
            this.Controls.Add(this.ButtonX);
            this.Controls.Add(this.ButtonY);
            this.Controls.Add(this.ButtonB);
            this.Controls.Add(this.ButtonA);
            this.Controls.Add(this.ButtonZR);
            this.Controls.Add(this.comPortComboBox);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.down);
            this.Controls.Add(this.up);
            this.Name = "PokemonAutomation";
            this.Text = "PokemonAutomation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button up;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.ComboBox comPortComboBox;
        private System.Windows.Forms.Button ButtonZR;
        private System.Windows.Forms.Button ButtonA;
        private System.Windows.Forms.Button ButtonB;
        private System.Windows.Forms.Button ButtonY;
        private System.Windows.Forms.Button ButtonX;
        private System.Windows.Forms.Button LeftN;
        private System.Windows.Forms.Button LeftS;
        private System.Windows.Forms.Button LeftE;
        private System.Windows.Forms.Button LeftNE;
        private System.Windows.Forms.Button LeftSE;
        private System.Windows.Forms.Button LeftW;
        private System.Windows.Forms.Button LeftSW;
        private System.Windows.Forms.Button LeftNW;
        private System.Windows.Forms.Button RightNW;
        private System.Windows.Forms.Button RightSW;
        private System.Windows.Forms.Button RightW;
        private System.Windows.Forms.Button RightSE;
        private System.Windows.Forms.Button RightNE;
        private System.Windows.Forms.Button RightE;
        private System.Windows.Forms.Button RightS;
        private System.Windows.Forms.Button RightN;
        private System.Windows.Forms.Button ButtonR;
        private System.Windows.Forms.Button ButtonL;
        private System.Windows.Forms.Button ButtonZL;
        private System.Windows.Forms.Button ButtonMinus;
        private System.Windows.Forms.Button ButtonPlus;
        private System.Windows.Forms.Button ButtonHome;
        private System.Windows.Forms.Button ButtonCapture;
        private System.Windows.Forms.CheckBox CheckboxLotoID;
        private System.Windows.Forms.TextBox DayTextbox;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.CheckBox CheckboxPlus3Days;
        private System.Windows.Forms.CheckBox CheckboxPlus4Days;
        private System.Windows.Forms.CheckBox CheckboxPlus1Day;
        private System.Windows.Forms.ComboBox YearComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MonthComboBox;
        private System.Windows.Forms.ComboBox DayComboBox;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CheckboxPlusNDays;
        private System.Windows.Forms.CheckBox checkBoxWatt;
    }
}

