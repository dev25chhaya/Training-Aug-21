using Microsoft.EntityFrameworkCore.Migrations;

namespace assignment.Migrations
{
    public partial class updateDoctor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    deptId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    deptName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("departmentId_PK", x => x.deptId);
                });

            migrationBuilder.CreateTable(
                name: "drugs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Timing = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drugs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "doctor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doctor", x => x.Id);
                    table.ForeignKey(
                        name: "doctor_departmentid_FK",
                        column: x => x.DepartmentID,
                        principalTable: "departments",
                        principalColumn: "deptId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "healthcareAss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_healthcareAss", x => x.Id);
                    table.ForeignKey(
                        name: "healthcareAss_departmentid_FK",
                        column: x => x.DepartmentID,
                        principalTable: "departments",
                        principalColumn: "deptId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "patient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: true),
                    AssistanceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patient", x => x.Id);
                    table.ForeignKey(
                        name: "patient_assistanceid_FK",
                        column: x => x.AssistanceId,
                        principalTable: "healthcareAss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "patient_departmentid_FK",
                        column: x => x.DepartmentID,
                        principalTable: "departments",
                        principalColumn: "deptId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "drugSchedual",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DrugId = table.Column<int>(type: "int", nullable: true),
                    PatientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drugSchedual", x => x.Id);
                    table.ForeignKey(
                        name: "drugSchedual_drugid_FK",
                        column: x => x.DrugId,
                        principalTable: "drugs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "drugSchedual_patientid_FK",
                        column: x => x.PatientId,
                        principalTable: "patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "treatment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorId = table.Column<int>(type: "int", nullable: true),
                    PatientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_treatment", x => x.Id);
                    table.ForeignKey(
                        name: "treatment_doctorid_FK",
                        column: x => x.DoctorId,
                        principalTable: "doctor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "treatment_patientid_FK",
                        column: x => x.PatientId,
                        principalTable: "patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_doctor_DepartmentID",
                table: "doctor",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_drugSchedual_DrugId",
                table: "drugSchedual",
                column: "DrugId");

            migrationBuilder.CreateIndex(
                name: "IX_drugSchedual_PatientId",
                table: "drugSchedual",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_healthcareAss_DepartmentID",
                table: "healthcareAss",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_patient_AssistanceId",
                table: "patient",
                column: "AssistanceId");

            migrationBuilder.CreateIndex(
                name: "IX_patient_DepartmentID",
                table: "patient",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_treatment_DoctorId",
                table: "treatment",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_treatment_PatientId",
                table: "treatment",
                column: "PatientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "drugSchedual");

            migrationBuilder.DropTable(
                name: "treatment");

            migrationBuilder.DropTable(
                name: "drugs");

            migrationBuilder.DropTable(
                name: "doctor");

            migrationBuilder.DropTable(
                name: "patient");

            migrationBuilder.DropTable(
                name: "healthcareAss");

            migrationBuilder.DropTable(
                name: "departments");
        }
    }
}
