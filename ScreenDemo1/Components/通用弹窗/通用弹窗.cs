using Microvast.Common.Utils;
using Microvast.Common.Vuex;
using ScreenDemo1.Properties;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test;
namespace ScreenDemo1.Components.通用弹窗
{
    public partial class 通用弹窗 : UIForm
    {
        public string name;
        public int Id = 0;
        public int FormType = 0;
        IniReadWrite Setting = new IniReadWrite();
        DataTable Controllist = new DataTable();
        public 通用弹窗()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="id"></param>
        /// <param name="Formtype">  1为默认新增，2为修改 </param>
        public 通用弹窗(string Name, int id = 0, int Formtype = 1)
        {
            InitializeComponent();
            Setting.inipath = System.Windows.Forms.Application.StartupPath + "\\config.ini";
            Setting.ExistINIFile();
            #region 赋值
            name = Name;
            Id = id;
            FormType = Formtype;
            #endregion
            #region 加载
            Assembly assembly = Assembly.Load("Microvast.Model");
            Type type = assembly.GetType($"Microvast.Model.{Name}");
            #endregion
            #region 反射获取类型属性
            var props = type.GetProperties();
            SqlSugarServerHelper sqlSugarServerHelper = new SqlSugarServerHelper();
            var dt = sqlSugarServerHelper.db.Ado.GetDataTable($"select * from {Name} where Id={id}");
            Controllist = sqlSugarServerHelper.db.Ado.GetDataTable($"select * from AddOrChangedataList where DataTableName = '{Name}'");
            int idx = 0;
            int labeli = 1;
            int labelj = 1;
            foreach (DataRow data in Controllist.Rows)
            {
                idx += 1;
                if (idx % 2 != 0)
                {
                    labeli += 1;
                    // label显示文本
                    System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                    label.Name = "label" + idx.ToString();
                    itemPanel.Controls.Add(label);
                    label.Location = new Point(30, 2 + (labeli - 1) * 35);
                    label.Text = idx + "." + data["DataName"].ToString();
                    label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    label.ForeColor = System.Drawing.Color.Black;
                    label.Size = new System.Drawing.Size(160, 23);
                    label.AutoSize = true;
                    label.BackColor = System.Drawing.Color.Transparent;
                    // label值显示框
                    if (data["type"].ToString() == "TextBox")
                    {
                        System.Windows.Forms.TextBox text_val = new System.Windows.Forms.TextBox();
                        text_val.Name = idx.ToString() + "" + data["DataName"].ToString();
                        //  text_val.Text = data["DefaultData"].ToString();
                        itemPanel.Controls.Add(text_val);
                        text_val.Location = new Point(itemPanel.Width / 2 - itemPanel.Width / 3+15, 0 + (labeli - 1) * 35);
                        text_val.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        text_val.Size = new System.Drawing.Size(230, 35);
                        text_val.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        if (FormType == 2) text_val.Text = dt.Rows[0][data["DataName"].ToString()].ToString();
                        if (data["LengthLim"].ToString() != "0") text_val.MaxLength = int.Parse(data["LengthLim"].ToString());
                        if (data["ValueLim"].ToString() == "1")
                        {
                            text_val.KeyPress += new System.Windows.Forms.KeyPressEventHandler(OnlyNum_KeyPress);
                        }
                        else if (data["ValueLim"].ToString() == "2")
                        {
                            text_val.KeyPress += new System.Windows.Forms.KeyPressEventHandler(NoCn_KeyPress);
                        }
                        switch (data["DefaultData"].ToString())
                        {
                            case "AddTime":
                                if (Formtype == 1)
                                {
                                    text_val.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                                    text_val.ReadOnly = true;
                                }
                                else
                                {
                                    text_val.Text = dt.Rows[0][data["DataName"].ToString()].ToString();
                                }
                                break;
                            case "UpdataTime":
                                if (Formtype == 2)
                                {
                                    text_val.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                                    text_val.ReadOnly = true;
                                }
                                else
                                {
                                    text_val.Text = "";
                                }
                                break;
                            case "AddUserID":
                                if (Formtype == 1)
                                {
                                    text_val.Text = Form1.mainForm.工号;
                                    text_val.ReadOnly = true;
                                }
                                else
                                {
                                    text_val.Text = dt.Rows[0][data["DataName"].ToString()].ToString();
                                }
                                break;
                            case "AddUserName":
                                if (Formtype == 1)
                                {
                                    text_val.Text = Form1.mainForm.登录名;
                                    text_val.ReadOnly = true;
                                }
                                else
                                {
                                    text_val.Text = dt.Rows[0][data["DataName"].ToString()].ToString();
                                }
                                break;
                            case "UpdataUserID":
                                if (Formtype == 2)
                                {
                                    text_val.Text = Form1.mainForm.工号;
                                    text_val.ReadOnly = true;
                                }
                                else
                                {
                                    text_val.Text = "";
                                }
                                break;
                            case "UpdataUserName":
                                if (Formtype == 2)
                                {
                                    text_val.Text = Form1.mainForm.登录名;
                                    text_val.ReadOnly = true;
                                }
                                else
                                {
                                    text_val.Text = "";
                                }
                                break;
                            default:
                                if (FormType == 1) text_val.Text = data["DefaultData"].ToString();
                                break;
                        }
                    }
                    else if (data["type"].ToString() == "ComboBox")
                    {
                        System.Windows.Forms.ComboBox ComboBoxtext_val = new System.Windows.Forms.ComboBox();
                        ComboBoxtext_val.Name = idx.ToString() + "" + data["DataName"].ToString();
                        string[] ComboboxValue = data["DefaultData"].ToString().Split(';');
                        for (int i = 0; i < ComboboxValue.Length; i++)
                        {
                            ComboBoxtext_val.Items.Add(ComboboxValue[i]);
                        }
                        ComboBoxtext_val.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                        ComboBoxtext_val.Text = data["DefaultData"].ToString();
                        ComboBoxtext_val.SelectedIndex = ComboBoxtext_val.Items.IndexOf(ComboboxValue[0]);
                        itemPanel.Controls.Add(ComboBoxtext_val);
                        ComboBoxtext_val.Location = new Point(itemPanel.Width / 2 - itemPanel.Width / 3 + 15, 0 + (labeli - 1) * 35);
                        ComboBoxtext_val.Size = new System.Drawing.Size(230, 35);
                        ComboBoxtext_val.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        if (FormType == 2)
                        {
                            ComboBoxtext_val.Text = dt.Rows[0][data["DataName"].ToString()].ToString();
                        }
                        if (data["DataName"].ToString() == "工序")
                        {
                            ComboBoxtext_val.Text  = Setting.IniReadValue("Setting", "当前工序");
                        }
                    }
                    else if (data["type"].ToString() == "DateTimePicker")
                    {
                        Sunny.UI.UIDatetimePicker Time = new UIDatetimePicker();
                        Time.FillColor = System.Drawing.Color.White;
                        Time.Font = new System.Drawing.Font("微软雅黑", 12F);
                        Time.Location = new Point(itemPanel.Width / 2 - itemPanel.Width / 3+15, 0 + (labeli - 1) * 35);
                        Time.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
                        Time.MaxLength = 19;
                        Time.MinimumSize = new System.Drawing.Size(63, 0);
                        Time.Name = idx.ToString() + "" + data["DataName"].ToString();
                        Time.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
                        Time.RectColor = System.Drawing.Color.Black;
                        Time.Size = new System.Drawing.Size(230, 30);
                        Time.Style = Sunny.UI.UIStyle.Custom;
                        Time.SymbolDropDown = 61555;
                        Time.SymbolNormal = 61555;
                        Time.TabIndex = 188;
                        Time.Text = "2022-11-08 00:00:00";
                        Time.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
                        Time.Value = new System.DateTime(2022, 11, 8, 0, 0, 0, 0);
                        Time.Watermark = "";
                        Time.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
                        Time.Value = System.DateTime.Now;
                        switch (data["DefaultData"].ToString())
                        {
                            case "AddTime":
                                if (Formtype == 1)
                                {
                                    Time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                                    Time.ReadOnly = true;
                                }
                                else
                                {
                                    Time.Text = dt.Rows[0][data["DataName"].ToString()].ToString();
                                }
                                break;
                            case "UpdataTime":
                                if (Formtype == 2)
                                {
                                    Time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                                    Time.ReadOnly = true;
                                }
                                else
                                {
                                    Time.Text = "";
                                }
                                break;
                            case "AddUserID":
                                if (Formtype == 1)
                                {
                                    Time.Text = Form1.mainForm.工号;
                                    Time.ReadOnly = true;
                                }
                                else
                                {
                                    Time.Text = dt.Rows[0][data["DataName"].ToString()].ToString();
                                }
                                break;
                            case "AddUserName":
                                if (Formtype == 1)
                                {
                                    Time.Text = Form1.mainForm.登录名;
                                    Time.ReadOnly = true;
                                }
                                else
                                {
                                    Time.Text = dt.Rows[0][data["DataName"].ToString()].ToString();
                                }
                                break;
                            case "UpdataUserID":
                                if (Formtype == 2)
                                {
                                    Time.Text = Form1.mainForm.工号;
                                    Time.ReadOnly = true;
                                }
                                else
                                {
                                    Time.Text = "";
                                }
                                break;
                            case "UpdataUserName":
                                if (Formtype == 2)
                                {
                                    Time.Text = Form1.mainForm.登录名;
                                    Time.ReadOnly = true;
                                }
                                else
                                {
                                    Time.Text = "";
                                }
                                break;
                            default:
                                if (FormType == 1) Time.Text = data["DefaultData"].ToString();
                                break;
                        }
                        itemPanel.Controls.Add(Time);
                    }
                }
                else
                {
                    labelj += 1;
                    // 第二项
                    // label显示文本
                    System.Windows.Forms.Label label2 = new System.Windows.Forms.Label();
                    label2.Name = "label" + idx.ToString();
                    itemPanel.Controls.Add(label2);
                    label2.Location = new Point(itemPanel.Width / 2 + 30, 2 + (labelj - 1) * 35);
                    label2.Text = idx + "." + data["DataName"].ToString();
                    label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    label2.ForeColor = System.Drawing.Color.Black;
                    label2.Size = new System.Drawing.Size(160, 23);
                    label2.AutoSize = true;
                    label2.BackColor = System.Drawing.Color.Transparent;
                    // label值显示框
                    if (data["type"].ToString() == "TextBox")
                    {
                        System.Windows.Forms.TextBox text_val = new System.Windows.Forms.TextBox();
                        text_val.Name = idx.ToString() + "" + data["DataName"].ToString();
                        // text_val.Text = data["DefaultData"].ToString();
                        itemPanel.Controls.Add(text_val);
                        text_val.Location = new Point(itemPanel.Width - itemPanel.Width / 3, 0 + (labelj - 1) * 35);
                        //label_val2.BackColor = System.Drawing.Color.Honeydew;
                        // label_val2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        text_val.Size = new System.Drawing.Size(230, 35);
                        text_val.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        if (FormType == 2) text_val.Text = dt.Rows[0][data["DataName"].ToString()].ToString();
                        if (data["LengthLim"].ToString() != "0") text_val.MaxLength = int.Parse(data["LengthLim"].ToString());
                        switch (data["DefaultData"].ToString())
                        {
                            case "AddTime":
                                if (Formtype == 1)
                                {
                                    text_val.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                                    text_val.ReadOnly = true;
                                }
                                else
                                {
                                    text_val.Text = dt.Rows[0][data["DataName"].ToString()].ToString();
                                }
                                break;
                            case "UpdataTime":
                                if (Formtype == 2)
                                {
                                    text_val.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                                    text_val.ReadOnly = true;
                                }
                                else
                                {
                                    text_val.Text = "";
                                }
                                break;
                            case "AddUserID":
                                if (Formtype == 1)
                                {
                                    text_val.Text = Form1.mainForm.工号;
                                    text_val.ReadOnly = true;
                                }
                                else
                                {
                                    text_val.Text = dt.Rows[0][data["DataName"].ToString()].ToString();
                                }
                                break;
                            case "AddUserName":
                                if (Formtype == 1)
                                {
                                    text_val.Text = Form1.mainForm.登录名;
                                    text_val.ReadOnly = true;
                                }
                                else
                                {
                                    text_val.Text = dt.Rows[0][data["DataName"].ToString()].ToString();
                                }
                                break;
                            case "UpdataUserID":
                                if (Formtype == 2)
                                {
                                    text_val.Text = Form1.mainForm.工号;
                                    text_val.ReadOnly = true;
                                }
                                else
                                {
                                    text_val.Text = "";
                                }
                                break;
                            case "UpdataUserName":
                                if (Formtype == 2)
                                {
                                    text_val.Text = Form1.mainForm.登录名;
                                    text_val.ReadOnly = true;
                                }
                                else
                                {
                                    text_val.Text = "";
                                }
                                break;
                            default:
                                if (FormType == 1) text_val.Text = data["DefaultData"].ToString();
                                break;
                        }
                    }
                    else if (data["type"].ToString() == "ComboBox")
                    {
                        System.Windows.Forms.ComboBox ComboBoxtext_val = new System.Windows.Forms.ComboBox();
                        ComboBoxtext_val.Name = idx.ToString() + "" + data["DataName"].ToString();
                        string[] ComboboxValue = data["DefaultData"].ToString().Split(';');
                        for (int i = 0; i < ComboboxValue.Length; i++)
                        {
                            ComboBoxtext_val.Items.Add(ComboboxValue[i]);
                        }
                        ComboBoxtext_val.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                        ComboBoxtext_val.Text = data["DefaultData"].ToString();
                        itemPanel.Controls.Add(ComboBoxtext_val);
                        ComboBoxtext_val.SelectedIndex = ComboBoxtext_val.Items.IndexOf(ComboboxValue[0]);
                        ComboBoxtext_val.Location = new Point(itemPanel.Width - itemPanel.Width / 3, 0 + (labelj - 1) * 35);
                        ComboBoxtext_val.Size = new System.Drawing.Size(230, 35);
                        ComboBoxtext_val.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                        if (FormType == 2)
                        {
                            ComboBoxtext_val.Text = dt.Rows[0][data["DataName"].ToString()].ToString();
                        }
                        if (data["DataName"].ToString() == "工序")
                        {
                            ComboBoxtext_val.Text = Setting.IniReadValue("Setting", "当前工序");
                        }
                    }
                    else if (data["type"].ToString() == "DateTimePicker")
                    {
                        Sunny.UI.UIDatetimePicker Time = new UIDatetimePicker();
                        Time.FillColor = System.Drawing.Color.White;
                        Time.Font = new System.Drawing.Font("微软雅黑", 12F);
                        Time.Location = new Point(itemPanel.Width - itemPanel.Width / 3, 0 + (labelj - 1) * 35);
                        Time.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
                        Time.MaxLength = 19;
                        Time.MinimumSize = new System.Drawing.Size(63, 0);
                        Time.Name = idx.ToString() + "" + data["DataName"].ToString();
                        Time.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
                        Time.RectColor = System.Drawing.Color.Black;
                        Time.Size = new System.Drawing.Size(230, 30);
                        Time.Style = Sunny.UI.UIStyle.Custom;
                        Time.SymbolDropDown = 61555;
                        Time.SymbolNormal = 61555;
                        Time.TabIndex = 188;
                        Time.Text = "2022-11-08 00:00:00";
                        Time.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
                        Time.Value = new System.DateTime(2022, 11, 8, 0, 0, 0, 0);
                        Time.Watermark = "";
                        Time.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
                        Time.ShowToday = true;
                        Time.Value = System.DateTime.Now;
                        itemPanel.Controls.Add(Time);
                        switch (data["DefaultData"].ToString())
                        {
                            case "AddTime":
                                if (Formtype == 1)
                                {
                                    Time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                                    Time.ReadOnly = true;
                                }
                                else
                                {
                                    Time.Text = dt.Rows[0][data["DataName"].ToString()].ToString();
                                }
                                break;
                            case "UpdataTime":
                                if (Formtype == 2)
                                {
                                    Time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                                    Time.ReadOnly = true;
                                }
                                else
                                {
                                    Time.Text = "";
                                }
                                break;
                            case "AddUserID":
                                if (Formtype == 1)
                                {
                                    Time.Text = Form1.mainForm.工号;
                                    Time.ReadOnly = true;
                                }
                                else
                                {
                                    Time.Text = dt.Rows[0][data["DataName"].ToString()].ToString();
                                }
                                break;
                            case "AddUserName":
                                if (Formtype == 1)
                                {
                                    Time.Text = Form1.mainForm.登录名;
                                    Time.ReadOnly = true;
                                }
                                else
                                {
                                    Time.Text = dt.Rows[0][data["DataName"].ToString()].ToString();
                                }
                                break;
                            case "UpdataUserID":
                                if (Formtype == 2)
                                {
                                    Time.Text = Form1.mainForm.工号;
                                    Time.ReadOnly = true;
                                }
                                else
                                {
                                    Time.Text = "";
                                }
                                break;
                            case "UpdataUserName":
                                if (Formtype == 2)
                                {
                                    Time.Text = Form1.mainForm.登录名;
                                    Time.ReadOnly = true;
                                }
                                else
                                {
                                    Time.Text = "";
                                }
                                break;
                            default:
                                if (FormType == 1) Time.Text = data["DefaultData"].ToString();
                                break;
                        }
                    }
                }
            
            }
            #endregion
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
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //if(FormType==2)
            //{
            //    if()
            //}
            string sql = string.Empty;
            string SqlNames = "";
            string SqlValue = "";
            string SqlUpdata = "";
            int idx = 0;
            SqlSugarServerHelper sqlSugarServerHelper = new SqlSugarServerHelper();
            StringBuilder sb = new StringBuilder();
            foreach (DataRow data in Controllist.Rows)
            {
                idx++;
                if (data["LengthLim"].ToString() != "0" && data["type"].ToString() == "TextBox")
                {
                    System.Windows.Forms.TextBox TempTextBox;
                    TempTextBox = Controls.Find(idx.ToString() + data["DataName"].ToString(), true)[0] as System.Windows.Forms.TextBox;
                    if (TempTextBox != null)
                    {
                        if (TempTextBox.Text.Length != TempTextBox.MaxLength)
                        {
                            MessageBox.Show(data["DataName"].ToString() + "：输入内容长度错误！");
                            return;
                        }
                    }
                }
                SqlValue += "'" + Label_Display(idx.ToString() + "" + data["DataName"].ToString()) + "',";
                SqlNames += data["DataName"].ToString() + ",";
                SqlUpdata += data["DataName"].ToString() + "='" + Label_Display(idx.ToString() + "" + data["DataName"].ToString()) + "',";
            }
            SqlValue = SqlValue.Substring(0, SqlValue.Length - 1);
            SqlNames = SqlNames.Substring(0, SqlNames.Length - 1);
            SqlUpdata = SqlUpdata.Substring(0, SqlUpdata.Length - 1);
            if (FormType == 1)
            {
                sql = $"insert into {name} (" + SqlNames + ") VALUES (" + SqlValue + ")";
                int res = sqlSugarServerHelper.db.Ado.ExecuteCommand(sql.ToString());
                Store.CommonRefreshDel(name);
                if (res == 0)
                {
                    MessageBox.Show("写入失败");
                }
                else
                {
                    MessageBox.Show("写入成功");
                }
                Close();
            }
            else if (FormType == 2)
            {
                sql = $"Update  {name} SET " + SqlUpdata + $" where Id={Id}";
                int res = sqlSugarServerHelper.db.Ado.ExecuteCommand(sql.ToString());
                Store.CommonRefreshDel(name);
                if (res == 0)
                {
                    MessageBox.Show("写入失败");
                }
                else
                {
                    MessageBox.Show("写入成功");
                }
                Close();
            }
        }
        public string Label_Display(string ControlName)
        {
            System.Windows.Forms.TextBox TempTextBox;
            System.Windows.Forms.ComboBox TempComboBox;
            // System.Windows.Forms.DateTimePicker datetimepicker;etimePicker();
            // Sunny.UI.UIDatetimePicker datetimepicker = new UIDatetimePicker();
            Sunny.UI.UIDatetimePicker datetimepicker;
            string res = "";
            datetimepicker = Controls.Find(ControlName, true)[0] as Sunny.UI.UIDatetimePicker;
            if (datetimepicker != null)
            {
                res = datetimepicker.Text;
            }
            //查找是否有相关的文本控件
            TempTextBox = Controls.Find(ControlName, true)[0] as System.Windows.Forms.TextBox;
            if (TempTextBox != null)
            {
                res = TempTextBox.Text;
            }
            //查找是否有相关的按钮控件
            TempComboBox = Controls.Find(ControlName, true)[0] as System.Windows.Forms.ComboBox;
            if (TempComboBox != null)
            {
                res = TempComboBox.Text;
            }
            return res;
        }
        /// <summary>
        /// 仅允许输入阿拉伯数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnlyNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = e.KeyChar;
            if ((key < '0' || key > '9') && (key != 8 && key != 46))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// 禁止中文
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoCn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || e.KeyChar == '\b')
            {
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
