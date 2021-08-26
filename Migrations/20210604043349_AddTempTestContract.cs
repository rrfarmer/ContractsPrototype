using Microsoft.EntityFrameworkCore.Migrations;

namespace Prototype.Migrations
{
    public partial class AddTempTestContract : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Create a couple Contracts for Customer 1
            migrationBuilder.Sql("INSERT INTO Contracts (CustomerId, Address, City, State, Zip, StartDate, BillingPeriodId, isActive, OtherWarrantyId) VALUES (1, '123 Left North St', 'Altgard', 'IO', 55555, '1/1/2021 12:00:00 AM', 1, 1, 2)");
            migrationBuilder.Sql("INSERT INTO Contracts (CustomerId, Address, City, State, Zip, StartDate, BillingPeriodId, isActive, OtherWarrantyId) VALUES (1, '123 Right North St', 'Altgard', 'IO', 55555, '3/1/2020 12:00:00 AM', 1, 0, 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
