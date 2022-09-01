using System;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        myProcess process = new myProcess();

        public Form1()
        {
            InitializeComponent();

            btnVision(true);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if(((Button)sender).Name != "btnStart")
            {
                process.Strat(((Button)sender).Text);
            }
            else
            {
                process.Strat(tbNameProc.Text);
            }
            btnVision(false);
            timer1.Start();
        }

        private void btnStopProc_Click(object sender, EventArgs e)
        {
            process.Kill();
            btnVision(true);
            Status.Text += $" код [{process.ExitCode()}]";
            timer1.Stop();
        }

        private void btnVision(bool marker)
        {
            btnStart.Enabled = marker;
            btnNotepad.Enabled = marker;
            btnStopProc.Enabled = !marker;
            if (marker) { Status.Text = "Приложение не запущено"; }
            else { Status.Text = "Приложение запущено"; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (process.HasExited())
                btnVision(true);
        }

        private void btnStRes_Click(object sender, EventArgs e)
        {
            lRes.Text = process.GetResProc(tbA.Text, tbB.Text);
        }

        private void btnQuantity_Click(object sender, EventArgs e)
        {
            lQuentity.Text = process.GetResQuantity(tbWord.Text, tbPath.Text);
        }
    }
}
