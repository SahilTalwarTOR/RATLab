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
            Save = new Button();
            DISCLAIMER = new Label();
            Author = new Label();
            Reset = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
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
            Record.Location = new Point(547, 12);
            Record.Name = "Record";
            Record.Size = new Size(230, 131);
            Record.TabIndex = 8;
            Record.Text = "Start Recording Time In Open";
            Record.UseVisualStyleBackColor = true;
            Record.Click += recordState;
            // 
            // Save
            // 
            Save.Font = new Font("Segoe UI", 18F);
            Save.Location = new Point(545, 183);
            Save.Name = "Save";
            Save.Size = new Size(230, 46);
            Save.TabIndex = 9;
            Save.Text = "Save To Excel";
            Save.UseVisualStyleBackColor = true;
            Save.Click += saveToExcel;
            // 
            // DISCLAIMER
            // 
            DISCLAIMER.AutoSize = true;
            DISCLAIMER.Font = new Font("Segoe UI", 8F);
            DISCLAIMER.Location = new Point(298, 12);
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
            // Reset
            // 
            Reset.Location = new Point(628, 149);
            Reset.Name = "Reset";
            Reset.Size = new Size(75, 23);
            Reset.TabIndex = 12;
            Reset.Text = "Reset Time";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += ResetTime;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
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
            // ControlWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 253);
            Controls.Add(Reset);
            Controls.Add(Author);
            Controls.Add(DISCLAIMER);
            Controls.Add(Save);
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
        private Button Save;
        private Label DISCLAIMER;
        private Label Author;
        private Button Reset;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
    }
}
