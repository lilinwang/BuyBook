namespace BookShopSystem
{
    partial class frmLogin
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
            this.btnloggin = new System.Windows.Forms.Button();
            this.rbnmanager = new System.Windows.Forms.RadioButton();
            this.rbndianyuan = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tebzhanghu = new System.Windows.Forms.TextBox();
            this.tebpassword = new System.Windows.Forms.TextBox();
            this.btnChangePassWord = new System.Windows.Forms.Button();
            this.lbltime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnloggin
            // 
            this.btnloggin.Location = new System.Drawing.Point(211, 156);
            this.btnloggin.Name = "btnloggin";
            this.btnloggin.Size = new System.Drawing.Size(75, 23);
            this.btnloggin.TabIndex = 0;
            this.btnloggin.Text = "登陆";
            this.btnloggin.UseVisualStyleBackColor = true;
            this.btnloggin.Click += new System.EventHandler(this.btnloggin_Click);
            // 
            // rbnmanager
            // 
            this.rbnmanager.AutoSize = true;
            this.rbnmanager.Location = new System.Drawing.Point(226, 12);
            this.rbnmanager.Name = "rbnmanager";
            this.rbnmanager.Size = new System.Drawing.Size(47, 16);
            this.rbnmanager.TabIndex = 1;
            this.rbnmanager.TabStop = true;
            this.rbnmanager.Text = "店主";
            this.rbnmanager.UseVisualStyleBackColor = true;
            this.rbnmanager.CheckedChanged += new System.EventHandler(this.rbnmanager_CheckedChanged);
            // 
            // rbndianyuan
            // 
            this.rbndianyuan.AutoSize = true;
            this.rbndianyuan.Location = new System.Drawing.Point(391, 12);
            this.rbndianyuan.Name = "rbndianyuan";
            this.rbndianyuan.Size = new System.Drawing.Size(47, 16);
            this.rbndianyuan.TabIndex = 2;
            this.rbndianyuan.TabStop = true;
            this.rbndianyuan.Text = "店员";
            this.rbndianyuan.UseVisualStyleBackColor = true;
            this.rbndianyuan.CheckedChanged += new System.EventHandler(this.rbndianyuan_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "账户";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "密码";
            // 
            // tebzhanghu
            // 
            this.tebzhanghu.Location = new System.Drawing.Point(211, 55);
            this.tebzhanghu.Name = "tebzhanghu";
            this.tebzhanghu.Size = new System.Drawing.Size(254, 21);
            this.tebzhanghu.TabIndex = 5;
            // 
            // tebpassword
            // 
            this.tebpassword.Location = new System.Drawing.Point(211, 95);
            this.tebpassword.Name = "tebpassword";
            this.tebpassword.PasswordChar = '*';
            this.tebpassword.Size = new System.Drawing.Size(254, 21);
            this.tebpassword.TabIndex = 6;
            // 
            // btnChangePassWord
            // 
            this.btnChangePassWord.Location = new System.Drawing.Point(380, 156);
            this.btnChangePassWord.Name = "btnChangePassWord";
            this.btnChangePassWord.Size = new System.Drawing.Size(75, 23);
            this.btnChangePassWord.TabIndex = 7;
            this.btnChangePassWord.Text = "修改密码";
            this.btnChangePassWord.UseVisualStyleBackColor = true;
            this.btnChangePassWord.Click += new System.EventHandler(this.btnChangePassWord_Click);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(540, 225);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(41, 12);
            this.lbltime.TabIndex = 8;
            this.lbltime.Text = "label3";
            this.lbltime.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 262);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.btnChangePassWord);
            this.Controls.Add(this.tebpassword);
            this.Controls.Add(this.tebzhanghu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbndianyuan);
            this.Controls.Add(this.rbnmanager);
            this.Controls.Add(this.btnloggin);
            this.Name = "frmlogin";
            this.Text = "登陆界面";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnloggin;
        private System.Windows.Forms.RadioButton rbnmanager;
        private System.Windows.Forms.RadioButton rbndianyuan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tebzhanghu;
        private System.Windows.Forms.TextBox tebpassword;
        private System.Windows.Forms.Button btnChangePassWord;
        private System.Windows.Forms.Label lbltime;
    }
}

