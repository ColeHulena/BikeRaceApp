namespace BikeRaceApp
{
    partial class FormManageRaceDetails
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txbSearchBar = new System.Windows.Forms.TextBox();
            this.lvSearch = new System.Windows.Forms.ListView();
            this.btnBack = new System.Windows.Forms.Button();
            this.dtpFinishTime = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.rbtnRace1 = new System.Windows.Forms.RadioButton();
            this.rbtnRace2 = new System.Windows.Forms.RadioButton();
            this.rbtnRace3 = new System.Windows.Forms.RadioButton();
            this.rbtnRace4 = new System.Windows.Forms.RadioButton();
            this.lblFinishTime = new System.Windows.Forms.Label();
            this.lblRaceTime = new System.Windows.Forms.Label();
            this.lblRaceTimeInput = new System.Windows.Forms.Label();
            this.btnRemoveRider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(29, 49);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search";
            // 
            // txbSearchBar
            // 
            this.txbSearchBar.Location = new System.Drawing.Point(76, 46);
            this.txbSearchBar.Name = "txbSearchBar";
            this.txbSearchBar.Size = new System.Drawing.Size(100, 20);
            this.txbSearchBar.TabIndex = 1;
            this.txbSearchBar.TextChanged += new System.EventHandler(this.txbSearchBar_TextChanged);
            // 
            // lvSearch
            // 
            this.lvSearch.HideSelection = false;
            this.lvSearch.Location = new System.Drawing.Point(57, 86);
            this.lvSearch.Name = "lvSearch";
            this.lvSearch.Size = new System.Drawing.Size(606, 171);
            this.lvSearch.TabIndex = 2;
            this.lvSearch.UseCompatibleStateImageBehavior = false;
            this.lvSearch.SelectedIndexChanged += new System.EventHandler(this.lvSearch_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(32, 398);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(66, 40);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dtpFinishTime
            // 
            this.dtpFinishTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFinishTime.Location = new System.Drawing.Point(102, 345);
            this.dtpFinishTime.Name = "dtpFinishTime";
            this.dtpFinishTime.ShowUpDown = true;
            this.dtpFinishTime.Size = new System.Drawing.Size(200, 20);
            this.dtpFinishTime.TabIndex = 25;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(544, 398);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 34);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update Race Result";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // rbtnRace1
            // 
            this.rbtnRace1.AutoSize = true;
            this.rbtnRace1.Location = new System.Drawing.Point(102, 294);
            this.rbtnRace1.Name = "rbtnRace1";
            this.rbtnRace1.Size = new System.Drawing.Size(60, 17);
            this.rbtnRace1.TabIndex = 27;
            this.rbtnRace1.TabStop = true;
            this.rbtnRace1.Text = "Race 1";
            this.rbtnRace1.UseVisualStyleBackColor = true;
            this.rbtnRace1.CheckedChanged += new System.EventHandler(this.rbtnRace1_CheckedChanged);
            // 
            // rbtnRace2
            // 
            this.rbtnRace2.AutoSize = true;
            this.rbtnRace2.Location = new System.Drawing.Point(221, 294);
            this.rbtnRace2.Name = "rbtnRace2";
            this.rbtnRace2.Size = new System.Drawing.Size(60, 17);
            this.rbtnRace2.TabIndex = 28;
            this.rbtnRace2.TabStop = true;
            this.rbtnRace2.Text = "Race 2";
            this.rbtnRace2.UseVisualStyleBackColor = true;
            this.rbtnRace2.CheckedChanged += new System.EventHandler(this.rbtnRace2_CheckedChanged);
            // 
            // rbtnRace3
            // 
            this.rbtnRace3.AutoSize = true;
            this.rbtnRace3.Location = new System.Drawing.Point(349, 294);
            this.rbtnRace3.Name = "rbtnRace3";
            this.rbtnRace3.Size = new System.Drawing.Size(60, 17);
            this.rbtnRace3.TabIndex = 29;
            this.rbtnRace3.TabStop = true;
            this.rbtnRace3.Text = "Race 3";
            this.rbtnRace3.UseVisualStyleBackColor = true;
            this.rbtnRace3.CheckedChanged += new System.EventHandler(this.rbtnRace3_CheckedChanged);
            // 
            // rbtnRace4
            // 
            this.rbtnRace4.AutoSize = true;
            this.rbtnRace4.Location = new System.Drawing.Point(483, 294);
            this.rbtnRace4.Name = "rbtnRace4";
            this.rbtnRace4.Size = new System.Drawing.Size(60, 17);
            this.rbtnRace4.TabIndex = 30;
            this.rbtnRace4.TabStop = true;
            this.rbtnRace4.Text = "Race 4";
            this.rbtnRace4.UseVisualStyleBackColor = true;
            this.rbtnRace4.CheckedChanged += new System.EventHandler(this.rbtnRace4_CheckedChanged);
            // 
            // lblFinishTime
            // 
            this.lblFinishTime.AutoSize = true;
            this.lblFinishTime.Location = new System.Drawing.Point(35, 351);
            this.lblFinishTime.Name = "lblFinishTime";
            this.lblFinishTime.Size = new System.Drawing.Size(60, 13);
            this.lblFinishTime.TabIndex = 31;
            this.lblFinishTime.Text = "Finish Time";
            // 
            // lblRaceTime
            // 
            this.lblRaceTime.AutoSize = true;
            this.lblRaceTime.Location = new System.Drawing.Point(359, 351);
            this.lblRaceTime.Name = "lblRaceTime";
            this.lblRaceTime.Size = new System.Drawing.Size(62, 13);
            this.lblRaceTime.TabIndex = 32;
            this.lblRaceTime.Text = "Race Time:";
            // 
            // lblRaceTimeInput
            // 
            this.lblRaceTimeInput.AutoSize = true;
            this.lblRaceTimeInput.Location = new System.Drawing.Point(424, 352);
            this.lblRaceTimeInput.Name = "lblRaceTimeInput";
            this.lblRaceTimeInput.Size = new System.Drawing.Size(58, 13);
            this.lblRaceTimeInput.TabIndex = 33;
            this.lblRaceTimeInput.Text = "0 Seconds";
            // 
            // btnRemoveRider
            // 
            this.btnRemoveRider.Location = new System.Drawing.Point(440, 398);
            this.btnRemoveRider.Name = "btnRemoveRider";
            this.btnRemoveRider.Size = new System.Drawing.Size(98, 34);
            this.btnRemoveRider.TabIndex = 34;
            this.btnRemoveRider.Text = "Remove Rider";
            this.btnRemoveRider.UseVisualStyleBackColor = true;
            this.btnRemoveRider.Click += new System.EventHandler(this.btnRemoveRider_Click);
            // 
            // FormManageRaceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.btnRemoveRider);
            this.Controls.Add(this.lblRaceTimeInput);
            this.Controls.Add(this.lblRaceTime);
            this.Controls.Add(this.lblFinishTime);
            this.Controls.Add(this.rbtnRace4);
            this.Controls.Add(this.rbtnRace3);
            this.Controls.Add(this.rbtnRace2);
            this.Controls.Add(this.rbtnRace1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dtpFinishTime);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lvSearch);
            this.Controls.Add(this.txbSearchBar);
            this.Controls.Add(this.lblSearch);
            this.Name = "FormManageRaceDetails";
            this.Text = "RiderRaceDetails";
            this.Load += new System.EventHandler(this.FormManageRaceDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txbSearchBar;
        private System.Windows.Forms.ListView lvSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dtpFinishTime;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RadioButton rbtnRace1;
        private System.Windows.Forms.RadioButton rbtnRace2;
        private System.Windows.Forms.RadioButton rbtnRace3;
        private System.Windows.Forms.RadioButton rbtnRace4;
        private System.Windows.Forms.Label lblFinishTime;
        private System.Windows.Forms.Label lblRaceTime;
        private System.Windows.Forms.Label lblRaceTimeInput;
        private System.Windows.Forms.Button btnRemoveRider;
    }
}