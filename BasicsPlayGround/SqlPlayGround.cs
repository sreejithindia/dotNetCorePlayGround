#define DEBUG
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BasicsPlayGround
{
    public class Animal
    {
        public string Color { get; set; }
        public string Name { get; set; }
    }
    public class SqlPlayGround
    {
        public IEnumerable<Animal> GetAnimals(string sqlConnectionString) 
        {
            #if (DEBUG)
            Console.WriteLine("This is deprecated");
            #endif
            var animals = new List<Animal>();
            
            // Define Sql Connection
            var sqlConnection = new SqlConnection(sqlConnectionString);
            using (sqlConnection)
            {
                // Sql Command
                var sqlCommand = new SqlCommand("SELECT Name, Color FROM Animals", sqlConnection);
                
                // Open Database Connection
                sqlConnection.Open();

                // Define Data Reader
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    // Start Reading the data
                    while (sqlDataReader.Read())
                    {
                        var animal = new Animal
                        {
                            Name = (string)sqlDataReader["Name"],
                            Color = (string)sqlDataReader["Color"]
                        };
                        animals.Add(animal);
                    }
                }
            }
            return animals;
        }
        
    }
}
