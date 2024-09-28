namespace EdikIvan
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            PicRand.MouseDown += PicRand_MouseDown;
            PicRand.MouseMove += PicRand_MouseMove;
            PicRand.MouseUp += PicRand_MouseUp;
            statusStrip1.Items.Add("Ready");
        }

        private Point panStartPoint;
        private bool isPanning = false;
        private bool isDrawing = false;
        private Point lastPoint;
        private Color drawingColor = Color.Red;
        private int penWidth = 1;
        private List<Line> drawnLines = new List<Line>();
        private Stack<Image> loadedImages = new Stack<Image>();
        private Stack<Image> previousImages = new Stack<Image>();
        private Stack<List<Line>> undoStack = new Stack<List<Line>>();

        private void RandomBtn_Click(object sender, EventArgs e)
        {
            string startupPath = Application.StartupPath;
            string[] imageFiles =
            {
                Path.Combine(startupPath, "Resources", "лес.jpg"),
                Path.Combine(startupPath, "Resources", "вулкан.jpg"),
                Path.Combine(startupPath, "Resources", "озеро.jpg"),
                Path.Combine(startupPath, "Resources", "город.jpg"),
                Path.Combine(startupPath, "Resources", "антарктида.jpg"),
                Path.Combine(startupPath, "Resources", "деревня.jpg"),
                Path.Combine(startupPath, "Resources", "небо.jpg"),
                Path.Combine(startupPath, "Resources", "поле.jpg"),
                Path.Combine(startupPath, "Resources", "пляж.jpg"),
                Path.Combine(startupPath, "Resources", "дом.jpg")
            };

            try
            {
                Random random = new Random();
                int randomIndex = random.Next(0, imageFiles.Length);
                Image randomImage = Image.FromFile(imageFiles[randomIndex]);

                randomImage = ResizeImage(randomImage, PicRand.Width, PicRand.Height);

                if (PicRand.Image != null)
                {
                    previousImages.Push(PicRand.Image);
                }

                PicRand.Image = randomImage;
                loadedImages.Push(randomImage);
                PicRand.SizeMode = PictureBoxSizeMode.StretchImage;

                PicRand.Invalidate();

                statusStrip1.Items[0].Text = $"Loaded: {Path.GetFileName(imageFiles[randomIndex])}";
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                using (var wrapMode = new System.Drawing.Imaging.ImageAttributes())
                {
                    wrapMode.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void PicRand_Paint(object sender, PaintEventArgs e)
        {
            if (PicRand.Image != null)
                e.Graphics.DrawImage(PicRand.Image, new Rectangle(0, 0, PicRand.Width, PicRand.Height));

            foreach (var line in drawnLines)
            {
                e.Graphics.DrawLine(new Pen(line.Color, line.Width), line.StartPoint, line.EndPoint);
            }
        }

        private void ChooseBtn_Click(object sender, EventArgs e)
        {
            Close();
            Thread thread = new Thread(openWindow);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void openWindow()
        {
            Application.Run(new ChooseForm());
        }

        private void PicRand_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Control.ModifierKeys == Keys.Shift)
                {
                    isPanning = true;
                    panStartPoint = e.Location;
                    statusStrip1.Items[0].Text = "Panning...";
                }
                else
                {
                    isDrawing = true;
                    lastPoint = e.Location;
                    statusStrip1.Items[0].Text = "Drawing...";
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            penWidth = trackBar1.Value;
            statusStrip1.Items[0].Text = $"Pen Width: {penWidth}";
        }

        private void PicRand_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = PicRand.CreateGraphics())
                {
                    g.DrawLine(new Pen(drawingColor, penWidth), lastPoint, e.Location);
                    drawnLines.Add(new Line(lastPoint, e.Location, drawingColor, penWidth));
                    lastPoint = e.Location;
                }
            }

            else if (isPanning)
            {
                int offsetX = e.X - panStartPoint.X;
                int offsetY = e.Y - panStartPoint.Y;

                PicRand.Location = new Point(PicRand.Location.X + offsetX, PicRand.Location.Y + offsetY);
                panStartPoint = e.Location;
            }
        }

        private void PicRand_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (isPanning)
                {
                    isPanning = false;
                    statusStrip1.Items[0].Text = "Ready";
                }
                else if (isDrawing)
                {
                    isDrawing = false;
                    statusStrip1.Items[0].Text = "Ready";
                    PicRand.Invalidate();
                    DrawAllLines();
                    undoStack.Push(new List<Line>(drawnLines)); 
                }
            }
        }

        private void DrawAllLines()
        {
            if (PicRand.Image != null && drawnLines.Count > 0)
            {
                using (Graphics g = Graphics.FromImage(PicRand.Image))
                {
                    foreach (var line in drawnLines)
                    {
                        g.DrawLine(new Pen(line.Color, line.Width), line.StartPoint, line.EndPoint);
                    }
                    PicRand.Invalidate();
                }
            }
        }

        private void ColorBtn_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    drawingColor = colorDialog.Color;
                    statusStrip1.Items[0].Text = $"Drawing Color: {drawingColor.Name}";
                }
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            drawnLines.Clear();
            PicRand.Image = null;
            PicRand.Invalidate();
            statusStrip1.Items[0].Text = "Cleared";
            loadedImages.Clear();
            previousImages.Clear();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveImage();
        }

        private void SaveImage()
        {

            using (Bitmap bitmap = new Bitmap(PicRand.Width, PicRand.Height))
            {
                PicRand.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));

                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    DrawAllLinesOnBitmap(g);
                }

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                    saveFileDialog.Title = "Save an Image File";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            bitmap.Save(saveFileDialog.FileName);
                            statusStrip1.Items[0].Text = $"Saved: {Path.GetFileName(saveFileDialog.FileName)}";
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error saving image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void DrawAllLinesOnBitmap(Graphics g)
        {
            foreach (var line in drawnLines)
            {
                g.DrawLine(new Pen(line.Color, line.Width), line.StartPoint, line.EndPoint);
            }
        }

        private void UndoBtn_Click(object sender, EventArgs e)
        {
            if (undoStack.Count > 0)
            {
                drawnLines = undoStack.Pop();
                DrawAllLines(); 
                PicRand.Invalidate();
                statusStrip1.Items[0].Text = "Undone Last Action";
            }
        }
    }

    public class Line
    {
        public Point StartPoint { get; }
        public Point EndPoint { get; }
        public Color Color { get; }
        public int Width { get; }

        public Line(Point startPoint, Point endPoint, Color color, int width)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
            Color = color;
            Width = width;
        }
    }
}
