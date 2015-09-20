namespace DartsScorerWinForms
{
    partial class StartForm
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
            this.StartButton = new System.Windows.Forms.Button();
            this.player1NameLabel = new System.Windows.Forms.Label();
            this.player2NameLabel = new System.Windows.Forms.Label();
            this.player1NameTextBox = new System.Windows.Forms.TextBox();
            this.player2NameTextBox = new System.Windows.Forms.TextBox();
            this.BestOfLegsLabel = new System.Windows.Forms.Label();
            this.bestOfLegsLabel2 = new System.Windows.Forms.Label();
            this.bestOfNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.bestOfNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(270, 407);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(202, 42);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start New Match";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // player1NameLabel
            // 
            this.player1NameLabel.AutoSize = true;
            this.player1NameLabel.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1NameLabel.Location = new System.Drawing.Point(30, 38);
            this.player1NameLabel.Name = "player1NameLabel";
            this.player1NameLabel.Size = new System.Drawing.Size(171, 31);
            this.player1NameLabel.TabIndex = 1;
            this.player1NameLabel.Text = "Player 1 Name:";
            // 
            // player2NameLabel
            // 
            this.player2NameLabel.AutoSize = true;
            this.player2NameLabel.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2NameLabel.Location = new System.Drawing.Point(30, 95);
            this.player2NameLabel.Name = "player2NameLabel";
            this.player2NameLabel.Size = new System.Drawing.Size(171, 31);
            this.player2NameLabel.TabIndex = 2;
            this.player2NameLabel.Text = "Player 2 Name:";
            // 
            // player1NameTextBox
            // 
            this.player1NameTextBox.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1NameTextBox.Location = new System.Drawing.Point(207, 34);
            this.player1NameTextBox.Name = "player1NameTextBox";
            this.player1NameTextBox.Size = new System.Drawing.Size(212, 38);
            this.player1NameTextBox.TabIndex = 3;
            // 
            // player2NameTextBox
            // 
            this.player2NameTextBox.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2NameTextBox.Location = new System.Drawing.Point(207, 91);
            this.player2NameTextBox.Name = "player2NameTextBox";
            this.player2NameTextBox.Size = new System.Drawing.Size(212, 38);
            this.player2NameTextBox.TabIndex = 4;
            // 
            // BestOfLegsLabel
            // 
            this.BestOfLegsLabel.AutoSize = true;
            this.BestOfLegsLabel.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BestOfLegsLabel.Location = new System.Drawing.Point(90, 169);
            this.BestOfLegsLabel.Name = "BestOfLegsLabel";
            this.BestOfLegsLabel.Size = new System.Drawing.Size(94, 31);
            this.BestOfLegsLabel.TabIndex = 5;
            this.BestOfLegsLabel.Text = "Best of ";
            // 
            // bestOfLegsLabel2
            // 
            this.bestOfLegsLabel2.AutoSize = true;
            this.bestOfLegsLabel2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestOfLegsLabel2.Location = new System.Drawing.Point(235, 169);
            this.bestOfLegsLabel2.Name = "bestOfLegsLabel2";
            this.bestOfLegsLabel2.Size = new System.Drawing.Size(66, 31);
            this.bestOfLegsLabel2.TabIndex = 6;
            this.bestOfLegsLabel2.Text = "Legs";
            // 
            // bestOfNumeric
            // 
            this.bestOfNumeric.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestOfNumeric.Location = new System.Drawing.Point(189, 167);
            this.bestOfNumeric.Name = "bestOfNumeric";
            this.bestOfNumeric.Size = new System.Drawing.Size(40, 38);
            this.bestOfNumeric.TabIndex = 8;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.bestOfNumeric);
            this.Controls.Add(this.bestOfLegsLabel2);
            this.Controls.Add(this.BestOfLegsLabel);
            this.Controls.Add(this.player2NameTextBox);
            this.Controls.Add(this.player1NameTextBox);
            this.Controls.Add(this.player2NameLabel);
            this.Controls.Add(this.player1NameLabel);
            this.Controls.Add(this.StartButton);
            this.Name = "StartForm";
            this.Text = "Darts Scorer";
            ((System.ComponentModel.ISupportInitialize)(this.bestOfNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label player1NameLabel;
        private System.Windows.Forms.Label player2NameLabel;
        private System.Windows.Forms.TextBox player1NameTextBox;
        private System.Windows.Forms.TextBox player2NameTextBox;
        private System.Windows.Forms.Label BestOfLegsLabel;
        private System.Windows.Forms.Label bestOfLegsLabel2;
        private System.Windows.Forms.NumericUpDown bestOfNumeric;
    }
}