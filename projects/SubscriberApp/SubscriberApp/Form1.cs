using System;
using System.Security.Policy;
using System.Windows.Forms;
using NetMQ;
using NetMQ.Sockets;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace SubscriberApp
{
    public partial class Form1 : Form
    {
        private SubscriberSocket subscriber;
        private System.Windows.Forms.Timer timer;
        public string name;
        private string lastProcessedTasks = "";
        public string publisherIP;

        public Form1()
        {
            InitializeComponent();
            subscriber = new SubscriberSocket();
            subscriber.Connect($"tcp://{publisherIP}:12345");

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            pictureBox1.Image = imagelist1.Images[0];
            label1.Text = "Welcome " + name;

            subscriber.Subscribe(name);
            subscriber.Subscribe("All");

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (subscriber.TryReceiveFrameString(out string message))
            {
                listBox1.Items.Add(message);
                richTextBox1.Text = message;
                findpic(message);
                ParseTasksAndCreateCheckboxes(message);
            }
        }

        private void ParseTasksAndCreateCheckboxes(string message)
        {
            if (message.Contains("Tasks:"))
            {
                int tasksStartIndex = message.IndexOf("Tasks:") + "Tasks:".Length;
                string tasksString = message.Substring(tasksStartIndex).Trim();

                if (tasksString == lastProcessedTasks)
                {
                    return;
                }

                lastProcessedTasks = tasksString;
                string[] tasks = tasksString.Split(';');

                UpdateProgress();

                foreach (string task in tasks)
                {
                    if (!string.IsNullOrWhiteSpace(task))
                    {
                        checkedListBox1.Items.Add(task.Trim());
                    }
                }
            }
        }


        private void findpic(string message)
        {
            if (message.Contains("açýk"))
            {
                pictureBox1.Image = imagelist1.Images[0];
            }
            else if (message.Contains("kapalý"))
            {
                pictureBox1.Image = imagelist1.Images[1];
            }
            else if (message.Contains("sisli"))
            {
                pictureBox1.Image = imagelist1.Images[2];
            }
            else if (message.Contains("hafif yaðmur"))
            {
                pictureBox1.Image = imagelist1.Images[3];
            }
            else if (message.Contains("parçalý bulutlu") || message.Contains("parçalý az bulutlu") || message.Contains("az bulutlu"))
            {
                pictureBox1.Image = imagelist1.Images[4];
            }
            else if (message.Contains("karlý"))
            {
                pictureBox1.Image = imagelist1.Images[5];
            }
        }
        private void UpdateProgress()
        {
            int total = checkedListBox1.Items.Count;
            int completed = 0;

            for (int i = 0; i < total; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    completed++;
                }
            }

            if (total > 0)
            {
                int percentage = (completed * 100) / total;
                progressBar1.Value = percentage;
            }
            else
            {
                progressBar1.Value = 0;
            }
        }


        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            subscriber?.Dispose();
            Application.Exit();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)(() => UpdateProgress()));
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Visible = checkBox1.Checked;
        }

       
    }
}
