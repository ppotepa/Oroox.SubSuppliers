using Microsoft.EntityFrameworkCore.Migrations;

namespace Oroox.SubSuppliers.Domain.Migrations
{
    public partial class CustomerAndJob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Key",
                table: "CalculationDetailsGroup");

            migrationBuilder.AddColumn<int>(
                name: "PartIndex",
                table: "CalculationDetailsGroup",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PartIndex",
                table: "CalculationDetailsGroup");

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "CalculationDetailsGroup",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
