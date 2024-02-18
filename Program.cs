using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SP_WP
{
    internal class Program
    {
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam);
        public const int WM_SETTEXT = 0X000C;

        static void Main(string[] args)
        {
            string way = "E:\\CONSOLE\\SP_WP\\bin\\Debug\\FOR_SP_HW.exe";
            string way2 = "E:\\CONSOLE\\SP_WP\\bin\\Debug\\FOR_SP_HW2.exe";
            IntPtr iHandle = FindWindow("WindowsForms10.Window.8.app.0.141b42a_r8_ad1", "Form1");
            if (iHandle != null)
            {
                Process.Start(way);
                Console.ReadKey();
                Process.Start(way2);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
