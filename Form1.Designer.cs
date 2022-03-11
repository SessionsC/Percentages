namespace Percentages
{
    partial class MainMenu
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
            this.Playbutton = new System.Windows.Forms.Button();
            this.Leaderboard = new System.Windows.Forms.Button();
            this.lblleader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Playbutton
            // 
            this.Playbutton.Location = new System.Drawing.Point(331, 204);
            this.Playbutton.Name = "Playbutton";
            this.Playbutton.Size = new System.Drawing.Size(142, 55);
            this.Playbutton.TabIndex = 0;
            this.Playbutton.Text = "Play with Percents";
            this.Playbutton.UseVisualStyleBackColor = true;
            this.Playbutton.Click += new System.EventHandler(this.LoadGame);
            // 
            // Leaderboard
            // 
            this.Leaderboard.Location = new System.Drawing.Point(331, 277);
            this.Leaderboard.Name = "Leaderboard";
            this.Leaderboard.Size = new System.Drawing.Size(142, 57);
            this.Leaderboard.TabIndex = 1;
            this.Leaderboard.Text = "Leaderboard";
            this.Leaderboard.UseVisualStyleBackColor = true;
            this.Leaderboard.Click += new System.EventHandler(this.LoadLeaderBoard);
            // 
            // lblleader
            // 
            this.lblleader.AutoSize = true;
            this.lblleader.Location = new System.Drawing.Point(328, 353);
            this.lblleader.Name = "lblleader";
            this.lblleader.Size = new System.Drawing.Size(167, 13);
            this.lblleader.TabIndex = 3;
            this.lblleader.Text = "Use this to view the top 10 scores";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.lblleader);
            this.Controls.Add(this.Leaderboard);
            this.Controls.Add(this.Playbutton);
            this.Name = "MainMenu";
            this.Text = "Percents";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Playbutton;
        private System.Windows.Forms.Button Leaderboard;
        private System.Windows.Forms.Label lblleader;
    }
}

