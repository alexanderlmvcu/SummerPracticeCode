using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Delta18
{
    public class SqlDatabase : IDatabase
    {
        private readonly string connectionString;
        public SqlDatabase(string cons)
        {
            connectionString = cons;
        }
        public void Create(Pet pet)
        {
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                using (var com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = "INSERT INTO Pet ([Name], Age, IsSpotted, Color) VALUES (@Name, @Age, @IsSpotted, @Color)";
                    com.Parameters.AddWithValue("@Name", pet.Name);
                    com.Parameters.AddWithValue("@Age", pet.Age);
                    com.Parameters.AddWithValue("@IsSpotted", pet.IsSpotted);
                    com.Parameters.AddWithValue("@Color", pet.Color);
                    com.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pet> GetAllPets()
        {
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                using (var com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = "SELECT * FROM Pet";
                    using (var rdr = com.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            var pet = new Pet();
                            pet.Id = rdr.GetInt32(0);
                            pet.Name = rdr.GetString(1);
                            pet.Age = rdr.GetInt32(2);
                            pet.IsSpotted = rdr.GetBoolean(3);
                            pet.Color = rdr.GetString(4);
                            yield return pet;
                        }
                    }
                }
            }
        }

        public Pet Read(int id)
        {
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                using (var com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = "SELECT * FROM Pet WHERE PetId = @Id";
                    com.Parameters.AddWithValue("@Id", id);
                    using (var rdr = com.ExecuteReader())
                    {
                        rdr.Read();
                        var pet = new Pet();
                        pet.Id = rdr.GetInt32(0);
                        pet.Name = rdr.GetString(1);
                        pet.Age = rdr.GetInt32(2);
                        pet.IsSpotted = rdr.GetBoolean(3);
                        pet.Color = rdr.GetString(4);
                        return pet;
                    }
                }
            }
        }

        public void Update(Pet pet)
        {
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                using (var com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = "UPDATE Pet SET @Color = 'White' WHERE @IsSpotted = 1";
                    com.Parameters.AddWithValue("@Name", pet.Name);
                    com.Parameters.AddWithValue("@Age", pet.Age);
                    com.Parameters.AddWithValue("@IsSpotted", pet.IsSpotted);
                    com.Parameters.AddWithValue("@Color", pet.Color);
                    com.ExecuteNonQuery();
                }
            }

            //;
        }
    }
}
