using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string url;
        string html;
        public Form1()
        {
            InitializeComponent();

            html = "";
            url = "ENTER URL HERE";
            urlBar.Text = url;

            browser.ReadOnly = true;
            browser.TextAlign = HorizontalAlignment.Center;
            browser.Text = "Hello World\r\nThis is your browser speaking";
        }

        private void urlBar_Click(object sender, EventArgs e)
        {
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
           // webBrowser1.GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //webBrowser1.GoForward();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //webBrowser1.GoHome();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            url = urlBar.Text;
            browser.ResetText();
            html = "";

            ReadInFile();
            FormatHtml();
           
            browser.Text = html;
        }

        private void FormatHtml()
        {
            //C: \Users\Denny\Documents\BitchinTestFolder/HelloWorld.html

            //string[] splitHtml = html.Split(new char[] { '<', '>' }, StringSplitOptions.RemoveEmptyEntries);
            //Get Text between tags
            List<string> splitHtml = new List<string>();
            string currentWord = "";

            foreach(char c in html)
            {
                currentWord += c;

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void ReadInFile()
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(url))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    html += line;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(exception.Message);
                browser.Text = "404! Could not find File";
            }
        }
    }
}
