namespace ScreenDemo1.SmallForm
{
    partial class AGV叫料
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
            this.确认 = new Sunny.UI.UIButton();
            this.Transfer = new Sunny.UI.UITransfer();
            this.SuspendLayout();
            // 
            // 确认
            // 
            this.确认.BackColor = System.Drawing.Color.Transparent;
            this.确认.Cursor = System.Windows.Forms.Cursors.Hand;
            this.确认.FillColor = System.Drawing.Color.Transparent;
            this.确认.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.确认.Location = new System.Drawing.Point(634, 470);
            this.确认.MinimumSize = new System.Drawing.Size(1, 1);
            this.确认.Name = "确认";
            this.确认.RectColor = System.Drawing.Color.White;
            this.确认.Size = new System.Drawing.Size(85, 42);
            this.确认.Style = Sunny.UI.UIStyle.Custom;
            this.确认.TabIndex = 16;
            this.确认.Text = "叫料";
            this.确认.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.确认.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.确认.Click += new System.EventHandler(this.确认_Click);
            // 
            // Transfer
            // 
            this.Transfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.Transfer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Transfer.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Transfer.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Transfer.ItemsLeft.AddRange(new object[] {
            "镍钴锰酸锂",
            "石墨烯",
            "炭黑",
            "聚偏二氟乙烯",
            "甲基吡咯烷酮",
            "石墨",
            "羧甲基纤维素钠",
            "羧基丁苯胶乳"});
            this.Transfer.Location = new System.Drawing.Point(69, 89);
            this.Transfer.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.Transfer.MinimumSize = new System.Drawing.Size(1, 1);
            this.Transfer.Name = "Transfer";
            this.Transfer.Padding = new System.Windows.Forms.Padding(1);
            this.Transfer.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.Transfer.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.Transfer.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.Transfer.ShowText = false;
            this.Transfer.Size = new System.Drawing.Size(500, 350);
            this.Transfer.Style = Sunny.UI.UIStyle.Gray;
            this.Transfer.TabIndex = 17;
            this.Transfer.Text = "uiTransfer1";
            this.Transfer.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Transfer.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // AGV叫料
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(748, 539);
            this.Controls.Add(this.Transfer);
            this.Controls.Add(this.确认);
            this.Name = "AGV叫料";
            this.RectColor = System.Drawing.Color.Gray;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "AGV叫料";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 791, 424);
            this.ResumeLayout(false);
        }
        #endregion
        public Sunny.UI.UIButton 确认;
        private Sunny.UI.UITransfer Transfer;
    }
}