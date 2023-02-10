using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Vista.DatabaseConnector;

namespace test_shit_cuzzo
{
    internal class PokemonsDAO
    {
        string connectionString = "datasource=localhost; port=3306; username=mohammed; password=mohammed; database=pokedex;";

        public List<Pokemon> LoadAllPokemon()
        {
            //List<Customer> data = SqlServerDb.LoadData<Customer, dynamic>("SELECT * FROM Customer", new {}, this.ConnectionString);
            List<Pokemon> data = MySqlDb.LoadData<Pokemon, dynamic>("SELECT * FROM pokemon", new { }, this.connectionString);

            return data;
        }
       

        public void AddPokemon(Pokemon pokemon)
        {
            //SqlServerDb.SaveData<Customer>("INSERT INTO Customer (FirstName, LastName) VALUES (@FirstName, @LastName)", customer, this.ConnectionString);
            MySqlDb.SaveData<Pokemon>("INSERT INTO pokemon (PokemonName, PokemonType) VALUES (@PokemonName, @PokemonType)", pokemon, this.connectionString);
        }


    }
}
