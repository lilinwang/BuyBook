/******************************************************
 * 文件：MoneyBase.cs
 * 功能：营业额的属性及基本的简化更新的操作
 * 完成者：王莉淋
 * 最后修改时间：2010年11月25日 20:17
 *
 * BUG修正：
 * 1.对于支出的总金额没有加负号，使得历史记录库和营业额库内容模糊
 *      原因：对于支出的操作，没有单独加负号
 * 
 *      已解决
 *******************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookShopSystem
{
    public class MoneyBase
    {
        public string isbn;//书的ISBN编码
        public string name;//书的名字
        public Int32 state;//0 表示“进货”。1表示“售出”
        public Int32 number;//进货或售出的书的本数
        public double price;//书的单价
        public double totalmoney;//书的总价格
        public DateTime time;//当前的日期

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="s1">String 书的所有信息</param>
        /// <param name="state2">String 标记“进货”或“售出”</param>
        /// <param name="num">Int 需要更新的书的数量</param>
        public MoneyBase(string s1,Int32 state2,Int32 num)
        {
            string[] bookimformation = s1.Split(' ');
            isbn = bookimformation[0];
            name = bookimformation[1];
            state = state2;//0 表示买进。1表示卖出
            if (state==0)
                price = Convert.ToDouble( bookimformation[4]);
            else 
                price= Convert.ToDouble(bookimformation[5]);
            number = num;
            totalmoney = number * price;
            time = DateTime.Today;

        }

        /// <summary>
        /// 简化“历史记录库”的录入
        /// </summary>
        /// <returns>string 返回更新“历史记录库”的字符串</returns>
        public string GetRecord()
        {
            string tem;
            if (state == 0) tem = "-"; else { tem = ""; }
            string s = isbn + ' ' + name + ' ' + tem  + Convert.ToString(price)
                + ' ' + Convert.ToString(number)  + ' '+tem  +Convert.ToString(totalmoney) + ' ' + Convert.ToString(time);
            return s;
        }

        /// <summary>
        /// 简化“营业额库”的录入
        /// </summary>
        /// <returns>string 返回更新“营业额库”的字符串</returns>
        public string GetAccount()
        {
            if (state == 0)
            {
                string s = Convert.ToString(totalmoney) + ' ' + '0' + ' '+Convert.ToString(totalmoney * (-1)) + ' ' + Convert.ToString(time);
                return s;
            }
            else
            {
                string s = '0' + ' ' + Convert.ToString(totalmoney) + ' ' + Convert.ToString(totalmoney) + ' ' + Convert.ToString(time);
                return s;
            }
        }
    }
}
