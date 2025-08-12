namespace WinformsAppPractice
{
    partial class MarkSubmission
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
            this.Mark1 = new System.Windows.Forms.Label();
            this.Mark2 = new System.Windows.Forms.Label();
            this.Mark3 = new System.Windows.Forms.Label();
            this.Mark1TextBox = new System.Windows.Forms.TextBox();
            this.Mark2TextBox = new System.Windows.Forms.TextBox();
            this.Mark3TextBox = new System.Windows.Forms.TextBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mark1
            // 
            this.Mark1.AutoSize = true;
            this.Mark1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mark1.Location = new System.Drawing.Point(137, 85);
            this.Mark1.Name = "Mark1";
            this.Mark1.Size = new System.Drawing.Size(117, 38);
            this.Mark1.TabIndex = 0;
            this.Mark1.Text = "Mark 1";
            // 
            // Mark2
            // 
            this.Mark2.AutoSize = true;
            this.Mark2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mark2.Location = new System.Drawing.Point(137, 179);
            this.Mark2.Name = "Mark2";
            this.Mark2.Size = new System.Drawing.Size(117, 38);
            this.Mark2.TabIndex = 1;
            this.Mark2.Text = "Mark 2";
            // 
            // Mark3
            // 
            this.Mark3.AutoSize = true;
            this.Mark3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mark3.Location = new System.Drawing.Point(137, 277);
            this.Mark3.Name = "Mark3";
            this.Mark3.Size = new System.Drawing.Size(117, 38);
            this.Mark3.TabIndex = 2;
            this.Mark3.Text = "Mark 3";
            // 
            // Mark1TextBox
            // 
            this.Mark1TextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Mark1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mark1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mark1TextBox.Location = new System.Drawing.Point(334, 85);
            this.Mark1TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.Mark1TextBox.Name = "Mark1TextBox";
            this.Mark1TextBox.Size = new System.Drawing.Size(227, 38);
            this.Mark1TextBox.TabIndex = 3;
            // 
            // Mark2TextBox
            // 
            this.Mark2TextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Mark2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mark2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mark2TextBox.Location = new System.Drawing.Point(334, 179);
            this.Mark2TextBox.Name = "Mark2TextBox";
            this.Mark2TextBox.Size = new System.Drawing.Size(227, 38);
            this.Mark2TextBox.TabIndex = 3;
            // 
            // Mark3TextBox
            // 
            this.Mark3TextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Mark3TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mark3TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mark3TextBox.Location = new System.Drawing.Point(334, 277);
            this.Mark3TextBox.Name = "Mark3TextBox";
            this.Mark3TextBox.Size = new System.Drawing.Size(227, 38);
            this.Mark3TextBox.TabIndex = 3;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.Location = new System.Drawing.Point(354, 371);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(142, 54);
            this.SubmitBtn.TabIndex = 4;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // MarkSubmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 507);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.Mark3TextBox);
            this.Controls.Add(this.Mark2TextBox);
            this.Controls.Add(this.Mark1TextBox);
            this.Controls.Add(this.Mark3);
            this.Controls.Add(this.Mark2);
            this.Controls.Add(this.Mark1);
            this.Name = "MarkSubmission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mark Submission";
            this.Load += new System.EventHandler(this.MarkSubmission_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mark1;
        private System.Windows.Forms.Label Mark2;
        private System.Windows.Forms.Label Mark3;
        private System.Windows.Forms.TextBox Mark1TextBox;
        private System.Windows.Forms.TextBox Mark2TextBox;
        private System.Windows.Forms.TextBox Mark3TextBox;
        private System.Windows.Forms.Button SubmitBtn;
    }
}

