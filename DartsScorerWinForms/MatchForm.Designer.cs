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
            this.matchPlayer2ScoreLabel = new System.Windows.Forms.Label();
            this.matchPlayer1ScoreLabel = new System.Windows.Forms.Label();
            this.matchPlayer2NameLabel = new System.Windows.Forms.Label();
            this.matchPlayer1NameLabel = new System.Windows.Forms.Label();
            this.legScorePanel = new System.Windows.Forms.Panel();
            this.legPastScoresPanel = new System.Windows.Forms.Panel();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.legPlayer2NameLabel = new System.Windows.Forms.Label();
            this.legPlayer1NameLabel = new System.Windows.Forms.Label();
            this.legPlayer1ScoreLabel = new System.Windows.Forms.Label();
            this.legPlayer2ScoreLabel = new System.Windows.Forms.Label();
            this.matchBestOfLabel = new System.Windows.Forms.Label();
            this.matchScorePanel.SuspendLayout();
            this.legScorePanel.SuspendLayout();
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
            this.matchScorePanel.Controls.Add(this.matchBestOfLabel);
            this.matchScorePanel.Controls.Add(this.matchPlayer2ScoreLabel);
            this.matchScorePanel.Controls.Add(this.matchPlayer1ScoreLabel);
            this.matchScorePanel.Controls.Add(this.matchPlayer2NameLabel);
            this.matchScorePanel.Controls.Add(this.matchPlayer1NameLabel);
            this.matchScorePanel.Location = new System.Drawing.Point(365, 12);
            this.matchScorePanel.Name = "matchScorePanel";
            this.matchScorePanel.Size = new System.Drawing.Size(407, 64);
            this.matchScorePanel.TabIndex = 2;
            // 
            // matchPlayer2ScoreLabel
            // 
            this.matchPlayer2ScoreLabel.AutoSize = true;
            this.matchPlayer2ScoreLabel.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchPlayer2ScoreLabel.Location = new System.Drawing.Point(226, 14);
            this.matchPlayer2ScoreLabel.Name = "matchPlayer2ScoreLabel";
            this.matchPlayer2ScoreLabel.Size = new System.Drawing.Size(26, 31);
            this.matchPlayer2ScoreLabel.TabIndex = 7;
            this.matchPlayer2ScoreLabel.Text = "0";
            // 
            // matchPlayer1ScoreLabel
            // 
            this.matchPlayer1ScoreLabel.AutoSize = true;
            this.matchPlayer1ScoreLabel.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchPlayer1ScoreLabel.Location = new System.Drawing.Point(158, 14);
            this.matchPlayer1ScoreLabel.Name = "matchPlayer1ScoreLabel";
            this.matchPlayer1ScoreLabel.Size = new System.Drawing.Size(26, 31);
            this.matchPlayer1ScoreLabel.TabIndex = 6;
            this.matchPlayer1ScoreLabel.Text = "0";
            // 
            // matchPlayer2NameLabel
            // 
            this.matchPlayer2NameLabel.AutoSize = true;
            this.matchPlayer2NameLabel.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchPlayer2NameLabel.Location = new System.Drawing.Point(265, 14);
            this.matchPlayer2NameLabel.Name = "matchPlayer2NameLabel";
            this.matchPlayer2NameLabel.Size = new System.Drawing.Size(76, 31);
            this.matchPlayer2NameLabel.TabIndex = 5;
            this.matchPlayer2NameLabel.Text = "label1";
            // 
            // matchPlayer1NameLabel
            // 
            this.matchPlayer1NameLabel.AutoSize = true;
            this.matchPlayer1NameLabel.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchPlayer1NameLabel.Location = new System.Drawing.Point(69, 14);
            this.matchPlayer1NameLabel.Name = "matchPlayer1NameLabel";
            this.matchPlayer1NameLabel.Size = new System.Drawing.Size(76, 31);
            this.matchPlayer1NameLabel.TabIndex = 0;
            this.matchPlayer1NameLabel.Text = "label2";
            this.matchPlayer1NameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // legScorePanel
            // 
            this.legScorePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.legScorePanel.Controls.Add(this.legPlayer2ScoreLabel);
            this.legScorePanel.Controls.Add(this.legPlayer1ScoreLabel);
            this.legScorePanel.Controls.Add(this.legPlayer1NameLabel);
            this.legScorePanel.Controls.Add(this.legPlayer2NameLabel);
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
            // legPlayer2NameLabel
            // 
            this.legPlayer2NameLabel.AutoSize = true;
            this.legPlayer2NameLabel.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.legPlayer2NameLabel.Location = new System.Drawing.Point(276, 17);
            this.legPlayer2NameLabel.Name = "legPlayer2NameLabel";
            this.legPlayer2NameLabel.Size = new System.Drawing.Size(76, 31);
            this.legPlayer2NameLabel.TabIndex = 1;
            this.legPlayer2NameLabel.Text = "label2";
            this.legPlayer2NameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // legPlayer1NameLabel
            // 
            this.legPlayer1NameLabel.AutoSize = true;
            this.legPlayer1NameLabel.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.legPlayer1NameLabel.Location = new System.Drawing.Point(53, 17);
            this.legPlayer1NameLabel.Name = "legPlayer1NameLabel";
            this.legPlayer1NameLabel.Size = new System.Drawing.Size(76, 31);
            this.legPlayer1NameLabel.TabIndex = 2;
            this.legPlayer1NameLabel.Text = "label2";
            this.legPlayer1NameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // legPlayer1ScoreLabel
            // 
            this.legPlayer1ScoreLabel.AutoSize = true;
            this.legPlayer1ScoreLabel.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.legPlayer1ScoreLabel.Location = new System.Drawing.Point(152, 17);
            this.legPlayer1ScoreLabel.Name = "legPlayer1ScoreLabel";
            this.legPlayer1ScoreLabel.Size = new System.Drawing.Size(50, 31);
            this.legPlayer1ScoreLabel.TabIndex = 8;
            this.legPlayer1ScoreLabel.Text = "501";
            // 
            // legPlayer2ScoreLabel
            // 
            this.legPlayer2ScoreLabel.AutoSize = true;
            this.legPlayer2ScoreLabel.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.legPlayer2ScoreLabel.Location = new System.Drawing.Point(208, 17);
            this.legPlayer2ScoreLabel.Name = "legPlayer2ScoreLabel";
            this.legPlayer2ScoreLabel.Size = new System.Drawing.Size(50, 31);
            this.legPlayer2ScoreLabel.TabIndex = 9;
            this.legPlayer2ScoreLabel.Text = "501";
            // 
            // matchBestOfLabel
            // 
            this.matchBestOfLabel.AutoSize = true;
            this.matchBestOfLabel.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchBestOfLabel.Location = new System.Drawing.Point(184, 14);
            this.matchBestOfLabel.Name = "matchBestOfLabel";
            this.matchBestOfLabel.Size = new System.Drawing.Size(26, 31);
            this.matchBestOfLabel.TabIndex = 8;
            this.matchBestOfLabel.Text = "s";
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
            this.matchScorePanel.ResumeLayout(false);
            this.matchScorePanel.PerformLayout();
            this.legScorePanel.ResumeLayout(false);
            this.legScorePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel numberPadPanel;
        private System.Windows.Forms.Panel matchScorePanel;
        private System.Windows.Forms.Panel legScorePanel;
        private System.Windows.Forms.Panel legPastScoresPanel;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Label matchPlayer2ScoreLabel;
        private System.Windows.Forms.Label matchPlayer1ScoreLabel;
        private System.Windows.Forms.Label matchPlayer2NameLabel;
        private System.Windows.Forms.Label matchPlayer1NameLabel;
        private System.Windows.Forms.Label legPlayer2ScoreLabel;
        private System.Windows.Forms.Label legPlayer1ScoreLabel;
        private System.Windows.Forms.Label legPlayer1NameLabel;
        private System.Windows.Forms.Label legPlayer2NameLabel;
        private System.Windows.Forms.Label matchBestOfLabel;
    }
}