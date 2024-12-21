namespace TickTackToe
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
            Button btnBaslat;
            lblPlayer1 = new Label();
            lblPlayer2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pb1 = new PictureBox();
            pb2 = new PictureBox();
            pb3 = new PictureBox();
            pb4 = new PictureBox();
            pb5 = new PictureBox();
            pb6 = new PictureBox();
            pb7 = new PictureBox();
            pb8 = new PictureBox();
            pb9 = new PictureBox();
            panel1 = new Panel();
            lblSs1 = new Label();
            lblSs2 = new Label();
            lblKazan = new Label();
            btnBaslat = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb9).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBaslat
            // 
            btnBaslat.BackColor = Color.FromArgb(192, 0, 0);
            btnBaslat.Cursor = Cursors.Hand;
            btnBaslat.ForeColor = Color.White;
            btnBaslat.Location = new Point(167, 28);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.RightToLeft = RightToLeft.No;
            btnBaslat.Size = new Size(124, 58);
            btnBaslat.TabIndex = 0;
            btnBaslat.Text = "BASLAT";
            btnBaslat.UseVisualStyleBackColor = false;
            btnBaslat.Click += btnBaslat_Click_1;
            // 
            // lblPlayer1
            // 
            lblPlayer1.BackColor = Color.Maroon;
            lblPlayer1.ForeColor = Color.White;
            lblPlayer1.Location = new Point(3, 85);
            lblPlayer1.Name = "lblPlayer1";
            lblPlayer1.Size = new Size(103, 30);
            lblPlayer1.TabIndex = 1;
            lblPlayer1.Text = "PLAYER 1";
            lblPlayer1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPlayer2
            // 
            lblPlayer2.BackColor = Color.Maroon;
            lblPlayer2.ForeColor = Color.White;
            lblPlayer2.Location = new Point(359, 85);
            lblPlayer2.Name = "lblPlayer2";
            lblPlayer2.Size = new Size(103, 30);
            lblPlayer2.TabIndex = 1;
            lblPlayer2.Text = "PLAYER 2";
            lblPlayer2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Bisque;
            pictureBox1.Image = Properties.Resources.ticktacktoeX1;
            pictureBox1.Location = new Point(3, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Bisque;
            pictureBox2.Image = Properties.Resources.ticktacktoeO1;
            pictureBox2.Location = new Point(359, 118);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(103, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pb1
            // 
            pb1.Anchor = AnchorStyles.None;
            pb1.BorderStyle = BorderStyle.FixedSingle;
            pb1.Cursor = Cursors.Hand;
            pb1.Location = new Point(18, 14);
            pb1.Name = "pb1";
            pb1.Size = new Size(50, 50);
            pb1.SizeMode = PictureBoxSizeMode.Zoom;
            pb1.TabIndex = 3;
            pb1.TabStop = false;
            pb1.Click += pb_Click;
            // 
            // pb2
            // 
            pb2.Anchor = AnchorStyles.None;
            pb2.BorderStyle = BorderStyle.FixedSingle;
            pb2.Cursor = Cursors.Hand;
            pb2.Location = new Point(74, 14);
            pb2.Name = "pb2";
            pb2.Size = new Size(50, 50);
            pb2.SizeMode = PictureBoxSizeMode.Zoom;
            pb2.TabIndex = 3;
            pb2.TabStop = false;
            pb2.Click += pb_Click;
            // 
            // pb3
            // 
            pb3.Anchor = AnchorStyles.None;
            pb3.BorderStyle = BorderStyle.FixedSingle;
            pb3.Cursor = Cursors.Hand;
            pb3.Location = new Point(130, 14);
            pb3.Name = "pb3";
            pb3.Size = new Size(50, 50);
            pb3.SizeMode = PictureBoxSizeMode.Zoom;
            pb3.TabIndex = 3;
            pb3.TabStop = false;
            pb3.Click += pb_Click;
            // 
            // pb4
            // 
            pb4.Anchor = AnchorStyles.None;
            pb4.BorderStyle = BorderStyle.FixedSingle;
            pb4.Cursor = Cursors.Hand;
            pb4.Location = new Point(18, 70);
            pb4.Name = "pb4";
            pb4.Size = new Size(50, 50);
            pb4.SizeMode = PictureBoxSizeMode.Zoom;
            pb4.TabIndex = 3;
            pb4.TabStop = false;
            pb4.Click += pb_Click;
            // 
            // pb5
            // 
            pb5.Anchor = AnchorStyles.None;
            pb5.BorderStyle = BorderStyle.FixedSingle;
            pb5.Cursor = Cursors.Hand;
            pb5.Location = new Point(74, 70);
            pb5.Name = "pb5";
            pb5.Size = new Size(50, 50);
            pb5.SizeMode = PictureBoxSizeMode.Zoom;
            pb5.TabIndex = 3;
            pb5.TabStop = false;
            pb5.Click += pb_Click;
            // 
            // pb6
            // 
            pb6.Anchor = AnchorStyles.None;
            pb6.BorderStyle = BorderStyle.FixedSingle;
            pb6.Cursor = Cursors.Hand;
            pb6.Location = new Point(130, 70);
            pb6.Name = "pb6";
            pb6.Size = new Size(50, 50);
            pb6.SizeMode = PictureBoxSizeMode.Zoom;
            pb6.TabIndex = 3;
            pb6.TabStop = false;
            pb6.Click += pb_Click;
            // 
            // pb7
            // 
            pb7.Anchor = AnchorStyles.None;
            pb7.BorderStyle = BorderStyle.FixedSingle;
            pb7.Cursor = Cursors.Hand;
            pb7.Location = new Point(18, 126);
            pb7.Name = "pb7";
            pb7.Size = new Size(50, 50);
            pb7.SizeMode = PictureBoxSizeMode.Zoom;
            pb7.TabIndex = 3;
            pb7.TabStop = false;
            pb7.Click += pb_Click;
            // 
            // pb8
            // 
            pb8.Anchor = AnchorStyles.None;
            pb8.BorderStyle = BorderStyle.FixedSingle;
            pb8.Cursor = Cursors.Hand;
            pb8.Location = new Point(74, 126);
            pb8.Name = "pb8";
            pb8.Size = new Size(50, 50);
            pb8.SizeMode = PictureBoxSizeMode.Zoom;
            pb8.TabIndex = 3;
            pb8.TabStop = false;
            pb8.Click += pb_Click;
            // 
            // pb9
            // 
            pb9.Anchor = AnchorStyles.None;
            pb9.BorderStyle = BorderStyle.FixedSingle;
            pb9.Cursor = Cursors.Hand;
            pb9.Location = new Point(130, 126);
            pb9.Name = "pb9";
            pb9.Size = new Size(50, 50);
            pb9.SizeMode = PictureBoxSizeMode.Zoom;
            pb9.TabIndex = 3;
            pb9.TabStop = false;
            pb9.Click += pb_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(pb1);
            panel1.Controls.Add(pb9);
            panel1.Controls.Add(pb2);
            panel1.Controls.Add(pb8);
            panel1.Controls.Add(pb4);
            panel1.Controls.Add(pb6);
            panel1.Controls.Add(pb3);
            panel1.Controls.Add(pb5);
            panel1.Controls.Add(pb7);
            panel1.Location = new Point(134, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 191);
            panel1.TabIndex = 4;
            // 
            // lblSs1
            // 
            lblSs1.BackColor = Color.Maroon;
            lblSs1.ForeColor = Color.White;
            lblSs1.Location = new Point(3, 171);
            lblSs1.Name = "lblSs1";
            lblSs1.Size = new Size(103, 42);
            lblSs1.TabIndex = 1;
            lblSs1.Text = "SIRA SIZDE";
            lblSs1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSs2
            // 
            lblSs2.BackColor = Color.Maroon;
            lblSs2.ForeColor = Color.White;
            lblSs2.Location = new Point(359, 171);
            lblSs2.Name = "lblSs2";
            lblSs2.Size = new Size(103, 42);
            lblSs2.TabIndex = 1;
            lblSs2.Text = "SIRA SIZDE";
            lblSs2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKazan
            // 
            lblKazan.BackColor = Color.Maroon;
            lblKazan.ForeColor = Color.White;
            lblKazan.Location = new Point(167, 334);
            lblKazan.Name = "lblKazan";
            lblKazan.Size = new Size(124, 30);
            lblKazan.TabIndex = 1;
            lblKazan.Text = "KAZANAN";
            lblKazan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(464, 441);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblPlayer2);
            Controls.Add(lblSs2);
            Controls.Add(lblKazan);
            Controls.Add(lblSs1);
            Controls.Add(lblPlayer1);
            Controls.Add(btnBaslat);
            Font = new Font("Showcard Gothic", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb9).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnBaslat;
        private Label lblPlayer1;
        private Label lblPlayer2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pb1;
        private PictureBox pb2;
        private PictureBox pb3;
        private PictureBox pb4;
        private PictureBox pb5;
        private PictureBox pb6;
        private PictureBox pb7;
        private PictureBox pb8;
        private PictureBox pb9;
        private Panel panel1;
        private Label lblSs1;
        private Label lblSs2;
        private Label lblKazan;
    }
}
