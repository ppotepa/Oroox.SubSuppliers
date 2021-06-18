using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Oroox.SubSuppliers.Domain.Migrations
{
    public partial class RemoveCalculationResultFromJob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_CalculationResult_CalculationResultId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_CalculationResultId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "CalculationResultId",
                table: "Jobs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CalculationResultId",
                table: "Jobs",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_CalculationResultId",
                table: "Jobs",
                column: "CalculationResultId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_CalculationResult_CalculationResultId",
                table: "Jobs",
                column: "CalculationResultId",
                principalTable: "CalculationResult",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
