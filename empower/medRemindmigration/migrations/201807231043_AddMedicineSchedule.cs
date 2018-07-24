using FluentMigrator;

namespace medRemindmigration
{
    [Migration(201807231043)]
    public class AddMedicineSchedule : Migration
    {
        public override void Up()
        {
            Create.Table("MedicineSchedule")
            .AddCommonColumns()
            .WithColumn("FrequencyType").AsAnsiString(20).NotNullable()
            .WithColumn("FrequencyInterval").AsAnsiString(20).NotNullable();
        }
        public override void Down()
        {
            Delete.Table("MedicineSchedule");
        }
    }
}