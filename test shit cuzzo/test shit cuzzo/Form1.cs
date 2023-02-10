namespace test_shit_cuzzo
{
    public partial class Form1 : Form
    {
        BindingSource BindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PokemonsDAO pokemonDAO= new PokemonsDAO();
            
            BindingSource.DataSource = pokemonDAO.LoadAllPokemon();

            dataGridView1.DataSource = BindingSource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}