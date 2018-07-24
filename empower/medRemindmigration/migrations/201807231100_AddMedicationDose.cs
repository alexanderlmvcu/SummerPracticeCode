using FluentMigrator;

namespace medRemindmigration
{
    [Migration(201807231100)]
    public class AddMedicationDose : Migration
    {
        public override void Up()
        {
            Create.Table("MedicationDose")
            .AddCommonColumns()
            .WithColumn("MedicineId").AsInt32().NotNullable()
            .WithColumn("DoseSizeId").AsInt32().NotNullable()
            .WithColumn("PillCount").AsInt16().NotNullable()
            .WithColumn("MaxDose").AsAnsiString(30).NotNullable();
            // .WithColumn("PrescriptionScheduleId").AsInt32().NotNullable();


            Create.ForeignKey("fk_medication_dose_medicine_id")
            .FromTable("MedicationDose").ForeignColumn("MedicineId")
            .ToTable("Medicine").PrimaryColumn("Id");
            Create.ForeignKey("fk_medication_dose_dose_size_id")
            .FromTable("MedicationDose").ForeignColumn("DoseSizeId")
            .ToTable("DoseSize").PrimaryColumn("Id");
            // Create.ForeignKey("fk_medication_dose_")
        }
        public override void Down()
        {
            Delete.Table("MedicationDose");
        }
    }
}