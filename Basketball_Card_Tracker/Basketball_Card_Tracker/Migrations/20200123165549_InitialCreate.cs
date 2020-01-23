using Microsoft.EntityFrameworkCore.Migrations;

namespace Basketball_Card_Tracker.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ForTradeCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Insert = table.Column<string>(nullable: true),
                    Serial = table.Column<string>(nullable: true),
                    Player = table.Column<string>(nullable: true),
                    Parallel = table.Column<string>(nullable: true),
                    Numbered = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForTradeCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MissingCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Insert = table.Column<string>(nullable: true),
                    Serial = table.Column<string>(nullable: true),
                    Player = table.Column<string>(nullable: true),
                    Parallel = table.Column<string>(nullable: true),
                    Numbered = table.Column<int>(nullable: false),
                    Seller = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MissingCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NumberedCards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Insert = table.Column<string>(nullable: true),
                    Serial = table.Column<string>(nullable: true),
                    Player = table.Column<string>(nullable: true),
                    Parallel = table.Column<string>(nullable: true),
                    Numbered = table.Column<int>(nullable: false),
                    Seller = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NumberedCards", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ForTradeCards");

            migrationBuilder.DropTable(
                name: "MissingCards");

            migrationBuilder.DropTable(
                name: "NumberedCards");
        }
    }
}
