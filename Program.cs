using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyCSharp
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException; //捕获UI线程异常
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException; //捕获多线程异常
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }

        //在这里处理UI线程异常
        //注意：Application_ThreadException方法执行完成后，应用程序仍会继续运行
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.ToString());
        }

        //在这里处理多线程异常
        //注意：CurrentDomain_UnhandledException方法执行完成后，应用程序就会被终止
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show(((Exception)e.ExceptionObject).ToString());
        }

        //测试抛出异常的效果
        public static void TestException()
        {
            System.Threading.Thread t = new System.Threading.Thread((System.Threading.ThreadStart)delegate
            {
                throw new Exception("非窗体线程异常");
            });
            t.Start();
            throw new Exception("窗体线程异常");
        }

    }
}
