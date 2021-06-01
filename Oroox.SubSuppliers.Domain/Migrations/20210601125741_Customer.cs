using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Oroox.SubSuppliers.Domain.Migrations
{
    public partial class Customer : Migration
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
                name: "CustomerAdditionalInfos",
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
                    table.PrimaryKey("PK_CustomerAdditionalInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerAdditionalInfos_Customers_CustomerId",
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
                name: "Registrations",
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
                    table.PrimaryKey("PK_Registrations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registrations_Customers_CustomerId",
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
                    { new Guid("34886496-ea22-500e-aa59-40222468f04c"), "Shipping", 0 },
                    { new Guid("26b5d663-7ee5-5e5e-9fd3-c6793819a381"), "Billing", 1 }
                });

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("14aa380d-60c8-58d1-9ae3-883bfb888f1b"), "ISO9001", 0 },
                    { new Guid("e506ca6f-f131-5f2e-a61a-0b6cece3cc4b"), "ISO14001", 1 },
                    { new Guid("641c35c9-72d5-591b-98de-ae0f2d54c35d"), "ISO13485", 2 },
                    { new Guid("e05c5cb2-62e9-5a95-93b1-99ce38938420"), "ITAF16949", 3 },
                    { new Guid("5a52d9ab-d197-5e1c-bcec-d5a5270c62fb"), "EN9100", 4 },
                    { new Guid("28a87d3e-bd22-503c-9d05-0796440fee66"), "Other", 5 }
                });

            migrationBuilder.InsertData(
                table: "CompanySizeTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("2e6c3fed-bdc4-592b-bc30-6a68e32bed7c"), "LessThan100", 100 },
                    { new Guid("85b1ee2c-1907-59a2-b31d-478ffbb68fca"), "LessThan50", 50 },
                    { new Guid("cbbb988e-fb72-5870-8b4a-d7cbb3c93974"), "MoreThan100", 101 },
                    { new Guid("932bc137-dce8-5a26-86db-0d62c29af0fc"), "LessThan10", 10 },
                    { new Guid("a7df4e3c-4cc8-57b9-a3ca-fe7df7bf6112"), "LessThan25", 25 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("da02bbac-a80e-5a16-89a7-c085212d24bd"), "PA", 171 },
                    { new Guid("92d99290-2a2e-5b3b-b2ab-64482839d159"), "NI", 160 },
                    { new Guid("66b8b1c6-ac96-5066-8534-1927594c9d72"), "NE", 161 },
                    { new Guid("42701c99-5139-52ea-bf75-02b968a83c58"), "NG", 162 },
                    { new Guid("7408eb3c-13ff-52bb-b597-53d4359f5f28"), "NU", 163 },
                    { new Guid("0d7945f6-7330-5bd6-99e5-eba2ce263b62"), "NF", 164 },
                    { new Guid("66f17a80-f468-53b1-9322-b7ab386bc84d"), "MP", 165 },
                    { new Guid("9df06e8b-6807-5691-adab-2d1042fc1704"), "NO", 166 },
                    { new Guid("a063d2a6-9033-5fc1-9f58-ba3304edc4b2"), "OM", 167 },
                    { new Guid("50847080-8158-5fb6-a56c-a103df10c0f2"), "PK", 168 },
                    { new Guid("6a6a8a96-c842-54d7-82be-005a21a7146d"), "PW", 169 },
                    { new Guid("58eefe0f-2497-54b5-947e-e96648b1f057"), "PS", 170 },
                    { new Guid("def8666f-ad90-5a17-81e4-21da103fe4d4"), "PG", 172 },
                    { new Guid("19362117-cba1-5ec6-9f0a-d645e1ade937"), "PR", 179 },
                    { new Guid("906e270e-04c8-5b4f-8115-d7c8c826750f"), "PE", 174 },
                    { new Guid("84064b0c-1661-5a48-aeac-d244e213e491"), "PH", 175 },
                    { new Guid("f361ad1e-76b6-5de1-9106-8a4e02d42a4f"), "PN", 176 },
                    { new Guid("284e1ea3-67ee-572a-b167-402423ab15e4"), "PL", 177 },
                    { new Guid("cc6c69bc-e945-501d-bec6-d4e2ea14296c"), "PT", 178 },
                    { new Guid("f4dc7cdb-1946-584b-b792-a392f23ddff1"), "NZ", 159 },
                    { new Guid("5a66dc51-24e9-5b76-8f5b-17ce40a204d1"), "QA", 180 },
                    { new Guid("b376f7b5-44f7-5701-8ef1-64d64154d554"), "RE", 181 },
                    { new Guid("da6073ac-b698-5016-8d3c-40783a729f54"), "RO", 182 },
                    { new Guid("4a1b09d0-f985-56a3-81f6-0c8057ebae88"), "RU", 183 },
                    { new Guid("27a0adc0-b178-5009-8cf4-8fccd3b08324"), "RW", 184 },
                    { new Guid("3d2d9173-d1dc-5e00-a046-ba150f99ed43"), "BL", 185 },
                    { new Guid("1c9c3915-fbf1-5d25-b935-e0b076800a1e"), "SH", 186 },
                    { new Guid("5d9f0744-e750-512a-af07-15837ac452fd"), "PY", 173 },
                    { new Guid("cdd269d4-e890-5b50-a5ba-fcab8badcb39"), "NC", 158 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("06fad6b9-7bb3-5ed8-b299-6ac4884d814e"), "MA", 151 },
                    { new Guid("736a044f-f149-5d6f-8bab-d625b9c8032a"), "NP", 156 },
                    { new Guid("2459b285-9f5e-55a2-8435-0f0294d21ff7"), "LY", 127 },
                    { new Guid("684c3026-72e9-5fd1-a881-1800733a7d3c"), "LI", 128 },
                    { new Guid("c046855a-cce6-53de-a20f-e840a9c98ea1"), "LT", 129 },
                    { new Guid("22507012-6555-57c2-bb1e-fa6a7c41e5b1"), "MO", 131 },
                    { new Guid("7b8a60e6-975e-5d06-848c-97d0880bb8fa"), "MK", 132 },
                    { new Guid("b5947d2d-725b-5254-b21a-6e25c33cdc49"), "MG", 133 },
                    { new Guid("2f7c2ad3-fbbc-5122-a3a0-225458425122"), "MW", 134 },
                    { new Guid("7ef3e606-e697-569c-95c9-4d0b18540678"), "MY", 135 },
                    { new Guid("106072e9-92e8-542b-9dd8-823abfd97d87"), "MV", 136 },
                    { new Guid("e8ab98ee-2bca-51a5-a249-823ff8061e32"), "ML", 137 },
                    { new Guid("713f3ca9-78c2-591f-9468-83bb9b523c20"), "MT", 138 },
                    { new Guid("412b0236-f575-54f0-8957-6c059b3ceec1"), "MH", 139 },
                    { new Guid("cf51738a-0308-54cb-b869-a185178e0888"), "MQ", 140 },
                    { new Guid("9b5e2aac-27ca-574d-9755-71939805f788"), "NL", 157 },
                    { new Guid("96f30a54-0a3e-52df-b498-fc3206ee2728"), "MR", 141 },
                    { new Guid("9ce5876b-c2c8-5c19-885e-a17392aa123a"), "YT", 143 },
                    { new Guid("3e9c4612-e4fe-5bcd-9630-5399395e0ef0"), "MX", 144 },
                    { new Guid("bae7b99b-e070-5709-9644-50d3dffd1e62"), "FM", 145 },
                    { new Guid("b1f3b4f0-e6f3-5486-a730-ff6d8468d269"), "MD", 146 },
                    { new Guid("10a1d13c-b078-551d-bfbd-05fe212f9f38"), "MC", 147 },
                    { new Guid("219c6296-27e7-543b-b859-c26a943554e6"), "MN", 148 },
                    { new Guid("7d502e58-9c21-55f3-a132-8b2c8017dd4a"), "ME", 149 },
                    { new Guid("32d0be12-d418-506d-91ea-080591ca4c99"), "MS", 150 },
                    { new Guid("b97bf153-a19f-5641-9081-d08d5a780776"), "KN", 187 },
                    { new Guid("c034306b-99f4-5bab-879a-080e733444f2"), "MZ", 152 },
                    { new Guid("52fa3e58-6312-5494-b6a6-ae5d43116a59"), "MM", 153 },
                    { new Guid("9a0516d2-29fe-5df3-9a5c-df404692fc0e"), "NA", 154 },
                    { new Guid("c29b86df-cc26-5bb2-a745-d1e52641f4a5"), "NR", 155 },
                    { new Guid("9b073671-f5ed-53fd-825f-e1077f833264"), "MU", 142 },
                    { new Guid("c1caf197-a4c2-5d4c-a3a5-08a57b405b5a"), "LC", 188 },
                    { new Guid("94200377-2fd9-519f-ab70-54c0e1a7955c"), "ST", 194 },
                    { new Guid("937134a2-d327-522f-a127-d4d24a4df985"), "PM", 190 },
                    { new Guid("cb0db61d-abe2-5829-b61c-330345b33502"), "TG", 223 },
                    { new Guid("b57d6afe-5b1a-5112-b5da-4497dd330ad8"), "TK", 224 },
                    { new Guid("7c0e946e-cc0c-5810-bb6f-1163dd1bc643"), "TO", 225 },
                    { new Guid("2d417b25-b6bf-56e2-bdfe-cbb6d8f3beac"), "TT", 226 },
                    { new Guid("59cb9f3e-4fb3-5531-9a3f-cc988c794e6f"), "TN", 227 },
                    { new Guid("1d95447a-28ec-57f5-8177-472968bfea8f"), "TR", 228 },
                    { new Guid("9f00ddab-32c8-51f5-ac9c-9e9393b75776"), "TM", 229 },
                    { new Guid("021fb1e9-9074-5fea-a41c-fb2c3c16354a"), "TC", 230 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("85138b8d-26dc-583b-9032-a01591bd9736"), "TV", 231 },
                    { new Guid("04d263b8-0466-5f86-8376-09c329044ee4"), "UG", 232 },
                    { new Guid("4048d4d1-3d69-50e7-a1a1-76cb6de6a702"), "UA", 233 },
                    { new Guid("6cc7e144-6727-5590-af5d-b2663d8a0841"), "AE", 234 },
                    { new Guid("fba0bac2-ce46-5cbf-9542-5aa9305ceb9b"), "GB", 235 },
                    { new Guid("bf5664a0-0a44-5bfb-a37b-5caf4ef567c7"), "US", 236 },
                    { new Guid("9ca2cd9f-03c7-58fd-9524-87e8d6209cba"), "UM", 237 },
                    { new Guid("81cc7738-58fb-54ee-ba35-950150de5f69"), "UY", 238 },
                    { new Guid("9712cd9a-fcab-5dac-b55d-6dd09654f34a"), "UZ", 239 },
                    { new Guid("5a305e87-b862-585b-8a45-f1c5b2776cc4"), "VU", 240 },
                    { new Guid("6887440e-7736-547d-be20-4822ef2340cd"), "VE", 241 },
                    { new Guid("ee1b26ff-b221-5fff-bef7-0b4de4043bb0"), "VN", 242 },
                    { new Guid("177e662e-59a8-55a5-a9e5-d5eda1419a1c"), "VG", 243 },
                    { new Guid("9a92be65-0499-5152-9952-9d8be38483e6"), "VI", 244 },
                    { new Guid("c32abbdb-e8de-5571-ad09-4d27ad5e06c3"), "WF", 245 },
                    { new Guid("aee2655b-0ebe-5e72-bf46-9eed3b3ef206"), "EH", 246 },
                    { new Guid("2162dc66-5a53-5e69-89e1-42b2e78078db"), "YE", 247 },
                    { new Guid("c8e921e0-5638-51c1-b1b7-a218d7555f56"), "ZM", 248 },
                    { new Guid("4c572aa6-a4ce-54de-96bd-9a2a022dc6bf"), "ZW", 249 },
                    { new Guid("0b573f20-c324-5e3a-836e-8d33d3bffb4e"), "TL", 222 },
                    { new Guid("3d477486-23c3-5a9d-82d7-630bdfaf733d"), "TH", 221 },
                    { new Guid("fb221bc0-1cd8-5f36-8429-7f832029bbb3"), "TZ", 220 },
                    { new Guid("126fb8ce-2e68-58c7-9869-c9bcd2aca785"), "TJ", 219 },
                    { new Guid("2d9947ea-6fcd-5163-ad58-1a883fcd363d"), "VC", 191 },
                    { new Guid("06aaee45-c3ab-5231-9def-d9379c8d649b"), "WS", 192 },
                    { new Guid("1a31f12d-243d-5aae-b9fd-c080c81c930e"), "SM", 193 },
                    { new Guid("a416f3ae-0bb1-5d9f-8a13-c8e79995b875"), "LR", 126 },
                    { new Guid("df14f3fc-6ab7-5e01-bd9a-f0556d9cfd31"), "SA", 195 },
                    { new Guid("f1429641-bc3f-56e7-a0bd-69a65aa84080"), "SN", 196 },
                    { new Guid("1e4b1e0f-e4bb-5ec2-93cd-75eaf99ba869"), "RS", 197 },
                    { new Guid("909543e1-2c15-543c-8fab-9c4d15daccd0"), "SC", 198 },
                    { new Guid("dcee4812-9169-5947-954e-4e7a0d8e99ac"), "SL", 199 },
                    { new Guid("832f7f41-212d-5b25-a4a9-dfdcc0574c23"), "SG", 200 },
                    { new Guid("775d367d-b405-5584-8981-6746ff94e0e4"), "SX", 201 },
                    { new Guid("14cf7da4-b27c-545c-988c-9407ad9ce1d9"), "SK", 202 },
                    { new Guid("43b08f9d-40b3-52d5-a9e8-1d0ee43807a3"), "SI", 203 },
                    { new Guid("ce1199a1-5d94-5f50-9bdd-b6bc8445978b"), "MF", 189 },
                    { new Guid("967f2694-4ffb-5cf1-b7a4-8c3ba28430f2"), "SB", 204 },
                    { new Guid("499e3dad-335f-570e-81e6-30f60857c624"), "ZA", 206 },
                    { new Guid("e4cb1249-ae70-5c4b-aad7-da2de90380f3"), "GS", 207 },
                    { new Guid("bac00e65-fc94-5d05-be9f-3ed7a5306b2b"), "SS", 208 },
                    { new Guid("4e99487d-6d98-5510-a5bd-3c69ac63c10e"), "ES", 209 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("2654af3e-88fd-57de-a302-b13b6b7942d8"), "LK", 210 },
                    { new Guid("4a9c0d1f-3cbc-5d99-a558-445b78ec89ef"), "SD", 211 },
                    { new Guid("de2f4b46-0417-54dd-9029-0e03248391ab"), "SR", 212 },
                    { new Guid("76f8337b-bc12-5474-b9fd-7eb74545d95f"), "SJ", 213 },
                    { new Guid("2d845d48-c266-5a37-874e-7006870202b2"), "SZ", 214 },
                    { new Guid("e6eca6b6-2da3-5a0a-8eb3-f7079172d9eb"), "SE", 215 },
                    { new Guid("b2c55b1a-605c-588e-a997-e47a3525d3bb"), "CH", 216 },
                    { new Guid("d0442ceb-0038-5082-9a9e-0ef14e673c4b"), "SY", 217 },
                    { new Guid("9295726a-4a22-58e4-906a-a155fef490a6"), "TW", 218 },
                    { new Guid("edcf1c73-20e7-5d33-988c-c019e19c05c0"), "SO", 205 },
                    { new Guid("3c85028e-2976-56a3-bd84-ea1f6db32e23"), "LS", 125 },
                    { new Guid("64fc9d4a-5f33-57b0-9e28-ca6e1f9cfa28"), "LU", 130 },
                    { new Guid("b8f9e4a7-f9fa-54cf-a0c7-343667493681"), "LV", 123 },
                    { new Guid("cf8e676b-77df-5550-b785-601465aceddf"), "IO", 33 },
                    { new Guid("bbab455e-befa-5f2d-8571-0756fc910d84"), "BN", 34 },
                    { new Guid("b27b2fee-e8e6-5e56-960a-f76a3148739d"), "BG", 35 },
                    { new Guid("0961867c-e5c5-5f0d-86b1-691e5e53e258"), "BF", 36 },
                    { new Guid("3b5b6040-7010-5c9d-b229-3c056574b82d"), "BI", 37 },
                    { new Guid("24424acb-f27c-5212-a42f-b066e3f11a04"), "CV", 38 },
                    { new Guid("e6ea9650-fd71-55f4-9259-7479094cd61e"), "KH", 39 },
                    { new Guid("0f214bb5-e466-54a1-809d-48750454b5b0"), "CM", 40 },
                    { new Guid("e1c455b6-c80b-51cf-b609-20b63f68eebc"), "CA", 41 },
                    { new Guid("d04d1bf5-2589-51f1-96d0-aeca74c18a49"), "KY", 42 },
                    { new Guid("158a1070-2360-54fb-b174-f2e76b60c848"), "CF", 43 },
                    { new Guid("4077b08b-fb2a-54c9-9e66-01b9204c475c"), "TD", 44 },
                    { new Guid("80e040d5-728a-5d13-8d95-2b95c157bfc4"), "CL", 45 },
                    { new Guid("4f04f755-61d4-5529-83a1-22eb54e4505a"), "CN", 46 },
                    { new Guid("2c9191ad-1fcb-59ef-bddc-9347381b1939"), "CX", 47 },
                    { new Guid("d49e51a4-b93e-5dd8-9f2f-49cfb3bf901b"), "CC", 48 },
                    { new Guid("8ad26ced-a0b4-5150-b1e8-65aefc298c36"), "CO", 49 },
                    { new Guid("10d1bb52-e4b0-5ef3-9097-3ed546cabb95"), "KM", 50 },
                    { new Guid("4cd11757-ef5f-5c4e-b42c-d3d53888e346"), "LB", 124 },
                    { new Guid("cb2fa77b-e87a-5ae1-b0eb-a613e14fc19b"), "CD", 52 },
                    { new Guid("c3e3c301-f714-556e-babe-53c75b3ab344"), "CK", 53 },
                    { new Guid("9a688895-0de5-5675-80bf-a4842fac2f85"), "CR", 54 },
                    { new Guid("f594fb99-332f-5890-8404-3e96d7a02b2c"), "CI", 55 },
                    { new Guid("2656c5f4-1557-54c7-9b94-3c828bcbdc4a"), "HR", 56 },
                    { new Guid("6b4dcac3-fc9c-583c-a990-fa6dfb7ffff0"), "CU", 57 },
                    { new Guid("9ffcd4e3-24fd-5e0e-8c73-cc932c4c499c"), "CW", 58 },
                    { new Guid("9b7022ef-9c26-57a7-9be4-f5eb3dee4661"), "CY", 59 },
                    { new Guid("d727b0d3-b402-53ce-81a5-a4c4f8727bb2"), "BR", 32 },
                    { new Guid("daa0d232-df91-5f73-8292-717a0ccb8340"), "BV", 31 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("756d0e6b-b5d9-5cd3-a3e8-1417a5a16fd0"), "BW", 30 },
                    { new Guid("d940fb15-8199-5726-aadc-014acbecbac6"), "BA", 29 },
                    { new Guid("5ca6401a-e7a6-57a5-824d-f805bde86779"), "AF", 1 },
                    { new Guid("92417a2b-bc5e-5201-8df0-526b8aaed1aa"), "AX", 2 },
                    { new Guid("a12b9a0c-21a7-5291-9477-8efef12323b1"), "AL", 3 },
                    { new Guid("eced8840-6107-5286-ba06-e45aae522a9d"), "DZ", 4 },
                    { new Guid("80a624b7-7f34-5217-b9f2-94b64642b8d6"), "AS", 5 },
                    { new Guid("5514b831-3207-5aa5-94d4-e250e06d7d45"), "AD", 6 },
                    { new Guid("2f01ca50-b347-5659-8d2c-6506ddb40d92"), "AO", 7 },
                    { new Guid("6d89926f-3a93-58b6-94bb-c158f5d0b613"), "AI", 8 },
                    { new Guid("123dd590-b2a8-5e8f-b3a0-1cf4d0bda000"), "AQ", 9 },
                    { new Guid("ac53a5a7-b286-5081-8e80-9bb049e7aebc"), "AG", 10 },
                    { new Guid("098f8ed7-3b56-5113-9c0c-8a7aec0173ae"), "AR", 11 },
                    { new Guid("245f95e6-2467-5280-99bf-61a23fdbb6b8"), "AM", 12 },
                    { new Guid("4406f10e-17f0-502c-8585-7e7b18e08a5f"), "AW", 13 },
                    { new Guid("8d2eb5f3-65e6-50de-9c08-2d79c5ad92db"), "CZ", 60 },
                    { new Guid("99bccbd8-4ed8-50ed-afd1-38576c63d14f"), "AU", 14 },
                    { new Guid("e8adcdd8-89ff-5394-baf7-e6571d34fa91"), "AZ", 16 },
                    { new Guid("19fe6bac-521b-5985-953a-d7359c061445"), "BS", 17 },
                    { new Guid("a4678229-8e1c-5ea3-833b-f563097d538c"), "BH", 18 },
                    { new Guid("b280a08e-6a0f-513b-832c-3cc0ae6c187b"), "BD", 19 },
                    { new Guid("3c85c3a8-935b-5224-861b-2459f810f03c"), "BB", 20 },
                    { new Guid("34af23fa-8ff1-519e-b8ba-07d94ae10158"), "BY", 21 },
                    { new Guid("8bfd6d84-9b8d-5c35-a3a1-1e08fb41aa91"), "BE", 22 },
                    { new Guid("108a2f59-9472-55fc-884f-93397f016fd4"), "BZ", 23 },
                    { new Guid("4e9a374c-6820-5e87-b270-cbbf13d625c0"), "BJ", 24 },
                    { new Guid("9be410ce-03f2-5711-9276-767926c22e41"), "BM", 25 },
                    { new Guid("39a40f90-cc0e-5b86-a67f-1980e9970785"), "BT", 26 },
                    { new Guid("83293fbb-1f99-5e42-8947-aa7407dfe055"), "BO", 27 },
                    { new Guid("bc786e8e-4b30-53cd-b625-b758456b74b8"), "BQ", 28 },
                    { new Guid("38e6e3ae-0b9c-509c-a1c3-0491033b9195"), "AT", 15 },
                    { new Guid("c1173fa6-ac66-579e-b6e9-cef9008b9c3c"), "DK", 61 },
                    { new Guid("fd005c52-dfd6-54dd-a64d-01185309ac61"), "CG", 51 },
                    { new Guid("bcc35689-47b1-5837-b41f-8481dc94bb4f"), "DM", 63 },
                    { new Guid("87c9c93a-fc56-5510-9046-cd19e17b483c"), "HT", 96 },
                    { new Guid("1afecb58-ffa0-5588-9ab5-61aba710a226"), "HM", 97 },
                    { new Guid("4b83ab99-173f-5c41-b786-ced320f2bbe4"), "VA", 98 },
                    { new Guid("2ee95aa1-8ebd-5f01-97e1-b322e3741dec"), "HN", 99 },
                    { new Guid("77742f9c-af50-5d4c-8b43-ba1b357697b8"), "HK", 100 },
                    { new Guid("340724a3-bbc5-52f3-be18-8d2aee1a048f"), "HU", 101 },
                    { new Guid("1163bb1b-d48b-5a58-88eb-97cdc4be250f"), "IS", 102 },
                    { new Guid("5f1c60ca-6b3d-52d4-ac28-2fff346fe340"), "IN", 103 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("79e78aff-0120-5a77-b11f-9e3ef277835a"), "ID", 104 },
                    { new Guid("ef713c0f-8684-5a97-a609-76c6b41af0b3"), "DJ", 62 },
                    { new Guid("4994f988-2ecf-5417-9fc9-cf7c8cd16070"), "IQ", 106 },
                    { new Guid("f977f2e9-9a0f-558b-88e8-0c717a3556f1"), "IE", 107 },
                    { new Guid("88f9703f-299a-5e3b-91a0-a69075a48009"), "IM", 108 },
                    { new Guid("a32e1715-6566-5fce-a146-33b081d0327b"), "IL", 109 },
                    { new Guid("ea3f2534-d570-5f97-b0a8-c8da47421923"), "IT", 110 },
                    { new Guid("ad5ccd9e-af32-5acb-9d40-4982da6a4e76"), "JM", 111 },
                    { new Guid("e2f11df5-c6e5-52ea-828c-afe9cb80a524"), "JP", 112 },
                    { new Guid("2eba375c-3bdb-517c-9b74-50971259601c"), "JE", 113 },
                    { new Guid("23e6055c-cf75-59f3-a7cc-571ee2d6fd46"), "JO", 114 },
                    { new Guid("a82720b1-2611-5119-b25d-a1fe4731352f"), "KZ", 115 },
                    { new Guid("02cfd30c-bbc8-57a4-bc47-2c97f53f1118"), "KE", 116 },
                    { new Guid("0cfb17ad-f594-57a7-8827-d3ea7f8c1b86"), "KI", 117 },
                    { new Guid("53726762-0569-54f5-9631-d5175212002f"), "KP", 118 },
                    { new Guid("2e65897d-f731-5685-b0a6-a38407edce80"), "KR", 119 },
                    { new Guid("f3dc1cc1-f842-5b1d-b519-a7ccf6be2bc3"), "KW", 120 },
                    { new Guid("9c75d3e3-0f33-5649-9597-da500385fc10"), "KG", 121 },
                    { new Guid("f0829a07-8be2-54b1-b2c3-360ad0b206a3"), "LA", 122 },
                    { new Guid("1803edc4-00ae-5703-bbbf-bf71529e0877"), "GY", 95 },
                    { new Guid("4a1ac73f-01e2-5125-947e-aafed4c64a87"), "GW", 94 },
                    { new Guid("c5157fd2-81ac-56f7-a748-a11a3056cb6e"), "IR", 105 },
                    { new Guid("a6a95a1f-e0b3-586e-af7b-c9fad083e5df"), "GG", 92 },
                    { new Guid("243ab93e-f179-5a5f-8a17-a4cb30798ea4"), "DO", 64 },
                    { new Guid("27dfd6ae-23cd-55e1-bde2-d583c1c2d195"), "EC", 65 },
                    { new Guid("a5873655-f611-5a8a-b628-3c49ad3b346f"), "EG", 66 },
                    { new Guid("035c5aa5-0b2c-5471-a127-84c12c25d856"), "GN", 93 },
                    { new Guid("b4af7cfa-5868-542c-ae6a-200909113fb4"), "SV", 67 },
                    { new Guid("9c95bc70-ec04-5cc2-a571-3da7465e976f"), "ER", 69 },
                    { new Guid("bdc65263-ad52-5214-9b5f-bf7004b00067"), "EE", 70 },
                    { new Guid("598f6a92-7976-5c9f-8b11-d00270e37536"), "ET", 71 },
                    { new Guid("f967421b-c49a-59df-939c-4ececfaddf8a"), "FK", 72 },
                    { new Guid("012e081d-ad96-519b-b72e-92adf8b8d6db"), "FO", 73 },
                    { new Guid("f7071bc0-062a-522e-998e-3d32770fe186"), "FJ", 74 },
                    { new Guid("16c266d0-f6cd-5322-870b-796c282fc2fe"), "FI", 75 },
                    { new Guid("8c3fa648-a1ab-5172-902d-9e6d396622a0"), "FR", 76 },
                    { new Guid("924a142e-3b4b-5bb2-b0df-d3b0f44ab43a"), "GF", 77 },
                    { new Guid("64debd5f-eabf-570e-8476-49b54742f8b5"), "GQ", 68 },
                    { new Guid("d6429fc3-35e0-5f38-9a94-c3c074d15780"), "TF", 79 },
                    { new Guid("f1b95a48-648f-57a1-9bb9-3782bcc4ec51"), "GA", 80 },
                    { new Guid("948e4475-78cf-5b81-a5a4-e516c4417e51"), "GM", 81 },
                    { new Guid("59f5527a-594b-55e0-bd96-b7ef9aaceca6"), "GE", 82 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("a8599586-d255-5536-a297-79a98379b83d"), "DE", 83 },
                    { new Guid("3592f59f-b5c7-5004-a907-d7523de63d3a"), "GH", 84 },
                    { new Guid("5a5bb905-22d8-52e4-8fac-95d01439d193"), "GI", 85 },
                    { new Guid("32f3b9e8-9559-5dde-89f0-8cb0559eb418"), "GR", 86 },
                    { new Guid("2c80272d-c886-5d89-8309-6ee43f8b5e4b"), "PF", 78 },
                    { new Guid("72f0a1de-7632-55dc-8bd6-6aa88fe6e09b"), "GL", 87 },
                    { new Guid("aa2e620c-8b97-53a7-8012-46a6055d1b3f"), "GD", 88 },
                    { new Guid("436a4c05-256a-5d5d-bdde-8a940a93c332"), "GP", 89 },
                    { new Guid("6df9c609-85ad-5b99-8afa-ac48d179a7c0"), "GU", 90 },
                    { new Guid("fa0a79a2-3019-5de2-a0c6-63e1b9243163"), "GT", 91 }
                });

            migrationBuilder.InsertData(
                table: "MachineDimensionsType",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("3885e147-acca-5bbb-b04e-735d54671725"), "THREE_PLUS_TWO_AXIS", 1 },
                    { new Guid("7b4362de-c2e5-53c1-901b-aaadbd8b4eb4"), "FIVE_AXIS", 2 },
                    { new Guid("6742fcc8-0eff-5717-aee9-d9b939b3a343"), "THREE_AXIS", 0 }
                });

            migrationBuilder.InsertData(
                table: "MillingMachineDimensionsTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("7b4362de-c2e5-53c1-901b-aaadbd8b4eb4"), "FIVE_AXIS", 2 },
                    { new Guid("3885e147-acca-5bbb-b04e-735d54671725"), "THREE_PLUS_TWO_AXIS", 1 },
                    { new Guid("6742fcc8-0eff-5717-aee9-d9b939b3a343"), "THREE_AXIS", 0 }
                });

            migrationBuilder.InsertData(
                table: "MillingMachineTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("2ba465b4-881c-5bc5-b38a-1d35a87874dc"), "TYPE_1", 0 },
                    { new Guid("96ccd35d-0f7d-5a71-b936-48b25093defe"), "TYPE_2", 1 },
                    { new Guid("c87f5faf-ef4f-55fc-bde4-6b614690d107"), "TYPE_3", 2 },
                    { new Guid("f02d8a9a-1d0d-5272-9b38-a6e65e15940a"), "TYPE_4", 3 }
                });

            migrationBuilder.InsertData(
                table: "OtherTechnologies",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("28a87d3e-bd22-503c-9d05-0796440fee66"), "Other", 8 },
                    { new Guid("3f8a5e3b-494e-5099-8bd4-0e7a145d409c"), "Annealing", 7 },
                    { new Guid("23304941-05aa-5c23-82db-faee6910692a"), "Knurling", 6 },
                    { new Guid("170871f3-c45f-5be6-b969-7d444adf0568"), "Toothings", 3 },
                    { new Guid("af9dee55-eff7-5179-afa6-b7bb805db03b"), "Engravings", 4 },
                    { new Guid("d69f148f-ef5c-5343-8db0-24cbfcc3653e"), "ThreadsTr", 2 },
                    { new Guid("61fe7597-b8e0-54a0-b3b6-f2c15620949b"), "ThreadsM", 1 },
                    { new Guid("4867b337-2da8-547a-924e-57e5e32c7c07"), "DeepHoleDrilling", 0 },
                    { new Guid("60fabdc3-b059-5b10-8ffb-c331efa44416"), "LaserMarking", 5 }
                });

            migrationBuilder.InsertData(
                table: "TurningMachineTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("c4c5a51c-6f3f-5a82-aeb8-db1a520f5b67"), "TURNING_MACHINE_TYPE_3", 2 },
                    { new Guid("34c0fc6f-7649-5991-ae36-852d73b57c6e"), "TURNING_MACHINE_TYPE_4", 3 },
                    { new Guid("7634ad7d-600f-5c74-98bc-ed7bc6f42399"), "TURNING_MACHINE_TYPE_1", 0 },
                    { new Guid("23e24e01-996d-5ae2-b63a-b988b607685a"), "TURNING_MACHINE_TYPE_2", 1 },
                    { new Guid("a7f50e2d-5eae-583a-804f-4e8bcd6c2429"), "TURNING_MACHINE_TYPE_5", 4 }
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
                name: "IX_CustomerAdditionalInfos_CustomerId",
                table: "CustomerAdditionalInfos",
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
                name: "IX_Registrations_CustomerId",
                table: "Registrations",
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
                name: "CustomerAdditionalInfos");

            migrationBuilder.DropTable(
                name: "CustomerOtherTechnology");

            migrationBuilder.DropTable(
                name: "MachineDimensionsType");

            migrationBuilder.DropTable(
                name: "MillingMachine");

            migrationBuilder.DropTable(
                name: "Registrations");

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
