using Microsoft.EntityFrameworkCore.Migrations;

namespace Prototype.Migrations
{
    public partial class AddTempTestCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Create a Customer 1
            migrationBuilder.Sql("INSERT INTO Customers (FirstName, LastName, Phone, Email, Notes) VALUES ('Ryan', 'Farmer', '555-555-5555', 'joe@dough.com', 'Crazy customer.... be careful.')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
