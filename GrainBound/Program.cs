using System;
using System.Diagnostics;

namespace GrainBound
{
    class Program
    {
        static void Main(string[] args)
        {
            Process cmd = new Process();

            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;

            cmd.Start();

            /* execute "dir" */

            cmd.StandardInput.WriteLine("C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\GrainBound\\GrainBound\\python\\python.exe GrainBoundApp_no_eds.py");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
        }
    }
}
