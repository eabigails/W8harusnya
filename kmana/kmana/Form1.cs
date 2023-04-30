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
    public partial class Form1 : Form
    {

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter SQLAdapter;
        string connectionString;
        string sqlQuery;

        DataTable dataPlayer = new DataTable();
        DataTable dataMatch = new DataTable();
        DataTable dataCountry = new DataTable();
        DataTable dataKartu = new DataTable();



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectionString = "server=localhost;uid=root;pwd=ujinujin;database=premier_league";
            sqlConnect = new MySqlConnection(connectionString);
            sqlConnect.Open();
           
        }


        private void playerDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Form3 form3 = new Form3();
            form3.Dock = DockStyle.Fill;
            form3.FormBorderStyle = FormBorderStyle.None;
            form3.TopLevel = false;
            panel1.Controls.Clear();
            form3.Show();
            this.panel1.Controls.Add(form3);

        }


     

        private void showMatchDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Form2 form2 = new Form2();
            form2.Dock = DockStyle.Fill;
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.TopLevel = false;
            panel1.Controls.Clear();
            form2.Show();
            this.panel1.Controls.Add(form2);
        }
      

    }
}
