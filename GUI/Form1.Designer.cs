namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.sourcePath = new System.Windows.Forms.Label();
            this.replicaPath = new System.Windows.Forms.Label();
            this.logPath = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.ListBox();
            this.sourceFolder = new System.Windows.Forms.Button();
            this.replicaFolder = new System.Windows.Forms.Button();
            this.logFile = new System.Windows.Forms.Button();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // sourcePath
            // 
            this.sourcePath.AutoSize = true;
            this.sourcePath.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourcePath.Location = new System.Drawing.Point(49, 59);
            this.sourcePath.Name = "sourcePath";
            this.sourcePath.Size = new System.Drawing.Size(115, 22);
            this.sourcePath.TabIndex = 0;
            this.sourcePath.Text = "Source Folder";
            // 
            // replicaPath
            // 
            this.replicaPath.AutoSize = true;
            this.replicaPath.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replicaPath.Location = new System.Drawing.Point(49, 107);
            this.replicaPath.Name = "replicaPath";
            this.replicaPath.Size = new System.Drawing.Size(116, 22);
            this.replicaPath.TabIndex = 1;
            this.replicaPath.Text = "Replica Folder";
            // 
            // logPath
            // 
            this.logPath.AutoSize = true;
            this.logPath.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logPath.Location = new System.Drawing.Point(49, 155);
            this.logPath.Name = "logPath";
            this.logPath.Size = new System.Drawing.Size(66, 22);
            this.logPath.TabIndex = 2;
            this.logPath.Text = "Log File";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(53, 206);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(156, 23);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(215, 206);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(156, 23);
            this.stopBtn.TabIndex = 4;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // logBox
            // 
            this.logBox.FormattingEnabled = true;
            this.logBox.Location = new System.Drawing.Point(53, 251);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(318, 95);
            this.logBox.TabIndex = 5;
            // 
            // sourceFolder
            // 
            this.sourceFolder.Location = new System.Drawing.Point(212, 60);
            this.sourceFolder.Name = "sourceFolder";
            this.sourceFolder.Size = new System.Drawing.Size(159, 23);
            this.sourceFolder.TabIndex = 6;
            this.sourceFolder.Text = "Open Folder";
            this.sourceFolder.UseVisualStyleBackColor = true;
            this.sourceFolder.Click += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // replicaFolder
            // 
            this.replicaFolder.Location = new System.Drawing.Point(212, 106);
            this.replicaFolder.Name = "replicaFolder";
            this.replicaFolder.Size = new System.Drawing.Size(159, 23);
            this.replicaFolder.TabIndex = 7;
            this.replicaFolder.Text = "Open Folder";
            this.replicaFolder.UseVisualStyleBackColor = true;
            this.replicaFolder.Click += new System.EventHandler(this.folderBrowserDialog2_HelpRequest);
            // 
            // logFile
            // 
            this.logFile.Location = new System.Drawing.Point(212, 154);
            this.logFile.Name = "logFile";
            this.logFile.Size = new System.Drawing.Size(159, 23);
            this.logFile.TabIndex = 8;
            this.logFile.Text = "Open File";
            this.logFile.UseVisualStyleBackColor = true;
            this.logFile.Click += new System.EventHandler(this.logFile_Click);
            // 
            // folderBrowserDialog2
            // 
            this.folderBrowserDialog2.HelpRequest += new System.EventHandler(this.folderBrowserDialog2_HelpRequest);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(426, 372);
            this.Controls.Add(this.logFile);
            this.Controls.Add(this.replicaFolder);
            this.Controls.Add(this.sourceFolder);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.logPath);
            this.Controls.Add(this.replicaPath);
            this.Controls.Add(this.sourcePath);
            this.Name = "Form1";
            this.Text = "Folder Synchronizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label sourcePath;
        private System.Windows.Forms.Label replicaPath;
        private System.Windows.Forms.Label logPath;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.ListBox logBox;
        private System.Windows.Forms.Button sourceFolder;
        private System.Windows.Forms.Button replicaFolder;
        private System.Windows.Forms.Button logFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
    }
}

