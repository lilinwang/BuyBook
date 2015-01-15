/******************************************************
 * 文件：Login.cs
 * 功能：“登陆（login）”的操作库
 * 完成者：刘玉夕
 * 最后修改时间：2010年11月29日 22:56
 *******************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BookShopSystem
{
    
    public class Login
    {
        static string path2=System.AppDomain.CurrentDomain.BaseDirectory;
        private string[] lines = File.ReadAllLines(path2+"Login.txt", Encoding.Default);
        /// <summary>
        /// 返回返回文件的行数
        /// </summary>
        /// <returns>Int 返回登陆库的行数</returns>
        public int Length 
        { 
            get 
            { 
                return lines.Length;
            }
        }
        public string[][] strss = new string[2][] { new string[100], new string[100] };

        /// <summary>
        /// 构造函数
        /// </summary>
        public Login()
        {
            for (int i = 0; i < lines.Length; i++)
            {
                string[] str1 = lines[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                strss[0][i] = str1[0];
                strss[1][i] = str1[1];
            }
        }
        /// <summary>
        /// 修改密码操作
        /// </summary>
        public void changepassword(string s1,int m)
        {
            lines[m] = strss[0][m] + "    " + s1;
            File.WriteAllLines(path2 + "Login.txt", lines);
        }

        public void addnewuser(string s1, string s2)
        {
            FileStream aFile = new FileStream(path2 + "Login.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(aFile);
            string s = s1 + "    " + s2;
            sw.WriteLine(s);
            sw.Close();
        }
    }
}
