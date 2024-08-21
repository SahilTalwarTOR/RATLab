using System;
using System.Data;
using System.Diagnostics;
using System.Media;
using Microsoft.Office.Interop.Excel;
using System.Collections;
using ClosedXML;
using System.Xml.XPath;
//Testing Version Control, Sahil Talwar 2024
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
            historyArr.Push("+ Open Entry from " + oldI + " to " + i.ToString() + " at " + savedNow);

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
            using var newWorkbook = new ClosedXML.Excel.XLWorkbook();
            var worksheet = newWorkbook.AddWorksheet("Rat Report");
            string filePath = Environment.ExpandEnvironmentVariables(@"%userprofile%\downloads\");
            worksheet.Cell("A1").Value = "Video Name";
            worksheet.Cell("B1").Value = "#Entered open arm";
            worksheet.Cell("C1").Value = "#Entered closed arm";
            worksheet.Cell("D1").Value = "Time in open arm";

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.InitialDirectory = filePath;
            saveDialog.Filter = "Excel Files|*.xlsx;";
            saveDialog.FilterIndex = 2;
            saveDialog.RestoreDirectory = true;
            System.Windows.Forms.DialogResult result = saveDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                Console.WriteLine("WROTE TO FILE");
                MessageBox.Show("Saving as " + filePath + saveDialog.FileName);
                newWorkbook.SaveAs(filePath + Path.GetFileName(saveDialog.FileName));
            }

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

        private void resetAll(object sender, EventArgs e)
        {
            historyArr.Push("- Reset All");
            i = 0;
            n = 0;
            OECount.Text = i.ToString();
            CECount.Text = i.ToString();
            ResetTime(sender, e);
        }

        private void savetoText(object sender, EventArgs e)
        {

        }
    }
}
