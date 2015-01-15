/******************************************************
 * 文件：BookBase.cs
 * 功能：书库的属性及基本的简化更新的操作
 * 完成者：王莉淋
 * 最后修改时间：2010年11月25日 20:17
 *
 *******************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace BookShopSystem
{
    public class Book
    {
        public string name;//书的名字
        public string species;//书的种类
        public string writer;//书的作者
        public Int32 number;//书的本数
        public string isbn;//书的ISBN码
        public double SalePrice;//进货时书的单价
        public double BuyPrice;//售出时书的单价

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="s1">String 书的所有信息</param>
        public Book(string s1)
        {
            string[] bookimformation = s1.Split(' ');
            isbn = bookimformation[0];
            name = bookimformation[1];
            species = bookimformation[2];
            writer = bookimformation[3];
            BuyPrice = Convert.ToDouble( bookimformation[4]);
            SalePrice = Convert.ToDouble(bookimformation[5]);
           // number = 0;
            number = Convert.ToInt32(bookimformation[6]);

        }

        /// <summary>
        /// 简化“现存书库”的录入
        /// </summary>
        /// <returns>string 返回更新“现存书库”的字符串</returns>
        public string getbook()
        {
            string s = isbn + ' ' + name + ' ' + species + ' ' + writer + ' ' + Convert.ToString(BuyPrice) + ' ' + Convert.ToString(SalePrice) + ' ' + Convert.ToString(number);
            return s;
        }
    }

    
}