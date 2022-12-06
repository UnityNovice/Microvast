namespace ScreenDemo1.Pages.基础信息
{
    partial class 数采报表
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region 组件设计器生成的代码
        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PageJump = new Sunny.UI.UIButton();
            this.PagePlus = new Sunny.UI.UIButton();
            this.PageMinus = new Sunny.UI.UIButton();
            this.PageCo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SettingNum = new System.Windows.Forms.TextBox();
            this.Currentpage = new System.Windows.Forms.Label();
            this.导出 = new Sunny.UI.UIButton();
            this.CodeQureybtn = new Sunny.UI.UIButton();
            this.TableTitllab = new System.Windows.Forms.Label();
            this.ProcessNoComboBox = new Sunny.UI.UIComboBox();
            this.CodeNameTxt = new Sunny.UI.UITextBox();
            this.TimeQureybtn = new Sunny.UI.UIButton();
            this.ProcessLbl = new System.Windows.Forms.Label();
            this.CodeNameLab = new System.Windows.Forms.Label();
            this.TimeNamelab = new System.Windows.Forms.Label();
            this.StartTime = new Sunny.UI.UIDatetimePicker();
            this.EndTime = new Sunny.UI.UIDatetimePicker();
            this.Timemidlab = new System.Windows.Forms.Label();
            this.DatabaseSource = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PageJump
            // 
            this.PageJump.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PageJump.FillColor = System.Drawing.Color.Transparent;
            this.PageJump.FillColor2 = System.Drawing.Color.Transparent;
            this.PageJump.FillHoverColor = System.Drawing.Color.DodgerBlue;
            this.PageJump.FillPressColor = System.Drawing.Color.LightGray;
            this.PageJump.FillSelectedColor = System.Drawing.Color.Transparent;
            this.PageJump.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PageJump.ForeColor = System.Drawing.Color.Black;
            this.PageJump.ForeDisableColor = System.Drawing.Color.DarkGray;
            this.PageJump.ForeHoverColor = System.Drawing.Color.LightGray;
            this.PageJump.ForePressColor = System.Drawing.Color.DarkGray;
            this.PageJump.Location = new System.Drawing.Point(1305, 865);
            this.PageJump.MinimumSize = new System.Drawing.Size(1, 1);
            this.PageJump.Name = "PageJump";
            this.PageJump.RectColor = System.Drawing.Color.Black;
            this.PageJump.RectHoverColor = System.Drawing.Color.DarkGray;
            this.PageJump.RectPressColor = System.Drawing.Color.Gainsboro;
            this.PageJump.RectSelectedColor = System.Drawing.Color.Gainsboro;
            this.PageJump.Size = new System.Drawing.Size(89, 35);
            this.PageJump.Style = Sunny.UI.UIStyle.Custom;
            this.PageJump.StyleCustomMode = true;
            this.PageJump.TabIndex = 178;
            this.PageJump.Text = "跳转";
            this.PageJump.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PageJump.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.PageJump.Click += new System.EventHandler(this.PageJump_Click);
            // 
            // PagePlus
            // 
            this.PagePlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PagePlus.FillColor = System.Drawing.Color.Transparent;
            this.PagePlus.FillColor2 = System.Drawing.Color.Transparent;
            this.PagePlus.FillHoverColor = System.Drawing.Color.DodgerBlue;
            this.PagePlus.FillPressColor = System.Drawing.Color.LightGray;
            this.PagePlus.FillSelectedColor = System.Drawing.Color.Transparent;
            this.PagePlus.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PagePlus.ForeColor = System.Drawing.Color.Black;
            this.PagePlus.ForeDisableColor = System.Drawing.Color.DarkGray;
            this.PagePlus.ForeHoverColor = System.Drawing.Color.LightGray;
            this.PagePlus.ForePressColor = System.Drawing.Color.DarkGray;
            this.PagePlus.Location = new System.Drawing.Point(862, 865);
            this.PagePlus.MinimumSize = new System.Drawing.Size(1, 1);
            this.PagePlus.Name = "PagePlus";
            this.PagePlus.RectColor = System.Drawing.Color.Black;
            this.PagePlus.RectHoverColor = System.Drawing.Color.DarkGray;
            this.PagePlus.RectPressColor = System.Drawing.Color.Gainsboro;
            this.PagePlus.RectSelectedColor = System.Drawing.Color.Gainsboro;
            this.PagePlus.Size = new System.Drawing.Size(89, 35);
            this.PagePlus.Style = Sunny.UI.UIStyle.Custom;
            this.PagePlus.StyleCustomMode = true;
            this.PagePlus.TabIndex = 177;
            this.PagePlus.Text = "下一页";
            this.PagePlus.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PagePlus.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.PagePlus.Click += new System.EventHandler(this.PagePlus_Click);
            // 
            // PageMinus
            // 
            this.PageMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PageMinus.FillColor = System.Drawing.Color.Transparent;
            this.PageMinus.FillColor2 = System.Drawing.Color.Transparent;
            this.PageMinus.FillHoverColor = System.Drawing.Color.DodgerBlue;
            this.PageMinus.FillPressColor = System.Drawing.Color.LightGray;
            this.PageMinus.FillSelectedColor = System.Drawing.Color.Transparent;
            this.PageMinus.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PageMinus.ForeColor = System.Drawing.Color.Black;
            this.PageMinus.ForeDisableColor = System.Drawing.Color.DarkGray;
            this.PageMinus.ForeHoverColor = System.Drawing.Color.LightGray;
            this.PageMinus.ForePressColor = System.Drawing.Color.DarkGray;
            this.PageMinus.Location = new System.Drawing.Point(457, 865);
            this.PageMinus.MinimumSize = new System.Drawing.Size(1, 1);
            this.PageMinus.Name = "PageMinus";
            this.PageMinus.RectColor = System.Drawing.Color.Black;
            this.PageMinus.RectHoverColor = System.Drawing.Color.DarkGray;
            this.PageMinus.RectPressColor = System.Drawing.Color.Gainsboro;
            this.PageMinus.RectSelectedColor = System.Drawing.Color.Gainsboro;
            this.PageMinus.Size = new System.Drawing.Size(89, 35);
            this.PageMinus.Style = Sunny.UI.UIStyle.Custom;
            this.PageMinus.StyleCustomMode = true;
            this.PageMinus.TabIndex = 176;
            this.PageMinus.Text = "上一页";
            this.PageMinus.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PageMinus.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.PageMinus.Click += new System.EventHandler(this.PageMinus_Click);
            // 
            // PageCo
            // 
            this.PageCo.AutoSize = true;
            this.PageCo.BackColor = System.Drawing.Color.Transparent;
            this.PageCo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PageCo.ForeColor = System.Drawing.Color.Black;
            this.PageCo.Location = new System.Drawing.Point(721, 872);
            this.PageCo.Name = "PageCo";
            this.PageCo.Size = new System.Drawing.Size(37, 21);
            this.PageCo.TabIndex = 175;
            this.PageCo.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(695, 872);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 21);
            this.label1.TabIndex = 174;
            this.label1.Text = "/";
            // 
            // SettingNum
            // 
            this.SettingNum.BackColor = System.Drawing.Color.White;
            this.SettingNum.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.SettingNum.ForeColor = System.Drawing.Color.Black;
            this.SettingNum.Location = new System.Drawing.Point(1208, 865);
            this.SettingNum.Multiline = true;
            this.SettingNum.Name = "SettingNum";
            this.SettingNum.Size = new System.Drawing.Size(91, 35);
            this.SettingNum.TabIndex = 173;
            // 
            // Currentpage
            // 
            this.Currentpage.AutoSize = true;
            this.Currentpage.BackColor = System.Drawing.Color.Transparent;
            this.Currentpage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Currentpage.ForeColor = System.Drawing.Color.Black;
            this.Currentpage.Location = new System.Drawing.Point(643, 872);
            this.Currentpage.Name = "Currentpage";
            this.Currentpage.Size = new System.Drawing.Size(19, 21);
            this.Currentpage.TabIndex = 172;
            this.Currentpage.Text = "1";
            // 
            // 导出
            // 
            this.导出.Cursor = System.Windows.Forms.Cursors.Hand;
            this.导出.FillColor = System.Drawing.Color.Transparent;
            this.导出.FillColor2 = System.Drawing.Color.Transparent;
            this.导出.FillHoverColor = System.Drawing.Color.DodgerBlue;
            this.导出.FillPressColor = System.Drawing.Color.LightGray;
            this.导出.FillSelectedColor = System.Drawing.Color.Transparent;
            this.导出.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.导出.ForeColor = System.Drawing.Color.Black;
            this.导出.ForeDisableColor = System.Drawing.Color.DarkGray;
            this.导出.ForeHoverColor = System.Drawing.Color.LightGray;
            this.导出.ForePressColor = System.Drawing.Color.DarkGray;
            this.导出.Location = new System.Drawing.Point(1347, 112);
            this.导出.MinimumSize = new System.Drawing.Size(1, 1);
            this.导出.Name = "导出";
            this.导出.RectColor = System.Drawing.Color.Black;
            this.导出.RectHoverColor = System.Drawing.Color.DarkGray;
            this.导出.RectPressColor = System.Drawing.Color.Gainsboro;
            this.导出.RectSelectedColor = System.Drawing.Color.Gainsboro;
            this.导出.Size = new System.Drawing.Size(69, 34);
            this.导出.Style = Sunny.UI.UIStyle.Custom;
            this.导出.StyleCustomMode = true;
            this.导出.TabIndex = 171;
            this.导出.Text = "导出";
            this.导出.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.导出.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.导出.Click += new System.EventHandler(this.导出_Click);
            // 
            // CodeQureybtn
            // 
            this.CodeQureybtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CodeQureybtn.FillColor = System.Drawing.Color.Transparent;
            this.CodeQureybtn.FillColor2 = System.Drawing.Color.Transparent;
            this.CodeQureybtn.FillHoverColor = System.Drawing.Color.DodgerBlue;
            this.CodeQureybtn.FillPressColor = System.Drawing.Color.LightGray;
            this.CodeQureybtn.FillSelectedColor = System.Drawing.Color.Transparent;
            this.CodeQureybtn.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CodeQureybtn.ForeColor = System.Drawing.Color.Black;
            this.CodeQureybtn.ForeDisableColor = System.Drawing.Color.DarkGray;
            this.CodeQureybtn.ForeHoverColor = System.Drawing.Color.LightGray;
            this.CodeQureybtn.ForePressColor = System.Drawing.Color.DarkGray;
            this.CodeQureybtn.Location = new System.Drawing.Point(555, 113);
            this.CodeQureybtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.CodeQureybtn.Name = "CodeQureybtn";
            this.CodeQureybtn.RectColor = System.Drawing.Color.Black;
            this.CodeQureybtn.RectHoverColor = System.Drawing.Color.DarkGray;
            this.CodeQureybtn.RectPressColor = System.Drawing.Color.Gainsboro;
            this.CodeQureybtn.RectSelectedColor = System.Drawing.Color.Gainsboro;
            this.CodeQureybtn.Size = new System.Drawing.Size(111, 34);
            this.CodeQureybtn.Style = Sunny.UI.UIStyle.Custom;
            this.CodeQureybtn.StyleCustomMode = true;
            this.CodeQureybtn.TabIndex = 167;
            this.CodeQureybtn.Text = "批次查询";
            this.CodeQureybtn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CodeQureybtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.CodeQureybtn.Click += new System.EventHandler(this.CodeQureybtn_Click);
            // 
            // TableTitllab
            // 
            this.TableTitllab.AutoSize = true;
            this.TableTitllab.Font = new System.Drawing.Font("微软雅黑", 25F);
            this.TableTitllab.ForeColor = System.Drawing.Color.Black;
            this.TableTitllab.Location = new System.Drawing.Point(676, 35);
            this.TableTitllab.Name = "TableTitllab";
            this.TableTitllab.Size = new System.Drawing.Size(156, 45);
            this.TableTitllab.TabIndex = 165;
            this.TableTitllab.Text = "数采内容";
            // 
            // ProcessNoComboBox
            // 
            this.ProcessNoComboBox.BackColor = System.Drawing.Color.White;
            this.ProcessNoComboBox.DataSource = null;
            this.ProcessNoComboBox.FillColor = System.Drawing.Color.White;
            this.ProcessNoComboBox.FillColor2 = System.Drawing.Color.Transparent;
            this.ProcessNoComboBox.FillDisableColor = System.Drawing.Color.Transparent;
            this.ProcessNoComboBox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ProcessNoComboBox.ForeColor = System.Drawing.Color.Black;
            this.ProcessNoComboBox.ItemForeColor = System.Drawing.Color.Black;
            this.ProcessNoComboBox.ItemHoverColor = System.Drawing.Color.DodgerBlue;
            this.ProcessNoComboBox.ItemRectColor = System.Drawing.Color.Black;
            this.ProcessNoComboBox.Items.AddRange(new object[] {
            "正极搅拌",
            "负极搅拌",
            "正极涂布",
            "负极涂布",
            "正极辊压",
            "负极辊压"});
            this.ProcessNoComboBox.ItemSelectBackColor = System.Drawing.Color.DodgerBlue;
            this.ProcessNoComboBox.ItemSelectForeColor = System.Drawing.Color.White;
            this.ProcessNoComboBox.Location = new System.Drawing.Point(112, 116);
            this.ProcessNoComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProcessNoComboBox.MinimumSize = new System.Drawing.Size(63, 0);
            this.ProcessNoComboBox.Name = "ProcessNoComboBox";
            this.ProcessNoComboBox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ProcessNoComboBox.RectColor = System.Drawing.Color.Black;
            this.ProcessNoComboBox.Size = new System.Drawing.Size(180, 29);
            this.ProcessNoComboBox.Style = Sunny.UI.UIStyle.Custom;
            this.ProcessNoComboBox.StyleCustomMode = true;
            this.ProcessNoComboBox.TabIndex = 180;
            this.ProcessNoComboBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProcessNoComboBox.Watermark = "";
            this.ProcessNoComboBox.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // CodeNameTxt
            // 
            this.CodeNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CodeNameTxt.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CodeNameTxt.ForeColor = System.Drawing.Color.Black;
            this.CodeNameTxt.Location = new System.Drawing.Point(360, 116);
            this.CodeNameTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CodeNameTxt.MinimumSize = new System.Drawing.Size(1, 16);
            this.CodeNameTxt.Name = "CodeNameTxt";
            this.CodeNameTxt.RectColor = System.Drawing.Color.Black;
            this.CodeNameTxt.ShowText = false;
            this.CodeNameTxt.Size = new System.Drawing.Size(190, 29);
            this.CodeNameTxt.Style = Sunny.UI.UIStyle.Custom;
            this.CodeNameTxt.StyleCustomMode = true;
            this.CodeNameTxt.TabIndex = 181;
            this.CodeNameTxt.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.CodeNameTxt.Watermark = "按批次号/工单查询";
            this.CodeNameTxt.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // TimeQureybtn
            // 
            this.TimeQureybtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TimeQureybtn.FillColor = System.Drawing.Color.Transparent;
            this.TimeQureybtn.FillColor2 = System.Drawing.Color.Transparent;
            this.TimeQureybtn.FillHoverColor = System.Drawing.Color.DodgerBlue;
            this.TimeQureybtn.FillPressColor = System.Drawing.Color.LightGray;
            this.TimeQureybtn.FillSelectedColor = System.Drawing.Color.Transparent;
            this.TimeQureybtn.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TimeQureybtn.ForeColor = System.Drawing.Color.Black;
            this.TimeQureybtn.ForeDisableColor = System.Drawing.Color.DarkGray;
            this.TimeQureybtn.ForeHoverColor = System.Drawing.Color.LightGray;
            this.TimeQureybtn.ForePressColor = System.Drawing.Color.DarkGray;
            this.TimeQureybtn.Location = new System.Drawing.Point(1208, 113);
            this.TimeQureybtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.TimeQureybtn.Name = "TimeQureybtn";
            this.TimeQureybtn.RectColor = System.Drawing.Color.Black;
            this.TimeQureybtn.RectHoverColor = System.Drawing.Color.DarkGray;
            this.TimeQureybtn.RectPressColor = System.Drawing.Color.Gainsboro;
            this.TimeQureybtn.RectSelectedColor = System.Drawing.Color.Gainsboro;
            this.TimeQureybtn.Size = new System.Drawing.Size(111, 34);
            this.TimeQureybtn.Style = Sunny.UI.UIStyle.Custom;
            this.TimeQureybtn.StyleCustomMode = true;
            this.TimeQureybtn.TabIndex = 182;
            this.TimeQureybtn.Text = "时间查询";
            this.TimeQureybtn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimeQureybtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.TimeQureybtn.Click += new System.EventHandler(this.TimeQureybtn_Click);
            // 
            // ProcessLbl
            // 
            this.ProcessLbl.AutoSize = true;
            this.ProcessLbl.BackColor = System.Drawing.Color.Transparent;
            this.ProcessLbl.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ProcessLbl.ForeColor = System.Drawing.Color.Black;
            this.ProcessLbl.Location = new System.Drawing.Point(56, 120);
            this.ProcessLbl.Name = "ProcessLbl";
            this.ProcessLbl.Size = new System.Drawing.Size(46, 21);
            this.ProcessLbl.TabIndex = 183;
            this.ProcessLbl.Text = "工序:";
            // 
            // CodeNameLab
            // 
            this.CodeNameLab.AutoSize = true;
            this.CodeNameLab.BackColor = System.Drawing.Color.Transparent;
            this.CodeNameLab.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CodeNameLab.ForeColor = System.Drawing.Color.Black;
            this.CodeNameLab.Location = new System.Drawing.Point(299, 120);
            this.CodeNameLab.Name = "CodeNameLab";
            this.CodeNameLab.Size = new System.Drawing.Size(62, 21);
            this.CodeNameLab.TabIndex = 184;
            this.CodeNameLab.Text = "批次号:";
            // 
            // TimeNamelab
            // 
            this.TimeNamelab.AutoSize = true;
            this.TimeNamelab.BackColor = System.Drawing.Color.Transparent;
            this.TimeNamelab.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TimeNamelab.ForeColor = System.Drawing.Color.Black;
            this.TimeNamelab.Location = new System.Drawing.Point(718, 120);
            this.TimeNamelab.Name = "TimeNamelab";
            this.TimeNamelab.Size = new System.Drawing.Size(46, 21);
            this.TimeNamelab.TabIndex = 186;
            this.TimeNamelab.Text = "时间:";
            // 
            // StartTime
            // 
            this.StartTime.FillColor = System.Drawing.Color.White;
            this.StartTime.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.StartTime.Location = new System.Drawing.Point(796, 116);
            this.StartTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartTime.MaxLength = 19;
            this.StartTime.MinimumSize = new System.Drawing.Size(63, 0);
            this.StartTime.Name = "StartTime";
            this.StartTime.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.StartTime.RectColor = System.Drawing.Color.Black;
            this.StartTime.Size = new System.Drawing.Size(190, 29);
            this.StartTime.Style = Sunny.UI.UIStyle.Custom;
            this.StartTime.SymbolDropDown = 61555;
            this.StartTime.SymbolNormal = 61555;
            this.StartTime.TabIndex = 188;
            this.StartTime.Text = "2022-11-08 00:00:00";
            this.StartTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.StartTime.Value = new System.DateTime(2022, 11, 8, 0, 0, 0, 0);
            this.StartTime.Watermark = "";
            this.StartTime.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // EndTime
            // 
            this.EndTime.FillColor = System.Drawing.Color.White;
            this.EndTime.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.EndTime.Location = new System.Drawing.Point(1009, 116);
            this.EndTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EndTime.MaxLength = 19;
            this.EndTime.MinimumSize = new System.Drawing.Size(63, 0);
            this.EndTime.Name = "EndTime";
            this.EndTime.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.EndTime.RectColor = System.Drawing.Color.Black;
            this.EndTime.Size = new System.Drawing.Size(190, 29);
            this.EndTime.Style = Sunny.UI.UIStyle.Custom;
            this.EndTime.SymbolDropDown = 61555;
            this.EndTime.SymbolNormal = 61555;
            this.EndTime.TabIndex = 189;
            this.EndTime.Text = "2022-11-08 23:59:59";
            this.EndTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.EndTime.Value = new System.DateTime(2022, 11, 8, 23, 59, 59, 0);
            this.EndTime.Watermark = "";
            this.EndTime.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Timemidlab
            // 
            this.Timemidlab.AutoSize = true;
            this.Timemidlab.BackColor = System.Drawing.Color.Transparent;
            this.Timemidlab.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Timemidlab.ForeColor = System.Drawing.Color.Black;
            this.Timemidlab.Location = new System.Drawing.Point(989, 120);
            this.Timemidlab.Name = "Timemidlab";
            this.Timemidlab.Size = new System.Drawing.Size(17, 21);
            this.Timemidlab.TabIndex = 190;
            this.Timemidlab.Text = "-";
            // 
            // DatabaseSource
            // 
            this.DatabaseSource.AllowUserToAddRows = false;
            this.DatabaseSource.AllowUserToResizeRows = false;
            this.DatabaseSource.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatabaseSource.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DatabaseSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatabaseSource.DefaultCellStyle = dataGridViewCellStyle2;
            this.DatabaseSource.EnableHeadersVisualStyles = false;
            this.DatabaseSource.GridColor = System.Drawing.Color.Black;
            this.DatabaseSource.Location = new System.Drawing.Point(41, 151);
            this.DatabaseSource.MultiSelect = false;
            this.DatabaseSource.Name = "DatabaseSource";
            this.DatabaseSource.ReadOnly = true;
            this.DatabaseSource.RowHeadersVisible = false;
            this.DatabaseSource.RowHeadersWidth = 51;
            this.DatabaseSource.RowTemplate.Height = 23;
            this.DatabaseSource.Size = new System.Drawing.Size(1588, 694);
            this.DatabaseSource.TabIndex = 191;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 数采报表
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.DatabaseSource);
            this.Controls.Add(this.EndTime);
            this.Controls.Add(this.StartTime);
            this.Controls.Add(this.TimeNamelab);
            this.Controls.Add(this.ProcessLbl);
            this.Controls.Add(this.TimeQureybtn);
            this.Controls.Add(this.CodeNameTxt);
            this.Controls.Add(this.ProcessNoComboBox);
            this.Controls.Add(this.PageJump);
            this.Controls.Add(this.PagePlus);
            this.Controls.Add(this.PageMinus);
            this.Controls.Add(this.PageCo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SettingNum);
            this.Controls.Add(this.Currentpage);
            this.Controls.Add(this.导出);
            this.Controls.Add(this.CodeQureybtn);
            this.Controls.Add(this.TableTitllab);
            this.Controls.Add(this.Timemidlab);
            this.Controls.Add(this.CodeNameLab);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Name = "数采报表";
            this.Size = new System.Drawing.Size(1653, 918);
            this.Load += new System.EventHandler(this.数采报表_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private Sunny.UI.UIButton PageJump;
        private Sunny.UI.UIButton PagePlus;
        private Sunny.UI.UIButton PageMinus;
        private System.Windows.Forms.Label PageCo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SettingNum;
        private System.Windows.Forms.Label Currentpage;
        private Sunny.UI.UIButton 导出;
        private Sunny.UI.UIButton CodeQureybtn;
        private System.Windows.Forms.Label TableTitllab;
        private Sunny.UI.UIComboBox ProcessNoComboBox;
        private Sunny.UI.UITextBox CodeNameTxt;
        private Sunny.UI.UIButton TimeQureybtn;
        private System.Windows.Forms.Label ProcessLbl;
        private System.Windows.Forms.Label CodeNameLab;
        private System.Windows.Forms.Label TimeNamelab;
        private Sunny.UI.UIDatetimePicker StartTime;
        private Sunny.UI.UIDatetimePicker EndTime;
        private System.Windows.Forms.Label Timemidlab;
        private System.Windows.Forms.DataGridView DatabaseSource;
        private System.Windows.Forms.Timer timer1;
    }
}
