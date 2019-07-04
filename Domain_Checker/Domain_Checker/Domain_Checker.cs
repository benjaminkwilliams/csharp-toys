using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Domain_Checker
{
    public partial class Domain_Checker : Form
    {
        public Domain_Checker()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            lblActive.Text = "";

            string parameters = "net user " + txtUserName.Text;

            if(chkIsDomain.Checked)
            {
                parameters += " /domain";
            }

            ProcessStartInfo startInfo = new ProcessStartInfo("cmd", "/c " + parameters)
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            List<string> cmd_output = new List<string>();

            Process process = Process.Start(startInfo);
            process.OutputDataReceived += (cmdsender, cmde) => cmd_output.Add(cmde.Data + Environment.NewLine);
            process.BeginOutputReadLine();
            process.Start();
            process.WaitForExit();

            foreach (string line in cmd_output)
            {
                if (line.Contains("Comment"))
                    txtOutput.AppendText(line);

                if (line.Contains("Account active") && line.Substring(line.Length - 5, 3).Equals("Yes"))
                    lblActive.Text = "Active";
            }
        }
    }
}
