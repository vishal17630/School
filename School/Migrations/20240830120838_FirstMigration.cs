using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentsDate",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(name: "Student Name", type: "Varchar(80)", nullable: false),
                    Standard = table.Column<string>(type: "Varchar(5)", nullable: false),
                    Medium = table.Column<string>(type: "Varchar(12)", nullable: false),
                    Mobile = table.Column<string>(type: "Varchar(12)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsDate", x => x.StudentId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentsDate");
        }
    }
}
