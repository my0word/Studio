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
            ExitBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)PicChoose).BeginInit();
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
            oneBtn.Location = new Point(182, 498);
            oneBtn.Name = "oneBtn";
            oneBtn.Size = new Size(75, 23);
            oneBtn.TabIndex = 4;
            oneBtn.Text = "1";
            oneBtn.UseVisualStyleBackColor = true;
            oneBtn.Click += oneBtn_Click;
            // 
            // fourBtn
            // 
            fourBtn.Location = new Point(514, 498);
            fourBtn.Name = "fourBtn";
            fourBtn.Size = new Size(75, 23);
            fourBtn.TabIndex = 5;
            fourBtn.Text = "4";
            fourBtn.UseVisualStyleBackColor = true;
            fourBtn.Click += fourBtn_Click;
            // 
            // threeBtn
            // 
            threeBtn.Location = new Point(410, 498);
            threeBtn.Name = "threeBtn";
            threeBtn.Size = new Size(75, 23);
            threeBtn.TabIndex = 6;
            threeBtn.Text = "3";
            threeBtn.UseVisualStyleBackColor = true;
            threeBtn.Click += threeBtn_Click;
            // 
            // twoBtn
            // 
            twoBtn.Location = new Point(293, 498);
            twoBtn.Name = "twoBtn";
            twoBtn.Size = new Size(75, 23);
            twoBtn.TabIndex = 7;
            twoBtn.Text = "2";
            twoBtn.UseVisualStyleBackColor = true;
            twoBtn.Click += twoBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(12, 526);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(75, 23);
            ExitBtn.TabIndex = 8;
            ExitBtn.Text = "Вернуться";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // ChooseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(784, 561);
            Controls.Add(ExitBtn);
            Controls.Add(twoBtn);
            Controls.Add(threeBtn);
            Controls.Add(fourBtn);
            Controls.Add(oneBtn);
            Controls.Add(PicChoose);
            Name = "ChooseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChooseForm";
            ((System.ComponentModel.ISupportInitialize)PicChoose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PicChoose;
        private Button oneBtn;
        private Button fourBtn;
        private Button threeBtn;
        private Button twoBtn;
        private Button ExitBtn;
    }
}