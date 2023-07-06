namespace NotifyLights
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            notifyIcon1 = new NotifyIcon(components);
            mqttAddressTextBox = new TextBox();
            mqttPortNumericUpDown = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            coldWhiteTopicTextBox = new TextBox();
            label4 = new Label();
            warmWhiteTopicTextBox = new TextBox();
            saveButton = new Button();
            panel1 = new Panel();
            checkBox1 = new CheckBox();
            panel2 = new Panel();
            warmWhiteTrackBar = new TrackBar();
            coldWhiteTrackBar = new TrackBar();
            warmWhitePercentLabel = new Label();
            coldWhitePercentLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)mqttPortNumericUpDown).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)warmWhiteTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coldWhiteTrackBar).BeginInit();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // mqttAddressTextBox
            // 
            mqttAddressTextBox.Enabled = false;
            mqttAddressTextBox.Location = new Point(3, 24);
            mqttAddressTextBox.Name = "mqttAddressTextBox";
            mqttAddressTextBox.Size = new Size(197, 23);
            mqttAddressTextBox.TabIndex = 0;
            // 
            // mqttPortNumericUpDown
            // 
            mqttPortNumericUpDown.Enabled = false;
            mqttPortNumericUpDown.Location = new Point(50, 56);
            mqttPortNumericUpDown.Maximum = new decimal(new int[] { 655555, 0, 0, 0 });
            mqttPortNumericUpDown.Name = "mqttPortNumericUpDown";
            mqttPortNumericUpDown.Size = new Size(150, 23);
            mqttPortNumericUpDown.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 53);
            label1.Name = "label1";
            label1.Size = new Size(41, 21);
            label1.TabIndex = 2;
            label1.Text = "Port:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 21);
            label2.TabIndex = 3;
            label2.Text = "MQTT ADDRESS:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 82);
            label3.Name = "label3";
            label3.Size = new Size(150, 21);
            label3.TabIndex = 5;
            label3.Text = "COLD WHITE TOPIC:";
            // 
            // coldWhiteTopicTextBox
            // 
            coldWhiteTopicTextBox.Enabled = false;
            coldWhiteTopicTextBox.Location = new Point(3, 106);
            coldWhiteTopicTextBox.Name = "coldWhiteTopicTextBox";
            coldWhiteTopicTextBox.Size = new Size(197, 23);
            coldWhiteTopicTextBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 132);
            label4.Name = "label4";
            label4.Size = new Size(157, 21);
            label4.TabIndex = 7;
            label4.Text = "WARM WHITE TOPIC:";
            // 
            // warmWhiteTopicTextBox
            // 
            warmWhiteTopicTextBox.Enabled = false;
            warmWhiteTopicTextBox.Location = new Point(3, 156);
            warmWhiteTopicTextBox.Name = "warmWhiteTopicTextBox";
            warmWhiteTopicTextBox.Size = new Size(197, 23);
            warmWhiteTopicTextBox.TabIndex = 6;
            // 
            // saveButton
            // 
            saveButton.Enabled = false;
            saveButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.Location = new Point(3, 185);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(197, 37);
            saveButton.TabIndex = 8;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(mqttAddressTextBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(mqttPortNumericUpDown);
            panel1.Controls.Add(warmWhiteTopicTextBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(coldWhiteTopicTextBox);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 239);
            panel1.TabIndex = 0;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(15, 240);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(68, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Editable";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(warmWhiteTrackBar);
            panel2.Controls.Add(coldWhiteTrackBar);
            panel2.Controls.Add(warmWhitePercentLabel);
            panel2.Controls.Add(coldWhitePercentLabel);
            panel2.Location = new Point(231, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(396, 239);
            panel2.TabIndex = 1;
            // 
            // warmWhiteTrackBar
            // 
            warmWhiteTrackBar.Location = new Point(3, 97);
            warmWhiteTrackBar.Maximum = 100;
            warmWhiteTrackBar.Name = "warmWhiteTrackBar";
            warmWhiteTrackBar.Size = new Size(390, 45);
            warmWhiteTrackBar.TabIndex = 6;
            warmWhiteTrackBar.Value = 100;
            warmWhiteTrackBar.MouseCaptureChanged += warmWhiteTrackBar_Scroll;
            // 
            // coldWhiteTrackBar
            // 
            coldWhiteTrackBar.BackColor = SystemColors.Control;
            coldWhiteTrackBar.Location = new Point(3, 24);
            coldWhiteTrackBar.Maximum = 100;
            coldWhiteTrackBar.Name = "coldWhiteTrackBar";
            coldWhiteTrackBar.Size = new Size(390, 45);
            coldWhiteTrackBar.TabIndex = 5;
            coldWhiteTrackBar.MouseCaptureChanged += coldWhiteTrackBar_Scroll;
            // 
            // warmWhitePercentLabel
            // 
            warmWhitePercentLabel.AutoSize = true;
            warmWhitePercentLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            warmWhitePercentLabel.Location = new Point(3, 72);
            warmWhitePercentLabel.Name = "warmWhitePercentLabel";
            warmWhitePercentLabel.Size = new Size(155, 21);
            warmWhitePercentLabel.TabIndex = 4;
            warmWhitePercentLabel.Text = "WARM WHITE: 100%";
            // 
            // coldWhitePercentLabel
            // 
            coldWhitePercentLabel.AutoSize = true;
            coldWhitePercentLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            coldWhitePercentLabel.Location = new Point(3, 0);
            coldWhitePercentLabel.Name = "coldWhitePercentLabel";
            coldWhitePercentLabel.Size = new Size(130, 21);
            coldWhitePercentLabel.TabIndex = 3;
            coldWhitePercentLabel.Text = "COLD WHITE: 0%";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 273);
            Controls.Add(checkBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Side Lights Settings";
            FormClosing += Form1_FormClosing;
            Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)mqttPortNumericUpDown).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)warmWhiteTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)coldWhiteTrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NotifyIcon notifyIcon1;
        private TextBox mqttAddressTextBox;
        private NumericUpDown mqttPortNumericUpDown;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox coldWhiteTopicTextBox;
        private Label label4;
        private TextBox warmWhiteTopicTextBox;
        private Button saveButton;
        private Panel panel1;
        private Panel panel2;
        private TrackBar warmWhiteTrackBar;
        private TrackBar coldWhiteTrackBar;
        private Label warmWhitePercentLabel;
        private Label coldWhitePercentLabel;
        private CheckBox checkBox1;
    }
}