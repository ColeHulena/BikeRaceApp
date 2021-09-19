namespace BikeRaceApp
{
    partial class FormLeaderBoard
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblLeaderBoard = new System.Windows.Forms.Label();
            this.lblNames = new System.Windows.Forms.Label();
            this.rbtnRace4 = new System.Windows.Forms.RadioButton();
            this.rbtnRace3 = new System.Windows.Forms.RadioButton();
            this.rbtnRace2 = new System.Windows.Forms.RadioButton();
            this.rbtnRace1 = new System.Windows.Forms.RadioButton();
            this.lblTimes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(23, 398);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(66, 40);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblLeaderBoard
            // 
            this.lblLeaderBoard.AutoSize = true;
            this.lblLeaderBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaderBoard.Location = new System.Drawing.Point(259, 32);
            this.lblLeaderBoard.Name = "lblLeaderBoard";
            this.lblLeaderBoard.Size = new System.Drawing.Size(181, 25);
            this.lblLeaderBoard.TabIndex = 24;
            this.lblLeaderBoard.Text = "LEADERBOARD";
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNames.Font = new System.Drawing.Font("Dutch801 Rm BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNames.Location = new System.Drawing.Point(189, 152);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(333, 19);
            this.lblNames.TabIndex = 25;
            this.lblNames.Text = "Select a Race to view the respective leaderboard";
            // 
            // rbtnRace4
            // 
            this.rbtnRace4.AutoSize = true;
            this.rbtnRace4.Location = new System.Drawing.Point(514, 94);
            this.rbtnRace4.Name = "rbtnRace4";
            this.rbtnRace4.Size = new System.Drawing.Size(60, 17);
            this.rbtnRace4.TabIndex = 34;
            this.rbtnRace4.TabStop = true;
            this.rbtnRace4.Text = "Race 4";
            this.rbtnRace4.UseVisualStyleBackColor = true;
            this.rbtnRace4.CheckedChanged += new System.EventHandler(this.rbtnRace4_CheckedChanged);
            // 
            // rbtnRace3
            // 
            this.rbtnRace3.AutoSize = true;
            this.rbtnRace3.Location = new System.Drawing.Point(380, 94);
            this.rbtnRace3.Name = "rbtnRace3";
            this.rbtnRace3.Size = new System.Drawing.Size(60, 17);
            this.rbtnRace3.TabIndex = 33;
            this.rbtnRace3.TabStop = true;
            this.rbtnRace3.Text = "Race 3";
            this.rbtnRace3.UseVisualStyleBackColor = true;
            this.rbtnRace3.CheckedChanged += new System.EventHandler(this.rbtnRace3_CheckedChanged);
            // 
            // rbtnRace2
            // 
            this.rbtnRace2.AutoSize = true;
            this.rbtnRace2.Location = new System.Drawing.Point(252, 94);
            this.rbtnRace2.Name = "rbtnRace2";
            this.rbtnRace2.Size = new System.Drawing.Size(60, 17);
            this.rbtnRace2.TabIndex = 32;
            this.rbtnRace2.TabStop = true;
            this.rbtnRace2.Text = "Race 2";
            this.rbtnRace2.UseVisualStyleBackColor = true;
            this.rbtnRace2.CheckedChanged += new System.EventHandler(this.rbtnRace2_CheckedChanged);
            // 
            // rbtnRace1
            // 
            this.rbtnRace1.AutoSize = true;
            this.rbtnRace1.Location = new System.Drawing.Point(133, 94);
            this.rbtnRace1.Name = "rbtnRace1";
            this.rbtnRace1.Size = new System.Drawing.Size(60, 17);
            this.rbtnRace1.TabIndex = 31;
            this.rbtnRace1.TabStop = true;
            this.rbtnRace1.Text = "Race 1";
            this.rbtnRace1.UseVisualStyleBackColor = true;
            this.rbtnRace1.CheckedChanged += new System.EventHandler(this.rbtnRace1_CheckedChanged);
            // 
            // lblTimes
            // 
            this.lblTimes.AutoSize = true;
            this.lblTimes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTimes.Font = new System.Drawing.Font("Dutch801 Rm BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimes.Location = new System.Drawing.Point(440, 152);
            this.lblTimes.Name = "lblTimes";
            this.lblTimes.Size = new System.Drawing.Size(0, 19);
            this.lblTimes.TabIndex = 35;
            // 
            // FormLeaderBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTimes);
            this.Controls.Add(this.rbtnRace4);
            this.Controls.Add(this.rbtnRace3);
            this.Controls.Add(this.rbtnRace2);
            this.Controls.Add(this.rbtnRace1);
            this.Controls.Add(this.lblNames);
            this.Controls.Add(this.lblLeaderBoard);
            this.Controls.Add(this.btnBack);
            this.Name = "FormLeaderBoard";
            this.Text = "FormLeaderBoard";
            this.Load += new System.EventHandler(this.FormLeaderBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblLeaderBoard;
        private System.Windows.Forms.Label lblNames;
        private System.Windows.Forms.RadioButton rbtnRace4;
        private System.Windows.Forms.RadioButton rbtnRace3;
        private System.Windows.Forms.RadioButton rbtnRace2;
        private System.Windows.Forms.RadioButton rbtnRace1;
        private System.Windows.Forms.Label lblTimes;
    }
}