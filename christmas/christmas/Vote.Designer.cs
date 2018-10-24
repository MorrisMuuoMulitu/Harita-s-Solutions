namespace christmas
{
    partial class Vote
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
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.btnVote = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlCenter
            // 
            this.pnlCenter.Location = new System.Drawing.Point(48, 50);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(399, 283);
            this.pnlCenter.TabIndex = 0;
            // 
            // btnVote
            // 
            this.btnVote.Location = new System.Drawing.Point(372, 339);
            this.btnVote.Name = "btnVote";
            this.btnVote.Size = new System.Drawing.Size(75, 23);
            this.btnVote.TabIndex = 1;
            this.btnVote.Text = " vote";
            this.btnVote.UseVisualStyleBackColor = true;
            this.btnVote.Click += new System.EventHandler(this.btnVote_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "tree vote";
            // 
            // Vote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 391);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVote);
            this.Controls.Add(this.pnlCenter);
            this.Name = "Vote";
            this.Text = "Vote";
            this.Load += new System.EventHandler(this.Vote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Button btnVote;
        private System.Windows.Forms.Label label1;
    }
}