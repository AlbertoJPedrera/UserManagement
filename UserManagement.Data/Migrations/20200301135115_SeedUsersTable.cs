using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManagement.Data.Migrations
{
    public partial class SeedUsersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql("INSERT INTO Users (Name, LastName, Email, Password, Country, PhoneNumber, PostalCode) Values ('Alberto', 'Pedrera', 'albpedros@gmail.com', '1234', 'Spain', '123456789', '46131')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql("DELETE FROM Users");
        }
    }
}
