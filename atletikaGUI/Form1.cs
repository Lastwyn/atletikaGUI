using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace atletikaGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "atletikavb2017";
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);

            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT versenyekszamok.Versenyszam FROM versenyekszamok";
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        versenyszamok versenyszamok = new versenyszamok(dr.GetString("versenyszam"));
                        listBox1_versenyszam.Items.Add(versenyszamok);
                    }

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll!");
                Environment.Exit(0);
            }
        }
    

        private void btn_aranykeres_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "atletikavb2017";
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);

            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT DISTINCT nemzetek.Nemzet FROM nemzetek JOIN versenyekszamok ON nemzetek.NemzetId = versenyekszamok.NemzetKod WHERE versenyekszamok.Helyezes LIKE 1 ";
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        aranynemzet aranynemzet = new aranynemzet(dr.GetString("nemzet"));
                        listBox1_kiiratas.Items.Add(aranynemzet);
                    }

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll!");
                Environment.Exit(0);
            }
            btn_aranykeres.Visible = false;
        }

        private void listBox1_kiiratas_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            aranynemzet kivalasztottorszag = (aranynemzet)listBox1_versenyszam.SelectedItem;
        }

        private void listBox1_versenyszam_SelectedIndexChanged(object sender, EventArgs e)
        {
            versenyszamok kivalasztottversenyszam = (versenyszamok)listBox1_versenyszam.SelectedItem;
        }

        private void btn_keres_Click(object sender, EventArgs e)
        {

            if (listBox1_kiiratas.SelectedIndex < 0)
            {
                MessageBox.Show(Environment.NewLine + "Nem választotta ki a nemzetet!");
                return;
            }
            if (listBox1_versenyszam.SelectedIndex < 0)
            {
                MessageBox.Show(Environment.NewLine + "Nem választotta ki a versenyszámot!");
                return;
            }
            if (!(numericUpDown1.Value < 4 && numericUpDown1.Value > 0)) 
            {
                MessageBox.Show(Environment.NewLine + "Csak érmes helyezéseket tartalmaz a statisztika!");
                return;
            }

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "atletikavb2017";
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);

            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = $"SELECT Nemzet, VersenyzoNev, Eredmeny FROM nemzetek JOIN versenyekszamok ON NemzetId WHERE Nemzet = '{listBox1_kiiratas.Text}' AND Versenyszam = '{listBox1_versenyszam.Text}' AND Helyezes = '{numericUpDown1.Value}'";
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    dr.Read();
                    neve.Text = dr.GetString("versenyzonev");
                    eredmenye.Text = dr.GetString("eredmeny");
                    nemzete.Text = dr.GetString("nemzet");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll!");
                Environment.Exit(0);
            }
        }
    }
    
}
    


