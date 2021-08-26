using Microsoft.EntityFrameworkCore.Migrations;

namespace Prototype.Migrations
{
    public partial class AddTempTestUnitsVisits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Add a couple Units to Contract 1 and 2
            migrationBuilder.Sql("INSERT INTO Units (MediaFilterId, ContractId) VALUES (1, 2)");
            migrationBuilder.Sql("INSERT INTO Units (MediaFilterId, ContractId) VALUES (1, 2)");
            migrationBuilder.Sql("INSERT INTO Units (MediaFilterId, ContractId) VALUES (1, 1)");

            // Add a couple Service Visits to a contract
            migrationBuilder.Sql("INSERT INTO ServiceVisit (Visit, ContractId) VALUES ('1/1/2021 12:00:00 AM', 2)");
            migrationBuilder.Sql("INSERT INTO ServiceVisit (Visit, ContractId) VALUES ('1/1/2021 12:00:00 AM', 2)");
            migrationBuilder.Sql("INSERT INTO ServiceVisit (Visit, ContractId) VALUES ('1/1/2021 12:00:00 AM', 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
