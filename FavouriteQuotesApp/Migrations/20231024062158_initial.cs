using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FavouriteQuotesApp.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Author", "Description", "Rating", "Text" },
                values: new object[,]
                {
                    { 1, " Author 1", "Inspiring", 3, "Quote 1" },
                    { 2, " Author 2", "Motivational", 4, "Quote 2" },
                    { 3, " Author 3", "Thought-provoking", 5, "Quote 3" },
                    { 4, " Author 1", "Inspiring", 3, "Quote 4" },
                    { 5, " Author 2", "Motivational", 4, "Quote 5" },
                    { 6, " Author 3", "Thought-provoking", 5, "Quote 6" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quotes");
        }
    }
}
