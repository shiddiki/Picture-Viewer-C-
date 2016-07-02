using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sidsiPictureViewer
{
    public partial class Form1 : Form
    {
        protected string[] pFileNames;
        protected int pCurrentImage = 1;
        protected int ok = 0;
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
            //tableLayoutPanel1.BackColor = Color.Transparent;
            //pictureBox1.BackColor = Color.Transparent;
            //pictureBox1.Size.Width += 100;
            
            
        }




    protected void ShowCurrentImage()
    {
        if (pCurrentImage >= 0 && pCurrentImage <= pFileNames.Length - 1)
        {
            pictureBox1.Image = Image.FromFile(pFileNames[pCurrentImage]);
        }
    }

  

    private void False(object sender, DragEventArgs e)
    {

    }

    private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
    {
        if (ok == 0)
        {
            MessageBox.Show("Open Images to Preview!!! \n Select multiple images to Activate PREV and NEXT button.");
            //  button1_Click(object sender, EventArgs e);
        }
        else if (pFileNames.Length > 1)
        {
            pCurrentImage = pCurrentImage == pFileNames.Length - 1 ? 0 : ++pCurrentImage;
            ShowCurrentImage();
        }
        else if (ok == 1)
        {
            MessageBox.Show("Only 1 image has been selected so far!!");

        }
    }

    private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
    {
        if (ok == 0)
        {

            //MessageBox.Show("Open Images to Preview!!! \n Select multiple images to Activate PREV and NEXT button.");
            //  button1_Click(object sender, EventArgs e);
        }
        else if (pFileNames.Length > 1)
        {
            button3.Enabled = true;
            button2.Enabled = true;
            pCurrentImage = pCurrentImage == 0 ? pFileNames.Length - 1 : --pCurrentImage;
            ShowCurrentImage();
        }
        else if (ok == 1)
        {
            MessageBox.Show("Only 1 image has been selected so far!!");


        }
    }

   

    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void button2_Click_1(object sender, EventArgs e)
    {
        if (ok == 0)
        {
            MessageBox.Show("Open Images to Preview!!! \n Select multiple images to Activate PREV and NEXT button.");
            //  button1_Click(object sender, EventArgs e);
        }
        else if (pFileNames.Length > 1)
        {
            pCurrentImage = pCurrentImage == pFileNames.Length - 1 ? 0 : ++pCurrentImage;
            ShowCurrentImage();
        }
        else if (ok == 1)
        {
            MessageBox.Show("Only 1 image has been selected so far!!");

        }

    }

    private void button1_Click_2(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Multiselect = true;
        //openFileDialog.Filter = "JPEG|*.jpg|Bitmaps|*.bmp";

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            pFileNames = openFileDialog.FileNames;
            pCurrentImage = 0;
            ok = 1;
            if (pFileNames.Length > 1)
            {
                button3.Enabled = true;
                button2.Enabled = true;
            }
            ShowCurrentImage();
        }
    }

    private void button3_Click_1(object sender, EventArgs e)
    {
        if (ok == 0)
        {

            //MessageBox.Show("Open Images to Preview!!! \n Select multiple images to Activate PREV and NEXT button.");
            //  button1_Click(object sender, EventArgs e);
        }
        else if (pFileNames.Length > 1)
        {
            button3.Enabled = true;
            button2.Enabled = true;
            pCurrentImage = pCurrentImage == 0 ? pFileNames.Length - 1 : --pCurrentImage;
            ShowCurrentImage();
        }
        else if (ok == 1)
        {
            MessageBox.Show("Only 1 image has been selected so far!!");


        }

    }

    private void button4_Click(object sender, EventArgs e)
    {
        Form2 fl = new Form2();
        fl.Show();


       /* 
        Size newSize = new Size((int)(pictureBox1.Width +50), (int)(pictureBox1.Height +100));

        Bitmap bmp = new Bitmap(pictureBox1.Image,newSize);

        pictureBox1.Image = bmp;
        tableLayoutPanel1.Width += 100;
        * */

    }

    private void button5_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    
}
    }


