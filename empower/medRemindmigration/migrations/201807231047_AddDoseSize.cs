using FluentMigrator;

namespace medRemindmigration
{
    [Migration(201807231047)]
    public class DoseSize : Migration
    {
        public override void Up()
        {
         Create.Table("DoseSize")
         .AddCommonColumns()
         .WithColumn("IngestionType").AsAnsiString(30).NotNullable() //might just have to do size 
         //and not oral capsule vs lotion?
         .WithColumn("Size").AsAnsiString(40).NotNullable();   
        }
        public override void Down()
        {
            Delete.Table("DoseSize");
        }
    }
}