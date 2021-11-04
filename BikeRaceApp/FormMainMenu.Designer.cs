namespace BikeRaceApp
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
            this.btnManageRider = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLeaderboards = new System.Windows.Forms.Button();
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
            // btnManageRider
            // 
            this.btnManageRider.Location = new System.Drawing.Point(88, 180);
            this.btnManageRider.Name = "btnManageRider";
            this.btnManageRider.Size = new System.Drawing.Size(180, 40);
            this.btnManageRider.TabIndex = 2;
            this.btnManageRider.Text = "Manage Race Details ";
            this.btnManageRider.UseVisualStyleBackColor = true;
            this.btnManageRider.Click += new System.EventHandler(this.btnManageRaceDetails_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(88, 246);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(180, 40);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnLeaderboards
            // 
            this.btnLeaderboards.Location = new System.Drawing.Point(88, 312);
            this.btnLeaderboards.Name = "btnLeaderboards";
            this.btnLeaderboards.Size = new System.Drawing.Size(180, 40);
            this.btnLeaderboards.TabIndex = 4;
            this.btnLeaderboards.Text = "Leaderboards";
            this.btnLeaderboards.UseVisualStyleBackColor = true;
            this.btnLeaderboards.Click += new System.EventHandler(this.btnLeaderboards_Click);
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
            this.label1.Location = new System.Drawing.Point(79, 30);
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
            this.Controls.Add(this.btnLeaderboards);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnManageRider);
            this.Controls.Add(this.btnAddRider);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMainMenu";
            this.Text = "Bike Race App";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddRider;
        private System.Windows.Forms.Button btnManageRider;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLeaderboards;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label1;
    }
}

