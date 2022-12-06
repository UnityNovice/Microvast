using Microvast.Common.Utils;
using Microvast.Common.Vuex;
using ScreenDemo1.Components.通用弹窗;
using ScreenDemo1.Properties;
using SqlSugar;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test;
using Microvast.Common.Utils;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using S7.Net.Types;
using System.Collections;
namespace ScreenDemo1.Pages.基础信息
{
    public partial class 数采报表 : UserControl
    {
        public string Tablename = "MicroVastProcessProperty";
        public string Codename = "bar_no";
        public string Timename = "do_time";
        private string Csvpath = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
        IniReadWrite Setting = new IniReadWrite();
        public 数采报表()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="TempTablename"></param>表名
        /// <param name="TempCodename"></param>码名
        /// <param name="TempTimename"></param>时间名
        public 数采报表(string TempTablename, string TempCodename, string TempTimename)
        {
            InitInfo(TempTablename);
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
        private void DealColumnName()
        {
            DataTable dt = new DataTable();
            if (DataInfo != null)
            {
                // column
                DataInfo.Columns["bar_no"].ColumnName = "批次号";
                DataInfo.Columns["vou_no"].ColumnName = "工单";
                DataInfo.Columns["process_no"].ColumnName = "工序";
                DataInfo.Columns["do_time"].ColumnName = "时间";
                DataInfo.Columns["ok_flag"].ColumnName = "合格标志";
                DataInfo.Columns["ng_msg"].ColumnName = "NG原因";
                DataInfo.Columns["user_id"].ColumnName = "操作者工号";
                DataInfo.Columns.Remove("item_no");
                DataInfo.Columns.Remove("flag");
                DataInfo.Columns.Remove("eqpt_loc_id");
                DataInfo.Columns.Remove("major_state");
                DataInfo.Columns.Remove("second_state");
                DataInfo.Columns.Remove("aux_state");
                //  DataInfo.Columns.Remove("item_no");
                for (int i = Form1.mainForm.limitDatas.Count + 1; i < 101; i++)
                {
                    DataInfo.Columns.Remove("data" + i.ToString("000"));
                }
                if (Form1.mainForm.limitDatas != null)
                {
                    for (int a = 0; a < Form1.mainForm.limitDatas.Count; a++)
                    {
                        KeyValuePair<string, LimitData> kv = Form1.mainForm.limitDatas.ElementAt(a);
                        string key = kv.Key;
                        LimitData value = kv.Value;
                        // Console.WriteLine($"key={key},value={dict[key]}");
                        if ("data" + (a + 1).ToString("000") == value.data_no)
                            DataInfo.Columns["data" + (a + 1).ToString("000")].ColumnName = value.data_name;
                    }
                }
                //   do_time
            }
        }
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
        private void 查询1_Click(object sender, EventArgs e)
        {
            SqlSugarServerHelper sqlSugarHelper = new SqlSugarServerHelper();
            var res = sqlSugarHelper.db.Queryable<基础物料信息表>().ToList();
            DataInfo.Clear();
            //  DataInfo = ListToTable<基础物料信息表>(res, false);
            //  DataInfo = res[];
            //  this.DatabaseSource.DataSource = res;
            //  DataInfo = (DatabaseSource.DataSource as DataTable);
            InitDataSet();
        }
        private void 导出_Click(object sender, EventArgs e)
        {
            string Excelpath = Tablename + "(" + System.DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ")";
            System.Windows.Forms.FolderBrowserDialog folder = new System.Windows.Forms.FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                //  Excelpath = folder.SelectedPath;
                Csvpath = folder.SelectedPath + "\\" + Excelpath + ".csv";
            }
            else
            {
                return;
            }
            ThreadStart thStart = new ThreadStart(exportCsv); // threadStart委托 
            Thread thread = new Thread(thStart);
            thread.Priority = ThreadPriority.Highest;
            thread.IsBackground = true; //关闭窗体继续执行
            thread.Start();
        }
        #endregion
        #region 初始化数据界面显示
        //初始化数据界面显示
        private void InitDataSet()
        {
            DealColumnName();
            pageSize = 50;
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
            if (PageCount == 0) nEndPos = nMax;
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
            DatabaseSource.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            DatabaseSource.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            DatabaseSource.DefaultCellStyle.ForeColor = Color.Black;
            // int a = Search_OKNG();
            if (PageCount == 0)
            {
                DataTable dt = this.DatabaseSource.DataSource as DataTable;
                if (dt != null) dt.Rows.Clear();
                this.DatabaseSource.DataSource = dt;
            }
        }
        #endregion
        public void InitInfo(string name)
        {
            SqlSugarServerHelper sqlSugarServerHelper = new SqlSugarServerHelper();
            string sql = "";
            sql = $"select Top 100000* from {Tablename}  order by id desc";
            var dt = sqlSugarServerHelper.db.Ado.GetDataTable(sql);
            DataInfo.Clear();
            DataInfo = dt;
            //   this.DatabaseSource.DataSource = dt;
            if (dt.Rows.Count != 0)
            {
                InitDataSet();
            }
            else
            {
                InitDataSet();
                MessageBox.Show("未检索到数据！");
            }
        }
        private void 新增_Click(object sender, EventArgs e)
        {
            通用弹窗 通用弹窗 = new 通用弹窗(this.Tablename);
            通用弹窗.ShowDialog();
        }
        private void 删除_Click(object sender, EventArgs e)
        {
            if (this.Tablename == "生产工单")
            {
                MessageBox.Show("无法删除工单数据");
                return;
            }
            DialogResult dr = MessageBox.Show("请确认是否删除!!!", "删除提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                SqlSugarServerHelper sqlSugarServerHelper = new SqlSugarServerHelper();
                //获取Id值
                int Id = Convert.ToInt32(this.DatabaseSource.CurrentRow.Cells[0].Value);
                sqlSugarServerHelper.db.Ado.ExecuteCommand($"delete from {Tablename} where Id={Id}");
                MessageBox.Show("已删除");
                InitInfo(this.Tablename);
            }
        }
        private void 修改_Click(object sender, EventArgs e)
        {
            //获取Id值
            int Id = Convert.ToInt32(this.DatabaseSource.CurrentRow.Cells[0].Value);
            if (this.Tablename == "生产工单")
            {
                int a = DatabaseSource.CurrentRow.Index;
                string str = DatabaseSource.CurrentRow.Cells[14].Value.ToString();
                if (str.IndexOf("未生产") > -1 || str.IndexOf("暂停中") > -1)
                {
                }
                else
                {
                    MessageBox.Show("无法修改生产中或者暂停中的工单数据");
                    return;
                }
            }
            通用弹窗 通用弹窗 = new 通用弹窗(this.Tablename, Id, 2);
            通用弹窗.ShowDialog();
        }
        private void CodeQureybtn_Click(object sender, EventArgs e)
        {
            SqlSugarServerHelper sqlSugarServerHelper = new SqlSugarServerHelper();
            string sql = "";
            if (ProcessNoComboBox.Text == "")
            {
                sql = $"select  * from {Tablename} where " + Codename + " = '" + CodeNameTxt.Text.ToString() + "' order by id desc";
            }
            else
            {
                sql = $"select  * from {Tablename} where process_no =  '" + ProcessNoComboBox.Text.ToString() + "' AND " + Codename + "='" + CodeNameTxt.Text.ToString() + "' order by id desc";
            }
            var dt = sqlSugarServerHelper.db.Ado.GetDataTable(sql);
            DataInfo.Clear();
            DataInfo = dt;
            InitDataSet();
            //   this.DatabaseSource.DataSource = dt;
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("未检索到数据！");
            }
        }
        private void TimeQureybtn_Click(object sender, EventArgs e)
        {
            SqlSugarServerHelper sqlSugarServerHelper = new SqlSugarServerHelper();
            string sql = "";
            if (ProcessNoComboBox.Text == "")
            {
                sql = $"select  * from {Tablename} where " + Timename + " between N'" + StartTime.Text.ToString() + "' AND N'" + EndTime.Text.ToString() + "' order by id desc";
            }
            else
            {
                sql = $"select  * from {Tablename} where process_no =  '" + ProcessNoComboBox.Text.ToString() + "' AND " + Timename + " between N'" + StartTime.Text.ToString() + "' AND N'" + EndTime.Text.ToString() + "' order by id desc";
            }
            var dt = sqlSugarServerHelper.db.Ado.GetDataTable(sql);
            DataInfo.Clear();
            DataInfo = dt;
            //   this.DatabaseSource.DataSource = dt;、 InitDataSet();
            InitDataSet();
            if (dt.Rows.Count != 0)
            {
                //InitDataSet();
            }
            else
            {
                MessageBox.Show("未检索到数据！");
            }
        }
        public void exportCsv()
        {
            bool flag = ExportDataTable2Csv(Csvpath, DataInfo);
            if (flag)
                MessageBox.Show("导出成功");
            else
                MessageBox.Show("数据导出异常");
        }
        public static bool ExportDataTable2Csv(string filePath, DataTable TempDatainfo)
        {
            bool flag = false;
            FileStream fs = null;
            StreamWriter sw = null;
            if (filePath.EndsWith(".csv"))
            {
                filePath = filePath.Substring(0, filePath.Length - 4);
            }
            try
            {
                fs = new FileStream(filePath + ".csv", FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs, Encoding.Default);
                var headdata = string.Empty;
                foreach (DataColumn col in TempDatainfo.Columns)
                {
                    headdata += col.ColumnName + ",";//获取到DataColumn列对象的列名
                }
                sw.WriteLine(headdata);
                string data = "";
                //csv写入数据
                for (int i = 0; i < TempDatainfo.Rows.Count; i++)
                {
                    string data2 = string.Empty;
                    //拼接行数据
                    for (int cNum1 = 0; cNum1 < TempDatainfo.Columns.Count; cNum1++)
                    {
                        data2 = data2 + "\"" + TempDatainfo.Rows[i][TempDatainfo.Columns[cNum1].ColumnName].ToString() + "\",";
                    }
                    bool flag1 = data != data2;
                    if (flag1)
                    {
                        sw.WriteLine(data2);
                    }
                    data = data2;
                }
                flag = true;
            }
            catch (IOException ex)
            {
                return false;
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
                if (fs != null)
                {
                    fs.Close();
                }
            }
            return flag;
        }
        private void Qurey(object sender, EventArgs e)
        {
            SqlSugarServerHelper sqlSugarServerHelper = new SqlSugarServerHelper();
            string sql = "";
            if (ProcessNoComboBox.Text == "")
            {
                sql = $"select  * from {Tablename}";
            }
            else
            {
                sql = $"select  * from {Tablename} where 工序 =  '" + ProcessNoComboBox.Text.ToString() + "'";
            }
            var dt = sqlSugarServerHelper.db.Ado.GetDataTable(sql);
            DataInfo.Clear();
            DataInfo = dt;
            //   this.DatabaseSource.DataSource = dt;
            InitDataSet();
            if (dt.Rows.Count != 0)
            {
                //InitDataSet();
            }
            else
            {
                MessageBox.Show("未检索到数据！");
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            SqlSugarServerHelper sqlSugarServerHelper = new SqlSugarServerHelper();
            string sql = "DECLARE @tmp_tbl TABLE([id] int, [批次号] varchar(255), [日期] datetime, [工序] varchar(255)) INSERT INTO[dbo].[过站数据报表] OUTPUT INSERTED.[id], INSERTED.[批次号], INSERTED.[日期], INSERTED.[工序] INTO @tmp_tbl DEFAULT VALUES SELECT* FROM @tmp_tbl";
            var dt = sqlSugarServerHelper.db.Ado.GetDataTable(sql);
        }
        private void 数采报表_Load(object sender, EventArgs e)
        {
            StartTime.Text = System.DateTime.Now.ToString("yyyy-MM-dd") + " 00:00:00";
            EndTime.Text = System.DateTime.Now.ToString("yyyy-MM-dd") + " 23:59:59";
            //   2022 - 11 - 08 00:00:00
            InitInfo("MicroVastProcessProperty");
            DatabaseSource.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgvRowPrePaint);
        }
        private void dgvRowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < DatabaseSource.Rows.Count)
            {
                DataGridViewRow dgrSingle = DatabaseSource.Rows[e.RowIndex];
                try
                {
                    /* 2021/06/11 新增 wu.mingxuan 所有NG项全标红 strat */
                    foreach (DataGridViewCell item in dgrSingle.Cells)
                    {
                        if (item.Value != null && item.Value.ToString() == "NG")
                        {
                            item.Style.ForeColor = Color.Red;
                        }
                    }
                    /* 2021/06/11 新增 wu.mingxuan 所有NG项全标红 end */
                    if (dgrSingle.Cells["合格标志"].Value.ToString().Contains("NG"))
                    {
                        dgrSingle.DefaultCellStyle.BackColor = Color.Yellow;
                        dgrSingle.Cells["合格标志"].Style.ForeColor = Color.Red;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
