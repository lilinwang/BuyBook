/******************************************************
 * 文件：frmLogin.cs
 * 功能：登陆界面的UI
 * 完成者：刘玉夕
 * 最后修改时间：2010年11月29日 22:56
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        //判定登陆者是否为店员
        private void rbnmanager_CheckedChanged(object sender, EventArgs e)
        {
            if (rbndianyuan.Checked == true)
            {
                rbnmanager.Checked = false;
            }
        }
        //判定登陆者是否为店主
        private void rbndianyuan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnmanager.Checked == true)
            {
                rbndianyuan.Checked = false;
            }
        }

        private void btnloggin_Click(object sender, EventArgs e)
        {
            
            Login log=new Login();
            string s1 = tebzhanghu.Text;
            string s2 = tebpassword.Text;          
            if (rbnmanager.Checked == false && rbndianyuan.Checked == false)
            {
                //MessageBox.Show("111111");
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
             //   frm_Clerk clerk = new frm_Clerk();
               // clerk.ShowDialog();
                frm_Manager manager = new frm_Manager();
                manager.ShowDialog();
            //    Application.Exit();                 
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
                if (s2 != log.strss[1][m])
                {
                    MessageBox.Show("密码错误！请重新输入！");
                    return;
                }
                frm_Clerk clerk = new frm_Clerk();
                clerk.ShowDialog();
              //  Application.Exit();
            }
        }
        
        //修改密码按钮控件
        private void btnChangePassWord_Click(object sender, EventArgs e)
        {
            frmChangePassword lg = new frmChangePassword();           
            lg.ShowDialog();
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
            lbltime.Text = Convert.ToString(DateTime.Now);
        }

 
    }
}
