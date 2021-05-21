using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Oroox.SubSuppliers.Domain.Migrations
{
    public partial class AddCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddressTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressTypes", x => x.Id);
                    table.UniqueConstraint("AK_AddressTypes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "Certifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certifications", x => x.Id);
                    table.UniqueConstraint("AK_Certifications_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "CompanySizeTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanySizeTypes", x => x.Id);
                    table.UniqueConstraint("AK_CompanySizeTypes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "ContactPerson",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactPerson", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CountryCodeTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryCodeTypes", x => x.Id);
                    table.UniqueConstraint("AK_CountryCodeTypes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "MachineDimensionsType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachineDimensionsType", x => x.Id);
                    table.UniqueConstraint("AK_MachineDimensionsType_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "MillingMachineDimensionsTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MillingMachineDimensionsTypes", x => x.Id);
                    table.UniqueConstraint("AK_MillingMachineDimensionsTypes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "MillingMachineTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MillingMachineTypes", x => x.Id);
                    table.UniqueConstraint("AK_MillingMachineTypes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "OtherTechnologies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherTechnologies", x => x.Id);
                    table.UniqueConstraint("AK_OtherTechnologies_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "TurningMachineTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TurningMachineTypes", x => x.Id);
                    table.UniqueConstraint("AK_TurningMachineTypes_Value", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VATNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CompanySizeTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerAdditionalInfoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_CompanySizeTypes_CompanySizeTypeId",
                        column: x => x.CompanySizeTypeId,
                        principalTable: "CompanySizeTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryCodeTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_AddressTypes_AddressTypeId",
                        column: x => x.AddressTypeId,
                        principalTable: "AddressTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Address_CountryCodeTypes_CountryCodeTypeId",
                        column: x => x.CountryCodeTypeId,
                        principalTable: "CountryCodeTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Address_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CertificationCustomer",
                columns: table => new
                {
                    CertificationsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificationCustomer", x => new { x.CertificationsId, x.CustomersId });
                    table.ForeignKey(
                        name: "FK_CertificationCustomer_Certifications_CertificationsId",
                        column: x => x.CertificationsId,
                        principalTable: "Certifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CertificationCustomer_Customers_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerAdditionalInfo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SpecialTolerances = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AverageMinimalSurfaceQualitiesTurning = table.Column<double>(type: "float", nullable: true),
                    AverageMinimalSurfaceQualitiesMilling = table.Column<double>(type: "float", nullable: true),
                    AverageAndFastestLeadTimeTurning = table.Column<double>(type: "float", nullable: true),
                    AverageAndFastestLeadTimeMilling = table.Column<double>(type: "float", nullable: true),
                    AverageWorkingHoursPerWeek = table.Column<double>(type: "float", nullable: true),
                    WorkingShiftsPerDay = table.Column<int>(type: "int", nullable: true),
                    CanUseStepFiles = table.Column<bool>(type: "bit", nullable: true),
                    SpecialCharacteristics = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAdditionalInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerAdditionalInfo_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerOtherTechnology",
                columns: table => new
                {
                    CustomersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OtherTechnologiesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerOtherTechnology", x => new { x.CustomersId, x.OtherTechnologiesId });
                    table.ForeignKey(
                        name: "FK_CustomerOtherTechnology_Customers_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerOtherTechnology_OtherTechnologies_OtherTechnologiesId",
                        column: x => x.OtherTechnologiesId,
                        principalTable: "OtherTechnologies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MillingMachine",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MachineNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinimalMachiningDimensions = table.Column<int>(type: "int", nullable: false),
                    MaximalMachiningDimensions = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MillingMachineTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MillingMachineDimensionsTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MillingMachine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MillingMachine_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MillingMachine_MillingMachineDimensionsTypes_MillingMachineDimensionsTypeId",
                        column: x => x.MillingMachineDimensionsTypeId,
                        principalTable: "MillingMachineDimensionsTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MillingMachine_MillingMachineTypes_MillingMachineTypeId",
                        column: x => x.MillingMachineTypeId,
                        principalTable: "MillingMachineTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Registration",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActivationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registration_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TurningMachines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MachineNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinimalMachiningDimensions = table.Column<int>(type: "int", nullable: false),
                    MaximalMachiningDimensions = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TurningMachineTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TurningMachines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TurningMachines_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TurningMachines_TurningMachineTypes_TurningMachineTypeId",
                        column: x => x.TurningMachineTypeId,
                        principalTable: "TurningMachineTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AddressTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("67272ee9-40f2-472e-ba74-6c7ab12ad37d"), "Shipping", 0 },
                    { new Guid("1a690b08-1f0a-4ae0-9282-b229e3ba336c"), "Billing", 1 }
                });

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("a2a4d5e1-ada4-442c-9029-0291f19da8f9"), "ISO9001", 0 },
                    { new Guid("5e750f90-ba52-4d08-a459-760176649bb5"), "ISO14001", 1 },
                    { new Guid("2f0bf6b9-56ef-4e71-8e44-ee795e0b31f7"), "ISO13485", 2 },
                    { new Guid("3b10c3fb-1a5a-4164-a442-42eeac6cf7bb"), "ITAF16949", 3 },
                    { new Guid("e6ad54ae-0a96-4c11-bd26-e4b353de61af"), "EN9100", 4 },
                    { new Guid("2160d49c-5cc6-43b0-9c74-6d916640c0d9"), "Other", 5 }
                });

            migrationBuilder.InsertData(
                table: "CompanySizeTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("8d391ae5-462e-4593-9817-c4aaad5f2418"), "LessThan100", 100 },
                    { new Guid("5d1c6790-ce59-4315-b8cc-4d928de65e3e"), "LessThan50", 50 },
                    { new Guid("297e5990-5e7b-4dd5-8840-5b2ebc735414"), "MoreThan100", 101 },
                    { new Guid("21460743-e733-4146-8e3a-e57fe0db1ac9"), "LessThan10", 10 },
                    { new Guid("e2035d07-c048-4fd8-ba7d-de4b338a3909"), "LessThan25", 25 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("0f0ccfee-e26e-479b-9e8a-ff219147e72e"), "PA", 171 },
                    { new Guid("9775060e-27c6-47d8-bdd0-bb8d24fd9897"), "NI", 160 },
                    { new Guid("8b158e33-0b9a-46c3-ad01-e8e064f375e5"), "NE", 161 },
                    { new Guid("2ca7c0a3-c56a-4502-94da-99aeeea27b8c"), "NG", 162 },
                    { new Guid("d3822fc6-1512-49cc-8975-e2086cdfb0bf"), "NU", 163 },
                    { new Guid("27d91671-6aac-4c86-b749-69003b7fba9a"), "NF", 164 },
                    { new Guid("c67919ca-db71-4bfa-ace1-32433e22f1e9"), "MP", 165 },
                    { new Guid("77eea453-e268-4c0d-a06c-d09b16e977f8"), "NO", 166 },
                    { new Guid("ed28ee11-e23d-4103-b45a-db76b98ef66a"), "OM", 167 },
                    { new Guid("734308af-c2ca-4d37-a6a3-4bd245e010ba"), "PK", 168 },
                    { new Guid("bcf91ffc-37d1-4cac-970c-b0c47f24fa01"), "PW", 169 },
                    { new Guid("78f2a19e-d0c1-4968-b510-6a053c31b0c4"), "PS", 170 },
                    { new Guid("e4e334d8-9e9f-41e2-8964-e4f5c9697b99"), "PG", 172 },
                    { new Guid("75d84d0b-5d2b-423f-8236-88dd0cc5c58e"), "PR", 179 },
                    { new Guid("415f226e-4d82-42c4-95dd-020e929aa94c"), "PE", 174 },
                    { new Guid("f04003c8-e13b-4c43-aacc-112fba6b7a52"), "PH", 175 },
                    { new Guid("8e5aea51-e9d4-4028-8dfe-fbbae29db819"), "PN", 176 },
                    { new Guid("181d789b-3433-403c-b782-5fca65b83251"), "PL", 177 },
                    { new Guid("c128323a-065c-4f63-bed8-20ac766233f1"), "PT", 178 },
                    { new Guid("3360a2f1-5c5c-4028-9129-2c90131d4ed0"), "NZ", 159 },
                    { new Guid("97f546fd-c226-488a-9820-5a4ef96004ab"), "QA", 180 },
                    { new Guid("bbd02f2e-49fa-485b-bcb8-9cace62a7b8c"), "RE", 181 },
                    { new Guid("c5fd82d9-d8a7-49ea-a0cc-13870a8842a1"), "RO", 182 },
                    { new Guid("612b4105-151b-47f7-aaf6-ef15559c9ff0"), "RU", 183 },
                    { new Guid("3b480777-f466-47b8-9500-603d6f145f20"), "RW", 184 },
                    { new Guid("3573e823-bdc6-4e7e-8ee3-52531c2dfaab"), "BL", 185 },
                    { new Guid("86960811-d456-420b-873b-28962a547dbf"), "SH", 186 },
                    { new Guid("d520b651-c391-4faf-b92f-d00d0d9965d7"), "PY", 173 },
                    { new Guid("58acd0f3-7aa1-4b38-b9a8-ebe7525a3dda"), "NC", 158 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("36d7e73b-1e15-4e9b-b6d2-5b252fb89ddb"), "MA", 151 },
                    { new Guid("c5a92c78-2596-4882-b17c-d9732bb7513d"), "NP", 156 },
                    { new Guid("8e72a54f-12e2-4c5d-a567-90f5d4f75dd6"), "LY", 127 },
                    { new Guid("dce7db69-ac0a-42ea-8fce-2b4759a6cde1"), "LI", 128 },
                    { new Guid("5bd3a292-d554-468a-9fad-ca0cbb5aea0f"), "LT", 129 },
                    { new Guid("64d5db60-5b8e-4d28-8759-6684087a9f86"), "MO", 131 },
                    { new Guid("21d5b1c4-503a-4fa8-9169-3896ee99bd03"), "MK", 132 },
                    { new Guid("f5221f09-ded0-4ae7-b0d0-e9638669c5fc"), "MG", 133 },
                    { new Guid("a97120ad-7b3a-496c-8435-dc6efb224ed9"), "MW", 134 },
                    { new Guid("1270ee5e-70c9-4ac0-b2a8-37577e8df1b8"), "MY", 135 },
                    { new Guid("e4c9842b-3d47-4ef9-ae04-c3d0ac788234"), "MV", 136 },
                    { new Guid("704208f6-c664-4b30-9ce5-fe87d53eba6b"), "ML", 137 },
                    { new Guid("1143b247-9398-463f-9748-3b4dd20522f7"), "MT", 138 },
                    { new Guid("338bc858-b9b3-47ca-9c3f-8b06e78bba86"), "MH", 139 },
                    { new Guid("89734048-9854-47fe-80fb-441c2025ebc7"), "MQ", 140 },
                    { new Guid("5a368bb5-40c6-4e91-a051-a19932d1f4c5"), "NL", 157 },
                    { new Guid("e9169237-7d99-4557-9079-53e8b8f2fb49"), "MR", 141 },
                    { new Guid("f68267ec-c571-4eaf-98f1-d367f2c4b43d"), "YT", 143 },
                    { new Guid("c3fbbbc5-4887-446f-8568-43dfc1d53e1e"), "MX", 144 },
                    { new Guid("50287ee0-1f5b-4347-925b-07ed56567581"), "FM", 145 },
                    { new Guid("5d7a008b-c9b0-4471-9c83-0ea1ddfd5045"), "MD", 146 },
                    { new Guid("62ea5c35-3db8-4e8c-912b-7a18aeb343a1"), "MC", 147 },
                    { new Guid("c15a6969-d90a-4849-bd00-ce7824e67424"), "MN", 148 },
                    { new Guid("f0ee72dd-fa17-4601-8795-02d53ebe8889"), "ME", 149 },
                    { new Guid("7fdce1e2-dc0e-43b4-9486-f33306c9a72f"), "MS", 150 },
                    { new Guid("9b5d34ef-f407-489f-9343-91fd3dfb233f"), "KN", 187 },
                    { new Guid("11819b12-077a-43a4-8417-460c3e3b0851"), "MZ", 152 },
                    { new Guid("4e3e5349-c012-4254-9d55-26ea387b0326"), "MM", 153 },
                    { new Guid("750050aa-c75a-4ef2-a3e4-cfb58ee516b3"), "NA", 154 },
                    { new Guid("4bc003d1-999b-42d1-90b4-846c09e2a638"), "NR", 155 },
                    { new Guid("74f18378-7f4d-44a1-a893-91770e6f8597"), "MU", 142 },
                    { new Guid("fc39c320-9142-43ef-912b-9990a5b548d6"), "LC", 188 },
                    { new Guid("8d576da4-f840-40ce-a9b6-33bb8fb05624"), "ST", 194 },
                    { new Guid("cd878fe1-140d-422e-993a-3f2d16c8805a"), "PM", 190 },
                    { new Guid("2ba286ce-8b1b-4ceb-8314-6cad68925fd5"), "TG", 223 },
                    { new Guid("5470eb7c-c2dd-4b37-a261-d1060de399cf"), "TK", 224 },
                    { new Guid("2ff2abe7-4d46-4ddb-aceb-f7156ec94dcb"), "TO", 225 },
                    { new Guid("ca86647a-f8da-4bb3-9304-531247544aa3"), "TT", 226 },
                    { new Guid("dcc2b781-ef65-4406-b94f-91e5f236c104"), "TN", 227 },
                    { new Guid("e1bc8935-6bea-4c34-b289-980c861d503e"), "TR", 228 },
                    { new Guid("daaf5442-94e5-493d-bd4b-66c3978dca78"), "TM", 229 },
                    { new Guid("e795e160-30ae-49f1-9fb6-ef54e9dea3d2"), "TC", 230 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("84aae4be-ba58-428a-a310-34aaf4992b5a"), "TV", 231 },
                    { new Guid("9e44d2f1-6d7b-4335-b6ab-d83316d249ec"), "UG", 232 },
                    { new Guid("84aa5a15-ffc2-4308-937e-e3a37b5f075f"), "UA", 233 },
                    { new Guid("1c63855c-238e-4b25-b2ff-f2c8cb594b12"), "AE", 234 },
                    { new Guid("513b4ff3-9274-4605-a6cd-7ab5d6fe7c73"), "GB", 235 },
                    { new Guid("22091318-cd6b-4049-9911-efce3eeb3deb"), "US", 236 },
                    { new Guid("1eddaf41-9746-46c0-868b-b4303bfa007b"), "UM", 237 },
                    { new Guid("787e5033-5f97-4e81-8953-a1b41724dc0f"), "UY", 238 },
                    { new Guid("3633ea89-ac98-4a77-ba6d-f4744929132b"), "UZ", 239 },
                    { new Guid("e2e8f63c-f1a4-4135-bd23-056730a22a52"), "VU", 240 },
                    { new Guid("fdf16a7e-6f06-47a8-bd53-da2ddd31cdec"), "VE", 241 },
                    { new Guid("97eca2aa-9a97-4365-8356-50d49bd58034"), "VN", 242 },
                    { new Guid("70fbe487-a108-4bf4-a79f-02287d4331aa"), "VG", 243 },
                    { new Guid("221ec5b8-f75b-4063-85d7-3de7ca4e0092"), "VI", 244 },
                    { new Guid("4a585fd3-7ffa-4f89-a3eb-c8f7d6bdfa59"), "WF", 245 },
                    { new Guid("4ca05911-3157-4bfb-a678-f424cb655b98"), "EH", 246 },
                    { new Guid("09067e50-dab7-44fe-b5d9-61b734bc0ede"), "YE", 247 },
                    { new Guid("86c57c4d-8f12-45b5-8581-946c3fc3d481"), "ZM", 248 },
                    { new Guid("9d647981-183d-4844-a312-4f26695b356e"), "ZW", 249 },
                    { new Guid("0946c5d4-8b53-4852-8bb3-0accc3deebac"), "TL", 222 },
                    { new Guid("8950f339-2769-441b-a9b8-1a8106320b9f"), "TH", 221 },
                    { new Guid("209c6e53-b31d-423a-860a-b3371bfc2084"), "TZ", 220 },
                    { new Guid("644aaf2c-b35f-4f35-bae2-9d42bb217cf7"), "TJ", 219 },
                    { new Guid("86ca958d-c720-4c6d-b3d7-7da7140c29cc"), "VC", 191 },
                    { new Guid("8d9cb652-b271-428b-9d8a-4cd90adcd4e9"), "WS", 192 },
                    { new Guid("16ab42ff-8ddc-4f25-a64c-c0c23a8c5f59"), "SM", 193 },
                    { new Guid("694871b5-bbd7-4129-b133-444d30d77bce"), "LR", 126 },
                    { new Guid("11de18e3-c37b-4401-97b0-48d8b0fa8176"), "SA", 195 },
                    { new Guid("7f66abe7-2a21-4807-9fe1-b740facd62e0"), "SN", 196 },
                    { new Guid("efae3600-d8a4-4312-afa6-2a58f73b18b2"), "RS", 197 },
                    { new Guid("bcfa6a62-0a90-41ca-9270-027da98d1c5d"), "SC", 198 },
                    { new Guid("84a1a222-b9a3-40b0-b9bd-5f206aae3380"), "SL", 199 },
                    { new Guid("7333b43e-65a1-42da-81aa-ab0261bc1949"), "SG", 200 },
                    { new Guid("2fe39403-c091-40d7-a13c-f45dc9fdc290"), "SX", 201 },
                    { new Guid("0fd57a12-26c5-4105-b3e0-d12502d781fc"), "SK", 202 },
                    { new Guid("0c4bbd83-0c25-4b9a-8fb6-8d34c448ed6f"), "SI", 203 },
                    { new Guid("4047a5c1-9b4b-417c-9a56-4fb811ebd051"), "MF", 189 },
                    { new Guid("5a118659-a2c5-4c64-9d23-2e5db25fdd6c"), "SB", 204 },
                    { new Guid("934f1188-3d4f-4311-925b-95b82b656242"), "ZA", 206 },
                    { new Guid("c9675524-ebfc-4d16-a40e-5b479d9600bf"), "GS", 207 },
                    { new Guid("118ba47e-d209-482b-b13b-c51507d5c9e5"), "SS", 208 },
                    { new Guid("77058d59-6cd1-4ced-93ba-7f2fa1fcea73"), "ES", 209 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("3f925f3c-f923-47cb-9047-6828e697857c"), "LK", 210 },
                    { new Guid("c8b13b9a-36f8-40ad-985d-70e1ad27b8a6"), "SD", 211 },
                    { new Guid("f164518f-2a99-497d-9a2e-47ec9f16ce38"), "SR", 212 },
                    { new Guid("8d2de3fa-b8af-45c6-9f83-c11987709e83"), "SJ", 213 },
                    { new Guid("4d5e4b5d-ab4a-4e85-bd0f-78d0fe33d036"), "SZ", 214 },
                    { new Guid("922f9763-699a-45e2-9e59-e5ab3ff2ae25"), "SE", 215 },
                    { new Guid("2f1eff27-e291-420a-b33a-2fcc90fece61"), "CH", 216 },
                    { new Guid("9a4f3a9e-464b-49b7-bd0b-f80caae39e86"), "SY", 217 },
                    { new Guid("7bf44862-2699-4965-a736-ad6774a7a43f"), "TW", 218 },
                    { new Guid("dd4f3d0f-f8fd-4660-8e21-36265f4d5cb9"), "SO", 205 },
                    { new Guid("8aa09226-408c-4d45-8097-0f00c6bb8dbd"), "LS", 125 },
                    { new Guid("13559ef0-ec8f-4df8-90a6-81c292bc5aa7"), "LU", 130 },
                    { new Guid("9b971e69-8006-4ec1-a6ee-0d5d12e9f8b4"), "LV", 123 },
                    { new Guid("bc4d43fb-b046-42ab-85f8-61efe7b70536"), "IO", 33 },
                    { new Guid("58742590-9402-4b92-882e-d83fc725482d"), "BN", 34 },
                    { new Guid("dc193b6f-18b6-4bbc-a472-8a9b57b2f3f2"), "BG", 35 },
                    { new Guid("392599b3-a796-47fa-895a-c2cac03501ba"), "BF", 36 },
                    { new Guid("1d94f49f-1b86-4030-8d76-050649351da5"), "BI", 37 },
                    { new Guid("6cc4d49f-966f-422c-8219-ed6a2672c4f7"), "CV", 38 },
                    { new Guid("e19c21fb-13b7-4843-87b1-a74aa064f8c9"), "KH", 39 },
                    { new Guid("76f3ab8a-771d-4fe6-a227-c14f92b04d60"), "CM", 40 },
                    { new Guid("51bea4f6-0a29-4d5d-9b83-3043080ed789"), "CA", 41 },
                    { new Guid("72050860-67c4-4eb0-add5-c3618ea6d543"), "KY", 42 },
                    { new Guid("b5a56e19-479d-40b3-b801-1247679cc13b"), "CF", 43 },
                    { new Guid("634df984-ab06-463d-be69-691f5d4c566b"), "TD", 44 },
                    { new Guid("133479e1-311e-4b1c-8bae-a2f216577737"), "CL", 45 },
                    { new Guid("4b905fe7-3ffc-4033-aa2a-0863b9c92523"), "CN", 46 },
                    { new Guid("84adffcc-ea28-4d36-a5ca-6f2677843910"), "CX", 47 },
                    { new Guid("66e934ae-9eaf-4a52-a1ef-be963a9297c2"), "CC", 48 },
                    { new Guid("197d16b2-94a1-4cb3-94de-28614c817a72"), "CO", 49 },
                    { new Guid("56758042-868b-4c65-9c80-ae751dcf8825"), "KM", 50 },
                    { new Guid("ba52c559-b282-46d8-a912-ec77675f904a"), "LB", 124 },
                    { new Guid("c9a2f1dd-4136-49db-80f1-be6e1a226d74"), "CD", 52 },
                    { new Guid("46f48d7c-8f16-44eb-a48b-5132ed9d1e77"), "CK", 53 },
                    { new Guid("b35bde70-3404-44f3-9a5e-a15b5b41847d"), "CR", 54 },
                    { new Guid("47a25aa3-d2b2-4ab1-8aef-cdd6edcee10e"), "CI", 55 },
                    { new Guid("0369a7a1-3693-4c77-be39-fb206f9f0a4a"), "HR", 56 },
                    { new Guid("153f28f3-0836-4664-962e-ae8aeeaf3103"), "CU", 57 },
                    { new Guid("1828affa-607e-4cee-8bed-dd15d80a3ddb"), "CW", 58 },
                    { new Guid("35cf161c-5de5-4cb1-a668-810064dfa37a"), "CY", 59 },
                    { new Guid("f60c0eb7-a830-4390-a80b-d2e73f82fb64"), "BR", 32 },
                    { new Guid("322f8a25-79cb-4784-b225-6d232caeeb71"), "BV", 31 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("b1009f00-aa17-449b-8dba-36b113ea9aa9"), "BW", 30 },
                    { new Guid("e6a99909-5759-48b1-91d2-efffeabe3a11"), "BA", 29 },
                    { new Guid("ee02752a-175b-4f4d-9a6a-9cdbb1cabb1f"), "AF", 1 },
                    { new Guid("de1eba2a-8bfa-4655-b600-6dedb4360faa"), "AX", 2 },
                    { new Guid("f547c091-3ad0-4c23-9ddd-f0dd1f21c9c8"), "AL", 3 },
                    { new Guid("9170884d-0805-4cc6-8bd6-9e91679cf12f"), "DZ", 4 },
                    { new Guid("58fe6adb-ce0f-4b0a-a60f-446cfef69844"), "AS", 5 },
                    { new Guid("d061ca3d-190b-469b-a7d9-065159bd2555"), "AD", 6 },
                    { new Guid("6a77f82b-1150-42d1-bc85-25ded591c345"), "AO", 7 },
                    { new Guid("fcee1adb-3dc9-4cea-bda8-a61cc0b0f9a2"), "AI", 8 },
                    { new Guid("0048c727-0274-4436-975e-5193969fd82e"), "AQ", 9 },
                    { new Guid("f7bbb2e9-1676-4a94-8c10-fce561c4cab6"), "AG", 10 },
                    { new Guid("698e1841-1bfb-42c6-890d-6dd99d6d3256"), "AR", 11 },
                    { new Guid("7b33fa09-354f-459c-8fb8-6f66b0ab05d2"), "AM", 12 },
                    { new Guid("2a08f668-cbad-4dd0-a2eb-85aad266ab7a"), "AW", 13 },
                    { new Guid("74dc9baf-3b2a-411f-8d9d-c758a54b220e"), "CZ", 60 },
                    { new Guid("877636f9-1976-4908-8e07-0afdb7cd27f9"), "AU", 14 },
                    { new Guid("26acbeef-277e-479c-b6ad-238b40c0cbff"), "AZ", 16 },
                    { new Guid("ac69545f-c506-4c0e-b344-ac35b044da55"), "BS", 17 },
                    { new Guid("699bd98f-58f4-4361-b157-c02205865e24"), "BH", 18 },
                    { new Guid("6d4ab862-fead-49e7-a12c-aa6f923350af"), "BD", 19 },
                    { new Guid("389fb376-963d-45f2-82ad-35ee2ca35374"), "BB", 20 },
                    { new Guid("a9688286-50dc-4263-8796-1b51cd99d985"), "BY", 21 },
                    { new Guid("7df8285d-920a-4205-af29-a06f801e35d3"), "BE", 22 },
                    { new Guid("ad8ff767-9c3b-46ff-b72b-b5ae481f4aca"), "BZ", 23 },
                    { new Guid("acdefcb0-e8cd-4130-9b9c-c5635b326e5b"), "BJ", 24 },
                    { new Guid("b1faf8d7-37a0-487c-8b31-de1273291f6b"), "BM", 25 },
                    { new Guid("7bf59fc7-ea57-4e9c-a11e-f217767c5980"), "BT", 26 },
                    { new Guid("84ca8e0b-0a50-4fec-8b64-25cd73ffb08d"), "BO", 27 },
                    { new Guid("3cd59006-2cc2-473b-bc62-478ef49d7de3"), "BQ", 28 },
                    { new Guid("a28c5acc-dfb4-4ce3-aec2-eefc6119a5fe"), "AT", 15 },
                    { new Guid("c963fb17-caab-4446-9324-98f0abc5fda4"), "DK", 61 },
                    { new Guid("3fc99b18-c72b-4e88-9baf-ff43d3228e97"), "CG", 51 },
                    { new Guid("9d1feccd-b34e-43ac-a1f9-37ed65767ec6"), "DM", 63 },
                    { new Guid("a0e6d769-6b77-4ab9-a135-b7f56a10582e"), "HT", 96 },
                    { new Guid("6295bcf9-1d52-40dd-9034-c8ac5d36e2a8"), "HM", 97 },
                    { new Guid("8a8f6f0f-a12e-461d-b847-4698e0087833"), "VA", 98 },
                    { new Guid("5ba8464c-a219-46e8-872e-1f3af48987ad"), "HN", 99 },
                    { new Guid("774d35f7-16c8-4638-889a-ec3582b2dac6"), "HK", 100 },
                    { new Guid("18e998e1-556c-4a54-b3be-e96b9cfd3586"), "HU", 101 },
                    { new Guid("e0677999-66ea-4e8f-8fa2-14879a0a55e2"), "IS", 102 },
                    { new Guid("fdf4b620-b552-4026-8ec9-688044a2f264"), "IN", 103 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("26e24b48-f1c3-4324-a216-8648ea8ce96d"), "ID", 104 },
                    { new Guid("ce70d9f3-0cd7-47ea-b449-321d2b47d5ba"), "DJ", 62 },
                    { new Guid("3a450dd3-b542-4219-a114-7ce866f0b014"), "IQ", 106 },
                    { new Guid("155f67df-11d5-482f-8078-439a98c0db1b"), "IE", 107 },
                    { new Guid("3653d1fb-b78b-4af3-a07b-f4c7805c4848"), "IM", 108 },
                    { new Guid("81c21925-d860-45df-b717-a7a4c96dca36"), "IL", 109 },
                    { new Guid("b425c8a8-0ee2-416a-9800-dbc2e76a1e02"), "IT", 110 },
                    { new Guid("6d804a88-f71a-4ccc-a4bb-5ef29da5d25e"), "JM", 111 },
                    { new Guid("e25cd762-f8ad-4191-820b-5a21b4a57dd5"), "JP", 112 },
                    { new Guid("30eb8ed6-c1d1-4d00-ad73-e38f312fedb4"), "JE", 113 },
                    { new Guid("25c3c395-a6b9-4555-a893-82febe3e5945"), "JO", 114 },
                    { new Guid("7493d7ea-0a2e-4db5-a79e-72c7099b938b"), "KZ", 115 },
                    { new Guid("10c06541-720b-4914-b3fd-bdb12f692f86"), "KE", 116 },
                    { new Guid("32e1fc1a-fdf6-41b0-b1f4-deedcc1fd3cc"), "KI", 117 },
                    { new Guid("06c6541f-4cec-4fcf-9492-88282a77f9b7"), "KP", 118 },
                    { new Guid("bc668ba6-9f1c-4220-80d2-40ad66f81aaf"), "KR", 119 },
                    { new Guid("0d3a4693-22e5-4b24-916f-ae040bcfdfcb"), "KW", 120 },
                    { new Guid("f05acf2a-f23d-41ea-a757-2d22347670f7"), "KG", 121 },
                    { new Guid("0e208ed9-43f0-4853-b0df-3eee5ca83ca0"), "LA", 122 },
                    { new Guid("fddb1513-5487-4d24-b5d1-8912d248c6b8"), "GY", 95 },
                    { new Guid("239270a9-b4ff-4eaf-82ac-6c895af9aad7"), "GW", 94 },
                    { new Guid("80d2a6ec-6831-4b80-97c1-b52d749121bd"), "IR", 105 },
                    { new Guid("2cfa3ba8-0f62-4b55-8d3b-d43d79bdd635"), "GG", 92 },
                    { new Guid("72faf281-3a64-470d-9c4f-cba7745f0c3d"), "DO", 64 },
                    { new Guid("3159abab-bb7e-445e-aef6-aff79ee87458"), "EC", 65 },
                    { new Guid("f02cd36c-3499-47ce-b732-b87ce3eb9772"), "EG", 66 },
                    { new Guid("053cc8d1-65b7-43e1-8b26-28ee3d504d5f"), "GN", 93 },
                    { new Guid("037afd35-f200-4e0b-8ba4-52612c136063"), "SV", 67 },
                    { new Guid("1a3acd53-90b4-49e8-9d01-2afea273ee0e"), "ER", 69 },
                    { new Guid("fc4d9cd2-5af0-4636-bd48-5298636049d3"), "EE", 70 },
                    { new Guid("14a79347-9a83-4715-a2a1-1906f071d3a8"), "ET", 71 },
                    { new Guid("6c8c9ed6-2b2b-4a22-a154-e5e7c34cd6e2"), "FK", 72 },
                    { new Guid("77b58ec3-4d73-40d4-ab2a-f7aaad42c443"), "FO", 73 },
                    { new Guid("202eb601-d2c4-43e6-b441-754e989f9bda"), "FJ", 74 },
                    { new Guid("b254c038-3ab8-4b0a-abd7-4a3d96a3b9e7"), "FI", 75 },
                    { new Guid("55b7c2f5-2fd7-441a-9081-103ad4cb1c27"), "FR", 76 },
                    { new Guid("139416b3-dafe-4101-9c24-cb13b828698c"), "GF", 77 },
                    { new Guid("aca4ad52-09ea-43f6-9507-ff50a4f8183f"), "GQ", 68 },
                    { new Guid("df07483e-d71f-43c0-a6cb-76a94bd2856a"), "TF", 79 },
                    { new Guid("46a800df-4a30-41ab-9b64-116f044b2555"), "GA", 80 },
                    { new Guid("c4366b50-90ad-482b-ae3d-a8678996a72a"), "GM", 81 },
                    { new Guid("2a24e370-dda0-476a-8024-744efc2bceea"), "GE", 82 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("a8303add-b05c-43cd-9f50-722c16345410"), "DE", 83 },
                    { new Guid("deccbaf1-ef61-487e-a018-74f56104f578"), "GH", 84 },
                    { new Guid("ae7ca192-6be6-4140-967b-fdc3147e807e"), "GI", 85 },
                    { new Guid("21a7ebd7-fe44-4804-b34c-d77bfcae3f7b"), "GR", 86 },
                    { new Guid("d6849a69-8a2e-46cb-bb28-628cdad8b383"), "PF", 78 },
                    { new Guid("791a58e0-cfbd-432d-b286-df1364a3fd12"), "GL", 87 },
                    { new Guid("7cfa4bbc-abf7-49d1-a1cd-fd4d1c14598a"), "GD", 88 },
                    { new Guid("211b37e3-6955-4992-a4f8-b67b4a8ef951"), "GP", 89 },
                    { new Guid("ed032c81-4c2e-4cec-9feb-b3024f0f09a3"), "GU", 90 },
                    { new Guid("a306c837-272e-4c21-b113-d76540a68491"), "GT", 91 }
                });

            migrationBuilder.InsertData(
                table: "MachineDimensionsType",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("ff77b51e-1019-49fb-9837-a054277eea69"), "THREE_PLUS_TWO_AXIS", 1 },
                    { new Guid("b0ba1076-32e9-4683-9daa-4332734b5cc7"), "FIVE_AXIS", 2 },
                    { new Guid("0a4a1633-b058-4d8a-a066-b83d6dc63e58"), "THREE_AXIS", 0 }
                });

            migrationBuilder.InsertData(
                table: "MillingMachineDimensionsTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("5ce52734-cdc6-4b7f-8180-c9a1a5b357db"), "FIVE_AXIS", 2 },
                    { new Guid("638e7164-0cb9-4a37-a716-2af0437d3475"), "THREE_PLUS_TWO_AXIS", 1 },
                    { new Guid("f32bad09-eb6c-45bf-a0ef-abea908b330c"), "THREE_AXIS", 0 }
                });

            migrationBuilder.InsertData(
                table: "MillingMachineTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("a26ac0e4-677a-48fc-8384-c9454f92778e"), "TYPE_1", 0 },
                    { new Guid("13daa247-12f7-4885-966e-276dc3722694"), "TYPE_2", 1 },
                    { new Guid("5fdcf81d-00f5-45b6-91f4-0b19bceb8550"), "TYPE_3", 2 },
                    { new Guid("c83bacb5-c1cd-4b25-9f07-29360d29d166"), "TYPE_4", 3 }
                });

            migrationBuilder.InsertData(
                table: "OtherTechnologies",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("6b33a4e0-e41a-48a4-86b7-3710e5d9915f"), "Other", 8 },
                    { new Guid("5310b489-8165-4fc9-970b-6eeb03507ed9"), "Annealing", 7 },
                    { new Guid("3f3ddc24-6a9a-42e5-870e-fe7feb7a5806"), "Knurling", 6 },
                    { new Guid("55dd3dfc-c30e-4eeb-8ee5-e39a99b79f93"), "Toothings", 3 },
                    { new Guid("c2fd923a-ab53-4472-a622-3128ac911a7e"), "Engravings", 4 },
                    { new Guid("e4a35ad3-90ed-4de9-808a-e4780cba505b"), "ThreadsTr", 2 },
                    { new Guid("d424f88d-3d6e-44f4-9fed-d5917a39e52d"), "ThreadsM", 1 },
                    { new Guid("2cfcbb75-3a13-4eae-8c7f-7953f198d11e"), "DeepHoleDrilling", 0 },
                    { new Guid("3a09b1c8-5c5b-463f-8dfa-352f2cf0f947"), "LaserMarking", 5 }
                });

            migrationBuilder.InsertData(
                table: "TurningMachineTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("d61e11f4-ce6f-4e98-a1b7-5c88623052b5"), "TURNING_MACHINE_TYPE_3", 2 },
                    { new Guid("e8706c40-4e55-4b7d-9430-2b049c4fef24"), "TURNING_MACHINE_TYPE_4", 3 },
                    { new Guid("94857418-d240-44a5-ba38-4b0ed0e13d9a"), "TURNING_MACHINE_TYPE_1", 0 },
                    { new Guid("36f8452a-176a-4ea8-ad8f-f9f8ecfe3c58"), "TURNING_MACHINE_TYPE_2", 1 },
                    { new Guid("ae33f04c-5c84-4bcb-8f21-9515fd4d5082"), "TURNING_MACHINE_TYPE_5", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_AddressTypeId",
                table: "Address",
                column: "AddressTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_CountryCodeTypeId",
                table: "Address",
                column: "CountryCodeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_CustomerId",
                table: "Address",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CertificationCustomer_CustomersId",
                table: "CertificationCustomer",
                column: "CustomersId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAdditionalInfo_CustomerId",
                table: "CustomerAdditionalInfo",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerOtherTechnology_OtherTechnologiesId",
                table: "CustomerOtherTechnology",
                column: "OtherTechnologiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CompanySizeTypeId",
                table: "Customers",
                column: "CompanySizeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MillingMachine_CustomerId",
                table: "MillingMachine",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_MillingMachine_MillingMachineDimensionsTypeId",
                table: "MillingMachine",
                column: "MillingMachineDimensionsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MillingMachine_MillingMachineTypeId",
                table: "MillingMachine",
                column: "MillingMachineTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Registration_CustomerId",
                table: "Registration",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TurningMachines_CustomerId",
                table: "TurningMachines",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_TurningMachines_TurningMachineTypeId",
                table: "TurningMachines",
                column: "TurningMachineTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "CertificationCustomer");

            migrationBuilder.DropTable(
                name: "ContactPerson");

            migrationBuilder.DropTable(
                name: "CustomerAdditionalInfo");

            migrationBuilder.DropTable(
                name: "CustomerOtherTechnology");

            migrationBuilder.DropTable(
                name: "MachineDimensionsType");

            migrationBuilder.DropTable(
                name: "MillingMachine");

            migrationBuilder.DropTable(
                name: "Registration");

            migrationBuilder.DropTable(
                name: "TurningMachines");

            migrationBuilder.DropTable(
                name: "AddressTypes");

            migrationBuilder.DropTable(
                name: "CountryCodeTypes");

            migrationBuilder.DropTable(
                name: "Certifications");

            migrationBuilder.DropTable(
                name: "OtherTechnologies");

            migrationBuilder.DropTable(
                name: "MillingMachineDimensionsTypes");

            migrationBuilder.DropTable(
                name: "MillingMachineTypes");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "TurningMachineTypes");

            migrationBuilder.DropTable(
                name: "CompanySizeTypes");
        }
    }
}
