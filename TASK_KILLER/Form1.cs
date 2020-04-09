using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TASK_KILLER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            programBox.SelectAll();
        }

        private void OnAppTextChanged(object sender, EventArgs e)
            => getAppBtn.Enabled = (programBox.Text.Length > 0) ? true : false;

        private void SetDefaults()
        {
            new Thread(async () =>
            {
                await Task.Delay(3000);
                this.Invoke(new MethodInvoker(() =>
                {
                    messagelbl.Text = "WAITING FOR COMMAND...";
                }));
            }).Start();
        }

        private void OnItemChecked(object sender, ItemCheckEventArgs e)
        {
            new Thread(() =>
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    deleteAppBtn.Enabled = AppCheckBoxList.CheckedItems.Count > 0 ? true : false;
                }));
            }).Start();
        }

        private void getAppBtn_Click(object sender, EventArgs e)
        {
            deleteAppBtn.Enabled = false;
            AppCheckBoxList.Items.Clear();

            Process[] processList = Process.GetProcesses();

            foreach (Process process in processList)
            {
                if (process.ProcessName.StartsWith(programBox.Text))
                {
                    AppCheckBoxList.Items.Add(process.ProcessName);
                }
            }
            // Sort Items
            var items = AppCheckBoxList.Items
                .Cast<string>()
                .OrderBy(i => i)
                .ToArray();
            AppCheckBoxList.Items.Clear();
            AppCheckBoxList.Items.AddRange(items);

            // Set default items
            SetDefaults();
        }

        private void deleteAppBtn_Click(object sender, EventArgs e)
        {
            getAppBtn.Enabled = false;
            deleteAppBtn.Enabled = false;
            AppCheckBoxList.Enabled = false;

            foreach (string appName in AppCheckBoxList.CheckedItems)
            {
                messagelbl.Text = $"{appName} process is stopped.";

                Process[] ps = Process.GetProcessesByName(appName);

                foreach (Process p in ps)
                {
                    p.Kill();
                }
            }
            AppCheckBoxList.Items.Clear();

            new Thread(async () =>
            {
                await Task.Delay(5000);
                this.Invoke(new MethodInvoker(() =>
                {
                    getAppBtn_Click(sender, e);
                    AppCheckBoxList.Enabled = true;
                    getAppBtn.Enabled = true;
                }));
            }).Start();
        }
    }
}
