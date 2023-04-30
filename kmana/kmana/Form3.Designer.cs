namespace kmana
{
    partial class Form3
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
            this.cb_chooseteam = new System.Windows.Forms.ComboBox();
            this.cb_player = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Yellow = new System.Windows.Forms.Label();
            this.lbl_Penalty = new System.Windows.Forms.Label();
            this.lbl_Goal = new System.Windows.Forms.Label();
            this.lbl_Red = new System.Windows.Forms.Label();
            this.playpos = new System.Windows.Forms.Label();
            this.nation = new System.Windows.Forms.Label();
            this.pos = new System.Windows.Forms.Label();
            this.teams = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_chooseteam
            // 
            this.cb_chooseteam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_chooseteam.FormattingEnabled = true;
            this.cb_chooseteam.Location = new System.Drawing.Point(315, 45);
            this.cb_chooseteam.Margin = new System.Windows.Forms.Padding(2);
            this.cb_chooseteam.Name = "cb_chooseteam";
            this.cb_chooseteam.Size = new System.Drawing.Size(155, 24);
            this.cb_chooseteam.TabIndex = 1;
            this.cb_chooseteam.SelectedIndexChanged += new System.EventHandler(this.cb_pilihteam_SelectedIndexChanged);
            // 
            // cb_player
            // 
            this.cb_player.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_player.FormattingEnabled = true;
            this.cb_player.Location = new System.Drawing.Point(521, 45);
            this.cb_player.Margin = new System.Windows.Forms.Padding(2);
            this.cb_player.Name = "cb_player";
            this.cb_player.Size = new System.Drawing.Size(155, 24);
            this.cb_player.TabIndex = 2;
            this.cb_player.SelectedIndexChanged += new System.EventHandler(this.cb_chooseplayer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Team :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.lbl_Yellow);
            this.panel1.Controls.Add(this.lbl_Penalty);
            this.panel1.Controls.Add(this.lbl_Goal);
            this.panel1.Controls.Add(this.lbl_Red);
            this.panel1.Controls.Add(this.playpos);
            this.panel1.Controls.Add(this.nation);
            this.panel1.Controls.Add(this.pos);
            this.panel1.Controls.Add(this.teams);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cb_player);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cb_chooseteam);
            this.panel1.Location = new System.Drawing.Point(8, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 495);
            this.panel1.TabIndex = 6;
            // 
            // lbl_Yellow
            // 
            this.lbl_Yellow.AutoSize = true;
            this.lbl_Yellow.Location = new System.Drawing.Point(679, 158);
            this.lbl_Yellow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Yellow.Name = "lbl_Yellow";
            this.lbl_Yellow.Size = new System.Drawing.Size(14, 16);
            this.lbl_Yellow.TabIndex = 22;
            this.lbl_Yellow.Text = ":)";
            this.lbl_Yellow.Visible = false;
            this.lbl_Yellow.Click += new System.EventHandler(this.labely_Click);
            // 
            // lbl_Penalty
            // 
            this.lbl_Penalty.AutoSize = true;
            this.lbl_Penalty.Location = new System.Drawing.Point(679, 213);
            this.lbl_Penalty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Penalty.Name = "lbl_Penalty";
            this.lbl_Penalty.Size = new System.Drawing.Size(14, 16);
            this.lbl_Penalty.TabIndex = 21;
            this.lbl_Penalty.Text = ":)";
            this.lbl_Penalty.Visible = false;
            // 
            // lbl_Goal
            // 
            this.lbl_Goal.AutoSize = true;
            this.lbl_Goal.Location = new System.Drawing.Point(679, 187);
            this.lbl_Goal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Goal.Name = "lbl_Goal";
            this.lbl_Goal.Size = new System.Drawing.Size(14, 16);
            this.lbl_Goal.TabIndex = 20;
            this.lbl_Goal.Text = ":)";
            this.lbl_Goal.Visible = false;
            // 
            // lbl_Red
            // 
            this.lbl_Red.AutoSize = true;
            this.lbl_Red.Location = new System.Drawing.Point(679, 126);
            this.lbl_Red.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Red.Name = "lbl_Red";
            this.lbl_Red.Size = new System.Drawing.Size(14, 16);
            this.lbl_Red.TabIndex = 19;
            this.lbl_Red.Text = ":)";
            this.lbl_Red.Visible = false;
            // 
            // playpos
            // 
            this.playpos.AutoSize = true;
            this.playpos.Location = new System.Drawing.Point(428, 243);
            this.playpos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playpos.Name = "playpos";
            this.playpos.Size = new System.Drawing.Size(14, 16);
            this.playpos.TabIndex = 18;
            this.playpos.Text = ":)";
            this.playpos.Visible = false;
            // 
            // nation
            // 
            this.nation.AutoSize = true;
            this.nation.Location = new System.Drawing.Point(428, 213);
            this.nation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nation.Name = "nation";
            this.nation.Size = new System.Drawing.Size(14, 16);
            this.nation.TabIndex = 17;
            this.nation.Text = ":)";
            this.nation.Visible = false;
            // 
            // pos
            // 
            this.pos.AutoSize = true;
            this.pos.Location = new System.Drawing.Point(428, 178);
            this.pos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pos.Name = "pos";
            this.pos.Size = new System.Drawing.Size(14, 16);
            this.pos.TabIndex = 16;
            this.pos.Text = ":)";
            this.pos.Visible = false;
            // 
            // teams
            // 
            this.teams.AutoSize = true;
            this.teams.Location = new System.Drawing.Point(428, 147);
            this.teams.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.teams.Name = "teams";
            this.teams.Size = new System.Drawing.Size(14, 16);
            this.teams.TabIndex = 15;
            this.teams.Text = ":)";
            this.teams.Visible = false;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(428, 111);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(14, 16);
            this.name.TabIndex = 14;
            this.name.Text = ":)";
            this.name.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(538, 158);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Yellow Cards :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(538, 187);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Goal Scored :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(538, 126);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Red Cards :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 243);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Playing Pos :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nationality :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Position :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Player Team :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Player Name :";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1019, 554);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_chooseteam;
        private System.Windows.Forms.ComboBox cb_player;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Yellow;
        private System.Windows.Forms.Label lbl_Penalty;
        private System.Windows.Forms.Label lbl_Goal;
        private System.Windows.Forms.Label lbl_Red;
        private System.Windows.Forms.Label playpos;
        private System.Windows.Forms.Label nation;
        private System.Windows.Forms.Label pos;
        private System.Windows.Forms.Label teams;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;

    }

}