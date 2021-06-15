using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Oroox.SubSuppliers.Domain.Migrations
{
    public partial class Hole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Hole",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Hole",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Hole",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                table: "Hole",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ModifiedBy",
                table: "Hole",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Hole",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Hole");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Hole");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Hole");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                table: "Hole");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Hole");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Hole");
        }
    }
}
