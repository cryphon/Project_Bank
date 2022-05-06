namespace DesignPatterns_Week3
{
    partial class ControlPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewStation = new System.Windows.Forms.Button();
            this.btnNewDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewStation
            // 
            this.btnNewStation.Location = new System.Drawing.Point(135, 104);
            this.btnNewStation.Name = "btnNewStation";
            this.btnNewStation.Size = new System.Drawing.Size(327, 72);
            this.btnNewStation.TabIndex = 0;
            this.btnNewStation.Text = "New Station";
            this.btnNewStation.UseVisualStyleBackColor = true;
            this.btnNewStation.Click += new System.EventHandler(this.btnNewStation_Click);
            // 
            // btnNewDisplay
            // 
            this.btnNewDisplay.Location = new System.Drawing.Point(12, 415);
            this.btnNewDisplay.Name = "btnNewDisplay";
            this.btnNewDisplay.Size = new System.Drawing.Size(118, 23);
            this.btnNewDisplay.TabIndex = 1;
            this.btnNewDisplay.Text = "New Display";
            this.btnNewDisplay.UseVisualStyleBackColor = true;
            this.btnNewDisplay.Click += new System.EventHandler(this.btnNewDisplay_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.btnNewDisplay);
            this.Controls.Add(this.btnNewStation);
            this.Name = "ControlPanel";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewStation;
        private System.Windows.Forms.Button btnNewDisplay;
    }
}
