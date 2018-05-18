using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomationHW1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (allTextFilled()) this.buttonRunTest.Enabled = true;

            this.textBoxAccessToken.TextChanged += textBox_TextChanged;
            this.textBoxConfigFile.TextChanged += textBox_TextChanged;
            this.textBoxLabel.TextChanged += textBox_TextChanged;
            this.textBoxProject.TextChanged += textBox_TextChanged;
            this.textBoxReportFile.TextChanged += textBox_TextChanged;
            this.textBoxTestID.TextChanged += textBox_TextChanged;
            this.textBoxTestName.TextChanged += textBox_TextChanged;

        }

        private bool allTextFilled()
        {
            if (String.IsNullOrEmpty(this.textBoxAccessToken.Text)) return false;
            if (String.IsNullOrEmpty(this.textBoxConfigFile.Text)) return false;
            if (String.IsNullOrEmpty(this.textBoxLabel.Text)) return false;
            if (String.IsNullOrEmpty(this.textBoxProject.Text)) return false;
            if (String.IsNullOrEmpty(this.textBoxReportFile.Text)) return false;
            if (String.IsNullOrEmpty(this.textBoxTestID.Text)) return false;
            if (String.IsNullOrEmpty(this.textBoxTestName.Text)) return false;

            return true;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (allTextFilled()) this.buttonRunTest.Enabled = true;
        }

        private void buttonRunTest_Click(object sender, EventArgs e)
        {
            string token = this.textBoxAccessToken.Text;
            string config_file = this.textBoxConfigFile.Text;
            string label = this.textBoxLabel.Text;
            string project = this.textBoxProject.Text;
            string report_file = this.textBoxReportFile.Text;
            string test_id = this.textBoxTestID.Text;
            string test_name = this.textBoxTestName.Text;

            string command = Utils.BuildTestimioCommand(token, project, report_file, label);
            string output = Utils.RunCmd(command);

            this.richTextBoxOutput.Text = output;
        }
    }
}
