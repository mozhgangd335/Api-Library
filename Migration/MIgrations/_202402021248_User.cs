using FluentMigrator;


namespace Library.Migrations.MIgrations
{
    [Migration(202402021248)]
    public class _202402021248_User : Migration
    {


        public override void Up()
        {
            Create.Table("Users")
       .WithColumn("Id").AsInt32().PrimaryKey().Identity()
        .WithColumn("FirstName").AsString(50).NotNullable()
        .WithColumn("LastName").AsString(50).NotNullable()
        .WithColumn("Email").AsString(100).NotNullable()
        .WithColumn("CreationDate").AsDateTime().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("Users");
    
        }
    }
}
