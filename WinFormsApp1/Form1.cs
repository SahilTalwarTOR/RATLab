using System;
using System.Data;
using System.Diagnostics;
using System.Media;
using Microsoft.Office.Interop.Excel;
using System.Collections;
using ClosedXML;
using System.Xml.XPath;
using DocumentFormat.OpenXml.ExtendedProperties;
using System.Runtime.InteropServices.JavaScript;
//Testing Version Control, Sahil Talwar 2024
namespace WinFormsApp1

{
    public partial class ControlWindow : Form
    {


        private static int called = 1;
        private static int i, n, oldI, oldN;
        Stopwatch timer = new Stopwatch();
        bool clicked = false;
        private static System.Windows.Forms.Timer updateTimer = new System.Windows.Forms.Timer();
        List<ExcelData> loggedData = new List<ExcelData>();
        TimeSpan baseTimeSpan = TimeSpan.FromMinutes(5);

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
                TimeSpan ct = baseTimeSpan.Subtract(ts);
                string closedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ct.Hours, ct.Minutes, ct.Seconds, ct.Milliseconds / 10);
                DISCLAIMER.Text = "Elapsed Time In Open: " + totalTime + "\nElapsed Time In Closed: " + ct;

            }


        }


        private void UpdateTimer(object sender, EventArgs e)
        {
            TimeSpan ts = timer.Elapsed;
            string totalTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            TimeSpan ct = baseTimeSpan.Subtract(ts);
            string closedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ct.Hours, ct.Minutes, ct.Seconds, ct.Milliseconds / 10);
            DISCLAIMER.Text = "Elapsed Time In Open: " + totalTime + "\nElapsed Time In Closed: " + ct;
        }


        private void saveToExcel(object sender, EventArgs e)
        {
            called++;
            Debug.WriteLine(called);
            using var newWorkbook = new ClosedXML.Excel.XLWorkbook();
            var worksheet = newWorkbook.AddWorksheet("Rat Report");
            string filePath = Environment.ExpandEnvironmentVariables(@"%userprofile%\downloads\");
            worksheet.Cell("A1").Value = "Rat";
            worksheet.Cell("B1").Value = "Video";
            worksheet.Cell("C1").Value = "# Entered Open Arm";
            worksheet.Cell("D1").Value = "# Entered Closed Arm";
            worksheet.Cell("E1").Value = "Time In Open Arm";
            worksheet.Cell("F1").Value = "Time in Closed Arm";
            worksheet.Cell("A" + called).InsertData(loggedData);

            var mergeRange = worksheet.Range("A1:F" + loggedData.Count);
            mergeRange.Style.Alignment.WrapText = true;



            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.InitialDirectory = filePath;
            saveDialog.Filter = "Excel Files|*.xlsx;";
            saveDialog.FilterIndex = 2;
            saveDialog.RestoreDirectory = true;
            System.Windows.Forms.DialogResult result = saveDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                for (int x = called; x < called + loggedData.Count; x++)
                {
                    if (worksheet.Cell("A" + x).GetValue<string>().Equals(worksheet.Cell("A" + (x + 1)).GetValue<string>()))
                    {
                        worksheet.Range("A" + x + ":A" + (x + 1)).Merge();
                        x++;
                    }
                }

                Console.WriteLine("WROTE TO FILE");
                MessageBox.Show("Saving as " + filePath + saveDialog.FileName);
                newWorkbook.SaveAs(filePath + Path.GetFileName(saveDialog.FileName));
                MessageBox.Show("File has been saved");
                historyArr.Push("Saved to Excel");
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
            historyArr.Push("Reset Time");

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
            
            string filePath = Environment.ExpandEnvironmentVariables(@"%userprofile%\downloads\");
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.InitialDirectory = filePath;
            saveDialog.Filter = "txt files (*.txt)|*.txt";
            saveDialog.FilterIndex = 2;
            saveDialog.RestoreDirectory = true;
            System.Windows.Forms.DialogResult result = saveDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(filePath, saveDialog.FileName))) {
                    foreach(ExcelData data in loggedData)
                    {
                        outputFile.WriteLine(data.returnData());
                    }
                }
            }

            historyArr.Push("Saved to Text");



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void logToArray(object sender, EventArgs e)
        {
            TimeSpan ts = timer.Elapsed;
            string totalTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            TimeSpan ct = baseTimeSpan.Subtract(ts);
            string closedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ct.Hours, ct.Minutes, ct.Seconds, ct.Milliseconds / 10);
            if (ts.Milliseconds == 0)
            {
                TimeSpan rm = TimeSpan.FromMinutes(0);
                string replaced = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", rm.Hours, rm.Minutes, rm.Seconds, rm.Milliseconds / 10);
                ExcelData data = new ExcelData(titleBox.Text, videoTitle.Text, i, n, totalTime, replaced);
                loggedData.Add(data);
                historyArr.Push("Logged to Array");
                titleBox.Text = "";
                videoTitle.Text = "";
            } else
            {
                ExcelData data = new ExcelData(titleBox.Text, videoTitle.Text, i, n, totalTime, closedTime);
                loggedData.Add(data);
                historyArr.Push("Logged to Array");
                titleBox.Text = "";
                videoTitle.Text = "";
            }


            

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }


    }
}
