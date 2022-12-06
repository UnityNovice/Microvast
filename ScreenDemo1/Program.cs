using ScreenDemo1.Pages.错误提示;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test;
namespace ScreenDemo1
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool isRuned;
            System.Threading.Mutex mutex = new System.Threading.Mutex(true, "Test", out isRuned);
            if (isRuned)
            {
                try
                {
                    //设置应用程序处理异常方式：ThreadException处理
                    Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
                    //UI线程的未处理异常捕获
                    Application.ThreadException += Application_ThreadException;
                    //非UI线程的未处理异常捕获
                    AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new 登录());
                    //Application.Run(new Form1());
                }
                catch (Exception ex)
                {
                    错误提示 错误提示 = new 错误提示(ex.ToString());
                }
                
            }
            else
            {
                MessageBox.Show("程序已启动，请勿重复启动");
            }
        }
        /// <summary>
        /// UI线程未捕获异常处理函数
        /// </summary>
        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            try
            {
                错误提示 错误提示 = new 错误提示(e.Exception.ToString());
                错误提示.ShowDialog();
            }
            catch (Exception ex)
            {
                错误提示 错误提示 = new 错误提示(ex.ToString());
                错误提示.ShowDialog();
            }
        }
        /// <summary>
        /// 非UI线程未捕获异常处理函数
        /// </summary>
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                string msg;
                if (e.ExceptionObject is Exception ex)
                {
                    错误提示 错误提示 = new 错误提示(ex.ToString());
                    错误提示.ShowDialog();
                }
                else
                {
                    错误提示 错误提示 = new 错误提示(e.ExceptionObject.ToString());
                    错误提示.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                错误提示 错误提示 = new 错误提示(ex.ToString());
                错误提示.ShowDialog();
            }
        }
    }
}
