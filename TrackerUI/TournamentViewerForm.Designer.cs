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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_TournamentName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combobox_round = new System.Windows.Forms.ComboBox();
            this.checkbox_UnplayedOnly = new System.Windows.Forms.CheckBox();
            this.listbox_Matchup = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TeamOneScore = new System.Windows.Forms.TextBox();
            this.txt_TeamTwoScore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Score = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tournament :";
            // 
            // lbl_TournamentName
            // 
            this.lbl_TournamentName.AutoSize = true;
            this.lbl_TournamentName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_TournamentName.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TournamentName.ForeColor = System.Drawing.Color.Teal;
            this.lbl_TournamentName.Location = new System.Drawing.Point(184, 24);
            this.lbl_TournamentName.Name = "lbl_TournamentName";
            this.lbl_TournamentName.Size = new System.Drawing.Size(116, 37);
            this.lbl_TournamentName.TabIndex = 1;
            this.lbl_TournamentName.Text = "<none>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(22, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Round";
            // 
            // combobox_round
            // 
            this.combobox_round.ForeColor = System.Drawing.Color.Teal;
            this.combobox_round.FormattingEnabled = true;
            this.combobox_round.Location = new System.Drawing.Point(106, 79);
            this.combobox_round.Name = "combobox_round";
            this.combobox_round.Size = new System.Drawing.Size(179, 38);
            this.combobox_round.TabIndex = 3;
            // 
            // checkbox_UnplayedOnly
            // 
            this.checkbox_UnplayedOnly.AutoSize = true;
            this.checkbox_UnplayedOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkbox_UnplayedOnly.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_UnplayedOnly.ForeColor = System.Drawing.Color.Teal;
            this.checkbox_UnplayedOnly.Location = new System.Drawing.Point(106, 123);
            this.checkbox_UnplayedOnly.Name = "checkbox_UnplayedOnly";
            this.checkbox_UnplayedOnly.Size = new System.Drawing.Size(154, 29);
            this.checkbox_UnplayedOnly.TabIndex = 4;
            this.checkbox_UnplayedOnly.Text = "Unplayed Only";
            this.checkbox_UnplayedOnly.UseVisualStyleBackColor = true;
            // 
            // listbox_Matchup
            // 
            this.listbox_Matchup.ForeColor = System.Drawing.Color.Teal;
            this.listbox_Matchup.FormattingEnabled = true;
            this.listbox_Matchup.ItemHeight = 30;
            this.listbox_Matchup.Location = new System.Drawing.Point(27, 169);
            this.listbox_Matchup.Name = "listbox_Matchup";
            this.listbox_Matchup.Size = new System.Drawing.Size(258, 214);
            this.listbox_Matchup.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(390, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "<team one>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(390, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Score";
            // 
            // txt_TeamOneScore
            // 
            this.txt_TeamOneScore.ForeColor = System.Drawing.Color.Teal;
            this.txt_TeamOneScore.Location = new System.Drawing.Point(464, 182);
            this.txt_TeamOneScore.Name = "txt_TeamOneScore";
            this.txt_TeamOneScore.Size = new System.Drawing.Size(100, 35);
            this.txt_TeamOneScore.TabIndex = 8;
            // 
            // txt_TeamTwoScore
            // 
            this.txt_TeamTwoScore.ForeColor = System.Drawing.Color.Teal;
            this.txt_TeamTwoScore.Location = new System.Drawing.Point(464, 326);
            this.txt_TeamTwoScore.Name = "txt_TeamTwoScore";
            this.txt_TeamTwoScore.Size = new System.Drawing.Size(100, 35);
            this.txt_TeamTwoScore.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(390, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Score";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(390, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 30);
            this.label6.TabIndex = 12;
            this.label6.Text = "<team two>";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(447, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 30);
            this.label7.TabIndex = 13;
            this.label7.Text = "-VS-";
            // 
            // btn_Score
            // 
            this.btn_Score.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Score.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Score.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_Score.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_Score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Score.ForeColor = System.Drawing.Color.Teal;
            this.btn_Score.Location = new System.Drawing.Point(588, 244);
            this.btn_Score.Name = "btn_Score";
            this.btn_Score.Size = new System.Drawing.Size(111, 66);
            this.btn_Score.TabIndex = 14;
            this.btn_Score.Text = "Score";
            this.btn_Score.UseVisualStyleBackColor = false;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(726, 445);
            this.Controls.Add(this.btn_Score);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_TeamTwoScore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_TeamOneScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listbox_Matchup);
            this.Controls.Add(this.checkbox_UnplayedOnly);
            this.Controls.Add(this.combobox_round);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_TournamentName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_TournamentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combobox_round;
        private System.Windows.Forms.CheckBox checkbox_UnplayedOnly;
        private System.Windows.Forms.ListBox listbox_Matchup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TeamOneScore;
        private System.Windows.Forms.TextBox txt_TeamTwoScore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Score;
    }
}

