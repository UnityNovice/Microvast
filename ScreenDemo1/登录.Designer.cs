namespace Test
{
    partial class 登录
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(登录));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.ComboBox();
            this.登录btn = new Sunny.UI.UIButton();
            this.CanelBtn = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPassword.Location = new System.Drawing.Point(130, 154);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(206, 29);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.Text = "123456";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(34, 157);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(90, 21);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "登录密码：";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(34, 120);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(58, 21);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "工号：";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUser.FormattingEnabled = true;
            this.txtUser.Items.AddRange(new object[] {
            "admin",
            "Eysen"});
            this.txtUser.Location = new System.Drawing.Point(130, 117);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(206, 29);
            this.txtUser.TabIndex = 12;
            this.txtUser.Text = "0000000";
            // 
            // 登录btn
            // 
            this.登录btn.BackColor = System.Drawing.Color.Transparent;
            this.登录btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.登录btn.FillColor = System.Drawing.Color.Transparent;
            this.登录btn.FillColor2 = System.Drawing.Color.Transparent;
            this.登录btn.FillHoverColor = System.Drawing.Color.Gray;
            this.登录btn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.登录btn.ForeColor = System.Drawing.Color.Black;
            this.登录btn.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(204)))));
            this.登录btn.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(204)))));
            this.登录btn.Location = new System.Drawing.Point(130, 277);
            this.登录btn.MinimumSize = new System.Drawing.Size(1, 1);
            this.登录btn.Name = "登录btn";
            this.登录btn.RectColor = System.Drawing.Color.Black;
            this.登录btn.Size = new System.Drawing.Size(73, 35);
            this.登录btn.Style = Sunny.UI.UIStyle.Custom;
            this.登录btn.TabIndex = 16;
            this.登录btn.Text = "登录";
            this.登录btn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.登录btn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.登录btn.Click += new System.EventHandler(this.登录按钮_Click);
            // 
            // CanelBtn
            // 
            this.CanelBtn.BackColor = System.Drawing.Color.Transparent;
            this.CanelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CanelBtn.FillColor = System.Drawing.Color.Transparent;
            this.CanelBtn.FillColor2 = System.Drawing.Color.Transparent;
            this.CanelBtn.FillHoverColor = System.Drawing.Color.Gray;
            this.CanelBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CanelBtn.ForeColor = System.Drawing.Color.Black;
            this.CanelBtn.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(204)))));
            this.CanelBtn.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(204)))));
            this.CanelBtn.Location = new System.Drawing.Point(263, 277);
            this.CanelBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.CanelBtn.Name = "CanelBtn";
            this.CanelBtn.RectColor = System.Drawing.Color.Black;
            this.CanelBtn.Size = new System.Drawing.Size(73, 35);
            this.CanelBtn.Style = Sunny.UI.UIStyle.Custom;
            this.CanelBtn.TabIndex = 18;
            this.CanelBtn.Text = "取消";
            this.CanelBtn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CanelBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.CanelBtn.Click += new System.EventHandler(this.取消_Click);
            // 
            // 登录
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(472, 349);
            this.Controls.Add(this.CanelBtn);
            this.Controls.Add(this.登录btn);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "登录";
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "登录";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.TitleForeColor = System.Drawing.Color.Black;
            this.TopMost = true;
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 472, 349);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.登录_FormClosing);
            this.Load += new System.EventHandler(this.登录_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ComboBox txtUser;
        private Sunny.UI.UIButton 登录btn;
        private Sunny.UI.UIButton CanelBtn;
    }
}