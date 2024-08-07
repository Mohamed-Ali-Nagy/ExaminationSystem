using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExaminationSystem.Migrations
{
    /// <inheritdoc />
    public partial class set_course_examRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Exams");

            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "Exams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExamType",
                table: "Exams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Exams_CourseID",
                table: "Exams",
                column: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Courses_CourseID",
                table: "Exams",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Courses_CourseID",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_Exams_CourseID",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "ExamType",
                table: "Exams");

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Exams",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
