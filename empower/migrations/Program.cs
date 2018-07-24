using System;
using System.Linq;
using FluentMigrator.Runner;
using FluentMigrator.Runner.Initialization;
using Microsoft.Extensions.DependencyInjection;

namespace migrations
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = CreateServices();
            using(var scope = serviceProvider.CreateScope()){
                UpdateDatabase(scope.ServiceProvider);
            }
        }
        private static void UpdateDatabase(IServiceProvider serviceProvider) {
            var runner = serviceProvider.GetRequiredService<IMigrationRunner>();
            runner.MigrateUp();
        }
        private static IServiceProvider CreateServices()
       {
           return new ServiceCollection()
               // Add common FluentMigrator services
               .AddFluentMigratorCore()
               .ConfigureRunner(rb => rb
                   // Add SQLite support to FluentMigrator
                   .AddSqlServer()
                   // Set the connection string
                   .WithGlobalConnectionString("Server=.\\S2017E;Database=sakila_migrations;Trusted_Connection=True;")
                   // Define the assembly containing the migrations
                   .ScanIn(typeof(AddActor).Assembly).For.Migrations())
               // Enable logging to console in the FluentMigrator way
               .AddLogging(lb => lb.AddFluentMigratorConsole())
               // Build the service provider
               .BuildServiceProvider(false);
       }
        
    }
}
