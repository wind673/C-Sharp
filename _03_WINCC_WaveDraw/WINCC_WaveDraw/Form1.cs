/*******************************(C) COPYRIGHT 2016 Wind（谢玉伸）*********************************/
/**============================================================================
* @FileName    : From1.cs
* @Description : 主界面触发函数文件
* @Date        : 2016/9/25
* @By          : Wind（谢玉伸）
* @Email       : 1659567673@ qq.com
* @Platform    : VS2012 (.NET4.5)
* @Explain     : None
*=============================================================================*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;


namespace WINCC_WaveDraw
{

    public partial class Form1 : Form
    {

        /* 设置固态参量 -------------------------------------*/
        public const int USART_LENTH = 30002;    //串口总数据长度
        public const int POINT_LENTH = 30002;   //画点的总点数
        public const double PI = 3.1415926f;
        public const int ADC_FACTOR = 65535;    //ADC精度,16位
        public const double ADC_VPP = 10.0f;      //ADC峰峰值
        public const int PANEL_HEIGH = 2962;      //画板高度
        public const double ZOOM_X = 3.80f;     //缩放系数
        public const double ZOOM_Y = 74.0f;

        /* 定义静态全局变量 ---------------------------------*/
        public static int[] UsartBuff = new int[USART_LENTH];
        public static double[] UsartRealBuff = new double[USART_LENTH];

        public static double StartX = 0.0f;//起点坐标
        public static double StartY = 0.0f;
        public static int Usart_Cnt = 0;
        public static double Grid_X = 10.0f;//每格10s
        public static double Grid_Y = 1.0f;//每格1v

        public static string Send_RichText_Str = "";
        public static string Receive_RichText_Str = "";
        public static Point[] LinePoints = new Point[POINT_LENTH];

        public static bool Follow_Flag = false;
        public static bool Start_Flag = false;
        public static bool SystemFirst_Flag = true;
        public static bool TimerLock_Flag = false;//定时标志
        public static bool TimerLockFirst_Flag = true; 
        public static bool Restart_Flag = false;
        public static bool Refresh_Flag = false; 

        public static int Position_Flag = 0;
        public static double Position_X1 = -10;
        public static double Position_Y1 = -10;
        public static double Position_X2 = -10;
        public static double Position_Y2 = -10;

        public static double TimerLock_Value = 0;

        public Form1()
        {
            InitializeComponent();

        }


        /**-----------------------------------------------------------------------------
         * @FunctionName  : Form1
         * @Description   : 刷新后初始事件
         * @Data          : 2016/9/25
         * @Explain       : None
         ------------------------------------------------------------------------------*/
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DrawPanel_Paint(object sender, PaintEventArgs e)
        {
            if (SystemFirst_Flag)
            {
                DrawPanel.VerticalScroll.Value = (int)(PANEL_HEIGH * 0.45);//设置X轴零点的起点
                DrawPanel.AutoScrollPosition = new Point((int)(Usart_Cnt * ZOOM_X / Grid_X) - 800, -DrawPanel.AutoScrollPosition.Y);
                SystemFirst_Flag = false;
            }
        }


        /**-----------------------------------------------------------------------------
         * @FunctionName  : RichText_TextChanged()
         * @Description   : 文字框
         * @Data          : 2016/9/25
         * @Explain       : 文字框事件响应
         ------------------------------------------------------------------------------*/
        private void Receive_RichText_TextChanged(object sender, EventArgs e)
        {
            /* 滚动条自动跟随至末尾 --------------------*/
            Receive_RichText.Select(Receive_RichText.TextLength, 0);
            Receive_RichText.ScrollToCaret();

        }

        private void Send_RichText_TextChanged(object sender, EventArgs e)
        {
            Send_RichText_Str = this.Send_RichText.Text;

            /*清屏指令 --------------------------------------------*/
            if (this.Send_RichText.Text.IndexOf("\n") > -1)
            {
                Receive_RichText_Str = ("root: " + Send_RichText_Str);
                this.Receive_RichText.Text += Receive_RichText_Str;
                if (this.Send_RichText.Text.IndexOf("cls") > -1 || this.Send_RichText.Text.IndexOf("CLS") > -1)
                {
                    this.Receive_RichText.Text = "";
                    Receive_RichText_Str = "";
                }

                this.Send_RichText.Text = "";
                Send_RichText_Str = "";
            }
        }





        /**----------------------------------------------------------------------------
        * @FunctionName  : Thread_Tick()
        * @Description   : 线程
        * @Data          : 2016/9/25
        * @Explain       : 用来响应各种事件
        ------------------------------------------------------------------------------*/
        private void Thread_1ms_Tick(object sender, EventArgs e)
        {
            if (Usart_Cnt < USART_LENTH - 1)
                if (Start_Flag) Usart_Cnt++;

            if (Refresh_Flag)
            {
                this.Refresh();
                Refresh_Flag = false;
            }

        }


        private void Thread_100ms_Tick(object sender, EventArgs e)
        {
            Graphics DrawGraphics = pictureBox1.CreateGraphics();
            int NowLenth_X = (int)(Usart_Cnt * ZOOM_X / Grid_X);
            if (NowLenth_X < 2) NowLenth_X = 2;

            Point[] LinePointBuff = new Point[NowLenth_X];
            Point[] LineZeroBuff = new Point[2];


            /* 画零点的线 -------------------------------------*/
            Pen ZeroPen = new Pen(Color.Black, 3);
            LineZeroBuff[0] = new Point(0, Form1.PANEL_HEIGH / 2 - 1);
            LineZeroBuff[1] = new Point(POINT_LENTH, Form1.PANEL_HEIGH / 2 - 1);
            ZeroPen.DashStyle = DashStyle.Dash;
            DrawGraphics.DrawLines(ZeroPen, LineZeroBuff); //画零点


            /* 更新数据 ---------------------------------------*/
            Usart.Data_Exchange();


            /* 画波形 -----------------------------------------*/
            for (int i = 0; i < (int)(Usart_Cnt * ZOOM_X / Grid_X); i++)
            {
                if (i < POINT_LENTH)
                    LinePointBuff[i] = LinePoints[i];
            }
            Pen GreenPen = new Pen(Color.Lime, 2);
            DrawGraphics.DrawLines(GreenPen, LinePointBuff);//画波形

            /* 显示当前状态 -----------------------------------*/
            textBox4.Text = (Usart_Cnt / 10.0f).ToString("f1").PadLeft(7, ' ');
            textBox3.Text = UsartRealBuff[Usart_Cnt].ToString("f2").PadLeft(7, ' ');

            /* 自动跟随 ---------------------------------------*/
            if (Follow_Flag)
            {
                DrawPanel.AutoScrollPosition = new Point((int)(Usart_Cnt * ZOOM_X / Grid_X) - 800, -DrawPanel.AutoScrollPosition.Y);  //自动跟随
                //Receive_RichText.Text = Receive_RichText.Text + " ( " + (Usart_Cnt / 10.0f).ToString("f1") + " , " + UsartRealBuff[Usart_Cnt].ToString("f2") + " ) ";
            }

            Icon icon1 = new Icon("C:/Position1.ico");
            Icon icon2 = new Icon("C:/Position2.ico");
            DrawGraphics.DrawIcon(icon1, (int)(Position_X1 * ZOOM_X * 10.0f / Grid_X) - 8, (int)(PANEL_HEIGH / 2 - 1 - Position_Y1 * ZOOM_Y / 2 / Grid_Y) - 8);
            DrawGraphics.DrawIcon(icon2, (int)(Position_X2 * ZOOM_X * 10.0f / Grid_X) - 8, (int)(PANEL_HEIGH / 2 - 1 - Position_Y2 * ZOOM_Y / 2 / Grid_Y) - 8);

            if (TimerLock_Flag && Start_Flag)
            {
                if ((double)numericUpDown_Time.Value * 10.0f >= Usart_Cnt)
                {
                    if (TimerLockFirst_Flag)
                    { 
                        Receive_RichText_Str = ("System: " + "正在进行数据采集，请稍后...") + "\n";
                        this.Receive_RichText.Text += Receive_RichText_Str;
                        TimerLockFirst_Flag = false;
                    }
                    progressBar1.Value = (int)(Usart_Cnt * 100.0f / ((double)numericUpDown_Time.Value * 10.0f));
                }
                else 
                {
                    progressBar1.Value = 100;
                    Receive_RichText_Str = ("System: " + "数据采集完毕！！！") + "\n";
                    this.Receive_RichText.Text += Receive_RichText_Str;
                    progressBar1.Value = 0;  


                    checkBox1.Checked = false;
                    checkBox_Follow.Checked = false;
                    Button_Start.Text = "开始";
                    Button_Start.ForeColor = Color.Green;
                    button26.BackColor = Color.Green;

                    TimerLockFirst_Flag = true;
                    TimerLock_Flag = false;
                    Form1.TimerLock_Flag = false;//定时标志
                    Form1.Follow_Flag = false;
                    Form1.Start_Flag = false;
                    Form1.Refresh_Flag = true;

                }
            
            }
        }


        /**----------------------------------------------------------------------------
        * @FunctionName  : numericUpDown
        * @Description   : 数值框
        * @Data          : 2016/9/25
        * @Explain       : 数值框响应事件
        ------------------------------------------------------------------------------*/
        /* Y轴缩放 -------------------------------*/
        private void Bar_ZoomY_ValueChanged(object sender, EventArgs e)
        {
            Grid_Y = (double)Bar_ZoomY.Value;
            this.Refresh();
        }

        /* X轴缩放 -------------------------------*/
        private void Bar_ZoomX_ValueChanged(object sender, EventArgs e)//缩放值
        {
            Grid_X = (double)Bar_ZoomX.Value;
            this.Refresh();
        }

        /* 定时器 -------------------------------*/
        private void numericUpDown_Time_ValueChanged(object sender, EventArgs e)
        {
            TimerLock_Value = (double)numericUpDown_Time.Value;

        }

        /**----------------------------------------------------------------------------
        * @FunctionName  : checkBox
        * @Description   : 选择框
        * @Data          : 2016/9/25
        * @Explain       : 选择框响应事件
        ------------------------------------------------------------------------------*/
        /* 自动跟随 -------------------------------*/
        private void checkBox_Follow_CheckedChanged(object sender, EventArgs e)
        {
            Follow_Flag = checkBox_Follow.Checked;
        }

        /* 定时 -----------------------------------*/
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            TimerLock_Flag = checkBox1.Checked;

        }



        /**----------------------------------------------------------------------------
        * @FunctionName  : Mouse
        * @Description   : 鼠标
        * @Data          : 2016/9/25
        * @Explain       : 鼠标响应事件
        ------------------------------------------------------------------------------*/
        /* 鼠标在画板上移动 ---------------------------*/
        private void Mouse_Move_DrawPanel(object sender, MouseEventArgs e)
        {
            textBox10.Text = ((double)(e.X * Grid_X / ZOOM_X / 10.0f)).ToString("f1").PadLeft(6, ' ');
            textBox9.Text = ((double)(((PANEL_HEIGH / 2 - e.Y - 1) * Grid_Y) / ZOOM_Y * 2.0)).ToString("f2").PadLeft(6, ' ');

        }

        /* 鼠标点击画板 -------------------------------*/
        private void Mouse_Click_DrawPanel(object sender, MouseEventArgs e)
        {
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;

            if (Position_Flag == 1)
            {
                Position_X1 = ((double)(e.X * Grid_X / ZOOM_X / 10.0f));
                Position_Y1 = ((double)(((PANEL_HEIGH / 2 - e.Y - 1) * Grid_Y) / ZOOM_Y * 2.0));

                textBox6.Text = Position_X1.ToString("f1").PadLeft(6, ' ');
                textBox5.Text = Position_Y1.ToString("f2").PadLeft(6, ' ');

                this.Refresh();
            }
            else if (Position_Flag == 2)
            {
                Position_X2 = ((double)(e.X * Grid_X / ZOOM_X / 10.0f));
                Position_Y2 = ((double)(((PANEL_HEIGH / 2 - e.Y - 1) * Grid_Y) / ZOOM_Y * 2.0));

                textBox2.Text = Position_X2.ToString("f1").PadLeft(6, ' ');
                textBox1.Text = Position_Y2.ToString("f2").PadLeft(6, ' ');

                this.Refresh();
            }

            textBox8.Text = (Position_X2 - Position_X1).ToString("f1").PadLeft(6, ' ');
            textBox7.Text = (Position_Y2 - Position_Y1).ToString("f2").PadLeft(6, ' ');

            Position_Flag = 0;

        }


        /**----------------------------------------------------------------------------
        * @FunctionName  : Button
        * @Description   : 按钮
        * @Data          : 2016/9/25
        * @Explain       : 按钮响应事件
        ------------------------------------------------------------------------------*/
        /* 开始 -----------------------------------*/
        private void Button_Start_Click(object sender, EventArgs e)
        {
            if (Start_Flag) Start_Flag = false;
            else Start_Flag = true;

            if (Start_Flag)
            {
                Button_Start.Text = "停止";
                Button_Start.ForeColor = Color.Black;
                button26.BackColor = Color.Black;   
            }
            else
            {
                Button_Start.Text = "开始";
                Button_Start.ForeColor = Color.Green;
                button26.BackColor = Color.Green;
            }

        }

        /* 刷新 -----------------------------------*/
        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            DrawPanel.VerticalScroll.Value = (int)(PANEL_HEIGH * 0.45);//设置X轴零点的起点
            DrawPanel.AutoScrollPosition = new Point((int)(Usart_Cnt * ZOOM_X / Grid_X) - 800, -DrawPanel.AutoScrollPosition.Y);
            this.Refresh();
        }

        /* 置0 -----------------------------------*/
        private void Button_Zero_Click(object sender, EventArgs e)
        {

        }


        //[DllImport("User32")]
        //public extern static void SetCursor(int x,int y);

        /* 选点1 -----------------------------------*/
        private void button_Point1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            Bitmap MyBitmap = new Bitmap("C:/Position1.ico");
            Cursor Mycursor = new Cursor(MyBitmap.GetHicon());
            this.pictureBox1.Cursor = Mycursor;
            Position_Flag = 1;

        }

        /* 选点2 -----------------------------------*/
        private void button_Point2_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            Bitmap MyBitmap = new Bitmap("C:/Position2.ico");
            Cursor Mycursor = new Cursor(MyBitmap.GetHicon());
            this.pictureBox1.Cursor = Mycursor;
            Position_Flag = 2;

        }

        /* 发送 -----------------------------------*/
        private void Send_Click(object sender, EventArgs e)
        {
            /*加上头部 --------------------------------------------*/
            Receive_RichText_Str = ("root: " + Send_RichText_Str) + "\n";
            this.Receive_RichText.Text += Receive_RichText_Str;

            /*清屏指令 --------------------------------------------*/
            if (this.Send_RichText.Text.IndexOf("cls") > -1 || this.Send_RichText.Text.IndexOf("CLS") > -1)
            {
                this.Receive_RichText.Text = "";
                Receive_RichText_Str = "";
            }

            this.Send_RichText.Text = "";
            Send_RichText_Str = "";

        }

        /* 重启 -----------------------------------*/
        private void Button_Restar_Click(object sender, EventArgs e)
        {
            Restart_Flag = true;

            progressBar1.Value = 0;
            numericUpDown_Time.Value = 1000;

            checkBox1.Checked = false;
            checkBox_Follow.Checked = false;

            Button_Start.Text = "开始";
            Button_Start.ForeColor = Color.Green;
            button26.BackColor = Color.Green;
             
        }























    }
}






/*******************************(C) COPYRIGHT 2016 Wind（谢玉伸）*********************************/




