namespace WINCC_WaveDraw
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Receive_RichText = new System.Windows.Forms.RichTextBox();
            this.Send_RichText = new System.Windows.Forms.RichTextBox();
            this.Send = new System.Windows.Forms.Button();
            this.Bar_ZoomX = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.Bar_ZoomY = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.Buton_Zero = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Buton_Refresh = new System.Windows.Forms.Button();
            this.Thread_1ms = new System.Windows.Forms.Timer(this.components);
            this.Thread_100ms = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.Button_Save = new System.Windows.Forms.Button();
            this.Button_Restar = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Button_Start = new System.Windows.Forms.Button();
            this.checkBox_Follow = new System.Windows.Forms.CheckBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button_Point1 = new System.Windows.Forms.Button();
            this.button_Point2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.numericUpDown_Time = new System.Windows.Forms.NumericUpDown();
            this.button22 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_Usart = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.DrawPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar_ZoomX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar_ZoomY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Time)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawPanel
            // 
            this.DrawPanel.AutoScroll = true;
            this.DrawPanel.BackColor = System.Drawing.Color.DarkGray;
            this.DrawPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrawPanel.Controls.Add(this.pictureBox1);
            this.DrawPanel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DrawPanel.Location = new System.Drawing.Point(4, 2);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(1001, 316);
            this.DrawPanel.TabIndex = 0;
            this.DrawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30000, 3000);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_Click_DrawPanel);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mouse_Move_DrawPanel);
            // 
            // Receive_RichText
            // 
            this.Receive_RichText.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Receive_RichText.Location = new System.Drawing.Point(15, 331);
            this.Receive_RichText.Name = "Receive_RichText";
            this.Receive_RichText.ReadOnly = true;
            this.Receive_RichText.Size = new System.Drawing.Size(517, 189);
            this.Receive_RichText.TabIndex = 37;
            this.Receive_RichText.Text = "";
            this.Receive_RichText.TextChanged += new System.EventHandler(this.Receive_RichText_TextChanged);
            // 
            // Send_RichText
            // 
            this.Send_RichText.Location = new System.Drawing.Point(15, 526);
            this.Send_RichText.Name = "Send_RichText";
            this.Send_RichText.Size = new System.Drawing.Size(479, 68);
            this.Send_RichText.TabIndex = 38;
            this.Send_RichText.Text = "";
            this.Send_RichText.TextChanged += new System.EventHandler(this.Send_RichText_TextChanged);
            // 
            // Send
            // 
            this.Send.BackColor = System.Drawing.Color.Transparent;
            this.Send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Send.Cursor = System.Windows.Forms.Cursors.Default;
            this.Send.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Send.Location = new System.Drawing.Point(498, 526);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(34, 68);
            this.Send.TabIndex = 39;
            this.Send.Text = "发送";
            this.Send.UseVisualStyleBackColor = false;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Bar_ZoomX
            // 
            this.Bar_ZoomX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Bar_ZoomX.Location = new System.Drawing.Point(924, 414);
            this.Bar_ZoomX.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Bar_ZoomX.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.Bar_ZoomX.Name = "Bar_ZoomX";
            this.Bar_ZoomX.Size = new System.Drawing.Size(55, 17);
            this.Bar_ZoomX.TabIndex = 45;
            this.Bar_ZoomX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Bar_ZoomX.Value = new decimal(new int[] {
            100,
            0,
            0,
            65536});
            this.Bar_ZoomX.ValueChanged += new System.EventHandler(this.Bar_ZoomX_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(869, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 24);
            this.button1.TabIndex = 46;
            this.button1.Text = "X轴每格           s";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Bar_ZoomY
            // 
            this.Bar_ZoomY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Bar_ZoomY.DecimalPlaces = 1;
            this.Bar_ZoomY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Bar_ZoomY.Location = new System.Drawing.Point(924, 441);
            this.Bar_ZoomY.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            65536});
            this.Bar_ZoomY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Bar_ZoomY.Name = "Bar_ZoomY";
            this.Bar_ZoomY.Size = new System.Drawing.Size(55, 17);
            this.Bar_ZoomY.TabIndex = 47;
            this.Bar_ZoomY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Bar_ZoomY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Bar_ZoomY.ValueChanged += new System.EventHandler(this.Bar_ZoomY_ValueChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(869, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 24);
            this.button2.TabIndex = 48;
            this.button2.Text = "Y轴每格           V";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Buton_Zero
            // 
            this.Buton_Zero.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Buton_Zero.Font = new System.Drawing.Font("新宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Buton_Zero.ForeColor = System.Drawing.Color.Maroon;
            this.Buton_Zero.Location = new System.Drawing.Point(558, 321);
            this.Buton_Zero.Name = "Buton_Zero";
            this.Buton_Zero.Size = new System.Drawing.Size(108, 53);
            this.Buton_Zero.TabIndex = 49;
            this.Buton_Zero.Text = "置零";
            this.Buton_Zero.UseVisualStyleBackColor = false;
            this.Buton_Zero.Click += new System.EventHandler(this.Button_Zero_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 321);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(540, 283);
            this.button4.TabIndex = 50;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Buton_Refresh
            // 
            this.Buton_Refresh.Font = new System.Drawing.Font("新宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Buton_Refresh.ForeColor = System.Drawing.Color.Blue;
            this.Buton_Refresh.Location = new System.Drawing.Point(558, 488);
            this.Buton_Refresh.Name = "Buton_Refresh";
            this.Buton_Refresh.Size = new System.Drawing.Size(108, 37);
            this.Buton_Refresh.TabIndex = 52;
            this.Buton_Refresh.Text = "刷新";
            this.Buton_Refresh.UseVisualStyleBackColor = true;
            this.Buton_Refresh.Click += new System.EventHandler(this.Button_Refresh_Click);
            // 
            // Thread_1ms
            // 
            this.Thread_1ms.Enabled = true;
            this.Thread_1ms.Interval = 1;
            this.Thread_1ms.Tick += new System.EventHandler(this.Thread_1ms_Tick);
            // 
            // Thread_100ms
            // 
            this.Thread_100ms.Enabled = true;
            this.Thread_100ms.Tick += new System.EventHandler(this.Thread_100ms_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(681, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 80);
            this.button3.TabIndex = 53;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Button_Save
            // 
            this.Button_Save.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Save.ForeColor = System.Drawing.Color.Blue;
            this.Button_Save.Location = new System.Drawing.Point(558, 538);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(47, 60);
            this.Button_Save.TabIndex = 56;
            this.Button_Save.Text = "保存";
            this.Button_Save.UseVisualStyleBackColor = true;
            // 
            // Button_Restar
            // 
            this.Button_Restar.Font = new System.Drawing.Font("新宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Restar.ForeColor = System.Drawing.Color.Blue;
            this.Button_Restar.Location = new System.Drawing.Point(558, 446);
            this.Button_Restar.Name = "Button_Restar";
            this.Button_Restar.Size = new System.Drawing.Size(108, 40);
            this.Button_Restar.TabIndex = 54;
            this.Button_Restar.Text = "重置";
            this.Button_Restar.UseVisualStyleBackColor = true;
            this.Button_Restar.Click += new System.EventHandler(this.Button_Restar_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(545, 440);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(134, 91);
            this.button8.TabIndex = 55;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(861, 321);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 215);
            this.button5.TabIndex = 57;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Button_Start
            // 
            this.Button_Start.Font = new System.Drawing.Font("新宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_Start.ForeColor = System.Drawing.Color.Green;
            this.Button_Start.Location = new System.Drawing.Point(879, 472);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(110, 49);
            this.Button_Start.TabIndex = 58;
            this.Button_Start.Text = "开始";
            this.Button_Start.UseVisualStyleBackColor = true;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // checkBox_Follow
            // 
            this.checkBox_Follow.AutoSize = true;
            this.checkBox_Follow.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox_Follow.Location = new System.Drawing.Point(868, 329);
            this.checkBox_Follow.Name = "checkBox_Follow";
            this.checkBox_Follow.Size = new System.Drawing.Size(72, 16);
            this.checkBox_Follow.TabIndex = 62;
            this.checkBox_Follow.Text = "自动跟随";
            this.checkBox_Follow.UseVisualStyleBackColor = false;
            this.checkBox_Follow.CheckedChanged += new System.EventHandler(this.checkBox_Follow_CheckedChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(685, 409);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(169, 65);
            this.button6.TabIndex = 69;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(861, 538);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(144, 66);
            this.button10.TabIndex = 73;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(925, 385);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(54, 14);
            this.textBox3.TabIndex = 75;
            this.textBox3.Text = "  0.00";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Gainsboro;
            this.button11.Enabled = false;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(869, 381);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(129, 24);
            this.button11.TabIndex = 77;
            this.button11.Text = "当前幅度          V";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(925, 356);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(54, 14);
            this.textBox4.TabIndex = 74;
            this.textBox4.Text = "  0.0";
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Gainsboro;
            this.button12.Enabled = false;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(869, 352);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(129, 23);
            this.button12.TabIndex = 76;
            this.button12.Text = "当前时间          s";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Gainsboro;
            this.button15.Enabled = false;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(731, 444);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(118, 24);
            this.button15.TabIndex = 86;
            this.button15.Text = "点1幅度         V";
            this.button15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Gainsboro;
            this.button16.Enabled = false;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Location = new System.Drawing.Point(731, 415);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(118, 23);
            this.button16.TabIndex = 85;
            this.button16.Text = "点1时间         s";
            this.button16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(685, 474);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(169, 65);
            this.button19.TabIndex = 96;
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(685, 539);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(169, 59);
            this.button21.TabIndex = 98;
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button_Point1
            // 
            this.button_Point1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_Point1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Point1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_Point1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Point1.Image = ((System.Drawing.Image)(resources.GetObject("button_Point1.Image")));
            this.button_Point1.Location = new System.Drawing.Point(687, 414);
            this.button_Point1.Name = "button_Point1";
            this.button_Point1.Size = new System.Drawing.Size(42, 56);
            this.button_Point1.TabIndex = 99;
            this.button_Point1.Text = "点1";
            this.button_Point1.UseVisualStyleBackColor = false;
            this.button_Point1.Click += new System.EventHandler(this.button_Point1_Click);
            // 
            // button_Point2
            // 
            this.button_Point2.BackColor = System.Drawing.Color.DeepPink;
            this.button_Point2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Point2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_Point2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Point2.Image = ((System.Drawing.Image)(resources.GetObject("button_Point2.Image")));
            this.button_Point2.Location = new System.Drawing.Point(688, 478);
            this.button_Point2.Name = "button_Point2";
            this.button_Point2.Size = new System.Drawing.Size(42, 56);
            this.button_Point2.TabIndex = 100;
            this.button_Point2.Text = "点2";
            this.button_Point2.UseVisualStyleBackColor = false;
            this.button_Point2.Click += new System.EventHandler(this.button_Point2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(695, 334);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(152, 25);
            this.progressBar1.TabIndex = 101;
            // 
            // numericUpDown_Time
            // 
            this.numericUpDown_Time.Location = new System.Drawing.Point(756, 370);
            this.numericUpDown_Time.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDown_Time.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Time.Name = "numericUpDown_Time";
            this.numericUpDown_Time.Size = new System.Drawing.Size(67, 21);
            this.numericUpDown_Time.TabIndex = 102;
            this.numericUpDown_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_Time.Value = new decimal(new int[] {
            10000,
            0,
            0,
            65536});
            this.numericUpDown_Time.ValueChanged += new System.EventHandler(this.numericUpDown_Time_ValueChanged);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Gainsboro;
            this.button22.Enabled = false;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button22.Location = new System.Drawing.Point(695, 369);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(152, 23);
            this.button22.TabIndex = 103;
            this.button22.Text = "                     s";
            this.button22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button22.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.checkBox1.Location = new System.Drawing.Point(707, 373);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 104;
            this.checkBox1.Text = "定时";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button23.ForeColor = System.Drawing.Color.Blue;
            this.button23.Location = new System.Drawing.Point(620, 538);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(46, 60);
            this.button23.TabIndex = 105;
            this.button23.Text = "打开";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(545, 531);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(134, 73);
            this.button24.TabIndex = 106;
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button25.Location = new System.Drawing.Point(545, 321);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(134, 53);
            this.button25.TabIndex = 107;
            this.button25.UseVisualStyleBackColor = false;
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.Green;
            this.button26.Location = new System.Drawing.Point(869, 465);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(130, 63);
            this.button26.TabIndex = 108;
            this.button26.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(785, 449);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(45, 14);
            this.textBox5.TabIndex = 110;
            this.textBox5.Text = "  0.00";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(785, 419);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(45, 14);
            this.textBox6.TabIndex = 109;
            this.textBox6.Text = "  0.0";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(786, 514);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(45, 14);
            this.textBox1.TabIndex = 114;
            this.textBox1.Text = "  0.00";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(786, 484);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(45, 14);
            this.textBox2.TabIndex = 113;
            this.textBox2.Text = "  0.0";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Gainsboro;
            this.button7.Enabled = false;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(732, 509);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(118, 24);
            this.button7.TabIndex = 112;
            this.button7.Text = "点2幅度         V";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Gainsboro;
            this.button9.Enabled = false;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(732, 480);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(118, 23);
            this.button9.TabIndex = 111;
            this.button9.Text = "点2时间         s";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(766, 575);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(58, 14);
            this.textBox7.TabIndex = 118;
            this.textBox7.Text = "  0.00";
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(766, 549);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(58, 14);
            this.textBox8.TabIndex = 117;
            this.textBox8.Text = "  0.0";
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Gainsboro;
            this.button13.Enabled = false;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(695, 570);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(148, 24);
            this.button13.TabIndex = 116;
            this.button13.Text = "两点幅度差           V";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Gainsboro;
            this.button14.Enabled = false;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Location = new System.Drawing.Point(695, 545);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(148, 23);
            this.button14.TabIndex = 115;
            this.button14.Text = "两点时间差           s";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.UseVisualStyleBackColor = false;
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(928, 576);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(45, 14);
            this.textBox9.TabIndex = 122;
            this.textBox9.Text = "  0.00";
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(928, 551);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(45, 14);
            this.textBox10.TabIndex = 121;
            this.textBox10.Text = "  0.0";
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Gainsboro;
            this.button17.Enabled = false;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Location = new System.Drawing.Point(869, 572);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(128, 24);
            this.button17.TabIndex = 120;
            this.button17.Text = "所指幅度         V";
            this.button17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Gainsboro;
            this.button18.Enabled = false;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Location = new System.Drawing.Point(869, 547);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(128, 23);
            this.button18.TabIndex = 119;
            this.button18.Text = "所指时间         s";
            this.button18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button18.UseVisualStyleBackColor = false;
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(546, 375);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(133, 63);
            this.button27.TabIndex = 123;
            this.button27.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(559, 383);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 20);
            this.comboBox1.TabIndex = 124;
            this.comboBox1.Text = "串口选择";
            // 
            // button_Usart
            // 
            this.button_Usart.Location = new System.Drawing.Point(559, 408);
            this.button_Usart.Name = "button_Usart";
            this.button_Usart.Size = new System.Drawing.Size(108, 25);
            this.button_Usart.TabIndex = 125;
            this.button_Usart.Text = "串口配对";
            this.button_Usart.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(681, 403);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(178, 201);
            this.button20.TabIndex = 97;
            this.button20.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 607);
            this.Controls.Add(this.button_Usart);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.Button_Start);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.numericUpDown_Time);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button_Point2);
            this.Controls.Add(this.button_Point1);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.checkBox_Follow);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.Button_Restar);
            this.Controls.Add(this.DrawPanel);
            this.Controls.Add(this.Buton_Refresh);
            this.Controls.Add(this.Buton_Zero);
            this.Controls.Add(this.Bar_ZoomY);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Bar_ZoomX);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.Send_RichText);
            this.Controls.Add(this.Receive_RichText);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button25);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1025, 645);
            this.MinimumSize = new System.Drawing.Size(1025, 645);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "波形采集上位机 V1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DrawPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar_ZoomX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bar_ZoomY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Time)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.RichTextBox Send_RichText;
        private System.Windows.Forms.Button Send;
        public System.Windows.Forms.RichTextBox Receive_RichText;
        private System.Windows.Forms.NumericUpDown Bar_ZoomX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown Bar_ZoomY;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Buton_Zero;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Buton_Refresh;
        private System.Windows.Forms.Timer Thread_1ms;
        private System.Windows.Forms.Timer Thread_100ms;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Button Button_Restar;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Button_Start;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button_Point1;
        private System.Windows.Forms.Button button_Point2;
        private System.Windows.Forms.CheckBox checkBox_Follow;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Time;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_Usart;
        private System.Windows.Forms.Button button20;

 






    }
}

