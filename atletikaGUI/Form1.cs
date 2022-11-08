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
                command.CommandText = "SELECT DISTINCT nemzetek.Nemzet, versenyekszamok.Versenyszam, versenyekszamok.NemzetKod, versenyekszamok.VersenyzoNev, versenyekszamok.Eredmeny, versenyekszamok.Helyezes FROM nemzetek JOIN versenyekszamok ON nemzetek.NemzetId = versenyekszamok.NemzetKod WHERE versenyekszamok.Helyezes = '1'";
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        vberedmenyek vberedmenyek = new vberedmenyek(dr.GetString("nemzet"), dr.GetString("versenyzonev"), dr.GetInt32("NemzetKod"), dr.GetString("versenyszam"), dr.GetString("eredmeny"), dr.GetInt32("helyezes"));
                        listBox1_kiiratas.Items.Add(vberedmenyek);
                    }

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll!");
                Environment.Exit(0);
            }
        }

        private void listBox1_kiiratas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    //SELECT DISTINCT nemzetek.Nemzet, versenyekszamok.Versenyszam, versenyekszamok.NemzetKod, versenyekszamok.VersenyzoNev, versenyekszamok.Eredmeny, versenyekszamok.Helyezes FROM nemzetek JOIN versenyekszamok ON nemzetek.NemzetId = versenyekszamok.NemzetKod WHERE versenyekszamok.Helyezes = "1"

}
