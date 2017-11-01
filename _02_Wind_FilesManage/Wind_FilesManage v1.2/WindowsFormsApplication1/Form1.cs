using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;  

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        String Str_App_c = "None";
        String Str_App_h = "None";
        String Str_Drive_c = "None";
        String Str_Drive_h = "None";

        String Str_Name = "None";  
        String Str_Platform = "Keil uVision5 v5.15 (STM32F407ZG)";
        String Str_Author = "None";
        String Str_Email = "None";
        String Str_Explain = "None";

        String Str_OS_STATE = "OS_STATE_ACTIVE";
        String Str_OS_THREAD = "OS_THREAD_PRIMARY";
        int    Int_Thread_Time = 300;

        bool Flag_App = true;
        bool Flag_Drive = false;
        bool Flag_AppBack = false;
        bool Flag_AppStart = false;
        bool Flag_AppEnd = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Str_OS_STATE = comboBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Flag_App)
            {
                Create_App_c();
                Create_App_h();
            }
            if (Flag_Drive)
            { 
                Create_Drive_c(); 
                Create_Drive_h();
            }

        }

         
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Str_Name = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Str_Platform = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Str_Author = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Str_Email = textBox4.Text;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Str_Explain = richTextBox1.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Flag_App = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Flag_Drive = checkBox2.Checked;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Int_Thread_Time = Decimal.ToInt32(numericUpDown1.Value);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Str_OS_THREAD = comboBox2.Text;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Flag_AppBack = checkBox3.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Flag_AppStart = checkBox4.Checked;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            Flag_AppEnd = checkBox5.Checked;
        }




        private void Create_App_c()//创建一个App.c
        {
            Create_App_c_Str();
            FileStream fs = new FileStream(@".\\App_" + Str_Name + ".c", FileMode.Create);
            //获得字节数组
            byte[] data = System.Text.Encoding.Default.GetBytes(Str_App_c);
            //开始写入
            fs.Write(data, 0, data.Length);
            //清空缓冲区、关闭流
            fs.Flush();
            fs.Close();
        }
        private void Create_App_h()//创建一个App.h
        {
            Create_App_h_Str();
            FileStream fs = new FileStream(@".\\App_" + Str_Name + ".h", FileMode.Create);
            //获得字节数组
            byte[] data = System.Text.Encoding.Default.GetBytes(Str_App_h);
            //开始写入
            fs.Write(data, 0, data.Length);
            //清空缓冲区、关闭流
            fs.Flush();
            fs.Close();
        }


        private void Create_Drive_c()//创建一个Drive.c
        {
            Create_Drive_c_Str();
            FileStream fs = new FileStream(@".\\Drive_" + Str_Name + ".c", FileMode.Create);
            //获得字节数组
            byte[] data = System.Text.Encoding.Default.GetBytes(Str_Drive_c);
            //开始写入
            fs.Write(data, 0, data.Length);
            //清空缓冲区、关闭流
            fs.Flush();
            fs.Close();
        }
        private void Create_Drive_h()//创建一个Drive.h
        {
            Create_Drive_h_Str();
            FileStream fs = new FileStream(@".\\Drive_" + Str_Name + ".h", FileMode.Create);
            //获得字节数组
            byte[] data = System.Text.Encoding.Default.GetBytes(Str_Drive_h);
            //开始写入
            fs.Write(data, 0, data.Length);
            //清空缓冲区、关闭流
            fs.Flush();
            fs.Close();
        }  

        private void Create_App_c_Str()//填写文件内容
        {
            String Name_AppBack = "NULL";
            String Name_AppStart = "NULL";
            String Name_AppEnd = "NULL";
            if (Flag_AppBack) Name_AppBack = Str_Name + "_Back";
            if (Flag_AppStart) Name_AppStart = Str_Name + "_Start";
            if (Flag_AppEnd) Name_AppEnd = Str_Name + "_End";

            Str_App_c = "/*******************************(C) COPYRIGHT " + DateTime.Now.Year.ToString() +" "+ Str_Author + "*********************************/" + "\n"
            + "/**============================================================================" + "\n"
            + "* @FileName    : App_" + Str_Name + ".c" + "\n" 
            + "* @Date        : " + DateTime.Now.ToLongDateString().ToString() + "\n"
            + "* @By          : " + Str_Author + "\n"
            + "* @Email       : " + Str_Email + "\n"
            + "* @Platform    : " + Str_Platform + "\n"
            + "* @Explain     : " + Str_Explain + "\n"
            + "*=============================================================================*/" + "\n"
            + "\n"
            + "/* 头文件包含 ----------------------------------------------------------------*/" + "\n"
            + "#include \"App_" + Str_Name + ".h\"" + "\n" + "\n"
            + "\n"
            + "/* 私有宏定义 ----------------------------------------------------------------*/" + "\n"
            + "\n"
            + "/* 私有（静态）函数声明 ------------------------------------------------------*/" + "\n"
            + "\n"
            + "/* 全局变量定义 --------------------------------------------------------------*/" + "\n"
            + "\n"
            + "/* 全局变量声明 --------------------------------------------------------------*/" + "\n"
            + "\n"
            + "/* 全局函数编写 --------------------------------------------------------------*/" + "\n"
            + "/**----------------------------------------------------------------------------" + "\n"
            + "* @FunctionName  : " + Str_Name + "()" + "\n"
            + "* @Description   : " + Str_Explain + "\n"
            + "* @Data          : " + DateTime.Now.ToLongDateString().ToString() + "\n"
            + "* @Explain       : None" + "\n"
            + "------------------------------------------------------------------------------*/" + "\n"
            + "int " + Str_Name + "_Main(void)" + "\n"
            + "{  " + "\n" + "\n" + "\n" + "\n"
            + "    return 0;" + "\n"
            + "}	" + "\n" + "\n";

            if (Flag_AppBack)
            {
                Str_App_c += "int " + Str_Name + "_Back(void)" + "\n"
                 + "{  " + "\n" + "\n" + "\n" + "\n"
                 + "    return 0;" + "\n"
                 + "}	" + "\n" + "\n";
            }
            if (Flag_AppStart)
            {
                Str_App_c += "int " + Str_Name + "_Start(void)" + "\n"
                 + "{  " + "\n" + "\n" + "\n" + "\n"
                 + "    return 0;" + "\n"
                 + "}	" + "\n" + "\n";
            }
            if (Flag_AppEnd)
            {
                Str_App_c += "int " + Str_Name + "_End(void)" + "\n"
                 + "{  " + "\n" + "\n" + "\n" + "\n"
                 + "    return 0;" + "\n"
                 + "}	" + "\n" + "\n";
            }

            Str_App_c += "Type_AppList App_" + Str_Name + " = {" + Str_Name+ "_Main,"+ Name_AppBack + "," + Name_AppStart + "," + Name_AppEnd + ", \\"+"\n"
            + "						"+Str_OS_STATE +","+ Str_OS_THREAD +", \\" +"\n"
            + "						" + "(u8*)\"" + Str_Name +"\","+ Int_Thread_Time.ToString()+"};"+"\n"
            +"\n"
            +"\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "/*******************************(C) COPYRIGHT " + DateTime.Now.Year.ToString() + " " + Str_Author + "*********************************/" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n";
             
        }

        private void Create_App_h_Str()
        {  
            Str_App_h = "/*******************************(C) COPYRIGHT " + DateTime.Now.Year.ToString() + " " + Str_Author + " *********************************/" + "\n"
            + "/**============================================================================" + "\n"
            + "* @FileName    : App_" + Str_Name + ".h" + "\n"
            + "* @Description : None" + "\n"
            + "* @Date        : " + DateTime.Now.ToLongDateString().ToString() + "\n"
            + "* @By          : " + Str_Author + "\n"
            + "* @Email       : " + Str_Email + "\n"
            + "* @Platform    : " + Str_Platform + "\n"
            + "* @Explain     : " + Str_Explain + "\n"
            + "*=============================================================================*/" + "\n"
            + "/* 防止重调用 ----------------------------------------------------------------*/" + "\n"
            + "#ifndef __APP_" + Str_Name.ToUpper() + "_H" + "\n"
            + "#define __APP_" + Str_Name.ToUpper() + "_H" + "\n"
            + "\n"
            + "/* 头文件包含 ----------------------------------------------------------------*/" + "\n"
            + "#include \"" + "OS_StartFile" + ".h\"" + "\n" + "\n"
            + "\n"
            + "/* 全局宏定义 ----------------------------------------------------------------*/" + "\n"
            + "\n"
            + "/* 结构体声明 ----------------------------------------------------------------*/" + "\n"
            + "\n"
            + "/* 全局变量声明 --------------------------------------------------------------*/" + "\n"
            + "\n"
            + "/* 全局函数声明 --------------------------------------------------------------*/" + "\n" 
            + "extern Type_AppList App_" + Str_Name + ";"+"\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "#endif" + "\n"
            + "/*******************************(C) COPYRIGHT " + DateTime.Now.Year.ToString() + " " + Str_Author + " *********************************/" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n";


        }

        private void Create_Drive_c_Str()
        {  
            Str_Drive_c = "/*******************************(C) COPYRIGHT " + DateTime.Now.Year.ToString() + " " + Str_Author + " *********************************/" + "\n"
            + "/**============================================================================" + "\n"
            + "* @FileName    : Drive_" + Str_Name + ".c" + "\n"
            + "* @Description : None" + "\n"
            + "* @Date        : " + DateTime.Now.ToLongDateString().ToString() + "\n"
            + "* @By          : " + Str_Author + "\n"
            + "* @Email       : " + Str_Email + "\n"
            + "* @Platform    : " + Str_Platform + "\n"
            + "* @Explain     : " + Str_Explain + "\n"
            + "*=============================================================================*/" + "\n"
            + "\n"
            + "/* 头文件包含 ----------------------------------------------------------------*/" + "\n"
            + "#include \"Drive_" + Str_Name + ".h\"" + "\n" + "\n"
            + "\n"
            + "/* 私有宏定义 ----------------------------------------------------------------*/" + "\n"
            + "\n"
            + "/* 私有（静态）函数声明 ------------------------------------------------------*/" + "\n"
            + "\n"
            + "/* 全局变量定义 --------------------------------------------------------------*/" + "\n"
            + "\n"
            + "/* 全局变量声明 --------------------------------------------------------------*/" + "\n"
            + "\n"
            + "/* 全局函数编写 --------------------------------------------------------------*/" + "\n"
            + "/**----------------------------------------------------------------------------" + "\n"
            + "* @FunctionName  : " + Str_Name + "_Init(void)" + "\n"
            + "* @Description   : " + Str_Explain + "\n"
            + "* @Data          : " + DateTime.Now.ToLongDateString().ToString() + "\n"
            + "* @Explain       : None" + "\n"
            + "------------------------------------------------------------------------------*/" + "\n"
            + "int " + Str_Name + "_Init(void)" + "\n"
            + "{  " + "\n" + "\n" + "\n" + "\n"
            + "    return 0;" + "\n"
            + "}	" + "\n" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "/*******************************(C) COPYRIGHT " + DateTime.Now.Year.ToString() + " " + Str_Author + " *********************************/" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n";
        }

        private void Create_Drive_h_Str()
        {
            Str_Drive_h = "/*******************************(C) COPYRIGHT " + DateTime.Now.Year.ToString() + " " + Str_Author + " *********************************/" + "\n"
            + "/**============================================================================" + "\n"
            + "* @FileName    : Drive_" + Str_Name + ".h" + "\n"
            + "* @Description : None" + "\n"
            + "* @Date        : " + DateTime.Now.ToLongDateString().ToString() + "\n"
            + "* @By          : " + Str_Author + "\n"
            + "* @Email       : " + Str_Email + "\n"
            + "* @Platform    : " + Str_Platform + "\n"
            + "* @Explain     : " + Str_Explain + "\n"
            + "*=============================================================================*/" + "\n"
            + "/* 防止重调用 ----------------------------------------------------------------*/" + "\n"
            + "#ifndef __DRIVE_" + Str_Name.ToUpper() + "_H" + "\n"
            + "#define __DRIVE_" + Str_Name.ToUpper() + "_H" + "\n"
            + "\n"
            + "/* 头文件包含 ----------------------------------------------------------------*/" + "\n"
            + "#include \"" + "User_Library" + ".h\"" + "\n" + "\n"
            + "\n"
            + "/* 全局宏定义 ----------------------------------------------------------------*/" + "\n"
            + "\n"
            + "/* 结构体声明 ----------------------------------------------------------------*/" + "\n"
            + "\n"
            + "/* 全局变量声明 --------------------------------------------------------------*/" + "\n"
            + "\n"
            + "/* 全局函数声明 --------------------------------------------------------------*/" + "\n"
            + "int " + Str_Name + "_Init(void);" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"       + "" + "\n"
            + "" + "\n"
            + "#endif" + "\n"
            + "/*******************************(C) COPYRIGHT " + DateTime.Now.Year.ToString() + " " + Str_Author + " *********************************/" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n"
            + "" + "\n";
        }



    }
}


