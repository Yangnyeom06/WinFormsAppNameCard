namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 20F);
            button1.Location = new Point(499, 349);
            button1.Name = "button1";
            button1.Size = new Size(219, 71);
            button1.TabIndex = 0;
            button1.Text = "배경색 바꾸기";
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 30F, FontStyle.Bold);
            label1.Location = new Point(311, 71);
            label1.Name = "label1";
            label1.Size = new Size(143, 54);
            label1.TabIndex = 1;
            label1.Text = "유정인";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 20F);
            label2.ForeColor = Color.FromArgb(192, 64, 0);
            label2.Location = new Point(311, 160);
            label2.Name = "label2";
            label2.Size = new Size(283, 74);
            label2.TabIndex = 2;
            label2.Text = "수원대 컴퓨터SW학과\r\n25017056";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.화면_캡처_2026_03_05_165815;
            pictureBox1.Location = new Point(65, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 272);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("맑은 고딕", 20F);
            button2.Location = new Point(49, 349);
            button2.Name = "button2";
            button2.Size = new Size(226, 71);
            button2.TabIndex = 4;
            button2.Text = "사진 변경";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("맑은 고딕", 20F);
            button3.Location = new Point(311, 267);
            button3.Name = "button3";
            button3.Size = new Size(180, 58);
            button3.TabIndex = 5;
            button3.Text = "GitHub";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 457);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button3;
    }
}
