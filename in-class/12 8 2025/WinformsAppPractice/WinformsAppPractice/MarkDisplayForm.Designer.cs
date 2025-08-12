namespace WinformsAppPractice
{
    partial class MarkDisplayForm
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
            this.AverageMarksDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AverageMarksDisplay
            // 
            this.AverageMarksDisplay.AutoSize = true;
            this.AverageMarksDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageMarksDisplay.Location = new System.Drawing.Point(218, 167);
            this.AverageMarksDisplay.Name = "AverageMarksDisplay";
            this.AverageMarksDisplay.Size = new System.Drawing.Size(0, 38);
            this.AverageMarksDisplay.TabIndex = 0;
            // 
            // MarkDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AverageMarksDisplay);
            this.Name = "MarkDisplayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarkDisplayForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AverageMarksDisplay;
    }
}