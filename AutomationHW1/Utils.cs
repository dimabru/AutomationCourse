using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomationHW1
{
    class Utils
    {

        public static string RunCmd(string command)
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c " + command;
            MessageBox.Show(command);
            p.Start();
            p.WaitForExit();

            string output = p.StandardOutput.ReadToEnd();
            return output;
        }

        /*
         * --token token
         * --project project
         * --report-file report_file
         * --label label
         * --name test_name
         * --testId test_id
         * --config-file config_file
        */
        public static string BuildTestimioCommand(Dictionary<string, string> testDict)
        {
            string path = Environment.GetEnvironmentVariable("PATH");
            path += ";C:\\Program Files\\nodejs\\;C:\\Users\\dimab\\AppData\\Roaming\\npm\\";
            Environment.SetEnvironmentVariable("PATH", path);

            string output = "npm i -g @testim/testim-cli && testim --token ";
            output += '"' + testDict["token"] + '"' + " ";

            output += "--project ";
            output += '"' + testDict["project"] + '"' + " ";

            output += "--label ";
            output += '"' + testDict["label"] + '"' + " ";

            output += "--host ";
            output += '"' + "ondemand.testim.io" + '"' + " ";

            output += "--port 4444 ";

            if (!String.IsNullOrEmpty(testDict["report_file"]))
            {
                output += "--report-file ";
                output += testDict["report_file"] + " ";
            }

            if (!String.IsNullOrEmpty(testDict["config_file"]))
            {
                output += "--config-file ";
                output += testDict["config_file"] + " ";
            }

            if (!String.IsNullOrEmpty(testDict["test_name"]))
            {
                output += "--name ";
                output += testDict["test_name"] + " ";
            }

            if (!String.IsNullOrEmpty(testDict["test_id"]))
            {
                output += "--testId ";
                output += testDict["test_id"] + " ";
            }

            return output;
        }

    }
}
