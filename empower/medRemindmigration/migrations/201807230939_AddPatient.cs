using FluentMigrator;

namespace medRemindmigration
{
    [Migration (201807230939)]
    public class AddPatient : Migration
    {

        public override void Up()
        {
            Create.Table("Patient")
            .AddCommonColumns()
            .WithColumn("FirstName").AsAnsiString(50).NotNullable()
            .WithColumn("LastName").AsAnsiString(50).NotNullable()
            .WithColumn("EmailAddress").AsAnsiString(100).NotNullable()
            .WithColumn("PhoneNumber").AsInt64().NotNullable();
        }
        public override void Down()
        {
            Delete.Table("Patient");
        }
    }
}