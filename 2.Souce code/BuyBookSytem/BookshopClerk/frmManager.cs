/******************************************************
 * 文件：frmManager.cs
 * 功能：店主操作界面UI
 * 完成者：王莉淋
 * 最后修改时间：2010年11月28日 02:23
 *
 * BUG修正：
 * 1.输出的txt文档为乱码
 *      原因：没有对文件输入输出标记固定格式
 * 
 *      已解决
 *******************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BookShopSystem
{
    public partial class frm_Manager : Form
    {
        static string path2 = System.AppDomain.CurrentDomain.BaseDirectory;//当前文件夹路径
        public frm_Manager()
        {
            InitializeComponent();
        }

        //加载“营业额库”
        private void btnMoney_Click(object sender, EventArgs e)
        {

            rtxtwindow.LoadFile(path2 + "account.txt", RichTextBoxStreamType.PlainText);
        }
        //加载“现存书库”
        private void btnExist_Click(object sender, EventArgs e)
        {
            rtxtwindow.LoadFile(path2 + "book.txt", RichTextBoxStreamType.PlainText);
        }
        //加载“历史记录库”
        private void btnHistory_Click(object sender, EventArgs e)
        {
            rtxtwindow.LoadFile(path2 + "record.txt", RichTextBoxStreamType.PlainText);
        }

        private void frm_Manager_Load(object sender, EventArgs e)
        {

        }
    }
}
