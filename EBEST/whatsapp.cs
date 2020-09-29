using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.WinForms;


namespace EBEST
{
    public partial class whatsapp : Form
    {
        public whatsapp()
        {
            InitializeComponent();
        }
        ChromiumWebBrowser browser;

        private void whatsapp_Load(object sender, EventArgs e)
        {
            //AbrirFormEnPanel(new Form1());
           browser = new ChromiumWebBrowser("https://web.whatsapp.com/");

           browser.Dock = DockStyle.Fill;

           this.pContainer.Controls.Add(browser);

           browser.Load("https://web.whatsapp.com/");
        }
        private void AbrirFormEnPanel2(object formhija2)
       {
           if (this.pContainer.Controls.Count > 0)
               this.pContainer.Controls.RemoveAt(0);
           Form fh = formhija2 as Form;
           fh.TopLevel = false;
           fh.Dock = DockStyle.Fill;
           this.pContainer.Controls.Add(fh);
           this.pContainer.Tag = fh;
           fh.Show();

       }
    }
}
