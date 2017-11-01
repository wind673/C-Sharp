/*******************************(C) COPYRIGHT 2016 Wind（谢玉伸）*********************************/
/**============================================================================
* @FileName    : Usart.cs
* @Description : 串口线程
* @Date        : 2016/9/25
* @By          : Wind（谢玉伸）
* @Email       : 1659567673@ qq.com
* @Platform    : VS2012 (.NET4.5)
* @Explain     : None
*=============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WINCC_WaveDraw
{
    public class Usart
    {
        /**-----------------------------------------------------------------------------
         * @FunctionName  : Usart_Main()     
         * @Description   : 串口线程主程序
         * @Data          : 2016/9/25
         * @Explain       : None
         ------------------------------------------------------------------------------*/
        public static void Usart_Main()
        {
            SimulateData_Creat();
            //while (true)
            //{

            //}
        
        }


        /**-----------------------------------------------------------------------------
         * @FunctionName  : SimulateData_Creat()     
         * @Description   : 产生模拟数据
         * @Data          : 2016/9/25
         * @Explain       : 产生16位，-10~10V,正弦交流信号
         ------------------------------------------------------------------------------*/
        public static void SimulateData_Creat()
        {
            for (int i = 0; i < Form1.POINT_LENTH; i++)
            {
                Form1.UsartBuff[i] = (int)((Math.Sin(i * 2.0f * Form1.PI / 1000)) * Form1.ADC_FACTOR / 2.0f  /2.5f) + Form1.ADC_FACTOR/2;  


            } 
        }

        /**-----------------------------------------------------------------------------
         * @FunctionName  : Data_Exchange()     
         * @Description   : 数据转换
         * @Data          : 2016/9/26
         * @Explain       : None
         ------------------------------------------------------------------------------*/
        public static void Data_Exchange()
        {
            double[] RealBuff = new double[(int)(Form1.Usart_Cnt * Form1.Grid_X / Form1.ZOOM_X) + Form1.USART_LENTH];
            int[] PointBuff = new int[(int)(Form1.Usart_Cnt * Form1.Grid_X / Form1.ZOOM_X) + Form1.USART_LENTH];


            for (int i = 0; i < Form1.USART_LENTH; i++)//进制转换成真实值
            {
                RealBuff[i] = Form1.UsartBuff[i] * Form1.ADC_VPP / Form1.ADC_FACTOR - Form1.ADC_VPP / 2.0f;
                Form1.UsartRealBuff[i] = RealBuff[i];
            }

            for (int i = 0; i < Form1.Usart_Cnt; i++)//真实值转画板比例
            {  
                 PointBuff[i] = (int)(RealBuff[(int)(i * Form1.Grid_X / Form1.ZOOM_X)] * Form1.ZOOM_Y / Form1.Grid_Y);
                  
            }  

            for (int i = 0; i < Form1.POINT_LENTH; i++)//真实值转画板比例
            {
                Form1.LinePoints[i] = new Point(i, Form1.PANEL_HEIGH / 2 - PointBuff[i] - 1); //转存至画板，等待更新 
            }

            if (Form1.Restart_Flag)//重启
            {
                Form1.StartX = 0.0f;//起点坐标
                Form1.StartY = 0.0f;
                Form1.Usart_Cnt = 0;
                Form1.Grid_X = 10.0f;//每格10s
                Form1.Grid_Y = 1.0f;//每格1v

                Form1.Position_Flag = 0;
                Form1.Position_X1 = -10;
                Form1.Position_Y1 = -10;
                Form1.Position_X2 = -10;
                Form1.Position_Y2 = -10;

                Form1.SystemFirst_Flag = true;
                Form1.TimerLock_Flag = false;//定时标志
                Form1.Follow_Flag = false;
                Form1.Start_Flag = false;

                for (int i = 0; i < Form1.Usart_Cnt; i++)
                {
                    Form1.LinePoints[i] = new Point(i, Form1.PANEL_HEIGH / 2 - 1);
                    Form1.UsartBuff[i] = 0;
                    Form1.UsartRealBuff[i] = 0; 
                }

                Form1.Refresh_Flag = true;
                Form1.Restart_Flag = false; 

            }

        }


    }
}






/*******************************(C) COPYRIGHT 2016 Wind（谢玉伸）*********************************/













