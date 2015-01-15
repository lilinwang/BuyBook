/******************************************************
 * 文件：Account.cs
 * 功能：对营业额库（account）的操作
 * 完成者：王莉淋
 * 最后修改时间：2010年11月29日 22:36
 *
 * BUG修正：
 * 1.输出的txt文档为乱码
 *      原因：没有对文件输入输出标记固定格式
 * 
 *      已解决
 *      
 * 2.更新月记录时删除了上一个月的记录
 *      原因：用这个月的记录覆盖了上个月的记录
 *      
 *      已解决
 *      
 * 3.各个datetime类型的比较出现问题
 *      原因：有用的信息为年月日，记录时也记录了时分秒
 *      
 *      已解决
 *      
 * 4.数据有错误
 *      原因：BUY和SALE的状态没能有效区分
 *      
 *      已解决
 *******************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BookShopSystem
{
    //对营业额库（account）的操作器
    public class AccountHandler
    {
        /// <summary>
        /// 店员“进货”时对“营业额库（account）”的更新
        /// </summary>
        /// <param name="path">String 现存书库文件路径</param>
        /// <param name="s">String 需要更新的书的信息</param>
        /// <param name="num">Int 需要更新的书的数量</param>
        public void UpdataBuy(string s, string path, Int32 num)
        {
            MoneyBase money = new MoneyBase(s, 0, num);
            string[] lines = new string[100];
            StreamReader sw_info = new StreamReader(path);//读入营业额库的信息
            for (Int32 i = 0; !sw_info.EndOfStream; i++)
            {
                lines[i] = sw_info.ReadLine();
            }
            sw_info.Close();
            string[] str = lines[1].Split(' ');
            string[] str1 = new string[100];
            //如果上一条记录的datatime<today，则删除一个旧的日期（day）的记录
            if (DateTime.Compare(money.time, Convert.ToDateTime(str[3])) > 0)
            {
                //如果今天是该月的1号，则删除一个旧的月份（mouth）的记录。添加一个新的月份的记录
                if ((money.time).Day == 1)
                {
                    FileStream aFile = new FileStream(path, FileMode.Create);
                    StreamWriter sw = new StreamWriter(aFile, System.Text.Encoding.UTF8);
                    sw.WriteLine(lines[0]);
                    sw.WriteLine(money.GetAccount());
                    for (Int32 j = 1; j < 30; j++)
                    {
                        sw.WriteLine(lines[j]);
                    }
                    sw.WriteLine(lines[31]);
                    sw.WriteLine(money.GetAccount());
                    for (Int32 j = 32; j < 43; j++)
                    {
                        sw.WriteLine(lines[j]);
                    }
                    sw.Close();
                }
                else
                {
                    FileStream aFile = new FileStream(path, FileMode.Create);
                    StreamWriter sw = new StreamWriter(aFile, System.Text.Encoding.UTF8);
                    sw.WriteLine(lines[0]);
                    sw.WriteLine(money.GetAccount());
                    for (Int32 j = 1; j < 30; j++)
                    {
                        sw.WriteLine(lines[j]);
                    }
                    sw.WriteLine(lines[31]);
                    str1 = lines[32].Split(' ');
                    //如果今天不是该月的1号，但是是新的一月的最早的记录（当前月比上一条记录的月份晚），则删除一个旧的月份记录，添加一个新的月份记录
                    if (Convert.ToDateTime(str1[3]).Month == money.time.Month)                       
                    {
                        string ss = Convert.ToString(Convert.ToDouble(str1[0]) + money.totalmoney) + ' ' + str1[1] + ' ' + Convert.ToString(Convert.ToDouble(str1[2]) - money.totalmoney) + ' ' + Convert.ToString(money.time);
                        lines[32] = ss;
                        for (Int32 j = 32; j < 44; j++)
                        {
                            sw.WriteLine(lines[j]);
                        }
                        
                    }
                    //如果今天不是该月的最早记录，则更新该月记录
                    else
                    {
                        sw.WriteLine(money.GetAccount());
                        for (Int32 j = 32; j < 43; j++)
                        {
                            sw.WriteLine(lines[j]);
                        }
                    }
                    sw.Close();
                }
            }
            //如果当前的日期与最新记录的日期相同，则更新改日的记录和该月的记录
            else
            {
                FileStream aFile = new FileStream(path, FileMode.Create);
                StreamWriter sw = new StreamWriter(aFile, System.Text.Encoding.UTF8);
                sw.WriteLine(lines[0]);
                str1 = lines[1].Split(' ');
                string ss = Convert.ToString(Convert.ToDouble(str1[0]) + money.totalmoney) + ' ' + str1[1] + ' ' + Convert.ToString(Convert.ToDouble(str1[2]) - money.totalmoney) + ' ' + Convert.ToString(money.time);
                lines[1] = ss;
                for (Int32 j = 1; j < 32; j++)
                {
                    sw.WriteLine(lines[j]);
                }
                str1 = lines[32].Split(' ');
                ss = Convert.ToString(Convert.ToDouble(str1[0]) + money.totalmoney) + ' ' + str1[1] + ' ' + Convert.ToString(Convert.ToDouble(str1[2]) - money.totalmoney) + ' ' + Convert.ToString(money.time);
                lines[32] = ss;
                for (Int32 j = 32; j < 44; j++)
                {
                    sw.WriteLine(lines[j]);
                }
                sw.Close();
            }

        }

        /// <summary>
        /// 店员“售出”时对“营业额库（account）”的更新
        /// </summary>
        /// <param name="path">String 现存书库文件路径</param>
        /// <param name="s">String 需要更新的书的信息</param>
        /// <param name="num">Int 需要更新的书的数量</param>
        public void UpdataSale(string s, string path, Int32 num)
        {
            MoneyBase money = new MoneyBase(s, 1, num);
            string[] lines = new string[100];
            StreamReader sw_info = new StreamReader(path);//读入营业额库的信息
            for (Int32 i = 0; !sw_info.EndOfStream; i++)
            {
                lines[i] = sw_info.ReadLine();
            }
            sw_info.Close();
            string[] str = lines[1].Split(' ');
            string[] str1 = new string[100];
            if (DateTime.Compare(money.time, Convert.ToDateTime(str[3])) > 0)//如果上一条记录的datatime<today，则删除一个旧的日期（day）
            {
                if ((money.time).Day == 1)
                {
                    FileStream aFile = new FileStream(path, FileMode.Create);
                    StreamWriter sw = new StreamWriter(aFile, System.Text.Encoding.UTF8);
                    sw.WriteLine(lines[0]);
                    sw.WriteLine(money.GetAccount());
                    for (Int32 j = 1; j < 30; j++)
                    {
                        sw.WriteLine(lines[j]);
                    }
                    sw.WriteLine(lines[31]);
                    sw.WriteLine(money.GetAccount());
                    for (Int32 j = 32; j < 43; j++)
                    {
                        sw.WriteLine(lines[j]);
                    }
                    sw.Close();
                }
                else
                {
                    FileStream aFile = new FileStream(path, FileMode.Create);
                    StreamWriter sw = new StreamWriter(aFile, System.Text.Encoding.UTF8);
                    sw.WriteLine(lines[0]);
                    sw.WriteLine(money.GetAccount());
                    for (Int32 j = 1; j < 30; j++)
                    {
                        sw.WriteLine(lines[j]);
                    }
                    sw.WriteLine(lines[31]);
                    str1 = lines[32].Split(' ');
                    //如果今天不是该月的1号，但是是新的一月的最早的记录（当前月比上一条记录的月份晚），则删除一个旧的月份记录，添加一个新的月份记录
                    if (Convert.ToDateTime(str1[3]).Month == money.time.Month)
                    {
                        string ss = Convert.ToString(Convert.ToDouble(str1[0]) + money.totalmoney) + ' ' + str1[1] + ' ' + Convert.ToString(Convert.ToDouble(str1[2]) - money.totalmoney) + ' ' + Convert.ToString(money.time);
                        lines[32] = ss;
                        for (Int32 j = 32; j < 44; j++)
                        {
                            sw.WriteLine(lines[j]);
                        }

                    }
                    //如果今天不是该月的最早记录，则更新该月记录
                    else
                    {
                        sw.WriteLine(money.GetAccount());
                        for (Int32 j = 32; j < 43; j++)
                        {
                            sw.WriteLine(lines[j]);
                        }
                    }
                    sw.Close();
                }
            }
            //如果当前的日期与最新记录的日期相同，则更新改日的记录和该月的记录
            else
            {
                FileStream aFile = new FileStream(path, FileMode.Create);
                StreamWriter sw = new StreamWriter(aFile, System.Text.Encoding.UTF8);
                sw.WriteLine(lines[0]);
                str1 = lines[1].Split(' ');
                string ss = str1[0] + ' ' + Convert.ToString(Convert.ToDouble(str1[1]) + money.totalmoney) + ' ' + Convert.ToString(Convert.ToDouble(str1[2]) + money.totalmoney )+ ' ' + Convert.ToString(money.time);
                lines[1] = ss;
                for (Int32 j = 1; j < 32; j++)
                {
                    sw.WriteLine(lines[j]);
                }
                str1 = lines[32].Split(' ');
                ss = str1[0] + ' ' + Convert.ToString(Convert.ToDouble(str1[1]) + money.totalmoney) + ' ' + Convert.ToString(Convert.ToDouble(str1[2]) + money.totalmoney) + ' ' + Convert.ToString(money.time);
                lines[32] = ss;
                for (Int32 j = 32; j < 44; j++)
                {
                    sw.WriteLine(lines[j]);
                }
                sw.Close();
            }

        }

    }
}
