namespace PCShutdown {
    partial class TimerForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerForm));
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer_RunCommand = new System.Windows.Forms.Timer(this.components);
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox_commandSettings = new System.Windows.Forms.GroupBox();
            this.groupBox_timeSettings = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_StartTimer = new System.Windows.Forms.Button();
            this.button_StopTimer = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox_commandSettings.SuspendLayout();
            this.groupBox_timeSettings.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown2.Location = new System.Drawing.Point(77, 40);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(45, 26);
            this.numericUpDown2.TabIndex = 2;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown1.Location = new System.Drawing.Point(8, 40);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(45, 26);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "HH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "MM";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // timer_RunCommand
            // 
            this.timer_RunCommand.Interval = 1000;
            this.timer_RunCommand.Tick += new System.EventHandler(this.timer_RunCommand_Tick);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(101, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Force shutdown";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton_SetCommand_CheckedChanged_1);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.Text = "Shutdown";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton_SetCommand_CheckedChanged_1);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(58, 17);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.Text = "Log off";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton_SetCommand_CheckedChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox_commandSettings.Controls.Add(this.radioButton1);
            this.groupBox_commandSettings.Controls.Add(this.radioButton3);
            this.groupBox_commandSettings.Controls.Add(this.radioButton2);
            this.groupBox_commandSettings.Location = new System.Drawing.Point(12, 12);
            this.groupBox_commandSettings.Name = "groupBox1";
            this.groupBox_commandSettings.Size = new System.Drawing.Size(124, 92);
            this.groupBox_commandSettings.TabIndex = 12;
            this.groupBox_commandSettings.TabStop = false;
            this.groupBox_commandSettings.Text = "What to do";
            // 
            // groupBox2
            // 
            this.groupBox_timeSettings.Controls.Add(this.label3);
            this.groupBox_timeSettings.Controls.Add(this.label1);
            this.groupBox_timeSettings.Controls.Add(this.numericUpDown2);
            this.groupBox_timeSettings.Controls.Add(this.numericUpDown1);
            this.groupBox_timeSettings.Controls.Add(this.label2);
            this.groupBox_timeSettings.Location = new System.Drawing.Point(142, 13);
            this.groupBox_timeSettings.Name = "groupBox2";
            this.groupBox_timeSettings.Size = new System.Drawing.Size(131, 91);
            this.groupBox_timeSettings.TabIndex = 13;
            this.groupBox_timeSettings.TabStop = false;
            this.groupBox_timeSettings.Text = "Set time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = ":";
            // 
            // button_StartTimer
            // 
            this.button_StartTimer.Image = ((System.Drawing.Image)(resources.GetObject("button_StartTimer.Image")));
            this.button_StartTimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_StartTimer.Location = new System.Drawing.Point(12, 110);
            this.button_StartTimer.Name = "button_StartTimer";
            this.button_StartTimer.Size = new System.Drawing.Size(93, 42);
            this.button_StartTimer.TabIndex = 14;
            this.button_StartTimer.Text = "Start timer";
            this.button_StartTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_StartTimer.UseVisualStyleBackColor = true;
            this.button_StartTimer.Click += new System.EventHandler(this.button_StartTimer_Click);
            // 
            // button_StopTimer
            // 
            this.button_StopTimer.Image = ((System.Drawing.Image)(resources.GetObject("button_StopTimer.Image")));
            this.button_StopTimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_StopTimer.Location = new System.Drawing.Point(111, 110);
            this.button_StopTimer.Name = "button_StopTimer";
            this.button_StopTimer.Size = new System.Drawing.Size(93, 42);
            this.button_StopTimer.TabIndex = 15;
            this.button_StopTimer.Text = "Stop timer";
            this.button_StopTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_StopTimer.UseVisualStyleBackColor = true;
            this.button_StopTimer.Click += new System.EventHandler(this.button_StopTimer_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 26);
            this.contextMenuStrip1.MouseLeave += new System.EventHandler(this.contextMenuStrip1_MouseLeave);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.toolStripMenuItem1.Text = "Exit Application";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 166);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(281, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 188);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox_timeSettings);
            this.Controls.Add(this.groupBox_commandSettings);
            this.Controls.Add(this.button_StartTimer);
            this.Controls.Add(this.button_StopTimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TimerForm";
            this.Text = "Command Planner";
            this.Load += new System.EventHandler(this.TimerForm_Load);
            this.Resize += new System.EventHandler(this.TimerForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox_commandSettings.ResumeLayout(false);
            this.groupBox_commandSettings.PerformLayout();
            this.groupBox_timeSettings.ResumeLayout(false);
            this.groupBox_timeSettings.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer_RunCommand;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox_commandSettings;
        private System.Windows.Forms.GroupBox groupBox_timeSettings;
        private System.Windows.Forms.Button button_StartTimer;
        private System.Windows.Forms.Button button_StopTimer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

    }
}

