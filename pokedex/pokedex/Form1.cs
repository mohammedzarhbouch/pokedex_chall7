namespace pokedex
{
    public partial class Form1 : Form
    {
        BindingSource pokemonBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pokemonDAO pokemonDAO = new pokemonDAO();

            // connecet the list to the grid view control
            pokemonBindingSource.DataSource = pokemonDAO.GetAllPokemon;

            dataGridView1.DataSource = pokemonBindingSource;
        }
    }
}