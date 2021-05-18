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
                name: "TurningMachineType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TurningMachineType", x => x.Id);
                    table.UniqueConstraint("AK_TurningMachineType_Value", x => x.Value);
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
                name: "TurningMachine",
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
                    table.PrimaryKey("PK_TurningMachine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TurningMachine_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TurningMachine_TurningMachineType_TurningMachineTypeId",
                        column: x => x.TurningMachineTypeId,
                        principalTable: "TurningMachineType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AddressTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("a0e865c6-8e97-49cb-baff-9d7c8f104daf"), "Shipping", 0 },
                    { new Guid("1cdaefda-ea11-4ff5-a42a-ba4f6a3e07a0"), "Billing", 1 }
                });

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("6c6168c6-311c-47f2-9a93-23ffcfcf2390"), "ISO9001", 0 },
                    { new Guid("b8673bc0-ae13-4e0c-9120-6e97e9a4bf2b"), "ISO14001", 1 },
                    { new Guid("f3611863-22a1-473e-bf3f-9befc47b90e0"), "ISO13485", 2 },
                    { new Guid("acb00c7d-2521-4110-873b-3d7c9c5795c6"), "ITAF16949", 3 },
                    { new Guid("82025241-d908-4f6c-acc3-9757e8d2f071"), "EN9100", 4 },
                    { new Guid("71ecffd2-ca7d-4cb6-94b7-1e4cbfcea246"), "Other", 5 }
                });

            migrationBuilder.InsertData(
                table: "CompanySizeTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("2fde15b4-5dbb-4790-b8c6-cdd0aa04742c"), "LessThan100", 100 },
                    { new Guid("1d264381-5557-4b95-8c03-fd50e2708aac"), "LessThan50", 50 },
                    { new Guid("f211e9f6-026b-452f-8e63-e25d487b5082"), "MoreThan100", 101 },
                    { new Guid("91c98ac2-8aa3-4679-b39b-20f042cbfbab"), "LessThan10", 10 },
                    { new Guid("828e369e-c64f-4019-9a74-26a38155f925"), "LessThan25", 25 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("4d362e3e-9fb7-493b-9c2d-b60c39a356a7"), "PA", 171 },
                    { new Guid("64cd81bc-a4cf-4ac5-baff-e4b38c9f3403"), "NI", 160 },
                    { new Guid("eecdf496-c3d3-41be-a6f9-1a8f5746b2ae"), "NE", 161 },
                    { new Guid("22808231-f980-4b27-a8d1-b721460afb1e"), "NG", 162 },
                    { new Guid("78ed333e-4faa-48c2-9b96-49c96cbece6a"), "NU", 163 },
                    { new Guid("516062e1-6d34-41f7-8a93-5e0f33ed10b0"), "NF", 164 },
                    { new Guid("ef6a34ae-3104-49c9-852d-7345fdb9075c"), "MP", 165 },
                    { new Guid("e9a3dff8-6115-4b66-a50d-b3f2f3c93dfc"), "NO", 166 },
                    { new Guid("01b4443f-6cf6-44c8-8ead-4274490aa623"), "OM", 167 },
                    { new Guid("b9cb7574-a77e-43be-87e7-5dae32ba4874"), "PK", 168 },
                    { new Guid("50e73169-b7fa-49c1-b523-4eca6eeed81f"), "PW", 169 },
                    { new Guid("20eda111-463e-4a54-b816-501693d87917"), "PS", 170 },
                    { new Guid("28587de3-1c91-4a5d-8570-fdb0156080b0"), "PG", 172 },
                    { new Guid("84d8608e-5605-4551-8e61-4f63682250d3"), "PR", 179 },
                    { new Guid("ede307e8-34b9-48ce-9265-e1c032443a7e"), "PE", 174 },
                    { new Guid("9cf217bc-7ac1-42a4-bb4a-d1b18cfb56cd"), "PH", 175 },
                    { new Guid("72e4f7fa-9453-4e91-a93b-af03941c7505"), "PN", 176 },
                    { new Guid("70e71f7d-d668-475b-931a-ef64fa4efbf0"), "PL", 177 },
                    { new Guid("a5d8f7c7-ccf9-4d16-b890-eb0fec94d40e"), "PT", 178 },
                    { new Guid("37c2d9d3-be65-4e09-88dc-82394ef00896"), "NZ", 159 },
                    { new Guid("d0da61d1-f7a7-4512-8487-b6da96ba7968"), "QA", 180 },
                    { new Guid("dc2fca57-f4c0-4757-bcdf-6ba3c9a267ee"), "RE", 181 },
                    { new Guid("91960739-beee-4980-be63-9101c5aa4495"), "RO", 182 },
                    { new Guid("20df223c-1405-43c2-b134-f97215b11c61"), "RU", 183 },
                    { new Guid("3c153b97-58a8-491f-9690-0c4a0e87d120"), "RW", 184 },
                    { new Guid("b565d833-0089-4c5e-b934-b5348b340398"), "BL", 185 },
                    { new Guid("bb365604-f02b-4c7a-9dbb-eb2bbd084b8f"), "SH", 186 },
                    { new Guid("26e4fdbe-b05e-4021-9527-2af8ed201754"), "PY", 173 },
                    { new Guid("37454c79-68d1-4231-abc2-937327b3a883"), "NC", 158 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("9498db77-213b-486b-9786-2685eba4a9d1"), "MA", 151 },
                    { new Guid("30611f35-02bc-475c-94ae-d22bb531d0d7"), "NP", 156 },
                    { new Guid("6ef6b570-ef53-4113-ac55-7fe6eb57bb55"), "LY", 127 },
                    { new Guid("f905159f-4c20-492c-94b3-61dc06a389e3"), "LI", 128 },
                    { new Guid("b8af491f-714a-4a1f-9b91-ebfbbab67c30"), "LT", 129 },
                    { new Guid("351a8476-6f3f-4971-989a-8958577c05f9"), "MO", 131 },
                    { new Guid("fedab7d8-41ad-4ff5-940e-781bf468393d"), "MK", 132 },
                    { new Guid("1936016e-9623-4452-b0f4-fa5e09d0fe0f"), "MG", 133 },
                    { new Guid("c8e0b2ab-d289-4820-9b11-333083915179"), "MW", 134 },
                    { new Guid("6258361e-1c58-4b7b-9e74-6bf8e98efe58"), "MY", 135 },
                    { new Guid("fc93baa0-cee9-45b5-909d-6cf2949ae24c"), "MV", 136 },
                    { new Guid("1eff6a53-a619-4f37-a0eb-ecb26da7a172"), "ML", 137 },
                    { new Guid("93df74e1-03e6-4271-bcc0-ffa8ce14820f"), "MT", 138 },
                    { new Guid("f3bee5c9-e575-4657-bc1c-e73063cd819d"), "MH", 139 },
                    { new Guid("779e7c73-0f2e-4855-b9aa-6855f6edeb8f"), "MQ", 140 },
                    { new Guid("347f8e72-9912-4624-a30d-e14a6152f075"), "NL", 157 },
                    { new Guid("caf992c9-85a9-4262-bc46-c37bfc89fe66"), "MR", 141 },
                    { new Guid("ef261bf4-1265-4513-91a5-e35034a51966"), "YT", 143 },
                    { new Guid("a30fd36c-d660-42de-beed-cad0ceaee3c0"), "MX", 144 },
                    { new Guid("08e8bdc0-6b38-4aa1-9c01-3eaa753a197b"), "FM", 145 },
                    { new Guid("d1788722-486e-4309-9c0a-0833c1586839"), "MD", 146 },
                    { new Guid("c8c618f5-8024-4973-b916-3f65ad1c3b6e"), "MC", 147 },
                    { new Guid("e6c1c6b0-cf16-437e-93bf-fa4628241b26"), "MN", 148 },
                    { new Guid("b49406c1-d001-4e99-b52b-d0b5e9a79863"), "ME", 149 },
                    { new Guid("d74132dd-7bec-4b62-bca9-83ad0ddc6b59"), "MS", 150 },
                    { new Guid("5ff920d1-0f2c-4ff7-883c-5280d93ab61b"), "KN", 187 },
                    { new Guid("b155cc37-50ac-453d-badc-0f7d2d013574"), "MZ", 152 },
                    { new Guid("297e9d08-e0c5-4764-971d-2a6ebe299870"), "MM", 153 },
                    { new Guid("9d05f5ed-2bab-4f28-a770-a3c6e3eb84a8"), "NA", 154 },
                    { new Guid("9f4c42a7-f537-4d5a-b2c8-b6ee8e5241a8"), "NR", 155 },
                    { new Guid("8dfaa256-393b-4b19-a761-e0b0f731f816"), "MU", 142 },
                    { new Guid("4bab451a-e0db-4e2d-ae99-8ba51651000a"), "LC", 188 },
                    { new Guid("68b7e7ac-3a93-48b1-80fb-d1aaf0b3b523"), "ST", 194 },
                    { new Guid("0cfa6fa8-2d2c-4715-b29a-1e2c4aad5fb1"), "PM", 190 },
                    { new Guid("6577b91a-370c-4505-9944-be87287a7081"), "TG", 223 },
                    { new Guid("028e2c2d-a0fb-49d6-875f-b18d423cf4f0"), "TK", 224 },
                    { new Guid("8659b324-0137-4878-9587-2170bda5299c"), "TO", 225 },
                    { new Guid("3791f875-3c6d-49fb-bc7f-c86b326c9080"), "TT", 226 },
                    { new Guid("4bff4433-c9ce-4d33-96e4-6bb1dd1b11a9"), "TN", 227 },
                    { new Guid("7fa892d7-6b98-408b-bbee-860f53810803"), "TR", 228 },
                    { new Guid("aec6a3f2-b600-40fb-9063-63ea44336924"), "TM", 229 },
                    { new Guid("c17c57e9-6aad-4c94-ad39-cb16216c55fc"), "TC", 230 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("7c355222-4785-4407-aefe-699cb61da315"), "TV", 231 },
                    { new Guid("714d6093-0002-4bb6-8aa6-639315074bdb"), "UG", 232 },
                    { new Guid("eaa8763f-1769-456f-83d6-c30749583407"), "UA", 233 },
                    { new Guid("238ad1a8-a1c3-4406-9f4e-1bc339239902"), "AE", 234 },
                    { new Guid("0298fb48-199d-4991-a804-f2d7f7d40bfd"), "GB", 235 },
                    { new Guid("b49375e9-a8d3-4c27-9be3-6948310daf4e"), "US", 236 },
                    { new Guid("6df9757d-14c9-4203-bb25-ffd4163ff37b"), "UM", 237 },
                    { new Guid("cfcab9f5-3ac2-459a-8827-5b4a4f079ebb"), "UY", 238 },
                    { new Guid("af368219-3337-4da8-886e-4257ffbe56b5"), "UZ", 239 },
                    { new Guid("9a31479c-65ae-48f1-9df9-6f989a2f6762"), "VU", 240 },
                    { new Guid("cd78692d-41b9-4aa2-8053-31250dc356ce"), "VE", 241 },
                    { new Guid("237361b4-e2fd-4c04-a951-d3edfb17d0e7"), "VN", 242 },
                    { new Guid("91f205b9-bc58-409c-8fb3-0a7e198382c9"), "VG", 243 },
                    { new Guid("bfcbb2a2-be4e-485b-8dfe-21fb271120d9"), "VI", 244 },
                    { new Guid("9c0f5ee9-177e-4848-93f4-725db739f091"), "WF", 245 },
                    { new Guid("713368ff-c7ce-4337-aeff-4514998a0f9a"), "EH", 246 },
                    { new Guid("74ce7561-9b3f-42c1-98a7-3af8a7b9fff1"), "YE", 247 },
                    { new Guid("6662a3ea-457a-4d02-93ad-0e7e522220de"), "ZM", 248 },
                    { new Guid("83914dac-5e7d-452a-8100-46339500d8fd"), "ZW", 249 },
                    { new Guid("cb77aff4-5fc0-4bad-9782-31cba57d8c2e"), "TL", 222 },
                    { new Guid("0d50eaf2-1fac-4f51-8a8e-15944dfdcc99"), "TH", 221 },
                    { new Guid("32040e6e-c743-4c50-8d11-a4865c2f7df5"), "TZ", 220 },
                    { new Guid("b020fae3-f1db-4cbf-9869-f71b9127876c"), "TJ", 219 },
                    { new Guid("cc4f0cc7-a59f-4be0-89df-6ffb8be1dc52"), "VC", 191 },
                    { new Guid("4ab8038d-9772-4d0d-b23c-1f8ef06d4aa9"), "WS", 192 },
                    { new Guid("78e2f3d6-03a9-4b81-8cbb-c73228672251"), "SM", 193 },
                    { new Guid("797aabee-7797-4278-81a4-742eb187a2b3"), "LR", 126 },
                    { new Guid("4f027f63-1459-4228-8013-6816b7405d9f"), "SA", 195 },
                    { new Guid("bbc52722-97fc-4e82-9887-dabc3f926669"), "SN", 196 },
                    { new Guid("c6cbbc32-ca0c-44c3-bc9d-9d11b2b09263"), "RS", 197 },
                    { new Guid("ab4fbc7f-6e8d-40a3-903c-cdc859e95fbe"), "SC", 198 },
                    { new Guid("ce86b797-478f-49c8-a6f6-cccf0dbbb5e5"), "SL", 199 },
                    { new Guid("4573cb74-8212-42ad-99db-e6928aac81e7"), "SG", 200 },
                    { new Guid("1fcccab5-b743-4354-831c-4abcded67e9c"), "SX", 201 },
                    { new Guid("e4869ca3-2a7d-494c-9c37-92c8a1b94d49"), "SK", 202 },
                    { new Guid("07660805-9081-48b7-9405-65a610921a15"), "SI", 203 },
                    { new Guid("79488b6d-72b4-43de-a310-c12a1e44dac1"), "MF", 189 },
                    { new Guid("41d45958-69fc-49b4-9465-2ea39aa3671c"), "SB", 204 },
                    { new Guid("a67e8fca-931a-4eb4-9773-d6477647f19d"), "ZA", 206 },
                    { new Guid("e5305ac6-50ef-413d-8086-cc78010d5f2a"), "GS", 207 },
                    { new Guid("befd8023-5437-43fa-aae4-8cd355ab211b"), "SS", 208 },
                    { new Guid("d15c6395-cc1e-401b-9cc4-e56715a31c43"), "ES", 209 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("75fdd728-0013-4a38-965b-c061c31e0421"), "LK", 210 },
                    { new Guid("94b1dd2c-26c9-4eac-8e29-4899af089bd1"), "SD", 211 },
                    { new Guid("3e88325f-bae4-46e6-b0cd-f6199a79e42d"), "SR", 212 },
                    { new Guid("46eb2de9-d565-47a0-95d1-190ded2bd341"), "SJ", 213 },
                    { new Guid("b16a4ab2-958e-45cb-b764-bf3a7988ee00"), "SZ", 214 },
                    { new Guid("f86ffac4-2aaa-4dd2-bab3-6332bec8d366"), "SE", 215 },
                    { new Guid("8f81954b-5a5f-4be8-87d6-9edd9c2351f0"), "CH", 216 },
                    { new Guid("923aa1fb-de83-4be7-aebd-882c49337a33"), "SY", 217 },
                    { new Guid("23b67af6-bedb-4bad-bc6a-db009a9e931a"), "TW", 218 },
                    { new Guid("1d9944bf-418b-44fa-888b-49c45097ad40"), "SO", 205 },
                    { new Guid("0262e75b-2111-4c3f-8e61-94197c478cca"), "LS", 125 },
                    { new Guid("0552945e-a3a5-490f-92bd-10922d0b1a17"), "LU", 130 },
                    { new Guid("1c3a93af-6366-4510-832d-380efb938a60"), "LV", 123 },
                    { new Guid("48841ba8-9b06-403b-a2c9-e07cd4f0e5fc"), "IO", 33 },
                    { new Guid("5784115a-7e78-4801-98e9-08f006896417"), "BN", 34 },
                    { new Guid("19f5f3b0-2b8c-4ce0-924e-68512f235eaf"), "BG", 35 },
                    { new Guid("9ca82797-1a93-471b-ab8c-391844a1e953"), "BF", 36 },
                    { new Guid("e04b997e-ac0d-4a77-8a33-5a4026339290"), "BI", 37 },
                    { new Guid("f63fb26e-aa72-4690-bf26-5c5886b25dec"), "CV", 38 },
                    { new Guid("54491b4e-3e81-45db-918f-673273df856f"), "KH", 39 },
                    { new Guid("e4f0a29a-fbaf-4192-9936-18530fd383f3"), "CM", 40 },
                    { new Guid("dc42e26f-6fef-469f-ae2d-b3888d51a544"), "CA", 41 },
                    { new Guid("14f13abd-16a7-4acf-99ea-831e499ff96b"), "KY", 42 },
                    { new Guid("afbe9dd2-8e6d-43a9-a35a-2e32f3177b39"), "CF", 43 },
                    { new Guid("ca7f7250-0091-4154-9c27-c6c4ca560700"), "TD", 44 },
                    { new Guid("2abb9340-b410-4f8c-a427-19e08a52b7cb"), "CL", 45 },
                    { new Guid("7f93a1b4-4ac4-410c-afd2-52aec3b7873d"), "CN", 46 },
                    { new Guid("e4df804f-be4a-480f-a9cd-2d5a9cbed9f6"), "CX", 47 },
                    { new Guid("d81d253e-c496-41f6-a3bc-b139e4e5a0ea"), "CC", 48 },
                    { new Guid("b49db942-f4cb-40ae-943b-e212f6d27578"), "CO", 49 },
                    { new Guid("0ac22944-0f3a-412c-9010-4fd7340f463b"), "KM", 50 },
                    { new Guid("f7be8b6f-fa5a-4d75-9c1e-ee1de8565f5a"), "LB", 124 },
                    { new Guid("faaaea1d-2f38-4ff1-abc3-dff8b0cf84a6"), "CD", 52 },
                    { new Guid("8c499e25-0392-40f7-9700-1825f3b20969"), "CK", 53 },
                    { new Guid("84f466bd-33cd-456a-94a4-0a32ccd95076"), "CR", 54 },
                    { new Guid("35ed979b-6cbd-49b8-b7d6-57ce753eab72"), "CI", 55 },
                    { new Guid("1e1d992c-b6c9-4c68-ad0a-078c032b54f3"), "HR", 56 },
                    { new Guid("e2209dbc-65b2-459f-9aa3-23134524f719"), "CU", 57 },
                    { new Guid("e2752b16-a36c-4d45-8577-38ba49e2a01a"), "CW", 58 },
                    { new Guid("f1d06239-c445-48b5-959b-d79c6e927721"), "CY", 59 },
                    { new Guid("ffc40e82-0f8b-4efd-83d4-61b7b9a902a6"), "BR", 32 },
                    { new Guid("c08ad48c-6d6a-44c5-90ff-945a5569df1a"), "BV", 31 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("dace0a7f-cbbe-48a0-89d7-6d10bffce433"), "BW", 30 },
                    { new Guid("52ec1e4c-25ce-471f-b52d-76d34c7ec0f6"), "BA", 29 },
                    { new Guid("d9b361d1-3610-4b60-a679-cea57e00fb64"), "AF", 1 },
                    { new Guid("5da711c9-7b6d-4af0-abd2-48ddfd84839e"), "AX", 2 },
                    { new Guid("e1dae2c2-bef4-4ec3-baee-8361b5eaa025"), "AL", 3 },
                    { new Guid("8dc78db0-59a4-42a6-bce5-ec7cecba7992"), "DZ", 4 },
                    { new Guid("fe0cd41d-1bf2-43a2-9187-02811ac6493e"), "AS", 5 },
                    { new Guid("9707e46a-7542-4ca7-9aa3-b7508f7e9243"), "AD", 6 },
                    { new Guid("74353b05-1670-457b-bc45-9d81858d27c9"), "AO", 7 },
                    { new Guid("7f08079c-9628-4b54-b931-94388bafacb2"), "AI", 8 },
                    { new Guid("6ac00c4e-7a55-47ab-9081-e09abb6567ba"), "AQ", 9 },
                    { new Guid("e43ef298-197a-4bec-b94a-5458073e608c"), "AG", 10 },
                    { new Guid("a428afac-0e63-4370-b08f-471ff55889c7"), "AR", 11 },
                    { new Guid("873e8430-974a-4c77-8692-f1e75cf7ef7f"), "AM", 12 },
                    { new Guid("9429c696-51b0-4845-ba89-216b9a0b22bb"), "AW", 13 },
                    { new Guid("fb2f3150-a8f5-4b84-9dc5-2b42520034b6"), "CZ", 60 },
                    { new Guid("3d4a395c-b155-468a-86fb-7e248fac282e"), "AU", 14 },
                    { new Guid("f774f3ea-28fc-4fc8-b0f5-1791d0eb4446"), "AZ", 16 },
                    { new Guid("3ccfc780-3275-40d0-8dfd-3c43af225829"), "BS", 17 },
                    { new Guid("598ca22e-30ac-4064-b367-c39ad77f946a"), "BH", 18 },
                    { new Guid("a85c3c48-e296-49fa-ad6b-435d65719229"), "BD", 19 },
                    { new Guid("25ff9c82-a5e5-43c0-9272-eefeb02cabc5"), "BB", 20 },
                    { new Guid("ede3338f-b93f-4ce2-8e22-634757183a6f"), "BY", 21 },
                    { new Guid("15ec6037-8df8-4b89-ab15-719bfe2633db"), "BE", 22 },
                    { new Guid("ad58afbf-af52-4884-9ea0-61eb0207b74c"), "BZ", 23 },
                    { new Guid("69c05536-8811-45a6-9015-ae8840670646"), "BJ", 24 },
                    { new Guid("e2204d87-f819-4d66-a800-695d92b33264"), "BM", 25 },
                    { new Guid("c8cd5ee5-bad4-4348-bb26-4dc80da4615f"), "BT", 26 },
                    { new Guid("1bf105b4-beca-4e8d-9c35-1b496ade0b77"), "BO", 27 },
                    { new Guid("14078921-b7f6-4f45-a9e7-5cbd1d052626"), "BQ", 28 },
                    { new Guid("e8b49b12-887d-4239-a61c-f00e91268c7d"), "AT", 15 },
                    { new Guid("e1e4c5b1-b64c-4655-b5d0-90ac29b32a1c"), "DK", 61 },
                    { new Guid("7f573094-492e-436d-9b7a-526720c6d04c"), "CG", 51 },
                    { new Guid("4dc20c1e-102e-46da-b9ba-15fbf6269cd1"), "DM", 63 },
                    { new Guid("37ebe25f-73d7-4662-829f-78b678258c3a"), "HT", 96 },
                    { new Guid("eb38bfe8-9a3d-48f3-84dd-2c19f3b4b3a0"), "HM", 97 },
                    { new Guid("1248ed53-803a-4b49-a94f-9ca72de7bd49"), "VA", 98 },
                    { new Guid("9cbbef28-df2c-4b05-94f2-75379f61f4cd"), "HN", 99 },
                    { new Guid("7bf141b3-8b86-4b4e-9e77-ee27e7c881bd"), "HK", 100 },
                    { new Guid("421dae95-3ced-486e-afd4-7969934d334f"), "HU", 101 },
                    { new Guid("429cbe8e-acbf-4c90-90a2-bd59962c4b4c"), "IS", 102 },
                    { new Guid("636e5891-c63a-48a5-9cd2-96f13946afe0"), "IN", 103 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("b31ac589-e333-422f-bde8-c8c7036638e1"), "ID", 104 },
                    { new Guid("fc05de17-61aa-429f-9e66-35087c780401"), "DJ", 62 },
                    { new Guid("a3cb65b4-be40-45f0-92e7-767228737d9d"), "IQ", 106 },
                    { new Guid("58846b50-579b-45b4-b524-964ce109be09"), "IE", 107 },
                    { new Guid("aac53054-f3e7-4ce4-8bd8-fac14853107d"), "IM", 108 },
                    { new Guid("78c0a193-b88e-4a48-ba97-db6747d4eaf9"), "IL", 109 },
                    { new Guid("12dc6bf9-9635-43fe-8c54-d8f5e63248b7"), "IT", 110 },
                    { new Guid("292007c4-07aa-4746-8d7e-f7b48a5aead0"), "JM", 111 },
                    { new Guid("c71a6a68-8267-41a0-9bbe-2b40212772e7"), "JP", 112 },
                    { new Guid("1a9b05cb-a47a-43db-b5e5-e5b98efc13ab"), "JE", 113 },
                    { new Guid("f867bf29-e31c-47c7-b71e-4b9257a22e6b"), "JO", 114 },
                    { new Guid("29fc321d-ecfe-40c1-bac0-46d4b1d455bb"), "KZ", 115 },
                    { new Guid("b6fca20b-6ada-4d79-93dd-701a684140fe"), "KE", 116 },
                    { new Guid("6785c0ae-a272-4f68-85ed-e2e5d89933ee"), "KI", 117 },
                    { new Guid("2b22b106-719c-4319-9a51-72625492c1fd"), "KP", 118 },
                    { new Guid("2368f725-7925-4e15-98f3-a51ca376695b"), "KR", 119 },
                    { new Guid("10e3373b-a3bf-4af8-9e65-19815a662b1c"), "KW", 120 },
                    { new Guid("725a5fca-a6b5-47a6-9aea-0ad0349a254d"), "KG", 121 },
                    { new Guid("e1eff479-15ee-458d-aa8f-f03060bd80aa"), "LA", 122 },
                    { new Guid("35f72141-12dc-41cd-901a-431c2b8e4ed9"), "GY", 95 },
                    { new Guid("cc9a1be8-3116-4959-b57b-da130f21892e"), "GW", 94 },
                    { new Guid("82a3e253-34c5-49a0-94b7-2ac439c90715"), "IR", 105 },
                    { new Guid("6bd8c758-6cf1-440f-af1f-bcd9a9c5a9ed"), "GG", 92 },
                    { new Guid("12299d40-8ece-464d-8e71-8d38089d5421"), "DO", 64 },
                    { new Guid("cdcb4831-cb5a-43b4-8bc8-ad78c4aa6211"), "EC", 65 },
                    { new Guid("2288501e-d1cb-4c0c-a1e0-93706ddda66a"), "EG", 66 },
                    { new Guid("20424fbe-fb93-4715-ab8b-9698f8d9e859"), "GN", 93 },
                    { new Guid("fc8ed871-b205-4d22-9da8-6a607e9452b1"), "SV", 67 },
                    { new Guid("df1aefa3-1edb-454d-b60b-1ba3214b2e9c"), "ER", 69 },
                    { new Guid("f7ab1f0b-2b09-4aab-9f06-fe7d3f372be8"), "EE", 70 },
                    { new Guid("d6f8161c-5f04-48a8-ba09-68b8552f3d94"), "ET", 71 },
                    { new Guid("1a033b5a-f694-4b83-b91d-724da25b9479"), "FK", 72 },
                    { new Guid("9ef6e73c-94d3-4c20-8758-f4b6cf36e809"), "FO", 73 },
                    { new Guid("1438a331-65f2-4105-b462-4d04688c18f5"), "FJ", 74 },
                    { new Guid("dde8750d-2aea-410c-8cf6-3beb2891663e"), "FI", 75 },
                    { new Guid("32c9d56a-93fe-4081-bde1-1eeb761cf9e2"), "FR", 76 },
                    { new Guid("e6140b24-db34-4720-b6a6-99a78e2ecae6"), "GF", 77 },
                    { new Guid("4d337da5-942f-4748-9030-087d8c0e263e"), "GQ", 68 },
                    { new Guid("54883948-4546-43e2-ad0c-ef352d4e3a99"), "TF", 79 },
                    { new Guid("88d8deb6-b0f9-498b-a3aa-654be12d0420"), "GA", 80 },
                    { new Guid("84810bc3-29c0-4dfc-8da9-983a97cb941f"), "GM", 81 },
                    { new Guid("5b955395-2837-457b-a51c-8672b8e41da7"), "GE", 82 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("fedef4f3-3439-4522-ab5f-c61a6088b6db"), "DE", 83 },
                    { new Guid("902ccaa8-9077-4e26-9183-4d31c64aa4ec"), "GH", 84 },
                    { new Guid("bb119c5b-7cfb-457d-9c72-9c06e2626ddd"), "GI", 85 },
                    { new Guid("4a98f0aa-b94e-4ead-b67a-78798ae48794"), "GR", 86 },
                    { new Guid("c49ad50a-7621-4892-89b2-afbdac12472d"), "PF", 78 },
                    { new Guid("d370fb06-3017-4925-93ec-30e6081a9353"), "GL", 87 },
                    { new Guid("120b6a8a-57cd-495d-bf6f-a601437affc0"), "GD", 88 },
                    { new Guid("4a9b150a-0279-485c-a1d4-b3eee86de50f"), "GP", 89 },
                    { new Guid("22878c06-24a5-4a93-9db3-6d298f306825"), "GU", 90 },
                    { new Guid("b372be84-c091-4314-bbd8-509cac367371"), "GT", 91 }
                });

            migrationBuilder.InsertData(
                table: "MachineDimensionsType",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("2b10da2c-61b1-4992-a488-02c5e8f80709"), "THREE_PLUS_TWO_AXIS", 1 },
                    { new Guid("bac76a2e-51dd-4386-8edb-7f5604f4d4ae"), "FIVE_AXIS", 2 },
                    { new Guid("7b944288-600e-4b73-80c9-5d1d5cb7f573"), "THREE_AXIS", 0 }
                });

            migrationBuilder.InsertData(
                table: "MillingMachineDimensionsTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("1dcd614a-0bbd-4962-a837-70cf115c3538"), "FIVE_AXIS", 2 },
                    { new Guid("7d328025-3d87-4ce0-ba3a-89665420fbd1"), "THREE_PLUS_TWO_AXIS", 1 },
                    { new Guid("f33d801e-aa56-45d8-93dc-a81d838b8d49"), "THREE_AXIS", 0 }
                });

            migrationBuilder.InsertData(
                table: "MillingMachineTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("1eccb47a-3548-4103-a709-06cfcfc0d9be"), "TYPE_1", 0 },
                    { new Guid("8f2796bf-c34a-491e-b860-5889dcc46bbb"), "TYPE_2", 1 },
                    { new Guid("e617b711-2939-4d5a-b0a8-e0d60b0a5035"), "TYPE_3", 2 },
                    { new Guid("4affe675-3615-44bf-a270-6855239ab386"), "TYPE_4", 3 }
                });

            migrationBuilder.InsertData(
                table: "OtherTechnologies",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("8227be71-3a28-4e57-a7a7-07d40daa8388"), "Other", 8 },
                    { new Guid("153d87de-0470-4b2e-bca5-1805c4049513"), "Annealing", 7 },
                    { new Guid("7510f501-e8a4-4737-9491-bd3d82aff09d"), "Knurling", 6 },
                    { new Guid("ac167bf0-fc05-4ac5-b350-795fde0fb71f"), "Toothings", 3 },
                    { new Guid("467e23b7-1765-4d39-80df-c3c6f6fbe5a0"), "Engravings", 4 },
                    { new Guid("49f3ce32-7210-4ee2-8ec2-d32390e07268"), "ThreadsTr", 2 },
                    { new Guid("8d269b93-52af-449b-90d8-237e701cdf14"), "ThreadsM", 1 },
                    { new Guid("25d7f49f-e567-41e9-b8fa-935995272b3b"), "DeepHoleDrilling", 0 },
                    { new Guid("9b7b1aa4-5923-40e5-a267-0f4683539c13"), "LaserMarking", 5 }
                });

            migrationBuilder.InsertData(
                table: "TurningMachineType",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("7c93a05f-4f8c-47d0-952e-7cff6061f728"), "TURNING_MACHINE_TYPE_3", 2 },
                    { new Guid("4f187ada-b0b1-4d41-abbd-62009044cba8"), "TURNING_MACHINE_TYPE_4", 3 },
                    { new Guid("027b6f80-837d-425d-81c0-0002937dff9c"), "TURNING_MACHINE_TYPE_1", 0 },
                    { new Guid("2d8fd979-4dee-45f1-add8-7cb462a2c64a"), "TURNING_MACHINE_TYPE_2", 1 },
                    { new Guid("973fc81f-ca06-49fe-8df7-79dde79efedc"), "TURNING_MACHINE_TYPE_5", 4 }
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
                name: "IX_TurningMachine_CustomerId",
                table: "TurningMachine",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_TurningMachine_TurningMachineTypeId",
                table: "TurningMachine",
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
                name: "TurningMachine");

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
                name: "TurningMachineType");

            migrationBuilder.DropTable(
                name: "CompanySizeTypes");
        }
    }
}
