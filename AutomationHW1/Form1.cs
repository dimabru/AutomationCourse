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

            if (MandatoryTextFilled()) this.buttonRunTest.Enabled = true;

            this.textBoxAccessToken.TextChanged += textBox_TextChanged;
            this.textBoxLabel.TextChanged += textBox_TextChanged;
            this.textBoxProject.TextChanged += textBox_TextChanged;

        }

        private bool MandatoryTextFilled()
        {
            if (String.IsNullOrEmpty(this.textBoxAccessToken.Text)) return false;
            if (String.IsNullOrEmpty(this.textBoxLabel.Text)) return false;
            if (String.IsNullOrEmpty(this.textBoxProject.Text)) return false;
            
            return true;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (MandatoryTextFilled()) this.buttonRunTest.Enabled = true;
            else this.buttonRunTest.Enabled = false;
        }

        private void buttonRunTest_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> testDict = new Dictionary<string, string>();

            testDict["token"] = this.textBoxAccessToken.Text;
            testDict["label"] = this.textBoxLabel.Text;
            testDict["project"] = this.textBoxProject.Text;
            testDict["config_file"] = this.textBoxConfigFile.Text;
            testDict["report_file"] = this.textBoxReportFile.Text;
            testDict["test_id"] = this.textBoxTestID.Text;
            testDict["test_name"] = this.textBoxTestName.Text;

            string command = Utils.BuildTestimioCommand(testDict);
            this.richTextBoxCommand.Text = command;
            string output = Utils.RunCmd(command);

            this.richTextBoxOutput.Text = output;
        }
    }
}
