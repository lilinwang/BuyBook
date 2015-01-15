/******************************************************
 * 文件：frmLogin.cs
 * 功能：登陆界面的UI
 * 完成者：刘玉夕
 * 修改者：王莉淋
 * 最后修改时间：2010年11月30日 2:33
 * 1.当两个新密码文本框都为输入时，点击“确认按钮”，在以空字符为密码登录，login.txt读取有误
 *   原因：未单独判断两个新密码文本框是否为空
 *   
 *   已解决
 *******************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BookShopSystem
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void rbnmanager_CheckedChanged(object sender, EventArgs e)
        {
            if (rbndianyuan.Checked == true)
            {
                rbnmanager.Checked = false;
            }
        }

        private void rbndianyuan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnmanager.Checked == true)
            {
                rbndianyuan.Checked = false;
            }
        }

        private void btnsure_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            string s1 = tebzhanghu.Text;
            string s2 = teboldpassword.Text;
            string s3 = tebnewpassword.Text;
            int k = 0;
            string s4 = tebcheck.Text;
            if (rbnmanager.Checked == false && rbndianyuan.Checked == false)
            {
                MessageBox.Show("请选择店主或店员！");
                return;
            }
            if (rbnmanager.Checked == true)
            {
                if (s1 == "")
                {
                    MessageBox.Show("请输入账户！");
                    return;
                }
                if (s1 != log.strss[0][0])
                {
                    MessageBox.Show("账户有误！请确认账户或者确认店主店员选择是否有误！");
                    return;
                }
                if (s2 == "")
                {
                    MessageBox.Show("请输入密码！");
                    return;
                }
                if (s2 != log.strss[1][0])
                {
                    MessageBox.Show("密码有误！请确认账户与密码！");
                    return;
                }
                if (s3 == "")
                {
                    MessageBox.Show("请输入新密码！");
                    return;
                }
                if (s4 == "")
                {
                    MessageBox.Show("请确认新密码！");
                    return;
                }
            }
            else
            {
                int m = -1;
                if (s1 == "")
                {
                    MessageBox.Show("请输入账户！");
                    return;
                }
                if (s2 == "")
                {
                    MessageBox.Show("请输入密码！");
                    return;
                }
                for (int i = 1; i <= log.Length; i++)
                {
                    if (s1 == log.strss[0][i])
                    {
                        m = i;            
                        break;
                    }
                }
                if (m == -1)
                {
                    MessageBox.Show("该账户不存在！");
                    return;
                }
                k = m;
                if (s2 != log.strss[0][m])
                {
                    MessageBox.Show("密码有误！请确认账户与密码！");
                    return;
                }
            }
            if (!s3.Equals(s4, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("输入的两次密码不符");
                tebnewpassword.Text = "";
                tebcheck.Text = "";
                return;
            }
            log.changepassword(s3, k);
            this.Visible = false;
            frmLogin lg = new frmLogin();
            lg.ShowDialog();
            Application.Exit();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmLogin lg = new frmLogin();
            lg.ShowDialog();
            Application.Exit();
        }

        private void frmchangepassword_Load(object sender, EventArgs e)
        {
            Visible = true;
        }

        private void lbltime_Click(object sender, EventArgs e)
        {
            lbltime.Text = Convert.ToString(DateTime.Now);
        }
    }
}
