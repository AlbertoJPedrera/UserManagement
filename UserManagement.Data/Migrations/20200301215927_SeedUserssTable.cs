// -----------------------------------------------------
//     Class name
//     Author: Alberto José Pedrera Ros
//------------------------------------------------------

using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManagement.Data.Migrations
{
    public partial class SeedUserssTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql("INSERT INTO Users (Id, Name, LastName, Password, Email, Country, PhoneNumber, PostalCode) Values ('1a297910-86ec-4a90-a430-2fc42a1b3231', 'Alberto', 'Pedrera', '1234', 'albpedros@gmail.com', 'Spain', '123456789', '46131')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql("DELETE FROM Users");
        }
    }
}