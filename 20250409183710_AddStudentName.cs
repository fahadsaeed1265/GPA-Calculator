﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UE_GPA.Migrations
{
    /// <inheritdoc />
    public partial class AddStudentName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StudentName",
                table: "StudentMarks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentName",
                table: "StudentMarks");
        }
    }
}
