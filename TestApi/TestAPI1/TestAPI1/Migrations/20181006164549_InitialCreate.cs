using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestAPI1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clans",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Bane = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Disciplines",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Flavor = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CharacteristicsDescription = table.Column<string>(nullable: true),
                    CharacteristicsType = table.Column<int>(nullable: false),
                    CharacteristicsThreat = table.Column<string>(nullable: true),
                    CharacteristicsResonance = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lexicons",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Adjective = table.Column<int>(nullable: true),
                    Definition = table.Column<string>(nullable: true),
                    See1 = table.Column<string>(nullable: true),
                    See2 = table.Column<string>(nullable: true),
                    See3 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lexicons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SourceBook",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Publisher = table.Column<string>(nullable: true),
                    BuyLink = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SourceBook", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Archetypes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ClanId = table.Column<int>(nullable: false),
                    ClanId1 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Archetypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Archetypes_Clans_ClanId1",
                        column: x => x.ClanId1,
                        principalTable: "Clans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClanDisciplines",
                columns: table => new
                {
                    ClanId = table.Column<int>(nullable: false),
                    ClanId1 = table.Column<long>(nullable: true),
                    DisciplineId = table.Column<int>(nullable: false),
                    DisciplineId1 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClanDisciplines", x => new { x.ClanId, x.DisciplineId });
                    table.ForeignKey(
                        name: "FK_ClanDisciplines_Clans_ClanId1",
                        column: x => x.ClanId1,
                        principalTable: "Clans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClanDisciplines_Disciplines_DisciplineId1",
                        column: x => x.DisciplineId1,
                        principalTable: "Disciplines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DisciplineNicknames",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    DisciplineId = table.Column<int>(nullable: false),
                    DisciplineId1 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisciplineNicknames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DisciplineNicknames_Disciplines_DisciplineId1",
                        column: x => x.DisciplineId1,
                        principalTable: "Disciplines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DisciplinePowers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DicePool = table.Column<string>(nullable: true),
                    Cost = table.Column<string>(nullable: true),
                    System = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    Level = table.Column<int>(nullable: false),
                    DisciplineId = table.Column<int>(nullable: false),
                    DisciplineId1 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisciplinePowers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DisciplinePowers_Disciplines_DisciplineId1",
                        column: x => x.DisciplineId1,
                        principalTable: "Disciplines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClanFlavor",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Flavor = table.Column<string>(nullable: true),
                    SourceId = table.Column<long>(nullable: true),
                    ClanId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClanFlavor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClanFlavor_Clans_ClanId",
                        column: x => x.ClanId,
                        principalTable: "Clans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClanFlavor_SourceBook_SourceId",
                        column: x => x.SourceId,
                        principalTable: "SourceBook",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Archetypes_ClanId1",
                table: "Archetypes",
                column: "ClanId1");

            migrationBuilder.CreateIndex(
                name: "IX_ClanDisciplines_ClanId1",
                table: "ClanDisciplines",
                column: "ClanId1");

            migrationBuilder.CreateIndex(
                name: "IX_ClanDisciplines_DisciplineId1",
                table: "ClanDisciplines",
                column: "DisciplineId1");

            migrationBuilder.CreateIndex(
                name: "IX_ClanFlavor_ClanId",
                table: "ClanFlavor",
                column: "ClanId");

            migrationBuilder.CreateIndex(
                name: "IX_ClanFlavor_SourceId",
                table: "ClanFlavor",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_DisciplineNicknames_DisciplineId1",
                table: "DisciplineNicknames",
                column: "DisciplineId1");

            migrationBuilder.CreateIndex(
                name: "IX_DisciplinePowers_DisciplineId1",
                table: "DisciplinePowers",
                column: "DisciplineId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Archetypes");

            migrationBuilder.DropTable(
                name: "ClanDisciplines");

            migrationBuilder.DropTable(
                name: "ClanFlavor");

            migrationBuilder.DropTable(
                name: "DisciplineNicknames");

            migrationBuilder.DropTable(
                name: "DisciplinePowers");

            migrationBuilder.DropTable(
                name: "Lexicons");

            migrationBuilder.DropTable(
                name: "Clans");

            migrationBuilder.DropTable(
                name: "SourceBook");

            migrationBuilder.DropTable(
                name: "Disciplines");
        }
    }
}
