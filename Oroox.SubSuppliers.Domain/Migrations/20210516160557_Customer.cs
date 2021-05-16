using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Oroox.SubSuppliers.Domain.Migrations
{
    public partial class Customer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddressType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Certification",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certification", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanySize",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanySize", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CountryCode",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryCode", x => x.Id);
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
                });

            migrationBuilder.CreateTable(
                name: "MillingMachineDimensionsType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MillingMachineDimensionsType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MillingMachineType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MillingMachineType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OtherTechnology",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherTechnology", x => x.Id);
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
                    CompanySizeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_CompanySize_CompanySizeId",
                        column: x => x.CompanySizeId,
                        principalTable: "CompanySize",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CountryCodeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_AddressType_AddressTypeId",
                        column: x => x.AddressTypeId,
                        principalTable: "AddressType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Address_CountryCode_CountryCodeId",
                        column: x => x.CountryCodeId,
                        principalTable: "CountryCode",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        name: "FK_CertificationCustomer_Certification_CertificationsId",
                        column: x => x.CertificationsId,
                        principalTable: "Certification",
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
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                        name: "FK_CustomerOtherTechnology_OtherTechnology_OtherTechnologiesId",
                        column: x => x.OtherTechnologiesId,
                        principalTable: "OtherTechnology",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MillingMachine",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MachineNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MachineTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MillingMachineDimensionsTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinimalMachiningDimensions = table.Column<int>(type: "int", nullable: false),
                    MaximalMachiningDimensions = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                        name: "FK_MillingMachine_MillingMachineDimensionsType_MillingMachineDimensionsTypeId",
                        column: x => x.MillingMachineDimensionsTypeId,
                        principalTable: "MillingMachineDimensionsType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MillingMachine_MillingMachineType_MachineTypeId",
                        column: x => x.MachineTypeId,
                        principalTable: "MillingMachineType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TurningMachine",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TurningMachineTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MachineNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinimalMachiningDimensions = table.Column<int>(type: "int", nullable: false),
                    MaximalMachiningDimensions = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AddressType",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("c66d834b-6377-441f-a38d-007f95c53e28"), "Shipping", 0 },
                    { new Guid("51777485-f6a0-45c3-a2e0-f261b90ecabd"), "Billing", 1 }
                });

            migrationBuilder.InsertData(
                table: "Certification",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("e486e819-13a2-459c-8e7e-e4781b12762c"), "ISO9001", 0 },
                    { new Guid("8f0150b6-74d0-4a76-91d8-91a82982ba37"), "ISO14001", 1 },
                    { new Guid("12eb82b9-5904-4700-884d-b5e76d7e79df"), "ISO13485", 2 },
                    { new Guid("fef87ef3-02bd-446a-a45d-ab42c0261811"), "ITAF16949", 3 },
                    { new Guid("a08a622c-d0c5-40b2-bda5-bd07b94748af"), "EN9100", 4 },
                    { new Guid("6e384532-949e-4a67-b986-547e30fed394"), "Other", 5 }
                });

            migrationBuilder.InsertData(
                table: "CompanySize",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("14fe8aa4-4f3f-4498-a00c-eba12ebe531a"), "LessThan100", 100 },
                    { new Guid("e4cfa28a-f569-4a0e-a3ff-ab2ecec9fa0f"), "LessThan50", 50 },
                    { new Guid("0a5a83f0-f138-4ecd-8cb9-0b004dcc6c1c"), "MoreThan100", 101 },
                    { new Guid("51eb2321-b462-44c0-bd36-9d5aace2f860"), "LessThan10", 10 },
                    { new Guid("72382fc5-bf8d-42a4-af23-5b1d6d737f08"), "LessThan25", 25 }
                });

            migrationBuilder.InsertData(
                table: "CountryCode",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("5f7c074d-a925-490d-afcf-75925c601572"), "PA", 171 },
                    { new Guid("bd67787f-36e6-4aba-a712-56bc4b0858b0"), "NI", 160 },
                    { new Guid("3bc41b93-8980-488a-845e-f91962c37110"), "NE", 161 },
                    { new Guid("a90a6843-86bf-4639-8f47-2de31816ad43"), "NG", 162 },
                    { new Guid("38e4bd72-f335-4b12-931b-dd53da7c71ce"), "NU", 163 },
                    { new Guid("5446a7c9-f000-41e3-8258-1e94d689c164"), "NF", 164 },
                    { new Guid("fab66fa4-8376-46e7-9836-ee42e79ea667"), "MP", 165 },
                    { new Guid("17645a3e-9845-4b02-9371-0d4e57d629e0"), "NO", 166 },
                    { new Guid("55f081ab-a0d2-4fc2-a86b-6dd998a2cc60"), "OM", 167 },
                    { new Guid("ab704cc6-587a-4d10-b60a-3fe3172a74b0"), "PK", 168 },
                    { new Guid("2c6b7433-03b4-4260-8111-e80f021390cd"), "PW", 169 },
                    { new Guid("adff0195-badb-4e5e-8568-d10915455d7e"), "PS", 170 },
                    { new Guid("c58634a5-4dcd-410b-8f65-afe002caa91d"), "PG", 172 },
                    { new Guid("dfc1bf2f-09e8-4a64-bf29-95e1c07608e9"), "PR", 179 },
                    { new Guid("84669a06-217c-4cdf-9748-cb7f0c773482"), "PE", 174 },
                    { new Guid("eaef52db-182a-4f94-b576-f7996207a601"), "PH", 175 },
                    { new Guid("66cac703-9c7b-4165-9fa5-6d375d813336"), "PN", 176 },
                    { new Guid("11cbea98-c64c-425d-8c17-7ebe1dcbee54"), "PL", 177 },
                    { new Guid("e9b4ce16-7c18-4eb8-8258-c0281700f9b4"), "PT", 178 },
                    { new Guid("0ea1f9e0-6d76-4fab-bccd-296adfc4ddf4"), "NZ", 159 },
                    { new Guid("227bd314-b71f-4826-b41c-bd73669c976d"), "QA", 180 },
                    { new Guid("f2a75e3c-6563-44fd-ba1f-02a9d667b090"), "RE", 181 },
                    { new Guid("f9beb256-18aa-4234-ac3f-c7734e1f8695"), "RO", 182 },
                    { new Guid("15d58600-2e48-4b99-ae0b-230415143b58"), "RU", 183 },
                    { new Guid("804b067f-2c35-43d5-9bb2-72c8a861cfa5"), "RW", 184 },
                    { new Guid("e01f840d-3e05-43f2-a37e-1eb72fc209ef"), "BL", 185 },
                    { new Guid("029da9d2-1e6b-439b-9c43-543c641df425"), "SH", 186 },
                    { new Guid("56ab3575-a84a-493c-b129-7c3c8cbb8ffc"), "PY", 173 },
                    { new Guid("313c7132-b3f0-403a-ae5b-b8465e61eb60"), "NC", 158 }
                });

            migrationBuilder.InsertData(
                table: "CountryCode",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("4b9e7426-3e8f-47b7-9229-ae06a8712d51"), "MA", 151 },
                    { new Guid("079314c7-b064-4bb4-b0db-6935d2954b35"), "NP", 156 },
                    { new Guid("5118efb2-6bd0-4856-93a4-a0de0d1deff3"), "LY", 127 },
                    { new Guid("69bd156a-ca16-460a-98e5-62ca5de74057"), "LI", 128 },
                    { new Guid("4cfe1751-3189-4e3d-a1e6-7468db4806e7"), "LT", 129 },
                    { new Guid("1d5fc2aa-ef4b-46df-a56d-238802036db4"), "MO", 131 },
                    { new Guid("6ead0ca4-4c8a-414b-b3fb-0897344005f0"), "MK", 132 },
                    { new Guid("a641a8dc-60c8-4cf9-84b6-27178b864b99"), "MG", 133 },
                    { new Guid("293bcaaa-d0fe-47c5-a359-6803683b3601"), "MW", 134 },
                    { new Guid("07d00b6c-a0a4-4f47-9f0f-d89e72d556ef"), "MY", 135 },
                    { new Guid("1962f46a-b923-450e-9094-a62ff8822b6c"), "MV", 136 },
                    { new Guid("136507e5-e34a-416a-a560-42fbf6d8e887"), "ML", 137 },
                    { new Guid("760c949c-1593-463d-813e-422a60c26e71"), "MT", 138 },
                    { new Guid("8ecc9821-fb1a-491e-9ca1-ab4e88d9d1f8"), "MH", 139 },
                    { new Guid("e0e02f71-748c-4169-a81e-9009874ad840"), "MQ", 140 },
                    { new Guid("fb1a64ec-3704-4394-a6b4-fb8c31ea2a3a"), "NL", 157 },
                    { new Guid("7180908e-883a-49aa-96a6-3c8971168595"), "MR", 141 },
                    { new Guid("23754b88-17b2-4935-aa38-88a587349545"), "YT", 143 },
                    { new Guid("05f01001-c84a-40b9-818e-dcb227675e45"), "MX", 144 },
                    { new Guid("7e903a68-b07d-4f66-b9b1-92633755938f"), "FM", 145 },
                    { new Guid("b6d027b2-3283-4fce-8d88-f7eba5b6313b"), "MD", 146 },
                    { new Guid("885d8516-acff-43fa-a12c-f514594f7020"), "MC", 147 },
                    { new Guid("b37075c6-9c39-47eb-97d8-608d24814636"), "MN", 148 },
                    { new Guid("c5148c5e-e7f1-4b94-ae97-75758025d35c"), "ME", 149 },
                    { new Guid("9fea5c44-5d50-4e0a-9005-68cd2c426a03"), "MS", 150 },
                    { new Guid("fb54deb4-a710-4d92-a00a-a49afd12b297"), "KN", 187 },
                    { new Guid("f3fa947c-6e39-45cd-981c-8ab968a68268"), "MZ", 152 },
                    { new Guid("7d6e2c79-5b4e-4bc4-a5b9-c709a94429b1"), "MM", 153 },
                    { new Guid("893fd04d-9709-427d-a4cb-a13cbb9189f8"), "NA", 154 },
                    { new Guid("ad144153-67a8-44d3-9894-bdf87809249e"), "NR", 155 },
                    { new Guid("d16fe58c-7500-488a-b2a1-7a85866cdb87"), "MU", 142 },
                    { new Guid("45f024d4-63c0-4508-8aae-b13721d74ba1"), "LC", 188 },
                    { new Guid("a8900e96-8822-46a7-8e9b-e93b2ef7e06a"), "ST", 194 },
                    { new Guid("169fe1a9-a335-4655-8168-20394dd4ec70"), "PM", 190 },
                    { new Guid("c31fedc6-356e-4192-94e3-2606b1084b70"), "TG", 223 },
                    { new Guid("3f978f0b-6590-4742-801e-a95156a9f27d"), "TK", 224 },
                    { new Guid("46f5093c-640b-4d21-8a9e-c4384039e347"), "TO", 225 },
                    { new Guid("7f7ac097-b4de-4b00-be19-ac08e2c631b3"), "TT", 226 },
                    { new Guid("67baafbd-3f2c-4168-a08b-b2593d5ed770"), "TN", 227 },
                    { new Guid("c6e090dd-626e-4980-9751-5adfe3085383"), "TR", 228 },
                    { new Guid("2e388040-2009-463f-a02d-3031d81273b7"), "TM", 229 },
                    { new Guid("543d9145-b121-4687-9741-4b74e8b15b0f"), "TC", 230 }
                });

            migrationBuilder.InsertData(
                table: "CountryCode",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("e0572937-c553-4ecb-bc71-4cb05eca8118"), "TV", 231 },
                    { new Guid("24870ad2-b99e-4871-a8ed-18169be90bc7"), "UG", 232 },
                    { new Guid("d7cf4e28-11a0-40ea-9681-dab31b02c4a4"), "UA", 233 },
                    { new Guid("dbd6ea82-49d6-422b-8b4a-7c511b54ed65"), "AE", 234 },
                    { new Guid("a25d4518-47d0-48fb-8229-14944135ade2"), "GB", 235 },
                    { new Guid("b823f938-3811-430c-b7f2-7ec096499d6f"), "US", 236 },
                    { new Guid("c12fae3e-2b06-456c-99cf-46bbd6ceb836"), "UM", 237 },
                    { new Guid("3b584d28-02db-4439-9502-dd8f6c61a64c"), "UY", 238 },
                    { new Guid("4c22885a-c098-4bb9-9d7e-8f9bc96999a6"), "UZ", 239 },
                    { new Guid("8cbf17d3-9425-40d3-9ce9-a0fc7e19aea2"), "VU", 240 },
                    { new Guid("fc46bb97-afab-4ba2-87c2-51e46a8ecdd1"), "VE", 241 },
                    { new Guid("72e53b3c-4e5f-40d0-bbf0-55b07a896590"), "VN", 242 },
                    { new Guid("4e91e9cd-2725-4d1a-8c36-24d1e169da01"), "VG", 243 },
                    { new Guid("bb3c65b7-3b2b-4879-8650-37f53aa79f4d"), "VI", 244 },
                    { new Guid("db484cbf-f370-4f0b-a946-6bba027b7cf5"), "WF", 245 },
                    { new Guid("899601b6-6ea2-4f46-9159-62b6640539c2"), "EH", 246 },
                    { new Guid("a26bb9d2-a365-4db7-8e3c-cd2d38612ca0"), "YE", 247 },
                    { new Guid("f4936197-3a64-4c2c-a35a-dfd9c293c66f"), "ZM", 248 },
                    { new Guid("ae396b4b-9520-4896-bc54-4af85c424fe4"), "ZW", 249 },
                    { new Guid("1b0927f6-a0ed-4625-861b-79803bee3147"), "TL", 222 },
                    { new Guid("2be9a338-276f-4978-98c8-041643880440"), "TH", 221 },
                    { new Guid("ca11ce7d-b0e5-4046-b8a0-f6f6c780ba7a"), "TZ", 220 },
                    { new Guid("4ddb0bc7-ff82-461a-bd9e-b5954e270c84"), "TJ", 219 },
                    { new Guid("ea636b70-4b95-4730-8914-8390b061bb10"), "VC", 191 },
                    { new Guid("9441f4c5-bb89-4a14-87dc-07337c95420d"), "WS", 192 },
                    { new Guid("2a9a2052-a005-4519-8dbc-4fd28a166190"), "SM", 193 },
                    { new Guid("40dcaccc-ab0e-4bbc-9463-ad05a78557c9"), "LR", 126 },
                    { new Guid("3d11dbcd-3c89-4ee9-bbe6-d75758db88ef"), "SA", 195 },
                    { new Guid("6d7ed103-80d6-4ca3-bb26-8e9c12743891"), "SN", 196 },
                    { new Guid("57f30592-a2c1-4006-b14a-c3536b116eab"), "RS", 197 },
                    { new Guid("71fcbc12-27e7-4ea4-a7a7-b7b9fc0f2b90"), "SC", 198 },
                    { new Guid("e1c2ee86-96ce-4652-a177-2e55e9eae2b6"), "SL", 199 },
                    { new Guid("cecd3b33-ca6a-4ae3-ad48-4e2c6920ded2"), "SG", 200 },
                    { new Guid("b32ef298-46aa-4935-b382-f89bb74a56a8"), "SX", 201 },
                    { new Guid("3bd3daef-72ba-4e24-8fb0-23d1f9573234"), "SK", 202 },
                    { new Guid("3ede45e1-75a8-44f7-89f5-d82eec726cb0"), "SI", 203 },
                    { new Guid("265558a4-2997-4237-9e1f-2b52e1530ddd"), "MF", 189 },
                    { new Guid("2b5997d4-fed8-4d84-8e9a-7155f0f6e30f"), "SB", 204 },
                    { new Guid("b0720023-38b1-4755-bf17-8df25af0b563"), "ZA", 206 },
                    { new Guid("793ccced-594e-49a9-bb9e-dd14846743a7"), "GS", 207 },
                    { new Guid("4305f445-f71e-4431-aae8-af17c142f0fe"), "SS", 208 },
                    { new Guid("d19bd931-6f0c-4385-922e-60b80911c3c3"), "ES", 209 }
                });

            migrationBuilder.InsertData(
                table: "CountryCode",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("2ddee2d6-2837-4fc9-ba2f-3f96d8ad3f96"), "LK", 210 },
                    { new Guid("70aab969-07b3-44df-a9a0-b0bc377882ba"), "SD", 211 },
                    { new Guid("2d88a249-d595-4119-96ec-a4f49060f11c"), "SR", 212 },
                    { new Guid("492bbfe4-a958-4d30-b381-2d6e4e85c4e3"), "SJ", 213 },
                    { new Guid("ac4a97b0-cccf-4270-bd95-e3f8633d1849"), "SZ", 214 },
                    { new Guid("44d41499-24b2-454b-8872-7fd8f97977f0"), "SE", 215 },
                    { new Guid("09d4c394-aeda-4568-86f3-796c8aa0ac0a"), "CH", 216 },
                    { new Guid("9668f8e8-cc35-42b1-adc7-4451e930950e"), "SY", 217 },
                    { new Guid("3ee870be-f63a-4d12-a3b4-26f3a63b7b2f"), "TW", 218 },
                    { new Guid("9bc5e60a-5bea-4d44-9ef4-e47a38375d89"), "SO", 205 },
                    { new Guid("9a53b9ee-33c5-4172-bf17-5aac3cbb9c24"), "LS", 125 },
                    { new Guid("57a68162-b2a5-4c49-beea-6f9d5da08383"), "LU", 130 },
                    { new Guid("8b6882e3-ebc4-4146-a822-83c00eec7422"), "LV", 123 },
                    { new Guid("126314a7-831e-4d76-acbd-7c00d8fcbd97"), "IO", 33 },
                    { new Guid("2e490952-cb0e-4c83-baae-eb35cc87eb55"), "BN", 34 },
                    { new Guid("64952b9a-6dec-46f8-9bb5-720c2ddcba13"), "BG", 35 },
                    { new Guid("504fd77f-6d82-4ce2-b7ab-167d08a16604"), "BF", 36 },
                    { new Guid("e8f7cb10-a369-445c-b93d-1c3562c2f67a"), "BI", 37 },
                    { new Guid("eb702932-2f92-49bb-b098-d06597526056"), "CV", 38 },
                    { new Guid("db06edb2-7c85-484b-99b6-850295ca0b24"), "KH", 39 },
                    { new Guid("f0344ca8-d893-47a9-8600-6bfdfffde818"), "CM", 40 },
                    { new Guid("2fda1766-7f33-4961-aae7-e7a22b61e19e"), "CA", 41 },
                    { new Guid("7c71300d-e454-4fd6-8889-00b6484ca0b0"), "KY", 42 },
                    { new Guid("dcd55dba-06e6-4736-bf51-3c98ac91473f"), "CF", 43 },
                    { new Guid("d5eae9e3-a61e-4ea1-bd99-4397312e3463"), "TD", 44 },
                    { new Guid("48f45eab-d549-4486-895d-bd47d095b278"), "CL", 45 },
                    { new Guid("45db3d7b-9c1c-4043-9281-b77d08b4991b"), "CN", 46 },
                    { new Guid("5fa3cfdc-2c7a-4a23-9e30-7bc8ff4b2a19"), "CX", 47 },
                    { new Guid("2530f4b8-718a-491f-ac47-21485624faf5"), "CC", 48 },
                    { new Guid("c35954ba-688b-47a9-bd35-4839b177b93e"), "CO", 49 },
                    { new Guid("1fe09f59-c6cb-4ad7-9fe8-c9d3cce370b9"), "KM", 50 },
                    { new Guid("dd0062a4-32bc-429b-bb53-276a41bff398"), "LB", 124 },
                    { new Guid("ff0fc2e9-1986-42bc-b178-6122e0545e10"), "CD", 52 },
                    { new Guid("3cd59a07-6859-4d8c-a442-5fc26aa3f221"), "CK", 53 },
                    { new Guid("52be9eca-5083-419c-b44f-f9567818742b"), "CR", 54 },
                    { new Guid("0c594c13-cbd3-4d43-bdca-fea439dde715"), "CI", 55 },
                    { new Guid("92fb8efc-a2c9-4c7d-8c21-60aa254e3909"), "HR", 56 },
                    { new Guid("7bfcf2c1-f392-4047-869e-427e2820fdcc"), "CU", 57 },
                    { new Guid("07e69fe0-d995-4891-b272-bacafe883c46"), "CW", 58 },
                    { new Guid("4f357f9c-730d-4e62-9104-19844b16d53d"), "CY", 59 },
                    { new Guid("7c35632f-a972-41ff-bfb1-4f2d73666d3d"), "BR", 32 },
                    { new Guid("0c7e32d5-3d6e-4ec6-80a8-05f5988b4de8"), "BV", 31 }
                });

            migrationBuilder.InsertData(
                table: "CountryCode",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("b6f13e00-b8a5-4d34-a8a3-e32243faf78c"), "BW", 30 },
                    { new Guid("ce0aaf69-c06e-44fe-ba9d-67b3bc7d3e41"), "BA", 29 },
                    { new Guid("d1253353-860c-470f-a039-72a2b05a02bd"), "AF", 1 },
                    { new Guid("808d1253-4f63-4d9f-817e-7cdf306e73b0"), "AX", 2 },
                    { new Guid("75aa9bed-ac0e-4ccc-bf72-5b8d67a49c15"), "AL", 3 },
                    { new Guid("67067674-3835-47fd-a726-85322f421f35"), "DZ", 4 },
                    { new Guid("dbc3f25e-41bf-43eb-b006-86d44f47ca99"), "AS", 5 },
                    { new Guid("d37f6880-b350-4d55-a95e-96ad276b1352"), "AD", 6 },
                    { new Guid("10989252-9639-4fe2-b26f-dec0d85b5c08"), "AO", 7 },
                    { new Guid("44727a85-84fe-4043-9319-458df8cb90e2"), "AI", 8 },
                    { new Guid("4dd2b8fa-aefe-4c6e-a315-95d8b0befa08"), "AQ", 9 },
                    { new Guid("52f3fe37-86e2-4f05-8afd-9bda30123b18"), "AG", 10 },
                    { new Guid("7f369fb8-9f08-47c4-aaae-02fd78ca0e1b"), "AR", 11 },
                    { new Guid("13866008-fe73-4085-b207-df7aeb4ef793"), "AM", 12 },
                    { new Guid("6d086eda-7de5-4947-8d5b-23a05454dc04"), "AW", 13 },
                    { new Guid("91eec6c4-62b4-443e-a43b-f84988469b18"), "CZ", 60 },
                    { new Guid("b9216e26-180c-48d0-b1b3-508289acaa5f"), "AU", 14 },
                    { new Guid("7b07ec86-fc1a-4b0a-9077-08e39a3890d5"), "AZ", 16 },
                    { new Guid("92ec9d9f-d51b-4357-8d06-ed92b63e1c82"), "BS", 17 },
                    { new Guid("bf0916b4-41e0-44a4-ab63-0e7752b00234"), "BH", 18 },
                    { new Guid("27d68970-6e88-432b-aea1-1e331b2e4f95"), "BD", 19 },
                    { new Guid("2da7bfc3-69b1-4066-9387-2c12bf8bafea"), "BB", 20 },
                    { new Guid("23841bbd-d329-4c0a-a82c-8261e940a588"), "BY", 21 },
                    { new Guid("85daa31a-c721-49da-aeef-ff8df4e7dce8"), "BE", 22 },
                    { new Guid("84ab3828-e368-4287-abef-f90616916606"), "BZ", 23 },
                    { new Guid("155e9cd8-2d4d-401c-892e-a95c13f9b89b"), "BJ", 24 },
                    { new Guid("c5d03cb2-a2d1-4088-97bc-ec694866e9ff"), "BM", 25 },
                    { new Guid("756f1c96-c85c-4044-8645-3cd1580c32c3"), "BT", 26 },
                    { new Guid("117d18c1-9f23-4977-96d2-46e568c3c8e9"), "BO", 27 },
                    { new Guid("e3b416a7-0868-4565-bf34-f05717f1bc06"), "BQ", 28 },
                    { new Guid("db3953aa-4660-42ae-9f91-1d85eb4168ae"), "AT", 15 },
                    { new Guid("62f72258-57e1-4331-b9e8-520244327f0e"), "DK", 61 },
                    { new Guid("1a2abbb1-b8f3-40e2-9950-2e0c4917613b"), "CG", 51 },
                    { new Guid("1834f6ec-5009-4997-98e2-614cbd71af6f"), "DM", 63 },
                    { new Guid("42979981-ab02-4cf3-84ff-949e3ffa51a0"), "HT", 96 },
                    { new Guid("e67845ca-c206-40ab-84f3-5e7892fd3d61"), "HM", 97 },
                    { new Guid("a1119316-56fa-41c2-ba90-495fffbdf13d"), "VA", 98 },
                    { new Guid("953e7ea1-6e83-46bd-bf49-6882a372cd8c"), "HN", 99 },
                    { new Guid("5c173095-ec46-46b3-93b8-d392c9369093"), "HK", 100 },
                    { new Guid("dcf0a977-1ee9-46c5-9150-8bb1461d3bcb"), "HU", 101 },
                    { new Guid("ae0c23fc-b6f8-47e6-bc93-510b6a56d15f"), "IS", 102 },
                    { new Guid("7fea8b1b-7664-4cfb-bb1a-9d3b19d089b2"), "IN", 103 }
                });

            migrationBuilder.InsertData(
                table: "CountryCode",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("a376a259-104b-4994-890f-fad5ff748346"), "ID", 104 },
                    { new Guid("ec00737b-17dd-440e-a27b-9594dd0fb701"), "DJ", 62 },
                    { new Guid("72c5697b-b4b4-48de-9a4b-622fcdbe3a24"), "IQ", 106 },
                    { new Guid("df0e0525-4b96-4881-8c85-0776c1268bee"), "IE", 107 },
                    { new Guid("4ff8e453-e71d-479b-823b-3efbbc79c676"), "IM", 108 },
                    { new Guid("5fc9ffe3-d141-40d2-885f-9f46827c2179"), "IL", 109 },
                    { new Guid("a7c348cc-11e8-476b-bc37-469d11b1cce7"), "IT", 110 },
                    { new Guid("c48279b3-c89c-4c7f-86c2-69d691c2c3c3"), "JM", 111 },
                    { new Guid("cde9a50e-877c-4acc-ab63-9ee5296a6668"), "JP", 112 },
                    { new Guid("e58e6dd6-736a-4bfb-b28d-0728a16b68e4"), "JE", 113 },
                    { new Guid("ccf6b61c-ae71-4720-884e-7ec3b98eccc6"), "JO", 114 },
                    { new Guid("93f640dd-af80-4805-b27a-9239714c1026"), "KZ", 115 },
                    { new Guid("44aa5075-7e49-4498-a622-333ff86f0195"), "KE", 116 },
                    { new Guid("837fc443-e1f5-4212-98e4-e7eb057d4fd3"), "KI", 117 },
                    { new Guid("7f8dc713-563b-41e9-8e4e-1b961e22a6a3"), "KP", 118 },
                    { new Guid("61521711-8373-4102-86b3-5edae59702c8"), "KR", 119 },
                    { new Guid("c9eadf71-2b2c-4007-88f3-eaa199d45302"), "KW", 120 },
                    { new Guid("232e7ca1-fa8c-42a4-a775-02b17d2d4414"), "KG", 121 },
                    { new Guid("5de73a11-c17c-4b7b-84a0-69b9ff753631"), "LA", 122 },
                    { new Guid("5b4bd2b6-4467-4b54-9601-15059c6043b2"), "GY", 95 },
                    { new Guid("ca00ed45-256d-438d-8352-8832d4e0fb3b"), "GW", 94 },
                    { new Guid("e9767f56-ae55-4428-ae19-7c698da057c3"), "IR", 105 },
                    { new Guid("c9ee39ef-59f6-44c0-9b4a-3affffb5d5c6"), "GG", 92 },
                    { new Guid("d2a753a0-2fc2-48f8-9129-c87e4e748ed5"), "DO", 64 },
                    { new Guid("ca9c2097-a452-4529-aea7-2e5d60a9d0bd"), "EC", 65 },
                    { new Guid("c341fc31-7f37-4ce1-acba-df0411c04c3c"), "EG", 66 },
                    { new Guid("2c20e16d-f23b-4c1e-8388-c0f8a6ad46d9"), "GN", 93 },
                    { new Guid("311660f3-a5bf-43d5-890c-7d691e9ae548"), "SV", 67 },
                    { new Guid("25c15afd-a6cc-4511-996d-ef127efc3813"), "ER", 69 },
                    { new Guid("e255f40e-ade4-4f3b-9f82-90c12a71ca17"), "EE", 70 },
                    { new Guid("eb86c1e9-9d8a-46b1-bdae-936ea35b6e55"), "ET", 71 },
                    { new Guid("2ee4e0d1-74a6-4ea5-a2c8-e02d7b1be0c9"), "FK", 72 },
                    { new Guid("74dc9c90-bacd-4ae1-85c3-7277f8b440bc"), "FO", 73 },
                    { new Guid("7db7b81d-26c8-4f05-b061-c8e25a7b954e"), "FJ", 74 },
                    { new Guid("b071d73c-d1e5-4b03-b916-3c623cca02ad"), "FI", 75 },
                    { new Guid("1ad2da97-a7f7-4f87-a4ba-9ceb178f361c"), "FR", 76 },
                    { new Guid("26551d54-0d7a-4db7-add9-574bc465bad2"), "GF", 77 },
                    { new Guid("91752b1d-5a36-4af1-b944-3ec6d5614f73"), "GQ", 68 },
                    { new Guid("4be3b368-3396-4721-9ac5-8a7730affffa"), "TF", 79 },
                    { new Guid("54231bed-a5c0-4d7c-a169-4c21d2271c46"), "GA", 80 },
                    { new Guid("97058246-edf1-434c-9416-8eed11f29466"), "GM", 81 },
                    { new Guid("00c0b052-217b-43a6-a07d-98d895296383"), "GE", 82 }
                });

            migrationBuilder.InsertData(
                table: "CountryCode",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("bdb5a9c1-c779-49e7-8076-945ec2547eb5"), "DE", 83 },
                    { new Guid("cbdf862f-af5d-47d8-af35-29a0ab68359c"), "GH", 84 },
                    { new Guid("c4225974-30ef-4601-8723-206b7923b5e2"), "GI", 85 },
                    { new Guid("6d8e4a52-3ca8-4f0a-b895-acef56eb766c"), "GR", 86 },
                    { new Guid("cb304971-77c8-4a3a-88e0-9c2bc614bb9f"), "PF", 78 },
                    { new Guid("a2aaee53-f29d-46ab-8c50-bb6064cedac1"), "GL", 87 },
                    { new Guid("cb5b588f-4f6c-465e-9de7-ba92574845c5"), "GD", 88 },
                    { new Guid("c618d1c6-28d4-4234-9411-6e2a4525dfa2"), "GP", 89 },
                    { new Guid("6a79a5b5-057f-4103-a87c-fa12425a5d79"), "GU", 90 },
                    { new Guid("a6a7e21f-f1d1-4d17-a811-8102a5038fe5"), "GT", 91 }
                });

            migrationBuilder.InsertData(
                table: "MachineDimensionsType",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("d806b7bf-6e4d-46fd-8d18-211cce2ebb9b"), "THREE_PLUS_TWO_AXIS", 1 },
                    { new Guid("c8bc5a3c-bb74-4e5c-8c4f-499327aca240"), "FIVE_AXIS", 2 },
                    { new Guid("3c2e68ee-cc02-4d1d-9513-1ce73170fd3b"), "THREE_AXIS", 0 }
                });

            migrationBuilder.InsertData(
                table: "MillingMachineDimensionsType",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("7ee4a09e-5fe3-46b9-9afd-72354a21243c"), "FIVE_AXIS", 2 },
                    { new Guid("1205ef7c-df5a-454a-8070-3d158a097fa9"), "THREE_PLUS_TWO_AXIS", 1 },
                    { new Guid("bc1c59af-7c78-49ed-95b1-ae29cc181472"), "THREE_AXIS", 0 }
                });

            migrationBuilder.InsertData(
                table: "MillingMachineType",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("ecc185b6-57c9-4d50-bbfa-8971052a1afe"), "TYPE_1", 0 },
                    { new Guid("a863b002-f736-463f-a124-4d718408fe06"), "TYPE_2", 1 },
                    { new Guid("c4ded1cb-38a1-4983-a3dc-d8a2e0cff378"), "TYPE_3", 2 },
                    { new Guid("86aae675-4121-4de7-84e6-e7c1a4cd72a4"), "TYPE_4", 3 }
                });

            migrationBuilder.InsertData(
                table: "OtherTechnology",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("87336eb8-c54f-491f-b83d-d3576ecab4a4"), "Other", 8 },
                    { new Guid("d7c76506-d968-4afa-968f-82dccb6e83aa"), "Annealing", 7 },
                    { new Guid("89b5d5f5-10ae-41dd-ac3f-7f608b6f774e"), "Knurling", 6 },
                    { new Guid("4f9287a2-5ce4-466f-a72f-34484b020170"), "Toothings", 3 },
                    { new Guid("81abedbc-7822-4add-81bd-2eb6f2406f4b"), "Engravings", 4 },
                    { new Guid("bf45a958-2bca-437a-8756-a9741d920fd1"), "ThreadsTr", 2 },
                    { new Guid("b7342d24-94b0-4c6c-a5b4-e7eddd8a3fac"), "ThreadsM", 1 },
                    { new Guid("e069b824-f2ee-4a96-913a-5b0d99e8fef1"), "DeepHoleDrilling", 0 },
                    { new Guid("87e565f5-e0c7-44d5-b5fc-69a5e5ff16c0"), "LaserMarking", 5 }
                });

            migrationBuilder.InsertData(
                table: "TurningMachineType",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("09dcb5cf-5288-4db4-a464-9b3f997ed23f"), "TURNING_MACHINE_TYPE_3", 2 },
                    { new Guid("762e96ec-74bb-405d-ad2f-86dc60bcb02d"), "TURNING_MACHINE_TYPE_4", 3 },
                    { new Guid("f0ea3b3c-1583-4509-9913-a09fe22f5e27"), "TURNING_MACHINE_TYPE_1", 0 },
                    { new Guid("79000159-f5fc-4663-a050-2817cd31f72d"), "TURNING_MACHINE_TYPE_2", 1 },
                    { new Guid("f82e6a4d-cd79-4fd9-b925-4352e2453f69"), "TURNING_MACHINE_TYPE_5", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_AddressTypeId",
                table: "Address",
                column: "AddressTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_CountryCodeId",
                table: "Address",
                column: "CountryCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_CustomerId",
                table: "Address",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_AddressType_Value",
                table: "AddressType",
                column: "Value");

            migrationBuilder.CreateIndex(
                name: "IX_Certification_Value",
                table: "Certification",
                column: "Value");

            migrationBuilder.CreateIndex(
                name: "IX_CertificationCustomer_CustomersId",
                table: "CertificationCustomer",
                column: "CustomersId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanySize_Value",
                table: "CompanySize",
                column: "Value");

            migrationBuilder.CreateIndex(
                name: "IX_CountryCode_Value",
                table: "CountryCode",
                column: "Value");

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
                name: "IX_Customers_CompanySizeId",
                table: "Customers",
                column: "CompanySizeId");

            migrationBuilder.CreateIndex(
                name: "IX_MachineDimensionsType_Value",
                table: "MachineDimensionsType",
                column: "Value");

            migrationBuilder.CreateIndex(
                name: "IX_MillingMachine_CustomerId",
                table: "MillingMachine",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_MillingMachine_MachineTypeId",
                table: "MillingMachine",
                column: "MachineTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MillingMachine_MillingMachineDimensionsTypeId",
                table: "MillingMachine",
                column: "MillingMachineDimensionsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MillingMachineDimensionsType_Value",
                table: "MillingMachineDimensionsType",
                column: "Value");

            migrationBuilder.CreateIndex(
                name: "IX_MillingMachineType_Value",
                table: "MillingMachineType",
                column: "Value");

            migrationBuilder.CreateIndex(
                name: "IX_OtherTechnology_Value",
                table: "OtherTechnology",
                column: "Value");

            migrationBuilder.CreateIndex(
                name: "IX_TurningMachine_CustomerId",
                table: "TurningMachine",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_TurningMachine_TurningMachineTypeId",
                table: "TurningMachine",
                column: "TurningMachineTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TurningMachineType_Value",
                table: "TurningMachineType",
                column: "Value");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "CertificationCustomer");

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
                name: "AddressType");

            migrationBuilder.DropTable(
                name: "CountryCode");

            migrationBuilder.DropTable(
                name: "Certification");

            migrationBuilder.DropTable(
                name: "OtherTechnology");

            migrationBuilder.DropTable(
                name: "MillingMachineDimensionsType");

            migrationBuilder.DropTable(
                name: "MillingMachineType");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "TurningMachineType");

            migrationBuilder.DropTable(
                name: "CompanySize");
        }
    }
}
