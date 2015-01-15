/******************************************************
 * 文件：Record.cs
 * 功能：对历史记录库（record）的操作
 * 完成者：王莉淋
 * 最后修改时间：2010年11月29日 22:56
 *
 * BUG修正：
 * 1.输出的txt文档为乱码
 *      原因：没有对文件输入输出标记固定格式
 * 
 *      已解决
 *      
 * 2.对于当前月的销售记录不是从1号开始时，不能更新“历史记录库（record）”
 *      原因：在判定是否要删除多余月份的记录时，是以当前日是否是1号
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
    //对历史记录库（record）的操作器
    public class RecordHandler
    {
        /// <summary>
        /// 店员“进货”时对“历史记录库（record）”的更新
        /// </summary>
        /// <param name="path">String 现存书库文件路径</param>
        /// <param name="s">String 需要更新的书的信息</param>
        /// <param name="num">Int 需要更新的书的数量</param>
        public void UpdataBuy(string s, string path,Int32 num)
        {
            MoneyBase money = new MoneyBase(s, 0,num);
            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            string[] lines2 = File.ReadAllLines(path, Encoding.UTF8);
            string[] str = lines[0].Split(' ');
            Int32 flag=lines.Length;
            if (DateTime.Compare(money.time, Convert.ToDateTime(str[5]))>0)//如果上一条记录的datatime<today，则删除一个旧的日期（day）
            {
                string[] str2,str3;
                str2 = lines[lines.Length - 1].Split(' ');
                for (Int32 i = lines.Length - 2; (i > 0)&&(flag==lines.Length); i--) 
                { 
                    str3 = lines[i].Split(' ');
                    if ((str2[5])!=(str3[5]))
                    {
                        flag=i+1;
                    }
                }
            }    
            FileStream aFile = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(aFile, System.Text.Encoding.UTF8);
          //  StreamWriter(".\\test.txt", true, System.Text.Encoding.Default);
            sw.WriteLine(money.GetRecord());
            for (Int32 i = 0; i < flag; i++)
            {
                sw.WriteLine(lines2[i]);
            }
            sw.Close();
        }

        /// <summary>
        /// 店员“售书”时对“历史记录库（record）”的更新
        /// </summary>
        /// <param name="path">String 现存书库文件路径</param>
        /// <param s="path">String 需要更新的书的信息</param>
        /// <param num="path">Int 需要更新的书的数量</param>
        public void UpdataSale(string s, string path, Int32 num)
        {
            MoneyBase money = new MoneyBase(s, 1, num);
            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            string[] lines2 = File.ReadAllLines(path, Encoding.UTF8);
            string[] str = lines[0].Split(' ');
            Int32 flag = lines.Length;
            if (DateTime.Compare(money.time, Convert.ToDateTime(str[5])) > 0)//如果上一条记录的datatime<today，则删除一个旧的日期（day）
            {
                string[] str2, str3;
                str2 = lines[lines.Length - 1].Split(' ');
                for (Int32 i = lines.Length - 2; (i > 0) && (flag == lines.Length); i--)
                {
                    str3 = lines[i].Split(' ');
                    if (str2[5] != str3[5])
                    {
                        flag = i + 1;
                    }
                }
            }
            FileStream aFile = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(aFile,System.Text.Encoding.UTF8);
            sw.WriteLine(money.GetRecord());
            for (int i = 0; i < flag; i++)
            {
                sw.WriteLine(lines2[i]);
            }
            sw.Close();
        }
    }
}
