using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AuditoriumMS
{
    static class Program
    {
        public const int AuditoriumSeatColumnsCount = 10;
        public const int AuditoriumSeatRowsCount = 10;

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
