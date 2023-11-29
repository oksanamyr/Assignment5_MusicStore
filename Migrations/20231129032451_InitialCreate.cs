using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment5.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Stream = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    MusicOn = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Performer = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Musicians = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Groups = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Year = table.Column<int>(type: "int", maxLength: 60, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventory");
        }
    }
}
