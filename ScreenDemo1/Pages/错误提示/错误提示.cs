using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ScreenDemo1.Pages.错误提示
{
    public partial class 错误提示 : UIForm
    {
        public 错误提示()
        {
            InitializeComponent();
        }
        public 错误提示(string msg)
        {
            InitializeComponent();
            WriteErrorMsg("发生时间：" + DateTime.Now.ToString("yyyy_MM_dd HH:mm:ss")+"    " + msg);
        }
        public void WriteErrorMsg(string msg)
        {
            this.uiRichTextBox1.Text = msg;
            SetLogTx(msg);
        }
        public void SetLogTx(string logmsg)
        {
            //文件名
            DateTime dt = DateTime.Now;
            string filename = dt.ToString("yyyyMMdd") + ".log";
            string path = System.AppDomain.CurrentDomain.BaseDirectory + "log\\Err\\";
            DeleteOldFiles(path, 7);
            //没有则创建，同一天不创建多个
            FileStream fs;
            //判断文件是否存在
            if (!File.Exists(path))
            {
                //创建文件
                try
                {
                    Directory.CreateDirectory(path);
                }
                catch (Exception e)
                {
                }
            }
            if (!File.Exists(path + filename))
            {
                fs = new FileStream(path + filename, FileMode.Create, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(path + filename, FileMode.Open, FileAccess.Write);
            }
            //追加写入
            StreamWriter sw = new StreamWriter(fs);
            long fl = fs.Length;
            fs.Seek(fl, SeekOrigin.Begin);
            sw.WriteLine("\r\n\r\n" + logmsg);//开始写入值
            //结束
            sw.Close();
            fs.Close();
        }
        void DeleteOldFiles(string dir, int days)
        {
            try
            {
                if (!Directory.Exists(dir) || days < 1) return;
                var now = DateTime.Now;
                foreach (var f in Directory.GetFileSystemEntries(dir).Where(f => File.Exists(f)))
                {
                    var t = File.GetLastWriteTimeUtc(f);
                    // var t = File.GetCreationTime(f);
                    var elapsedTicks = now.Ticks - t.Ticks;
                    var elapsedSpan = new TimeSpan(elapsedTicks);
                    if (elapsedSpan.TotalDays > days) File.Delete(f);
                }
            }
            catch (Exception ex)
            {
                // ignored
            }
        }
    }
}
