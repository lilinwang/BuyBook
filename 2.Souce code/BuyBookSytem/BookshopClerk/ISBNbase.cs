using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BookShopSystem
{
    class ISBN
    {
        public string isbn;
        public ISBN(string s1)
        {
            isbn = s1;
        }
        public string search(string path)

        {
                string[] line = new string[1000];
                string[] lines = File.ReadAllLines(path, Encoding.Default);
                for (int i = 0; i < lines.Length; i++)
                {
                    line = lines[i].Split(' ');
                    if (line[0]==isbn) return lines[i];
                }
                return " ";
        }    
    }
}
