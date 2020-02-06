using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesCollection.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Game> Games { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<GameGenre> GameGenres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<GameGenre>().HasKey(gg => new { gg.GameId, gg.GenreId });
            modelBuilder.Entity<Genre>().HasData(new Genre { Id = 1, Name = "Role-playing" });
            modelBuilder.Entity<Genre>().HasData(new Genre { Id = 2, Name = "Adventure" });
            modelBuilder.Entity<Genre>().HasData(new Genre { Id = 3, Name = "Shooter" });
            modelBuilder.Entity<Genre>().HasData(new Genre { Id = 4, Name = "Platform" });
            modelBuilder.Entity<Genre>().HasData(new Genre { Id = 5, Name = "Indie" });
            modelBuilder.Entity<Genre>().HasData(new Genre { Id = 6, Name = "Puzzle" });
            modelBuilder.Entity<Genre>().HasData(new Genre { Id = 7, Name = "Adventure" });
            modelBuilder.Entity<Genre>().HasData(new Genre { Id = 8, Name = "Simulator" });
            modelBuilder.Entity<Genre>().HasData(new Genre { Id = 9, Name = "Strategy" });
            modelBuilder.Entity<Genre>().HasData(new Genre { Id = 10, Name = "Turn-based Strategy" });
            modelBuilder.Entity<Genre>().HasData(new Genre { Id = 11, Name = "Real time Strategy" });
            modelBuilder.Entity<Genre>().HasData(new Genre { Id = 12, Name = "Survival" });
            modelBuilder.Entity<Genre>().HasData(new Genre { Id = 13, Name = "Sports" });
            modelBuilder.Entity<Genre>().HasData(new Genre { Id = 14, Name = "Stealth" });
            modelBuilder.Entity<Genre>().HasData(new Genre { Id = 15, Name = "Multiplayer" });
            modelBuilder.Entity<Genre>().HasData(new Genre { Id = 16, Name = "Massive Multiplayer" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 1, Name = "Take Two Interactive", CountryCode = "US", Website = "https://take2games.com" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 2, Name = "Xbox Game Studios", CountryCode = "US", Website = "https://xbox.com/en-US/xbox-game-studios/" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 3, Name = "CD Projekt", CountryCode = "PL", Website = "https://cdprojekt.com/" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 4, Name = "Electronic Arts", CountryCode = "US", Website = "https://ea.com/" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 5, Name = "BioWare", CountryCode = "US", Website = "https://bioware.com/", ParentId = 3 });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 6, Name = "ZeniMax Media", CountryCode = "US", Website = "https://zenimax.com/" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 7, Name = "Arkane Studios", CountryCode = "FR", Website = "https://arkane-studios.com/", ParentId = 6 });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 8, Name = "Bethesda Softworks", CountryCode = "US", Website = "https://bethesda.com/", ParentId = 6 });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 9, Name = "id Software", CountryCode = "US", Website = "https://idsoftware.com/", ParentId = 6 });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 10, Name = "ZeniMax Online Studios", CountryCode = "US", Website = "https://zenimaxonline.com/", ParentId = 6 });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 11, Name = "UbiSoft", CountryCode = "FR", Website = "https://ubisoft.com/" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 12, Name = "UbiSoft Montreal", CountryCode = "CA", Website = "https://montreal.ubisoft.com/", ParentId = 11 });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 13, Name = "2K Games", CountryCode = "US", Website = "https://2k.com", ParentId = 1 });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 14, Name = "Rockstar Games", CountryCode = "US", Website = "https://rockstargames.com", ParentId = 1 });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 15, Name = "Firaxis Games", CountryCode = "US", Website = "https://www.firaxis.com/", ParentId = 13 });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 16, Name = "Obsidian Entertainment", CountryCode = "US", Website = "https://www.firaxis.com/", ParentId = 2 });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 17, Name = "Paradox Interactive", CountryCode = "SE", Website = "https://www.paradoxplaza.com/"});
            modelBuilder.Entity<Company>().HasData(new Company { Id = 18, Name = "Hardsuit Labs", CountryCode = "US", Website = "https://www.hardsuitlabs.com/", ParentId = 17 });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 19, Name = "Focus Home Interactive", CountryCode = "FR", Website = "http://focus-home.com/" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 20, Name = "Asobo Studio", CountryCode = "FR", Website = "http://www.asobostudio.com/", ParentId = 19 });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 21, Name = "Deep Silver", CountryCode = "GE", Website = "https://www.deepsilver.com/" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 22, Name = "Bohemia Interactive Studio", CountryCode = "CZ", Website = "http://www.bohemia.net/" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 23, Name = "Warhorse Studios", CountryCode = "CZ", Website = "http://www.warhorsestudios.cz/", ParentId = 21 });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 24, Name = "Facebook", CountryCode = "US", Website = "http://www.facebook.com/" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 25, Name = "Beat Games", CountryCode = "CZ", Website = "http://www.beatgames/", ParentId = 25 });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 26, Name = "CD Projekt RED", CountryCode = "PL", Website = "https://en.cdprojektred.com/", ParentId = 3 });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 27, Name = "Steam", CountryCode = "US", Website = "https://www.steampowered.com/"});
            modelBuilder.Entity<Company>().HasData(new Company { Id = 28, Name = "UbiSoft Québec", CountryCode = "CA", Website = "https://quebec.ubisoft.com/", ParentId = 11 });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 29, Name = "Private Division", CountryCode = "US", Website = "https://www.privatedivision.com/", ParentId = 1 });
            modelBuilder.Entity<Game>().HasData(new Game { Id = 1, Name = "Cyberpunk 2077", Description = "<p>In Cyberpunk 2077 you play as V — a hired gun on the rise — and you just got your first serious contract. In a world of cyberenhanced street warriors, tech-savvy netrunners and corporate lifehackers, today you take your first step towards becoming an urban legend.</p>", Website = "https://www.cyberpunk.net/", YouTubeChannel = "https://www.youtube.com/user/CyberPunkGame", PublisherId = 3, DeveloperId = 26 });
            modelBuilder.Entity<GameGenre>().HasData(new GameGenre { GameId = 1, GenreId = 1});
            modelBuilder.Entity<GameGenre>().HasData(new GameGenre { GameId = 1, GenreId = 3 });
            modelBuilder.Entity<Game>().HasData(new Game { Id = 2, Name = "DayZ", Description = "<p>DayZ is a survival video game developed and published by Bohemia Interactive. It is the standalone successor of the mod of the same name. Following a five-year long early access period for Windows, the game was officially released in December 2018, and was released for the Xbox One and PlayStation 4 in 2019.</p>", Website = "https://www.bohemia.net/games/dayz", YouTubeChannel = "https://www.youtube.com/user/BohemiaInteract", PublisherId = 22, DeveloperId = 22 });
            modelBuilder.Entity<GameGenre>().HasData(new GameGenre { GameId = 2, GenreId = 12 });
            modelBuilder.Entity<GameGenre>().HasData(new GameGenre { GameId = 2, GenreId = 3 });
            modelBuilder.Entity<Game>().HasData(new Game { Id = 3, Name = "Far Cry: New Dawn", Description = "<p>Dive into a transformed vibrant post-apocalyptic Hope County, Montana, 17 years after a global nuclear catastrophe. Lead the fight against the Highwaymen, as they seek to take over the last remaining resources.</p>", Website = "https://far-cry.ubisoft.com/game/en-gb/home", YouTubeChannel = "https://www.youtube.com/playlist?list=PLpwyzkZha0Z7G-o616hulBY-eXZrYzj-i", PublisherId = 11, DeveloperId = 12 });
            modelBuilder.Entity<GameGenre>().HasData(new GameGenre { GameId = 3, GenreId = 2 });
            modelBuilder.Entity<GameGenre>().HasData(new GameGenre { GameId = 3, GenreId = 3 });
            modelBuilder.Entity<Game>().HasData(new Game { Id = 4, Name = "Assassin's Creed: Odyssey", Description = "<p>Live the epic odyssey of a legendary Spartan hero, write your own epic odyssey and become a legendary Spartan hero in Assassin's Creed Odyssey, an inspiring adventure where you must forge your destiny and define your own path in a world on the brink of tearing itself apart. Influence how history unfolds as you experience a rich and ever-changing world shaped by your decisions.</p>", Website = "https://assassinscreed.ubisoft.com/game/en-gb/home", YouTubeChannel = "https://www.youtube.com/user/assassinscreed", PublisherId = 11, DeveloperId = 28 });
            modelBuilder.Entity<GameGenre>().HasData(new GameGenre { GameId = 4, GenreId = 1 });
            modelBuilder.Entity<GameGenre>().HasData(new GameGenre { GameId = 4, GenreId = 2 });
            modelBuilder.Entity<Game>().HasData(new Game { Id = 5, Name = "The Outer Worlds", Description = "<p>In The Outer Worlds, you awake from hibernation on a colonist ship that was lost in transit to Halcyon, the furthest colony from Earth located at the edge of the galaxy, only to find yourself in the midst of a deep conspiracy threatening to destroy it. As you explore the furthest reaches of space and encounter various factions, all vying for power, the character you decide to become will determine how this player-driven story unfolds. In the corporate equation for the colony, you are the unplanned variable.</p>", Website = "https://outerworlds.obsidian.net/en", YouTubeChannel = null, PublisherId = 29, DeveloperId = 16 });
            modelBuilder.Entity<GameGenre>().HasData(new GameGenre { GameId = 5, GenreId = 1 });
            modelBuilder.Entity<GameGenre>().HasData(new GameGenre { GameId = 5, GenreId = 3 });
            modelBuilder.Entity<Game>().HasData(new Game { Id = 6, Name = "A Plague Tale: Innocence", Description = "<p>A Plague Tale: Innocence, on PlayStation 4, Xbox One and PC, tells the grim story of two siblings fighting together for survival in the darkest hours of History. This new video game from Asobo Studio sends you on an emotional journey through the 14th century France, with gameplay combining adventure, action and stealth, supported by a compelling story. Follow the young Amicia and her little brother Hugo, who face the brutality of a ravaged world as they discover their purpose to expose a dark secret. On the run from the Inquisition's soldiers, surrounded by unstoppable swarms of rats incarnating the Black Death, Amicia and Hugo will learn to know and trust each other as they struggle for their lives against all odds.</p>", Website = "http://aplaguetale.com/", YouTubeChannel = null, PublisherId = 19, DeveloperId = 20 });
            modelBuilder.Entity<GameGenre>().HasData(new GameGenre { GameId = 6, GenreId = 2 });
            modelBuilder.Entity<Game>().HasData(new Game { Id = 7, Name = "Dishonored", Description = "<p>Dishonored is an immersive first-person action game that casts you as a supernatural assassin driven by revenge. With Dishonored’s flexible combat system, creatively eliminate your targets as you combine the supernatural abilities, weapons and unusual gadgets at your disposal. Pursue your enemies under the cover of darkness or ruthlessly attack them head on with weapons drawn. The outcome of each mission plays out based on the choices you make.</p>", Website = "https://dishonored.bethesda.net/", YouTubeChannel = null, PublisherId = 8, DeveloperId = 7 });
            modelBuilder.Entity<GameGenre>().HasData(new GameGenre { GameId = 7, GenreId = 2 });
            modelBuilder.Entity<GameGenre>().HasData(new GameGenre { GameId = 7, GenreId = 3 });
            modelBuilder.Entity<Game>().HasData(new Game { Id = 8, Name = "Dishonored 2", Description = "<p>Reprise your role as a supernatural assassin in Dishonored 2. Play your way in a world where mysticism and industry collide. Will you choose to play as Empress Emily Kaldwin or the Royal Protector, Corvo Attano? Will you stalk your way through the game unseen, make full use of its brutal combat system, or use a blend of both? How will you combine your character’s unique set of powers, weapons and gadgets to eliminate your enemies? The story responds to your choices, leading to intriguing outcomes, as you play through each of the game’s hand-crafted missions.</p>", Website = "https://dishonored.bethesda.net/", YouTubeChannel = null, PublisherId = 8, DeveloperId = 7 });
            modelBuilder.Entity<GameGenre>().HasData(new GameGenre { GameId = 8, GenreId = 2 });
            modelBuilder.Entity<GameGenre>().HasData(new GameGenre { GameId = 8, GenreId = 3 });
            modelBuilder.Entity<Game>().HasData(new Game { Id = 9, Name = "The Witcher 3: Wild Hunt", Description = "<p>The Witcher: Wild Hunt is a story-driven, next-generation open world role-playing game set in a visually stunning fantasy universe full of meaningful choices and impactful consequences. In The Witcher you play as the professional monster hunter, Geralt of Rivia, tasked with finding a child of prophecy in a vast open world rich with merchant cities, viking pirate islands, dangerous mountain passes, and forgotten caverns to explore.</p>", Website = "https://dishonored.bethesda.net/", YouTubeChannel = "https://www.youtube.com/user/WitcherGame", PublisherId = 3, DeveloperId = 26 });
            modelBuilder.Entity<GameGenre>().HasData(new GameGenre { GameId = 9, GenreId = 2 });
            modelBuilder.Entity<GameGenre>().HasData(new GameGenre { GameId = 9, GenreId = 1 });
        }
    }
}
