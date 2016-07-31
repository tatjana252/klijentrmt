using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        static int brojac = 0;
        static Stream stm;
        static TcpClient tcpclnt;
        static string ime;
        static bool prvi = true;
        public Form1()
        {
            InitializeComponent();
            console.AppendText("Konektuje se....." + Environment.NewLine + "Unesite ime: ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void console_TextChanged(object sender, EventArgs e)
        {
        }

        private void send_Click(object sender, EventArgs e)
        {
           
            if (brojac == 0)
            {
                
                stm = null;
                tcpclnt = null;
                if (ime == null)
                {
                    if (odgovori.Text == "")
                    {
                        console.AppendText("Unesite ime");
                        return;
                    }
                    ime = odgovori.Text;
                    prvi = false;
                }
                
                stm = konektujSe(ime, console, out tcpclnt);
                slanje(odgovori.Text, stm, console);
                odgovori.Text = "";
                string odg = primanje(stm, console);
                if (odg.StartsWith("Sacekaj"))
                {
                    primanje(stm, console);
                }
                primanje(stm, console);
                brojac++;
            }

            else if(brojac == 1)
            {
                slanje(odgovori.Text, stm, console);
                odgovori.Text = "";
                primanje(stm, console);
                diskonektujSe(tcpclnt);
                console.AppendText("Zelis li da igras jos jednom?");
                brojac++;
            }
            else if(brojac == 2)
            {
                if (odgovori.Text.ToUpper() != "DA")
                {
                    console.AppendText("Dovidjenja! ");
                    this.Close();
                }
                else
                {
                    brojac = 0;
                    odgovori.Text = "";
                    send_Click(sender, e);
                }
            }

        }
        public static void diskonektujSe(TcpClient tcpclnt)
        {
            tcpclnt.Close();
        }
        public static Stream konektujSe (string ime, TextBox console, out TcpClient tcpclnt)
        {
            try
            {
                    tcpclnt = new TcpClient();
                    tcpclnt.Connect("192.168.1.3", 8001);
                    // use the ipaddress as in the server program
                    Stream stm = tcpclnt.GetStream();                   
                    return stm;

            }

            catch (Exception e)
            {
                Console.WriteLine("Greska! " + e.StackTrace);
                tcpclnt = null;
                return null;
            }
        }
        public static string primanje(Stream stm, TextBox console)
        {
            byte[] bb = new byte[150];
            stm.Read(bb, 0, 150);
            string something = Encoding.ASCII.GetString(bb);
            if (!prvi && something.Equals(ime)) { return something; }
            console.AppendText(something + "\r\n");
            return something;
        }
        public static void slanje(string str, Stream stm, TextBox console)
        {
            byte[] toBytes = Encoding.ASCII.GetBytes(str);
            stm.Write(toBytes, 0, toBytes.Length);  
            console.AppendText(str+"\r\n");
        }

    }
    
}
