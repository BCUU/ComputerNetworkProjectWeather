namespace ComputerNetworkProject
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
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(57, 31);
            label1.Name = "label1";
            label1.Size = new Size(97, 36);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(57, 93);
            label2.Name = "label2";
            label2.Size = new Size(97, 36);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(17, 275);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Location = new Point(283, 304);
            button1.Name = "button1";
            button1.Size = new Size(94, 36);
            button1.TabIndex = 3;
            button1.Text = "Gonder";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonSendEmail_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(283, 275);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 23);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(14, 239);
            label3.Name = "label3";
            label3.Size = new Size(140, 33);
            label3.TabIndex = 5;
            label3.Text = "Sehir secin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(272, 239);
            label4.Name = "label4";
            label4.Size = new Size(245, 33);
            label4.TabIndex = 6;
            label4.Text = "Mail adresinizi girin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 151);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 7;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 184);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 8;
            label6.Text = "label6";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(584, 345);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
