using System;
using System.Data;
using System.Diagnostics;
using System.Media;
using Microsoft.Office.Interop.Excel;
using System.Collections;

namespace WinFormsApp1
{
    public partial class ControlWindow : Form
    {
        public ControlWindow()
        {
            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
        Stack<String> historyArr = new Stack<String>();
        private static int i;
        private static int oldI;
        private void incrementOE(object sender, EventArgs e)
        {
            oldI = i;
            i++;
            OECount.Text = i.ToString();
            DateTime savedNow = DateTime.Now;
            historyArr.Push("+ Open Entry from " + oldI + " to " + i.ToString()  + " at " + savedNow);

        }

        private void decrOE(object sender, EventArgs e)
        {
            oldI = i;
            i--;
            OECount.Text = i.ToString();
            DateTime savedNow = DateTime.Now;
            historyArr.Push("- Open Entry from " + oldI + " to " + i.ToString() + " at " + savedNow);
        }

        private static int n;
        private static int oldN;
        private void incrementCE(object sender, EventArgs e)
        {
            oldN = n;
            n++;
            CECount.Text = n.ToString();
            DateTime savedNow = DateTime.Now;
            historyArr.Push("+ Closed Entry from " + oldN + " to " + n.ToString() + " at " + savedNow);
        }

        private void decreaseCE(object sender, EventArgs e)
        {
            oldN = n;
            n--;
            CECount.Text = n.ToString();
            DateTime savedNow = DateTime.Now;
            historyArr.Push("- Closed Entry from " + oldN + " to " + n.ToString() + " at " + savedNow);
        }


        Stopwatch timer = new Stopwatch();
        bool clicked = false;
        private static System.Windows.Forms.Timer updateTimer = new System.Windows.Forms.Timer();
        private void recordState(object sender, EventArgs e)
        {
            if (clicked == false)
            {
                clicked = true;
                timer.Start();
                Record.Text = "Stop Recording Time in Open";

                updateTimer.Interval = 10;
                updateTimer.Tick += new EventHandler(UpdateTimer);
                updateTimer.Start();

            }
            else if (clicked == true)
            {
                timer.Stop();
                updateTimer.Stop();
                clicked = false;
                Record.Text = "Start Recording Time in Open";
                TimeSpan ts = timer.Elapsed;
                string totalTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                DISCLAIMER.Text = "Elapsed Time In Open: " + totalTime + "\nElapsed Time In Closed: ";

            }


        }


        private void UpdateTimer(object sender, EventArgs e)
        {
            TimeSpan ts = timer.Elapsed;
            string totalTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            DISCLAIMER.Text = "Elapsed Time In Open: " + totalTime;
        }


        private void saveToExcel(object sender, EventArgs e)
        {
            return;
        }

        private void DISCLAIMER_Click(object sender, EventArgs e)
        {

        }

        private void ResetTime(object sender, EventArgs e)
        {
            timer.Reset();
            updateTimer.Dispose();
            TimeSpan ts = timer.Elapsed;
            string totalTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            DISCLAIMER.Text = "Elapsed Time In Open: " + totalTime;

        }

        private void ControlWindow_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void DrawHistory(object sender, EventArgs e)
        {
            History history = new History(historyArr);
            history.Show();
        }


    
    }
}
