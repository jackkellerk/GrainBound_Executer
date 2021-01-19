using System;
using System.Diagnostics;

namespace GrainBound
{
    class Program
    {
        static void Main(string[] args)
        {
            if(!System.IO.File.Exists(Environment.CurrentDirectory + "\\python\\python.exe") || !System.IO.File.Exists("GrainBoundApp_no_eds.py"))
            {
                Console.WriteLine("ERROR: Main python files not found! GrainBound did not install correctly. Press any key to continue...");
                Console.ReadKey();
                return;
            }

            Process cmd = new Process();

            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;

            cmd.Start();

            /* execute "dir" */

            Console.WriteLine("Launching GrainBound process...");

            cmd.StandardInput.WriteLine(Environment.CurrentDirectory + "\\python\\python.exe GrainBoundApp_no_eds.py");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());

            cmd.Dispose();
        }
    }
}
