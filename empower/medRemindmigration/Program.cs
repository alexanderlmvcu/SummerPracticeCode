using System;
using System.Linq;
using FluentMigrator;
using FluentMigrator.Runner;
using FluentMigrator.Runner.Initialization;
using Microsoft.Extensions.DependencyInjection;


namespace medRemindmigration
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

        private static void UpdateDatabase(IServiceProvider serviceProvider)
        {
            var runner = serviceProvider.GetRequiredService<IMigrationRunner>();
            runner.MigrateUp();
        }

        private static IServiceProvider CreateServices()
        {
            return new ServiceCollection()
            .AddFluentMigratorCore()
            .ConfigureRunner(rb => rb
            .AddSqlServer()
            .WithGlobalConnectionString("Server=.\\S2017E;Database=medRemind;Trusted_Connection=True;")
            .ScanIn(typeof(AddPatient).Assembly).For.Migrations())
            .AddLogging(lb => lb.AddFluentMigratorConsole())
            .BuildServiceProvider(false);
        }
        
    }
}
