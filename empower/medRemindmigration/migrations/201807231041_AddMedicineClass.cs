using FluentMigrator;
namespace medRemindmigration
{
    [Migration(201807231041)]
    public class AddMedicineClass : Migration
    {
        public override void Up()
        {
            Create.Table("MedicineClass")
            .AddCommonColumns()
            .WithColumn("MedicineClassName").AsAnsiString(75).NotNullable();

        }
        public override void Down()
        {
            Delete.Table("MedicineClass");
        }
    }
}