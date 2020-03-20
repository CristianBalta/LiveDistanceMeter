namespace H1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.baudRate = new System.Windows.Forms.ComboBox();
            this.portName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(76, 343);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(349, 355);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distance in mm to object:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(708, 111);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(183, 42);
            this.progressBar1.TabIndex = 14;
            // 
            // baudRate
            // 
            this.baudRate.FormattingEnabled = true;
            this.baudRate.Items.AddRange(new object[] {
            "300",
            "9600",
            "115200"});
            this.baudRate.Location = new System.Drawing.Point(404, 233);
            this.baudRate.Margin = new System.Windows.Forms.Padding(6);
            this.baudRate.Name = "baudRate";
            this.baudRate.Size = new System.Drawing.Size(219, 32);
            this.baudRate.TabIndex = 13;
            // 
            // portName
            // 
            this.portName.FormattingEnabled = true;
            this.portName.Location = new System.Drawing.Point(76, 233);
            this.portName.Margin = new System.Windows.Forms.Padding(6);
            this.portName.Name = "portName";
            this.portName.Size = new System.Drawing.Size(219, 32);
            this.portName.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(768, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Port Name";
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(76, 111);
            this.close.Margin = new System.Windows.Forms.Padding(6);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(138, 42);
            this.close.TabIndex = 17;
            this.close.Text = "Close Port";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click_1);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(76, 33);
            this.open.Margin = new System.Windows.Forms.Padding(6);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(138, 42);
            this.open.TabIndex = 16;
            this.open.Text = "Open Port";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(18, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(308, 292);
            this.listBox1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::H1.Properties.Resources.arduino;
            this.pictureBox1.Location = new System.Drawing.Point(486, 343);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(415, 339);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Exit.Location = new System.Drawing.Point(723, 193);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(144, 72);
            this.Exit.TabIndex = 20;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 713);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.baudRate);
            this.Controls.Add(this.portName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.open);
            this.Name = "Form1";
            this.Text = "Live Distance Meter";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox baudRate;
        private System.Windows.Forms.ComboBox portName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button open;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Exit;
    }
}

