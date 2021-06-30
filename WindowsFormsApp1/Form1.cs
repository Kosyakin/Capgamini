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
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView2.Nodes.Add("PORTRAIT");
            treeView2.Nodes.Add("LANDSCAPE");
            treeView2.Nodes.Add("HOLYDAY");
            treeView2.Nodes.Add("CARS");
            treeView2.Nodes.Add("OTHER IMAGES");

        }


        //Next/Back Algoritm
        public void Next_Back(int h)
        {
            try
            {
             
            for (int i = 0; i < 5; i++)
                {
                
                int g = DATA.NUMBER[i]; 
                    for (int j = 0; j < g; j++)
                    {
                        if (DATA.Name == Convert.ToString(treeView2.Nodes[i].Nodes[j].Text))
                        {
                            if(h==1)
                            DATA.Name = Convert.ToString(treeView2.Nodes[i].Nodes[j].NextNode.Text);
                            if(h==-1)
                            DATA.Name = Convert.ToString(treeView2.Nodes[i].Nodes[j].PrevNode.Text);

                        pictureBox1.Image = new Bitmap(DATA.Name);
                        
                        break;
                        }
                    }
                }
            }
            catch
            {
                if (h == 1)
                {
                    MessageBox.Show("Это было последнее фото в этом списке", "Ошибка №3", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (h == -1)
                {
                    MessageBox.Show("Это было первое фото", "Ошибка №4", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }




        //Обновление дерева
            public void update() { 
       
        if (DATA.FILE != null)
            {
                try
                {
                    treeView2.Nodes[DATA.INT].Nodes.Add(DATA.FILE);
                    DATA.FILE = null;
                }
                catch { MessageBox.Show("Не было загружено файлов", "Ошибка №2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void OpenFile_Click_1(object sender, EventArgs e)
        {
            
            Form2 f2 = new Form2();
            f2.Show();
            update();

        }

        

        private void View_PictureBox(object sender, TreeNodeMouseClickEventArgs e)
        {
            
            string file = Convert.ToString(treeView2.SelectedNode.Text);
           
            DATA.Name = file;
         


            try
            {
                pictureBox1.Image = new Bitmap(file);
            }
            catch
            {
                MessageBox.Show("Невозможно открыть файл, проверьте формат выбранного файла, либо вы нажали на жанр картинки","Ошибка №1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void button1_Click(object sender, EventArgs e)
        {
            update();
        }

        private void button3_Click(object sender, EventArgs e)//BACK
        {
            string file = DATA.Name;
            int h = -1;
            Next_Back(h);
        }

        private void button2_Click(object sender, EventArgs e)//NEXT
        {
            string file =DATA.Name;
            int h = 1;
            Next_Back(h);

            
            
        }

        private void button4_Click(object sender, EventArgs e)//DELETE
        {
            treeView2.SelectedNode.Remove();
        }

     
        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

    }
}
