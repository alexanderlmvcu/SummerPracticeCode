using FluentMigrator;

namespace migrations 
{
    [Migration(201807181037)]
    public class AddCategory : Migration
    {
        public override void Up()
        {
           Create.Table("category")
           .WithColumn("category_id").AsInt32().PrimaryKey().Identity()
           .WithColumn("name").AsAnsiString(25).NotNullable()
           .WithColumn("last_update").AsDateTime().NotNullable(); 
        }
        public override void Down()
        {
            Delete.Table("category");
        }

        
    }
}