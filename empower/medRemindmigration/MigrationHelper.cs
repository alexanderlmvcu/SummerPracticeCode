using FluentMigrator;
using FluentMigrator.Builders.Create.Column;
using FluentMigrator.Builders.Create.Constraint;
using FluentMigrator.Builders.Create.ForeignKey;
using FluentMigrator.Builders.Create.Index;
using FluentMigrator.Builders.Create.Schema;
using FluentMigrator.Builders.Create.Sequence;
using FluentMigrator.Builders.Create.Table;
using FluentMigrator.Infrastructure;


namespace medRemindmigration{
   public static class MigrationHelper
   {
       public static ICreateTableColumnOptionOrWithColumnSyntax AddCommonColumns
       (this ICreateTableWithColumnOrSchemaOrDescriptionSyntax table){
           return table
               .WithColumn("Id").AsInt32().PrimaryKey().Identity()
               .WithColumn("CreatedAt").AsDateTime().NotNullable()
               .WithColumn("LastUpdated").AsDateTime().NotNullable();
       }
   }
}