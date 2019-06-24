using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    ParentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.ParentId);
                });

            migrationBuilder.CreateTable(
                name: "Ailments",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    PatientParentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ailments", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Ailments_Patients_PatientParentId",
                        column: x => x.PatientParentId,
                        principalTable: "Patients",
                        principalColumn: "ParentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Medications",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    Doses = table.Column<string>(nullable: true),
                    PatientParentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medications", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Medications_Patients_PatientParentId",
                        column: x => x.PatientParentId,
                        principalTable: "Patients",
                        principalColumn: "ParentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ailments_PatientParentId",
                table: "Ailments",
                column: "PatientParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Medications_PatientParentId",
                table: "Medications",
                column: "PatientParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ailments");

            migrationBuilder.DropTable(
                name: "Medications");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
