namespace BinChecker
{
    partial class Form1
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
            this.CheckBinsButton = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // CheckBinsButton
            // 
            this.CheckBinsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBinsButton.Location = new System.Drawing.Point(92, 61);
            this.CheckBinsButton.Name = "CheckBinsButton";
            this.CheckBinsButton.Size = new System.Drawing.Size(75, 23);
            this.CheckBinsButton.TabIndex = 0;
            this.CheckBinsButton.Text = "Check Bins";
            this.CheckBinsButton.UseVisualStyleBackColor = true;
            this.CheckBinsButton.Click += new System.EventHandler(this.CheckBinsButton_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputLabel.Location = new System.Drawing.Point(8, 101);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(242, 56);
            this.OutputLabel.TabIndex = 1;
            this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(37, 21);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 166);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.CheckBinsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Bin Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CheckBinsButton;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}

