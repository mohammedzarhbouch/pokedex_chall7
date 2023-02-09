using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokedex
{// adding this as a test
    internal class pokemonDAO
    {
        string connectionString =
            "datasource=localhost; port=3306; username=mohammed; password=mohammed; database=pokedex;";

        public List<pokemon> GetAllPokemon()
        {
            //leeg list
            List<pokemon> returnThese = new List<pokemon>();

            //connect to MySql
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            //define the  sql statement
            MySqlCommand command = new MySqlCommand("SELECT * FROM POKEMON",connection);
            using(MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    pokemon a = new pokemon
                    {
                        ID = reader.GetInt32(0),
                        PokemonName = reader.GetString(1),
                        PokemonType = reader.GetString(2),
                        ImageURL = reader.GetString(3)
                    };
                    returnThese.Add(a);
                }
            }
            connection.Close();

            return returnThese;
        }
        

        
    }
            

        


    
}
