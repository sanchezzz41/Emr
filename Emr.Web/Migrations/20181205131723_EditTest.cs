using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Emr.Web.Migrations
{
    public partial class EditTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Diagnoses",
                columns: table => new
                {
                    DiagnosGuid = table.Column<Guid>(nullable: false),
                    NameDiagnos = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnoses", x => x.DiagnosGuid);
                });

            migrationBuilder.CreateTable(
                name: "Drags",
                columns: table => new
                {
                    DragGuid = table.Column<Guid>(nullable: false),
                    NameDrug = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drags", x => x.DragGuid);
                });

            migrationBuilder.CreateTable(
                name: "Medics",
                columns: table => new
                {
                    MedicGuid = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Surname = table.Column<string>(maxLength: 100, nullable: false),
                    Patronymic = table.Column<string>(maxLength: 100, nullable: false),
                    Snils = table.Column<int>(maxLength: 100, nullable: false),
                    Dob = table.Column<DateTime>(maxLength: 100, nullable: false),
                    Pob = table.Column<string>(maxLength: 100, nullable: false),
                    Age = table.Column<string>(maxLength: 100, nullable: false),
                    Gender = table.Column<string>(maxLength: 100, nullable: false),
                    Passport = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medics", x => x.MedicGuid);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientGuid = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Surname = table.Column<string>(maxLength: 100, nullable: false),
                    Patronymic = table.Column<string>(maxLength: 100, nullable: false),
                    Snils = table.Column<int>(maxLength: 100, nullable: false),
                    Dob = table.Column<DateTime>(maxLength: 100, nullable: false),
                    Pob = table.Column<string>(maxLength: 100, nullable: false),
                    Age = table.Column<string>(maxLength: 100, nullable: false),
                    Gender = table.Column<string>(maxLength: 100, nullable: false),
                    Passport = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientGuid);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    RecipeGuid = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.RecipeGuid);
                });

            migrationBuilder.CreateTable(
                name: "Researches",
                columns: table => new
                {
                    ResearchGuid = table.Column<Guid>(nullable: false),
                    NameResearch = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Researches", x => x.ResearchGuid);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "ElectronicPersonalMedicalRecords",
                columns: table => new
                {
                    EpmrGuid = table.Column<Guid>(nullable: false),
                    PatientGuid = table.Column<Guid>(nullable: false),
                    MedicGuid = table.Column<Guid>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Signing = table.Column<DateTime>(nullable: false),
                    TextEpmr = table.Column<string>(maxLength: 100, nullable: false),
                    FileEpmr = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectronicPersonalMedicalRecords", x => x.EpmrGuid);
                    table.ForeignKey(
                        name: "FK_ElectronicPersonalMedicalRecords_Medics_MedicGuid",
                        column: x => x.MedicGuid,
                        principalTable: "Medics",
                        principalColumn: "MedicGuid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElectronicPersonalMedicalRecords_Patients_PatientGuid",
                        column: x => x.PatientGuid,
                        principalTable: "Patients",
                        principalColumn: "PatientGuid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Metrics",
                columns: table => new
                {
                    MetricGuid = table.Column<Guid>(nullable: false),
                    PatientGuid = table.Column<Guid>(nullable: false),
                    MedicGuid = table.Column<Guid>(nullable: false),
                    WaistCircumference = table.Column<int>(maxLength: 100, nullable: false),
                    BodyTemperature = table.Column<int>(maxLength: 100, nullable: false),
                    RespiratoryRate = table.Column<int>(maxLength: 100, nullable: false),
                    Growth = table.Column<int>(maxLength: 100, nullable: false),
                    Mass = table.Column<int>(maxLength: 100, nullable: false),
                    SystolicPressure = table.Column<int>(maxLength: 100, nullable: false),
                    DiastolicPressure = table.Column<int>(maxLength: 100, nullable: false),
                    Pulse = table.Column<int>(maxLength: 100, nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Metrics", x => x.MetricGuid);
                    table.ForeignKey(
                        name: "FK_Metrics_Medics_MedicGuid",
                        column: x => x.MedicGuid,
                        principalTable: "Medics",
                        principalColumn: "MedicGuid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Metrics_Patients_PatientGuid",
                        column: x => x.PatientGuid,
                        principalTable: "Patients",
                        principalColumn: "PatientGuid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalExaminations",
                columns: table => new
                {
                    MeGuid = table.Column<Guid>(nullable: false),
                    PatientGuid = table.Column<Guid>(nullable: false),
                    MedicGuid = table.Column<Guid>(nullable: false),
                    DiagnosGuid = table.Column<Guid>(nullable: false),
                    RecipeGuid = table.Column<Guid>(nullable: false),
                    InspectionDate = table.Column<DateTime>(nullable: false),
                    Symptom = table.Column<string>(maxLength: 100, nullable: false),
                    Comment = table.Column<string>(maxLength: 100, nullable: false),
                    InspectionResult = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalExaminations", x => x.MeGuid);
                    table.ForeignKey(
                        name: "FK_MedicalExaminations_Diagnoses_DiagnosGuid",
                        column: x => x.DiagnosGuid,
                        principalTable: "Diagnoses",
                        principalColumn: "DiagnosGuid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalExaminations_Medics_MedicGuid",
                        column: x => x.MedicGuid,
                        principalTable: "Medics",
                        principalColumn: "MedicGuid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalExaminations_Patients_PatientGuid",
                        column: x => x.PatientGuid,
                        principalTable: "Patients",
                        principalColumn: "PatientGuid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalExaminations_Recipes_RecipeGuid",
                        column: x => x.RecipeGuid,
                        principalTable: "Recipes",
                        principalColumn: "RecipeGuid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecieptDragses",
                columns: table => new
                {
                    DragGuid = table.Column<Guid>(nullable: false),
                    RecipeGuid = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecieptDragses", x => new { x.DragGuid, x.RecipeGuid });
                    table.ForeignKey(
                        name: "FK_RecieptDragses_Drags_DragGuid",
                        column: x => x.DragGuid,
                        principalTable: "Drags",
                        principalColumn: "DragGuid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecieptDragses_Recipes_RecipeGuid",
                        column: x => x.RecipeGuid,
                        principalTable: "Recipes",
                        principalColumn: "RecipeGuid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserGuid = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    Login = table.Column<string>(maxLength: 200, nullable: false),
                    Password = table.Column<string>(maxLength: 200, nullable: false),
                    BirthDay = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserGuid);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ElectronicPersonalMedicalRecords_MedicGuid",
                table: "ElectronicPersonalMedicalRecords",
                column: "MedicGuid");

            migrationBuilder.CreateIndex(
                name: "IX_ElectronicPersonalMedicalRecords_PatientGuid",
                table: "ElectronicPersonalMedicalRecords",
                column: "PatientGuid");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalExaminations_DiagnosGuid",
                table: "MedicalExaminations",
                column: "DiagnosGuid");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalExaminations_MedicGuid",
                table: "MedicalExaminations",
                column: "MedicGuid");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalExaminations_PatientGuid",
                table: "MedicalExaminations",
                column: "PatientGuid");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalExaminations_RecipeGuid",
                table: "MedicalExaminations",
                column: "RecipeGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Metrics_MedicGuid",
                table: "Metrics",
                column: "MedicGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Metrics_PatientGuid",
                table: "Metrics",
                column: "PatientGuid");

            migrationBuilder.CreateIndex(
                name: "IX_RecieptDragses_RecipeGuid",
                table: "RecieptDragses",
                column: "RecipeGuid");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ElectronicPersonalMedicalRecords");

            migrationBuilder.DropTable(
                name: "MedicalExaminations");

            migrationBuilder.DropTable(
                name: "Metrics");

            migrationBuilder.DropTable(
                name: "RecieptDragses");

            migrationBuilder.DropTable(
                name: "Researches");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Diagnoses");

            migrationBuilder.DropTable(
                name: "Medics");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Drags");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
