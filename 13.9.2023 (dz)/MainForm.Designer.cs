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
            ChromPanel = new FlowLayoutPanel();
            ChromClose = new MyRoundButton();
            ChromMinimize = new MyRoundButton();
            label_name = new Label();
            label_age = new Label();
            textBox_name = new TextBox();
            panel_name = new Panel();
            panel_age = new Panel();
            textBox_age = new TextBox();
            button_save = new MyRoundButton();
            button_showAll = new MyRoundButton();
            boundButton_search = new MyRoundButton();
            panel_search = new Panel();
            textBox_search = new TextBox();
            listView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            ChromPanel.SuspendLayout();
            panel_name.SuspendLayout();
            panel_age.SuspendLayout();
            panel_search.SuspendLayout();
            SuspendLayout();
            // 
            // ChromPanel
            // 
            ChromPanel.BackColor = Color.MediumPurple;
            ChromPanel.Controls.Add(ChromClose);
            ChromPanel.Controls.Add(ChromMinimize);
            ChromPanel.Dock = DockStyle.Top;
            ChromPanel.FlowDirection = FlowDirection.RightToLeft;
            ChromPanel.Location = new Point(0, 0);
            ChromPanel.Margin = new Padding(0);
            ChromPanel.Name = "ChromPanel";
            ChromPanel.Size = new Size(600, 70);
            ChromPanel.TabIndex = 2;
            ChromPanel.MouseDown += ChromPanel_MouseDown;
            // 
            // ChromClose
            // 
            ChromClose.BackColor = Color.FloralWhite;
            ChromClose.BorderRadius = 15;
            ChromClose.FlatAppearance.BorderSize = 0;
            ChromClose.FlatStyle = FlatStyle.Flat;
            ChromClose.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ChromClose.ForeColor = Color.Black;
            ChromClose.Location = new Point(541, 10);
            ChromClose.Margin = new Padding(0, 10, 9, 10);
            ChromClose.Name = "ChromClose";
            ChromClose.Size = new Size(50, 50);
            ChromClose.TabIndex = 3;
            ChromClose.UseVisualStyleBackColor = false;
            ChromClose.Click += ChromClose_Click;
            // 
            // ChromMinimize
            // 
            ChromMinimize.BackColor = Color.FloralWhite;
            ChromMinimize.BorderRadius = 15;
            ChromMinimize.FlatAppearance.BorderSize = 0;
            ChromMinimize.FlatStyle = FlatStyle.Flat;
            ChromMinimize.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ChromMinimize.ForeColor = Color.Black;
            ChromMinimize.Location = new Point(482, 10);
            ChromMinimize.Margin = new Padding(0, 10, 9, 10);
            ChromMinimize.Name = "ChromMinimize";
            ChromMinimize.Size = new Size(50, 50);
            ChromMinimize.TabIndex = 4;
            ChromMinimize.UseVisualStyleBackColor = false;
            ChromMinimize.Click += ChromMinimize_Click;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(14, 92);
            label_name.Margin = new Padding(5, 0, 5, 0);
            label_name.Name = "label_name";
            label_name.Size = new Size(102, 52);
            label_name.TabIndex = 3;
            label_name.Text = "Name";
            // 
            // label_age
            // 
            label_age.AutoSize = true;
            label_age.Location = new Point(14, 165);
            label_age.Margin = new Padding(5, 0, 5, 0);
            label_age.Name = "label_age";
            label_age.Size = new Size(73, 52);
            label_age.TabIndex = 4;
            label_age.Text = "Age";
            // 
            // textBox_name
            // 
            textBox_name.BackColor = Color.FloralWhite;
            textBox_name.BorderStyle = BorderStyle.None;
            textBox_name.Dock = DockStyle.Top;
            textBox_name.Location = new Point(0, 0);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(428, 46);
            textBox_name.TabIndex = 5;
            // 
            // panel_name
            // 
            panel_name.BackColor = Color.MediumPurple;
            panel_name.Controls.Add(textBox_name);
            panel_name.Location = new Point(160, 93);
            panel_name.Name = "panel_name";
            panel_name.Size = new Size(428, 51);
            panel_name.TabIndex = 6;
            // 
            // panel_age
            // 
            panel_age.BackColor = Color.MediumPurple;
            panel_age.Controls.Add(textBox_age);
            panel_age.Location = new Point(160, 165);
            panel_age.Name = "panel_age";
            panel_age.Size = new Size(428, 51);
            panel_age.TabIndex = 7;
            // 
            // textBox_age
            // 
            textBox_age.BackColor = Color.FloralWhite;
            textBox_age.BorderStyle = BorderStyle.None;
            textBox_age.Dock = DockStyle.Top;
            textBox_age.Location = new Point(0, 0);
            textBox_age.Name = "textBox_age";
            textBox_age.Size = new Size(428, 46);
            textBox_age.TabIndex = 5;
            // 
            // button_save
            // 
            button_save.BackColor = Color.MediumPurple;
            button_save.BorderRadius = 20;
            button_save.FlatAppearance.BorderSize = 0;
            button_save.FlatStyle = FlatStyle.Flat;
            button_save.ForeColor = Color.White;
            button_save.Location = new Point(75, 250);
            button_save.Name = "button_save";
            button_save.Size = new Size(200, 60);
            button_save.TabIndex = 8;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = false;
            button_save.Click += button_save_Click;
            // 
            // button_showAll
            // 
            button_showAll.BackColor = Color.MediumPurple;
            button_showAll.BorderRadius = 20;
            button_showAll.FlatAppearance.BorderSize = 0;
            button_showAll.FlatStyle = FlatStyle.Flat;
            button_showAll.ForeColor = Color.White;
            button_showAll.Location = new Point(325, 250);
            button_showAll.Name = "button_showAll";
            button_showAll.Size = new Size(200, 60);
            button_showAll.TabIndex = 9;
            button_showAll.Text = "Show All";
            button_showAll.UseVisualStyleBackColor = false;
            button_showAll.Click += button_showAll_Click;
            // 
            // boundButton_search
            // 
            boundButton_search.BackColor = Color.MediumPurple;
            boundButton_search.BorderRadius = 20;
            boundButton_search.FlatAppearance.BorderSize = 0;
            boundButton_search.FlatStyle = FlatStyle.Flat;
            boundButton_search.ForeColor = Color.White;
            boundButton_search.Location = new Point(14, 628);
            boundButton_search.Name = "boundButton_search";
            boundButton_search.Size = new Size(140, 60);
            boundButton_search.TabIndex = 10;
            boundButton_search.Text = "Search";
            boundButton_search.UseVisualStyleBackColor = false;
            boundButton_search.Click += boundButton_search_Click;
            // 
            // panel_search
            // 
            panel_search.BackColor = Color.MediumPurple;
            panel_search.Controls.Add(textBox_search);
            panel_search.Location = new Point(160, 631);
            panel_search.Name = "panel_search";
            panel_search.Size = new Size(428, 51);
            panel_search.TabIndex = 11;
            // 
            // textBox_search
            // 
            textBox_search.BackColor = Color.FloralWhite;
            textBox_search.BorderStyle = BorderStyle.None;
            textBox_search.Dock = DockStyle.Top;
            textBox_search.Location = new Point(0, 0);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(428, 46);
            textBox_search.TabIndex = 5;
            // 
            // listView
            // 
            listView.BackColor = Color.FloralWhite;
            listView.BorderStyle = BorderStyle.None;
            listView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView.Location = new Point(14, 350);
            listView.Name = "listView";
            listView.Size = new Size(574, 272);
            listView.TabIndex = 6;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 280;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Age";
            columnHeader2.Width = 280;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(18F, 52F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(600, 700);
            Controls.Add(listView);
            Controls.Add(panel_search);
            Controls.Add(boundButton_search);
            Controls.Add(button_showAll);
            Controls.Add(button_save);
            Controls.Add(panel_age);
            Controls.Add(panel_name);
            Controls.Add(label_age);
            Controls.Add(label_name);
            Controls.Add(ChromPanel);
            Font = new Font("Sitka Banner", 18F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ChromPanel.ResumeLayout(false);
            panel_name.ResumeLayout(false);
            panel_name.PerformLayout();
            panel_age.ResumeLayout(false);
            panel_age.PerformLayout();
            panel_search.ResumeLayout(false);
            panel_search.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel ChromPanel;
        private MyRoundButton ChromClose;
        private MyRoundButton ChromMinimize;
        private Label label_name;
        private Label label_age;
        private TextBox textBox_name;
        private Panel panel_name;
        private Panel panel_age;
        private TextBox textBox_age;
        private MyRoundButton button_save;
        private MyRoundButton button_showAll;
        private MyRoundButton boundButton_search;
        private Panel panel_search;
        private TextBox textBox_search;
        private ListView listView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}