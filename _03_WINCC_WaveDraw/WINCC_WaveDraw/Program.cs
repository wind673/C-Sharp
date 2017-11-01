using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; 

namespace WINCC_WaveDraw
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        ///   
        [STAThread]
        static void Main()
        {
            Thread Thread_Draw = new Thread(new ThreadStart(Usart.Usart_Main));//开启线程
            Thread_Draw.Start(); 

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Thread_Draw.Abort();//结束线程
        }
    }
}
