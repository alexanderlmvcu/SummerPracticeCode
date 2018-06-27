using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RunningWithScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.AppSettings["ConnectionString"];

            Console.WriteLine("Enter a table name:");
            var tableName = Console.ReadLine();
            var sqlSelect = $"select * from {tableName}";
            Console.WriteLine($"This is the query that is about to run: {sqlSelect}");
            var row = 0;

            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (var command = new SqlCommand(sqlSelect, sqlConnection))
                {
                    using (var dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            row++;
                            Console.Write($"Data from row {row}: ");
                            var values = new List<string>();
                            for (int i = 0; i < dr.FieldCount; i++)
                            {
                                values.Add(dr[i] == DBNull.Value ? "NULL" : dr[i].ToString());
                            }
                            Console.WriteLine(string.Join("|", values));
                        }
                    }
                }
            }
            //var parents = new ParentRow[]
            //{ //    new ParentRow() {ParentId = 1, ParentName = "Parent1"},
            //    new ParentRow() {ParentId = 2, ParentName = "Parent2"} //};
            //var children = new ChildRow[]
            //{//    new ChildRow() {ChildId = 1, ParentId = 1, ChildName = "Child1"},
            //    new ChildRow() {ChildId = 2, ParentId = 1, ChildName = "Child2"},
            //    new ChildRow() {ChildId = 3, ParentId = 2, ChildName = "Child3"},
            //    new ChildRow() {ChildId = 4, ParentId = 2, ChildName = "Child4"} //};
            //var groupJoined = parents.GroupJoin(children, p => p.ParentId, c => c.ParentId, (p, c) => new
            //{//    Parent = p,
            //    children = c//});
            //var groupJoinedFamilyMessageBuilder = new StringBuilder();
            //foreach (var parent in groupJoined)
            //{ //    var childrenNames = String.Join(",", parent.Children.Select(children => c.ChildName));
            //    var line = parent.Parent.ParentName + ": " + childrenNames;
            //    groupJoinedFamilyMessageBuilder.AppendLine(line);//}
            Console.WriteLine($"You had {row}{(row > 0 ? "s" : "")} of data");
            Console.ReadKey();
        }
    }
}
