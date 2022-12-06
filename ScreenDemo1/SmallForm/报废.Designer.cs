namespace ScreenDemo1.SmallForm
{
    partial class 报废
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(报废));
            this.确定 = new Sunny.UI.UIButton();
            this.label58 = new System.Windows.Forms.Label();
            this.报废重量 = new Sunny.UI.UITextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.报废批次号 = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // 确定
            // 
            this.确定.BackColor = System.Drawing.Color.Transparent;
            this.确定.Cursor = System.Windows.Forms.Cursors.Hand;
            this.确定.FillColor = System.Drawing.Color.Transparent;
            this.确定.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.确定.Location = new System.Drawing.Point(354, 235);
            this.确定.MinimumSize = new System.Drawing.Size(1, 1);
            this.确定.Name = "确定";
            this.确定.RectColor = System.Drawing.Color.White;
            this.确定.Size = new System.Drawing.Size(58, 25);
            this.确定.Style = Sunny.UI.UIStyle.Custom;
            this.确定.TabIndex = 16;
            this.确定.Text = "确认";
            this.确定.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.确定.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.确定.Click += new System.EventHandler(this.保存_Click);
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.label58.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label58.Location = new System.Drawing.Point(37, 127);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(86, 24);
            this.label58.TabIndex = 33;
            this.label58.Text = "报废数量:";
            // 
            // 报废重量
            // 
            this.报废重量.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.报废重量.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.报废重量.Location = new System.Drawing.Point(138, 124);
            this.报废重量.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.报废重量.MinimumSize = new System.Drawing.Size(1, 16);
            this.报废重量.Name = "报废重量";
            this.报废重量.ShowText = false;
            this.报废重量.Size = new System.Drawing.Size(295, 30);
            this.报废重量.Style = Sunny.UI.UIStyle.Custom;
            this.报废重量.TabIndex = 30;
            this.报废重量.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.报废重量.Watermark = "";
            this.报废重量.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.报废重量.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNum_KeyPress);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.label60.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label60.Location = new System.Drawing.Point(19, 66);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(104, 24);
            this.label60.TabIndex = 32;
            this.label60.Text = "报废批次号:";
            // 
            // 报废批次号
            // 
            this.报废批次号.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.报废批次号.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.报废批次号.Location = new System.Drawing.Point(138, 64);
            this.报废批次号.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.报废批次号.MinimumSize = new System.Drawing.Size(1, 16);
            this.报废批次号.Name = "报废批次号";
            this.报废批次号.ShowText = false;
            this.报废批次号.Size = new System.Drawing.Size(295, 30);
            this.报废批次号.Style = Sunny.UI.UIStyle.Custom;
            this.报废批次号.TabIndex = 29;
            this.报废批次号.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.报废批次号.Watermark = "";
            this.报废批次号.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.报废批次号.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoCn_KeyPress);
            // 
            // 报废
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(494, 318);
            this.Controls.Add(this.label58);
            this.Controls.Add(this.报废重量);
            this.Controls.Add(this.label60);
            this.Controls.Add(this.报废批次号);
            this.Controls.Add(this.确定);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "报废";
            this.RectColor = System.Drawing.Color.Gray;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "批次操作—报废";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 791, 424);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        public Sunny.UI.UIButton 确定;
        private System.Windows.Forms.Label label58;
        private Sunny.UI.UITextBox 报废重量;
        private System.Windows.Forms.Label label60;
        private Sunny.UI.UITextBox 报废批次号;
    }
}