using FluentMigrator;

namespace medRemindmigration
{
    [Migration(201897231042)]
    public class AddSideEffect : Migration
    {
        public override void Up()
        {
            Create.Table("SideEffect")
            .AddCommonColumns()
            .WithColumn("SideEffectName").AsAnsiString(80).NotNullable();
        }
        public override void Down()
        {
            Delete.Table("SideEffect");
        }
    }
}