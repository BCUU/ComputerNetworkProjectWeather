namespace SubscriberApp
{
    partial class Form1
    {
        /// <summary>
        ///  Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        /// <param name="disposing">yönetilen kaynaklar dispose edilmeliyse true; aksi halde false.</param>
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
        ///  Gerekli metot tasarımcı desteği için.
        ///  Bu metodun içeriği kod düzenleyici ile değiştirilmemelidir.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            imagelist1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            checkedListBox1 = new CheckedListBox();
            progressBar1 = new ProgressBar();
            monthCalendar1 = new MonthCalendar();
            label2 = new Label();
            listBox1 = new ListBox();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // imagelist1
            // 
            imagelist1.ColorDepth = ColorDepth.Depth32Bit;
            imagelist1.ImageStream = (ImageListStreamer)resources.GetObject("imagelist1.ImageStream");
            imagelist1.TransparentColor = Color.Transparent;
            imagelist1.Images.SetKeyName(0, "sunny_3982116.png");
            imagelist1.Images.SetKeyName(1, "cloudy_2042088.png");
            imagelist1.Images.SetKeyName(2, "foggy_2076827.png");
            imagelist1.Images.SetKeyName(3, "raining_7687017.png");
            imagelist1.Images.SetKeyName(4, "cloudy_7686960.png");
            imagelist1.Images.SetKeyName(5, "snow_7687020.png");
            imagelist1.Images.SetKeyName(6, "weather-news_648198.png");
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1037, 15);
            pictureBox1.Margin = new Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.DarkCyan;
            groupBox1.Location = new Point(905, 433);
            groupBox1.Margin = new Padding(6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6);
            groupBox1.Size = new Size(338, 209);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Tag = "groupbox1";
            groupBox1.Text = "weather";
            groupBox1.Visible = false;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.DarkCyan;
            richTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            richTextBox1.ForeColor = Color.LightCyan;
            richTextBox1.Location = new Point(12, 63);
            richTextBox1.Margin = new Padding(6);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(337, 134);
            richTextBox1.TabIndex = 4;
            richTextBox1.Tag = "richtextbox1";
            richTextBox1.Text = "dasdasdasdasdasdsadasdasdasdasdas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(22, 26);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(537, 86);
            label1.TabIndex = 5;
            label1.Text = "Welcome Ahmet";
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.DarkCyan;
            checkedListBox1.ForeColor = Color.Azure;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(22, 257);
            checkedListBox1.Margin = new Padding(6);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(654, 256);
            checkedListBox1.TabIndex = 7;
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.LightCyan;
            progressBar1.ForeColor = Color.DarkCyan;
            progressBar1.Location = new Point(22, 548);
            progressBar1.Margin = new Padding(6);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(657, 21);
            progressBar1.TabIndex = 8;
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = Color.DarkCyan;
            monthCalendar1.Location = new Point(870, 120);
            monthCalendar1.Margin = new Padding(17, 19, 17, 19);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(22, 192);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(239, 59);
            label2.TabIndex = 10;
            label2.Text = "Your Taks :";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(16, 649);
            listBox1.Margin = new Padding(6, 4, 6, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1239, 100);
            listBox1.TabIndex = 0;
            listBox1.Visible = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(20, 603);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(160, 36);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Show Data";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1300, 753);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(monthCalendar1);
            Controls.Add(progressBar1);
            Controls.Add(checkedListBox1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 4, 6, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Subscriber App";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ImageList imagelist1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private RichTextBox richTextBox1;
        private Label label1;
        private CheckedListBox checkedListBox1;
        private ProgressBar progressBar1;
        private MonthCalendar monthCalendar1;
        private Label label2;
        private ListBox listBox1;
        private CheckBox checkBox1;
    }
}
