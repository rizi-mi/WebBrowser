using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB8
{
    public partial class Form1 : Form
    {
        PictureBox pictureBoxLogo;
        public Form1()
        {
            InitializeComponent();
            webBrowser1.Url = new Uri("http://google.com");
            button1.Click += button1_Click;
            webBrowser1.AllowWebBrowserDrop = true;
            pictureBoxLogo = new PictureBox();
            pictureBoxLogo.Location = new Point(10, 10);
            pictureBoxLogo.Size = new Size(400, 130);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.Image = Image.FromFile("C:\\Users\\vladi\\OneDrive\\Рабочий стол\\Учёба\\LAB8\\LOGO.png");

            Controls.Add(pictureBoxLogo);

            webBrowser1.DocumentCompleted += webBrowser1_DocumentCompleted;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
            toolStripStatusLabel1 = new ToolStripStatusLabel(textBox1.Text);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            if (textBox1.Text != e.Url.ToString())
            {
                textBox1.Text = e.Url.ToString();
            }
        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("");

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.ReadyState == WebBrowserReadyState.Complete)
            {
                int centerHorizontal = (webBrowser1.Width - pictureBoxLogo.Width) / 2;
                int centerVertical = (webBrowser1.Height - pictureBoxLogo.Height) / 4;
                pictureBoxLogo.Location = new Point(centerHorizontal, centerVertical);
                pictureBoxLogo.BringToFront();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
