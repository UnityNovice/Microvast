namespace ScreenDemo1.Components.通用弹窗
{
    partial class 通用弹窗
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
            this.SaveBtn = new Sunny.UI.UIButton();
            this.itemPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Transparent;
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.FillColor = System.Drawing.Color.Transparent;
            this.SaveBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SaveBtn.ForeColor = System.Drawing.Color.Black;
            this.SaveBtn.Location = new System.Drawing.Point(565, 578);
            this.SaveBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(71, 35);
            this.SaveBtn.Style = Sunny.UI.UIStyle.Custom;
            this.SaveBtn.StyleCustomMode = true;
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "保存";
            this.SaveBtn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SaveBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // itemPanel
            // 
            this.itemPanel.Location = new System.Drawing.Point(37, 63);
            this.itemPanel.Name = "itemPanel";
            this.itemPanel.Size = new System.Drawing.Size(1131, 499);
            this.itemPanel.TabIndex = 3;
            // 
            // 通用弹窗
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1204, 625);
            this.Controls.Add(this.itemPanel);
            this.Controls.Add(this.SaveBtn);
            this.Name = "通用弹窗";
            this.RectColor = System.Drawing.Color.White;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "通用弹窗";
            this.TitleColor = System.Drawing.Color.Gray;
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.ResumeLayout(false);
        }
        #endregion
        private Sunny.UI.UIButton SaveBtn;
        private System.Windows.Forms.Panel itemPanel;
    }
}