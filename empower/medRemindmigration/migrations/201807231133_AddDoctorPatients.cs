using FluentMigrator;

namespace medRemindmigration
{
    [Migration(201807231133)]
    public class AddDoctorPatients : Migration
    {
        public override void Up()
        {
            Create.Table("DoctorPatients")
            .AddCommonColumns()
            .WithColumn("DoctorId").AsInt32().NotNullable()
            .WithColumn("PatientId").AsInt32().NotNullable();

            Create.ForeignKey("fk_doctor_patients_doctor_id")
            .FromTable("DoctorPatients").ForeignColumn("DoctorId")
            .ToTable("Doctor").PrimaryColumn("Id");

            Create.ForeignKey("fk_doctor_patients_patient_id")
            .FromTable("DoctorPatients").ForeignColumn("DoctorId")
            .ToTable("Patient").PrimaryColumn("Id");
        }
        
        public override void Down()
        {
            Delete.Table("DoctorPatients");
        }
    }
}