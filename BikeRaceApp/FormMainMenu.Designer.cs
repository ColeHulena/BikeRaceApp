﻿namespace BikeRaceApp
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.btnAddRider = new System.Windows.Forms.Button();
            this.btnEditRiderTeam = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLeaderboards = new System.Windows.Forms.Button();
            this.btnAddRiderToTeam = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddRider
            // 
            this.btnAddRider.Location = new System.Drawing.Point(88, 119);
            this.btnAddRider.Name = "btnAddRider";
            this.btnAddRider.Size = new System.Drawing.Size(180, 40);
            this.btnAddRider.TabIndex = 1;
            this.btnAddRider.Text = "Add Rider";
            this.btnAddRider.UseVisualStyleBackColor = true;
            this.btnAddRider.Click += new System.EventHandler(this.btnAddRider_Click);
            // 
            // btnEditRiderTeam
            // 
            this.btnEditRiderTeam.Location = new System.Drawing.Point(88, 230);
            this.btnEditRiderTeam.Name = "btnEditRiderTeam";
            this.btnEditRiderTeam.Size = new System.Drawing.Size(180, 40);
            this.btnEditRiderTeam.TabIndex = 2;
            this.btnEditRiderTeam.Text = "Manage Rider or Team";
            this.btnEditRiderTeam.UseVisualStyleBackColor = true;
            this.btnEditRiderTeam.Click += new System.EventHandler(this.btnEditRiderTeam_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(88, 292);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(180, 40);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnLeaderboards
            // 
            this.btnLeaderboards.Location = new System.Drawing.Point(88, 350);
            this.btnLeaderboards.Name = "btnLeaderboards";
            this.btnLeaderboards.Size = new System.Drawing.Size(180, 40);
            this.btnLeaderboards.TabIndex = 4;
            this.btnLeaderboards.Text = "Leaderboards";
            this.btnLeaderboards.UseVisualStyleBackColor = true;
            // 
            // btnAddRiderToTeam
            // 
            this.btnAddRiderToTeam.Location = new System.Drawing.Point(88, 174);
            this.btnAddRiderToTeam.Name = "btnAddRiderToTeam";
            this.btnAddRiderToTeam.Size = new System.Drawing.Size(180, 40);
            this.btnAddRiderToTeam.TabIndex = 5;
            this.btnAddRiderToTeam.Text = "Add Rider to Team";
            this.btnAddRiderToTeam.UseVisualStyleBackColor = true;
            this.btnAddRiderToTeam.Click += new System.EventHandler(this.btnCreateTeam_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "MAIN MENU";
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddRiderToTeam);
            this.Controls.Add(this.btnLeaderboards);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnEditRiderTeam);
            this.Controls.Add(this.btnAddRider);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMainMenu";
            this.Text = "Bike Race App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddRider;
        private System.Windows.Forms.Button btnEditRiderTeam;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLeaderboards;
        private System.Windows.Forms.Button btnAddRiderToTeam;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label1;
    }
}

