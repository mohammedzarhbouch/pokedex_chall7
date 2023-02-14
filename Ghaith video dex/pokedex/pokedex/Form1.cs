using MySqlConnector;
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

namespace pokedex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server = localhost; port = 3306; username = bigguy; password = bigguy; database = pokedex; ");
            con.Open();

            MySqlCommand cmd = new MySqlCommand("INSERT INTO pokemon (PokemonName, PokemonType) VALUES (@PokemonName, @PokemonType)", con);
            cmd.Parameters.AddWithValue("@PokemonName", textBox2.Text);
            cmd.Parameters.AddWithValue("@PokemonType", textBox3.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Succesfully Saved");
        }
    }
}
