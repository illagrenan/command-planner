using System;
using System.Diagnostics;
using System.Windows.Forms;
using CommandPlanner.Properties;
using CommandPlanner.exceptions;

namespace PCShutdown
{
    public partial class TimerForm : Form
    {
        DateTime timerStartTime;
        int secondsBeforeRunningCommand;
        string commandToExecute;
        bool tooltipAfterMinimization = false;

        public TimerForm()
        {
            InitializeComponent();
        }

        private void TimerForm_Load(object sender, EventArgs e)
        {
            button_StopTimer.Enabled = false;
            SetDefaultValues();
        }

        private void SetDefaultValues()
        {
            commandToExecute = "/s /f";
            secondsBeforeRunningCommand = 0;
        }

        private void SwitchUIBetweenOnAndOff()
        {
            button_StartTimer.Enabled = !button_StartTimer.Enabled;
            button_StopTimer.Enabled = !button_StopTimer.Enabled;

            ReverseControlsEnabled(groupBox_commandSettings.Controls);
            ReverseControlsEnabled(groupBox_timeSettings.Controls);
        }

        private void ReverseControlsEnabled(Control.ControlCollection controlCollection)
        {
            foreach (Control oneControl in controlCollection)
            {
                oneControl.Enabled = !oneControl.Enabled;
            }
        }

        private void button_StartTimer_Click(object sender, EventArgs e)
        {
            secondsBeforeRunningCommand = ((int)numericUpDown1.Value * 60 * 60) + ((int)numericUpDown2.Value * 60);

            if (secondsBeforeRunningCommand > Settings.Default.MAXIMUM_ALLOWED_TIME_TO_PLAN_COMMAND)
            {
                MessageBox.Show(
                    "Your chosen time is too large.",
                    "Maximum time exceeded",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (secondsBeforeRunningCommand == 0)
            {

                DialogResult executeCommandImmediately = MessageBox.Show(
                    "Execute the command immediately",
                    "Execute the command immediately?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (DialogResult.No == executeCommandImmediately)
                {
                    return;
                }

            }

            SwitchUIBetweenOnAndOff();
            timer_RunCommand.Start();
            timerStartTime = DateTime.Now;
        }

        /// <summary>
        /// Minimize to Tray
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerForm_Resize(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
            {
                return;
            }

            minimizeFormToTray();

            if (!tooltipAfterMinimization)
            {
                showBallon("Command Planner", "Running in tray");
                tooltipAfterMinimization = true;
            }

        }

        /// <summary>
        /// Show ballon tooltip (from Tray)
        /// </summary>
        /// <param name="title"></param>
        /// <param name="text"></param>
        /// <param name="icon"></param>
        private void showBallon(string title, string text)
        {
            notifyIcon1.BalloonTipTitle = title;
            notifyIcon1.BalloonTipText = text;
            notifyIcon1.ShowBalloonTip(Settings.Default.DEFAULT_TOOLTIP_DISPLAY_TIME);
        }

        /// <summary>
        /// Restore windows from tray
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        /// <summary>
        /// User clicked on SystemTrayIcon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {

            // Which button was used?
            switch (e.Button)
            {
                case MouseButtons.Left:

                    if (WindowState == FormWindowState.Minimized)
                    {
                        restoreFormFromTray();
                    }
                    else
                    {
                        minimizeFormToTray();
                    }

                    break;

                case MouseButtons.Right:

                    showContextMenu();
                    return;
            }
        }

        private void showContextMenu()
        {
            contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        private void minimizeFormToTray()
        {
            Hide();
        }

        private void restoreFormFromTray()
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void timer_RunCommand_Tick(object sender, EventArgs e)
        {
            TimeSpan diff = DateTime.Now - timerStartTime;

            if (diff.TotalSeconds >= secondsBeforeRunningCommand)
            {
                showBallon("Executing command",
                            Settings.Default.DEFAULT_COMMAND + " " + commandToExecute);

                timer_RunCommand.Stop();
                ExecuteCommandPlannedCommand();
                SetDefaultValues();
            }

            var remainingSeconds = secondsBeforeRunningCommand - diff.TotalSeconds;
            var timespanRemainingSeconds = TimeSpan.FromSeconds(remainingSeconds);
            var remainingTimeFormatted = timespanRemainingSeconds.ToString(@"hh\:mm\:ss");

            toolStripStatusLabel1.Text = "Remaining: " + remainingTimeFormatted;
        }

        private void ExecuteCommandPlannedCommand()
        {
            Process.Start(Settings.Default.DEFAULT_COMMAND,
                        commandToExecute + " /t " + Settings.Default.DEFAULT_COMMAND_DELAY_TIME.ToString());

        }

        private void button_StopTimer_Click(object sender, EventArgs e)
        {
            SwitchUIBetweenOnAndOff();
            SetDefaultValues();
            toolStripStatusLabel1.Text = "Ready";
        }

        private void radioButton_SetCommand_CheckedChanged_1(object sender, EventArgs e)
        {
            RadioButton currentRadioCheckbox = (RadioButton)sender;

            if (!currentRadioCheckbox.Checked)
            {
                return;
            }

            switch (currentRadioCheckbox.Text)
            {
                case "Force shutdown":
                    commandToExecute = "/s /f";
                    break;

                case "Shutdown":
                    commandToExecute = "/s";
                    break;

                case "Log off":
                    commandToExecute = "/l";
                    break;

                default:
                    throw new UnknownCommandException("Unknown command \"" + currentRadioCheckbox.Text + "\".");
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void contextMenuStrip1_MouseLeave(object sender, EventArgs e)
        {
            contextMenuStrip1.Hide();
        }
    }
}
