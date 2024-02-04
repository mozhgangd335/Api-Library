using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Migrations.MIgrations
{
    [Migration(202402031706)]
    internal class _202402031706_category : Migration
    {
        public override void Up()
        {

            Create.Table("Categories")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                 .WithColumn("Name").AsString(50).NotNullable();
        }
              
        public override void Down()
        {

            Delete.Table("Categories");
        }

    }
}
