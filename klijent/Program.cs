using System;
using System.IO;
using System.Text;
using System.Net.Sockets;
using System.Windows.Forms;
using GUI;

namespace klijent
{

    public class clnt
    {
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           
        }
    }
}
