using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Splish_Splash_Decorators
{
    public partial class Output : Form
    {
  
        //this code is where the necessary information is passed on to. 
        public Output(string CustomerDetails, string EstDetails)
        {
            InitializeComponent();
            //this displays the information inside a single label
            lblCDetails.Text = CustomerDetails;
            lblJob_Est.Text = EstDetails;
            //this is for printing the final form estimate out. 
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

         
        }

     
        //this closes the program 
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //this button is for a help message on this form
        private void btnHelpFinal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the final page before confirmation via a printed hardcopy.", "Help Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
 
        //tooltips
        private void MouseEnterPrintHelp(object sender, EventArgs e)
        {
            lblPrintHelp.Text = "Make sure you are connected to a printer before printing!";
        }
        //tooltips
        private void MouseLeavePrintHelp(object sender, EventArgs e)
        {
            lblPrintHelp.Text = "";
        }
        //tooltips
        private void MouseEnterCancelHelp(object sender, EventArgs e)
        {
            lblCancelHelp.Text = "This will end the estimate and close the program.";
        }
        //tooltips
        private void MouseLeaveCancelHelp(object sender, EventArgs e)
        {
            lblCancelHelp.Text = "";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
            doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(doc_PrintPage);
            PrintDialog PrintSettings = new PrintDialog();
            PrintSettings.Document = doc;
           // PageSettings pgsetting = new PageSettings();

            if (PrintSettings.ShowDialog() == DialogResult.OK)
                doc.Print();
        }
        //this is for printing the document
        private void doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height, panel1.CreateGraphics());
            panel1.DrawToBitmap(bmp, new Rectangle(0, 0, panel1.Width, panel1.Height));

            RectangleF bounds = e.PageSettings.PrintableArea;
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, panel1.Width, panel1.Height);

        }

       

        }
    }

           
  


      


        
   

