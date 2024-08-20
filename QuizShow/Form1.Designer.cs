namespace QuizShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(266, 114);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(12, 133);
            button1.Name = "button1";
            button1.Size = new Size(130, 29);
            button1.TabIndex = 1;
            button1.Text = "A";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(148, 132);
            button2.Name = "button2";
            button2.Size = new Size(130, 30);
            button2.TabIndex = 2;
            button2.Text = "B";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 168);
            button3.Name = "button3";
            button3.Size = new Size(130, 28);
            button3.TabIndex = 3;
            button3.Text = "C";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(148, 168);
            button4.Name = "button4";
            button4.Size = new Size(130, 28);
            button4.TabIndex = 4;
            button4.Text = "D";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(284, 15);
            label1.Name = "label1";
            label1.Size = new Size(138, 21);
            label1.TabIndex = 5;
            label1.Text = "Question Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(379, 48);
            label2.Name = "label2";
            label2.Size = new Size(43, 21);
            label2.TabIndex = 6;
            label2.Text = "True:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(379, 82);
            label3.Name = "label3";
            label3.Size = new Size(47, 21);
            label3.TabIndex = 7;
            label3.Text = "False:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(428, 15);
            label4.Name = "label4";
            label4.Size = new Size(19, 21);
            label4.TabIndex = 8;
            label4.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(428, 48);
            label5.Name = "label5";
            label5.Size = new Size(19, 21);
            label5.TabIndex = 9;
            label5.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(428, 82);
            label6.Name = "label6";
            label6.Size = new Size(19, 21);
            label6.TabIndex = 10;
            label6.Text = "0";
            // 
            // button5
            // 
            button5.Location = new Point(290, 106);
            button5.Name = "button5";
            button5.Size = new Size(157, 34);
            button5.TabIndex = 11;
            button5.Text = "next";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(284, 146);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(381, 146);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(93, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 225);
            label7.Name = "label7";
            label7.Size = new Size(52, 21);
            label7.TabIndex = 15;
            label7.Text = "label7";
            label7.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(111, 225);
            label8.Name = "label8";
            label8.Size = new Size(52, 21);
            label8.TabIndex = 16;
            label8.Text = "label8";
            label8.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 223);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label7;
        private Label label8;
    }
}
