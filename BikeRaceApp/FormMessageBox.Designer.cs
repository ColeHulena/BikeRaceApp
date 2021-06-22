namespace BikeRaceApp
{
    partial class FormMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMessageBox));
            this.btnLeftText = new System.Windows.Forms.Button();
            this.btnRightText = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLeftText
            // 
            this.btnLeftText.Location = new System.Drawing.Point(86, 78);
            this.btnLeftText.Name = "btnLeftText";
            this.btnLeftText.Size = new System.Drawing.Size(75, 23);
            this.btnLeftText.TabIndex = 0;
            this.btnLeftText.Text = "button1";
            this.btnLeftText.UseVisualStyleBackColor = true;
            this.btnLeftText.Click += new System.EventHandler(this.btnLeftText_Click);
            // 
            // btnRightText
            // 
            this.btnRightText.Location = new System.Drawing.Point(218, 78);
            this.btnRightText.Name = "btnRightText";
            this.btnRightText.Size = new System.Drawing.Size(75, 23);
            this.btnRightText.TabIndex = 1;
            this.btnRightText.Text = "button2";
            this.btnRightText.UseVisualStyleBackColor = true;
            this.btnRightText.Click += new System.EventHandler(this.btnRightText_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(12, 35);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(76, 25);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "label1";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 113);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnRightText);
            this.Controls.Add(this.btnLeftText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMessageBox";
            this.Text = "MessageBox";
            this.Load += new System.EventHandler(this.FormMessageBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeftText;
        private System.Windows.Forms.Button btnRightText;
        private System.Windows.Forms.Label lblMessage;
    }
}