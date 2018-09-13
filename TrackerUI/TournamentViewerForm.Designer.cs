namespace TrackerUI
{
    partial class TournamentViewerForm
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.ddRound = new System.Windows.Forms.ComboBox();
            this.cbUnplayedOnly = new System.Windows.Forms.CheckBox();
            this.lbMatchUp = new System.Windows.Forms.ListBox();
            this.nameTeamOne = new System.Windows.Forms.Label();
            this.lblTeamOneScore = new System.Windows.Forms.Label();
            this.tbTeamOneScoreValue = new System.Windows.Forms.TextBox();
            this.nameTeamTwoScoreText = new System.Windows.Forms.TextBox();
            this.lblTeamTwoScore = new System.Windows.Forms.Label();
            this.nameTeamTwo = new System.Windows.Forms.Label();
            this.lblVS = new System.Windows.Forms.Label();
            this.btnScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblHeader.Location = new System.Drawing.Point(30, 36);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(240, 50);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Tournament:  ";
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tournamentName.Location = new System.Drawing.Point(236, 36);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(150, 50);
            this.tournamentName.TabIndex = 1;
            this.tournamentName.Text = "<none>";
            this.tournamentName.Click += new System.EventHandler(this.tournamentName_Click);
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblRound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblRound.Location = new System.Drawing.Point(32, 99);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(95, 37);
            this.lblRound.TabIndex = 2;
            this.lblRound.Text = "Round";
            // 
            // ddRound
            // 
            this.ddRound.FormattingEnabled = true;
            this.ddRound.Location = new System.Drawing.Point(124, 98);
            this.ddRound.Name = "ddRound";
            this.ddRound.Size = new System.Drawing.Size(243, 38);
            this.ddRound.TabIndex = 3;
            // 
            // cbUnplayedOnly
            // 
            this.cbUnplayedOnly.AutoSize = true;
            this.cbUnplayedOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbUnplayedOnly.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.cbUnplayedOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.cbUnplayedOnly.Location = new System.Drawing.Point(124, 157);
            this.cbUnplayedOnly.Name = "cbUnplayedOnly";
            this.cbUnplayedOnly.Size = new System.Drawing.Size(209, 41);
            this.cbUnplayedOnly.TabIndex = 4;
            this.cbUnplayedOnly.Text = "Unplayed Only";
            this.cbUnplayedOnly.UseVisualStyleBackColor = true;
            // 
            // lbMatchUp
            // 
            this.lbMatchUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMatchUp.FormattingEnabled = true;
            this.lbMatchUp.ItemHeight = 30;
            this.lbMatchUp.Location = new System.Drawing.Point(39, 237);
            this.lbMatchUp.Name = "lbMatchUp";
            this.lbMatchUp.Size = new System.Drawing.Size(328, 242);
            this.lbMatchUp.TabIndex = 5;
            // 
            // nameTeamOne
            // 
            this.nameTeamOne.AutoSize = true;
            this.nameTeamOne.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.nameTeamOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.nameTeamOne.Location = new System.Drawing.Point(392, 237);
            this.nameTeamOne.Name = "nameTeamOne";
            this.nameTeamOne.Size = new System.Drawing.Size(165, 37);
            this.nameTeamOne.TabIndex = 6;
            this.nameTeamOne.Text = "<team one>";
            // 
            // lblTeamOneScore
            // 
            this.lblTeamOneScore.AutoSize = true;
            this.lblTeamOneScore.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblTeamOneScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTeamOneScore.Location = new System.Drawing.Point(392, 283);
            this.lblTeamOneScore.Name = "lblTeamOneScore";
            this.lblTeamOneScore.Size = new System.Drawing.Size(82, 37);
            this.lblTeamOneScore.TabIndex = 7;
            this.lblTeamOneScore.Text = "Score";
            // 
            // tbTeamOneScoreValue
            // 
            this.tbTeamOneScoreValue.Location = new System.Drawing.Point(480, 286);
            this.tbTeamOneScoreValue.Name = "tbTeamOneScoreValue";
            this.tbTeamOneScoreValue.Size = new System.Drawing.Size(100, 35);
            this.tbTeamOneScoreValue.TabIndex = 8;
            // 
            // nameTeamTwoScoreText
            // 
            this.nameTeamTwoScoreText.Location = new System.Drawing.Point(480, 437);
            this.nameTeamTwoScoreText.Name = "nameTeamTwoScoreText";
            this.nameTeamTwoScoreText.Size = new System.Drawing.Size(100, 35);
            this.nameTeamTwoScoreText.TabIndex = 11;
            // 
            // lblTeamTwoScore
            // 
            this.lblTeamTwoScore.AutoSize = true;
            this.lblTeamTwoScore.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblTeamTwoScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTeamTwoScore.Location = new System.Drawing.Point(392, 434);
            this.lblTeamTwoScore.Name = "lblTeamTwoScore";
            this.lblTeamTwoScore.Size = new System.Drawing.Size(82, 37);
            this.lblTeamTwoScore.TabIndex = 10;
            this.lblTeamTwoScore.Text = "Score";
            // 
            // nameTeamTwo
            // 
            this.nameTeamTwo.AutoSize = true;
            this.nameTeamTwo.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.nameTeamTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.nameTeamTwo.Location = new System.Drawing.Point(392, 388);
            this.nameTeamTwo.Name = "nameTeamTwo";
            this.nameTeamTwo.Size = new System.Drawing.Size(165, 37);
            this.nameTeamTwo.TabIndex = 9;
            this.nameTeamTwo.Text = "<team two>";
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblVS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblVS.Location = new System.Drawing.Point(462, 339);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(70, 37);
            this.lblVS.TabIndex = 12;
            this.lblVS.Text = "-VS-";
            this.lblVS.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnScore
            // 
            this.btnScore.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScore.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnScore.Location = new System.Drawing.Point(627, 339);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(109, 37);
            this.btnScore.TabIndex = 13;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(832, 879);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.lblVS);
            this.Controls.Add(this.nameTeamTwoScoreText);
            this.Controls.Add(this.lblTeamTwoScore);
            this.Controls.Add(this.nameTeamTwo);
            this.Controls.Add(this.tbTeamOneScoreValue);
            this.Controls.Add(this.lblTeamOneScore);
            this.Controls.Add(this.nameTeamOne);
            this.Controls.Add(this.lbMatchUp);
            this.Controls.Add(this.cbUnplayedOnly);
            this.Controls.Add(this.ddRound);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.ComboBox ddRound;
        private System.Windows.Forms.CheckBox cbUnplayedOnly;
        private System.Windows.Forms.ListBox lbMatchUp;
        private System.Windows.Forms.Label nameTeamOne;
        private System.Windows.Forms.Label lblTeamOneScore;
        private System.Windows.Forms.TextBox tbTeamOneScoreValue;
        private System.Windows.Forms.TextBox nameTeamTwoScoreText;
        private System.Windows.Forms.Label lblTeamTwoScore;
        private System.Windows.Forms.Label nameTeamTwo;
        private System.Windows.Forms.Label lblVS;
        private System.Windows.Forms.Button btnScore;
    }
}

