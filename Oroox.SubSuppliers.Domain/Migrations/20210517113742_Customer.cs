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
                    table.UniqueConstraint("AK_AddressType_Value", x => x.Value);
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
                    table.UniqueConstraint("AK_Certification_Value", x => x.Value);
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
                name: "CountryCodeType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryCodeType", x => x.Id);
                    table.UniqueConstraint("AK_CountryCodeType_Value", x => x.Value);
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
                    table.UniqueConstraint("AK_MillingMachineDimensionsType_Value", x => x.Value);
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
                    table.UniqueConstraint("AK_MillingMachineType_Value", x => x.Value);
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
                    table.UniqueConstraint("AK_OtherTechnology_Value", x => x.Value);
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
                    CompanySizeTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerAdditionalInfoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Address_CountryCodeType_CountryCodeTypeId",
                        column: x => x.CountryCodeTypeId,
                        principalTable: "CountryCodeType",
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MillingMachine_MillingMachineType_MillingMachineTypeId",
                        column: x => x.MillingMachineTypeId,
                        principalTable: "MillingMachineType",
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AddressType",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("6267f0a1-4a65-45a1-9420-7fe742fad6c3"), "Shipping", 0 },
                    { new Guid("bc25d13f-99d1-4458-86fc-c862d9c8e31f"), "Billing", 1 }
                });

            migrationBuilder.InsertData(
                table: "Certification",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("b931f643-f1c1-41c9-84fa-a8b55c460810"), "ISO9001", 0 },
                    { new Guid("389144fc-ee57-4eef-8c65-158c5b7cc3e3"), "ISO14001", 1 },
                    { new Guid("00c29f75-f554-42f2-b140-112c5d1f9b39"), "ISO13485", 2 },
                    { new Guid("ee7da6e4-ce16-40ba-bbd2-4a2e9cb19826"), "ITAF16949", 3 },
                    { new Guid("ac86f580-97a2-4f8f-b7b2-13aca3726c36"), "EN9100", 4 },
                    { new Guid("8fa38536-e68e-4a42-9ea6-dd66feadf9c4"), "Other", 5 }
                });

            migrationBuilder.InsertData(
                table: "CompanySizeTypes",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("bdcd87b6-603a-47ff-94ab-b3073e3017b2"), "LessThan100", 100 },
                    { new Guid("d7eea6cd-6ecc-4166-9118-b9374bdd8211"), "LessThan50", 50 },
                    { new Guid("4a645606-ba1c-4867-88f7-495a61507200"), "MoreThan100", 101 },
                    { new Guid("fa8fd2e1-0755-4236-857f-bbff5098c83b"), "LessThan10", 10 },
                    { new Guid("4e55f870-7290-42a8-90a2-89e88c44ed81"), "LessThan25", 25 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeType",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("46b832e0-ca8b-4e9c-b0d0-d4e0341f6dba"), "PA", 171 },
                    { new Guid("bd39592b-206e-4f44-a65e-a006dc19334c"), "NI", 160 },
                    { new Guid("eca3b86b-cec8-49bb-a2a3-cdeed57a7735"), "NE", 161 },
                    { new Guid("ed314697-4bf1-40fc-880e-039cffa977d8"), "NG", 162 },
                    { new Guid("015d81f9-cd67-4191-affb-1363fa40de7d"), "NU", 163 },
                    { new Guid("c02815a6-656c-48d6-afdc-d29ea279257f"), "NF", 164 },
                    { new Guid("89bd87c4-b358-4478-a4da-a137f95adbb2"), "MP", 165 },
                    { new Guid("43dd9739-8275-4429-9f41-ed2f9dcb2e8b"), "NO", 166 },
                    { new Guid("1ddc2881-9b44-40c0-8efe-8cea6acd51e5"), "OM", 167 },
                    { new Guid("33bfb872-7366-4a74-865a-6b74019e71bf"), "PK", 168 },
                    { new Guid("155c2b46-5ce5-43b6-a8e6-9f043e79d7f0"), "PW", 169 },
                    { new Guid("c36e7695-e539-4ee4-861b-9acbb6f931db"), "PS", 170 },
                    { new Guid("47d57bd7-69d3-4e8d-8fa9-900855c6f5fa"), "PG", 172 },
                    { new Guid("a156314b-274c-431a-abf8-bb4f7c611d82"), "PR", 179 },
                    { new Guid("f5848f28-d9bf-4f05-94dc-888235bd9601"), "PE", 174 },
                    { new Guid("aaabc17d-43c1-425d-8035-adb8d6c55ee2"), "PH", 175 },
                    { new Guid("4171ad22-24db-49fb-a022-a3a3ce13e75e"), "PN", 176 },
                    { new Guid("32ddf016-e07c-4d6f-84db-3ecb9f7a64cc"), "PL", 177 },
                    { new Guid("c1707bdc-840c-4e3f-9fc8-80691c89c9eb"), "PT", 178 },
                    { new Guid("27124d2e-510f-44ac-b40b-103169c57c29"), "NZ", 159 },
                    { new Guid("0ee4658f-eecd-47d4-864e-ae7f48b120b6"), "QA", 180 },
                    { new Guid("2447aeed-9211-4d1e-9e6d-882be06bdd23"), "RE", 181 },
                    { new Guid("302f3718-aecd-4d09-b7f1-d185d58f1294"), "RO", 182 },
                    { new Guid("f8ac0931-9352-4db0-89b9-a80b83a7f37a"), "RU", 183 },
                    { new Guid("26a5ecf2-f7cb-4a1c-95d1-5439080c2b7b"), "RW", 184 },
                    { new Guid("e3518af7-afa1-4bc5-afef-70676070a925"), "BL", 185 },
                    { new Guid("48654947-7884-497d-ab12-f1340cefcb50"), "SH", 186 },
                    { new Guid("a1e02d2b-4812-4105-bb14-a82b860353e9"), "PY", 173 },
                    { new Guid("6f892654-e8ea-4e5a-b826-370595f1d0ad"), "NC", 158 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeType",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("cc412306-25e5-4485-b8ed-d975fab708d2"), "MA", 151 },
                    { new Guid("984086f9-33a0-4717-a357-782c6a9605f4"), "NP", 156 },
                    { new Guid("b00c9782-ec3c-49b6-997e-2a91003de297"), "LY", 127 },
                    { new Guid("5c5d6bf6-4b5f-4be6-a698-afcc67dfc839"), "LI", 128 },
                    { new Guid("7f2cce6c-14a5-45e5-8d74-ced2ec9fba65"), "LT", 129 },
                    { new Guid("e2245716-ab12-4e14-aaec-f863c245fc9f"), "MO", 131 },
                    { new Guid("03d13902-f1d4-4978-9564-d9c465108eb6"), "MK", 132 },
                    { new Guid("3116f7b1-b6a3-424d-b4ad-e9baf6e225f3"), "MG", 133 },
                    { new Guid("280f3f23-ddf3-4fd9-8eff-b7bf65bc3d63"), "MW", 134 },
                    { new Guid("7fc70a0b-6f50-4c00-bf45-d9610303eea4"), "MY", 135 },
                    { new Guid("8f10a755-2fa7-4dad-a729-d6586fccfae3"), "MV", 136 },
                    { new Guid("df9bb74b-4104-4616-aa51-31ad18086e5e"), "ML", 137 },
                    { new Guid("48a82db3-9186-4e9d-9dfd-a48d74ec05f2"), "MT", 138 },
                    { new Guid("d33dd066-bb1f-4daa-b3dc-037649b1ba67"), "MH", 139 },
                    { new Guid("689bccbe-92b0-4015-af22-e98350c2aac3"), "MQ", 140 },
                    { new Guid("5ec6c71a-7524-468c-b07a-797efb5f92d4"), "NL", 157 },
                    { new Guid("a8589144-6513-47c2-9658-397380b72c3b"), "MR", 141 },
                    { new Guid("5bb9d509-028b-4ec5-986a-515ce12520d8"), "YT", 143 },
                    { new Guid("9c2e7670-d853-44ca-b8b7-c2e9ea0a23fa"), "MX", 144 },
                    { new Guid("07de659c-855c-4c15-90ac-e27253f7609f"), "FM", 145 },
                    { new Guid("c02c195b-4ada-42a6-96a1-167e389fadbb"), "MD", 146 },
                    { new Guid("b353fede-3c41-4871-b407-b13aa7eed09d"), "MC", 147 },
                    { new Guid("a41b96bc-adb7-45ac-9fa6-fae98c8de24e"), "MN", 148 },
                    { new Guid("ff7cd1e7-7dc4-42bc-b317-e11eb0de72ff"), "ME", 149 },
                    { new Guid("f81e682b-6896-4539-a72d-933f40ddc71f"), "MS", 150 },
                    { new Guid("903d0ebd-5a96-465b-a478-ce4d4777d974"), "KN", 187 },
                    { new Guid("0228f16f-d39f-4ae9-865d-f752b689cdcc"), "MZ", 152 },
                    { new Guid("21490c86-8138-4f69-b7fa-081974a31903"), "MM", 153 },
                    { new Guid("7df689b1-3f69-441e-9242-2e788cc490c2"), "NA", 154 },
                    { new Guid("e8f8f8c4-3a77-4523-9fdb-1e6ff905982a"), "NR", 155 },
                    { new Guid("ed82ef11-8e97-42f3-ad3d-4f06cf3bf0d5"), "MU", 142 },
                    { new Guid("c1a84cdb-752e-409d-a326-d202cd0d4a4c"), "LC", 188 },
                    { new Guid("1fd65baa-a9a0-4eb2-a777-1082a1954d2c"), "ST", 194 },
                    { new Guid("1dd25007-bac6-4af1-8807-76db580e65ac"), "PM", 190 },
                    { new Guid("9c852227-41ac-4f49-afbe-27c6869648ec"), "TG", 223 },
                    { new Guid("c54bb71a-04f0-48f7-8fd7-072f4ca28869"), "TK", 224 },
                    { new Guid("067d029f-3386-4cf6-936e-42b3c6700d9a"), "TO", 225 },
                    { new Guid("631bd74a-698f-4bc5-b8e5-877f66011fcd"), "TT", 226 },
                    { new Guid("4350e755-fe34-45fb-997c-1411f29afb71"), "TN", 227 },
                    { new Guid("04dda2ed-04fb-4045-a4f4-f8fe1263680f"), "TR", 228 },
                    { new Guid("0fd9c9ce-5d19-4f18-b4b0-eaa98fa4962c"), "TM", 229 },
                    { new Guid("041a73c1-94e4-40b5-be2b-a7104815727b"), "TC", 230 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeType",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("32d2a6b7-32a5-498b-9ea4-e4a22a2d7493"), "TV", 231 },
                    { new Guid("3d6477de-7e24-43f5-a615-7a3d28fc6992"), "UG", 232 },
                    { new Guid("be8727d6-856e-4de2-bc95-65bf19fb191f"), "UA", 233 },
                    { new Guid("71f70988-0b5a-46be-9019-32c8ced442f9"), "AE", 234 },
                    { new Guid("e2e334c7-caab-4151-a9b3-1eb5b32c5f4c"), "GB", 235 },
                    { new Guid("bb7e7d49-1fb0-4f70-8129-ee5e6d6ccd53"), "US", 236 },
                    { new Guid("93a0c180-1f30-4638-ae48-fb8085162638"), "UM", 237 },
                    { new Guid("f0b716d7-c0b0-4d1d-92a5-27c5eee0f61a"), "UY", 238 },
                    { new Guid("223b254e-84c2-41ef-a368-9c81800d66e9"), "UZ", 239 },
                    { new Guid("f78824ba-afc6-411a-b79e-e5051d449970"), "VU", 240 },
                    { new Guid("8f0f1646-4395-402c-9818-d3ace985b33b"), "VE", 241 },
                    { new Guid("f712485d-e5de-4620-be5b-fa9cec50220a"), "VN", 242 },
                    { new Guid("0b34c110-1742-42a4-876d-c81c68877838"), "VG", 243 },
                    { new Guid("26d1c0e5-1628-48ff-87d1-fc2b12d107f4"), "VI", 244 },
                    { new Guid("328de1e9-05c1-47cc-8fc9-ddc823009173"), "WF", 245 },
                    { new Guid("3d219530-b74a-4bb3-bdd1-bc240286300b"), "EH", 246 },
                    { new Guid("14148840-50f1-413c-9149-bbffe2446e13"), "YE", 247 },
                    { new Guid("4dea1eb7-b158-4d63-9d8f-47c2f35346bb"), "ZM", 248 },
                    { new Guid("d274458d-38b5-4be9-b5cc-58dbf450139a"), "ZW", 249 },
                    { new Guid("3e43967e-6104-431c-8079-73130054040b"), "TL", 222 },
                    { new Guid("88b2870e-4207-48df-bc31-0435f44d7e3f"), "TH", 221 },
                    { new Guid("57b56a9c-fe4b-4759-aff7-2212bf14a7c5"), "TZ", 220 },
                    { new Guid("71924ca9-9bec-4a60-9bad-6a1096d20207"), "TJ", 219 },
                    { new Guid("dc3c83ac-00ac-484e-a355-90bf3836d6e0"), "VC", 191 },
                    { new Guid("38cc6eb3-da6d-4282-a341-c4c2cd7f700b"), "WS", 192 },
                    { new Guid("b849d2b4-6dda-4a91-a081-7aa08e7ad235"), "SM", 193 },
                    { new Guid("83995e4a-0a93-4618-bd7a-9af3ad2717d6"), "LR", 126 },
                    { new Guid("c1804492-b37d-49e9-8142-612672f67370"), "SA", 195 },
                    { new Guid("59ee66a8-0506-4fd0-9ba7-a33c2d941b95"), "SN", 196 },
                    { new Guid("f90f92a3-2b7f-4b22-8882-9b28f60fbb2e"), "RS", 197 },
                    { new Guid("59a14fa6-2e4b-4d7f-a748-e84204f5af9a"), "SC", 198 },
                    { new Guid("54e5e330-b8d3-4c4b-9531-90a5a97ffe12"), "SL", 199 },
                    { new Guid("bccc6713-9485-4ef8-bafc-de3f2920504d"), "SG", 200 },
                    { new Guid("6ed5bc2b-605d-4257-9be8-cfe55227d58b"), "SX", 201 },
                    { new Guid("4d7289e1-5a37-4168-92c9-39353382e2d6"), "SK", 202 },
                    { new Guid("29a77941-cdb0-46a5-8f67-4af595e85ec8"), "SI", 203 },
                    { new Guid("7a0765d0-5073-4946-9b8d-a7e22bf5199b"), "MF", 189 },
                    { new Guid("03964a61-f40a-4d47-aad4-7554a86dbc41"), "SB", 204 },
                    { new Guid("0c03898f-7483-41ce-b723-d1172b03a210"), "ZA", 206 },
                    { new Guid("849ef571-9544-4afa-9a92-af0208ffca7e"), "GS", 207 },
                    { new Guid("c34fc8d4-c93a-45d3-9c26-c108935e37dd"), "SS", 208 },
                    { new Guid("da00527b-be8c-4514-a921-340cd96985b9"), "ES", 209 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeType",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("82cb2ae0-6519-4727-b8cd-877abf000453"), "LK", 210 },
                    { new Guid("d0c36ef5-a339-411a-86ba-4c32fa7aa830"), "SD", 211 },
                    { new Guid("ea3e38ef-c2ef-40bd-8b9b-1d2cbeccf6b1"), "SR", 212 },
                    { new Guid("1867979d-3db4-4795-a79c-186db24ce26f"), "SJ", 213 },
                    { new Guid("abccb784-f22b-4b29-87b8-4a1081bfcb35"), "SZ", 214 },
                    { new Guid("16f6c4cd-3d7b-4648-ae8b-f9c7588b44b2"), "SE", 215 },
                    { new Guid("a35441f8-13e2-404f-ad38-e42f0cac0f59"), "CH", 216 },
                    { new Guid("5dc05d2f-440a-4ff1-8520-8f8749ace929"), "SY", 217 },
                    { new Guid("6f15aeae-e1ed-425f-895c-2e74e10671b9"), "TW", 218 },
                    { new Guid("e90dffea-75af-4bde-9e67-92bdda222670"), "SO", 205 },
                    { new Guid("3c396e85-4987-4a2b-ad95-093bbce7a83d"), "LS", 125 },
                    { new Guid("63733e62-f3ab-42f1-b790-9dcb6970e804"), "LU", 130 },
                    { new Guid("beeec53b-77b1-43b9-90cc-afa426e18e80"), "LV", 123 },
                    { new Guid("a3b1ce21-3aaa-4711-ba10-e120a16fa7ec"), "IO", 33 },
                    { new Guid("7c3aa7cb-5432-4c58-b575-9b08d6bcf160"), "BN", 34 },
                    { new Guid("033d322e-e4e5-4c0a-bca5-eed14fbace19"), "BG", 35 },
                    { new Guid("f67accf5-7ed7-4ea7-8cdb-38220de5c9d6"), "BF", 36 },
                    { new Guid("e5f875d6-e17b-409e-92a7-fa7ef90ad055"), "BI", 37 },
                    { new Guid("3bb65d00-c5a8-4abf-9dea-c8db5999e4dd"), "CV", 38 },
                    { new Guid("e336694a-131b-4bcf-96ac-fd9408181150"), "KH", 39 },
                    { new Guid("c6de6b70-023e-4190-84e3-ab11e61ff808"), "CM", 40 },
                    { new Guid("1022c57e-cb71-4394-851b-fa9f398d6ac8"), "CA", 41 },
                    { new Guid("1e269890-2008-4f70-8264-52aec3633002"), "KY", 42 },
                    { new Guid("11b8ea45-052f-4189-9762-3dbd847ee31e"), "CF", 43 },
                    { new Guid("9194ce8e-1835-4829-a4ba-e0b6ab2ed39f"), "TD", 44 },
                    { new Guid("be364f25-b51f-4fda-a1c6-5536a7a4af59"), "CL", 45 },
                    { new Guid("a7cd4bea-5b0f-4f4c-860a-603e97fa8e2c"), "CN", 46 },
                    { new Guid("38986822-49c9-419b-beff-76d46064f0d6"), "CX", 47 },
                    { new Guid("2368a042-cdc0-40b7-92af-6a3139cc2e7f"), "CC", 48 },
                    { new Guid("cea3bcea-f131-4e28-9137-f8e07089b268"), "CO", 49 },
                    { new Guid("87149cc5-2bb3-4f56-bcee-e32f1955e9c8"), "KM", 50 },
                    { new Guid("5857e20a-2b02-4961-b199-376096acc967"), "LB", 124 },
                    { new Guid("e1d4b1b5-8456-4060-9cc1-48ae68f3f6d8"), "CD", 52 },
                    { new Guid("13cf6a8c-815c-421c-917b-974de304e6bd"), "CK", 53 },
                    { new Guid("7531e01f-a6f8-4b5c-ac5d-058b3d8497f1"), "CR", 54 },
                    { new Guid("c37e40f2-f392-4941-abf8-018c8af79f55"), "CI", 55 },
                    { new Guid("1b7a16f9-5668-477b-b54d-6decda4fe4b4"), "HR", 56 },
                    { new Guid("2a3c4cd6-3812-45c7-8739-afcb9686ae29"), "CU", 57 },
                    { new Guid("833a739c-6d18-47e8-8e9e-5419ca426bcb"), "CW", 58 },
                    { new Guid("f035afb5-98fb-40a4-9b73-56621331ffe8"), "CY", 59 },
                    { new Guid("7c75b5ec-b74d-47e3-9809-b3e5143eb9ad"), "BR", 32 },
                    { new Guid("94b94540-cddc-4f4b-a7a2-bc620a33a00d"), "BV", 31 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeType",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("37e9b6d0-e880-4bf8-9f04-180f04136fcb"), "BW", 30 },
                    { new Guid("67ced096-6146-4494-b218-b5a05bff8ba3"), "BA", 29 },
                    { new Guid("c390510c-556e-47ab-8f2f-c027669585a8"), "AF", 1 },
                    { new Guid("2b3cb465-a06f-4481-b56a-745d6b3f0672"), "AX", 2 },
                    { new Guid("393db64e-a658-4a04-86d2-5675e64c3754"), "AL", 3 },
                    { new Guid("1636db9f-b1ea-4f82-ba84-9b06e97bab25"), "DZ", 4 },
                    { new Guid("4e52528e-5219-4aec-ba3b-155685424e0d"), "AS", 5 },
                    { new Guid("c0a7f8ea-635e-45bd-af59-85ad4b78c7bb"), "AD", 6 },
                    { new Guid("eab18277-909f-4f4f-ae23-2444fe18c217"), "AO", 7 },
                    { new Guid("0609f999-8c44-4adb-a6b6-1b9bfc87a26b"), "AI", 8 },
                    { new Guid("bb9e200e-d150-494f-ad49-5d14f309a776"), "AQ", 9 },
                    { new Guid("790af826-7332-4fff-ae32-ca36f2fa0111"), "AG", 10 },
                    { new Guid("44ea2527-690c-41b3-8276-d5d7e4a71404"), "AR", 11 },
                    { new Guid("317d9bc5-cef1-404a-b0b9-3427600b016e"), "AM", 12 },
                    { new Guid("097329bd-834c-4f14-a2f3-6acc4962f608"), "AW", 13 },
                    { new Guid("399f2b95-0bf6-4278-ab22-f98406cc1c9c"), "CZ", 60 },
                    { new Guid("9d0ee05c-8a68-44c7-9b8c-c0cc45737a68"), "AU", 14 },
                    { new Guid("465f17be-8c4c-4458-999c-e181223b5469"), "AZ", 16 },
                    { new Guid("fc2592a1-44d8-414c-b3be-c9e3395724a2"), "BS", 17 },
                    { new Guid("7e8ce6aa-534b-4af1-ae99-fe10a1d7d01b"), "BH", 18 },
                    { new Guid("dedbfca3-7bfa-4656-93b7-2e5c87ebb426"), "BD", 19 },
                    { new Guid("f33e796c-8cd2-47b9-88e3-c6afaf61e8f2"), "BB", 20 },
                    { new Guid("73727b52-e484-4878-8bb2-2699d2d8bc28"), "BY", 21 },
                    { new Guid("b64f23a4-9c43-471a-a83a-6cdb8b17988a"), "BE", 22 },
                    { new Guid("adc920d1-0827-476c-b42d-694d1f507cd4"), "BZ", 23 },
                    { new Guid("5f9490a9-b14c-4c3f-81d7-46373cbf55e3"), "BJ", 24 },
                    { new Guid("7e8001e4-7cb5-418b-bf0e-a9b8806b1aa3"), "BM", 25 },
                    { new Guid("be741de3-fb65-422a-9278-5c3bfa5750ff"), "BT", 26 },
                    { new Guid("6a17e070-6a00-4892-95ee-1a59da1ffdc5"), "BO", 27 },
                    { new Guid("bf3e3fba-560c-4616-9f9d-83e0c608efb4"), "BQ", 28 },
                    { new Guid("4dd3640f-1239-4682-b21d-105e6c0c7d0a"), "AT", 15 },
                    { new Guid("dd2dbd41-90cc-45be-bd4d-d29eb13beb1c"), "DK", 61 },
                    { new Guid("4e1f8b63-a570-49e3-a57d-626fc791dc5a"), "CG", 51 },
                    { new Guid("64800852-4ea6-4cab-b3c1-b285ca42ceba"), "DM", 63 },
                    { new Guid("8553750d-22c3-464d-8fd1-d01276b9cf1a"), "HT", 96 },
                    { new Guid("3d6f95ff-73dd-4504-a652-992e3ef6128a"), "HM", 97 },
                    { new Guid("0a410193-e5ec-4067-b2fe-46f13f966cbf"), "VA", 98 },
                    { new Guid("efa35a04-bc59-4a0c-a181-44c22f954aa5"), "HN", 99 },
                    { new Guid("d560eb00-fb3e-4c5a-be15-13da0b4f2280"), "HK", 100 },
                    { new Guid("a43a503c-840d-4982-81cb-f42b1bab2404"), "HU", 101 },
                    { new Guid("9a8cf6ba-94da-45de-b301-0ec67df254f0"), "IS", 102 },
                    { new Guid("52bc4845-7cfb-46b0-8275-30735549fb14"), "IN", 103 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeType",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("3ce20367-c6ef-46e9-ac57-4960d3a0e918"), "ID", 104 },
                    { new Guid("3a0cfde5-430a-47be-baa1-8f8e244f980b"), "DJ", 62 },
                    { new Guid("593db72f-e00c-4165-b851-6bfa6a3cb9c5"), "IQ", 106 },
                    { new Guid("3104518a-cdfc-4e7f-b119-d097b07823e0"), "IE", 107 },
                    { new Guid("d9090e7a-f5ff-458a-85ff-c6c0ce03621e"), "IM", 108 },
                    { new Guid("78e59c2f-e152-468a-afca-ece90faa30be"), "IL", 109 },
                    { new Guid("7fe3f3a2-a7f3-4907-b697-f7375c145824"), "IT", 110 },
                    { new Guid("cd26dc37-5c71-4c2b-8381-e4773a8de36c"), "JM", 111 },
                    { new Guid("a0626187-e2da-4fd9-8935-831a9fe259f8"), "JP", 112 },
                    { new Guid("30846950-595a-4e9d-b2fc-8bd6c5c53309"), "JE", 113 },
                    { new Guid("b0c04434-8af5-4f6e-b19a-297c3738480d"), "JO", 114 },
                    { new Guid("a88565ec-f4f4-4bdf-b647-7cb76ac8301a"), "KZ", 115 },
                    { new Guid("351d2771-8500-4591-a8fc-6518816143b8"), "KE", 116 },
                    { new Guid("2fd8e62d-03f5-43da-a34e-137359b5f82e"), "KI", 117 },
                    { new Guid("1f099d5e-b51c-4a4a-96cb-09f650b19784"), "KP", 118 },
                    { new Guid("38b4ad3a-43ab-4a34-bdc3-99b4afb9c511"), "KR", 119 },
                    { new Guid("576bd41f-ba84-470a-8902-c107faf668eb"), "KW", 120 },
                    { new Guid("d2f948ab-20de-42d1-8db0-669e51f3aff1"), "KG", 121 },
                    { new Guid("11b8d791-3493-4681-907a-ad82f9af7788"), "LA", 122 },
                    { new Guid("56cc2d4c-7e0d-462d-9a64-f39481ee20f3"), "GY", 95 },
                    { new Guid("7ebd20a9-1ca7-4dc9-8c6b-59b769bc353f"), "GW", 94 },
                    { new Guid("bb031e07-7567-4706-82d0-59e36283ff41"), "IR", 105 },
                    { new Guid("c94f7e2b-edf0-4ac9-ba2e-24935c52dc8e"), "GG", 92 },
                    { new Guid("ae15bce0-48cb-4fd3-b956-05740c7172b7"), "DO", 64 },
                    { new Guid("19f8bba6-af5f-4a29-bdb0-676505ed01a0"), "EC", 65 },
                    { new Guid("74f0d480-c848-4755-b495-afdf1946f13e"), "EG", 66 },
                    { new Guid("c60f40d0-87a4-46cd-8c42-3d101e88378e"), "GN", 93 },
                    { new Guid("79d76b35-1ac0-4341-81c8-e1d91d00efcf"), "SV", 67 },
                    { new Guid("44bf5df2-0957-446e-a60d-fe873512cf9a"), "ER", 69 },
                    { new Guid("ccaa9918-976c-4ff3-bc81-d972a974f4ae"), "EE", 70 },
                    { new Guid("f08289f7-fdb5-4067-8be5-00309ac81144"), "ET", 71 },
                    { new Guid("1414ea5c-d1c2-42cb-be1c-968bafd2c9e1"), "FK", 72 },
                    { new Guid("b146f68d-9f85-4164-888c-79cf9b19d5e8"), "FO", 73 },
                    { new Guid("458a196c-13f3-4ca2-a5b2-3c7c485696a0"), "FJ", 74 },
                    { new Guid("a6446357-eae0-412f-abb4-d55db92a35c5"), "FI", 75 },
                    { new Guid("5b59493b-7093-49a0-870e-f391cdde8b1d"), "FR", 76 },
                    { new Guid("a18699c3-e820-4be9-9f89-d1c73cb5aa41"), "GF", 77 },
                    { new Guid("83132b8f-aaf8-4586-9f55-8e97c1c8ffec"), "GQ", 68 },
                    { new Guid("58d5df86-0dd1-4d35-ba52-650e37a9ce69"), "TF", 79 },
                    { new Guid("56015486-2a19-47ba-aba3-ee8510c2f51f"), "GA", 80 },
                    { new Guid("6d683a54-e47c-4e13-be7b-6c3c4e6e3e8b"), "GM", 81 },
                    { new Guid("f161e5ae-53b6-4cb6-b156-ebcf9c7b68c1"), "GE", 82 }
                });

            migrationBuilder.InsertData(
                table: "CountryCodeType",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("040825c4-364f-48c7-bc99-e0869b21ea2b"), "DE", 83 },
                    { new Guid("b1ad9148-509f-421d-a6ae-1e58e74ba8fb"), "GH", 84 },
                    { new Guid("4a1b13e4-90b5-439b-8e08-bd91dedf31a8"), "GI", 85 },
                    { new Guid("88062106-508c-4647-8b32-25f310f78da6"), "GR", 86 },
                    { new Guid("ffc328d8-94ba-400e-970d-28f2c205293b"), "PF", 78 },
                    { new Guid("ed6ecf1f-6f75-427c-95be-5898414c3808"), "GL", 87 },
                    { new Guid("f7eb59aa-4559-45c8-8d17-65233477f66d"), "GD", 88 },
                    { new Guid("e78cd924-bb7f-41e1-8cfd-5fa4a83eb442"), "GP", 89 },
                    { new Guid("e1c9256c-bd50-4904-88fc-693a92845a57"), "GU", 90 },
                    { new Guid("a2ea9a5b-1230-4a68-88e7-58f3fd741bf6"), "GT", 91 }
                });

            migrationBuilder.InsertData(
                table: "MachineDimensionsType",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("7ed8b1da-76b4-4df3-b855-3098084329ba"), "THREE_PLUS_TWO_AXIS", 1 },
                    { new Guid("cf8646b4-4ecc-400d-8ca7-43354c400e34"), "FIVE_AXIS", 2 },
                    { new Guid("d06bf4d7-0c13-4e54-9dbc-29a71bd3566c"), "THREE_AXIS", 0 }
                });

            migrationBuilder.InsertData(
                table: "MillingMachineDimensionsType",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("a7e598dc-6225-4db3-bd2b-46822d2b11dd"), "FIVE_AXIS", 2 },
                    { new Guid("1cf9aa5d-64c1-4332-b4c8-97b91315723b"), "THREE_PLUS_TWO_AXIS", 1 },
                    { new Guid("b6058ea0-2c0e-4beb-9bc0-bbc64e1ea742"), "THREE_AXIS", 0 }
                });

            migrationBuilder.InsertData(
                table: "MillingMachineType",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("c8fb70dd-0328-4dac-bde3-d0f4c7f39dc0"), "TYPE_1", 0 },
                    { new Guid("b9a8edbb-6ca8-45a1-b7a5-c721f29ab9ed"), "TYPE_2", 1 },
                    { new Guid("0981aff6-3416-4537-867f-6c621ecd430b"), "TYPE_3", 2 },
                    { new Guid("0842591e-6e18-47e4-9a8c-e2665aeea558"), "TYPE_4", 3 }
                });

            migrationBuilder.InsertData(
                table: "OtherTechnology",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("29f26969-90b3-4001-9dee-5aac967c9f36"), "Other", 8 },
                    { new Guid("6b9d9c37-fd40-4f2e-a157-53867298b90e"), "Annealing", 7 },
                    { new Guid("c8725c85-e9bc-414e-85b7-68194ca6476c"), "Knurling", 6 },
                    { new Guid("5dea6de7-cb25-49ee-bd13-4ff64e1beb98"), "Toothings", 3 },
                    { new Guid("f90c523e-9d77-44c1-a85d-6d4de47519ab"), "Engravings", 4 },
                    { new Guid("b7841423-e53e-4941-bd86-2ac869fd34fd"), "ThreadsTr", 2 },
                    { new Guid("d1c1681e-b8c4-4045-b29f-ce466e599798"), "ThreadsM", 1 },
                    { new Guid("a13cd35a-95cb-462b-8ac7-81e8705f547b"), "DeepHoleDrilling", 0 },
                    { new Guid("46d90eb7-53b4-43b0-b6a8-f712b5e00aed"), "LaserMarking", 5 }
                });

            migrationBuilder.InsertData(
                table: "TurningMachineType",
                columns: new[] { "Id", "Name", "Value" },
                values: new object[,]
                {
                    { new Guid("67b10097-cb9f-4fe2-aeb5-d93420e805a7"), "TURNING_MACHINE_TYPE_3", 2 },
                    { new Guid("91832b1e-615b-4dc2-b5a4-a398e732bee4"), "TURNING_MACHINE_TYPE_4", 3 },
                    { new Guid("771fc31a-b10d-4f29-8afc-c55a2e31cd8b"), "TURNING_MACHINE_TYPE_1", 0 },
                    { new Guid("9b9111a4-cab6-4521-88c5-083288bd1774"), "TURNING_MACHINE_TYPE_2", 1 },
                    { new Guid("23884dbd-9f04-4348-9191-b266096da30e"), "TURNING_MACHINE_TYPE_5", 4 }
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
                name: "CountryCodeType");

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
                name: "CompanySizeTypes");
        }
    }
}
