﻿namespace WarehouseManager
{
	partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.dgvInvDisplay = new System.Windows.Forms.DataGridView();
            this.menInventory = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staInventory = new System.Windows.Forms.StatusStrip();
            this.tslLoggedUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslServerStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tooInventory = new System.Windows.Forms.ToolStrip();
            this.tscTxtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tscBtnSearch = new System.Windows.Forms.ToolStripButton();
            this.refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvDisplay)).BeginInit();
            this.menInventory.SuspendLayout();
            this.staInventory.SuspendLayout();
            this.tooInventory.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInvDisplay
            // 
            this.dgvInvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvDisplay.Location = new System.Drawing.Point(5, 52);
            this.dgvInvDisplay.Name = "dgvInvDisplay";
            this.dgvInvDisplay.Size = new System.Drawing.Size(932, 424);
            this.dgvInvDisplay.TabIndex = 0;
            this.dgvInvDisplay.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvInvDisplay_DataBindingComplete);
            // 
            // menInventory
            // 
            this.menInventory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menInventory.Location = new System.Drawing.Point(0, 0);
            this.menInventory.Name = "menInventory";
            this.menInventory.Size = new System.Drawing.Size(944, 24);
            this.menInventory.TabIndex = 1;
            this.menInventory.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.fileToolStripMenuItem.Text = "System";
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // staInventory
            // 
            this.staInventory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslLoggedUser,
            this.tslServerStatus});
            this.staInventory.Location = new System.Drawing.Point(0, 479);
            this.staInventory.Name = "staInventory";
            this.staInventory.Size = new System.Drawing.Size(944, 22);
            this.staInventory.TabIndex = 2;
            this.staInventory.Text = "statusStrip1";
            // 
            // tslLoggedUser
            // 
            this.tslLoggedUser.Name = "tslLoggedUser";
            this.tslLoggedUser.Size = new System.Drawing.Size(62, 17);
            this.tslLoggedUser.Text = "UserName";
            // 
            // tslServerStatus
            // 
            this.tslServerStatus.Name = "tslServerStatus";
            this.tslServerStatus.Size = new System.Drawing.Size(39, 17);
            this.tslServerStatus.Text = "Status";
            // 
            // tooInventory
            // 
            this.tooInventory.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tooInventory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscTxtSearch,
            this.tscBtnSearch});
            this.tooInventory.Location = new System.Drawing.Point(0, 24);
            this.tooInventory.Name = "tooInventory";
            this.tooInventory.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tooInventory.Size = new System.Drawing.Size(944, 25);
            this.tooInventory.TabIndex = 3;
            this.tooInventory.Text = "toolStrip1";
            // 
            // tscTxtSearch
            // 
            this.tscTxtSearch.Name = "tscTxtSearch";
            this.tscTxtSearch.Size = new System.Drawing.Size(200, 25);
            // 
            // tscBtnSearch
            // 
            this.tscBtnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tscBtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("tscBtnSearch.Image")));
            this.tscBtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tscBtnSearch.Name = "tscBtnSearch";
            this.tscBtnSearch.Size = new System.Drawing.Size(46, 22);
            this.tscBtnSearch.Text = "Search";
            this.tscBtnSearch.Click += new System.EventHandler(this.tscBtnSearch_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(862, 24);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 4;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click_1);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.tooInventory);
            this.Controls.Add(this.staInventory);
            this.Controls.Add(this.dgvInvDisplay);
            this.Controls.Add(this.menInventory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menInventory;
            this.Name = "Inventory";
            this.Text = "Warehouse Manager - Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvDisplay)).EndInit();
            this.menInventory.ResumeLayout(false);
            this.menInventory.PerformLayout();
            this.staInventory.ResumeLayout(false);
            this.staInventory.PerformLayout();
            this.tooInventory.ResumeLayout(false);
            this.tooInventory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvInvDisplay;
		private System.Windows.Forms.MenuStrip menInventory;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.StatusStrip staInventory;
		private System.Windows.Forms.ToolStripStatusLabel tslServerStatus;
		private System.Windows.Forms.ToolStripStatusLabel tslLoggedUser;
		private System.Windows.Forms.ToolStrip tooInventory;
		private System.Windows.Forms.ToolStripTextBox tscTxtSearch;
		private System.Windows.Forms.ToolStripButton tscBtnSearch;
		private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Button refresh;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
	}
}