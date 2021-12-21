using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment.Migrations
{
    public partial class table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assignment");

            migrationBuilder.CreateTable(
                name: "Assignments",
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
                    table.PrimaryKey("PK_Assignments", x => x.AssignmentID);
                    table.ForeignKey(
                        name: "FK_Assignments_Employees_EmployeeRefId",
                        column: x => x.EmployeeRefId,
                        principalTable: "Employees",
                        principalColumn: "EMployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_EmployeeRefId",
                table: "Assignments",
                column: "EmployeeRefId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.CreateTable(
                name: "Assignment",
                columns: table => new
                {
                    AssignmentID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    EmployeeRefId = table.Column<long>(type: "bigint", nullable: false),
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
    }
}
