using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace 点名
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Directory.
        //string[] y = Directory.GetFiles(@"\image");

        List<string> path;
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "随机抽取")
            {
                timer1.Enabled = true;
                button1.Text = "暂停";
            }
            else
            {
                timer1.Enabled = false;
                button1.Text = "随机抽取";
            }
            //path = new List<string>();
            //string[] lian= Directory.GetFiles(@"\image");
            //for (int i = 0; i < lian.Length; i++)
            //{
            //    path.Add(lian[i]);
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            path = new List<string>();
            string[] lian = Directory.GetFiles("./image");
            for (int i = 0; i < lian.Length; i++)
            {
                path.Add(lian[i]);

            }
            Random de = new Random();
            int t=de.Next(0, 4);
            pictureBox1.Image = Image.FromFile(path[t]);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            string w= Path.GetFileName(path[t]);
            char[] p = new char[] { '.' };
           string[] r= w.Split(p);
            label1.Text = r[0];
        }
    }
}
