using FluentMigrator;

namespace medRemindmigration 
{
    [Migration(201807231344)]
    public class AddCaregiverPatients : Migration
    {
        public override void Up()
        {
            Create.Table("CaregiverPatients")
            .AddCommonColumns()
            .WithColumn("CaregiverId").AsInt32().NotNullable()
            .WithColumn("PatientId").AsInt32().NotNullable();

            Create.ForeignKey("fk_caregiver_patients_caregiver_id")
            .FromTable("CaregiverPatients").ForeignColumn("CaregiverId")
            .ToTable("Caregiver").PrimaryColumn("Id");

            Create.ForeignKey("fk_caregiver_patients_patient_id")
            .FromTable("CaregiverPatients").ForeignColumn("PatientId")
            .ToTable("Patient").PrimaryColumn("Id");
        }
        public override void Down()
        {
            Delete.Table("CaregiverPatients");
        }
    }
}