using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UE_GPA.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentMarks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marks1 = table.Column<int>(type: "int", nullable: false),
                    Subject2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marks2 = table.Column<int>(type: "int", nullable: false),
                    Subject3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marks3 = table.Column<int>(type: "int", nullable: false),
                    Subject4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marks4 = table.Column<int>(type: "int", nullable: false),
                    Subject5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marks5 = table.Column<int>(type: "int", nullable: false),
                    GPA = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentMarks", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentMarks");
        }
    }
}
