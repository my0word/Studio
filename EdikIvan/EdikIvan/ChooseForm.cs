using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdikIvan
{
    public partial class ChooseForm : Form
    {
        public ChooseForm()
        {
            InitializeComponent();
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            string startupPath = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = Path.Combine(startupPath, "Resources", "лес.jpg");

            if (File.Exists(imagePath))
            {
                PicChoose.Image = Image.FromFile(imagePath);
                PicChoose.Visible = true;
            }
            else
            {
                MessageBox.Show("Изображение не найдено.");
            }
            PicChoose.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            string startupPath = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = Path.Combine(startupPath, "Resources", "вулкан.jpg");

            if (File.Exists(imagePath))
            {
                PicChoose.Image = Image.FromFile(imagePath);
                PicChoose.Visible = true;
            }
            else
            {
                MessageBox.Show("Изображение не найдено.");
            }
            PicChoose.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            string startupPath = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = Path.Combine(startupPath, "Resources", "озеро.jpg");

            if (File.Exists(imagePath))
            {
                PicChoose.Image = Image.FromFile(imagePath);
                PicChoose.Visible = true;
            }
            else
            {
                MessageBox.Show("Изображение не найдено.");
            }
            PicChoose.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            string startupPath = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = Path.Combine(startupPath, "Resources", "город.jpg");

            if (File.Exists(imagePath))
            {
                PicChoose.Image = Image.FromFile(imagePath);
                PicChoose.Visible = true;
            }
            else
            {
                MessageBox.Show("Изображение не найдено.");
            }
            PicChoose.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            var thread = new Thread(closeWindow);
            thread.Start();
        }
        private void closeWindow()
        {
            Application.Run(new MainForm());
        }
    }
}
