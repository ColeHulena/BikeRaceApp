namespace BikeRaceApp
{
    partial class FormAddRider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddRider));
            this.txpName = new System.Windows.Forms.TextBox();
            this.txpSurname = new System.Windows.Forms.TextBox();
            this.txpSchool = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbIndividual = new System.Windows.Forms.RadioButton();
            this.rdbTeam = new System.Windows.Forms.RadioButton();
            this.cmbSelectTeam = new System.Windows.Forms.ComboBox();
            this.lblTeamMembers = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnAddRider = new System.Windows.Forms.Button();
            this.chbRace1 = new System.Windows.Forms.CheckBox();
            this.chbRace2 = new System.Windows.Forms.CheckBox();
            this.chbRace3 = new System.Windows.Forms.CheckBox();
            this.chbRace4 = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txpName
            // 
            this.txpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txpName.Location = new System.Drawing.Point(177, 113);
            this.txpName.Name = "txpName";
            this.txpName.Size = new System.Drawing.Size(158, 29);
            this.txpName.TabIndex = 4;
            this.txpName.Text = "Enter here";
            this.txpName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txpSurname
            // 
            this.txpSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txpSurname.Location = new System.Drawing.Point(177, 148);
            this.txpSurname.Name = "txpSurname";
            this.txpSurname.Size = new System.Drawing.Size(158, 29);
            this.txpSurname.TabIndex = 5;
            this.txpSurname.Text = "Enter here";
            this.txpSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txpSchool
            // 
            this.txpSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txpSchool.Location = new System.Drawing.Point(177, 183);
            this.txpSchool.Name = "txpSchool";
            this.txpSchool.Size = new System.Drawing.Size(158, 29);
            this.txpSchool.TabIndex = 6;
            this.txpSchool.Text = "Enter here";
            this.txpSchool.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add Rider";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rider Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rider Surname:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rider School:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Entry Type";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdbIndividual
            // 
            this.rdbIndividual.AutoSize = true;
            this.rdbIndividual.Checked = true;
            this.rdbIndividual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbIndividual.Location = new System.Drawing.Point(119, 227);
            this.rdbIndividual.Name = "rdbIndividual";
            this.rdbIndividual.Size = new System.Drawing.Size(107, 28);
            this.rdbIndividual.TabIndex = 12;
            this.rdbIndividual.TabStop = true;
            this.rdbIndividual.Text = "Individual";
            this.rdbIndividual.UseVisualStyleBackColor = true;
            this.rdbIndividual.CheckedChanged += new System.EventHandler(this.rdbIndividual_CheckedChanged);
            // 
            // rdbTeam
            // 
            this.rdbTeam.AutoSize = true;
            this.rdbTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTeam.Location = new System.Drawing.Point(228, 227);
            this.rdbTeam.Name = "rdbTeam";
            this.rdbTeam.Size = new System.Drawing.Size(77, 28);
            this.rdbTeam.TabIndex = 13;
            this.rdbTeam.Text = "Team";
            this.rdbTeam.UseVisualStyleBackColor = true;
            this.rdbTeam.CheckedChanged += new System.EventHandler(this.rdbTeam_CheckedChanged);
            // 
            // cmbSelectTeam
            // 
            this.cmbSelectTeam.FormattingEnabled = true;
            this.cmbSelectTeam.Location = new System.Drawing.Point(176, 285);
            this.cmbSelectTeam.Name = "cmbSelectTeam";
            this.cmbSelectTeam.Size = new System.Drawing.Size(121, 21);
            this.cmbSelectTeam.TabIndex = 15;
            this.cmbSelectTeam.Text = "Select Team";
            // 
            // lblTeamMembers
            // 
            this.lblTeamMembers.AutoSize = true;
            this.lblTeamMembers.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblTeamMembers.Location = new System.Drawing.Point(173, 269);
            this.lblTeamMembers.Name = "lblTeamMembers";
            this.lblTeamMembers.Size = new System.Drawing.Size(80, 13);
            this.lblTeamMembers.TabIndex = 16;
            this.lblTeamMembers.Text = "Team Members";
            // 
            // btnAddRider
            // 
            this.btnAddRider.Location = new System.Drawing.Point(177, 398);
            this.btnAddRider.Name = "btnAddRider";
            this.btnAddRider.Size = new System.Drawing.Size(180, 40);
            this.btnAddRider.TabIndex = 17;
            this.btnAddRider.Text = "Add Rider";
            this.btnAddRider.UseVisualStyleBackColor = true;
            this.btnAddRider.Click += new System.EventHandler(this.btnCreateTeam_Click);
            // 
            // chbRace1
            // 
            this.chbRace1.AutoSize = true;
            this.chbRace1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbRace1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbRace1.Location = new System.Drawing.Point(16, 269);
            this.chbRace1.Name = "chbRace1";
            this.chbRace1.Size = new System.Drawing.Size(88, 28);
            this.chbRace1.TabIndex = 18;
            this.chbRace1.Text = "Race 1";
            this.chbRace1.UseVisualStyleBackColor = true;
            // 
            // chbRace2
            // 
            this.chbRace2.AutoSize = true;
            this.chbRace2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbRace2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbRace2.Location = new System.Drawing.Point(16, 303);
            this.chbRace2.Name = "chbRace2";
            this.chbRace2.Size = new System.Drawing.Size(88, 28);
            this.chbRace2.TabIndex = 19;
            this.chbRace2.Text = "Race 2";
            this.chbRace2.UseVisualStyleBackColor = true;
            // 
            // chbRace3
            // 
            this.chbRace3.AutoSize = true;
            this.chbRace3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbRace3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbRace3.Location = new System.Drawing.Point(16, 337);
            this.chbRace3.Name = "chbRace3";
            this.chbRace3.Size = new System.Drawing.Size(88, 28);
            this.chbRace3.TabIndex = 20;
            this.chbRace3.Text = "Race 3";
            this.chbRace3.UseVisualStyleBackColor = true;
            // 
            // chbRace4
            // 
            this.chbRace4.AutoSize = true;
            this.chbRace4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbRace4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbRace4.Location = new System.Drawing.Point(16, 371);
            this.chbRace4.Name = "chbRace4";
            this.chbRace4.Size = new System.Drawing.Size(88, 28);
            this.chbRace4.TabIndex = 21;
            this.chbRace4.Text = "Race 4";
            this.chbRace4.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 398);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(66, 40);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormAddRider
            // 
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.chbRace4);
            this.Controls.Add(this.chbRace3);
            this.Controls.Add(this.chbRace2);
            this.Controls.Add(this.chbRace1);
            this.Controls.Add(this.btnAddRider);
            this.Controls.Add(this.lblTeamMembers);
            this.Controls.Add(this.cmbSelectTeam);
            this.Controls.Add(this.rdbTeam);
            this.Controls.Add(this.rdbIndividual);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txpSchool);
            this.Controls.Add(this.txpSurname);
            this.Controls.Add(this.txpName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddRider";
            this.Text = "Bike Race App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txpName;
        private System.Windows.Forms.TextBox txpSurname;
        private System.Windows.Forms.TextBox txpSchool;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbIndividual;
        private System.Windows.Forms.RadioButton rdbTeam;
        private System.Windows.Forms.ComboBox cmbSelectTeam;
        private System.Windows.Forms.Label lblTeamMembers;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnAddRider;
        private System.Windows.Forms.CheckBox chbRace1;
        private System.Windows.Forms.CheckBox chbRace2;
        private System.Windows.Forms.CheckBox chbRace3;
        private System.Windows.Forms.CheckBox chbRace4;
        private System.Windows.Forms.Button btnBack;
    }
}