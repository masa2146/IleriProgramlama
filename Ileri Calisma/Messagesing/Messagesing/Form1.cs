using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Messagesing
{
    public partial class Form1 : Form
    {

        private const int mouseSolTik = 0x0202;
        private const int shift = 0x0002;
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]

        public static extern int SendMessage(IntPtr hwnd, [MarshalAs(UnmanagedType.U4)] int Msg, IntPtr wParam, IntPtr lParam);


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Process proc = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(proc.ProcessName);
            foreach (Process p in processes)
            {
                this.textBox1.Text +=p.Id;

            }
            SendMessage(proc.MainWindowHandle,mouseSolTik,IntPtr.Zero,IntPtr.Zero);
           // SendMessage(proc.MainWindowHandle, shift, IntPtr.Zero, IntPtr.Zero);
        } 

        protected override void WndProc(ref Message m)
        {

            if(m.Msg == mouseSolTik)
            {
                this.textBox1.Text += "Sol Tık Yapıldı!\n";
            }
            if (m.Msg == shift)
            {
                this.textBox1.Text += "Shift!\n";
            }
            base.WndProc(ref m);
        }
    }
}
