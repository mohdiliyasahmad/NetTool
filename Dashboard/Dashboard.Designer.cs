﻿namespace Dashboard
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.lblSoftware = new System.Windows.Forms.Label();
            this.lstSoftware = new System.Windows.Forms.ListBox();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.lstNetworkDevices = new System.Windows.Forms.ListView();
            this.lstIPAddress = new System.Windows.Forms.ListBox();
            this.lblNetworkDevices = new System.Windows.Forms.Label();
            this.lblIPAddresses = new System.Windows.Forms.Label();
            this.lstView = new System.Windows.Forms.ListView();
            this.chkOnline = new System.Windows.Forms.CheckBox();
            this.lblStorage = new System.Windows.Forms.Label();
            this.lstStorage = new System.Windows.Forms.ListView();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblDomain = new System.Windows.Forms.Label();
            this.lstDomain = new System.Windows.Forms.ListBox();
            this.lblScanning = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtFilter = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pgInfo = new System.Windows.Forms.ToolStripProgressBar();
            this.btnFilter = new System.Windows.Forms.ToolStripButton();
            this.btnList = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanOnlineOnly = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSoftware
            // 
            this.lblSoftware.AutoSize = true;
            this.lblSoftware.Location = new System.Drawing.Point(706, 36);
            this.lblSoftware.Name = "lblSoftware";
            this.lblSoftware.Size = new System.Drawing.Size(25, 13);
            this.lblSoftware.TabIndex = 15;
            this.lblSoftware.Text = "Info";
            this.lblSoftware.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstSoftware
            // 
            this.lstSoftware.FormattingEnabled = true;
            this.lstSoftware.Location = new System.Drawing.Point(703, 56);
            this.lstSoftware.Name = "lstSoftware";
            this.lstSoftware.Size = new System.Drawing.Size(524, 277);
            this.lstSoftware.TabIndex = 14;
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "OFF.jpg");
            this.imgList.Images.SetKeyName(1, "ON.jpg");
            // 
            // lstNetworkDevices
            // 
            this.lstNetworkDevices.Location = new System.Drawing.Point(12, 485);
            this.lstNetworkDevices.Name = "lstNetworkDevices";
            this.lstNetworkDevices.Size = new System.Drawing.Size(683, 124);
            this.lstNetworkDevices.TabIndex = 16;
            this.lstNetworkDevices.UseCompatibleStateImageBehavior = false;
            this.lstNetworkDevices.View = System.Windows.Forms.View.Details;
            this.lstNetworkDevices.Click += new System.EventHandler(this.lstNetworkDevices_Click);
            // 
            // lstIPAddress
            // 
            this.lstIPAddress.FormattingEnabled = true;
            this.lstIPAddress.Location = new System.Drawing.Point(704, 514);
            this.lstIPAddress.Name = "lstIPAddress";
            this.lstIPAddress.Size = new System.Drawing.Size(523, 95);
            this.lstIPAddress.TabIndex = 17;
            // 
            // lblNetworkDevices
            // 
            this.lblNetworkDevices.AutoSize = true;
            this.lblNetworkDevices.Location = new System.Drawing.Point(12, 459);
            this.lblNetworkDevices.Name = "lblNetworkDevices";
            this.lblNetworkDevices.Size = new System.Drawing.Size(25, 13);
            this.lblNetworkDevices.TabIndex = 18;
            this.lblNetworkDevices.Text = "Info";
            this.lblNetworkDevices.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIPAddresses
            // 
            this.lblIPAddresses.AutoSize = true;
            this.lblIPAddresses.Location = new System.Drawing.Point(703, 494);
            this.lblIPAddresses.Name = "lblIPAddresses";
            this.lblIPAddresses.Size = new System.Drawing.Size(25, 13);
            this.lblIPAddresses.TabIndex = 19;
            this.lblIPAddresses.Text = "Info";
            this.lblIPAddresses.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstView
            // 
            this.lstView.Location = new System.Drawing.Point(14, 127);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(683, 329);
            this.lstView.TabIndex = 24;
            this.lstView.UseCompatibleStateImageBehavior = false;
            this.lstView.View = System.Windows.Forms.View.Details;
            this.lstView.Click += new System.EventHandler(this.lstView_Click);
            // 
            // chkOnline
            // 
            this.chkOnline.AutoSize = true;
            this.chkOnline.Location = new System.Drawing.Point(409, 24);
            this.chkOnline.Name = "chkOnline";
            this.chkOnline.Size = new System.Drawing.Size(129, 17);
            this.chkOnline.TabIndex = 23;
            this.chkOnline.Text = "Online Machines Only";
            this.chkOnline.UseVisualStyleBackColor = true;
            // 
            // lblStorage
            // 
            this.lblStorage.AutoSize = true;
            this.lblStorage.Location = new System.Drawing.Point(702, 342);
            this.lblStorage.Name = "lblStorage";
            this.lblStorage.Size = new System.Drawing.Size(25, 13);
            this.lblStorage.TabIndex = 26;
            this.lblStorage.Text = "Info";
            this.lblStorage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstStorage
            // 
            this.lstStorage.Location = new System.Drawing.Point(703, 366);
            this.lstStorage.Name = "lstStorage";
            this.lstStorage.Size = new System.Drawing.Size(524, 116);
            this.lstStorage.TabIndex = 25;
            this.lstStorage.UseCompatibleStateImageBehavior = false;
            this.lstStorage.View = System.Windows.Forms.View.Details;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 111);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(25, 13);
            this.lblInfo.TabIndex = 27;
            this.lblInfo.Text = "Info";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Location = new System.Drawing.Point(15, 37);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(25, 13);
            this.lblDomain.TabIndex = 29;
            this.lblDomain.Text = "Info";
            this.lblDomain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstDomain
            // 
            this.lstDomain.FormattingEnabled = true;
            this.lstDomain.Location = new System.Drawing.Point(14, 56);
            this.lstDomain.Name = "lstDomain";
            this.lstDomain.Size = new System.Drawing.Size(363, 56);
            this.lstDomain.TabIndex = 28;
            // 
            // lblScanning
            // 
            this.lblScanning.AutoSize = true;
            this.lblScanning.Location = new System.Drawing.Point(572, 24);
            this.lblScanning.Name = "lblScanning";
            this.lblScanning.Size = new System.Drawing.Size(61, 13);
            this.lblScanning.TabIndex = 30;
            this.lblScanning.Text = "Scanning...";
            this.lblScanning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.txtFilter,
            this.btnFilter,
            this.toolStripSeparator2,
            this.pgInfo,
            this.btnList,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1240, 25);
            this.toolStrip1.TabIndex = 32;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(91, 22);
            this.toolStripLabel1.Text = "Search Machine";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // txtFilter
            // 
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 25);
            this.txtFilter.ToolTipText = "Search Machine ";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pgInfo
            // 
            this.pgInfo.Name = "pgInfo";
            this.pgInfo.Size = new System.Drawing.Size(100, 22);
            // 
            // btnFilter
            // 
            this.btnFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFilter.Image = global::Dashboard.Properties.Resources.find;
            this.btnFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(23, 22);
            this.btnFilter.Text = "toolStripButton3";
            this.btnFilter.ToolTipText = "Search Machine ";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnList
            // 
            this.btnList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnList.Image = global::Dashboard.Properties.Resources.Search_computer;
            this.btnList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(23, 22);
            this.btnList.Text = "Scan Network";
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1240, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scanNetworkToolStripMenuItem,
            this.scanOnlineOnly});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.fileToolStripMenuItem.Text = "Scan";
          
            // 
            // scanNetworkToolStripMenuItem
            // 
            this.scanNetworkToolStripMenuItem.Name = "scanNetworkToolStripMenuItem";
            this.scanNetworkToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.scanNetworkToolStripMenuItem.Text = "Scan Network";
            this.scanNetworkToolStripMenuItem.Click += new System.EventHandler(this.btnList_Click);
            // 
            // scanOnlineOnly
            // 
            this.scanOnlineOnly.Name = "scanOnlineOnly";
            this.scanOnlineOnly.Size = new System.Drawing.Size(165, 22);
            this.scanOnlineOnly.Text = "Scan Online Only";
            this.scanOnlineOnly.ToolTipText = "Scan Online Only";
            this.scanOnlineOnly.Click += new System.EventHandler(this.scanOnlineOnly_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1240, 657);
            this.Controls.Add(this.lblScanning);
            this.Controls.Add(this.chkOnline);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblDomain);
            this.Controls.Add(this.lstDomain);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblStorage);
            this.Controls.Add(this.lstStorage);
            this.Controls.Add(this.lstView);
            this.Controls.Add(this.lblIPAddresses);
            this.Controls.Add(this.lblNetworkDevices);
            this.Controls.Add(this.lstIPAddress);
            this.Controls.Add(this.lstNetworkDevices);
            this.Controls.Add(this.lblSoftware);
            this.Controls.Add(this.lstSoftware);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Network Scanner";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoftware;
        private System.Windows.Forms.ListBox lstSoftware;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.ListView lstNetworkDevices;
        private System.Windows.Forms.ListBox lstIPAddress;
        private System.Windows.Forms.Label lblNetworkDevices;
        private System.Windows.Forms.Label lblIPAddresses;
        private System.Windows.Forms.ListView lstView;
        private System.Windows.Forms.CheckBox chkOnline;
        private System.Windows.Forms.Label lblStorage;
        private System.Windows.Forms.ListView lstStorage;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.ListBox lstDomain;
        private System.Windows.Forms.Label lblScanning;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txtFilter;
        private System.Windows.Forms.ToolStripButton btnFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripProgressBar pgInfo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scanNetworkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scanOnlineOnly;
    }
}

