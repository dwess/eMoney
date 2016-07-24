using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string url;
        string backUrl;
        string forwardUrl;
        string html;
        public Form1()
        {
            InitializeComponent();

            html = "";
            url = "ENTER URL HERE";
            urlBar.Text = url;
            backUrl = "";
            forwardUrl = "";

            browser.ReadOnly = true;
            browser.WordWrap = false;
            browser.ScrollBars = ScrollBars.Both;
            browser.TextAlign = HorizontalAlignment.Center;
            browser.Text = "Hello World\r\nThis is your browser speaking";
        }

        private void urlBar_Click(object sender, EventArgs e)
        {
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            forwardUrl = url;
            url = backUrl;
            urlBar.Text = url;
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            url = forwardUrl;
            urlBar.Text = url;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            backUrl = url;
            url = @"C:\Users\Denny\Documents\BitchinTestFolder\HelloWorld.html";
            urlBar.Text = url;
            NavigateToUrl();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //C:\Users\Denny\Documents\BitchinTestFolder\HelloWorld.html
            backUrl = url;
            NavigateToUrl();
        }

        private void NavigateToUrl()
        {
            url = urlBar.Text;
            browser.ResetText();
            html = "";

            ReadInFile();
            ParseHtml();
        }

        private void ParseHtml()
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ConformanceLevel = ConformanceLevel.Fragment;
            settings.DtdProcessing = DtdProcessing.Ignore;
            XmlReader reader = XmlReader.Create(new StringReader(html), settings);

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        //Format HTML HERE
                        browser.Text += FormatHtml(reader.Name);
                        break;

                    case XmlNodeType.Text:
                        browser.Text += reader.Value;
                        break;

                    case XmlNodeType.EndElement:
                        browser.Text += EndElement(reader.Name);
                        break;
                }
            } 
        }

        private string EndElement(string name)
        {
            switch (name)
            {
                case "h1":
                case "h2":
                case "h3":
                case "h4":
                case "h5":
                    browser.Font = new Font(browser.Font.Name, 8.5f, browser.Font.Style);
                    return "\r\n";
                    break;

                case "center":
                    browser.TextAlign = HorizontalAlignment.Left;
                    break;
            }
            return "";
        }

        private string FormatHtml(string elementName)
        {
            switch (elementName)
            {
                //default font size is 8.25
                case "h1":
                    browser.Font = new Font(browser.Font.Name, 24, browser.Font.Style);
                    break;
                case "h2":
                    browser.Font = new Font(browser.Font.Name, 22, browser.Font.Style);
                    break;
                case "h3":
                    browser.Font = new Font(browser.Font.Name, 18, browser.Font.Style);
                    break;
                case "h4":
                    browser.Font = new Font(browser.Font.Name, 16, browser.Font.Style);
                    break;
                case "h5":
                    browser.Font = new Font(browser.Font.Name, 12, browser.Font.Style);
                    break;
                case "center":
                    browser.TextAlign = HorizontalAlignment.Center;
                    break;
                default:
                    return "\r\n";
                    break;
            }
            return "";
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

                try
                {
                    WebClient client = new WebClient();
                    html = client.DownloadString(url);
                    html = html.Replace("<!DOCTYPE html>", "");
                    FixHtml();
                    
                    
                }
                catch
                {
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(exception.Message);
                    browser.Text = "404! Could not find File";
                }
            }
        }

        private void FixHtml()
        {
            RemoveHeadTag();
            RemoveScriptTags();
            if (!this.html.Contains("<html"))
                return;
            int htmlStart;
            int htmlEnd;
            htmlStart = this.html.IndexOf("<html");
            this.html = this.html.Remove(0, htmlStart);
            htmlEnd = this.html.IndexOf(">") + 1;
            this.html = this.html.Remove(0, htmlEnd);
            html = "<html>" + html;
        }

        private void RemoveHeadTag()
        {
            if (!html.Contains("<head"))
                return;
            int headStart;
            int headEnd;
            headStart = html.IndexOf("<head");
            headEnd = html.IndexOf("</head>") + "</head>".Length;
            html = html.Remove(headStart, headEnd - headStart);
        }

        private void RemoveScriptTags()
        {
            while (html.Contains("<script"))
            {
                int scriptStart;
                int scriptEnd;
                scriptStart = html.IndexOf("<script");
                scriptEnd = html.IndexOf("</script>") + "</script>".Length;
                html = html.Remove(scriptStart, scriptEnd - scriptStart);
            }
        }
    }
}
