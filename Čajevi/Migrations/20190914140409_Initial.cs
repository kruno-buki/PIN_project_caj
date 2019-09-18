using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Čajevi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Biljni",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ime = table.Column<string>(nullable: false),
                    podrijetlo = table.Column<string>(nullable: false),
                    vrsta = table.Column<string>(nullable: false),
                    godina = table.Column<int>(nullable: false),
                    kilaza = table.Column<float>(nullable: false),
                    komada = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biljni", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Premium",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ime = table.Column<string>(nullable: false),
                    podrijetlo = table.Column<string>(nullable: false),
                    vrsta = table.Column<string>(nullable: false),
                    godina = table.Column<int>(nullable: false),
                    kilaza = table.Column<float>(nullable: false),
                    komada = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Premium", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SpecialEdition",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ime = table.Column<string>(nullable: false),
                    podrijetlo = table.Column<string>(nullable: false),
                    vrsta = table.Column<string>(nullable: false),
                    godina = table.Column<int>(nullable: false),
                    kilaza = table.Column<float>(nullable: false),
                    komada = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialEdition", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Voćni",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ime = table.Column<string>(nullable: false),
                    podrijetlo = table.Column<string>(nullable: false),
                    vrsta = table.Column<string>(nullable: false),
                    godina = table.Column<int>(nullable: false),
                    kilaza = table.Column<float>(nullable: false),
                    komada = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voćni", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Biljni");

            migrationBuilder.DropTable(
                name: "Premium");

            migrationBuilder.DropTable(
                name: "SpecialEdition");

            migrationBuilder.DropTable(
                name: "Voćni");
        }
    }
}
