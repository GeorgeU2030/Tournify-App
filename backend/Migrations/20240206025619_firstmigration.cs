using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class firstmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    DriverId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NameDriver = table.Column<string>(type: "text", nullable: true),
                    Photo = table.Column<string>(type: "text", nullable: true),
                    Points = table.Column<int>(type: "integer", nullable: true),
                    RacingTeam = table.Column<string>(type: "text", nullable: true),
                    LogoTeam = table.Column<string>(type: "text", nullable: true),
                    Titles = table.Column<int>(type: "integer", nullable: true),
                    Country = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.DriverId);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nameplayer = table.Column<string>(type: "text", nullable: true),
                    Photo = table.Column<string>(type: "text", nullable: true),
                    Points = table.Column<int>(type: "integer", nullable: true),
                    Genre = table.Column<string>(type: "text", nullable: true),
                    Wimbledon = table.Column<int>(type: "integer", nullable: true),
                    AustralianOpen = table.Column<int>(type: "integer", nullable: true),
                    RolandGarros = table.Column<int>(type: "integer", nullable: true),
                    UsOpen = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerId);
                });

            migrationBuilder.CreateTable(
                name: "Seasonraces",
                columns: table => new
                {
                    SeasonraceId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Edition = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasonraces", x => x.SeasonraceId);
                });

            migrationBuilder.CreateTable(
                name: "Tournaments",
                columns: table => new
                {
                    TournamentId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NameTournament = table.Column<string>(type: "text", nullable: true),
                    Logo = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournaments", x => x.TournamentId);
                });

            migrationBuilder.CreateTable(
                name: "Winraces",
                columns: table => new
                {
                    WinraceId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Namerace = table.Column<string>(type: "text", nullable: true),
                    DriverId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Winraces", x => x.WinraceId);
                    table.ForeignKey(
                        name: "FK_Winraces_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "DriverId");
                });

            migrationBuilder.CreateTable(
                name: "DriverSeasons",
                columns: table => new
                {
                    DriverSeasonId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NameDriverseason = table.Column<string>(type: "text", nullable: true),
                    Photo = table.Column<string>(type: "text", nullable: true),
                    RacingTeam = table.Column<string>(type: "text", nullable: true),
                    LogoTeam = table.Column<string>(type: "text", nullable: true),
                    Seasonpoints = table.Column<int>(type: "integer", nullable: true),
                    Seasonwins = table.Column<int>(type: "integer", nullable: true),
                    SeasonraceId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverSeasons", x => x.DriverSeasonId);
                    table.ForeignKey(
                        name: "FK_DriverSeasons_Seasonraces_SeasonraceId",
                        column: x => x.SeasonraceId,
                        principalTable: "Seasonraces",
                        principalColumn: "SeasonraceId");
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    RaceId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Namerace = table.Column<string>(type: "text", nullable: true),
                    Logorace = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<string>(type: "text", nullable: true),
                    SeasonraceId = table.Column<int>(type: "integer", nullable: true),
                    WinnerDriverSeasonId = table.Column<int>(type: "integer", nullable: true),
                    SecondDriverSeasonId = table.Column<int>(type: "integer", nullable: true),
                    ThirdDriverSeasonId = table.Column<int>(type: "integer", nullable: true),
                    FourthDriverSeasonId = table.Column<int>(type: "integer", nullable: true),
                    FifthDriverSeasonId = table.Column<int>(type: "integer", nullable: true),
                    SixthDriverSeasonId = table.Column<int>(type: "integer", nullable: true),
                    SeventhDriverSeasonId = table.Column<int>(type: "integer", nullable: true),
                    EighthDriverSeasonId = table.Column<int>(type: "integer", nullable: true),
                    NinthDriverSeasonId = table.Column<int>(type: "integer", nullable: true),
                    TenthDriverSeasonId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.RaceId);
                    table.ForeignKey(
                        name: "FK_Races_DriverSeasons_EighthDriverSeasonId",
                        column: x => x.EighthDriverSeasonId,
                        principalTable: "DriverSeasons",
                        principalColumn: "DriverSeasonId");
                    table.ForeignKey(
                        name: "FK_Races_DriverSeasons_FifthDriverSeasonId",
                        column: x => x.FifthDriverSeasonId,
                        principalTable: "DriverSeasons",
                        principalColumn: "DriverSeasonId");
                    table.ForeignKey(
                        name: "FK_Races_DriverSeasons_FourthDriverSeasonId",
                        column: x => x.FourthDriverSeasonId,
                        principalTable: "DriverSeasons",
                        principalColumn: "DriverSeasonId");
                    table.ForeignKey(
                        name: "FK_Races_DriverSeasons_NinthDriverSeasonId",
                        column: x => x.NinthDriverSeasonId,
                        principalTable: "DriverSeasons",
                        principalColumn: "DriverSeasonId");
                    table.ForeignKey(
                        name: "FK_Races_DriverSeasons_SecondDriverSeasonId",
                        column: x => x.SecondDriverSeasonId,
                        principalTable: "DriverSeasons",
                        principalColumn: "DriverSeasonId");
                    table.ForeignKey(
                        name: "FK_Races_DriverSeasons_SeventhDriverSeasonId",
                        column: x => x.SeventhDriverSeasonId,
                        principalTable: "DriverSeasons",
                        principalColumn: "DriverSeasonId");
                    table.ForeignKey(
                        name: "FK_Races_DriverSeasons_SixthDriverSeasonId",
                        column: x => x.SixthDriverSeasonId,
                        principalTable: "DriverSeasons",
                        principalColumn: "DriverSeasonId");
                    table.ForeignKey(
                        name: "FK_Races_DriverSeasons_TenthDriverSeasonId",
                        column: x => x.TenthDriverSeasonId,
                        principalTable: "DriverSeasons",
                        principalColumn: "DriverSeasonId");
                    table.ForeignKey(
                        name: "FK_Races_DriverSeasons_ThirdDriverSeasonId",
                        column: x => x.ThirdDriverSeasonId,
                        principalTable: "DriverSeasons",
                        principalColumn: "DriverSeasonId");
                    table.ForeignKey(
                        name: "FK_Races_DriverSeasons_WinnerDriverSeasonId",
                        column: x => x.WinnerDriverSeasonId,
                        principalTable: "DriverSeasons",
                        principalColumn: "DriverSeasonId");
                    table.ForeignKey(
                        name: "FK_Races_Seasonraces_SeasonraceId",
                        column: x => x.SeasonraceId,
                        principalTable: "Seasonraces",
                        principalColumn: "SeasonraceId");
                });

            migrationBuilder.CreateTable(
                name: "SeasonTeams",
                columns: table => new
                {
                    SeasonTeamId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SeasonId = table.Column<int>(type: "integer", nullable: false),
                    Nameseasonteam = table.Column<string>(type: "text", nullable: true),
                    Logost = table.Column<string>(type: "text", nullable: true),
                    Win = table.Column<int>(type: "integer", nullable: true),
                    Lose = table.Column<int>(type: "integer", nullable: true),
                    Draw = table.Column<int>(type: "integer", nullable: true),
                    Points = table.Column<int>(type: "integer", nullable: true),
                    Gd = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeasonTeams", x => x.SeasonTeamId);
                });

            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    SeasonId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Edition = table.Column<int>(type: "integer", nullable: true),
                    ChampionTeamId = table.Column<int>(type: "integer", nullable: true),
                    SubChampionTeamId = table.Column<int>(type: "integer", nullable: true),
                    TournamentId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.SeasonId);
                    table.ForeignKey(
                        name: "FK_Seasons_Tournaments_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournaments",
                        principalColumn: "TournamentId");
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NameTeam = table.Column<string>(type: "text", nullable: true),
                    Flag = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<string>(type: "text", nullable: true),
                    Logo = table.Column<string>(type: "text", nullable: true),
                    Division = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    SeasonId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamId);
                    table.ForeignKey(
                        name: "FK_Teams_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "SeasonId");
                });

            migrationBuilder.CreateTable(
                name: "Trophies",
                columns: table => new
                {
                    TrophyId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NameTrophy = table.Column<string>(type: "text", nullable: true),
                    TeamId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trophies", x => x.TrophyId);
                    table.ForeignKey(
                        name: "FK_Trophies_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DriverSeasons_SeasonraceId",
                table: "DriverSeasons",
                column: "SeasonraceId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_EighthDriverSeasonId",
                table: "Races",
                column: "EighthDriverSeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_FifthDriverSeasonId",
                table: "Races",
                column: "FifthDriverSeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_FourthDriverSeasonId",
                table: "Races",
                column: "FourthDriverSeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_NinthDriverSeasonId",
                table: "Races",
                column: "NinthDriverSeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_SeasonraceId",
                table: "Races",
                column: "SeasonraceId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_SecondDriverSeasonId",
                table: "Races",
                column: "SecondDriverSeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_SeventhDriverSeasonId",
                table: "Races",
                column: "SeventhDriverSeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_SixthDriverSeasonId",
                table: "Races",
                column: "SixthDriverSeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_TenthDriverSeasonId",
                table: "Races",
                column: "TenthDriverSeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_ThirdDriverSeasonId",
                table: "Races",
                column: "ThirdDriverSeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_WinnerDriverSeasonId",
                table: "Races",
                column: "WinnerDriverSeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_SeasonTeams_SeasonId",
                table: "SeasonTeams",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Seasons_ChampionTeamId",
                table: "Seasons",
                column: "ChampionTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Seasons_SubChampionTeamId",
                table: "Seasons",
                column: "SubChampionTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Seasons_TournamentId",
                table: "Seasons",
                column: "TournamentId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_SeasonId",
                table: "Teams",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Trophies_TeamId",
                table: "Trophies",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Winraces_DriverId",
                table: "Winraces",
                column: "DriverId");

            migrationBuilder.AddForeignKey(
                name: "FK_SeasonTeams_Seasons_SeasonId",
                table: "SeasonTeams",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "SeasonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seasons_Teams_ChampionTeamId",
                table: "Seasons",
                column: "ChampionTeamId",
                principalTable: "Teams",
                principalColumn: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seasons_Teams_SubChampionTeamId",
                table: "Seasons",
                column: "SubChampionTeamId",
                principalTable: "Teams",
                principalColumn: "TeamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Seasons_SeasonId",
                table: "Teams");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropTable(
                name: "SeasonTeams");

            migrationBuilder.DropTable(
                name: "Trophies");

            migrationBuilder.DropTable(
                name: "Winraces");

            migrationBuilder.DropTable(
                name: "DriverSeasons");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Seasonraces");

            migrationBuilder.DropTable(
                name: "Seasons");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Tournaments");
        }
    }
}
