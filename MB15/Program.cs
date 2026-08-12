using MB15.SortComparison;
using System;
using System.Windows.Forms;

namespace MB15
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Original from here:
        /// https://www.codeproject.com/Articles/1087568/Visualization-and-Comparison-of-sorting-algorith
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}