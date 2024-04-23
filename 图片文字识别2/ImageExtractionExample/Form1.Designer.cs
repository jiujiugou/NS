namespace ImageExtractionExample
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
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            extractTextButton = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(48, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(687, 622);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(741, 23);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(846, 622);
            textBox1.TabIndex = 1;
            // 
            // extractTextButton
            // 
            extractTextButton.Location = new Point(1621, 547);
            extractTextButton.Name = "extractTextButton";
            extractTextButton.Size = new Size(118, 49);
            extractTextButton.TabIndex = 2;
            extractTextButton.Text = "提取";
            extractTextButton.UseVisualStyleBackColor = true;
            extractTextButton.Click += extractTextButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1624, 486);
            button1.Name = "button1";
            button1.Size = new Size(115, 44);
            button1.TabIndex = 3;
            button1.Text = "清空";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1783, 680);
            Controls.Add(button1);
            Controls.Add(extractTextButton);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button extractTextButton;
        private Button button1;
    }
}
