namespace _9._6._2023__dz_
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            labelX_0 = new Label();
            labelX_125 = new Label();
            labelX_250 = new Label();
            labelX__125 = new Label();
            labelX__250 = new Label();
            labelY__250 = new Label();
            labelY__125 = new Label();
            labelY_250 = new Label();
            labelY_125 = new Label();
            labelY_0 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 759);
            label1.Name = "label1";
            label1.Size = new Size(85, 48);
            label1.TabIndex = 0;
            label1.Text = "Y = ";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(107, 762);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(482, 55);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(30, 823);
            button1.Name = "button1";
            button1.Size = new Size(559, 55);
            button1.TabIndex = 2;
            button1.Text = "Рисовать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(68, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 500);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 890);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 4;
            // 
            // trackBar1
            // 
            trackBar1.LargeChange = 1;
            trackBar1.Location = new Point(30, 577);
            trackBar1.Maximum = 20;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(559, 69);
            trackBar1.TabIndex = 5;
            trackBar1.Value = 1;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(30, 652);
            trackBar2.Maximum = 100;
            trackBar2.Minimum = 1;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(559, 69);
            trackBar2.TabIndex = 6;
            trackBar2.Value = 100;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(30, 727);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(70, 29);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Оси";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(100, 727);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(83, 29);
            checkBox2.TabIndex = 8;
            checkBox2.Text = "Сетка";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // labelX_0
            // 
            labelX_0.AutoSize = true;
            labelX_0.Location = new Point(310, 11);
            labelX_0.Name = "labelX_0";
            labelX_0.Size = new Size(22, 25);
            labelX_0.TabIndex = 9;
            labelX_0.Text = "0";
            labelX_0.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelX_125
            // 
            labelX_125.AutoSize = true;
            labelX_125.Location = new Point(418, 11);
            labelX_125.Name = "labelX_125";
            labelX_125.Size = new Size(54, 25);
            labelX_125.TabIndex = 10;
            labelX_125.Text = "+125";
            labelX_125.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelX_250
            // 
            labelX_250.AutoSize = true;
            labelX_250.Location = new Point(543, 11);
            labelX_250.Name = "labelX_250";
            labelX_250.Size = new Size(54, 25);
            labelX_250.TabIndex = 11;
            labelX_250.Text = "+250";
            labelX_250.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelX__125
            // 
            labelX__125.AutoSize = true;
            labelX__125.Location = new Point(168, 11);
            labelX__125.Name = "labelX__125";
            labelX__125.Size = new Size(49, 25);
            labelX__125.TabIndex = 12;
            labelX__125.Text = "-125";
            labelX__125.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelX__250
            // 
            labelX__250.AutoSize = true;
            labelX__250.Location = new Point(43, 11);
            labelX__250.Name = "labelX__250";
            labelX__250.Size = new Size(49, 25);
            labelX__250.TabIndex = 13;
            labelX__250.Text = "-250";
            labelX__250.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelY__250
            // 
            labelY__250.AutoSize = true;
            labelY__250.Location = new Point(13, 514);
            labelY__250.Name = "labelY__250";
            labelY__250.Size = new Size(49, 25);
            labelY__250.TabIndex = 18;
            labelY__250.Text = "-250";
            labelY__250.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelY__125
            // 
            labelY__125.AutoSize = true;
            labelY__125.Location = new Point(13, 404);
            labelY__125.Name = "labelY__125";
            labelY__125.Size = new Size(49, 25);
            labelY__125.TabIndex = 17;
            labelY__125.Text = "-125";
            labelY__125.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelY_250
            // 
            labelY_250.AutoSize = true;
            labelY_250.Location = new Point(8, 39);
            labelY_250.Name = "labelY_250";
            labelY_250.Size = new Size(54, 25);
            labelY_250.TabIndex = 16;
            labelY_250.Text = "+250";
            labelY_250.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelY_125
            // 
            labelY_125.AutoSize = true;
            labelY_125.Location = new Point(8, 155);
            labelY_125.Name = "labelY_125";
            labelY_125.Size = new Size(54, 25);
            labelY_125.TabIndex = 15;
            labelY_125.Text = "+125";
            labelY_125.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelY_0
            // 
            labelY_0.AutoSize = true;
            labelY_0.Location = new Point(40, 279);
            labelY_0.Name = "labelY_0";
            labelY_0.Size = new Size(22, 25);
            labelY_0.TabIndex = 14;
            labelY_0.Text = "0";
            labelY_0.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 947);
            Controls.Add(labelY__250);
            Controls.Add(labelY__125);
            Controls.Add(labelY_250);
            Controls.Add(labelY_125);
            Controls.Add(labelY_0);
            Controls.Add(labelX__250);
            Controls.Add(labelX__125);
            Controls.Add(labelX_250);
            Controls.Add(labelX_125);
            Controls.Add(labelX_0);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label2;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label labelX_0;
        private Label labelX_125;
        private Label labelX_250;
        private Label labelX__125;
        private Label labelX__250;
        private Label labelY__250;
        private Label labelY__125;
        private Label labelY_250;
        private Label labelY_125;
        private Label labelY_0;
    }
}