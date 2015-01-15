/******************************************************
 * 文件：frmManager.cs
 * 功能：店员操作界面UI
 * 完成者：王莉淋
 * 最后修改时间：2010年11月30日 03:00
 *
 * BUG修正：
 * 1.输出的txt文档为乱码
 *      原因：没有对文件输入输出标记固定格式
 * 
 *      已解决
 *      
 * 2.对于不合法的输入（如负数、字符等），仍会对“营业额库”和“历史记录库”更新
 *      原因：判定不合法的输入后没有退出
 *      
 *      已解决
 * 
 * 3.对于数量文本框和ISBN文本框为空，也可进行更新，出现不必要的更新
 *      原因：未判断数量文本框和ISBN文本框为空
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
    public partial class frm_Clerk : Form
    {
        private int booknumber=0;//需要更新的书的数量（进货的数量或售出的数量）
        private string CodeISBN="";//ISBN码
        static string path2 = System.AppDomain.CurrentDomain.BaseDirectory;//当前文件夹路径
        
        public frm_Clerk()
        {
            InitializeComponent();
        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {
            CodeISBN = txtISBN.Text;
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            string str = txtNumber.Text;
            try
            {
                booknumber = Int16.Parse(str);
                if (booknumber == 0) {MessageBox.Show("数量不能为零！") ;};//判定不合法的输入
                if (booknumber < 0) { MessageBox.Show("数量不能为负数！"); };//判定不合法的输入
            }
            catch (Exception)
            {
                MessageBox.Show("请输入一个数字");
                txtNumber.Text = "";
                str = txtNumber.Text;
            }
        }
        
       
        //店员“进货”时，对每个库的更新
        private void btn_Buy_Click(object sender, EventArgs e)
        {
            if (booknumber == 0) 
            {
                MessageBox.Show("请输入数量！");
                return;
            }
            if (CodeISBN == "")
            {
                MessageBox.Show("请输入ISBN码！");
                return;
            }
            ISBN Isbn = new ISBN(CodeISBN);
            string s = Isbn.search(path2+"isbn.txt");
            if (s == " ")
            {
                MessageBox.Show("ISBN库中没有该本书！");
            }
            else
            {
                BookBaseHandler book = new BookBaseHandler();
                book.UpdataBuy(s, path2 + "book.txt", booknumber);
                RecordHandler record = new RecordHandler();
                record.UpdataBuy(s, path2 + "record.txt", booknumber);
                AccountHandler account = new AccountHandler();
                account.UpdataBuy(s, path2 + "account.txt", booknumber);
                MessageBox.Show("信息录入成功！");
            }
        }

        //店员“售出”时，对每个库的更新
        private void btn_Sell_Click(object sender, EventArgs e)
        {
            if (booknumber == 0)
            {
                MessageBox.Show("请输入数量！");
                return;
            }
            if (CodeISBN == "")
            {
                MessageBox.Show("请输入ISBN码！");
                return;
            }
            ISBN Isbn = new ISBN(CodeISBN);
            string s = Isbn.search(path2 + "isbn.txt");
            if (s == " ")
            {
                MessageBox.Show("ISBN库中没有该本书！");
            }
            else
            {
                BookBaseHandler book = new BookBaseHandler();
                Int32 tem;
                tem = book.UpdataSale(s, path2 + "book.txt", booknumber);
                if (tem == 0)
                {
                    MessageBox.Show("这本书的没有库存了！");
                }
                else
                {
                    if (tem != -1) MessageBox.Show("这本书的库存仅余" + Convert.ToString(tem) + "! " + "库存不足！");
                    else
                    {
                        RecordHandler record = new RecordHandler();
                        record.UpdataSale(s, path2 + "record.txt", booknumber);
                        AccountHandler account = new AccountHandler();
                        account.UpdataSale(s, path2 + "account.txt", booknumber);
                        MessageBox.Show("信息录入成功！");
                    }
                }
                
            }
        }
    }
}