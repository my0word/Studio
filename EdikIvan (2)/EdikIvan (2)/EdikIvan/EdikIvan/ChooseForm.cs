namespace EdikIvan
{
    public partial class ChooseForm : Form
    {
        private List<string> loadedImages = new List<string>();
        private int currentImageIndex = -1;

        public ChooseForm()
        {
            InitializeComponent();
        }

        private void oneBtn_Click(object sender, EventArgs e) { LoadImage("лес.jpg"); }
        private void twoBtn_Click(object sender, EventArgs e) { LoadImage("вулкан.jpg"); }
        private void threeBtn_Click(object sender, EventArgs e) { LoadImage("озеро.jpg"); }
        private void fourBtn_Click(object sender, EventArgs e) { LoadImage("город.jpg"); }
        private void fiveBtn_Click(object sender, EventArgs e) { LoadImage("антарктида.jpg"); }
        private void sixBtn_Click(object sender, EventArgs e) { LoadImage("деревня.jpg"); }

        private void sevenBtn_Click(object sender, EventArgs e) { LoadImage("небо.jpg"); }

        private void eightBtn_Click(object sender, EventArgs e) { LoadImage("поле.jpg"); }

        private void nineBtn_Click(object sender, EventArgs e) { LoadImage("пляж.jpg"); }

        private void tenBtn_Click(object sender, EventArgs e) { LoadImage("дом.jpg"); }


        private void LoadImage(string imageName)
        {
            string startupPath = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = Path.Combine(startupPath, "Resources", imageName);

            if (File.Exists(imagePath))
            {
                PicChoose.Image = Image.FromFile(imagePath);
                PicChoose.Visible = true;

                if (!loadedImages.Contains(imagePath))
                {
                    loadedImages.Add(imagePath);
                    currentImageIndex = loadedImages.Count - 1;
                }
                brightnessBar.Value = 0;
                contrastBar.Value = 0;
                AdjustImage();
            }
            else
            {
                MessageBox.Show("Изображение не найдено.");
            }
            PicChoose.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ResetImage();
        }

        private void ResetImage()
        {
            PicChoose.Image = null;
            PicChoose.Visible = false;
            MessageBox.Show("Изображение сброшено.");
            loadedImages.Clear();
            currentImageIndex = -1;
            brightnessBar.Value = 0;
            contrastBar.Value = 0;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveImage();
        }

        private void SaveImage()
        {
            if (PicChoose.Image != null)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "JPEG Image|*.jpg|PNG Image|*.png|Bitmap Image|*.bmp";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        PicChoose.Image.Save(saveFileDialog.FileName);
                        MessageBox.Show("Изображение сохранено.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Нет изображения для сохранения.");
            }
        }

        private void LoadNextImage()
        {
            if (loadedImages.Count > 0)
            {
                currentImageIndex = (currentImageIndex + 1) % loadedImages.Count;
                PicChoose.Image = Image.FromFile(loadedImages[currentImageIndex]);
                PicChoose.SizeMode = PictureBoxSizeMode.Zoom;
                PicChoose.Visible = true;
                brightnessBar.Value = 0;
                contrastBar.Value = 0;
                AdjustImage();
            }
        }

        private void LoadPreviousImage()
        {
            if (loadedImages.Count > 0)
            {
                currentImageIndex = (currentImageIndex - 1 + loadedImages.Count) % loadedImages.Count;
                PicChoose.Image = Image.FromFile(loadedImages[currentImageIndex]);
                PicChoose.SizeMode = PictureBoxSizeMode.Zoom;
                PicChoose.Visible = true;
                brightnessBar.Value = 0;
                contrastBar.Value = 0;
                AdjustImage();
            }
        }

        private void brightnessBar_Scroll(object sender, EventArgs e)
        {
            AdjustImage();
        }

        private void contrastBar_Scroll(object sender, EventArgs e)
        {
            AdjustImage();
        }
        private void AdjustImage()
        {
            if (PicChoose.Image != null)
            {
                Bitmap originalBitmap = new Bitmap(PicChoose.Image);

                float brightnessFactor = brightnessBar.Value;
                float contrastFactor = contrastBar.Value;

                Bitmap adjustedBitmap = AdjustBrightnessContrast(originalBitmap, brightnessFactor, contrastFactor);

                PicChoose.Image.Dispose();
                PicChoose.Image = adjustedBitmap;
                PicChoose.SizeMode = PictureBoxSizeMode.Zoom;
                PicChoose.Visible = true;
            }
        }

        private Bitmap AdjustBrightnessContrast(Bitmap image, float brightnessFactor, float contrastFactor)
        {
            float bOffset = brightnessFactor * 255 / 100.0f;
            float cMultiplier = (contrastFactor + 100) / 100.0f;

            Bitmap adjustedImage = new Bitmap(image.Width, image.Height);

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);

                    int r = Clamp((int)(pixelColor.R * cMultiplier + bOffset), 0, 255);
                    int g = Clamp((int)(pixelColor.G * cMultiplier + bOffset), 0, 255);
                    int bPixel = Clamp((int)(pixelColor.B * cMultiplier + bOffset), 0, 255);

                    adjustedImage.SetPixel(x, y, Color.FromArgb(r, g, bPixel));
                }
            }

            return adjustedImage;
        }

        private int Clamp(int value, int min, int max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }

        private void rotateLeftBtn_Click(object sender, EventArgs e)
        {
            RotateImage(-90);
        }

        private void rotateRightBtn_Click(object sender, EventArgs e)
        {
            RotateImage(90);
        }

        private void RotateImage(float angle)
        {
            if (PicChoose.Image != null)
            {
                Bitmap originalBitmap = new Bitmap(PicChoose.Image);
                Bitmap rotatedBitmap = new Bitmap(originalBitmap.Width, originalBitmap.Height);

                using (Graphics g = Graphics.FromImage(rotatedBitmap))
                {
                    g.TranslateTransform((float)originalBitmap.Width / 2, (float)originalBitmap.Height / 2);
                    g.RotateTransform(angle);
                    g.TranslateTransform(-(float)originalBitmap.Width / 2, -(float)originalBitmap.Height / 2);
                    g.DrawImage(originalBitmap, new Point(0, 0));
                }

                PicChoose.Image.Dispose();
                PicChoose.Image = rotatedBitmap;
                PicChoose.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void ChooseForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                SaveImage();
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                LoadNextImage();
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Left)
            {
                LoadPreviousImage();
                e.SuppressKeyPress = true;
            }

            if (e.Control && e.KeyCode == Keys.R)
            {
                RotateImage(90);
                e.SuppressKeyPress = true;
            }

            if (e.Control && e.KeyCode == Keys.L)
            {
                RotateImage(-90);
                e.SuppressKeyPress = true;
            }
        }

        private void grayscaleBtn_Click(object sender, EventArgs e)
        {
            ApplyGrayscaleFilter();
        }

        private void invertBtn_Click(object sender, EventArgs e)
        {
            ApplyInvertFilter();
        }
        private void ApplyGrayscaleFilter()
        {
            if (PicChoose.Image != null)
            {
                Bitmap originalBitmap = new Bitmap(PicChoose.Image);
                Bitmap grayBitmap = new Bitmap(originalBitmap.Width, originalBitmap.Height);

                for (int y = 0; y < originalBitmap.Height; y++)
                {
                    for (int x = 0; x < originalBitmap.Width; x++)
                    {
                        Color pixelColor = originalBitmap.GetPixel(x, y);
                        int grayValue = (int)(pixelColor.R * 0.3 + pixelColor.G * 0.59 + pixelColor.B * 0.11);
                        grayBitmap.SetPixel(x, y, Color.FromArgb(grayValue, grayValue, grayValue));
                    }
                }

                PicChoose.Image.Dispose();
                PicChoose.Image = grayBitmap;
                PicChoose.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void ApplyInvertFilter()
        {
            if (PicChoose.Image != null)
            {
                Bitmap originalBitmap = new Bitmap(PicChoose.Image);
                Bitmap invertedBitmap = new Bitmap(originalBitmap.Width, originalBitmap.Height);

                for (int y = 0; y < originalBitmap.Height; y++)
                {
                    for (int x = 0; x < originalBitmap.Width; x++)
                    {
                        Color pixelColor = originalBitmap.GetPixel(x, y);
                        invertedBitmap.SetPixel(x, y,
                            Color.FromArgb(255 - pixelColor.R,
                                           255 - pixelColor.G,
                                           255 - pixelColor.B));
                    }
                }

                PicChoose.Image.Dispose();
                PicChoose.Image = invertedBitmap;
                PicChoose.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void purpleBtn_Click(object sender, EventArgs e)
        {
            ApplyPurpleFilter();
        }

        private void ApplyPurpleFilter()
        {
            if (PicChoose.Image != null)
            {
                Bitmap originalBitmap = new Bitmap(PicChoose.Image);
                Bitmap purpleBitmap = new Bitmap(originalBitmap.Width, originalBitmap.Height);

                for (int y = 0; y < originalBitmap.Height; y++)
                {
                    for (int x = 0; x < originalBitmap.Width; x++)
                    {
                        Color pixelColor = originalBitmap.GetPixel(x, y);

                        int r = Clamp((int)(pixelColor.R * 0.5), 0, 255);
                        int g = Clamp((int)(pixelColor.G * 0.2), 0, 255);
                        int b = Clamp((int)(pixelColor.B * 1.5), 0, 255);

                        purpleBitmap.SetPixel(x, y, Color.FromArgb(r, g, b));
                    }
                }

                PicChoose.Image.Dispose();
                PicChoose.Image = purpleBitmap;
                PicChoose.SizeMode = PictureBoxSizeMode.Zoom;
            }
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
