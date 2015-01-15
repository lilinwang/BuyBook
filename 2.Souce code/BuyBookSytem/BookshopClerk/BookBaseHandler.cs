/******************************************************
 * 文件：BookBaseHandler.cs
 * 功能：对现存书库（book）的操作
 * 完成者：王莉淋
 * 最后修改时间：2010年11月28日 02:23
 *
 * BUG修正：
 * 1.输出的txt文档为乱码
 *      原因：没有对文件输入输出标记固定格式
 * 
 *      已解决
 *      
 * 2.现存书库的书的数量不正确
 *      原因：在判定输入是否合法时修改了不应该修改的number值
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
    //现存书库操作器
    public class BookBaseHandler
    {
        /// <summary>
        /// 店员“进货”时的更新
        /// </summary>
        /// <param name="path">String 现存书库文件路径</param>
        /// <param s="path">String 需要更新的书的信息</param>
        /// <param num="path">Int 需要更新的书的数量</param>
        public void UpdataBuy(string s, string path,Int32 num)            //店员操作“进货”时的操作类
        {
            string[] lines = File.ReadAllLines(path, Encoding.UTF8);     //现存书库的读入
            string[] lines2 = File.ReadAllLines(path, Encoding.UTF8);
            Int32 len = lines.Length;
            string scopy = s;
            string[] ss1 = s.Split(' ');
            string[] ss2;
            Int32 flag=0;
            string[] modify;//对于不合法的文本流进行修正
            modify = lines[len - 1].Split(' ');
            if (modify.Length < 7) { len--; };
            for (Int32 i = 0; i < len; i++)
            {

                 ss2 = lines[i].Split(' ');
                if (ss1[0] == ss2[0])
                {
                    Book book = new Book(lines[i]);
                    book.number  +=num;
                    lines2[i] = book.getbook();
                    flag = 1; i = len;
                }
            }
            
            FileStream aFile = new FileStream(path, FileMode.Create);    //现存书库的录入
            StreamWriter sw = new StreamWriter(aFile, System.Text.Encoding.UTF8);
           //sw.WriteLine(lines.Length);
            //sw.WriteLine(len);
            for (Int32 j = 0; j < len-1; j++)
            {
                sw.WriteLine(lines2[j]);
            }
            if (flag == 0)
            {
                sw.WriteLine(lines2[len - 1]);
                sw.Write(scopy + ' ' + Convert.ToString(num));
            }
            else
            {
                sw.Write(lines2[len - 1]);
            }
            sw.Close();
        }

        /// <summary>
        /// 店员“售书”时的更新
        /// </summary>
        /// <param name="path">String 现存书库文件路径</param>
        /// <param name="s">String 需要更新的书的信息</param>
        /// <param name="num">Int 需要更新的书的数量</param>
        public Int32 UpdataSale(string s, string path, Int32 num)  //店员操作“售书”时的操作类
        {
            Int32 flag = 0;
            string[] lines = File.ReadAllLines(path, Encoding.UTF8);//现存书库的读入
            string[] lines2 = File.ReadAllLines(path, Encoding.UTF8);
            Int32 len = lines.Length;
            string[] ss1 = s.Split(' ');
            string[] ss2;
            string[] modify;//对于不合法的文本流进行修正
            modify = lines[len - 1].Split(' ');
            if (modify.Length < 7) { len--; };
            for (Int32 i = 0; (i < len) && (flag==0); i++)
            {
                ss2 = lines[i].Split(' ');
                if (ss1[0] == ss2[0])
                {
                    Book book = new Book(lines2[i]);
                    int ttt = book.number;
                    ttt -= num;
                    if (ttt < 0) 
                    {
                        return (book.number);
                    }
                    book.number = ttt;
                    lines2[i] = book.getbook();
                    flag = 1; i = len;
                }
            }
            if (flag==0)
            {
                return (0);
            }
            FileStream aFile = new FileStream(path, FileMode.Create);//现存书库的录入
            StreamWriter sw = new StreamWriter(aFile, System.Text.Encoding.UTF8);
            //sw.WriteLine(lines.Length);
            for (Int32 j = 0; j < len-1; j++)
            {
                sw.WriteLine(lines2[j]);
            }
            sw.Write(lines2[len - 1]);
            sw.Close();
            return (-1);
        }
    }
}
