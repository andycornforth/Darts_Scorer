namespace DartsScorerWinForms
{
    partial class MatchForm
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
            this.numberPadPanel = new System.Windows.Forms.Panel();
            this.matchScorePanel = new System.Windows.Forms.Panel();
            this.legScorePanel = new System.Windows.Forms.Panel();
            this.legPastScoresPanel = new System.Windows.Forms.Panel();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // numberPadPanel
            // 
            this.numberPadPanel.BackColor = System.Drawing.Color.Black;
            this.numberPadPanel.Location = new System.Drawing.Point(12, 12);
            this.numberPadPanel.Name = "numberPadPanel";
            this.numberPadPanel.Size = new System.Drawing.Size(337, 348);
            this.numberPadPanel.TabIndex = 0;
            // 
            // matchScorePanel
            // 
            this.matchScorePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.matchScorePanel.Location = new System.Drawing.Point(365, 12);
            this.matchScorePanel.Name = "matchScorePanel";
            this.matchScorePanel.Size = new System.Drawing.Size(407, 64);
            this.matchScorePanel.TabIndex = 2;
            // 
            // legScorePanel
            // 
            this.legScorePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.legScorePanel.Location = new System.Drawing.Point(365, 82);
            this.legScorePanel.Name = "legScorePanel";
            this.legScorePanel.Size = new System.Drawing.Size(407, 64);
            this.legScorePanel.TabIndex = 3;
            // 
            // legPastScoresPanel
            // 
            this.legPastScoresPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.legPastScoresPanel.Location = new System.Drawing.Point(383, 152);
            this.legPastScoresPanel.Name = "legPastScoresPanel";
            this.legPastScoresPanel.Size = new System.Drawing.Size(368, 208);
            this.legPastScoresPanel.TabIndex = 4;
            // 
            // statsPanel
            // 
            this.statsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statsPanel.Location = new System.Drawing.Point(12, 366);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(537, 137);
            this.statsPanel.TabIndex = 4;
            // 
            // MatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 513);
            this.Controls.Add(this.statsPanel);
            this.Controls.Add(this.legPastScoresPanel);
            this.Controls.Add(this.legScorePanel);
            this.Controls.Add(this.matchScorePanel);
            this.Controls.Add(this.numberPadPanel);
            this.Name = "MatchForm";
            this.Text = "Darts Scorer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel numberPadPanel;
        private System.Windows.Forms.Panel matchScorePanel;
        private System.Windows.Forms.Panel legScorePanel;
        private System.Windows.Forms.Panel legPastScoresPanel;
        private System.Windows.Forms.Panel statsPanel;
    }
}