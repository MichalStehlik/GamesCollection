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
            modelBuilder.Entity<Game>().HasData(new Game { Id = 1, Name = "Cyberpunk 2077", Description = "<p>In Cyberpunk 2077 you play as V — a hired gun on the rise — and you just got your first serious contract. In a world of cyberenhanced street warriors, tech-savvy netrunners and corporate lifehackers, today you take your first step towards becoming an urban legend.</p>", Website = "https://www.cyberpunk.net/", YouTubeChannel = "https://www.youtube.com/user/CyberPunkGame", PublisherId = 3, DeveloperId = 26 });
            modelBuilder.Entity<GameGenre>().HasData(new GameGenre { GameId = 1, GenreId = 1});
            modelBuilder.Entity<GameGenre>().HasData(new GameGenre { GameId = 1, GenreId = 3 });
            modelBuilder.Entity<Game>().HasData(new Game { Id = 2, Name = "DayZ", Description = "<p>DayZ is a survival video game developed and published by Bohemia Interactive. It is the standalone successor of the mod of the same name. Following a five-year long early access period for Windows, the game was officially released in December 2018, and was released for the Xbox One and PlayStation 4 in 2019.</p>", Website = "https://www.bohemia.net/games/dayz", YouTubeChannel = "https://www.youtube.com/user/BohemiaInteract", PublisherId = 22, DeveloperId = 22 });
            modelBuilder.Entity<GameGenre>().HasData(new GameGenre { GameId = 2, GenreId = 12 });
            modelBuilder.Entity<GameGenre>().HasData(new GameGenre { GameId = 2, GenreId = 3 });
        }
    }
}
