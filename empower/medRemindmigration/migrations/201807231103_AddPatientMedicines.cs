using FluentMigrator;

namespace medRemindmigration 
{
    [Migration(201807231103)]
    public class AddPatientMedicines : Migration
    {
        public override void Up()
        {
            Create.Table("PatientMedicines")
            .AddCommonColumns()
            .WithColumn("MedicationDoseId").AsInt32().NotNullable() 
            .WithColumn("PatientId").AsInt32().NotNullable()
            .WithColumn("PrescribedOn").AsDateTime().NotNullable()
            .WithColumn("PrescribingDoctorId").AsInt32().NotNullable()
            .WithColumn("MedicineScheduleId").AsInt32().NotNullable();

            Create.ForeignKey("fk_patient_medicine_medicine_id")
            .FromTable("PatientMedicines").ForeignColumn("MedicineId")
            .ToTable("Medicine").PrimaryColumn("Id");

            Create.ForeignKey("fk_patient_medicine_patient_id")
            .FromTable("PatientMedicines").ForeignColumn("PatientId")
            .ToTable("Patient").PrimaryColumn("Id");
            
            Create.ForeignKey("fk_patient_medicine_prescribing_doctor_id")
            .FromTable("PatientMedicines").ForeignColumn("PrescribingDoctorId")
            .ToTable("Doctor").PrimaryColumn("Id");

            Create.ForeignKey("fk_patient_medicine_medicine_schedule_id")
            .FromTable("PatientMedicines").ForeignColumn("MedicineScheduleId")
            .ToTable("MedicineSchedule").PrimaryColumn("Id");
        }
        public override void Down()
        {
            Delete.Table("PatientMedicines");
        }
    }
}