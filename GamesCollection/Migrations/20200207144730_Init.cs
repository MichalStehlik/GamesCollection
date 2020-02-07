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
                    PublisherId = table.Column<int>(nullable: false),
                    GameGenreGameId = table.Column<int>(nullable: true),
                    GameGenreGenreId = table.Column<int>(nullable: true)
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
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    GameGenreGameId = table.Column<int>(nullable: true),
                    GameGenreGenreId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                columns: new[] { "Id", "GameGenreGameId", "GameGenreGenreId", "Name" },
                values: new object[,]
                {
                    { 9, null, null, "Strategy" },
                    { 14, null, null, "Stealth" },
                    { 13, null, null, "Sports" },
                    { 12, null, null, "Survival" },
                    { 11, null, null, "Real time Strategy" },
                    { 10, null, null, "Turn-based Strategy" },
                    { 8, null, null, "Simulator" },
                    { 2, null, null, "Adventure" },
                    { 6, null, null, "Puzzle" },
                    { 5, null, null, "Indie" },
                    { 4, null, null, "Platform" },
                    { 3, null, null, "Shooter" },
                    { 15, null, null, "Multiplayer" },
                    { 1, null, null, "Role-playing" },
                    { 7, null, null, "Adventure" },
                    { 16, null, null, "Massive Multiplayer" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CountryCode", "Name", "ParentId", "Website" },
                values: new object[,]
                {
                    { 13, "US", "2K Games", 1, "https://2k.com" },
                    { 14, "US", "Rockstar Games", 1, "https://rockstargames.com" },
                    { 29, "US", "Private Division", 1, "https://www.privatedivision.com/" },
                    { 16, "US", "Obsidian Entertainment", 2, "https://www.obsidian.net" },
                    { 26, "PL", "CD Projekt RED", 3, "https://en.cdprojektred.com/" },
                    { 5, "US", "BioWare", 4, "https://bioware.com/" },
                    { 7, "FR", "Arkane Studios", 6, "https://arkane-studios.com/" },
                    { 8, "US", "Bethesda Softworks", 6, "https://bethesda.com/" },
                    { 9, "US", "id Software", 6, "https://idsoftware.com/" },
                    { 10, "US", "ZeniMax Online Studios", 6, "https://zenimaxonline.com/" },
                    { 12, "CA", "UbiSoft Montreal", 11, "https://montreal.ubisoft.com/" },
                    { 28, "CA", "UbiSoft Québec", 11, "https://quebec.ubisoft.com/" },
                    { 18, "US", "Hardsuit Labs", 17, "https://www.hardsuitlabs.com/" },
                    { 20, "FR", "Asobo Studio", 19, "http://www.asobostudio.com/" },
                    { 23, "CZ", "Warhorse Studios", 21, "http://www.warhorsestudios.cz/" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "DeveloperId", "GameGenreGameId", "GameGenreGenreId", "Name", "PublisherId", "Website", "YouTubeChannel" },
                values: new object[] { 2, "<p>DayZ is a survival video game developed and published by Bohemia Interactive. It is the standalone successor of the mod of the same name. Following a five-year long early access period for Windows, the game was officially released in December 2018, and was released for the Xbox One and PlayStation 4 in 2019.</p>", 22, null, null, "DayZ", 22, "https://www.bohemia.net/games/dayz", "https://www.youtube.com/user/BohemiaInteract" });

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
                columns: new[] { "Id", "Description", "DeveloperId", "GameGenreGameId", "GameGenreGenreId", "Name", "PublisherId", "Website", "YouTubeChannel" },
                values: new object[,]
                {
                    { 5, "<p>In The Outer Worlds, you awake from hibernation on a colonist ship that was lost in transit to Halcyon, the furthest colony from Earth located at the edge of the galaxy, only to find yourself in the midst of a deep conspiracy threatening to destroy it. As you explore the furthest reaches of space and encounter various factions, all vying for power, the character you decide to become will determine how this player-driven story unfolds. In the corporate equation for the colony, you are the unplanned variable.</p>", 16, null, null, "The Outer Worlds", 29, "https://outerworlds.obsidian.net/en", null },
                    { 1, "<p>In Cyberpunk 2077 you play as V — a hired gun on the rise — and you just got your first serious contract. In a world of cyberenhanced street warriors, tech-savvy netrunners and corporate lifehackers, today you take your first step towards becoming an urban legend.</p>", 26, null, null, "Cyberpunk 2077", 3, "https://www.cyberpunk.net/", "https://www.youtube.com/user/CyberPunkGame" },
                    { 9, "<p>The Witcher: Wild Hunt is a story-driven, next-generation open world role-playing game set in a visually stunning fantasy universe full of meaningful choices and impactful consequences. In The Witcher you play as the professional monster hunter, Geralt of Rivia, tasked with finding a child of prophecy in a vast open world rich with merchant cities, viking pirate islands, dangerous mountain passes, and forgotten caverns to explore.</p>", 26, null, null, "The Witcher 3: Wild Hunt", 3, "https://dishonored.bethesda.net/", "https://www.youtube.com/user/WitcherGame" },
                    { 7, "<p>Dishonored is an immersive first-person action game that casts you as a supernatural assassin driven by revenge. With Dishonored’s flexible combat system, creatively eliminate your targets as you combine the supernatural abilities, weapons and unusual gadgets at your disposal. Pursue your enemies under the cover of darkness or ruthlessly attack them head on with weapons drawn. The outcome of each mission plays out based on the choices you make.</p>", 7, null, null, "Dishonored", 8, "https://dishonored.bethesda.net/", null },
                    { 8, "<p>Reprise your role as a supernatural assassin in Dishonored 2. Play your way in a world where mysticism and industry collide. Will you choose to play as Empress Emily Kaldwin or the Royal Protector, Corvo Attano? Will you stalk your way through the game unseen, make full use of its brutal combat system, or use a blend of both? How will you combine your character’s unique set of powers, weapons and gadgets to eliminate your enemies? The story responds to your choices, leading to intriguing outcomes, as you play through each of the game’s hand-crafted missions.</p>", 7, null, null, "Dishonored 2", 8, "https://dishonored.bethesda.net/", null },
                    { 3, "<p>Dive into a transformed vibrant post-apocalyptic Hope County, Montana, 17 years after a global nuclear catastrophe. Lead the fight against the Highwaymen, as they seek to take over the last remaining resources.</p>", 12, null, null, "Far Cry: New Dawn", 11, "https://far-cry.ubisoft.com/game/en-gb/home", "https://www.youtube.com/playlist?list=PLpwyzkZha0Z7G-o616hulBY-eXZrYzj-i" },
                    { 4, "<p>Live the epic odyssey of a legendary Spartan hero, write your own epic odyssey and become a legendary Spartan hero in Assassin's Creed Odyssey, an inspiring adventure where you must forge your destiny and define your own path in a world on the brink of tearing itself apart. Influence how history unfolds as you experience a rich and ever-changing world shaped by your decisions.</p>", 28, null, null, "Assassin's Creed: Odyssey", 11, "https://assassinscreed.ubisoft.com/game/en-gb/home", "https://www.youtube.com/user/assassinscreed" },
                    { 6, "<p>A Plague Tale: Innocence, on PlayStation 4, Xbox One and PC, tells the grim story of two siblings fighting together for survival in the darkest hours of History. This new video game from Asobo Studio sends you on an emotional journey through the 14th century France, with gameplay combining adventure, action and stealth, supported by a compelling story. Follow the young Amicia and her little brother Hugo, who face the brutality of a ravaged world as they discover their purpose to expose a dark secret. On the run from the Inquisition's soldiers, surrounded by unstoppable swarms of rats incarnating the Black Death, Amicia and Hugo will learn to know and trust each other as they struggle for their lives against all odds.</p>", 20, null, null, "A Plague Tale: Innocence", 19, "http://aplaguetale.com/", null }
                });

            migrationBuilder.InsertData(
                table: "GameGenres",
                columns: new[] { "GameId", "GenreId" },
                values: new object[,]
                {
                    { 5, 1 },
                    { 5, 3 },
                    { 1, 1 },
                    { 1, 3 },
                    { 9, 2 },
                    { 9, 1 },
                    { 7, 2 },
                    { 7, 3 },
                    { 8, 2 },
                    { 8, 3 },
                    { 3, 2 },
                    { 3, 3 },
                    { 4, 1 },
                    { 4, 2 },
                    { 6, 2 }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Games_GameGenreGameId_GameGenreGenreId",
                table: "Games",
                columns: new[] { "GameGenreGameId", "GameGenreGenreId" });

            migrationBuilder.CreateIndex(
                name: "IX_Genres_GameGenreGameId_GameGenreGenreId",
                table: "Genres",
                columns: new[] { "GameGenreGameId", "GameGenreGenreId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Games_GameGenres_GameGenreGameId_GameGenreGenreId",
                table: "Games",
                columns: new[] { "GameGenreGameId", "GameGenreGenreId" },
                principalTable: "GameGenres",
                principalColumns: new[] { "GameId", "GenreId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Genres_GameGenres_GameGenreGameId_GameGenreGenreId",
                table: "Genres",
                columns: new[] { "GameGenreGameId", "GameGenreGenreId" },
                principalTable: "GameGenres",
                principalColumns: new[] { "GameId", "GenreId" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameGenres_Games_GameId",
                table: "GameGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_GameGenres_Genres_GenreId",
                table: "GameGenres");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "GameGenres");
        }
    }
}
