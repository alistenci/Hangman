namespace Adam_Asmaca_
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
            components = new System.ComponentModel.Container();
            lblBilgi = new Label();
            pictureBox1 = new PictureBox();
            lblHak = new Label();
            label2 = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lblSaniye = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblBilgi
            // 
            lblBilgi.BorderStyle = BorderStyle.FixedSingle;
            lblBilgi.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblBilgi.Location = new Point(12, 9);
            lblBilgi.Name = "lblBilgi";
            lblBilgi.Size = new Size(1039, 49);
            lblBilgi.TabIndex = 9;
            lblBilgi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1071, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 399);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // lblHak
            // 
            lblHak.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblHak.Location = new Point(12, 326);
            lblHak.Name = "lblHak";
            lblHak.Size = new Size(247, 32);
            lblHak.TabIndex = 7;
            lblHak.Text = "Your Remaining Right:";
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 195);
            label2.Name = "label2";
            label2.Size = new Size(1039, 107);
            label2.TabIndex = 5;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 73);
            label1.Name = "label1";
            label1.Size = new Size(1039, 107);
            label1.TabIndex = 6;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblSaniye
            // 
            lblSaniye.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaniye.Location = new Point(239, 367);
            lblSaniye.Name = "lblSaniye";
            lblSaniye.Size = new Size(690, 41);
            lblSaniye.TabIndex = 11;
            lblSaniye.Text = "Congratulations, you won. The app  will restart 3 seconds after";
            lblSaniye.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(588, 314);
            label3.Name = "label3";
            label3.Size = new Size(463, 44);
            label3.TabIndex = 12;
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(322, 314);
            label4.Name = "label4";
            label4.Size = new Size(258, 44);
            label4.TabIndex = 12;
            label4.Text = "Keys Pressed";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 449);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblBilgi);
            Controls.Add(pictureBox1);
            Controls.Add(lblHak);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblSaniye);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            KeyPress += Form1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblBilgi;
        private PictureBox pictureBox1;
        private Label lblHak;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label lblSaniye;
        private Label label3;
        private Label label4;
    }
}