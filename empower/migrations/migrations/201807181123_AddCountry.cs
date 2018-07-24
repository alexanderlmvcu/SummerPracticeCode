using FluentMigrator;
namespace migrations 
{
    [Migration(201807181123)]
    public class AddCountry : Migration
    {
        public override void Up()
        {
            Create.Table("country")
            .WithColumn("country_id").AsInt16().PrimaryKey().Identity()
            .WithColumn("country").AsAnsiString(50).NotNullable()
            .WithColumn("last_update").AsDateTime().NotNullable();

            Create.ForeignKey("fk_city_country_country_id")
            .FromTable("city").ForeignColumn("country_id")
            .ToTable("country").PrimaryColumn("country_id");
        }
        public override void Down()
        {
            Delete.Table("country");
        }
    }
}