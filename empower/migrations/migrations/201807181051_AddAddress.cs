using FluentMigrator;

namespace migrations 
{
    [Migration(201807181051)]
    public class AddAddress : Migration
    {
        public override void Up()
        {
            Create.Table("address") 
            .WithColumn("address").AsAnsiString(50).NotNullable()
            .WithColumn("address2").AsAnsiString(50).NotNullable()
            .WithColumn("district").AsAnsiString(20).NotNullable()
            .WithColumn("city_id").AsInt32().NotNullable()
            .WithColumn("postal_code").AsAnsiString(10).NotNullable()
            .WithColumn("phone").AsAnsiString(20).NotNullable()
            .WithColumn("last_update").AsDateTime().NotNullable();
        }
        public override void Down()
        {
            Delete.Table("address");
        }
    }
}