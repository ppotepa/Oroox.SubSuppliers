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
                    { new Guid("a8883146-c906-5d1c-90b9-7de145f91345"), "Shipping", 0 },
                    { new Guid("19795683-2de9-51cf-87b5-14e1b29a20cb"), "Billing", 1 }
                });

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("5ad03a69-7f42-590f-92f1-f2000f533a9f"), "ISO9001", 0 },
                    { new Guid("cac0fbe5-feab-577e-a502-63cb3af5cd50"), "ISO14001", 1 },
                    { new Guid("e985886b-4e22-5a0b-95a0-d7db7b339139"), "ISO13485", 2 },
                    { new Guid("c42d8176-3999-558c-93d0-3a0f49c9967e"), "ITAF16949", 3 },
                    { new Guid("5dc24980-27b8-5899-a7db-6d9a434b07c9"), "EN9100", 4 },
                    { new Guid("46cc9416-0e09-5790-8edf-1afd310798b8"), "Other", 5 }
                });

            migrationBuilder.InsertData(
                table: "CompanySizeTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("03771842-6399-500e-a446-f0f090e2b45c"), "LessThan100", 100 },
                    { new Guid("7ed405fa-6221-5ca1-bf00-ef024e66aa6e"), "LessThan50", 50 },
                    { new Guid("05594fee-a667-5523-9ad8-e7c5e6fd3a2a"), "MoreThan100", 101 },
                    { new Guid("e497d944-64db-5ea5-8cc4-df29ce65a15e"), "LessThan10", 10 },
                    { new Guid("88612e63-9606-5eec-963d-d376de208121"), "LessThan25", 25 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("28ab882b-6f9a-58df-b71f-cd17253aef58"), "PA", 171 },
                    { new Guid("a1a41f56-47aa-54b1-af63-bf1c063557a7"), "NI", 160 },
                    { new Guid("2da8c60a-3d6b-5515-a35a-ebeb8c90e358"), "NE", 161 },
                    { new Guid("4460925e-4d98-5309-9f69-9648e42f4e43"), "NG", 162 },
                    { new Guid("8842c6c9-ac68-52ec-8246-17afcf5ee173"), "NU", 163 },
                    { new Guid("9285a80f-7f82-5d48-b337-1d8738b9742a"), "NF", 164 },
                    { new Guid("0491921e-2a93-50cc-889f-24dbdf9aff7e"), "MP", 165 },
                    { new Guid("6f485592-43af-51fb-9884-3972f3629dac"), "NO", 166 },
                    { new Guid("55cdd703-6cf1-52f7-92eb-70ada9c894a3"), "OM", 167 },
                    { new Guid("e874406a-c436-5b9d-a1f4-2b2a7b3c6c8b"), "PK", 168 },
                    { new Guid("0ea16bb1-6dea-54bc-90ef-e910469fd766"), "PW", 169 },
                    { new Guid("5bf6cf35-7c7f-5435-aeea-ee0c6f15789d"), "PS", 170 },
                    { new Guid("833f29d7-c624-54b5-a288-3aae5ab9bb4d"), "PG", 172 },
                    { new Guid("116cf350-4e34-562a-a41d-89c192fe4cee"), "PR", 179 },
                    { new Guid("015e6cf5-99a2-5bff-80a4-da65cdb2504c"), "PE", 174 },
                    { new Guid("dc7e53c5-b39a-5f7d-840e-1295678ce63e"), "PH", 175 },
                    { new Guid("bff34991-46c3-58db-b615-98d3fce5d838"), "PN", 176 },
                    { new Guid("9c63d493-5c1c-5355-a7c7-6638b5eb5cf1"), "PL", 177 },
                    { new Guid("78be49a2-655c-5b7f-8e3f-a9212288f841"), "PT", 178 },
                    { new Guid("0b863bbd-aeec-579a-87a5-2f201e76fe4a"), "NZ", 159 },
                    { new Guid("37a830fd-7183-5d4a-bd43-9e863133b956"), "QA", 180 },
                    { new Guid("b270df57-7c93-520f-9021-eb1dc53cf2a5"), "RE", 181 },
                    { new Guid("59d3d920-8728-5e15-b935-db0d7ade9dcf"), "RO", 182 },
                    { new Guid("673f7f97-a929-56f3-9cae-67b561942322"), "RU", 183 },
                    { new Guid("637f71cb-f027-5a12-b2bc-b61e508fb22e"), "RW", 184 },
                    { new Guid("9d350de7-2ba4-58ae-b464-ca51989d81bc"), "BL", 185 },
                    { new Guid("fcc0c895-2c05-562e-bde9-48b7c3dca80b"), "SH", 186 },
                    { new Guid("cfa74244-5e5b-52a1-86c3-8b7070b48d62"), "PY", 173 },
                    { new Guid("0fa10dcc-15f8-5bcc-88b9-f6265cb50bb0"), "NC", 158 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("3fa079f8-d815-5d56-a641-a8916769b379"), "MA", 151 },
                    { new Guid("ddd0fa3b-f99f-52db-b344-24cdd673c4f1"), "NP", 156 },
                    { new Guid("a0ac3524-93a3-5070-a0f7-0bb6582c5e45"), "LY", 127 },
                    { new Guid("5332780c-224a-52f6-aafb-f8763b6e4b08"), "LI", 128 },
                    { new Guid("15f1330e-f669-5b3b-a5b4-3f8d45511b08"), "LT", 129 },
                    { new Guid("bc957902-2843-5a76-8ff8-49062de963d5"), "MO", 131 },
                    { new Guid("2c2bd55f-77a1-51f6-945a-171f0833d8ab"), "MK", 132 },
                    { new Guid("c7efb0e1-55e4-51f0-b412-27d189779248"), "MG", 133 },
                    { new Guid("f1edb8d6-47d2-5c44-a87a-ad6a1182f322"), "MW", 134 },
                    { new Guid("384ce04f-9efe-535b-a287-cf4b51ae4feb"), "MY", 135 },
                    { new Guid("b4da38f4-9c0c-5170-a72a-1e55a9ca7c3e"), "MV", 136 },
                    { new Guid("1762bd94-78b2-5f16-b9fb-dd8982b9c17d"), "ML", 137 },
                    { new Guid("661456fa-9d44-5392-8f68-f11a940eb490"), "MT", 138 },
                    { new Guid("aadf8b61-48c0-5f25-8cac-e0c00560610b"), "MH", 139 },
                    { new Guid("15e7e7ec-d92d-5e9b-a477-846342e11d90"), "MQ", 140 },
                    { new Guid("63fa6c9d-0816-58a1-8353-f795c86d9d56"), "NL", 157 },
                    { new Guid("ac6b8c2a-9b50-5f9a-af3e-5981d7b64b1a"), "MR", 141 },
                    { new Guid("60a3df99-e7ca-5733-883d-4399a5756f06"), "YT", 143 },
                    { new Guid("db9f898b-6c14-5f03-99b6-fc575998f642"), "MX", 144 },
                    { new Guid("dcf777dd-3f8e-564f-ab53-61be1e636f63"), "FM", 145 },
                    { new Guid("434f3f5e-4b8f-558c-90f2-3cf067d2966b"), "MD", 146 },
                    { new Guid("7b02f7ab-d7e0-50f1-8a0e-d01aee2985ed"), "MC", 147 },
                    { new Guid("3062c64f-55e5-5d4a-b3ce-9f6d2fea12ad"), "MN", 148 },
                    { new Guid("da211c10-84d0-5b10-8a42-21df72ace911"), "ME", 149 },
                    { new Guid("800094bf-09a5-5e57-acdb-4b0ef07410e6"), "MS", 150 },
                    { new Guid("901277d6-57a3-5da3-8fb3-5991a72bcfcf"), "KN", 187 },
                    { new Guid("8c8a0911-0209-58d3-b3b2-2507f6cce15e"), "MZ", 152 },
                    { new Guid("06c60097-ddb7-5e86-ae5a-f490899bf4f5"), "MM", 153 },
                    { new Guid("f6e0e6f9-3e42-59b4-935e-68c7580c1aa5"), "NA", 154 },
                    { new Guid("798cc2f8-b152-54ec-b19a-4cecccc1df4e"), "NR", 155 },
                    { new Guid("7e3053fc-ee6a-56ca-997f-0e573d253a98"), "MU", 142 },
                    { new Guid("ef01e439-26cd-5714-93e3-e995e76ceb0f"), "LC", 188 },
                    { new Guid("282293c3-838e-5e7c-b7f3-fd9a090d7a82"), "ST", 194 },
                    { new Guid("67af16fa-15bc-558e-99d2-539247de42f8"), "PM", 190 },
                    { new Guid("f2e93d2f-c62c-536e-ae96-aeeb708c839a"), "TG", 223 },
                    { new Guid("c280633f-9986-5653-a17a-a055da26317d"), "TK", 224 },
                    { new Guid("ca9621b1-8a10-518b-ac5c-7c7186a43c48"), "TO", 225 },
                    { new Guid("8d9fb7d1-6e60-5824-8f05-a95796beb66b"), "TT", 226 },
                    { new Guid("18348345-8002-5d20-a546-0b9b6c322245"), "TN", 227 },
                    { new Guid("dfcf4748-3629-5c97-b9a5-6002d425c8cd"), "TR", 228 },
                    { new Guid("7e5cdb60-3a68-51fd-bdea-8b44de844b91"), "TM", 229 },
                    { new Guid("43eaaaa4-0695-5c0b-9351-fc57479aa679"), "TC", 230 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("790cf85b-553f-5427-a6be-ee9e42cbe3cc"), "TV", 231 },
                    { new Guid("ebd9e2a1-6e12-5f3e-8a1c-b6c278987a30"), "UG", 232 },
                    { new Guid("21e05bce-f28c-52ce-b357-c09d3c947048"), "UA", 233 },
                    { new Guid("41e6b339-7f13-5932-9d8b-e0589a72bb91"), "AE", 234 },
                    { new Guid("acc996c9-9a2a-5bff-9e92-379e811de520"), "GB", 235 },
                    { new Guid("509ae36d-603d-56b6-8180-f4be7a63d858"), "US", 236 },
                    { new Guid("45d55f9a-6a07-5f9d-83f1-0ec4fa5722e5"), "UM", 237 },
                    { new Guid("7e1d867f-a909-5ea0-ba3a-882b2344ec87"), "UY", 238 },
                    { new Guid("0b421075-8e50-5bfd-82bf-06b8bb9ab30d"), "UZ", 239 },
                    { new Guid("259d51c1-aee0-5216-8c96-a2f46ee835bb"), "VU", 240 },
                    { new Guid("9ac661eb-0c14-55b6-bca7-41de9f9e0edb"), "VE", 241 },
                    { new Guid("980369ae-b3e8-5a08-9bd2-d0cdecbe1b7e"), "VN", 242 },
                    { new Guid("87fbaca6-cdd5-5864-af75-3d4e001a004d"), "VG", 243 },
                    { new Guid("f3c5709a-b6e1-5ca6-9da0-1fdc05e76e53"), "VI", 244 },
                    { new Guid("fd0ffbff-5d9f-5e0d-80d8-1b9e3a2a8e56"), "WF", 245 },
                    { new Guid("0b671452-07a8-5dbc-9a6c-d9f10ab37671"), "EH", 246 },
                    { new Guid("017ef99f-d2fe-519c-b49a-b72b4d34b955"), "YE", 247 },
                    { new Guid("0b2c0726-6334-5eb3-aa3c-f199c7d27254"), "ZM", 248 },
                    { new Guid("9a92c6a3-eb9c-5806-b598-b5b706727fd2"), "ZW", 249 },
                    { new Guid("b7e287da-6634-5e60-a69d-f4522e8bb60f"), "TL", 222 },
                    { new Guid("bdcc6531-b1a9-50da-846b-a5ac38638aa7"), "TH", 221 },
                    { new Guid("8f3016bf-c223-5021-8c47-eb83b0c3b066"), "TZ", 220 },
                    { new Guid("100abe89-3738-5c4b-bec0-3eb0fd9a8e64"), "TJ", 219 },
                    { new Guid("0d32f844-6b51-51b7-a340-9c451f4477dd"), "VC", 191 },
                    { new Guid("394817a0-d725-5f8e-9e89-92c8c32e8063"), "WS", 192 },
                    { new Guid("9fe8aa5c-534d-5a3a-aada-17ee7228acac"), "SM", 193 },
                    { new Guid("60d78752-984c-5f4d-8c20-f912c9147e45"), "LR", 126 },
                    { new Guid("cf297a21-2855-59af-ac2e-78fc6f5de4f0"), "SA", 195 },
                    { new Guid("2ebd8c51-03ee-51ce-aaf5-a8c2e807ea81"), "SN", 196 },
                    { new Guid("ea6b5c91-d6c2-5610-9725-14bb0e398d78"), "RS", 197 },
                    { new Guid("6c461ee5-3045-5379-a186-c368d1b370d5"), "SC", 198 },
                    { new Guid("ee3b1b58-fe6b-50c4-990b-7fd32b0e423c"), "SL", 199 },
                    { new Guid("7501cc1e-1f98-532c-bfe1-025d0fc51a0a"), "SG", 200 },
                    { new Guid("dbda2871-52ec-51e8-9f86-ff2168280767"), "SX", 201 },
                    { new Guid("95c517f2-17cf-535f-ad2b-aedfe8618a93"), "SK", 202 },
                    { new Guid("f858606b-6ef4-5be0-b9fb-c0c2aab7cc55"), "SI", 203 },
                    { new Guid("b0364f0f-993d-5520-986b-d4c7f3ff4355"), "MF", 189 },
                    { new Guid("7028d960-87ab-55b4-b841-42a0fde078d2"), "SB", 204 },
                    { new Guid("9d577108-a988-5c11-aff3-f9e79b5b1f26"), "ZA", 206 },
                    { new Guid("fdecc802-7af2-5100-8475-9cfa91a9922c"), "GS", 207 },
                    { new Guid("7220d84a-ac50-5622-a9d4-dff6e43f9365"), "SS", 208 },
                    { new Guid("10ef81c2-b9bd-5648-85e3-0db8d03b0ea0"), "ES", 209 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("efcc8be9-286c-5ad0-8f8d-2496de3bd512"), "LK", 210 },
                    { new Guid("07098226-aee3-5dd7-8dbe-3b2386a12219"), "SD", 211 },
                    { new Guid("a4358603-8b4f-50e4-810b-3a038847e6d6"), "SR", 212 },
                    { new Guid("5ef0dcc4-ed64-58ed-9201-e93dbb8f8e71"), "SJ", 213 },
                    { new Guid("edda6af9-6ea0-5f8c-bfc7-04bc97769414"), "SZ", 214 },
                    { new Guid("674dd772-6c16-5778-9ca7-50591bfa0391"), "SE", 215 },
                    { new Guid("ce810cdb-5ebd-5f54-a622-95fffa5e2bb9"), "CH", 216 },
                    { new Guid("e304fdd1-9cdd-52f9-b086-10b941fff6be"), "SY", 217 },
                    { new Guid("cf424494-8cfc-54b4-a946-5e80476fd470"), "TW", 218 },
                    { new Guid("93cf88c6-1f8c-57dc-96f7-09119cfef9ea"), "SO", 205 },
                    { new Guid("3bb7f983-1e58-57ec-80a2-2fee939174d4"), "LS", 125 },
                    { new Guid("185f6355-2b65-5d1a-a57a-fb58db09e075"), "LU", 130 },
                    { new Guid("883d4ca8-e009-5ec1-9083-6ca1ac19023d"), "LV", 123 },
                    { new Guid("4c4e6920-08f3-5623-9662-a064df656906"), "IO", 33 },
                    { new Guid("e87ecdeb-4bf5-5171-a3b3-4439a3060614"), "BN", 34 },
                    { new Guid("63d2857b-bedd-5faf-bd0b-3bcbf45716a6"), "BG", 35 },
                    { new Guid("76c179cb-0ee9-5af2-bdcc-dbf99d1a5d86"), "BF", 36 },
                    { new Guid("bfe1b261-9d65-5109-93c2-ed1e16132358"), "BI", 37 },
                    { new Guid("feb126e1-3952-570d-b000-44905bbaebd3"), "CV", 38 },
                    { new Guid("598622b9-c16f-53a0-aabe-257520427da2"), "KH", 39 },
                    { new Guid("5d9739df-7180-5b8c-8baf-3f8ada982df0"), "CM", 40 },
                    { new Guid("41855dfa-628d-5649-80e1-ba3cbf53574e"), "CA", 41 },
                    { new Guid("32aa490f-bd1c-572d-bed4-0dd785b1dc63"), "KY", 42 },
                    { new Guid("08b574a7-fcbe-59b0-8227-ec1e5a278584"), "CF", 43 },
                    { new Guid("f28dc683-756e-5334-b776-a455b4bfba8d"), "TD", 44 },
                    { new Guid("fbeeca20-ed11-5094-ba09-1a43199869f9"), "CL", 45 },
                    { new Guid("452db218-a3fd-5bd8-8265-9b8d756e7fcc"), "CN", 46 },
                    { new Guid("b3018e30-9874-5262-b95e-4191f269d75c"), "CX", 47 },
                    { new Guid("d87c72b4-28b4-544f-aa1c-d362a1e61f99"), "CC", 48 },
                    { new Guid("99c34107-d0b8-5049-834a-cf6ecea0afa2"), "CO", 49 },
                    { new Guid("7ea12859-eea0-5c5c-a904-0478f8dcf73c"), "KM", 50 },
                    { new Guid("a5ad5137-7ded-568e-8a60-8cd490924e35"), "LB", 124 },
                    { new Guid("46de7fa0-77fe-52e1-b7d3-0a4fe022bcc3"), "CD", 52 },
                    { new Guid("57d64285-209f-5b24-b704-fdc1c7011ea3"), "CK", 53 },
                    { new Guid("d5ad3867-f97b-5ee6-bb51-03a0dcbbe865"), "CR", 54 },
                    { new Guid("885341ed-8c15-5247-95b4-fa1ce7030517"), "CI", 55 },
                    { new Guid("a2d51f38-bbc1-52b6-9f15-c82199513c6a"), "HR", 56 },
                    { new Guid("69f41139-eda8-55ae-acd8-065f360f625a"), "CU", 57 },
                    { new Guid("2cf0be4d-de25-5582-977b-b789b23d9801"), "CW", 58 },
                    { new Guid("ef618e7c-c48b-5f54-ae25-0b7ac9c1a8dd"), "CY", 59 },
                    { new Guid("2fa5b328-cc3c-505e-88a8-c7051904cc6c"), "BR", 32 },
                    { new Guid("7703d672-5dc7-5707-91c0-009afcefb72f"), "BV", 31 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("99d12c44-cb61-5bbd-8424-9f0314140770"), "BW", 30 },
                    { new Guid("537ad173-dbe4-5eb2-9e89-ce00e9743fcc"), "BA", 29 },
                    { new Guid("3b912629-fa73-5570-8d2b-be9f75a46a05"), "AF", 1 },
                    { new Guid("7521a246-a1cf-5159-85ac-c11ada8106b9"), "AX", 2 },
                    { new Guid("3ed45125-61ab-50ca-be1b-5837942942ce"), "AL", 3 },
                    { new Guid("e78525db-7915-5122-a712-af8cedbe6b31"), "DZ", 4 },
                    { new Guid("fc1abc91-2fc1-54e1-b7f9-3f1f035b59bb"), "AS", 5 },
                    { new Guid("48f9e04c-021c-5954-b9ee-eb0965f3afed"), "AD", 6 },
                    { new Guid("d0658776-dbda-5820-bbfb-f4ec7253c3be"), "AO", 7 },
                    { new Guid("ef6e1e8e-1cd7-5fd9-a504-67fada2b51d6"), "AI", 8 },
                    { new Guid("62cd4ed3-2722-59e6-83b6-b4a889feb8b9"), "AQ", 9 },
                    { new Guid("44216339-46df-5746-bb93-34cb127c8964"), "AG", 10 },
                    { new Guid("2c4e284e-01b7-5ea8-9536-7535dad4fba2"), "AR", 11 },
                    { new Guid("aa9d8192-79d1-572a-b3e8-31367c44457b"), "AM", 12 },
                    { new Guid("aa20bdaa-5656-5381-b4a9-8f68934fe356"), "AW", 13 },
                    { new Guid("09ed5917-efba-5440-aac1-55037ae268f8"), "CZ", 60 },
                    { new Guid("bc178c82-718d-548f-881c-37b863a8c58d"), "AU", 14 },
                    { new Guid("e2021c77-8e66-54c3-8c78-c5076d70b3c2"), "AZ", 16 },
                    { new Guid("1e65cb6b-dccc-5f16-9c9a-b73c96783555"), "BS", 17 },
                    { new Guid("1938c913-befa-58bc-b6f2-a772aad79dc3"), "BH", 18 },
                    { new Guid("95e9813e-2e2c-5aa4-840a-0f73d419441e"), "BD", 19 },
                    { new Guid("3c8c60ae-e838-5c5b-b757-0f86fdefd849"), "BB", 20 },
                    { new Guid("dedb88dd-cac1-5643-affc-92249dde4ca7"), "BY", 21 },
                    { new Guid("0acb7d7b-376b-581e-a2b6-674e9b16d3e9"), "BE", 22 },
                    { new Guid("69c91cd7-ea28-5dc2-9172-a8e6bc5bdb9c"), "BZ", 23 },
                    { new Guid("f9fe93a9-8141-57aa-a45b-5fff102118b1"), "BJ", 24 },
                    { new Guid("dd58c458-8cdc-525f-8c3a-33c1e2402591"), "BM", 25 },
                    { new Guid("96ffb2ac-d3f6-5d6d-8525-eca3ebf2a0e1"), "BT", 26 },
                    { new Guid("f0b17b5a-249f-557e-bb30-dbdf5e462ddb"), "BO", 27 },
                    { new Guid("f9b1e638-f51b-515b-89d9-1e6fa1282b86"), "BQ", 28 },
                    { new Guid("79a2d442-4c04-53d8-b5d7-88b56d5d8587"), "AT", 15 },
                    { new Guid("707c6f5e-0752-594f-95aa-ef4642711b71"), "DK", 61 },
                    { new Guid("15492e57-f3a2-57d9-9409-92b3fde60203"), "CG", 51 },
                    { new Guid("14cd47a8-b30b-5a19-8303-8b6c38f61629"), "DM", 63 },
                    { new Guid("131b50f1-3dcb-52a5-a5ff-602d0ff8678f"), "HT", 96 },
                    { new Guid("196e49a2-25f3-520c-a880-a4b5395e17ce"), "HM", 97 },
                    { new Guid("42eb797c-c869-5b8b-bad4-b369f2fa7a5f"), "VA", 98 },
                    { new Guid("a0494307-c04b-5ab8-81c8-68b251180cfe"), "HN", 99 },
                    { new Guid("8739795c-c974-583f-97e6-49f0bc6a1e49"), "HK", 100 },
                    { new Guid("a890df0a-b817-5de7-bf1f-5514e2c56860"), "HU", 101 },
                    { new Guid("5191d108-a93c-5777-9fb5-94a494cdb119"), "IS", 102 },
                    { new Guid("7693b6ac-dc49-554b-adca-f95a064c0933"), "IN", 103 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("888bb708-ac4e-5400-9d18-0db5d6d06ded"), "ID", 104 },
                    { new Guid("28f62e86-2a1d-5204-b993-4c5b6bb8b5f6"), "DJ", 62 },
                    { new Guid("b85fef8a-c400-56fe-b639-6215281e8c21"), "IQ", 106 },
                    { new Guid("3f8129e5-c5a9-5cad-9944-5d7afb5d471c"), "IE", 107 },
                    { new Guid("a56761c9-8c85-5e7b-8654-cec9f34626db"), "IM", 108 },
                    { new Guid("22447866-e26e-53b1-85f1-fcd2b568251a"), "IL", 109 },
                    { new Guid("cda31d82-0dab-5cbc-a40d-fff89834f5a0"), "IT", 110 },
                    { new Guid("aaa97986-2ab2-5614-8d51-4fbe4b0bd28d"), "JM", 111 },
                    { new Guid("cdae5812-9605-5549-be21-25f7652ca3da"), "JP", 112 },
                    { new Guid("b61618b6-6328-58a4-94c3-75295bd00b81"), "JE", 113 },
                    { new Guid("ab8f1f6e-626b-57b0-8758-184d0b693736"), "JO", 114 },
                    { new Guid("911b4ca2-9437-5c03-9b52-2a78d8807631"), "KZ", 115 },
                    { new Guid("8a4638ce-3b6c-5ab7-854d-4728ebe66afb"), "KE", 116 },
                    { new Guid("24d2354f-4d51-53f2-8249-fb6441796051"), "KI", 117 },
                    { new Guid("fe870894-ad0b-53a6-bc8c-c7c802fa2f14"), "KP", 118 },
                    { new Guid("c36919ba-aa4b-5f10-908b-3c1bcc96705c"), "KR", 119 },
                    { new Guid("87d1ad1d-f77f-5b9e-9994-3d4ab7466c1c"), "KW", 120 },
                    { new Guid("db81bb2c-c516-5097-b4e5-c706b188fdbb"), "KG", 121 },
                    { new Guid("3db0274b-f881-59c1-ad96-84e72c31e66d"), "LA", 122 },
                    { new Guid("22a4eb55-6a17-5b9b-98b4-cc05ac38920c"), "GY", 95 },
                    { new Guid("182166aa-eb3b-5e3d-ad3c-70bd64a8dd73"), "GW", 94 },
                    { new Guid("cdbce150-be65-51cf-80ed-9b5349fb4d41"), "IR", 105 },
                    { new Guid("fea57031-0299-5238-aa18-8541ee9e0db6"), "GG", 92 },
                    { new Guid("a9436dd0-836e-5c4b-a5c0-341b1fb973e2"), "DO", 64 },
                    { new Guid("ef80d953-432d-5ada-a475-b75237d1d0fa"), "EC", 65 },
                    { new Guid("b2cef41b-4815-5428-a9ba-c4b490e08beb"), "EG", 66 },
                    { new Guid("e6c8405d-7e72-5ac1-9894-7a78e8032df9"), "GN", 93 },
                    { new Guid("0ef99452-1c18-521a-8b54-5a9684926548"), "SV", 67 },
                    { new Guid("c61112d0-6391-5772-a193-39c3ec915b5c"), "ER", 69 },
                    { new Guid("a02cc222-3f9d-561d-8945-db49b2f027e4"), "EE", 70 },
                    { new Guid("6d5d8583-95af-58fa-91a9-22a6f56d3af3"), "ET", 71 },
                    { new Guid("4149930c-28ff-55bb-b12d-f046314a4610"), "FK", 72 },
                    { new Guid("3a9b4818-daac-51d6-9c21-30f1255d389d"), "FO", 73 },
                    { new Guid("8e07f3fa-0ce2-5e50-b9a2-c841832be443"), "FJ", 74 },
                    { new Guid("8753c751-bb7b-5c25-a1f6-1d38bcbe52ba"), "FI", 75 },
                    { new Guid("30c019ea-d355-586e-8896-fea1e61a823e"), "FR", 76 },
                    { new Guid("0eddd99c-2630-5924-bc87-b1ec86956828"), "GF", 77 },
                    { new Guid("b261bb15-9b3a-5786-95ef-d8e49967b52c"), "GQ", 68 },
                    { new Guid("db3afc0c-c748-5011-b967-1f6d42e3908e"), "TF", 79 },
                    { new Guid("8393e1a5-7e1c-53d6-b0eb-ba1379877dbd"), "GA", 80 },
                    { new Guid("c49f6780-3761-5d92-a4ff-bf0b5e264254"), "GM", 81 },
                    { new Guid("4ed3d445-80c4-58a9-8f7e-83a033badf1a"), "GE", 82 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("036c3a18-12ca-5e25-8861-fd659013ff4c"), "DE", 83 },
                    { new Guid("5cf549d0-ed47-5bc5-a0f8-4d588713f305"), "GH", 84 },
                    { new Guid("d69f10e7-ad3e-5f9a-9e32-4ba9048bae37"), "GI", 85 },
                    { new Guid("e372028e-4411-5396-852d-f0f86c2668f0"), "GR", 86 },
                    { new Guid("2fbf9894-4d7b-5381-8163-91c3db053c31"), "PF", 78 },
                    { new Guid("c77555e1-b642-5cb5-9314-e2d0ec14cd04"), "GL", 87 },
                    { new Guid("c548c111-d3fe-53e1-9010-586ac478d9a3"), "GD", 88 },
                    { new Guid("90309b98-03a9-5741-ad21-48ac984f209b"), "GP", 89 },
                    { new Guid("562ac58e-c928-51a9-80d9-c35bfb31b3ec"), "GU", 90 },
                    { new Guid("e2f043a5-43b7-5615-be3f-e0362da2d863"), "GT", 91 }
                });

            migrationBuilder.InsertData(
                table: "MachineDimensionsType",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("69521354-580d-5690-8323-293c1bf9a250"), "THREE_PLUS_TWO_AXIS", 1 },
                    { new Guid("f175c73a-7821-5416-b4d9-a6a442d86675"), "FIVE_AXIS", 2 },
                    { new Guid("a9c9ce6b-e387-506a-aa11-e94d4e5e96e8"), "THREE_AXIS", 0 }
                });

            migrationBuilder.InsertData(
                table: "MillingMachineDimensionsTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("c437bb5d-d409-5326-80d8-c8f878f39910"), "FIVE_AXIS", 2 },
                    { new Guid("f777012c-fab2-5efd-ab35-9a28a0bd3575"), "THREE_PLUS_TWO_AXIS", 1 },
                    { new Guid("38a3299e-44ab-5ff9-85fc-7f73ea5bca3e"), "THREE_AXIS", 0 }
                });

            migrationBuilder.InsertData(
                table: "MillingMachineTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("e8ab862c-c24f-5a4d-aecf-46f94ec58cfb"), "TYPE_1", 0 },
                    { new Guid("08341e4f-2a5f-519a-a766-a2d6c6dc22c0"), "TYPE_2", 1 },
                    { new Guid("d8e0cec5-ff22-5fe3-b631-7d02ddfa74d8"), "TYPE_3", 2 },
                    { new Guid("3ebb0273-3ca0-5b1d-a1f0-ee6de2883ada"), "TYPE_4", 3 }
                });

            migrationBuilder.InsertData(
                table: "OtherTechnologies",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("767ff03f-cdd8-520b-a452-920045c12ca1"), "Other", 8 },
                    { new Guid("110b356b-aff5-58a0-a989-418aec685097"), "Annealing", 7 },
                    { new Guid("734cdf67-1834-510c-bb46-cf4c9384207b"), "Knurling", 6 },
                    { new Guid("c677f037-7e6d-59eb-b928-bb3fdb5c00b0"), "Toothings", 3 },
                    { new Guid("eef999c2-d4b8-5c34-b6c5-a581bdbfc25f"), "Engravings", 4 },
                    { new Guid("b9837b14-b9b1-5ea3-8999-ef92a59f6243"), "ThreadsTr", 2 },
                    { new Guid("5dec8698-7fc3-5db7-8465-13339f912b69"), "ThreadsM", 1 },
                    { new Guid("0543c433-b71c-5dec-885a-6346bfb0136a"), "DeepHoleDrilling", 0 },
                    { new Guid("38346732-5a23-59dd-b988-adbd88b4bb24"), "LaserMarking", 5 }
                });

            migrationBuilder.InsertData(
                table: "TurningMachineTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("a212118c-3b4d-5575-9095-0e9cf5d65e29"), "TURNING_MACHINE_TYPE_3", 2 },
                    { new Guid("13521bfe-f43f-5e74-aac6-8e228552d603"), "TURNING_MACHINE_TYPE_4", 3 },
                    { new Guid("4c0ec856-54c2-5235-a2a3-23fd2053489e"), "TURNING_MACHINE_TYPE_1", 0 },
                    { new Guid("4d4834c2-a801-5d73-89b4-a8674e26617c"), "TURNING_MACHINE_TYPE_2", 1 },
                    { new Guid("0002a08a-4ad1-5ec8-b356-0bb4143266fe"), "TURNING_MACHINE_TYPE_5", 4 }
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
