using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Oroox.SubSuppliers.Domain.Migrations
{
    public partial class Costs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Job",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "HourlyRate",
                table: "Machine");

            migrationBuilder.RenameTable(
                name: "Job",
                newName: "Jobs");

            migrationBuilder.AddColumn<Guid>(
                name: "CalculationDetailsForQuoteId",
                table: "Jobs",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerId",
                table: "Jobs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "QuoteId",
                table: "Jobs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Jobs",
                table: "Jobs",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CalculationDetailsForQuote",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuoteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalculationDetailsForQuote", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CalculationResult",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuoteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateOfCalculation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinalPriceForPrototype = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FinalBestUnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalculationResult", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaterialType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LicenseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CalculationDetailsGroupMap",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<long>(type: "bigint", nullable: false),
                    CalculationDetailsForQuoteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalculationDetailsGroupMap", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CalculationDetailsGroupMap_CalculationDetailsForQuote_CalculationDetailsForQuoteId",
                        column: x => x.CalculationDetailsForQuoteId,
                        principalTable: "CalculationDetailsForQuote",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FinalCost",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PartialCostType = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Depth = table.Column<float>(type: "real", nullable: false),
                    Volume = table.Column<float>(type: "real", nullable: false),
                    Perimeter = table.Column<float>(type: "real", nullable: false),
                    FinishingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsExcluded = table.Column<bool>(type: "bit", nullable: false),
                    CalculationResultId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinalCost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FinalCost_CalculationResult_CalculationResultId",
                        column: x => x.CalculationResultId,
                        principalTable: "CalculationResult",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PartialCost",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CalculationResultId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PartialCostType = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartialCost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PartialCost_CalculationResult_CalculationResultId",
                        column: x => x.CalculationResultId,
                        principalTable: "CalculationResult",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Quote",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CadFileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Width = table.Column<float>(type: "real", nullable: false),
                    Height = table.Column<float>(type: "real", nullable: false),
                    Depth = table.Column<float>(type: "real", nullable: false),
                    StatusCode = table.Column<int>(type: "int", nullable: false),
                    ChosenQuantity = table.Column<long>(type: "bigint", nullable: true),
                    ChosenDeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CalculationResultId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CalculationResultId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quote", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quote_CalculationResult_CalculationResultId1",
                        column: x => x.CalculationResultId1,
                        principalTable: "CalculationResult",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Material",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    DescriptionShortCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionLongCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Shape = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BasicType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SurfaceTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MarketGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LicenseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DisplayId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Material_MaterialType_MaterialTypeId",
                        column: x => x.MaterialTypeId,
                        principalTable: "MaterialType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CalculationDetailsGroup",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CalculationDetailsGroupMapId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalculationDetailsGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CalculationDetailsGroup_CalculationDetailsGroupMap_CalculationDetailsGroupMapId",
                        column: x => x.CalculationDetailsGroupMapId,
                        principalTable: "CalculationDetailsGroupMap",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CostPerQuantity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<long>(type: "bigint", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FinalCostId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PartialCostId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostPerQuantity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CostPerQuantity_FinalCost_FinalCostId",
                        column: x => x.FinalCostId,
                        principalTable: "FinalCost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CostPerQuantity_PartialCost_PartialCostId",
                        column: x => x.PartialCostId,
                        principalTable: "PartialCost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MilledPart",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuoteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Width = table.Column<float>(type: "real", nullable: false),
                    Height = table.Column<float>(type: "real", nullable: false),
                    Depth = table.Column<float>(type: "real", nullable: false),
                    RealVolume = table.Column<float>(type: "real", nullable: false),
                    MilledPartType = table.Column<int>(type: "int", nullable: false),
                    IsCalculable = table.Column<bool>(type: "bit", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstanceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrepName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MilledPart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MilledPart_Quote_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quote",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialSetting",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LicenseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaterialId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParameterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParameterValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSetting", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaterialSetting_Material_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CalculationDetailsSection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CalculationDetailsGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalculationDetailsSection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CalculationDetailsSection_CalculationDetailsGroup_CalculationDetailsGroupId",
                        column: x => x.CalculationDetailsGroupId,
                        principalTable: "CalculationDetailsGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Hole",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Diameter = table.Column<float>(type: "real", nullable: true),
                    CountersinkDetected = table.Column<bool>(type: "bit", nullable: false),
                    SinkingMethodType = table.Column<int>(type: "int", nullable: true),
                    LengthA = table.Column<float>(type: "real", nullable: true),
                    LengthB = table.Column<float>(type: "real", nullable: true),
                    Depth = table.Column<float>(type: "real", nullable: false),
                    Volume = table.Column<float>(type: "real", nullable: false),
                    Perimeter = table.Column<float>(type: "real", nullable: false),
                    FinishingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsExcluded = table.Column<bool>(type: "bit", nullable: false),
                    MilledPartId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hole_MilledPart_MilledPartId",
                        column: x => x.MilledPartId,
                        principalTable: "MilledPart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CalculationDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsBold = table.Column<bool>(type: "bit", nullable: false),
                    NumericValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OperationType = table.Column<int>(type: "int", nullable: false),
                    PriorityOrder = table.Column<long>(type: "bigint", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueGroupType = table.Column<int>(type: "int", nullable: false),
                    ValueType = table.Column<int>(type: "int", nullable: false),
                    CalculationDetailsSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalculationDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CalculationDetails_CalculationDetailsSection_CalculationDetailsSectionId",
                        column: x => x.CalculationDetailsSectionId,
                        principalTable: "CalculationDetailsSection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_CalculationDetailsForQuoteId",
                table: "Jobs",
                column: "CalculationDetailsForQuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_CustomerId",
                table: "Jobs",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_QuoteId",
                table: "Jobs",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_CalculationDetails_CalculationDetailsSectionId",
                table: "CalculationDetails",
                column: "CalculationDetailsSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_CalculationDetailsGroup_CalculationDetailsGroupMapId",
                table: "CalculationDetailsGroup",
                column: "CalculationDetailsGroupMapId");

            migrationBuilder.CreateIndex(
                name: "IX_CalculationDetailsGroupMap_CalculationDetailsForQuoteId",
                table: "CalculationDetailsGroupMap",
                column: "CalculationDetailsForQuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_CalculationDetailsSection_CalculationDetailsGroupId",
                table: "CalculationDetailsSection",
                column: "CalculationDetailsGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_CostPerQuantity_FinalCostId",
                table: "CostPerQuantity",
                column: "FinalCostId");

            migrationBuilder.CreateIndex(
                name: "IX_CostPerQuantity_PartialCostId",
                table: "CostPerQuantity",
                column: "PartialCostId");

            migrationBuilder.CreateIndex(
                name: "IX_FinalCost_CalculationResultId",
                table: "FinalCost",
                column: "CalculationResultId");

            migrationBuilder.CreateIndex(
                name: "IX_Hole_MilledPartId",
                table: "Hole",
                column: "MilledPartId");

            migrationBuilder.CreateIndex(
                name: "IX_Material_MaterialTypeId",
                table: "Material",
                column: "MaterialTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSetting_MaterialId",
                table: "MaterialSetting",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_MilledPart_QuoteId",
                table: "MilledPart",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_PartialCost_CalculationResultId",
                table: "PartialCost",
                column: "CalculationResultId");

            migrationBuilder.CreateIndex(
                name: "IX_Quote_CalculationResultId1",
                table: "Quote",
                column: "CalculationResultId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_CalculationDetailsForQuote_CalculationDetailsForQuoteId",
                table: "Jobs",
                column: "CalculationDetailsForQuoteId",
                principalTable: "CalculationDetailsForQuote",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Customers_CustomerId",
                table: "Jobs",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Quote_QuoteId",
                table: "Jobs",
                column: "QuoteId",
                principalTable: "Quote",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_CalculationDetailsForQuote_CalculationDetailsForQuoteId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Customers_CustomerId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Quote_QuoteId",
                table: "Jobs");

            migrationBuilder.DropTable(
                name: "CalculationDetails");

            migrationBuilder.DropTable(
                name: "CostPerQuantity");

            migrationBuilder.DropTable(
                name: "Hole");

            migrationBuilder.DropTable(
                name: "MaterialSetting");

            migrationBuilder.DropTable(
                name: "CalculationDetailsSection");

            migrationBuilder.DropTable(
                name: "FinalCost");

            migrationBuilder.DropTable(
                name: "PartialCost");

            migrationBuilder.DropTable(
                name: "MilledPart");

            migrationBuilder.DropTable(
                name: "Material");

            migrationBuilder.DropTable(
                name: "CalculationDetailsGroup");

            migrationBuilder.DropTable(
                name: "Quote");

            migrationBuilder.DropTable(
                name: "MaterialType");

            migrationBuilder.DropTable(
                name: "CalculationDetailsGroupMap");

            migrationBuilder.DropTable(
                name: "CalculationResult");

            migrationBuilder.DropTable(
                name: "CalculationDetailsForQuote");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Jobs",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_CalculationDetailsForQuoteId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_CustomerId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_QuoteId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "CalculationDetailsForQuoteId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "QuoteId",
                table: "Jobs");

            migrationBuilder.RenameTable(
                name: "Jobs",
                newName: "Job");

            migrationBuilder.AddColumn<decimal>(
                name: "HourlyRate",
                table: "Machine",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Job",
                table: "Job",
                column: "Id");
        }
    }
}
