
using FluentMigrator;

namespace Library.Migrations.MIgrations
{
    [Migration(202402031713)]
    public class _202402031713_Book : Migration

    {

        public override void Up()
        {
            Create.Table("Books")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                 .WithColumn("Title").AsString(50).NotNullable()
                 
                 .WithColumn("Count").AsInt32().NotNullable()
                 .WithColumn("CreationDate").AsDateTime().NotNullable();
        }
        public override void Down()
        {
            Delete.Table("Books");
        }

    }
}
