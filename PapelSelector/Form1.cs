using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PapelSelector
{
    public partial class Form1 : Form
    {


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("Winspool.drv")]
        private static extern bool SetDefaultPrinter(string printerName);

        private String printer1 = Properties.Settings.Default.Printer1;
        private String printer2 = Properties.Settings.Default.Printer2;

        private int ActivePapelId = 0;

        public Form1()
        {
            InitializeComponent();
            label1.Text = Properties.Settings.Default.Nombre1;
            label2.Text = Properties.Settings.Default.Nombre2;

            lblPrinter1.Text = printer1;
            lblPrinter2.Text = printer2;

            this.Top = Properties.Settings.Default.Top;
            this.Left = Properties.Settings.Default.Left;


            SelectPapel(Properties.Settings.Default.DefaultPapelId);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SelectPapel(1);
        }


        private void SelectPapel(int id)
        {
            if (id == 1)
            {
                label1.ForeColor = Color.Red;
                label2.ForeColor = Color.Black;
                // Change the default printer to XPS Document Writer
                SetDefaultPrinter(printer1);                
            }
            else
            {
                label2.ForeColor = Color.Red;
                label1.ForeColor = Color.Black;
                SetDefaultPrinter(printer2);
            }
            ActivePapelId = id;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            SelectPapel(2);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            setPrinter(2);
        }


        private void setPrinter(int id)
        {
            PrintDialog printd = new PrintDialog();
            if (id == 1 && printer1 != "") 
                printd.PrinterSettings.PrinterName = printer1;
            else if (id == 2 && printer2 != "")
                printd.PrinterSettings.PrinterName = printer2;

            if (printd.ShowDialog() == DialogResult.OK) 
            {
                if (id == 1)
                  printer1 = printd.PrinterSettings.PrinterName;
                else if (id == 2)
                  printer2 = printd.PrinterSettings.PrinterName;

                //saveConfig();
                lblPrinter1.Text = printer1;
                lblPrinter2.Text = printer2;

                SelectPapel(ActivePapelId);
            }
        }

        private void btnConfig1_Click(object sender, EventArgs e)
        {
            setPrinter(1);
        }


        private void saveConfig()
        {
            Properties.Settings.Default.Printer1 = printer1;
            Properties.Settings.Default.Printer2 = printer2;
            Properties.Settings.Default.DefaultPapelId = ActivePapelId;
            Properties.Settings.Default.Top = this.Top;
            Properties.Settings.Default.Left = this.Left;

            Properties.Settings.Default.Save();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveConfig();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lblPrinter1_Click(object sender, EventArgs e)
        {

        }

        private void lblPrinter2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
