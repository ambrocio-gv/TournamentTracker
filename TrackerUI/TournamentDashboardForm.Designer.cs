namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            this.label1 = new System.Windows.Forms.Label();
            this.combobox_LoadTournament = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_LoadTournament = new System.Windows.Forms.Button();
            this.btn_CreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(91, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "TournamentDashboard";
            // 
            // combobox_LoadTournament
            // 
            this.combobox_LoadTournament.ForeColor = System.Drawing.Color.Teal;
            this.combobox_LoadTournament.FormattingEnabled = true;
            this.combobox_LoadTournament.Location = new System.Drawing.Point(72, 111);
            this.combobox_LoadTournament.Name = "combobox_LoadTournament";
            this.combobox_LoadTournament.Size = new System.Drawing.Size(328, 38);
            this.combobox_LoadTournament.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(101, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Load Existing Tournament";
            // 
            // btn_LoadTournament
            // 
            this.btn_LoadTournament.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_LoadTournament.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_LoadTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_LoadTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_LoadTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadTournament.ForeColor = System.Drawing.Color.Teal;
            this.btn_LoadTournament.Location = new System.Drawing.Point(124, 174);
            this.btn_LoadTournament.Name = "btn_LoadTournament";
            this.btn_LoadTournament.Size = new System.Drawing.Size(224, 53);
            this.btn_LoadTournament.TabIndex = 27;
            this.btn_LoadTournament.Text = "Load Tournament";
            this.btn_LoadTournament.UseVisualStyleBackColor = false;
            // 
            // btn_CreateTournament
            // 
            this.btn_CreateTournament.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_CreateTournament.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_CreateTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_CreateTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_CreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateTournament.ForeColor = System.Drawing.Color.Teal;
            this.btn_CreateTournament.Location = new System.Drawing.Point(93, 244);
            this.btn_CreateTournament.Name = "btn_CreateTournament";
            this.btn_CreateTournament.Size = new System.Drawing.Size(286, 70);
            this.btn_CreateTournament.TabIndex = 28;
            this.btn_CreateTournament.Text = "Create Tournament";
            this.btn_CreateTournament.UseVisualStyleBackColor = false;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(526, 362);
            this.Controls.Add(this.btn_CreateTournament);
            this.Controls.Add(this.btn_LoadTournament);
            this.Controls.Add(this.combobox_LoadTournament);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentDashboardForm";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combobox_LoadTournament;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_LoadTournament;
        private System.Windows.Forms.Button btn_CreateTournament;
    }
}