namespace WinFormsApp1
{
    partial class ControlWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            IncrOEntries = new Button();
            decrOEntries = new Button();
            decrCEntries = new Button();
            incrCEntries = new Button();
            OpenEntriesLabel = new Label();
            ClosedEntriesLabel = new Label();
            OECount = new Label();
            CECount = new Label();
            Record = new Button();
            DISCLAIMER = new Label();
            Author = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            resetAllToolStripMenuItem = new ToolStripMenuItem();
            resetTimeToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveToExcelToolStripMenuItem = new ToolStripMenuItem();
            saveToTXTToolStripMenuItem = new ToolStripMenuItem();
            insertBaselineToolStripMenuItem = new ToolStripMenuItem();
            LogButton = new Button();
            titleBox = new TextBox();
            videoTitle = new TextBox();
            setClosedOpenTo0ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // IncrOEntries
            // 
            IncrOEntries.Location = new Point(90, 139);
            IncrOEntries.Name = "IncrOEntries";
            IncrOEntries.Size = new Size(63, 29);
            IncrOEntries.TabIndex = 0;
            IncrOEntries.Text = "+";
            IncrOEntries.UseVisualStyleBackColor = true;
            IncrOEntries.Click += incrementOE;
            // 
            // decrOEntries
            // 
            decrOEntries.Location = new Point(90, 174);
            decrOEntries.Name = "decrOEntries";
            decrOEntries.Size = new Size(63, 29);
            decrOEntries.TabIndex = 1;
            decrOEntries.Text = "-";
            decrOEntries.UseVisualStyleBackColor = true;
            decrOEntries.Click += decrOE;
            // 
            // decrCEntries
            // 
            decrCEntries.Location = new Point(290, 174);
            decrCEntries.Name = "decrCEntries";
            decrCEntries.Size = new Size(63, 29);
            decrCEntries.TabIndex = 3;
            decrCEntries.Text = "-";
            decrCEntries.UseVisualStyleBackColor = true;
            decrCEntries.Click += decreaseCE;
            // 
            // incrCEntries
            // 
            incrCEntries.Location = new Point(290, 139);
            incrCEntries.Name = "incrCEntries";
            incrCEntries.Size = new Size(63, 29);
            incrCEntries.TabIndex = 2;
            incrCEntries.Text = "+";
            incrCEntries.UseVisualStyleBackColor = true;
            incrCEntries.Click += incrementCE;
            // 
            // OpenEntriesLabel
            // 
            OpenEntriesLabel.Font = new Font("Segoe UI", 12F);
            OpenEntriesLabel.Location = new Point(58, 68);
            OpenEntriesLabel.Name = "OpenEntriesLabel";
            OpenEntriesLabel.Size = new Size(128, 33);
            OpenEntriesLabel.TabIndex = 4;
            OpenEntriesLabel.Text = "Open Entries #";
            OpenEntriesLabel.TextAlign = ContentAlignment.MiddleCenter;
            OpenEntriesLabel.Click += label1_Click;
            // 
            // ClosedEntriesLabel
            // 
            ClosedEntriesLabel.Font = new Font("Segoe UI", 12F);
            ClosedEntriesLabel.Location = new Point(260, 68);
            ClosedEntriesLabel.Name = "ClosedEntriesLabel";
            ClosedEntriesLabel.Size = new Size(128, 33);
            ClosedEntriesLabel.TabIndex = 5;
            ClosedEntriesLabel.Text = "Closed Entries #";
            ClosedEntriesLabel.TextAlign = ContentAlignment.MiddleCenter;
            ClosedEntriesLabel.Click += label1_Click_1;
            // 
            // OECount
            // 
            OECount.AutoSize = true;
            OECount.Font = new Font("Segoe UI", 13F);
            OECount.Location = new Point(111, 101);
            OECount.Name = "OECount";
            OECount.Size = new Size(22, 25);
            OECount.TabIndex = 6;
            OECount.Text = "0";
            OECount.Click += label1_Click_2;
            // 
            // CECount
            // 
            CECount.AutoSize = true;
            CECount.Font = new Font("Segoe UI", 13F);
            CECount.Location = new Point(312, 101);
            CECount.Name = "CECount";
            CECount.Size = new Size(22, 25);
            CECount.TabIndex = 7;
            CECount.Text = "0";
            // 
            // Record
            // 
            Record.Font = new Font("Segoe UI", 16F);
            Record.Location = new Point(433, 68);
            Record.Name = "Record";
            Record.Size = new Size(342, 131);
            Record.TabIndex = 8;
            Record.Text = "Start Recording Time In Open";
            Record.UseVisualStyleBackColor = true;
            Record.Click += recordState;
            // 
            // DISCLAIMER
            // 
            DISCLAIMER.AutoSize = true;
            DISCLAIMER.Font = new Font("Segoe UI", 8F);
            DISCLAIMER.Location = new Point(480, 52);
            DISCLAIMER.Name = "DISCLAIMER";
            DISCLAIMER.Size = new Size(243, 13);
            DISCLAIMER.TabIndex = 10;
            DISCLAIMER.Text = "Time in closed will be automatically calculated";
            DISCLAIMER.TextAlign = ContentAlignment.MiddleCenter;
            DISCLAIMER.Click += DISCLAIMER_Click;
            // 
            // Author
            // 
            Author.AutoSize = true;
            Author.Font = new Font("Segoe UI", 7F);
            Author.Location = new Point(3, 236);
            Author.Name = "Author";
            Author.Size = new Size(131, 12);
            Author.TabIndex = 11;
            Author.Text = "Software by Sahil Talwar 2024";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, resetAllToolStripMenuItem, resetTimeToolStripMenuItem, saveToolStripMenuItem, insertBaselineToolStripMenuItem, setClosedOpenTo0ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(57, 20);
            fileToolStripMenuItem.Text = "&History";
            fileToolStripMenuItem.Click += DrawHistory;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(57, 6);
            // 
            // resetAllToolStripMenuItem
            // 
            resetAllToolStripMenuItem.Name = "resetAllToolStripMenuItem";
            resetAllToolStripMenuItem.Size = new Size(64, 20);
            resetAllToolStripMenuItem.Text = "Reset All";
            resetAllToolStripMenuItem.Click += resetAll;
            // 
            // resetTimeToolStripMenuItem
            // 
            resetTimeToolStripMenuItem.Name = "resetTimeToolStripMenuItem";
            resetTimeToolStripMenuItem.Size = new Size(76, 20);
            resetTimeToolStripMenuItem.Text = "Reset Time";
            resetTimeToolStripMenuItem.Click += ResetTime;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToExcelToolStripMenuItem, saveToTXTToolStripMenuItem });
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(43, 20);
            saveToolStripMenuItem.Text = "Save";
            // 
            // saveToExcelToolStripMenuItem
            // 
            saveToExcelToolStripMenuItem.Name = "saveToExcelToolStripMenuItem";
            saveToExcelToolStripMenuItem.Size = new Size(142, 22);
            saveToExcelToolStripMenuItem.Text = "Save to Excel";
            saveToExcelToolStripMenuItem.Click += saveToExcel;
            // 
            // saveToTXTToolStripMenuItem
            // 
            saveToTXTToolStripMenuItem.Name = "saveToTXTToolStripMenuItem";
            saveToTXTToolStripMenuItem.Size = new Size(142, 22);
            saveToTXTToolStripMenuItem.Text = "Save to .TXT";
            saveToTXTToolStripMenuItem.Click += savetoText;
            // 
            // insertBaselineToolStripMenuItem
            // 
            insertBaselineToolStripMenuItem.Name = "insertBaselineToolStripMenuItem";
            insertBaselineToolStripMenuItem.Size = new Size(12, 20);
            // 
            // LogButton
            // 
            LogButton.Location = new Point(700, 205);
            LogButton.Name = "LogButton";
            LogButton.Size = new Size(75, 23);
            LogButton.TabIndex = 14;
            LogButton.Text = "Log Data";
            LogButton.UseVisualStyleBackColor = true;
            LogButton.Click += logToArray;
            // 
            // titleBox
            // 
            titleBox.Location = new Point(545, 205);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(149, 23);
            titleBox.TabIndex = 15;
            titleBox.Text = "Folder/Rat Name";
            titleBox.TextChanged += textBox1_TextChanged;
            // 
            // videoTitle
            // 
            videoTitle.Location = new Point(433, 205);
            videoTitle.Name = "videoTitle";
            videoTitle.Size = new Size(106, 23);
            videoTitle.TabIndex = 16;
            videoTitle.Text = "Video #";
            videoTitle.TextChanged += textBox1_TextChanged_1;
            // 
            // ControlWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 253);
            Controls.Add(videoTitle);
            Controls.Add(titleBox);
            Controls.Add(LogButton);
            Controls.Add(Author);
            Controls.Add(DISCLAIMER);
            Controls.Add(Record);
            Controls.Add(CECount);
            Controls.Add(OECount);
            Controls.Add(ClosedEntriesLabel);
            Controls.Add(OpenEntriesLabel);
            Controls.Add(decrCEntries);
            Controls.Add(incrCEntries);
            Controls.Add(decrOEntries);
            Controls.Add(IncrOEntries);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "ControlWindow";
            Text = "RATLab";
            Load += ControlWindow_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button IncrOEntries;
        private Button decrOEntries;
        private Button decrCEntries;
        private Button incrCEntries;
        private Label OpenEntriesLabel;
        private Label ClosedEntriesLabel;
        private Label OECount;
        private Label CECount;
        private Button Record;
        private Label DISCLAIMER;
        private Label Author;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem resetAllToolStripMenuItem;
        private ToolStripMenuItem resetTimeToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveToExcelToolStripMenuItem;
        private ToolStripMenuItem saveToTXTToolStripMenuItem;
        private Button LogButton;
        private TextBox titleBox;
        private TextBox videoTitle;
        private ToolStripMenuItem insertBaselineToolStripMenuItem;
        private ToolStripMenuItem setClosedOpenTo0ToolStripMenuItem;
    }
}
