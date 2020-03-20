using System;
using System.Threading;
using System.Windows.Forms;

namespace H1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Thread thr = new Thread(new ThreadStart(run));
            thr.Start();
            
        }

        static void run()
        {
            Application.Run(new Form1());
        }
    }
}
