namespace ScreenDemo1.SmallForm
{
    partial class 拆批
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
            this.label57 = new System.Windows.Forms.Label();
            this.拆批后该批重量 = new Sunny.UI.UITextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.拆批批次号 = new Sunny.UI.UITextBox();
            this.确认 = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.label57.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label57.Location = new System.Drawing.Point(43, 113);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(100, 24);
            this.label57.TabIndex = 28;
            this.label57.Text = "拆批后重量";
            // 
            // 拆批后该批重量
            // 
            this.拆批后该批重量.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.拆批后该批重量.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.拆批后该批重量.Location = new System.Drawing.Point(168, 111);
            this.拆批后该批重量.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.拆批后该批重量.MinimumSize = new System.Drawing.Size(1, 16);
            this.拆批后该批重量.Name = "拆批后该批重量";
            this.拆批后该批重量.ShowText = false;
            this.拆批后该批重量.Size = new System.Drawing.Size(224, 30);
            this.拆批后该批重量.Style = Sunny.UI.UIStyle.Custom;
            this.拆批后该批重量.TabIndex = 25;
            this.拆批后该批重量.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.拆批后该批重量.Watermark = "";
            this.拆批后该批重量.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.拆批后该批重量.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNum_KeyPress);
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.label59.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label59.Location = new System.Drawing.Point(43, 64);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(100, 24);
            this.label59.TabIndex = 27;
            this.label59.Text = "拆批批次号";
            // 
            // 拆批批次号
            // 
            this.拆批批次号.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.拆批批次号.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.拆批批次号.Location = new System.Drawing.Point(168, 64);
            this.拆批批次号.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.拆批批次号.MinimumSize = new System.Drawing.Size(1, 16);
            this.拆批批次号.Name = "拆批批次号";
            this.拆批批次号.ShowText = false;
            this.拆批批次号.Size = new System.Drawing.Size(224, 30);
            this.拆批批次号.Style = Sunny.UI.UIStyle.Custom;
            this.拆批批次号.TabIndex = 24;
            this.拆批批次号.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.拆批批次号.Watermark = "";
            this.拆批批次号.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.拆批批次号.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoCn_KeyPress);
            // 
            // 确认
            // 
            this.确认.Cursor = System.Windows.Forms.Cursors.Hand;
            this.确认.FillColor = System.Drawing.Color.Transparent;
            this.确认.FillColor2 = System.Drawing.Color.Transparent;
            this.确认.FillHoverColor = System.Drawing.Color.DodgerBlue;
            this.确认.FillPressColor = System.Drawing.Color.LightGray;
            this.确认.FillSelectedColor = System.Drawing.Color.Transparent;
            this.确认.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.确认.ForeDisableColor = System.Drawing.Color.DarkGray;
            this.确认.ForePressColor = System.Drawing.Color.DarkGray;
            this.确认.Location = new System.Drawing.Point(420, 253);
            this.确认.MinimumSize = new System.Drawing.Size(1, 1);
            this.确认.Name = "确认";
            this.确认.RectColor = System.Drawing.Color.DarkGray;
            this.确认.RectHoverColor = System.Drawing.Color.DarkGray;
            this.确认.RectPressColor = System.Drawing.Color.Gainsboro;
            this.确认.RectSelectedColor = System.Drawing.Color.Gainsboro;
            this.确认.Size = new System.Drawing.Size(59, 28);
            this.确认.Style = Sunny.UI.UIStyle.Custom;
            this.确认.TabIndex = 26;
            this.确认.Text = "确认";
            this.确认.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.确认.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.确认.Click += new System.EventHandler(this.确认_Click);
            // 
            // 拆批
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(508, 328);
            this.Controls.Add(this.label57);
            this.Controls.Add(this.拆批后该批重量);
            this.Controls.Add(this.label59);
            this.Controls.Add(this.拆批批次号);
            this.Controls.Add(this.确认);
            this.Name = "拆批";
            this.RectColor = System.Drawing.Color.Gray;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "批次操作—拆批";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 791, 424);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.Label label57;
        private Sunny.UI.UITextBox 拆批后该批重量;
        private System.Windows.Forms.Label label59;
        private Sunny.UI.UITextBox 拆批批次号;
        private Sunny.UI.UIButton 确认;
    }
}