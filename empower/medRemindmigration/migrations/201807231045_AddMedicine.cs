using FluentMigrator;

namespace medRemindmigration
{
    [Migration(201807231045)]
    public class AddMedicine : Migration
    {
        public override void Up()
        {
            Create.Table("Medicine")
            .AddCommonColumns()
            .WithColumn("MedicineName").AsAnsiString(75).NotNullable()
            .WithColumn("MedicineClassNameId").AsInt32().NotNullable()
            .WithColumn("SideEffectId").AsInt32().NotNullable();
            // .WithColumn("DoseSizeId").AsInt32().NotNullable();

            Create.ForeignKey("fk_medicine_medicine_class_name_id")
            .FromTable("Medicine").ForeignColumn("MedicineClassNameId")
            .ToTable("MedicineClass").PrimaryColumn("Id");

            Create.ForeignKey("fk_medicine_side_effect_id")
            .FromTable("Medicine").ForeignColumn("SideEffectId")
            .ToTable("SideEffect").PrimaryColumn("Id");

            // Create.ForeignKey("fk_medicine_dose_size_id")
            // .FromTable("Medicine").ForeignColumn("DoseSizeId")
            // .ToTable("DoseSize").PrimaryColumn("Id");
        }
        public override void Down()
        {
            Delete.Table("Medicine");
        }
    }
}