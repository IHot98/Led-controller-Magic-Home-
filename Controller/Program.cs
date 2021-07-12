using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    static class Program
    {
        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        private const int ATTACH_PARENT_PROCESS = -1;

        [STAThread]
        static void Main(string[] args)
        {
            // Enable visual elements just like always
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Attach to the parent process via AttachConsole SDK call
            AttachConsole(ATTACH_PARENT_PROCESS);
            Console.WriteLine("This is from the main program");

            Application.Run(new Form1());
        }
    }
}
