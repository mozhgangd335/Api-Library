using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Migrations.MIgrations
{
    [Migration(202402050810)]
    internal class _202402050810_AlterRentBook : Migration
    {
        public override void Up()
        {

            Alter.Table("RentBooks").AddColumn("BookId").AsInt32()
                .AddColumn("UserId").AsInt32();
            Create.ForeignKey("Fk_RentBook_Books")
                .FromTable("RentBooks").ForeignColumn("BookId")
                .ToTable("Books").PrimaryColumns("Id");
            Create.ForeignKey("Fk_RentBook_Users")
                .FromTable("RentBooks").ForeignColumn("UserId")
                .ToTable("Users").PrimaryColumns("Id");
        }
        public override void Down()
        {
            Delete.Column("BookId").FromTable("Books");
            Delete.Column("UserId").FromTable("Users");
        }

    }
}
