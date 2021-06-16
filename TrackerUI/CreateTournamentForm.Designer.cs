namespace TrackerUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TournamentName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combobox_SelectTeam = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_EntryFee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linklabel_CreateNewTeam = new System.Windows.Forms.LinkLabel();
            this.btn_AddTeam = new System.Windows.Forms.Button();
            this.btn_CreatePrize = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listbox_PlayerList = new System.Windows.Forms.ListBox();
            this.btn_DeleteSelectedPlayer = new System.Windows.Forms.Button();
            this.btn_DeleteSelectedPrize = new System.Windows.Forms.Button();
            this.listbox_PrizeList = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_CreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create Tournament";
            // 
            // txt_TournamentName
            // 
            this.txt_TournamentName.ForeColor = System.Drawing.Color.Teal;
            this.txt_TournamentName.Location = new System.Drawing.Point(55, 122);
            this.txt_TournamentName.Name = "txt_TournamentName";
            this.txt_TournamentName.Size = new System.Drawing.Size(263, 35);
            this.txt_TournamentName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(50, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tournament Name";
            // 
            // combobox_SelectTeam
            // 
            this.combobox_SelectTeam.ForeColor = System.Drawing.Color.Teal;
            this.combobox_SelectTeam.FormattingEnabled = true;
            this.combobox_SelectTeam.Location = new System.Drawing.Point(55, 291);
            this.combobox_SelectTeam.Name = "combobox_SelectTeam";
            this.combobox_SelectTeam.Size = new System.Drawing.Size(263, 38);
            this.combobox_SelectTeam.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(50, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select Team";
            // 
            // txt_EntryFee
            // 
            this.txt_EntryFee.ForeColor = System.Drawing.Color.Teal;
            this.txt_EntryFee.Location = new System.Drawing.Point(176, 181);
            this.txt_EntryFee.Name = "txt_EntryFee";
            this.txt_EntryFee.Size = new System.Drawing.Size(100, 35);
            this.txt_EntryFee.TabIndex = 14;
            this.txt_EntryFee.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(48, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "Entry Fee";
            // 
            // linklabel_CreateNewTeam
            // 
            this.linklabel_CreateNewTeam.AutoSize = true;
            this.linklabel_CreateNewTeam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklabel_CreateNewTeam.Location = new System.Drawing.Point(187, 254);
            this.linklabel_CreateNewTeam.Name = "linklabel_CreateNewTeam";
            this.linklabel_CreateNewTeam.Size = new System.Drawing.Size(131, 21);
            this.linklabel_CreateNewTeam.TabIndex = 15;
            this.linklabel_CreateNewTeam.TabStop = true;
            this.linklabel_CreateNewTeam.Text = "Create New Team";
            this.linklabel_CreateNewTeam.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabel_CreateNewTeam_LinkClicked);
            // 
            // btn_AddTeam
            // 
            this.btn_AddTeam.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_AddTeam.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_AddTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_AddTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_AddTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddTeam.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddTeam.ForeColor = System.Drawing.Color.Teal;
            this.btn_AddTeam.Location = new System.Drawing.Point(125, 349);
            this.btn_AddTeam.Name = "btn_AddTeam";
            this.btn_AddTeam.Size = new System.Drawing.Size(123, 39);
            this.btn_AddTeam.TabIndex = 16;
            this.btn_AddTeam.Text = "Add Team";
            this.btn_AddTeam.UseVisualStyleBackColor = false;
            this.btn_AddTeam.Click += new System.EventHandler(this.btn_AddTeam_Click);
            // 
            // btn_CreatePrize
            // 
            this.btn_CreatePrize.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_CreatePrize.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_CreatePrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_CreatePrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_CreatePrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreatePrize.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreatePrize.ForeColor = System.Drawing.Color.Teal;
            this.btn_CreatePrize.Location = new System.Drawing.Point(100, 407);
            this.btn_CreatePrize.Name = "btn_CreatePrize";
            this.btn_CreatePrize.Size = new System.Drawing.Size(167, 37);
            this.btn_CreatePrize.TabIndex = 17;
            this.btn_CreatePrize.Text = "Create Prize";
            this.btn_CreatePrize.UseVisualStyleBackColor = false;
            this.btn_CreatePrize.Click += new System.EventHandler(this.btn_CreatePrize_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(364, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 30);
            this.label5.TabIndex = 18;
            this.label5.Text = "Teams / Players";
            // 
            // listbox_PlayerList
            // 
            this.listbox_PlayerList.ForeColor = System.Drawing.Color.Teal;
            this.listbox_PlayerList.FormattingEnabled = true;
            this.listbox_PlayerList.ItemHeight = 30;
            this.listbox_PlayerList.Location = new System.Drawing.Point(369, 76);
            this.listbox_PlayerList.Name = "listbox_PlayerList";
            this.listbox_PlayerList.Size = new System.Drawing.Size(265, 124);
            this.listbox_PlayerList.TabIndex = 19;
            // 
            // btn_DeleteSelectedPlayer
            // 
            this.btn_DeleteSelectedPlayer.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_DeleteSelectedPlayer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_DeleteSelectedPlayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_DeleteSelectedPlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_DeleteSelectedPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteSelectedPlayer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteSelectedPlayer.ForeColor = System.Drawing.Color.Teal;
            this.btn_DeleteSelectedPlayer.Location = new System.Drawing.Point(666, 76);
            this.btn_DeleteSelectedPlayer.Name = "btn_DeleteSelectedPlayer";
            this.btn_DeleteSelectedPlayer.Size = new System.Drawing.Size(121, 55);
            this.btn_DeleteSelectedPlayer.TabIndex = 20;
            this.btn_DeleteSelectedPlayer.Text = "Delete Selected";
            this.btn_DeleteSelectedPlayer.UseVisualStyleBackColor = false;
            this.btn_DeleteSelectedPlayer.Click += new System.EventHandler(this.btn_DeleteSelectedPlayer_Click);
            // 
            // btn_DeleteSelectedPrize
            // 
            this.btn_DeleteSelectedPrize.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_DeleteSelectedPrize.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_DeleteSelectedPrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_DeleteSelectedPrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_DeleteSelectedPrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteSelectedPrize.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteSelectedPrize.ForeColor = System.Drawing.Color.Teal;
            this.btn_DeleteSelectedPrize.Location = new System.Drawing.Point(666, 253);
            this.btn_DeleteSelectedPrize.Name = "btn_DeleteSelectedPrize";
            this.btn_DeleteSelectedPrize.Size = new System.Drawing.Size(121, 56);
            this.btn_DeleteSelectedPrize.TabIndex = 23;
            this.btn_DeleteSelectedPrize.Text = "Delete Selected";
            this.btn_DeleteSelectedPrize.UseVisualStyleBackColor = false;
            this.btn_DeleteSelectedPrize.Click += new System.EventHandler(this.btn_DeleteSelectedPrize_Click);
            // 
            // listbox_PrizeList
            // 
            this.listbox_PrizeList.ForeColor = System.Drawing.Color.Teal;
            this.listbox_PrizeList.FormattingEnabled = true;
            this.listbox_PrizeList.ItemHeight = 30;
            this.listbox_PrizeList.Location = new System.Drawing.Point(369, 253);
            this.listbox_PrizeList.Name = "listbox_PrizeList";
            this.listbox_PrizeList.Size = new System.Drawing.Size(265, 124);
            this.listbox_PrizeList.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(364, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 30);
            this.label6.TabIndex = 21;
            this.label6.Text = "Prizes";
            // 
            // btn_CreateTournament
            // 
            this.btn_CreateTournament.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_CreateTournament.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_CreateTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_CreateTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_CreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateTournament.ForeColor = System.Drawing.Color.Teal;
            this.btn_CreateTournament.Location = new System.Drawing.Point(408, 398);
            this.btn_CreateTournament.Name = "btn_CreateTournament";
            this.btn_CreateTournament.Size = new System.Drawing.Size(226, 48);
            this.btn_CreateTournament.TabIndex = 24;
            this.btn_CreateTournament.Text = "Create Tournament";
            this.btn_CreateTournament.UseVisualStyleBackColor = false;
            this.btn_CreateTournament.Click += new System.EventHandler(this.btn_CreateTournament_Click);
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 494);
            this.Controls.Add(this.btn_CreateTournament);
            this.Controls.Add(this.btn_DeleteSelectedPrize);
            this.Controls.Add(this.listbox_PrizeList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_DeleteSelectedPlayer);
            this.Controls.Add(this.listbox_PlayerList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_CreatePrize);
            this.Controls.Add(this.btn_AddTeam);
            this.Controls.Add(this.linklabel_CreateNewTeam);
            this.Controls.Add(this.txt_EntryFee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combobox_SelectTeam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TournamentName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TournamentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combobox_SelectTeam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_EntryFee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linklabel_CreateNewTeam;
        private System.Windows.Forms.Button btn_AddTeam;
        private System.Windows.Forms.Button btn_CreatePrize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listbox_PlayerList;
        private System.Windows.Forms.Button btn_DeleteSelectedPlayer;
        private System.Windows.Forms.Button btn_DeleteSelectedPrize;
        private System.Windows.Forms.ListBox listbox_PrizeList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_CreateTournament;
    }
}