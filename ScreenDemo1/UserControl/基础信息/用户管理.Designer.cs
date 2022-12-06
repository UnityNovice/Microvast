namespace Test.NewFolder1
{
    partial class 用户管理
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.DatabaseSource = new Sunny.UI.UIDataGridView();
            this.查询 = new Sunny.UI.UIButton();
            this.修改 = new Sunny.UI.UIButton();
            this.删除 = new Sunny.UI.UIButton();
            this.新增 = new Sunny.UI.UIButton();
            this.导出 = new Sunny.UI.UIButton();
            this.PageCo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SettingNum = new System.Windows.Forms.TextBox();
            this.Currentpage = new System.Windows.Forms.Label();
            this.PageMinus = new Sunny.UI.UIButton();
            this.PagePlus = new Sunny.UI.UIButton();
            this.PageJump = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(710, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 45);
            this.label4.TabIndex = 5;
            this.label4.Text = "用户管理";
            // 
            // DatabaseSource
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.DatabaseSource.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DatabaseSource.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.DatabaseSource.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatabaseSource.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DatabaseSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatabaseSource.DefaultCellStyle = dataGridViewCellStyle8;
            this.DatabaseSource.EnableHeadersVisualStyles = false;
            this.DatabaseSource.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DatabaseSource.GridColor = System.Drawing.Color.Black;
            this.DatabaseSource.Location = new System.Drawing.Point(61, 132);
            this.DatabaseSource.Name = "DatabaseSource";
            this.DatabaseSource.RectColor = System.Drawing.Color.White;
            this.DatabaseSource.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatabaseSource.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DatabaseSource.RowHeadersWidth = 30;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            this.DatabaseSource.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DatabaseSource.RowTemplate.Height = 23;
            this.DatabaseSource.ScrollBarBackColor = System.Drawing.Color.Gray;
            this.DatabaseSource.ScrollBarColor = System.Drawing.Color.Silver;
            this.DatabaseSource.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.DatabaseSource.SelectedIndex = -1;
            this.DatabaseSource.Size = new System.Drawing.Size(1498, 638);
            this.DatabaseSource.StripeEvenColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.DatabaseSource.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.DatabaseSource.Style = Sunny.UI.UIStyle.Custom;
            this.DatabaseSource.TabIndex = 6;
            this.DatabaseSource.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // 查询
            // 
            this.查询.Cursor = System.Windows.Forms.Cursors.Hand;
            this.查询.FillColor = System.Drawing.Color.Transparent;
            this.查询.FillColor2 = System.Drawing.Color.Transparent;
            this.查询.FillHoverColor = System.Drawing.Color.DodgerBlue;
            this.查询.FillPressColor = System.Drawing.Color.LightGray;
            this.查询.FillSelectedColor = System.Drawing.Color.Transparent;
            this.查询.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.查询.ForeColor = System.Drawing.Color.Black;
            this.查询.ForeDisableColor = System.Drawing.Color.DarkGray;
            this.查询.ForePressColor = System.Drawing.Color.DarkGray;
            this.查询.Location = new System.Drawing.Point(322, 71);
            this.查询.MinimumSize = new System.Drawing.Size(1, 1);
            this.查询.Name = "查询";
            this.查询.RectColor = System.Drawing.Color.DarkGray;
            this.查询.RectHoverColor = System.Drawing.Color.DarkGray;
            this.查询.RectPressColor = System.Drawing.Color.Gainsboro;
            this.查询.RectSelectedColor = System.Drawing.Color.Gainsboro;
            this.查询.Size = new System.Drawing.Size(69, 34);
            this.查询.Style = Sunny.UI.UIStyle.Custom;
            this.查询.StyleCustomMode = true;
            this.查询.TabIndex = 27;
            this.查询.Text = "查询";
            this.查询.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.查询.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.查询.Click += new System.EventHandler(this.查询_Click);
            // 
            // 修改
            // 
            this.修改.Cursor = System.Windows.Forms.Cursors.Hand;
            this.修改.FillColor = System.Drawing.Color.Transparent;
            this.修改.FillColor2 = System.Drawing.Color.Transparent;
            this.修改.FillHoverColor = System.Drawing.Color.DodgerBlue;
            this.修改.FillPressColor = System.Drawing.Color.LightGray;
            this.修改.FillSelectedColor = System.Drawing.Color.Transparent;
            this.修改.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.修改.ForeColor = System.Drawing.Color.Black;
            this.修改.ForeDisableColor = System.Drawing.Color.DarkGray;
            this.修改.ForePressColor = System.Drawing.Color.DarkGray;
            this.修改.Location = new System.Drawing.Point(623, 71);
            this.修改.MinimumSize = new System.Drawing.Size(1, 1);
            this.修改.Name = "修改";
            this.修改.RectColor = System.Drawing.Color.DarkGray;
            this.修改.RectHoverColor = System.Drawing.Color.DarkGray;
            this.修改.RectPressColor = System.Drawing.Color.Gainsboro;
            this.修改.RectSelectedColor = System.Drawing.Color.Gainsboro;
            this.修改.Size = new System.Drawing.Size(69, 34);
            this.修改.Style = Sunny.UI.UIStyle.Custom;
            this.修改.StyleCustomMode = true;
            this.修改.TabIndex = 28;
            this.修改.Text = "修改";
            this.修改.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.修改.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // 删除
            // 
            this.删除.Cursor = System.Windows.Forms.Cursors.Hand;
            this.删除.FillColor = System.Drawing.Color.Transparent;
            this.删除.FillColor2 = System.Drawing.Color.Transparent;
            this.删除.FillHoverColor = System.Drawing.Color.DodgerBlue;
            this.删除.FillPressColor = System.Drawing.Color.LightGray;
            this.删除.FillSelectedColor = System.Drawing.Color.Transparent;
            this.删除.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.删除.ForeColor = System.Drawing.Color.Black;
            this.删除.ForeDisableColor = System.Drawing.Color.DarkGray;
            this.删除.ForePressColor = System.Drawing.Color.DarkGray;
            this.删除.Location = new System.Drawing.Point(698, 71);
            this.删除.MinimumSize = new System.Drawing.Size(1, 1);
            this.删除.Name = "删除";
            this.删除.RectColor = System.Drawing.Color.DarkGray;
            this.删除.RectHoverColor = System.Drawing.Color.DarkGray;
            this.删除.RectPressColor = System.Drawing.Color.Gainsboro;
            this.删除.RectSelectedColor = System.Drawing.Color.Gainsboro;
            this.删除.Size = new System.Drawing.Size(69, 34);
            this.删除.Style = Sunny.UI.UIStyle.Custom;
            this.删除.StyleCustomMode = true;
            this.删除.TabIndex = 29;
            this.删除.Text = "删除";
            this.删除.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.删除.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // 新增
            // 
            this.新增.Cursor = System.Windows.Forms.Cursors.Hand;
            this.新增.FillColor = System.Drawing.Color.Transparent;
            this.新增.FillColor2 = System.Drawing.Color.Transparent;
            this.新增.FillHoverColor = System.Drawing.Color.DodgerBlue;
            this.新增.FillPressColor = System.Drawing.Color.LightGray;
            this.新增.FillSelectedColor = System.Drawing.Color.Transparent;
            this.新增.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.新增.ForeColor = System.Drawing.Color.Black;
            this.新增.ForeDisableColor = System.Drawing.Color.DarkGray;
            this.新增.ForePressColor = System.Drawing.Color.DarkGray;
            this.新增.Location = new System.Drawing.Point(548, 71);
            this.新增.MinimumSize = new System.Drawing.Size(1, 1);
            this.新增.Name = "新增";
            this.新增.RectColor = System.Drawing.Color.DarkGray;
            this.新增.RectHoverColor = System.Drawing.Color.DarkGray;
            this.新增.RectPressColor = System.Drawing.Color.Gainsboro;
            this.新增.RectSelectedColor = System.Drawing.Color.Gainsboro;
            this.新增.Size = new System.Drawing.Size(69, 34);
            this.新增.Style = Sunny.UI.UIStyle.Custom;
            this.新增.StyleCustomMode = true;
            this.新增.TabIndex = 30;
            this.新增.Text = "新增";
            this.新增.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.新增.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // 导出
            // 
            this.导出.Cursor = System.Windows.Forms.Cursors.Hand;
            this.导出.FillColor = System.Drawing.Color.Transparent;
            this.导出.FillColor2 = System.Drawing.Color.Transparent;
            this.导出.FillHoverColor = System.Drawing.Color.DodgerBlue;
            this.导出.FillPressColor = System.Drawing.Color.LightGray;
            this.导出.FillSelectedColor = System.Drawing.Color.Transparent;
            this.导出.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.导出.ForeColor = System.Drawing.Color.Black;
            this.导出.ForeDisableColor = System.Drawing.Color.DarkGray;
            this.导出.ForePressColor = System.Drawing.Color.DarkGray;
            this.导出.Location = new System.Drawing.Point(773, 71);
            this.导出.MinimumSize = new System.Drawing.Size(1, 1);
            this.导出.Name = "导出";
            this.导出.RectColor = System.Drawing.Color.DarkGray;
            this.导出.RectHoverColor = System.Drawing.Color.DarkGray;
            this.导出.RectPressColor = System.Drawing.Color.Gainsboro;
            this.导出.RectSelectedColor = System.Drawing.Color.Gainsboro;
            this.导出.Size = new System.Drawing.Size(69, 34);
            this.导出.Style = Sunny.UI.UIStyle.Custom;
            this.导出.StyleCustomMode = true;
            this.导出.TabIndex = 31;
            this.导出.Text = "导出";
            this.导出.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.导出.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.导出.Click += new System.EventHandler(this.导出_Click);
            // 
            // PageCo
            // 
            this.PageCo.AutoSize = true;
            this.PageCo.BackColor = System.Drawing.Color.Transparent;
            this.PageCo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PageCo.ForeColor = System.Drawing.Color.Black;
            this.PageCo.Location = new System.Drawing.Point(661, 804);
            this.PageCo.Name = "PageCo";
            this.PageCo.Size = new System.Drawing.Size(37, 21);
            this.PageCo.TabIndex = 161;
            this.PageCo.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(635, 804);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 21);
            this.label1.TabIndex = 160;
            this.label1.Text = "/";
            // 
            // SettingNum
            // 
            this.SettingNum.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SettingNum.Location = new System.Drawing.Point(1073, 797);
            this.SettingNum.Multiline = true;
            this.SettingNum.Name = "SettingNum";
            this.SettingNum.Size = new System.Drawing.Size(91, 35);
            this.SettingNum.TabIndex = 158;
            // 
            // Currentpage
            // 
            this.Currentpage.AutoSize = true;
            this.Currentpage.BackColor = System.Drawing.Color.Transparent;
            this.Currentpage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Currentpage.ForeColor = System.Drawing.Color.Black;
            this.Currentpage.Location = new System.Drawing.Point(611, 804);
            this.Currentpage.Name = "Currentpage";
            this.Currentpage.Size = new System.Drawing.Size(19, 21);
            this.Currentpage.TabIndex = 155;
            this.Currentpage.Text = "1";
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
            this.PageMinus.ForePressColor = System.Drawing.Color.DarkGray;
            this.PageMinus.Location = new System.Drawing.Point(397, 797);
            this.PageMinus.MinimumSize = new System.Drawing.Size(1, 1);
            this.PageMinus.Name = "PageMinus";
            this.PageMinus.RectColor = System.Drawing.Color.DarkGray;
            this.PageMinus.RectHoverColor = System.Drawing.Color.DarkGray;
            this.PageMinus.RectPressColor = System.Drawing.Color.Gainsboro;
            this.PageMinus.RectSelectedColor = System.Drawing.Color.Gainsboro;
            this.PageMinus.Size = new System.Drawing.Size(89, 35);
            this.PageMinus.Style = Sunny.UI.UIStyle.Custom;
            this.PageMinus.StyleCustomMode = true;
            this.PageMinus.TabIndex = 162;
            this.PageMinus.Text = "上一页";
            this.PageMinus.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PageMinus.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.PageMinus.Click += new System.EventHandler(this.PageMinus_Click);
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
            this.PagePlus.ForePressColor = System.Drawing.Color.DarkGray;
            this.PagePlus.Location = new System.Drawing.Point(802, 797);
            this.PagePlus.MinimumSize = new System.Drawing.Size(1, 1);
            this.PagePlus.Name = "PagePlus";
            this.PagePlus.RectColor = System.Drawing.Color.DarkGray;
            this.PagePlus.RectHoverColor = System.Drawing.Color.DarkGray;
            this.PagePlus.RectPressColor = System.Drawing.Color.Gainsboro;
            this.PagePlus.RectSelectedColor = System.Drawing.Color.Gainsboro;
            this.PagePlus.Size = new System.Drawing.Size(89, 35);
            this.PagePlus.Style = Sunny.UI.UIStyle.Custom;
            this.PagePlus.StyleCustomMode = true;
            this.PagePlus.TabIndex = 163;
            this.PagePlus.Text = "下一页";
            this.PagePlus.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PagePlus.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.PagePlus.Click += new System.EventHandler(this.PagePlus_Click);
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
            this.PageJump.ForePressColor = System.Drawing.Color.DarkGray;
            this.PageJump.Location = new System.Drawing.Point(1170, 797);
            this.PageJump.MinimumSize = new System.Drawing.Size(1, 1);
            this.PageJump.Name = "PageJump";
            this.PageJump.RectColor = System.Drawing.Color.DarkGray;
            this.PageJump.RectHoverColor = System.Drawing.Color.DarkGray;
            this.PageJump.RectPressColor = System.Drawing.Color.Gainsboro;
            this.PageJump.RectSelectedColor = System.Drawing.Color.Gainsboro;
            this.PageJump.Size = new System.Drawing.Size(89, 35);
            this.PageJump.Style = Sunny.UI.UIStyle.Custom;
            this.PageJump.StyleCustomMode = true;
            this.PageJump.TabIndex = 164;
            this.PageJump.Text = "跳转";
            this.PageJump.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PageJump.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.PageJump.Click += new System.EventHandler(this.PageJump_Click);
            // 
            // 用户管理
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PageJump);
            this.Controls.Add(this.PagePlus);
            this.Controls.Add(this.PageMinus);
            this.Controls.Add(this.PageCo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SettingNum);
            this.Controls.Add(this.Currentpage);
            this.Controls.Add(this.导出);
            this.Controls.Add(this.新增);
            this.Controls.Add(this.删除);
            this.Controls.Add(this.修改);
            this.Controls.Add(this.查询);
            this.Controls.Add(this.DatabaseSource);
            this.Controls.Add(this.label4);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "用户管理";
            this.Size = new System.Drawing.Size(1653, 870);
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.Label label4;
        private Sunny.UI.UIDataGridView DatabaseSource;
        private Sunny.UI.UIButton 查询;
        private Sunny.UI.UIButton 修改;
        private Sunny.UI.UIButton 删除;
        private Sunny.UI.UIButton 新增;
        private Sunny.UI.UIButton 导出;
        private System.Windows.Forms.Label PageCo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SettingNum;
        private System.Windows.Forms.Label Currentpage;
        private Sunny.UI.UIButton PageMinus;
        private Sunny.UI.UIButton PagePlus;
        private Sunny.UI.UIButton PageJump;
    }
}
