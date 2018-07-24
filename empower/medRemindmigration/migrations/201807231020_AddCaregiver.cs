using FluentMigrator;

namespace medRemindmigration
{
    [Migration(201807231020)]

    public class AddCaregiver : Migration
    {

        public override void Up()
        {
            Create.Table("Caregiver")
            .AddCommonColumns()
            .WithColumn("FirstName").AsAnsiString(50).NotNullable()
            .WithColumn("LastName").AsAnsiString(50).NotNullable()
            .WithColumn("EmailAddress").AsAnsiString(100).NotNullable()
            .WithColumn("PhoneNumber").AsInt64().NotNullable();

        }
        
        public override void Down()
        {
            Delete.Table("Caregiver");
        }
    }
}