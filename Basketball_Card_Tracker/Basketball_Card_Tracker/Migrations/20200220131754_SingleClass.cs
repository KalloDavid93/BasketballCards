using Microsoft.EntityFrameworkCore.Migrations;

namespace Basketball_Card_Tracker.Migrations
{
    public partial class SingleClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Insert = table.Column<string>(nullable: true),
                    Player = table.Column<string>(nullable: true),
                    Serial = table.Column<string>(nullable: true),
                    Parallel = table.Column<string>(nullable: true),
                    Numbered = table.Column<int>(nullable: false),
                    Seller = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");
        }
    }
}
