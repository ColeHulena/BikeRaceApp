namespace BikeRaceApp
{
    partial class FormSearchRider
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
            this.lvSearch = new System.Windows.Forms.ListView();
            this.txbSearchBar = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(39, 384);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(66, 40);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lvSearch
            // 
            this.lvSearch.HideSelection = false;
            this.lvSearch.Location = new System.Drawing.Point(92, 113);
            this.lvSearch.Name = "lvSearch";
            this.lvSearch.Size = new System.Drawing.Size(606, 171);
            this.lvSearch.TabIndex = 25;
            this.lvSearch.UseCompatibleStateImageBehavior = false;
            // 
            // txbSearchBar
            // 
            this.txbSearchBar.Location = new System.Drawing.Point(110, 52);
            this.txbSearchBar.Name = "txbSearchBar";
            this.txbSearchBar.Size = new System.Drawing.Size(100, 20);
            this.txbSearchBar.TabIndex = 27;
            this.txbSearchBar.TextChanged += new System.EventHandler(this.txbSearchBar_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(63, 55);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 26;
            this.lblSearch.Text = "Search";
            // 
            // FormSearchRider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbSearchBar);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lvSearch);
            this.Controls.Add(this.btnBack);
            this.Name = "FormSearchRider";
            this.Text = "FormSearchRider";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView lvSearch;
        private System.Windows.Forms.TextBox txbSearchBar;
        private System.Windows.Forms.Label lblSearch;
    }
}