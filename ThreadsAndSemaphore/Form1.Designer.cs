namespace ThreadsAndSemaphore
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            WorkThreadsList = new ListBox();
            WaitThreadsList = new ListBox();
            CreateThreadsList = new ListBox();
            label4 = new Label();
            PleasesInSemaphore = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)PleasesInSemaphore).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(70, 32);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 0;
            label1.Text = "Working Threads";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(391, 32);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 1;
            label2.Text = "Waiting Threads";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(707, 32);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 2;
            label3.Text = "Created Threads";
            // 
            // WorkThreadsList
            // 
            WorkThreadsList.FormattingEnabled = true;
            WorkThreadsList.ItemHeight = 20;
            WorkThreadsList.Location = new Point(39, 73);
            WorkThreadsList.Name = "WorkThreadsList";
            WorkThreadsList.Size = new Size(194, 184);
            WorkThreadsList.TabIndex = 3;
            WorkThreadsList.MouseDoubleClick += WorkThreadsList_MouseDoubleClick;
            // 
            // WaitThreadsList
            // 
            WaitThreadsList.FormattingEnabled = true;
            WaitThreadsList.ItemHeight = 20;
            WaitThreadsList.Location = new Point(360, 73);
            WaitThreadsList.Name = "WaitThreadsList";
            WaitThreadsList.Size = new Size(194, 184);
            WaitThreadsList.TabIndex = 4;
            WaitThreadsList.MouseDoubleClick += WaitThreadsList_MouseDoubleClick;
            // 
            // CreateThreadsList
            // 
            CreateThreadsList.FormattingEnabled = true;
            CreateThreadsList.ItemHeight = 20;
            CreateThreadsList.Location = new Point(673, 73);
            CreateThreadsList.Name = "CreateThreadsList";
            CreateThreadsList.Size = new Size(194, 184);
            CreateThreadsList.TabIndex = 5;
            CreateThreadsList.MouseDoubleClick += CreateThreadsList_MouseDoubleClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(39, 275);
            label4.Name = "label4";
            label4.Size = new Size(157, 20);
            label4.TabIndex = 6;
            label4.Text = "Pleases in Semaphore";
            // 
            // PleasesInSemaphore
            // 
            PleasesInSemaphore.Location = new Point(39, 307);
            PleasesInSemaphore.Minimum = new decimal(new int[] { 6, 0, 0, 0 });
            PleasesInSemaphore.Name = "PleasesInSemaphore";
            PleasesInSemaphore.Size = new Size(157, 27);
            PleasesInSemaphore.TabIndex = 7;
            PleasesInSemaphore.Value = new decimal(new int[] { 6, 0, 0, 0 });
            PleasesInSemaphore.ValueChanged += PleasesInSemaphore_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(657, 288);
            button1.Name = "button1";
            button1.Size = new Size(210, 29);
            button1.TabIndex = 8;
            button1.Text = "Create a New";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 349);
            Controls.Add(button1);
            Controls.Add(PleasesInSemaphore);
            Controls.Add(label4);
            Controls.Add(CreateThreadsList);
            Controls.Add(WaitThreadsList);
            Controls.Add(WorkThreadsList);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Threads & Semaphore";
            ((System.ComponentModel.ISupportInitialize)PleasesInSemaphore).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox WorkThreadsList;
        private ListBox WaitThreadsList;
        private ListBox CreateThreadsList;
        private Label label4;
        private NumericUpDown PleasesInSemaphore;
        private Button button1;
    }
}