

using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NotifyLights
{

    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        ContextMenuStrip notifyIconContextMenu;
        public Form1()
        {
            InitializeComponent();
            //AllocConsole();
            mqttAddressTextBox.Text = Properties.Settings.Default["mqttHost"].ToString();
            int port = Int32.Parse(Properties.Settings.Default["mqttPort"].ToString());
            Console.WriteLine(port);
            mqttPortNumericUpDown.Value = port;
            coldWhiteTopicTextBox.Text = Properties.Settings.Default["mqttColdWhiteTopic"].ToString();
            warmWhiteTopicTextBox.Text = Properties.Settings.Default["mqttWarmWhiteTopic"].ToString();
            
            notifyIconContextMenu = new ContextMenuStrip();

            notifyIconContextMenu.Items.Add("Wawrow 2023");
            notifyIconContextMenu.Items.Add("WWB 100%");
            notifyIconContextMenu.Items.Add("WWB 50%");
            notifyIconContextMenu.Items.Add("WWB 25%");
            notifyIconContextMenu.Items.Add("Exit");

            notifyIconContextMenu.Items[0].Click += new System.EventHandler(notifyIconContextMenu_Wawrow_Click);
            notifyIconContextMenu.Items[1].Click += new System.EventHandler(notifyIconContextMenu_SendValueWW100_Click);
            notifyIconContextMenu.Items[2].Click += new System.EventHandler(notifyIconContextMenu_SendValueWW50_Click);
            notifyIconContextMenu.Items[3].Click += new System.EventHandler(notifyIconContextMenu_SendValueWW25_Click);
            notifyIconContextMenu.Items[4].Click += new System.EventHandler(notifyIconContextMenu_ExitItem_Click);
            
            notifyIcon1.ContextMenuStrip = notifyIconContextMenu;
            notifyIcon1.Visible = true;
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;

        }

        private void notifyIconContextMenu_Wawrow_Click(object? sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        }

        private void notifyIconContextMenu_SendValueWW25_Click(object? sender, EventArgs e)
        {
            _ = MQTTClient.Publish_Application_Message(mqttAddressTextBox.Text, Int32.Parse(mqttPortNumericUpDown.Value.ToString()),
                     warmWhiteTopicTextBox.Text, 20.ToString());
        }

        private void notifyIconContextMenu_SendValueWW50_Click(object? sender, EventArgs e)
        {
            _ = MQTTClient.Publish_Application_Message(mqttAddressTextBox.Text, Int32.Parse(mqttPortNumericUpDown.Value.ToString()),
                     warmWhiteTopicTextBox.Text, 90.ToString());
        }

        private void notifyIconContextMenu_SendValueWW100_Click(object? sender, EventArgs e)
        {
            _ = MQTTClient.Publish_Application_Message(mqttAddressTextBox.Text, Int32.Parse(mqttPortNumericUpDown.Value.ToString()),
                     warmWhiteTopicTextBox.Text, 255.ToString());
        }

        private void notifyIconContextMenu_ExitItem_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }
        private void coldWhiteTrackBar_Scroll(object sender, EventArgs e)
        {
            coldWhitePercentLabel.Text = "COLD WHITE: " + coldWhiteTrackBar.Value.ToString() + "%";
            _ = MQTTClient.Publish_Application_Message(mqttAddressTextBox.Text, Int32.Parse(mqttPortNumericUpDown.Value.ToString()),
                coldWhiteTopicTextBox.Text, coldWhiteTrackBar.Value.ToString());
        }
        private void warmWhiteTrackBar_Scroll(object sender, EventArgs e)
        {
            warmWhitePercentLabel.Text = "WARM WHITE: " + warmWhiteTrackBar.Value.ToString() + "%";
            _ = MQTTClient.Publish_Application_Message(mqttAddressTextBox.Text, Int32.Parse(mqttPortNumericUpDown.Value.ToString()),
                warmWhiteTopicTextBox.Text, warmWhiteTrackBar.Value.ToString());
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["mqttHost"] = mqttAddressTextBox.Text;
            Properties.Settings.Default["mqttPort"] = mqttPortNumericUpDown.Value;
            Properties.Settings.Default["mqttColdWhiteTopic"] = coldWhiteTopicTextBox.Text;
            Properties.Settings.Default["mqttWarmWhiteTopic"] = warmWhiteTopicTextBox.Text;
            Properties.Settings.Default.Save();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                mqttAddressTextBox.Enabled = true;
                mqttPortNumericUpDown.Enabled = true;
                coldWhiteTopicTextBox.Enabled = true;
                warmWhiteTopicTextBox.Enabled = true;
            }
            else
            {
                mqttAddressTextBox.Enabled = false;
                mqttPortNumericUpDown.Enabled = false;
                coldWhiteTopicTextBox.Enabled = false;
                warmWhiteTopicTextBox.Enabled = false;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                this.ShowInTaskbar = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        }
    }
}