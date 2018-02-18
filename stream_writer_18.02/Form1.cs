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

namespace stream_writer_18._02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
      {
            //StreamReader sr = new StreamReader("C:/Users/P502/Documents/Visual Studio 2017/test.txt");
            //var mytext = sr.ReadToEnd();
            //sr.Close();
            // MessageBox.Show(mytext);

            string filePath = "C:/Users/P502/Documents/Visual Studio 2017/test.txt";
            int top = 0;
            int topB = 0;
            int left = 0;

            StreamReader sr = new StreamReader(filePath);
            GroupBox gb = new GroupBox();

            while (!sr.EndOfStream)
            {
                var text = sr.ReadLine();
                if (text.Contains("Sual"))
                {
                    gb = new GroupBox();
                    this.Controls.Add(gb);
                    Label label = new Label();
                    this.Controls.Add(label);
                    label.Text = text;
                    label.Width = 500;
                    label.Top = top;
                    label.Left = left;
                    top += 200;
                    topB = 0;
                }
                else
                {

                    RadioButton radio = new RadioButton();
                    //this.Controls.Add(radio); 
                    gb.Controls.Add(radio);
                    radio.Text = text;
                    radio.Width = 500;
                    radio.Top = topB;
                    radio.Left = left;
                    topB += 20;
                    gb.Top = top+10;
                    gb.Left = 5; 

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
