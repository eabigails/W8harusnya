namespace kmana
{
    partial class Form2
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
            this.dgv_awayteam = new System.Windows.Forms.DataGridView();
            this.dgv_match = new System.Windows.Forms.DataGridView();
            this.panel_form2 = new System.Windows.Forms.Panel();
            this.dgv_hometeam = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_match = new System.Windows.Forms.ComboBox();
            this.cbx_team = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_awayteam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_match)).BeginInit();
            this.panel_form2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hometeam)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_awayteam
            // 
            this.dgv_awayteam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_awayteam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_awayteam.Location = new System.Drawing.Point(654, 60);
            this.dgv_awayteam.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_awayteam.Name = "dgv_awayteam";
            this.dgv_awayteam.RowHeadersVisible = false;
            this.dgv_awayteam.RowHeadersWidth = 82;
            this.dgv_awayteam.RowTemplate.Height = 33;
            this.dgv_awayteam.Size = new System.Drawing.Size(270, 366);
            this.dgv_awayteam.TabIndex = 0;
            // 
            // dgv_match
            // 
            this.dgv_match.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_match.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_match.Location = new System.Drawing.Point(11, 60);
            this.dgv_match.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_match.Name = "dgv_match";
            this.dgv_match.RowHeadersVisible = false;
            this.dgv_match.RowHeadersWidth = 82;
            this.dgv_match.RowTemplate.Height = 33;
            this.dgv_match.Size = new System.Drawing.Size(286, 366);
            this.dgv_match.TabIndex = 1;
            // 
            // panel_form2
            // 
            this.panel_form2.BackColor = System.Drawing.Color.RosyBrown;
            this.panel_form2.Controls.Add(this.label3);
            this.panel_form2.Controls.Add(this.dgv_hometeam);
            this.panel_form2.Controls.Add(this.label2);
            this.panel_form2.Controls.Add(this.label1);
            this.panel_form2.Controls.Add(this.cb_match);
            this.panel_form2.Controls.Add(this.cbx_team);
            this.panel_form2.Controls.Add(this.dgv_match);
            this.panel_form2.Controls.Add(this.dgv_awayteam);
            this.panel_form2.Location = new System.Drawing.Point(8, 20);
            this.panel_form2.Margin = new System.Windows.Forms.Padding(2);
            this.panel_form2.Name = "panel_form2";
            this.panel_form2.Size = new System.Drawing.Size(936, 462);
            this.panel_form2.TabIndex = 2;
            // 
            // dgv_hometeam
            // 
            this.dgv_hometeam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hometeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hometeam.Location = new System.Drawing.Point(331, 60);
            this.dgv_hometeam.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_hometeam.Name = "dgv_hometeam";
            this.dgv_hometeam.RowHeadersVisible = false;
            this.dgv_hometeam.RowHeadersWidth = 82;
            this.dgv_hometeam.RowTemplate.Height = 33;
            this.dgv_hometeam.Size = new System.Drawing.Size(292, 366);
            this.dgv_hometeam.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(827, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Match :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Team :";
            // 
            // cb_match
            // 
            this.cb_match.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_match.FormattingEnabled = true;
            this.cb_match.Location = new System.Drawing.Point(735, 24);
            this.cb_match.Margin = new System.Windows.Forms.Padding(2);
            this.cb_match.Name = "cb_match";
            this.cb_match.Size = new System.Drawing.Size(141, 24);
            this.cb_match.TabIndex = 3;
            this.cb_match.SelectedIndexChanged += new System.EventHandler(this.cb_match_SelectedIndexChanged);
            // 
            // cbx_team
            // 
            this.cbx_team.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_team.FormattingEnabled = true;
            this.cbx_team.Location = new System.Drawing.Point(322, 24);
            this.cbx_team.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_team.Name = "cbx_team";
            this.cbx_team.Size = new System.Drawing.Size(130, 24);
            this.cbx_team.TabIndex = 2;
            this.cbx_team.SelectedIndexChanged += new System.EventHandler(this.cb_team_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Match Details";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 505);
            this.Controls.Add(this.panel_form2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_awayteam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_match)).EndInit();
            this.panel_form2.ResumeLayout(false);
            this.panel_form2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hometeam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_awayteam;
        private System.Windows.Forms.DataGridView dgv_match;
        private System.Windows.Forms.Panel panel_form2;
        private System.Windows.Forms.ComboBox cbx_team;
        private System.Windows.Forms.ComboBox cb_match;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_hometeam;
        private System.Windows.Forms.Label label3;
    }

}