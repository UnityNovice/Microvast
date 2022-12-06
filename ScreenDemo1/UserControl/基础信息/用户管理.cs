using System.Drawing;
using System.Windows.Forms;
using System;
using System.Net;
using System.Net.NetworkInformation;
using System.IO.Ports;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Sunny.UI;
using System.ComponentModel;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using System.Drawing.Printing;
using SqlSugar;
using System.Data;
using System.Reflection;
namespace Test.NewFolder1
{
    public partial class 用户管理 : UserControl
    {
        public 用户管理()
        {
            InitializeComponent();
        }
        #region 双缓冲
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;//用双缓冲绘制窗口的所有子控件
                return cp;
            }
        }
        #endregion
        #region 翻页数据定义变量
        //翻页数据变量定义
        int pageSize = 0;
        int nMax = 0;
        int PageCount = 0;
        int pagecurrent = 0;
        int ncurrent = 0;
        #endregion
        #region  datatable 中转
        System.Data.DataTable DataInfo = new System.Data.DataTable();
        #endregion
        #region  控件操作
        private void PageMinus_Click(object sender, EventArgs e)
        {
            pagecurrent--;
            if (pagecurrent < 1)
            {
                pagecurrent = 1;
                return;
            }
            else
            {
                ncurrent = pageSize * (pagecurrent - 1);
            }
            int nStartPos = 0;
            int nEndPos = 0;
            System.Data.DataTable datemp = DataInfo.Clone();
            if (pagecurrent == PageCount)
            {
                nEndPos = nMax;
            }
            else
            {
                nEndPos = pageSize * pagecurrent;
            }
            Currentpage.Text = pagecurrent.ToString();
            PageCo.Text = PageCount.ToString();
            nStartPos = ncurrent;
            for (int i = nStartPos; i < nEndPos; i++)
            {
                datemp.ImportRow(DataInfo.Rows[i]);
                ncurrent++;
                DatabaseSource.DataSource = datemp;
                DatabaseSource.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            DatabaseSource.DefaultCellStyle.Font = new System.Drawing.Font("微软雅黑", 12, FontStyle.Regular);
        }
        private void PagePlus_Click(object sender, EventArgs e)
        {
            pagecurrent++;
            if (pagecurrent > PageCount)
            {
                pagecurrent = PageCount;
                return;
            }
            else
            {
                ncurrent = pageSize * (pagecurrent - 1);
            }
            int nStartPos = 0;
            int nEndPos = 0;
            System.Data.DataTable datemp = DataInfo.Clone();
            if (pagecurrent == PageCount)
            {
                nEndPos = nMax;
            }
            else
            {
                nEndPos = pageSize * pagecurrent;
            }
            Currentpage.Text = pagecurrent.ToString();
            PageCo.Text = PageCount.ToString();
            nStartPos = ncurrent;
            for (int i = nStartPos; i < nEndPos; i++)
            {
                datemp.ImportRow(DataInfo.Rows[i]);
                ncurrent++;
                DatabaseSource.DataSource = datemp;
                DatabaseSource.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
         
            DatabaseSource.DefaultCellStyle.Font = new System.Drawing.Font("微软雅黑", 12, FontStyle.Regular);
        }
        private void PageJump_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^-?\d+\.?\d*$");//[0-9]+$");
            Match ma = reg.Match(SettingNum.Text.ToString());
            if ((ma.Success))
            {
                if (((int)(float.Parse(SettingNum.Text.ToString())) > 0) && ((int)(float.Parse(SettingNum.Text.ToString())) <= PageCount))
                {
                    int SetPageNum = Convert.ToInt16(SettingNum.Text);
                    if (SetPageNum >= 1 & SetPageNum <= PageCount)
                        pagecurrent = SetPageNum;
                    ncurrent = pageSize * (pagecurrent - 1);
                    if (SetPageNum < 1)
                    {
                        pagecurrent = 1;
                        ncurrent = pageSize * (pagecurrent - 1);
                    }
                    if (SetPageNum > PageCount)
                    {
                        pagecurrent = PageCount;
                        ncurrent = pageSize * (pagecurrent - 1);
                    }
                    int nStartPos = 0;
                    int nEndPos = 0;
                    System.Data.DataTable datemp = DataInfo.Clone();
                    if (pagecurrent == PageCount)
                    {
                        nEndPos = nMax;
                    }
                    else
                    {
                        nEndPos = pageSize * pagecurrent;
                    }
                    Currentpage.Text = pagecurrent.ToString();
                    PageCo.Text = PageCount.ToString();
                    nStartPos = ncurrent;
                    for (int i = nStartPos; i < nEndPos; i++)
                    {
                        datemp.ImportRow(DataInfo.Rows[i]);
                        ncurrent++;
                        DatabaseSource.DataSource = datemp;
                        DatabaseSource.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    }
                  
                    DatabaseSource.DefaultCellStyle.Font = new System.Drawing.Font("微软雅黑", 12, FontStyle.Regular);
                }
                else
                {
                    MessageBox.Show("输入页码超出范围！");
                    SettingNum.Text = "";
                }
            }
            else
            {
                MessageBox.Show("输入页码不是数字！");
                SettingNum.Text = "";
            }
        }
        private void DataBase_Display(int f)
        {
          
        }
        private void 查询_Click(object sender, EventArgs e)
        {
            SqlSugarHelper sqlSugarHelper = new SqlSugarHelper();
            var res = sqlSugarHelper.db.Queryable<基础物料信息表>().ToList();
            DataInfo.Clear();
            DataInfo = ListToTable<基础物料信息表>(res, false);
            // DataInfo = res[];
            // this.DatabaseSource.DataSource = res;
            //  DataInfo = (DatabaseSource.DataSource as DataTable);
            InitDataSet();
        }
        private void 导出_Click(object sender, EventArgs e)
        {
        }
        #endregion
        #region 数据操作函数
        /// <summary>
        /// List集合转DataTable
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="list">传入集合</param>
        /// <param name="isStoreDB">是否存入数据库DateTime字段，date时间范围没事，取出展示不用设置TRUE</param>
        /// <returns>返回datatable结果</returns>
        public static DataTable ListToTable<T>(List<T> list, bool isStoreDB = true)
        {
            Type tp = typeof(T);
            PropertyInfo[] proInfos = tp.GetProperties();
            DataTable dt = new DataTable();
            foreach (var item in proInfos)
            {
                dt.Columns.Add(item.Name, item.PropertyType); //添加列明及对应类型
            }
            foreach (var item in list)
            {
                DataRow dr = dt.NewRow();
                foreach (var proInfo in proInfos)
                {
                    object obj = proInfo.GetValue(item);
                    if (obj == null)
                    {
                        continue;
                    }
                    //if (obj != null)
                    // {
                    if (isStoreDB && proInfo.PropertyType == typeof(DateTime) && Convert.ToDateTime(obj) < Convert.ToDateTime("1753-01-01"))
                    {
                        continue;
                    }
                    // dr[proInfo.Name] = proInfo.GetValue(item);
                    dr[proInfo.Name] = obj;
                    // }
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }
        //初始化数据界面显示
        private void InitDataSet()
        {
            pageSize = 25;
            nMax = DataInfo.Rows.Count;
            PageCount = (nMax / pageSize);
            if ((nMax % pageSize) > 0) PageCount++;
            pagecurrent = 1;
            ncurrent = 0;
            int nStartPos = 0;
            int nEndPos = 0;
            System.Data.DataTable datemp = DataInfo.Clone();
            if (pagecurrent == PageCount)
            {
                nEndPos = nMax;
            }
            else
            {
                nEndPos = pageSize * pagecurrent;
            }
            Currentpage.Text = pagecurrent.ToString();
            PageCo.Text = PageCount.ToString();
            nStartPos = ncurrent;
            for (int i = nStartPos; i < nEndPos; i++)
            {
                datemp.ImportRow(DataInfo.Rows[i]);
                ncurrent++;
                DatabaseSource.DataSource = datemp;
                DatabaseSource.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
          
            DatabaseSource.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            // DatabaseSource.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            // DatabaseSource.Columns[0].DefaultCellStyle.Format = "yy-MM-dd HH:mm:ss";
            // DatabaseSource.Columns[0].Width = 250;
            DatabaseSource.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("微软雅黑", 14, FontStyle.Regular);
            DatabaseSource.ColumnHeadersHeight = 50;
            DatabaseSource.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            for (int k = 0; k < DatabaseSource.Columns.Count; k++)
            {
                DatabaseSource.Columns[k].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            // DatabaseSource.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(15, 64, 130);
            //   DatabaseSource.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //  DatabaseSource.DefaultCellStyle.Font = new System.Drawing.Font("微软雅黑", 12, FontStyle.Regular);
            // int a = Search_OKNG();
        }
        #endregion
    }
}
