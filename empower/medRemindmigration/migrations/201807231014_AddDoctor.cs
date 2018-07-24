using FluentMigrator;

namespace medRemindmigration
{
    [Migration(201807231014)]
    public class AddDoctor : Migration
    {
        public override void Up()
        {
            Create.Table("Doctor")
            .AddCommonColumns()
            .WithColumn("FirstName").AsAnsiString(50).NotNullable()
            .WithColumn("LastName").AsAnsiString(100).NotNullable()
            .WithColumn("Specialty").AsAnsiString(100).NotNullable()
            .WithColumn("EmailAddress").AsAnsiString(150).NotNullable()
            .WithColumn("OfficePhoneNumber").AsAnsiString(30).NotNullable();
        }
        public override void Down()
        {
            Delete.Table("Doctor");
        }
    }
}