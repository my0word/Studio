namespace EdikIvan
{
    public partial class ChooseForm : Form
    {
        private List<string> loadedImages = new List<string>();
        private int currentImageIndex = -1;

        public ChooseForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += ChooseForm_KeyDown;
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
            return Math.Max(min, Math.Min(max, value));
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
                e.SuppressKeyPress = true;
                SaveImage();
            }
            else if (e.KeyCode == Keys.Right)
            {
                LoadNextImage();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                LoadPreviousImage();
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.R)
            {
                RotateImage(90);
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.L)
            {
                RotateImage(-90);
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.G)
            {
                e.SuppressKeyPress = true;
                grayscaleBtn.PerformClick();
            }
            else if (e.Control && e.KeyCode == Keys.I)
            {
                e.SuppressKeyPress = true;
                invertBtn.PerformClick();
            }
            else if (e.Control && e.KeyCode == Keys.P)
            {
                e.SuppressKeyPress = true;
                purpleBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                ResetImage();
                e.SuppressKeyPress = true;
            }
        }

        private void grayscaleBtn_Click(object sender, EventArgs e)
        {
            ApplyFilter("Grayscale");
        }

        private void invertBtn_Click(object sender, EventArgs e)
        {
            ApplyFilter("Invert");
        }

        private void purpleBtn_Click(object sender, EventArgs e)
        {
            ApplyFilter("Purple");
        }

        private void ApplyFilter(string filterType)
        {
            if (PicChoose.Image != null)
            {
                Bitmap originalBitmap = new Bitmap(PicChoose.Image);
                Bitmap filteredBitmap = new Bitmap(originalBitmap.Width, originalBitmap.Height);

                for (int y = 0; y < originalBitmap.Height; y++)
                {
                    for (int x = 0; x < originalBitmap.Width; x++)
                    {
                        Color pixelColor = originalBitmap.GetPixel(x, y);
                        Color newColor;

                        switch (filterType)
                        {
                            case "Grayscale":
                                int grayValue = (int)(pixelColor.R * 0.3 + pixelColor.G * 0.59 + pixelColor.B * 0.11);
                                newColor = Color.FromArgb(grayValue, grayValue, grayValue);
                                break;

                            case "Invert":
                                newColor = Color.FromArgb(255 - pixelColor.R,
                                                           255 - pixelColor.G,
                                                           255 - pixelColor.B);
                                break;

                            case "Purple":
                                int r = Clamp((int)(pixelColor.R * 0.5), 0, 255);
                                int g = Clamp((int)(pixelColor.G * 0.2), 0, 255);
                                int b = Clamp((int)(pixelColor.B * 1.5), 0, 255);
                                newColor = Color.FromArgb(r, g, b);
                                break;

                            default:
                                continue;
                        }

                        filteredBitmap.SetPixel(x, y, newColor);
                    }
                }

                PicChoose.Image.Dispose();
                PicChoose.Image = filteredBitmap;
                PicChoose.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}