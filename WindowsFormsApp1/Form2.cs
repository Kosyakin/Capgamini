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

namespace WindowsFormsApp1
{

    public partial class Form2 : Form
    {
        string filename;
        public string OpenFile()
        {
            
            int size = -1;
            openFileDialog1.Filter = "Image Files(*.BMP,*.PNG,*.JPG)|*.BMP;*.PNG;*.JPG|All files(*.*)|*.*";
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            filename = openFileDialog1.FileName;
            {
               filename = openFileDialog1.FileName;
                try
                {
                   size = filename.Length;
                   
                   
                }
                catch (IOException)
                {
                    
                }
               
            }
            return filename;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            filename = OpenFile();
            DATA.FILE = Convert.ToString(filename);
            DATA.INT = 0;
            DATA.NUMBER[0]++;
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            filename = OpenFile();
            DATA.FILE = Convert.ToString(filename);
            DATA.INT = 1;
            this.Close();
            DATA.NUMBER[1]++;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            filename = OpenFile();
            DATA.FILE = Convert.ToString(filename);
            DATA.INT = 2;
            this.Close();
            DATA.NUMBER[2]++;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            filename = OpenFile();
            DATA.FILE = Convert.ToString(filename);
            DATA.INT = 3;
            this.Close();
            DATA.NUMBER[3]++;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            filename = OpenFile();
            DATA.FILE = Convert.ToString(filename);
            DATA.INT = 4;
            this.Close();
            DATA.NUMBER[4]++;

        }
    }
}
