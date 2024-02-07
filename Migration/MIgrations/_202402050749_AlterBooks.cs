using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Migrations.MIgrations
{

    [Migration(202402050749)]
    internal class _202402050749_AlterBooks : Migration
    {
        public override void Up()
        {
            Alter.Table("Books").AddColumn("AuthorID").AsInt32()
                 .AddColumn("CategoryId").AsInt32();
            Create.ForeignKey("Fk_Book_Author")
                .FromTable("Books").ForeignColumn("AuthorId")
                .ToTable("Authors").PrimaryColumns("Id");
            Create.ForeignKey("Fk_Book_Category").FromTable("Books")
                .ForeignColumn("CategoryId").ToTable("Categories").PrimaryColumns("Id");
        }
        public override void Down()
        {
            Delete.Column("AuthorId").FromTable("Books");
            Delete.Column("CategoryId").FromTable("Books");
        }

    }
}
