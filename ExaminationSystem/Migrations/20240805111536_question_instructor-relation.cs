using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExaminationSystem.Migrations
{
    /// <inheritdoc />
    public partial class question_instructorrelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InstructorID",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Questions_InstructorID",
                table: "Questions",
                column: "InstructorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Instructors_InstructorID",
                table: "Questions",
                column: "InstructorID",
                principalTable: "Instructors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Instructors_InstructorID",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_InstructorID",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "InstructorID",
                table: "Questions");
        }
    }
}
