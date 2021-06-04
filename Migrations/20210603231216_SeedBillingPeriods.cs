using Microsoft.EntityFrameworkCore.Migrations;

namespace Prototype.Migrations
{
    public partial class SeedBillingPeriods : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Billing Period Inserts
            migrationBuilder.Sql("INSERT INTO BillingPeriods (Name) VALUES ('Monthly')");
            migrationBuilder.Sql("INSERT INTO BillingPeriods (Name) VALUES ('Annual')");

            // Media Filter Inserts
            migrationBuilder.Sql("INSERT INTO MediaFilters (Size) VALUES ('14x14x1')");
            migrationBuilder.Sql("INSERT INTO MediaFilters (Size) VALUES ('21x21x1')");

            // Other Warranties
            migrationBuilder.Sql("INSERT INTO OtherWarranties (Name) VALUES ('None')");
            migrationBuilder.Sql("INSERT INTO OtherWarranties (Name) VALUES ('WeFixinNothin')");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
