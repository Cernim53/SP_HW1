using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Task4
{
    public class myProcess
    {
        Process process = null;
        public void Strat(string name)
        {
            try
            {
                process = new Process();
                
                process.StartInfo.FileName = $"{name}.exe";
                process.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Kill()
        {
            try
            {
                if (process != null)
                {
                    process.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public string ExitCode()
        {
            return process.ExitCode.ToString();
        }

        public bool HasExited()
        {
            if(process.HasExited)
                return true;

            return false;
        }

        public string GetResProc(string a, string b)
        {
            ProcessStartInfo pi = new ProcessStartInfo();
            pi.FileName = "Math.exe";
            pi.Arguments = $"{a} {b}";
            pi.CreateNoWindow = true;
            var res = Process.Start(pi);
            Thread.Sleep(300);
            if(res.HasExited)
                return Convert.ToString(res.ExitCode);

            return "";
        }

        public string GetResQuantity(string word, string path)
        {
            ProcessStartInfo pi = new ProcessStartInfo();
            pi.FileName = "Search.exe";
            pi.Arguments = $"{word} {path}";
            var res = Process.Start(pi);
            Thread.Sleep(300);

            if (res.HasExited)
                return Convert.ToString(res.ExitCode);

            return "";
        }
    }
}
