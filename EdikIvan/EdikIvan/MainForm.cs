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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RandomBtn_Click(object sender, EventArgs e)
        {
            string startupPath = Application.StartupPath;
            string[] imageFiles =
            {
        Path.Combine(startupPath, "Resources", "лес.jpg"),
        Path.Combine(startupPath, "Resources", "вулкан.jpg"),
        Path.Combine(startupPath, "Resources", "озеро.jpg"),
        Path.Combine(startupPath, "Resources", "город.jpg")
    };

            Random random = new Random();
            int randomIndex = random.Next(0, imageFiles.Length);

            Image randomImage = Image.FromFile(imageFiles[randomIndex]);

            PicRand.Image = randomImage;
            PicRand.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void ChooseBtn_Click(object sender, EventArgs e)
        {
            Close();
            var thread = new Thread(openWindow);
            thread.Start();
        }
        private void openWindow()
        {
            Application.Run(new ChooseForm());
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
