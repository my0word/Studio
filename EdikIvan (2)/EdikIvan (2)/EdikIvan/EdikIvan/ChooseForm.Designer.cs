namespace EdikIvan
{
    partial class ChooseForm
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
            PicChoose = new PictureBox();
            oneBtn = new Button();
            fourBtn = new Button();
            threeBtn = new Button();
            twoBtn = new Button();
            saveBtn = new Button();
            resetBtn = new Button();
            brightnessBar = new TrackBar();
            contrastBar = new TrackBar();
            rotateLeftBtn = new Button();
            rotateRightBtn = new Button();
            invertBtn = new Button();
            grayscaleBtn = new Button();
            purpleBtn = new Button();
            ExitBtn = new Button();
            fiveBtn = new Button();
            sixBtn = new Button();
            sevenBtn = new Button();
            eightBtn = new Button();
            nineBtn = new Button();
            tenBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)PicChoose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)brightnessBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contrastBar).BeginInit();
            SuspendLayout();
            // 
            // PicChoose
            // 
            PicChoose.Location = new Point(106, 28);
            PicChoose.Name = "PicChoose";
            PicChoose.Size = new Size(600, 400);
            PicChoose.TabIndex = 3;
            PicChoose.TabStop = false;
            // 
            // oneBtn
            // 
            oneBtn.Location = new Point(104, 435);
            oneBtn.Name = "oneBtn";
            oneBtn.Size = new Size(75, 23);
            oneBtn.TabIndex = 4;
            oneBtn.Text = "1";
            oneBtn.UseVisualStyleBackColor = true;
            oneBtn.Click += oneBtn_Click;
            // 
            // fourBtn
            // 
            fourBtn.Location = new Point(104, 464);
            fourBtn.Name = "fourBtn";
            fourBtn.Size = new Size(75, 23);
            fourBtn.TabIndex = 5;
            fourBtn.Text = "4";
            fourBtn.UseVisualStyleBackColor = true;
            fourBtn.Click += fourBtn_Click;
            // 
            // threeBtn
            // 
            threeBtn.Location = new Point(266, 435);
            threeBtn.Name = "threeBtn";
            threeBtn.Size = new Size(75, 23);
            threeBtn.TabIndex = 6;
            threeBtn.Text = "3";
            threeBtn.UseVisualStyleBackColor = true;
            threeBtn.Click += threeBtn_Click;
            // 
            // twoBtn
            // 
            twoBtn.Location = new Point(185, 435);
            twoBtn.Name = "twoBtn";
            twoBtn.Size = new Size(75, 23);
            twoBtn.TabIndex = 7;
            twoBtn.Text = "2";
            twoBtn.UseVisualStyleBackColor = true;
            twoBtn.Click += twoBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(528, 493);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(89, 23);
            saveBtn.TabIndex = 8;
            saveBtn.Text = "сохранить";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(447, 493);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(75, 23);
            resetBtn.TabIndex = 9;
            resetBtn.Text = "сброс";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // brightnessBar
            // 
            brightnessBar.Location = new Point(12, 37);
            brightnessBar.Name = "brightnessBar";
            brightnessBar.Size = new Size(74, 45);
            brightnessBar.TabIndex = 11;
            brightnessBar.Scroll += brightnessBar_Scroll;
            // 
            // contrastBar
            // 
            contrastBar.Location = new Point(12, 88);
            contrastBar.Name = "contrastBar";
            contrastBar.Size = new Size(74, 45);
            contrastBar.TabIndex = 12;
            contrastBar.Scroll += contrastBar_Scroll;
            // 
            // rotateLeftBtn
            // 
            rotateLeftBtn.AutoSize = true;
            rotateLeftBtn.Location = new Point(638, 464);
            rotateLeftBtn.Name = "rotateLeftBtn";
            rotateLeftBtn.Size = new Size(68, 25);
            rotateLeftBtn.TabIndex = 13;
            rotateLeftBtn.Text = "влево";
            rotateLeftBtn.UseVisualStyleBackColor = true;
            rotateLeftBtn.Click += rotateLeftBtn_Click;
            // 
            // rotateRightBtn
            // 
            rotateRightBtn.Location = new Point(638, 435);
            rotateRightBtn.Name = "rotateRightBtn";
            rotateRightBtn.Size = new Size(68, 23);
            rotateRightBtn.TabIndex = 14;
            rotateRightBtn.Text = "вправо";
            rotateRightBtn.UseVisualStyleBackColor = true;
            rotateRightBtn.Click += rotateRightBtn_Click;
            // 
            // invertBtn
            // 
            invertBtn.Location = new Point(477, 464);
            invertBtn.Name = "invertBtn";
            invertBtn.Size = new Size(97, 23);
            invertBtn.TabIndex = 15;
            invertBtn.Text = "инвертировать";
            invertBtn.UseVisualStyleBackColor = true;
            invertBtn.Click += invertBtn_Click;
            // 
            // grayscaleBtn
            // 
            grayscaleBtn.Location = new Point(447, 437);
            grayscaleBtn.Name = "grayscaleBtn";
            grayscaleBtn.Size = new Size(75, 23);
            grayscaleBtn.TabIndex = 17;
            grayscaleBtn.Text = "серый";
            grayscaleBtn.UseVisualStyleBackColor = true;
            grayscaleBtn.Click += grayscaleBtn_Click;
            // 
            // purpleBtn
            // 
            purpleBtn.Location = new Point(528, 437);
            purpleBtn.Name = "purpleBtn";
            purpleBtn.Size = new Size(89, 23);
            purpleBtn.TabIndex = 18;
            purpleBtn.Text = "пурпурный";
            purpleBtn.UseVisualStyleBackColor = true;
            purpleBtn.Click += purpleBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(11, 526);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(75, 23);
            ExitBtn.TabIndex = 19;
            ExitBtn.Text = "Вернуться";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // fiveBtn
            // 
            fiveBtn.Location = new Point(185, 464);
            fiveBtn.Name = "fiveBtn";
            fiveBtn.Size = new Size(75, 23);
            fiveBtn.TabIndex = 20;
            fiveBtn.Text = "5";
            fiveBtn.UseVisualStyleBackColor = true;
            fiveBtn.Click += fiveBtn_Click;
            // 
            // sixBtn
            // 
            sixBtn.Location = new Point(266, 464);
            sixBtn.Name = "sixBtn";
            sixBtn.Size = new Size(75, 23);
            sixBtn.TabIndex = 21;
            sixBtn.Text = "6";
            sixBtn.UseVisualStyleBackColor = true;
            sixBtn.Click += sixBtn_Click;
            // 
            // sevenBtn
            // 
            sevenBtn.Location = new Point(104, 493);
            sevenBtn.Name = "sevenBtn";
            sevenBtn.Size = new Size(75, 23);
            sevenBtn.TabIndex = 22;
            sevenBtn.Text = "7";
            sevenBtn.UseVisualStyleBackColor = true;
            sevenBtn.Click += sevenBtn_Click;
            // 
            // eightBtn
            // 
            eightBtn.Location = new Point(185, 493);
            eightBtn.Name = "eightBtn";
            eightBtn.Size = new Size(75, 23);
            eightBtn.TabIndex = 23;
            eightBtn.Text = "8";
            eightBtn.UseVisualStyleBackColor = true;
            eightBtn.Click += eightBtn_Click;
            // 
            // nineBtn
            // 
            nineBtn.Location = new Point(266, 493);
            nineBtn.Name = "nineBtn";
            nineBtn.Size = new Size(75, 23);
            nineBtn.TabIndex = 24;
            nineBtn.Text = "9";
            nineBtn.UseVisualStyleBackColor = true;
            nineBtn.Click += nineBtn_Click;
            // 
            // tenBtn
            // 
            tenBtn.Location = new Point(185, 522);
            tenBtn.Name = "tenBtn";
            tenBtn.Size = new Size(75, 23);
            tenBtn.TabIndex = 25;
            tenBtn.Text = "10";
            tenBtn.UseVisualStyleBackColor = true;
            tenBtn.Click += tenBtn_Click;
            // 
            // ChooseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(784, 561);
            Controls.Add(tenBtn);
            Controls.Add(nineBtn);
            Controls.Add(eightBtn);
            Controls.Add(sevenBtn);
            Controls.Add(sixBtn);
            Controls.Add(fiveBtn);
            Controls.Add(ExitBtn);
            Controls.Add(purpleBtn);
            Controls.Add(grayscaleBtn);
            Controls.Add(invertBtn);
            Controls.Add(rotateRightBtn);
            Controls.Add(rotateLeftBtn);
            Controls.Add(contrastBar);
            Controls.Add(brightnessBar);
            Controls.Add(resetBtn);
            Controls.Add(saveBtn);
            Controls.Add(twoBtn);
            Controls.Add(threeBtn);
            Controls.Add(fourBtn);
            Controls.Add(oneBtn);
            Controls.Add(PicChoose);
            Name = "ChooseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChooseForm";
            ((System.ComponentModel.ISupportInitialize)PicChoose).EndInit();
            ((System.ComponentModel.ISupportInitialize)brightnessBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)contrastBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PicChoose;
        private Button oneBtn;
        private Button fourBtn;
        private Button threeBtn;
        private Button twoBtn;
        private Button saveBtn;
        private Button resetBtn;
        private TrackBar brightnessBar;
        private TrackBar contrastBar;
        private Button rotateLeftBtn;
        private Button rotateRightBtn;
        private Button invertBtn;
        private Button grayscaleBtn;
        private Button purpleBtn;
        private Button ExitBtn;
        private Button fiveBtn;
        private Button sixBtn;
        private Button sevenBtn;
        private Button eightBtn;
        private Button nineBtn;
        private Button tenBtn;
    }
}