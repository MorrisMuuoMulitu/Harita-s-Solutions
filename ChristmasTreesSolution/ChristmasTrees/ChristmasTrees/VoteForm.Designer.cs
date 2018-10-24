namespace ChristmasTrees {
    partial class VoteForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnVote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlCenter
            // 
            this.pnlCenter.AutoScroll = true;
            this.pnlCenter.Location = new System.Drawing.Point(24, 53);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(436, 266);
            this.pnlCenter.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a tree for Everyone\'s Christmas tree!";
            // 
            // btnVote
            // 
            this.btnVote.Location = new System.Drawing.Point(199, 345);
            this.btnVote.Name = "btnVote";
            this.btnVote.Size = new System.Drawing.Size(75, 23);
            this.btnVote.TabIndex = 2;
            this.btnVote.Text = "Vote";
            this.btnVote.UseVisualStyleBackColor = true;
            this.btnVote.Click += new System.EventHandler(this.btnVote_Click);
            // 
            // VoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(487, 394);
            this.Controls.Add(this.btnVote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlCenter);
            this.Name = "VoteForm";
            this.Text = "VoteForm";
            this.Load += new System.EventHandler(this.VoteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVote;
    }
}