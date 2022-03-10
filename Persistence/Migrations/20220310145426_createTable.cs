using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class createTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Diseases",
                columns: table => new
                {
                    DiseaseId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    sideEffect = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    vaccineName = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diseases", x => x.DiseaseId);
                });

            migrationBuilder.CreateTable(
                name: "MinistryAdministrator",
                columns: table => new
                {
                    adminId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    firstName = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    lastName = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    gender = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    email = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    number = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MinistryAdministrator", x => x.adminId);
                });

            migrationBuilder.CreateTable(
                name: "Relatives",
                columns: table => new
                {
                    RelativeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    firstName = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    lastName = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    gender = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    address = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    number = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    email = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relatives", x => x.RelativeId);
                });

            migrationBuilder.CreateTable(
                name: "Vaccine",
                columns: table => new
                {
                    VaccineId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VaccineAge = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true),
                    DateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    VaccineName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    diseasesName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    DoseRoute = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccine", x => x.VaccineId);
                });

            migrationBuilder.CreateTable(
                name: "HealthOffices",
                columns: table => new
                {
                    HealthOfficeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    address = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    email = table.Column<string>(type: "TEXT", maxLength: 30, nullable: true),
                    number = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    MinisrtAdminId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthOffices", x => x.HealthOfficeId);
                    table.ForeignKey(
                        name: "FK_HealthOffices_MinistryAdministrator_MinisrtAdminId",
                        column: x => x.MinisrtAdminId,
                        principalTable: "MinistryAdministrator",
                        principalColumn: "adminId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VaccineCamping",
                columns: table => new
                {
                    VaccineCampingId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VaccineCampingName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    VaccineCampingDescription = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Time = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    adminId = table.Column<int>(type: "INTEGER", nullable: false),
                    MinistryAdministratorsadminId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccineCamping", x => x.VaccineCampingId);
                    table.ForeignKey(
                        name: "FK_VaccineCamping_MinistryAdministrator_MinistryAdministratorsadminId",
                        column: x => x.MinistryAdministratorsadminId,
                        principalTable: "MinistryAdministrator",
                        principalColumn: "adminId");
                });

            migrationBuilder.CreateTable(
                name: "Child",
                columns: table => new
                {
                    ChildId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ChildFirstName = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    ChildMiniName = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    ChildLastName = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    ChildGender = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    ChildBirthDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ChildAddress = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    RelativeId = table.Column<int>(type: "INTEGER", nullable: false),
                    relativesRelativeId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Child", x => x.ChildId);
                    table.ForeignKey(
                        name: "FK_Child_Relatives_relativesRelativeId",
                        column: x => x.relativesRelativeId,
                        principalTable: "Relatives",
                        principalColumn: "RelativeId");
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    DoctorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    firstName = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    lastName = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    gender = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    address = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    number = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    specilization = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    HealthOfficeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.DoctorId);
                    table.ForeignKey(
                        name: "FK_Doctors_HealthOffices_HealthOfficeId",
                        column: x => x.HealthOfficeId,
                        principalTable: "HealthOffices",
                        principalColumn: "HealthOfficeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Checkings",
                columns: table => new
                {
                    ChildId = table.Column<int>(type: "INTEGER", nullable: false),
                    DiseasesId = table.Column<int>(type: "INTEGER", nullable: false),
                    doctorId = table.Column<int>(type: "INTEGER", nullable: false),
                    CheckResultDescription = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    Weight = table.Column<decimal>(type: "TEXT", nullable: false),
                    Height = table.Column<decimal>(type: "TEXT", nullable: false),
                    date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkings", x => new { x.ChildId, x.DiseasesId, x.doctorId });
                    table.ForeignKey(
                        name: "FK_Checkings_Child_ChildId",
                        column: x => x.ChildId,
                        principalTable: "Child",
                        principalColumn: "ChildId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Checkings_Diseases_DiseasesId",
                        column: x => x.DiseasesId,
                        principalTable: "Diseases",
                        principalColumn: "DiseaseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Checkings_Doctors_doctorId",
                        column: x => x.doctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    ChildId = table.Column<int>(type: "INTEGER", nullable: false),
                    doctorId = table.Column<int>(type: "INTEGER", nullable: false),
                    VaccineCampingId = table.Column<int>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => new { x.ChildId, x.VaccineCampingId, x.doctorId });
                    table.ForeignKey(
                        name: "FK_Events_Child_ChildId",
                        column: x => x.ChildId,
                        principalTable: "Child",
                        principalColumn: "ChildId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Events_Doctors_doctorId",
                        column: x => x.doctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Events_VaccineCamping_VaccineCampingId",
                        column: x => x.VaccineCampingId,
                        principalTable: "VaccineCamping",
                        principalColumn: "VaccineCampingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VaccineTranasaction",
                columns: table => new
                {
                    ChildId = table.Column<int>(type: "INTEGER", nullable: false),
                    doctorId = table.Column<int>(type: "INTEGER", nullable: false),
                    VaccineId = table.Column<int>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DueDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccineTranasaction", x => new { x.ChildId, x.VaccineId, x.doctorId });
                    table.ForeignKey(
                        name: "FK_VaccineTranasaction_Child_ChildId",
                        column: x => x.ChildId,
                        principalTable: "Child",
                        principalColumn: "ChildId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VaccineTranasaction_Doctors_doctorId",
                        column: x => x.doctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VaccineTranasaction_Vaccine_VaccineId",
                        column: x => x.VaccineId,
                        principalTable: "Vaccine",
                        principalColumn: "VaccineId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Checkings_DiseasesId",
                table: "Checkings",
                column: "DiseasesId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkings_doctorId",
                table: "Checkings",
                column: "doctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Child_relativesRelativeId",
                table: "Child",
                column: "relativesRelativeId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_HealthOfficeId",
                table: "Doctors",
                column: "HealthOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_doctorId",
                table: "Events",
                column: "doctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_VaccineCampingId",
                table: "Events",
                column: "VaccineCampingId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthOffices_MinisrtAdminId",
                table: "HealthOffices",
                column: "MinisrtAdminId");

            migrationBuilder.CreateIndex(
                name: "IX_VaccineCamping_MinistryAdministratorsadminId",
                table: "VaccineCamping",
                column: "MinistryAdministratorsadminId");

            migrationBuilder.CreateIndex(
                name: "IX_VaccineTranasaction_doctorId",
                table: "VaccineTranasaction",
                column: "doctorId");

            migrationBuilder.CreateIndex(
                name: "IX_VaccineTranasaction_VaccineId",
                table: "VaccineTranasaction",
                column: "VaccineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Checkings");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "VaccineTranasaction");

            migrationBuilder.DropTable(
                name: "Diseases");

            migrationBuilder.DropTable(
                name: "VaccineCamping");

            migrationBuilder.DropTable(
                name: "Child");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Vaccine");

            migrationBuilder.DropTable(
                name: "Relatives");

            migrationBuilder.DropTable(
                name: "HealthOffices");

            migrationBuilder.DropTable(
                name: "MinistryAdministrator");
        }
    }
}
