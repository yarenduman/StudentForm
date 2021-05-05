using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentForm.Data.Migrations
{
    public partial class studentadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "Students",
               columns: table => new
               {
                   Id = table.Column<int>(type: "INTEGER", nullable: false)
                   .Annotation("Sqlite: Autoincrement", true),
                   Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                   Surname = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                   Department = table.Column<string>(type: "TEXT", maxLength: 1024, nullable: true),
                   BirthDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                   CreationDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                   LastUpdateDate = table.Column<DateTime>(type: "TEXT", nullable: false),


               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Students", x => x.Id);
               });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
               name: "Students");

        }
    }
}
