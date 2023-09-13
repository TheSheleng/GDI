namespace _13._9._2023__dz_
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
            this.ChromPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ChromClose = new _13._9._2023__dz_.MyRoundButton();
            this.ChromMinimize = new _13._9._2023__dz_.MyRoundButton();
            this.ChromPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChromPanel
            // 
            this.ChromPanel.BackColor = System.Drawing.Color.MediumPurple;
            this.ChromPanel.Controls.Add(this.ChromClose);
            this.ChromPanel.Controls.Add(this.ChromMinimize);
            this.ChromPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChromPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.ChromPanel.Location = new System.Drawing.Point(0, 0);
            this.ChromPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ChromPanel.Name = "ChromPanel";
            this.ChromPanel.Size = new System.Drawing.Size(500, 60);
            this.ChromPanel.TabIndex = 2;
            this.ChromPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChromPanel_MouseDown);
            // 
            // ChromClose
            // 
            this.ChromClose.BackColor = System.Drawing.Color.FloralWhite;
            this.ChromClose.BorderRadius = 15;
            this.ChromClose.FlatAppearance.BorderSize = 0;
            this.ChromClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChromClose.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChromClose.ForeColor = System.Drawing.Color.Black;
            this.ChromClose.Location = new System.Drawing.Point(445, 5);
            this.ChromClose.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.ChromClose.Name = "ChromClose";
            this.ChromClose.Size = new System.Drawing.Size(50, 50);
            this.ChromClose.TabIndex = 3;
            this.ChromClose.UseVisualStyleBackColor = false;
            this.ChromClose.Click += new System.EventHandler(this.ChromClose_Click);
            // 
            // ChromMinimize
            // 
            this.ChromMinimize.BackColor = System.Drawing.Color.FloralWhite;
            this.ChromMinimize.BorderRadius = 15;
            this.ChromMinimize.FlatAppearance.BorderSize = 0;
            this.ChromMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChromMinimize.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChromMinimize.ForeColor = System.Drawing.Color.Black;
            this.ChromMinimize.Location = new System.Drawing.Point(390, 5);
            this.ChromMinimize.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.ChromMinimize.Name = "ChromMinimize";
            this.ChromMinimize.Size = new System.Drawing.Size(50, 50);
            this.ChromMinimize.TabIndex = 4;
            this.ChromMinimize.UseVisualStyleBackColor = false;
            this.ChromMinimize.Click += new System.EventHandler(this.ChromMinimize_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.ChromPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ChromPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel ChromPanel;
        private MyRoundButton ChromClose;
        private MyRoundButton ChromMinimize;
    }
}