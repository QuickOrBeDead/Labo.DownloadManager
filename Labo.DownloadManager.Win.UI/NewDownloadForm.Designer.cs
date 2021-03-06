﻿namespace Labo.DownloadManager.Win.UI
{
    partial class NewDownloadForm
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
            this.components = new System.ComponentModel.Container();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtDownloadFolder = new System.Windows.Forms.TextBox();
            this.lblDownloadFolder = new System.Windows.Forms.Label();
            this.btnDownloadFolder = new System.Windows.Forms.Button();
            this.cbStartNow = new System.Windows.Forms.CheckBox();
            this.nudSegmentsCount = new System.Windows.Forms.NumericUpDown();
            this.lblSegmentsCount = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.fbdDownloadFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudSegmentsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(12, 9);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(29, 13);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Text = "URL";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(15, 25);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(353, 20);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.TextChanged += new System.EventHandler(this.txtUrl_TextChanged);
            this.txtUrl.Leave += new System.EventHandler(this.txtUrl_Leave);
            this.txtUrl.Validating += new System.ComponentModel.CancelEventHandler(this.txtUrl_Validating);
            // 
            // txtDownloadFolder
            // 
            this.txtDownloadFolder.Location = new System.Drawing.Point(15, 68);
            this.txtDownloadFolder.Name = "txtDownloadFolder";
            this.txtDownloadFolder.Size = new System.Drawing.Size(317, 20);
            this.txtDownloadFolder.TabIndex = 2;
            this.txtDownloadFolder.TextChanged += new System.EventHandler(this.txtDownloadFolder_TextChanged);
            // 
            // lblDownloadFolder
            // 
            this.lblDownloadFolder.AutoSize = true;
            this.lblDownloadFolder.Location = new System.Drawing.Point(12, 52);
            this.lblDownloadFolder.Name = "lblDownloadFolder";
            this.lblDownloadFolder.Size = new System.Drawing.Size(87, 13);
            this.lblDownloadFolder.TabIndex = 3;
            this.lblDownloadFolder.Text = "Download Folder";
            // 
            // btnDownloadFolder
            // 
            this.btnDownloadFolder.Location = new System.Drawing.Point(338, 66);
            this.btnDownloadFolder.Name = "btnDownloadFolder";
            this.btnDownloadFolder.Size = new System.Drawing.Size(30, 23);
            this.btnDownloadFolder.TabIndex = 4;
            this.btnDownloadFolder.Text = "...";
            this.btnDownloadFolder.UseVisualStyleBackColor = true;
            this.btnDownloadFolder.Click += new System.EventHandler(this.btnDownloadFolder_Click);
            // 
            // cbStartNow
            // 
            this.cbStartNow.AutoSize = true;
            this.cbStartNow.Checked = true;
            this.cbStartNow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStartNow.Location = new System.Drawing.Point(298, 167);
            this.cbStartNow.Name = "cbStartNow";
            this.cbStartNow.Size = new System.Drawing.Size(73, 17);
            this.cbStartNow.TabIndex = 5;
            this.cbStartNow.Text = "Start Now";
            this.cbStartNow.UseVisualStyleBackColor = true;
            // 
            // nudSegmentsCount
            // 
            this.nudSegmentsCount.Location = new System.Drawing.Point(15, 175);
            this.nudSegmentsCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSegmentsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSegmentsCount.Name = "nudSegmentsCount";
            this.nudSegmentsCount.Size = new System.Drawing.Size(41, 20);
            this.nudSegmentsCount.TabIndex = 6;
            this.nudSegmentsCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblSegmentsCount
            // 
            this.lblSegmentsCount.AutoSize = true;
            this.lblSegmentsCount.Location = new System.Drawing.Point(12, 159);
            this.lblSegmentsCount.Name = "lblSegmentsCount";
            this.lblSegmentsCount.Size = new System.Drawing.Size(85, 13);
            this.lblSegmentsCount.TabIndex = 7;
            this.lblSegmentsCount.Text = "Segments Count";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(215, 190);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.Location = new System.Drawing.Point(296, 190);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(12, 103);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(60, 13);
            this.lblFileName.TabIndex = 10;
            this.lblFileName.Text = "File Name :";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(75, 100);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(293, 20);
            this.txtFileName.TabIndex = 11;
            this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Info:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(72, 133);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 13;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // NewDownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 221);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblSegmentsCount);
            this.Controls.Add(this.nudSegmentsCount);
            this.Controls.Add(this.cbStartNow);
            this.Controls.Add(this.btnDownloadFolder);
            this.Controls.Add(this.lblDownloadFolder);
            this.Controls.Add(this.txtDownloadFolder);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewDownloadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Download";
            ((System.ComponentModel.ISupportInitialize)(this.nudSegmentsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtDownloadFolder;
        private System.Windows.Forms.Label lblDownloadFolder;
        private System.Windows.Forms.Button btnDownloadFolder;
        private System.Windows.Forms.CheckBox cbStartNow;
        private System.Windows.Forms.NumericUpDown nudSegmentsCount;
        private System.Windows.Forms.Label lblSegmentsCount;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.FolderBrowserDialog fbdDownloadFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}