using FluentMigrator;
namespace migrations 
{
    [Migration(201807181111)]
    public class AddCity : Migration
    {
        public override void Up()
        {
            Create.Table("city")
            .WithColumn("city_id").AsInt32().PrimaryKey().Identity()
            .WithColumn("city").AsAnsiString(50).NotNullable()
            .WithColumn("country_id").AsInt16().NotNullable()
            .WithColumn("last_update").AsDateTime().NotNullable();

            Create.ForeignKey("fk_address_city_city_id")
            .FromTable("address").ForeignColumn("city_id")
            .ToTable("city").PrimaryColumn("city_id");
        }
        public override void Down()
        {
            Delete.Table("city");
        }
    }
}