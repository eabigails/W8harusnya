using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kmana
{
    public partial class Form3 : Form
    {

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter SQLAdapter;
        string connectionString;
        string sqlQuery;

        DataTable dataPlayer = new DataTable();
        DataTable dataMatch = new DataTable();
        DataTable dataCountry = new DataTable();
        DataTable cardss = new DataTable();



        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            connectionString = "server=localhost;uid=root;pwd=ujinujin;database=premier_league";
            sqlConnect = new MySqlConnection(connectionString);
            sqlConnect.Open();

            sqlQuery = "select team_name as 'nama team',team_id as 'id team' from team ;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SQLAdapter = new MySqlDataAdapter(sqlCommand);
            SQLAdapter.Fill(dataPlayer);
            cb_chooseteam.DataSource = dataPlayer;
            cb_chooseteam.DisplayMember = "nama team";
            cb_chooseteam.ValueMember = "id team";
        }



        private void cb_pilihteam_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataMatch = new DataTable();
            sqlQuery = $"select player_name as 'nama player' from player p where p.team_id = '{cb_chooseteam.SelectedValue.ToString()}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SQLAdapter = new MySqlDataAdapter(sqlCommand);
            SQLAdapter.Fill(dataMatch);
            cb_player.DataSource = dataMatch;
            cb_player.DisplayMember = "nama player";
        }


  

        private void cb_chooseplayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataCountry = new DataTable();
            string save = cb_player.GetItemText(cb_player.SelectedItem).ToString();
            string saveteam = cb_chooseteam.GetItemText(cb_chooseteam.SelectedItem).ToString();
            sqlQuery = $"select player_name as 'nama player', team_name as 'nama team', nation as 'nationality',playing_pos as 'playing pos',team_number as 'squad number' from player p,nationality n,dmatch d,team t where player_name = '{save}' and team_name = '{saveteam}' and p.nationality_id = n.nationality_id;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SQLAdapter = new MySqlDataAdapter(sqlCommand);
            SQLAdapter.Fill(dataCountry);
            name.Visible = true;
            teams.Visible = true;
            pos.Visible = true;
            nation.Visible = true;
            playpos.Visible = true;
            name.Text = dataCountry.Rows[0][0].ToString();
            teams.Text = dataCountry.Rows[0][1].ToString();
            pos.Text = dataCountry.Rows[0][2].ToString();
            nation.Text = dataCountry.Rows[0][3].ToString();
            playpos.Text = dataCountry.Rows[0][4].ToString();
            cards();
        }

        private void cards()
        {
            int yellow = 0;
            int red = 0;
            int goal = 0;
            int pm = 0;
            cardss = new DataTable();
            string save = cb_player.GetItemText(cb_player.SelectedItem).ToString();
            sqlQuery = $"select `type` as 'Cards' from dmatch d, player p where d.player_id = p.player_id and p.player_name = '{save}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SQLAdapter = new MySqlDataAdapter(sqlCommand);
            SQLAdapter.Fill(cardss);
            for (int i = 0; i < cardss.Rows.Count; i++)
            {
                if (cardss.Rows[i][0].ToString() == "CY")
                {
                    yellow++;
                }
                if (cardss.Rows[i][0].ToString() == "CR")
                {
                    red++;
                }
                if (cardss.Rows[i][0].ToString() == "GO")
                {
                    goal++;
                }

                if (cardss.Rows[i][0].ToString() == "PM")
                {
                    pm++;
                }

            }
            lbl_Yellow.Visible = true;
            lbl_Red.Visible = true;
            lbl_Goal.Visible = true;
            lbl_Penalty.Visible = true;
            lbl_Yellow.Text = yellow.ToString();
            lbl_Red.Text = red.ToString();
            lbl_Goal.Text = goal.ToString();
            lbl_Penalty.Text = pm.ToString();

        }

        private void labely_Click(object sender, EventArgs e)
        {

        }


    }
}
