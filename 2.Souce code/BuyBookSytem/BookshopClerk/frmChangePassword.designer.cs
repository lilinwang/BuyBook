namespace BookShopSystem
{
    partial class frmChangePassword
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
            this.rbnmanager = new System.Windows.Forms.RadioButton();
            this.rbndianyuan = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnsure = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.tebzhanghu = new System.Windows.Forms.TextBox();
            this.teboldpassword = new System.Windows.Forms.TextBox();
            this.tebnewpassword = new System.Windows.Forms.TextBox();
            this.tebcheck = new System.Windows.Forms.TextBox();
            this.lbltime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbnmanager
            // 
            this.rbnmanager.AutoSize = true;
            this.rbnmanager.Location = new System.Drawing.Point(75, 12);
            this.rbnmanager.Name = "rbnmanager";
            this.rbnmanager.Size = new System.Drawing.Size(47, 16);
            this.rbnmanager.TabIndex = 0;
            this.rbnmanager.TabStop = true;
            this.rbnmanager.Text = "店主";
            this.rbnmanager.UseVisualStyleBackColor = true;
            this.rbnmanager.CheckedChanged += new System.EventHandler(this.rbnmanager_CheckedChanged);
            // 
            // rbndianyuan
            // 
            this.rbndianyuan.AutoSize = true;
            this.rbndianyuan.Location = new System.Drawing.Point(190, 12);
            this.rbndianyuan.Name = "rbndianyuan";
            this.rbndianyuan.Size = new System.Drawing.Size(47, 16);
            this.rbndianyuan.TabIndex = 1;
            this.rbndianyuan.TabStop = true;
            this.rbndianyuan.Text = "店员";
            this.rbndianyuan.UseVisualStyleBackColor = true;
            this.rbndianyuan.CheckedChanged += new System.EventHandler(this.rbndianyuan_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "账户";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "原密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "新密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "再次输入新密码";
            // 
            // btnsure
            // 
            this.btnsure.Location = new System.Drawing.Point(47, 310);
            this.btnsure.Name = "btnsure";
            this.btnsure.Size = new System.Drawing.Size(75, 23);
            this.btnsure.TabIndex = 6;
            this.btnsure.Text = "确认";
            this.btnsure.UseVisualStyleBackColor = true;
            this.btnsure.Click += new System.EventHandler(this.btnsure_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(175, 310);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 7;
            this.btncancel.Text = "取消";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // tebzhanghu
            // 
            this.tebzhanghu.Location = new System.Drawing.Point(60, 75);
            this.tebzhanghu.MaxLength = 12;
            this.tebzhanghu.Name = "tebzhanghu";
            this.tebzhanghu.Size = new System.Drawing.Size(190, 21);
            this.tebzhanghu.TabIndex = 8;
            // 
            // teboldpassword
            // 
            this.teboldpassword.Location = new System.Drawing.Point(60, 133);
            this.teboldpassword.MaxLength = 12;
            this.teboldpassword.Name = "teboldpassword";
            this.teboldpassword.PasswordChar = '*';
            this.teboldpassword.Size = new System.Drawing.Size(190, 21);
            this.teboldpassword.TabIndex = 9;
            // 
            // tebnewpassword
            // 
            this.tebnewpassword.Location = new System.Drawing.Point(60, 192);
            this.tebnewpassword.MaxLength = 12;
            this.tebnewpassword.Name = "tebnewpassword";
            this.tebnewpassword.PasswordChar = '*';
            this.tebnewpassword.Size = new System.Drawing.Size(190, 21);
            this.tebnewpassword.TabIndex = 10;
            // 
            // tebcheck
            // 
            this.tebcheck.Location = new System.Drawing.Point(60, 253);
            this.tebcheck.MaxLength = 12;
            this.tebcheck.Name = "tebcheck";
            this.tebcheck.PasswordChar = '*';
            this.tebcheck.Size = new System.Drawing.Size(190, 21);
            this.tebcheck.TabIndex = 11;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(188, 357);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(41, 12);
            this.lbltime.TabIndex = 12;
            this.lbltime.Text = "label5";
            this.lbltime.Click += new System.EventHandler(this.lbltime_Click);
            // 
            // frmchangepassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 393);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.tebcheck);
            this.Controls.Add(this.tebnewpassword);
            this.Controls.Add(this.teboldpassword);
            this.Controls.Add(this.tebzhanghu);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbndianyuan);
            this.Controls.Add(this.rbnmanager);
            this.Name = "frmchangepassword";
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.frmchangepassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbnmanager;
        private System.Windows.Forms.RadioButton rbndianyuan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsure;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.TextBox tebzhanghu;
        private System.Windows.Forms.TextBox teboldpassword;
        private System.Windows.Forms.TextBox tebnewpassword;
        private System.Windows.Forms.TextBox tebcheck;
        private System.Windows.Forms.Label lbltime;
    }
}