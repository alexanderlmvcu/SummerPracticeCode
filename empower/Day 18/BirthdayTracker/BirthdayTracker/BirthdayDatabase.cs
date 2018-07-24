using System;
using System.Data.SqlClient;
using System.Linq;
using System.Collections.Generic;

namespace BirthdayTracker
{
    internal class BirthdayDatabase
    {
        private readonly string connectionString;
        internal BirthdayDatabase(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public int Create(Location location)
        {
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                using (var com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = @"
                    insert into [Location] (LocationName) Values (@LocationName)
                    select Cast(SCOPE_IDENTITY() as int)
                    ";
                    com.Parameters.AddWithValue("@LocationName", location.LocationName);
                    var id = (int)com.ExecuteScalar();
                    return id;
                }
            }
        }
        public IEnumerable<Location> GetAllLocations ()
        {
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();
                using (var com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = @"Select * from Location";
                    using (var rdr = com.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            var location = new Location();
                            location.LocationId = (int)rdr["LocationId"];
                            location.LocationName = (string)rdr["LocationName"];
                            yield return location;
                        }
                    }
                }
            }
        }
    }
}
