namespace BookShopSystem
{
    partial class frm_Manager
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMoney = new System.Windows.Forms.Button();
            this.btnExist = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.rtxtwindow = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnMoney
            // 
            this.btnMoney.Location = new System.Drawing.Point(236, 310);
            this.btnMoney.Name = "btnMoney";
            this.btnMoney.Size = new System.Drawing.Size(100, 23);
            this.btnMoney.TabIndex = 1;
            this.btnMoney.Text = "查看营业额";
            this.btnMoney.UseVisualStyleBackColor = true;
            this.btnMoney.Click += new System.EventHandler(this.btnMoney_Click);
            // 
            // btnExist
            // 
            this.btnExist.Location = new System.Drawing.Point(22, 310);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(100, 23);
            this.btnExist.TabIndex = 2;
            this.btnExist.Text = "查看库存";
            this.btnExist.UseVisualStyleBackColor = true;
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(461, 310);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(100, 23);
            this.btnHistory.TabIndex = 3;
            this.btnHistory.Text = "查看历史记录";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // rtxtwindow
            // 
            this.rtxtwindow.Location = new System.Drawing.Point(12, 12);
            this.rtxtwindow.Name = "rtxtwindow";
            this.rtxtwindow.Size = new System.Drawing.Size(578, 281);
            this.rtxtwindow.TabIndex = 4;
            this.rtxtwindow.Text = "";
            // 
            // frm_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 345);
            this.Controls.Add(this.rtxtwindow);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnExist);
            this.Controls.Add(this.btnMoney);
            this.Name = "frm_Manager";
            this.Text = "店主操作界面";
            this.Load += new System.EventHandler(this.frm_Manager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMoney;
        private System.Windows.Forms.Button btnExist;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.RichTextBox rtxtwindow;

    }
}