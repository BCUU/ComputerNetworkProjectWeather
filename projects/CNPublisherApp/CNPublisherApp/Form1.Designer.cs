using NetMQ.Sockets;
using System.Net.Sockets;
using System.Net;
using System.Xml.Linq;
using System;

namespace CNPublisherApp
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
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            buttonSend = new Button();
            textBox2 = new TextBox();
            comboBox2 = new ComboBox();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            History = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.LightCyan;
            label1.Location = new Point(57, 31);
            label1.Name = "label1";
            label1.Size = new Size(196, 73);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.LightCyan;
            label2.Location = new Point(57, 93);
            label2.Name = "label2";
            label2.Size = new Size(196, 73);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(331, 343);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(424, 40);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.LightCyan;
            label3.Location = new Point(12, 319);
            label3.Name = "label3";
            label3.Size = new Size(313, 67);
            label3.TabIndex = 5;
            label3.Text = "Select City :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.LightCyan;
            label5.Location = new Point(72, 166);
            label5.Name = "label5";
            label5.Size = new Size(78, 32);
            label5.TabIndex = 7;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.LightCyan;
            label6.Location = new Point(72, 209);
            label6.Name = "label6";
            label6.Size = new Size(78, 32);
            label6.TabIndex = 8;
            label6.Text = "label6";
            // 
            // buttonSend
            // 
            buttonSend.BackColor = Color.LightCyan;
            buttonSend.Font = new Font("Segoe UI Symbol", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSend.ForeColor = Color.DarkCyan;
            buttonSend.Location = new Point(610, 447);
            buttonSend.Margin = new Padding(2, 1, 2, 1);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(145, 71);
            buttonSend.TabIndex = 9;
            buttonSend.Tag = "buttonSend";
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = false;
            buttonSend.Click += buttonSend_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(331, 404);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(424, 39);
            textBox2.TabIndex = 10;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(331, 623);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(424, 40);
            comboBox2.TabIndex = 11;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(331, 669);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(424, 171);
            richTextBox1.TabIndex = 13;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.BackColor = Color.LightCyan;
            button2.Font = new Font("Segoe UI Symbol", 13.875F, FontStyle.Bold);
            button2.ForeColor = Color.DarkCyan;
            button2.Location = new Point(626, 846);
            button2.Name = "button2";
            button2.Size = new Size(129, 67);
            button2.TabIndex = 14;
            button2.Text = "Send";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.LightCyan;
            label4.Location = new Point(57, 386);
            label4.Name = "label4";
            label4.Size = new Size(263, 67);
            label4.TabIndex = 15;
            label4.Text = "Message :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.LightCyan;
            label7.Location = new Point(72, 599);
            label7.Name = "label7";
            label7.Size = new Size(248, 67);
            label7.TabIndex = 16;
            label7.Text = "Send To :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.LightCyan;
            label8.Location = new Point(152, 669);
            label8.Name = "label8";
            label8.Size = new Size(168, 67);
            label8.TabIndex = 17;
            label8.Text = "Task :";
            // 
            // History
            // 
            History.BackColor = Color.DarkCyan;
            History.Font = new Font("Segoe UI Symbol", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            History.ForeColor = Color.LightCyan;
            History.FormattingEnabled = true;
            History.ItemHeight = 40;
            History.Location = new Point(837, 31);
            History.Name = "History";
            History.RightToLeft = RightToLeft.No;
            History.Size = new Size(435, 804);
            History.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(1300, 940);
            Controls.Add(History);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(richTextBox1);
            Controls.Add(comboBox2);
            Controls.Add(textBox2);
            Controls.Add(buttonSend);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Publisher App";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label5;
        private Label label6;
        private Button buttonSend;
        private TextBox textBox2;
        private ComboBox comboBox2;
        private RichTextBox richTextBox1;
        private Button button2;
        private Label label4;
        private Label label7;
        private Label label8;
        private ListBox History;
    }
}
