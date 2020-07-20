namespace Thelele_Mosebjadi__PRG281_Project
{
    partial class frmDirectMonitor
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstDrive = new System.Windows.Forms.ListBox();
            this.lstFolder = new System.Windows.Forms.ListBox();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.lblDrive = new System.Windows.Forms.Label();
            this.lblFolder = new System.Windows.Forms.Label();
            this.lblFiles = new System.Windows.Forms.Label();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkSub = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.label1.Location = new System.Drawing.Point(12, 376);
            this.label1.MinimumSize = new System.Drawing.Size(200, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder to monitor : ";
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(218, 374);
            this.txtFolder.MinimumSize = new System.Drawing.Size(508, 26);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.ReadOnly = true;
            this.txtFolder.Size = new System.Drawing.Size(508, 20);
            this.txtFolder.TabIndex = 1;
            // 
            // btnMonitor
            // 
            this.btnMonitor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnMonitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonitor.Location = new System.Drawing.Point(732, 374);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(140, 26);
            this.btnMonitor.TabIndex = 2;
            this.btnMonitor.Text = "&Monitor";
            this.btnMonitor.UseVisualStyleBackColor = false;
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 3);
            this.label3.MinimumSize = new System.Drawing.Size(600, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(600, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Monitor Folder Activity ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstDrive
            // 
            this.lstDrive.FormattingEnabled = true;
            this.lstDrive.Location = new System.Drawing.Point(15, 106);
            this.lstDrive.Name = "lstDrive";
            this.lstDrive.Size = new System.Drawing.Size(126, 121);
            this.lstDrive.TabIndex = 9;
            this.lstDrive.SelectedIndexChanged += new System.EventHandler(this.lstDrive_SelectedIndexChanged);
            // 
            // lstFolder
            // 
            this.lstFolder.FormattingEnabled = true;
            this.lstFolder.Location = new System.Drawing.Point(206, 106);
            this.lstFolder.Name = "lstFolder";
            this.lstFolder.Size = new System.Drawing.Size(171, 121);
            this.lstFolder.TabIndex = 10;
            this.lstFolder.SelectedIndexChanged += new System.EventHandler(this.lstFolder_SelectedIndexChanged);
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(443, 106);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(302, 121);
            this.lstFiles.TabIndex = 11;
            this.lstFiles.SelectedIndexChanged += new System.EventHandler(this.lstFiles_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.label4.Location = new System.Drawing.Point(12, 54);
            this.label4.MinimumSize = new System.Drawing.Size(200, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Choose Directory to monitor :: ";
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSelectFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFolder.Location = new System.Drawing.Point(206, 233);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(171, 23);
            this.btnSelectFolder.TabIndex = 13;
            this.btnSelectFolder.Text = "&Select Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = false;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // lblDrive
            // 
            this.lblDrive.AutoSize = true;
            this.lblDrive.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrive.Location = new System.Drawing.Point(12, 90);
            this.lblDrive.Name = "lblDrive";
            this.lblDrive.Size = new System.Drawing.Size(58, 16);
            this.lblDrive.TabIndex = 14;
            this.lblDrive.Text = "Drive ::";
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolder.Location = new System.Drawing.Point(263, 87);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(131, 16);
            this.lblFolder.TabIndex = 15;
            this.lblFolder.Text = "Directory/Folder ::";
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiles.Location = new System.Drawing.Point(440, 87);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(54, 16);
            this.lblFiles.TabIndex = 16;
            this.lblFiles.Text = "Files ::";
            // 
            // pBar
            // 
            this.pBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pBar.Location = new System.Drawing.Point(206, 468);
            this.pBar.Maximum = 3;
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(527, 16);
            this.pBar.Step = 1;
            this.pBar.TabIndex = 17;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(367, 499);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(169, 32);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkSub
            // 
            this.chkSub.AutoSize = true;
            this.chkSub.Location = new System.Drawing.Point(209, 274);
            this.chkSub.Name = "chkSub";
            this.chkSub.Size = new System.Drawing.Size(168, 17);
            this.chkSub.TabIndex = 19;
            this.chkSub.Text = "Monitor Subdirectories (if  any)";
            this.chkSub.UseVisualStyleBackColor = true;
            // 
            // frmDirectMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(886, 543);
            this.Controls.Add(this.chkSub);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.lblFiles);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.lblDrive);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.lstFolder);
            this.Controls.Add(this.lstDrive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMonitor);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDirectMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor Directory";
            this.Load += new System.EventHandler(this.frmDirectMonitor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstDrive;
        private System.Windows.Forms.ListBox lstFolder;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Label lblDrive;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkSub;
    }
}

