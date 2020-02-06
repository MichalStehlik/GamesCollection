using Microsoft.EntityFrameworkCore.Migrations;

namespace GamesCollection.Migrations
{
    public partial class AddingGames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameGenres_Games_GameId",
                table: "GameGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_GameGenres_Genres_GenreId",
                table: "GameGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Companies_DeveloperId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Companies_PublisherId",
                table: "Games");

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CountryCode", "Name", "ParentId", "Website" },
                values: new object[,]
                {
                    { 28, "CA", "UbiSoft Québec", 11, "https://quebec.ubisoft.com/" },
                    { 29, "US", "Private Division", 1, "https://www.privatedivision.com/" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "DeveloperId", "Name", "PublisherId", "Website", "YouTubeChannel" },
                values: new object[,]
                {
                    { 3, "<p>Dive into a transformed vibrant post-apocalyptic Hope County, Montana, 17 years after a global nuclear catastrophe. Lead the fight against the Highwaymen, as they seek to take over the last remaining resources.</p>", 12, "Far Cry: New Dawn", 11, "https://far-cry.ubisoft.com/game/en-gb/home", "https://www.youtube.com/playlist?list=PLpwyzkZha0Z7G-o616hulBY-eXZrYzj-i" },
                    { 6, "<p>A Plague Tale: Innocence, on PlayStation 4, Xbox One and PC, tells the grim story of two siblings fighting together for survival in the darkest hours of History. This new video game from Asobo Studio sends you on an emotional journey through the 14th century France, with gameplay combining adventure, action and stealth, supported by a compelling story. Follow the young Amicia and her little brother Hugo, who face the brutality of a ravaged world as they discover their purpose to expose a dark secret. On the run from the Inquisition's soldiers, surrounded by unstoppable swarms of rats incarnating the Black Death, Amicia and Hugo will learn to know and trust each other as they struggle for their lives against all odds.</p>", 20, "A Plague Tale: Innocence", 19, "http://aplaguetale.com/", null },
                    { 7, "<p>Dishonored is an immersive first-person action game that casts you as a supernatural assassin driven by revenge. With Dishonored’s flexible combat system, creatively eliminate your targets as you combine the supernatural abilities, weapons and unusual gadgets at your disposal. Pursue your enemies under the cover of darkness or ruthlessly attack them head on with weapons drawn. The outcome of each mission plays out based on the choices you make.</p>", 7, "Dishonored", 8, "https://dishonored.bethesda.net/", null },
                    { 8, "<p>Reprise your role as a supernatural assassin in Dishonored 2. Play your way in a world where mysticism and industry collide. Will you choose to play as Empress Emily Kaldwin or the Royal Protector, Corvo Attano? Will you stalk your way through the game unseen, make full use of its brutal combat system, or use a blend of both? How will you combine your character’s unique set of powers, weapons and gadgets to eliminate your enemies? The story responds to your choices, leading to intriguing outcomes, as you play through each of the game’s hand-crafted missions.</p>", 7, "Dishonored 2", 8, "https://dishonored.bethesda.net/", null },
                    { 9, "<p>The Witcher: Wild Hunt is a story-driven, next-generation open world role-playing game set in a visually stunning fantasy universe full of meaningful choices and impactful consequences. In The Witcher you play as the professional monster hunter, Geralt of Rivia, tasked with finding a child of prophecy in a vast open world rich with merchant cities, viking pirate islands, dangerous mountain passes, and forgotten caverns to explore.</p>", 26, "The Witcher 3: Wild Hunt", 3, "https://dishonored.bethesda.net/", "https://www.youtube.com/user/WitcherGame" }
                });

            migrationBuilder.InsertData(
                table: "GameGenres",
                columns: new[] { "GameId", "GenreId" },
                values: new object[,]
                {
                    { 3, 2 },
                    { 3, 3 },
                    { 6, 2 },
                    { 7, 2 },
                    { 7, 3 },
                    { 8, 2 },
                    { 8, 3 },
                    { 9, 2 },
                    { 9, 1 }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "DeveloperId", "Name", "PublisherId", "Website", "YouTubeChannel" },
                values: new object[,]
                {
                    { 4, "<p>Live the epic odyssey of a legendary Spartan hero, write your own epic odyssey and become a legendary Spartan hero in Assassin's Creed Odyssey, an inspiring adventure where you must forge your destiny and define your own path in a world on the brink of tearing itself apart. Influence how history unfolds as you experience a rich and ever-changing world shaped by your decisions.</p>", 28, "Assassin's Creed: Odyssey", 11, "https://assassinscreed.ubisoft.com/game/en-gb/home", "https://www.youtube.com/user/assassinscreed" },
                    { 5, "<p>In The Outer Worlds, you awake from hibernation on a colonist ship that was lost in transit to Halcyon, the furthest colony from Earth located at the edge of the galaxy, only to find yourself in the midst of a deep conspiracy threatening to destroy it. As you explore the furthest reaches of space and encounter various factions, all vying for power, the character you decide to become will determine how this player-driven story unfolds. In the corporate equation for the colony, you are the unplanned variable.</p>", 16, "The Outer Worlds", 29, "https://outerworlds.obsidian.net/en", null }
                });

            migrationBuilder.InsertData(
                table: "GameGenres",
                columns: new[] { "GameId", "GenreId" },
                values: new object[,]
                {
                    { 4, 1 },
                    { 4, 2 },
                    { 5, 1 },
                    { 5, 3 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_GameGenres_Games_GameId",
                table: "GameGenres",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameGenres_Genres_GenreId",
                table: "GameGenres",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Companies_DeveloperId",
                table: "Games",
                column: "DeveloperId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Companies_PublisherId",
                table: "Games",
                column: "PublisherId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameGenres_Games_GameId",
                table: "GameGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_GameGenres_Genres_GenreId",
                table: "GameGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Companies_DeveloperId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Companies_PublisherId",
                table: "Games");

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.AddForeignKey(
                name: "FK_GameGenres_Games_GameId",
                table: "GameGenres",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GameGenres_Genres_GenreId",
                table: "GameGenres",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Companies_DeveloperId",
                table: "Games",
                column: "DeveloperId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Companies_PublisherId",
                table: "Games",
                column: "PublisherId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
