using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Migrations.MIgrations
{
    [Migration(202402031815)]
    internal class _202402031815_RentBook : Migration
    {
        public override void Up()
        {
            Create.Table("RentBooks")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                
                 .WithColumn("Days").AsInt32().NotNullable()
                 .WithColumn("DateRent").AsDateTime().NotNullable()
                 .WithColumn("IsRentedBack").AsDateTime().NotNullable();

        }
        public override void Down()
        {
            Delete.Table("RentBooks");
        }

    }
}
