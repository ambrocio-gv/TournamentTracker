namespace TrackerUI
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TeamName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combobox_SelectTeamMember = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AddTeamMember = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Cellphone = new System.Windows.Forms.TextBox();
            this.Cellphone = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.Label();
            this.listbox_TeamMembersListBox = new System.Windows.Forms.ListBox();
            this.btn_DeleteSelected = new System.Windows.Forms.Button();
            this.btn_CreateTeam = new System.Windows.Forms.Button();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Create Team";
            // 
            // txt_TeamName
            // 
            this.txt_TeamName.ForeColor = System.Drawing.Color.Teal;
            this.txt_TeamName.Location = new System.Drawing.Point(32, 79);
            this.txt_TeamName.Name = "txt_TeamName";
            this.txt_TeamName.Size = new System.Drawing.Size(263, 35);
            this.txt_TeamName.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(27, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 30);
            this.label4.TabIndex = 11;
            this.label4.Text = "Team Name";
            // 
            // combobox_SelectTeamMember
            // 
            this.combobox_SelectTeamMember.ForeColor = System.Drawing.Color.Teal;
            this.combobox_SelectTeamMember.FormattingEnabled = true;
            this.combobox_SelectTeamMember.Location = new System.Drawing.Point(32, 159);
            this.combobox_SelectTeamMember.Name = "combobox_SelectTeamMember";
            this.combobox_SelectTeamMember.Size = new System.Drawing.Size(263, 38);
            this.combobox_SelectTeamMember.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(27, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "Select Team Member";
            // 
            // btn_AddTeamMember
            // 
            this.btn_AddTeamMember.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_AddTeamMember.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_AddTeamMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_AddTeamMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_AddTeamMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddTeamMember.ForeColor = System.Drawing.Color.Teal;
            this.btn_AddTeamMember.Location = new System.Drawing.Point(79, 203);
            this.btn_AddTeamMember.Name = "btn_AddTeamMember";
            this.btn_AddTeamMember.Size = new System.Drawing.Size(155, 40);
            this.btn_AddTeamMember.TabIndex = 15;
            this.btn_AddTeamMember.Text = "Add Member";
            this.btn_AddTeamMember.UseVisualStyleBackColor = false;
            this.btn_AddTeamMember.Click += new System.EventHandler(this.btn_AddTeamMember_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Cellphone);
            this.groupBox1.Controls.Add(this.Cellphone);
            this.groupBox1.Controls.Add(this.txt_Email);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.txt_LastName);
            this.groupBox1.Controls.Add(this.LastName);
            this.groupBox1.Controls.Add(this.txt_FirstName);
            this.groupBox1.Controls.Add(this.FirstName);
            this.groupBox1.Location = new System.Drawing.Point(19, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 234);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Member";
            // 
            // txt_Cellphone
            // 
            this.txt_Cellphone.ForeColor = System.Drawing.Color.Teal;
            this.txt_Cellphone.Location = new System.Drawing.Point(143, 174);
            this.txt_Cellphone.Name = "txt_Cellphone";
            this.txt_Cellphone.Size = new System.Drawing.Size(236, 35);
            this.txt_Cellphone.TabIndex = 16;
            // 
            // Cellphone
            // 
            this.Cellphone.AutoSize = true;
            this.Cellphone.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cellphone.ForeColor = System.Drawing.Color.Teal;
            this.Cellphone.Location = new System.Drawing.Point(17, 174);
            this.Cellphone.Name = "Cellphone";
            this.Cellphone.Size = new System.Drawing.Size(115, 30);
            this.Cellphone.TabIndex = 15;
            this.Cellphone.Text = "Cellphone";
            // 
            // txt_Email
            // 
            this.txt_Email.ForeColor = System.Drawing.Color.Teal;
            this.txt_Email.Location = new System.Drawing.Point(143, 130);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(236, 35);
            this.txt_Email.TabIndex = 14;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.Teal;
            this.Email.Location = new System.Drawing.Point(18, 133);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(66, 30);
            this.Email.TabIndex = 13;
            this.Email.Text = "Email";
            // 
            // txt_LastName
            // 
            this.txt_LastName.ForeColor = System.Drawing.Color.Teal;
            this.txt_LastName.Location = new System.Drawing.Point(143, 89);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(236, 35);
            this.txt_LastName.TabIndex = 12;
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.ForeColor = System.Drawing.Color.Teal;
            this.LastName.Location = new System.Drawing.Point(17, 89);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(117, 30);
            this.LastName.TabIndex = 11;
            this.LastName.Text = "Last Name";
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.ForeColor = System.Drawing.Color.Teal;
            this.txt_FirstName.Location = new System.Drawing.Point(144, 45);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(236, 35);
            this.txt_FirstName.TabIndex = 10;
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.ForeColor = System.Drawing.Color.Teal;
            this.FirstName.Location = new System.Drawing.Point(18, 45);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(120, 30);
            this.FirstName.TabIndex = 9;
            this.FirstName.Text = "First Name";
            // 
            // listbox_TeamMembersListBox
            // 
            this.listbox_TeamMembersListBox.FormattingEnabled = true;
            this.listbox_TeamMembersListBox.ItemHeight = 30;
            this.listbox_TeamMembersListBox.Location = new System.Drawing.Point(423, 4);
            this.listbox_TeamMembersListBox.Name = "listbox_TeamMembersListBox";
            this.listbox_TeamMembersListBox.Size = new System.Drawing.Size(313, 364);
            this.listbox_TeamMembersListBox.TabIndex = 17;
            // 
            // btn_DeleteSelected
            // 
            this.btn_DeleteSelected.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_DeleteSelected.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_DeleteSelected.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_DeleteSelected.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_DeleteSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteSelected.ForeColor = System.Drawing.Color.Teal;
            this.btn_DeleteSelected.Location = new System.Drawing.Point(498, 383);
            this.btn_DeleteSelected.Name = "btn_DeleteSelected";
            this.btn_DeleteSelected.Size = new System.Drawing.Size(215, 40);
            this.btn_DeleteSelected.TabIndex = 18;
            this.btn_DeleteSelected.Text = "Delete Selected";
            this.btn_DeleteSelected.UseVisualStyleBackColor = false;
            this.btn_DeleteSelected.Click += new System.EventHandler(this.btn_DeleteSelected_Click);
            // 
            // btn_CreateTeam
            // 
            this.btn_CreateTeam.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_CreateTeam.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_CreateTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_CreateTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_CreateTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateTeam.ForeColor = System.Drawing.Color.Teal;
            this.btn_CreateTeam.Location = new System.Drawing.Point(498, 506);
            this.btn_CreateTeam.Name = "btn_CreateTeam";
            this.btn_CreateTeam.Size = new System.Drawing.Size(215, 60);
            this.btn_CreateTeam.TabIndex = 19;
            this.btn_CreateTeam.Text = "Create Team";
            this.btn_CreateTeam.UseVisualStyleBackColor = false;
            this.btn_CreateTeam.Click += new System.EventHandler(this.btn_CreateTeam_Click);
            // 
            // createMemberButton
            // 
            this.createMemberButton.BackColor = System.Drawing.Color.Gainsboro;
            this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberButton.ForeColor = System.Drawing.Color.Teal;
            this.createMemberButton.Location = new System.Drawing.Point(93, 516);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(155, 40);
            this.createMemberButton.TabIndex = 20;
            this.createMemberButton.Text = "Add Member";
            this.createMemberButton.UseVisualStyleBackColor = false;
            this.createMemberButton.Click += new System.EventHandler(this.createMemberButton_Click);
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(771, 594);
            this.Controls.Add(this.createMemberButton);
            this.Controls.Add(this.btn_CreateTeam);
            this.Controls.Add(this.btn_DeleteSelected);
            this.Controls.Add(this.listbox_TeamMembersListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_AddTeamMember);
            this.Controls.Add(this.combobox_SelectTeamMember);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TeamName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TeamName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combobox_SelectTeamMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AddTeamMember;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Cellphone;
        private System.Windows.Forms.Label Cellphone;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.ListBox listbox_TeamMembersListBox;
        private System.Windows.Forms.Button btn_DeleteSelected;
        private System.Windows.Forms.Button btn_CreateTeam;
        private System.Windows.Forms.Button createMemberButton;
    }
}