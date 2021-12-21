﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EMployeeID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitizenshipId = table.Column<int>(type: "int", nullable: false),
                    CitizenshipLegislationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitizenshipStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitizenshipToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorrespondenceLanguage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DriversLicenseExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DriversLicenseId = table.Column<int>(type: "int", nullable: false),
                    DriversLicenseIssuingCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EffectiveStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ethnicity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HomeFaxAreaCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeFaxCountryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeFaxExtension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeFaxLegislationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeFaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomePhoneAreaCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomePhoneCountryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomePhoneExtension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomePhoneLegislationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Honors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LegalEntityId = table.Column<int>(type: "int", nullable: false),
                    LicenseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MilitaryVetStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameSuffix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalIdCountry = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EMployeeID);
                });

            migrationBuilder.CreateTable(
                name: "Assignment",
                columns: table => new
                {
                    AssignmentID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeRefId = table.Column<long>(type: "bigint", nullable: false),
                    ActionCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActionReasonCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActualTerminationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AssignmentCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssignmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssignmentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssignmentProjectedEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AssignmentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssignmentStatusTypeId = table.Column<long>(type: "bigint", nullable: false),
                    BusinessUnitId = table.Column<long>(type: "bigint", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DefaultExpenseAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentId = table.Column<long>(type: "bigint", nullable: false),
                    EffectiveEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EffectiveStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Frequency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullPartTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GradeId = table.Column<long>(type: "bigint", nullable: false),
                    GradeLadderId = table.Column<long>(type: "bigint", nullable: false),
                    JobId = table.Column<long>(type: "bigint", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LegalEntityId = table.Column<long>(type: "bigint", nullable: false),
                    LocationId = table.Column<long>(type: "bigint", nullable: false),
                    ManagerAssignmentId = table.Column<long>(type: "bigint", nullable: false),
                    ManagerId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignment", x => x.AssignmentID);
                    table.ForeignKey(
                        name: "FK_Assignment_Employees_EmployeeRefId",
                        column: x => x.EmployeeRefId,
                        principalTable: "Employees",
                        principalColumn: "EMployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_EmployeeRefId",
                table: "Assignment",
                column: "EmployeeRefId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assignment");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
