using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthAPI.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ailments_Patients_PatientParentId",
                table: "Ailments");

            migrationBuilder.DropForeignKey(
                name: "FK_Medications_Patients_PatientParentId",
                table: "Medications");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "Patients",
                newName: "PatientId");

            migrationBuilder.RenameColumn(
                name: "PatientParentId",
                table: "Medications",
                newName: "PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_Medications_PatientParentId",
                table: "Medications",
                newName: "IX_Medications_PatientId");

            migrationBuilder.RenameColumn(
                name: "PatientParentId",
                table: "Ailments",
                newName: "PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_Ailments_PatientParentId",
                table: "Ailments",
                newName: "IX_Ailments_PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ailments_Patients_PatientId",
                table: "Ailments",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "PatientId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Medications_Patients_PatientId",
                table: "Medications",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "PatientId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ailments_Patients_PatientId",
                table: "Ailments");

            migrationBuilder.DropForeignKey(
                name: "FK_Medications_Patients_PatientId",
                table: "Medications");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "Patients",
                newName: "ParentId");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "Medications",
                newName: "PatientParentId");

            migrationBuilder.RenameIndex(
                name: "IX_Medications_PatientId",
                table: "Medications",
                newName: "IX_Medications_PatientParentId");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "Ailments",
                newName: "PatientParentId");

            migrationBuilder.RenameIndex(
                name: "IX_Ailments_PatientId",
                table: "Ailments",
                newName: "IX_Ailments_PatientParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ailments_Patients_PatientParentId",
                table: "Ailments",
                column: "PatientParentId",
                principalTable: "Patients",
                principalColumn: "ParentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Medications_Patients_PatientParentId",
                table: "Medications",
                column: "PatientParentId",
                principalTable: "Patients",
                principalColumn: "ParentId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
