using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Oroox.SubSuppliers.Domain.Migrations
{
    public partial class AddRegardingObjectToComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "RegardingObjectId",
                table: "Comments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_RegardingObjectId",
                table: "Comments",
                column: "RegardingObjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_RegardingObjects_RegardingObjectId",
                table: "Comments",
                column: "RegardingObjectId",
                principalTable: "RegardingObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_RegardingObjects_RegardingObjectId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_RegardingObjectId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "RegardingObjectId",
                table: "Comments");
        }
    }
}
