using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Migrations.MIgrations
{
    [Migration(202402031711)]
    internal class _202402031711_Authors : Migration { 

        public override void Up()
        {

            Create.Table("Authors")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                 .WithColumn("Name").AsString(50).NotNullable();
        }
    
        public override void Down()
        {
            Delete.Table("Authors");
        }

    }
}
