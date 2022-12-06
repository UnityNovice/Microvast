namespace ScreenDemo1
{
    partial class Form1
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
        #region Windows 窗体设计器生成的代码
        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.UserName = new Sunny.UI.UILabel();
            this.label1 = new System.Windows.Forms.Label();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.Menu1 = new Sunny.UI.UINavMenu();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.UserNum = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.Permissions = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ScreenDemo1.Properties.Resources.英文组合Logo;
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.uiPanel1.FillColor = System.Drawing.Color.Transparent;
            this.uiPanel1.FillColor2 = System.Drawing.Color.Transparent;
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.ForeColor = System.Drawing.Color.Silver;
            this.uiPanel1.Location = new System.Drawing.Point(263, 117);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.White;
            this.uiPanel1.Size = new System.Drawing.Size(1653, 918);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.StyleCustomMode = true;
            this.uiPanel1.TabIndex = 2;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.UserName.ForeColor = System.Drawing.Color.Black;
            this.UserName.Location = new System.Drawing.Point(1774, 3);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(53, 21);
            this.UserName.Style = Sunny.UI.UIStyle.Custom;
            this.UserName.TabIndex = 4;
            this.UserName.Text = "Eysen";
            this.UserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserName.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(712, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 52);
            this.label1.TabIndex = 5;
            this.label1.Text = "Microvast Software";
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.ForeColor = System.Drawing.Color.Black;
            this.uiLabel1.Location = new System.Drawing.Point(1691, 3);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(74, 21);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 6;
            this.uiLabel1.Text = "用户名：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Menu1
            // 
            this.Menu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Menu1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Menu1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.Menu1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Menu1.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.Menu1.ForeColor = System.Drawing.Color.White;
            this.Menu1.FullRowSelect = true;
            this.Menu1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(210)))));
            this.Menu1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Menu1.Indent = 50;
            this.Menu1.ItemHeight = 50;
            this.Menu1.LineColor = System.Drawing.Color.Gainsboro;
            this.Menu1.Location = new System.Drawing.Point(4, 117);
            this.Menu1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.Menu1.Name = "Menu1";
            this.Menu1.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Menu1.ScrollBarHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Menu1.ScrollBarPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Menu1.ScrollFillColor = System.Drawing.Color.White;
            this.Menu1.SecondBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Menu1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(210)))));
            this.Menu1.SelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(210)))));
            this.Menu1.SelectedColorGradient = true;
            this.Menu1.SelectedForeColor = System.Drawing.Color.White;
            this.Menu1.SelectedHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(210)))));
            this.Menu1.ShowLines = false;
            this.Menu1.ShowNodeToolTips = true;
            this.Menu1.ShowOneNode = true;
            this.Menu1.ShowSecondBackColor = true;
            this.Menu1.ShowTips = true;
            this.Menu1.Size = new System.Drawing.Size(259, 914);
            this.Menu1.Style = Sunny.UI.UIStyle.Custom;
            this.Menu1.StyleCustomMode = true;
            this.Menu1.TabIndex = 8;
            this.Menu1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Menu1.TipsForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.Menu1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Menu1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.uiNavMenu1_NodeMouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(232)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.uiLabel3);
            this.panel1.Controls.Add(this.UserNum);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.uiLabel2);
            this.panel1.Controls.Add(this.uiLabel1);
            this.panel1.Controls.Add(this.Permissions);
            this.panel1.Controls.Add(this.UserName);
            this.panel1.ForeColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(3, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1913, 82);
            this.panel1.TabIndex = 9;
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.ForeColor = System.Drawing.Color.Black;
            this.uiLabel3.Location = new System.Drawing.Point(1691, 28);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(58, 21);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 9;
            this.uiLabel3.Text = "工号：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // UserNum
            // 
            this.UserNum.AutoSize = true;
            this.UserNum.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.UserNum.ForeColor = System.Drawing.Color.Black;
            this.UserNum.Location = new System.Drawing.Point(1774, 28);
            this.UserNum.Name = "UserNum";
            this.UserNum.Size = new System.Drawing.Size(73, 21);
            this.UserNum.Style = Sunny.UI.UIStyle.Custom;
            this.UserNum.TabIndex = 8;
            this.UserNum.Text = "2200214";
            this.UserNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserNum.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.Black;
            this.uiLabel2.Location = new System.Drawing.Point(1691, 53);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(58, 21);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 7;
            this.uiLabel2.Text = "角色：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Permissions
            // 
            this.Permissions.AutoSize = true;
            this.Permissions.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Permissions.ForeColor = System.Drawing.Color.Black;
            this.Permissions.Location = new System.Drawing.Point(1774, 53);
            this.Permissions.Name = "Permissions";
            this.Permissions.Size = new System.Drawing.Size(58, 21);
            this.Permissions.Style = Sunny.UI.UIStyle.Custom;
            this.Permissions.TabIndex = 3;
            this.Permissions.Text = "管理员";
            this.Permissions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Permissions.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1040);
            this.Controls.Add(this.Menu1);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "MicrovastV1";
            this.TitleColor = System.Drawing.Color.LightGray;
            this.TitleForeColor = System.Drawing.Color.Black;
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 800, 450);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel UserName;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UINavMenu Menu1;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel Permissions;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel UserNum;
    }
}
