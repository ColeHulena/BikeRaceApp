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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAddRider = new System.Windows.Forms.Button();
            this.btnEditRiderTeam = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLeaderboards = new System.Windows.Forms.Button();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(68, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 40);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "MAIN MENU";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddRider
            // 
            this.btnAddRider.Location = new System.Drawing.Point(88, 119);
            this.btnAddRider.Name = "btnAddRider";
            this.btnAddRider.Size = new System.Drawing.Size(180, 40);
            this.btnAddRider.TabIndex = 1;
            this.btnAddRider.Text = "Add Rider";
            this.btnAddRider.UseVisualStyleBackColor = true;
            // 
            // btnEditRiderTeam
            // 
            this.btnEditRiderTeam.Location = new System.Drawing.Point(88, 230);
            this.btnEditRiderTeam.Name = "btnEditRiderTeam";
            this.btnEditRiderTeam.Size = new System.Drawing.Size(180, 40);
            this.btnEditRiderTeam.TabIndex = 2;
            this.btnEditRiderTeam.Text = "Edit Rider or Team";
            this.btnEditRiderTeam.UseVisualStyleBackColor = true;
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
            // btnAddTeam
            // 
            this.btnAddTeam.Location = new System.Drawing.Point(88, 174);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(180, 40);
            this.btnAddTeam.TabIndex = 5;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.btnLeaderboards);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnEditRiderTeam);
            this.Controls.Add(this.btnAddRider);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Bike Race App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAddRider;
        private System.Windows.Forms.Button btnEditRiderTeam;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLeaderboards;
        private System.Windows.Forms.Button btnAddTeam;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

