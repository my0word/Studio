namespace EdikIvan
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RandomBtn = new Button();
            ChooseBtn = new Button();
            PicRand = new PictureBox();
            ExitBtn = new Button();
            ClearBtn = new Button();
            loglab = new Label();
            ColorBtn = new Button();
            trackBar1 = new TrackBar();
            WidthLbl = new Label();
            SaveBtn = new Button();
            statusStrip1 = new StatusStrip();
            UndoBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)PicRand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // RandomBtn
            // 
            RandomBtn.AutoSize = true;
            RandomBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RandomBtn.Location = new Point(492, 436);
            RandomBtn.Name = "RandomBtn";
            RandomBtn.Size = new Size(280, 47);
            RandomBtn.TabIndex = 0;
            RandomBtn.Text = "Случайная картинка";
            RandomBtn.UseVisualStyleBackColor = true;
            RandomBtn.Click += RandomBtn_Click;
            // 
            // ChooseBtn
            // 
            ChooseBtn.AutoSize = true;
            ChooseBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ChooseBtn.Location = new Point(492, 489);
            ChooseBtn.Name = "ChooseBtn";
            ChooseBtn.Size = new Size(280, 47);
            ChooseBtn.TabIndex = 1;
            ChooseBtn.Text = "Выбор картинки-->";
            ChooseBtn.UseVisualStyleBackColor = true;
            ChooseBtn.Click += ChooseBtn_Click;
            // 
            // PicRand
            // 
            PicRand.Location = new Point(172, 9);
            PicRand.Name = "PicRand";
            PicRand.Size = new Size(600, 400);
            PicRand.TabIndex = 2;
            PicRand.TabStop = false;
            PicRand.Paint += PicRand_Paint;
            PicRand.MouseDown += PicRand_MouseDown;
            PicRand.MouseMove += PicRand_MouseMove;
            PicRand.MouseUp += PicRand_MouseUp;
            // 
            // ExitBtn
            // 
            ExitBtn.AutoSize = true;
            ExitBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ExitBtn.Location = new Point(12, 489);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(104, 47);
            ExitBtn.TabIndex = 3;
            ExitBtn.Text = "Выход";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.AutoSize = true;
            ClearBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ClearBtn.Location = new Point(362, 436);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(124, 47);
            ClearBtn.TabIndex = 4;
            ClearBtn.Text = "Стереть";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // loglab
            // 
            loglab.AutoSize = true;
            loglab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loglab.Location = new Point(302, 412);
            loglab.Name = "loglab";
            loglab.Size = new Size(184, 21);
            loglab.TabIndex = 5;
            loglab.Text = "Тут вы можете рисовать";
            // 
            // ColorBtn
            // 
            ColorBtn.AutoSize = true;
            ColorBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ColorBtn.Location = new Point(274, 489);
            ColorBtn.Name = "ColorBtn";
            ColorBtn.Size = new Size(212, 47);
            ColorBtn.TabIndex = 6;
            ColorBtn.Text = "Поменять цвет";
            ColorBtn.UseVisualStyleBackColor = true;
            ColorBtn.Click += ColorBtn_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(12, 33);
            trackBar1.Maximum = 20;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(154, 45);
            trackBar1.TabIndex = 5;
            trackBar1.Value = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // WidthLbl
            // 
            WidthLbl.AutoSize = true;
            WidthLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WidthLbl.Location = new Point(31, 9);
            WidthLbl.Name = "WidthLbl";
            WidthLbl.Size = new Size(107, 21);
            WidthLbl.TabIndex = 7;
            WidthLbl.Text = "Ширина пера";
            // 
            // SaveBtn
            // 
            SaveBtn.AutoSize = true;
            SaveBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SaveBtn.Location = new Point(12, 383);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(125, 47);
            SaveBtn.TabIndex = 8;
            SaveBtn.Text = "Скачать";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 539);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(784, 22);
            statusStrip1.TabIndex = 9;
            statusStrip1.Text = "statusStrip1";
            // 
            // UndoBtn
            // 
            UndoBtn.AutoSize = true;
            UndoBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UndoBtn.Location = new Point(121, 436);
            UndoBtn.Name = "UndoBtn";
            UndoBtn.Size = new Size(235, 47);
            UndoBtn.TabIndex = 10;
            UndoBtn.Text = "Вернуть рисунок";
            UndoBtn.UseVisualStyleBackColor = true;
            UndoBtn.Click += UndoBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(784, 561);
            Controls.Add(UndoBtn);
            Controls.Add(statusStrip1);
            Controls.Add(SaveBtn);
            Controls.Add(WidthLbl);
            Controls.Add(trackBar1);
            Controls.Add(ColorBtn);
            Controls.Add(loglab);
            Controls.Add(ClearBtn);
            Controls.Add(ExitBtn);
            Controls.Add(PicRand);
            Controls.Add(ChooseBtn);
            Controls.Add(RandomBtn);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)PicRand).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RandomBtn;
        private Button ChooseBtn;
        private PictureBox PicRand;
        private Button ExitBtn;
        private Button ClearBtn;
        private Label loglab;
        private Button ColorBtn;
        private TrackBar trackBar1;
        private Label WidthLbl;
        private Button SaveBtn;
        private StatusStrip statusStrip1;
        private Button UndoBtn;
    }
}