namespace SimulationUI
{
    partial class Form1
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
            this.wavelengthTextBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.powerTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sourceXTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sourceYTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sourceZTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.detectorZTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.detectorYTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.detectorXTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.radiusTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wavelengthTextBox
            // 
            this.wavelengthTextBox.Location = new System.Drawing.Point(127, 23);
            this.wavelengthTextBox.Name = "wavelengthTextBox";
            this.wavelengthTextBox.Size = new System.Drawing.Size(56, 22);
            this.wavelengthTextBox.TabIndex = 0;
            this.wavelengthTextBox.Text = "780";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Location = new System.Drawing.Point(12, 209);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(758, 153);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "";
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 25;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Simulation";
            this.columnHeader2.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Simulations";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wavelengh (nm)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Source";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Power (mW)";
            // 
            // powerTextBox
            // 
            this.powerTextBox.Location = new System.Drawing.Point(280, 23);
            this.powerTextBox.Name = "powerTextBox";
            this.powerTextBox.Size = new System.Drawing.Size(56, 22);
            this.powerTextBox.TabIndex = 6;
            this.powerTextBox.Text = "150";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "X";
            // 
            // sourceXTextBox
            // 
            this.sourceXTextBox.Location = new System.Drawing.Point(365, 23);
            this.sourceXTextBox.Name = "sourceXTextBox";
            this.sourceXTextBox.Size = new System.Drawing.Size(56, 22);
            this.sourceXTextBox.TabIndex = 8;
            this.sourceXTextBox.Text = "75.7604835020458 ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Y";
            // 
            // sourceYTextBox
            // 
            this.sourceYTextBox.Location = new System.Drawing.Point(450, 23);
            this.sourceYTextBox.Name = "sourceYTextBox";
            this.sourceYTextBox.Size = new System.Drawing.Size(56, 22);
            this.sourceYTextBox.TabIndex = 10;
            this.sourceYTextBox.Text = "66.9948002207114";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(512, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Z";
            // 
            // sourceZTextBox
            // 
            this.sourceZTextBox.Location = new System.Drawing.Point(535, 23);
            this.sourceZTextBox.Name = "sourceZTextBox";
            this.sourceZTextBox.Size = new System.Drawing.Size(56, 22);
            this.sourceZTextBox.TabIndex = 12;
            this.sourceZTextBox.Text = "168.218489512914";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(512, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Z";
            // 
            // detectorZTextBox
            // 
            this.detectorZTextBox.Location = new System.Drawing.Point(535, 57);
            this.detectorZTextBox.Name = "detectorZTextBox";
            this.detectorZTextBox.Size = new System.Drawing.Size(56, 22);
            this.detectorZTextBox.TabIndex = 23;
            this.detectorZTextBox.Text = "170.9";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(427, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Y";
            // 
            // detectorYTextBox
            // 
            this.detectorYTextBox.Location = new System.Drawing.Point(450, 57);
            this.detectorYTextBox.Name = "detectorYTextBox";
            this.detectorYTextBox.Size = new System.Drawing.Size(56, 22);
            this.detectorYTextBox.TabIndex = 21;
            this.detectorYTextBox.Text = "79.89";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(342, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "X";
            // 
            // detectorXTextBox
            // 
            this.detectorXTextBox.Location = new System.Drawing.Point(365, 57);
            this.detectorXTextBox.Name = "detectorXTextBox";
            this.detectorXTextBox.Size = new System.Drawing.Size(56, 22);
            this.detectorXTextBox.TabIndex = 19;
            this.detectorXTextBox.Text = "175.34";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "Detector";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "Radius (mm)";
            // 
            // radiusTextBox
            // 
            this.radiusTextBox.Location = new System.Drawing.Point(103, 57);
            this.radiusTextBox.Name = "radiusTextBox";
            this.radiusTextBox.Size = new System.Drawing.Size(56, 22);
            this.radiusTextBox.TabIndex = 14;
            this.radiusTextBox.Text = "2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Time Span (s)";
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(112, 85);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(56, 22);
            this.timeTextBox.TabIndex = 26;
            this.timeTextBox.Text = "3.e-09";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Run All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.detectorZTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.detectorYTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.detectorXTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.radiusTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sourceZTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sourceYTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sourceXTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.powerTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wavelengthTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wavelengthTextBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox powerTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sourceXTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sourceYTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sourceZTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox detectorZTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox detectorYTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox detectorXTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox radiusTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.Button button2;
    }
}

