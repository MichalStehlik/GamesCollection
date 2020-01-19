using Microsoft.EntityFrameworkCore.Migrations;

namespace GamesCollection.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Website = table.Column<string>(nullable: false),
                    CountryCode = table.Column<string>(nullable: false),
                    ParentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_Companies_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    YouTubeChannel = table.Column<string>(nullable: true),
                    DeveloperId = table.Column<int>(nullable: false),
                    PublisherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_Companies_DeveloperId",
                        column: x => x.DeveloperId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Games_Companies_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GameGenres",
                columns: table => new
                {
                    GameId = table.Column<int>(nullable: false),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameGenres", x => new { x.GameId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_GameGenres_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GameGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CountryCode", "Name", "ParentId", "Website" },
                values: new object[,]
                {
                    { 1, "US", "Take Two Interactive", null, "https://take2games.com" },
                    { 27, "US", "Steam", null, "https://www.steampowered.com/" },
                    { 25, "CZ", "Beat Games", 25, "http://www.beatgames/" },
                    { 24, "US", "Facebook", null, "http://www.facebook.com/" },
                    { 21, "GE", "Deep Silver", null, "https://www.deepsilver.com/" },
                    { 19, "FR", "Focus Home Interactive", null, "http://focus-home.com/" },
                    { 22, "CZ", "Bohemia Interactive Studio", null, "http://www.bohemia.net/" },
                    { 11, "FR", "UbiSoft", null, "https://ubisoft.com/" },
                    { 6, "US", "ZeniMax Media", null, "https://zenimax.com/" },
                    { 4, "US", "Electronic Arts", null, "https://ea.com/" },
                    { 3, "PL", "CD Projekt", null, "https://cdprojekt.com/" },
                    { 2, "US", "Xbox Game Studios", null, "https://xbox.com/en-US/xbox-game-studios/" },
                    { 17, "SE", "Paradox Interactive", null, "https://www.paradoxplaza.com/" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 9, "Strategy" },
                    { 14, "Stealth" },
                    { 13, "Sports" },
                    { 12, "Survival" },
                    { 11, "Real time Strategy" },
                    { 10, "Turn-based Strategy" },
                    { 8, "Simulator" },
                    { 2, "Adventure" },
                    { 6, "Puzzle" },
                    { 5, "Indie" },
                    { 4, "Platform" },
                    { 3, "Shooter" },
                    { 15, "Multiplayer" },
                    { 1, "Role-playing" },
                    { 7, "Adventure" },
                    { 16, "Massive Multiplayer" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CountryCode", "Name", "ParentId", "Website" },
                values: new object[,]
                {
                    { 13, "US", "2K Games", 1, "https://2k.com" },
                    { 14, "US", "Rockstar Games", 1, "https://rockstargames.com" },
                    { 16, "US", "Obsidian Entertainment", 2, "https://www.firaxis.com/" },
                    { 5, "US", "BioWare", 3, "https://bioware.com/" },
                    { 26, "PL", "CD Projekt RED", 3, "https://en.cdprojektred.com/" },
                    { 7, "FR", "Arkane Studios", 6, "https://arkane-studios.com/" },
                    { 8, "US", "Bethesda Softworks", 6, "https://bethesda.com/" },
                    { 9, "US", "id Software", 6, "https://idsoftware.com/" },
                    { 10, "US", "ZeniMax Online Studios", 6, "https://zenimaxonline.com/" },
                    { 12, "CA", "UbiSoft Montreal", 11, "https://montreal.ubisoft.com/" },
                    { 18, "US", "Hardsuit Labs", 17, "https://www.hardsuitlabs.com/" },
                    { 20, "FR", "Asobo Studio", 19, "http://www.asobostudio.com/" },
                    { 23, "CZ", "Warhorse Studios", 21, "http://www.warhorsestudios.cz/" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "DeveloperId", "Name", "PublisherId", "Website", "YouTubeChannel" },
                values: new object[] { 2, "<p>DayZ is a survival video game developed and published by Bohemia Interactive. It is the standalone successor of the mod of the same name. Following a five-year long early access period for Windows, the game was officially released in December 2018, and was released for the Xbox One and PlayStation 4 in 2019.</p>", 22, "DayZ", 22, "https://www.bohemia.net/games/dayz", "https://www.youtube.com/user/BohemiaInteract" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CountryCode", "Name", "ParentId", "Website" },
                values: new object[] { 15, "US", "Firaxis Games", 13, "https://www.firaxis.com/" });

            migrationBuilder.InsertData(
                table: "GameGenres",
                columns: new[] { "GameId", "GenreId" },
                values: new object[,]
                {
                    { 2, 12 },
                    { 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "DeveloperId", "Name", "PublisherId", "Website", "YouTubeChannel" },
                values: new object[] { 1, "<p>In Cyberpunk 2077 you play as V — a hired gun on the rise — and you just got your first serious contract. In a world of cyberenhanced street warriors, tech-savvy netrunners and corporate lifehackers, today you take your first step towards becoming an urban legend.</p>", 26, "Cyberpunk 2077", 3, "https://www.cyberpunk.net/", "https://www.youtube.com/user/CyberPunkGame" });

            migrationBuilder.InsertData(
                table: "GameGenres",
                columns: new[] { "GameId", "GenreId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "GameGenres",
                columns: new[] { "GameId", "GenreId" },
                values: new object[] { 1, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ParentId",
                table: "Companies",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_GameGenres_GenreId",
                table: "GameGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_DeveloperId",
                table: "Games",
                column: "DeveloperId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_PublisherId",
                table: "Games",
                column: "PublisherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameGenres");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
