/******************************************************
 * 文件：frmManager.cs
 * 功能：程序的入口
 * 完成者：王莉淋
 * 最后修改时间：2010年11月28日 02:23
 *******************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace BookShopSystem
{
    
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
          //  Application.Run(new frm_Clerk());
        }
    }
}
