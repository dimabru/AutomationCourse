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
            p.Start();
            p.WaitForExit();

            string output = p.StandardOutput.ReadToEnd();
            //output = p.StandardError.ReadToEnd();
            return output;
        }

        public static string BuildTestimioCommand(string token, string project, string report, string label)
        {
            string path = Environment.GetEnvironmentVariable("PATH");
            path += ";C:\\Program Files\\nodejs\\;C:\\Users\\dimab\\AppData\\Roaming\\npm\\";
            Environment.SetEnvironmentVariable("PATH", path);

            string output = "npm i -g @testim/testim-cli && testim --token ";
            output += '"' + token + '"' + " ";

            output += "--project ";
            output += '"' + project + '"' + " ";

            output += "--host ";
            output += '"' + "ondemand.testim.io" + '"' + " ";

            output += "--port 4444 ";

            output += "--report-file ";
            output += report + " ";

            output += "--label ";
            output += '"' + label + '"';

            return output;
        }

    }
}
