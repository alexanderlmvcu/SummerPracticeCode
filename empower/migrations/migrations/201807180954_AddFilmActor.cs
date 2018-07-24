using FluentMigrator;
namespace migrations 
{
    [Migration(201807180954)]
    public class AddFilmActor : Migration
    {
        public override void Up()
        {
            Create.Table("film_actor")
            .WithColumn("actor_id").AsInt32().NotNullable()
            .WithColumn("film_id").AsInt32().NotNullable()
            .WithColumn("last_update").AsDateTime().NotNullable();

            Create.ForeignKey("fk_film_actor_actor_id")
            .FromTable("film_actor").ForeignColumn("actor_id")
            .ToTable("actor").PrimaryColumn("actor_id");
            Create.ForeignKey("fk_film_actor_film_id")
            .FromTable("film_actor").ForeignColumn("film_id")
            .ToTable("film").PrimaryColumn("film_id");
        }
        public override void Down()
        {
            Delete.Table("film_actor");
        }
    }
}