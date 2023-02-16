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
            this.refresh();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server = localhost; port = 3306; username = bigguy; password = bigguy; database = pokedex; ");
            con.Open();

           // MySqlCommand cmd = new MySqlCommand("INSERT INTO pokemon (ID, PokemonName, PokemonType) VALUES (@ID,@PokemonName, @PokemonType)", con);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO pokemon (PokemonName, PokemonType) VALUES (@PokemonName, @PokemonType)", con);
           // cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@PokemonName", textBox2.Text);
            cmd.Parameters.AddWithValue("@PokemonType", textBox3.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            this.refresh();
           // MessageBox.Show("Succesfully Saved");
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server = localhost; port = 3306; username = bigguy; password = bigguy; database = pokedex; ");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE pokemon SET PokemonName=@PokemonName, PokemonType=@PokemonType WHERE ID = @ID ", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@PokemonName", textBox2.Text);
            cmd.Parameters.AddWithValue("@PokemonType", textBox3.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Succesfully Updated");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server = localhost; port = 3306; username = bigguy; password = bigguy; database = pokedex; ");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM pokemon WHERE ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Succesfully deleted");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.refresh();
        }

        private void refresh()
        {
            MySqlConnection con = new MySqlConnection("server = localhost; port = 3306; username = bigguy; password = bigguy; database = pokedex; ");
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM pokemon", con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            MessageBox.Show("hey");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Pokédex_logo;
        }
    } 
}
