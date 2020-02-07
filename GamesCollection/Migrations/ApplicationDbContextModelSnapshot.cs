﻿// <auto-generated />
using System;
using GamesCollection.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GamesCollection.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GamesCollection.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryCode = "US",
                            Name = "Take Two Interactive",
                            Website = "https://take2games.com"
                        },
                        new
                        {
                            Id = 2,
                            CountryCode = "US",
                            Name = "Xbox Game Studios",
                            Website = "https://xbox.com/en-US/xbox-game-studios/"
                        },
                        new
                        {
                            Id = 3,
                            CountryCode = "PL",
                            Name = "CD Projekt",
                            Website = "https://cdprojekt.com/"
                        },
                        new
                        {
                            Id = 4,
                            CountryCode = "US",
                            Name = "Electronic Arts",
                            Website = "https://ea.com/"
                        },
                        new
                        {
                            Id = 5,
                            CountryCode = "US",
                            Name = "BioWare",
                            ParentId = 4,
                            Website = "https://bioware.com/"
                        },
                        new
                        {
                            Id = 6,
                            CountryCode = "US",
                            Name = "ZeniMax Media",
                            Website = "https://zenimax.com/"
                        },
                        new
                        {
                            Id = 7,
                            CountryCode = "FR",
                            Name = "Arkane Studios",
                            ParentId = 6,
                            Website = "https://arkane-studios.com/"
                        },
                        new
                        {
                            Id = 8,
                            CountryCode = "US",
                            Name = "Bethesda Softworks",
                            ParentId = 6,
                            Website = "https://bethesda.com/"
                        },
                        new
                        {
                            Id = 9,
                            CountryCode = "US",
                            Name = "id Software",
                            ParentId = 6,
                            Website = "https://idsoftware.com/"
                        },
                        new
                        {
                            Id = 10,
                            CountryCode = "US",
                            Name = "ZeniMax Online Studios",
                            ParentId = 6,
                            Website = "https://zenimaxonline.com/"
                        },
                        new
                        {
                            Id = 11,
                            CountryCode = "FR",
                            Name = "UbiSoft",
                            Website = "https://ubisoft.com/"
                        },
                        new
                        {
                            Id = 12,
                            CountryCode = "CA",
                            Name = "UbiSoft Montreal",
                            ParentId = 11,
                            Website = "https://montreal.ubisoft.com/"
                        },
                        new
                        {
                            Id = 13,
                            CountryCode = "US",
                            Name = "2K Games",
                            ParentId = 1,
                            Website = "https://2k.com"
                        },
                        new
                        {
                            Id = 14,
                            CountryCode = "US",
                            Name = "Rockstar Games",
                            ParentId = 1,
                            Website = "https://rockstargames.com"
                        },
                        new
                        {
                            Id = 15,
                            CountryCode = "US",
                            Name = "Firaxis Games",
                            ParentId = 13,
                            Website = "https://www.firaxis.com/"
                        },
                        new
                        {
                            Id = 16,
                            CountryCode = "US",
                            Name = "Obsidian Entertainment",
                            ParentId = 2,
                            Website = "https://www.obsidian.net"
                        },
                        new
                        {
                            Id = 17,
                            CountryCode = "SE",
                            Name = "Paradox Interactive",
                            Website = "https://www.paradoxplaza.com/"
                        },
                        new
                        {
                            Id = 18,
                            CountryCode = "US",
                            Name = "Hardsuit Labs",
                            ParentId = 17,
                            Website = "https://www.hardsuitlabs.com/"
                        },
                        new
                        {
                            Id = 19,
                            CountryCode = "FR",
                            Name = "Focus Home Interactive",
                            Website = "http://focus-home.com/"
                        },
                        new
                        {
                            Id = 20,
                            CountryCode = "FR",
                            Name = "Asobo Studio",
                            ParentId = 19,
                            Website = "http://www.asobostudio.com/"
                        },
                        new
                        {
                            Id = 21,
                            CountryCode = "GE",
                            Name = "Deep Silver",
                            Website = "https://www.deepsilver.com/"
                        },
                        new
                        {
                            Id = 22,
                            CountryCode = "CZ",
                            Name = "Bohemia Interactive Studio",
                            Website = "http://www.bohemia.net/"
                        },
                        new
                        {
                            Id = 23,
                            CountryCode = "CZ",
                            Name = "Warhorse Studios",
                            ParentId = 21,
                            Website = "http://www.warhorsestudios.cz/"
                        },
                        new
                        {
                            Id = 24,
                            CountryCode = "US",
                            Name = "Facebook",
                            Website = "http://www.facebook.com/"
                        },
                        new
                        {
                            Id = 25,
                            CountryCode = "CZ",
                            Name = "Beat Games",
                            ParentId = 25,
                            Website = "http://www.beatgames/"
                        },
                        new
                        {
                            Id = 26,
                            CountryCode = "PL",
                            Name = "CD Projekt RED",
                            ParentId = 3,
                            Website = "https://en.cdprojektred.com/"
                        },
                        new
                        {
                            Id = 27,
                            CountryCode = "US",
                            Name = "Steam",
                            Website = "https://www.steampowered.com/"
                        },
                        new
                        {
                            Id = 28,
                            CountryCode = "CA",
                            Name = "UbiSoft Québec",
                            ParentId = 11,
                            Website = "https://quebec.ubisoft.com/"
                        },
                        new
                        {
                            Id = 29,
                            CountryCode = "US",
                            Name = "Private Division",
                            ParentId = 1,
                            Website = "https://www.privatedivision.com/"
                        });
                });

            modelBuilder.Entity("GamesCollection.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DeveloperId")
                        .HasColumnType("int");

                    b.Property<int?>("GameGenreGameId")
                        .HasColumnType("int");

                    b.Property<int?>("GameGenreGenreId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PublisherId")
                        .HasColumnType("int");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YouTubeChannel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DeveloperId");

                    b.HasIndex("PublisherId");

                    b.HasIndex("GameGenreGameId", "GameGenreGenreId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "<p>In Cyberpunk 2077 you play as V — a hired gun on the rise — and you just got your first serious contract. In a world of cyberenhanced street warriors, tech-savvy netrunners and corporate lifehackers, today you take your first step towards becoming an urban legend.</p>",
                            DeveloperId = 26,
                            Name = "Cyberpunk 2077",
                            PublisherId = 3,
                            Website = "https://www.cyberpunk.net/",
                            YouTubeChannel = "https://www.youtube.com/user/CyberPunkGame"
                        },
                        new
                        {
                            Id = 2,
                            Description = "<p>DayZ is a survival video game developed and published by Bohemia Interactive. It is the standalone successor of the mod of the same name. Following a five-year long early access period for Windows, the game was officially released in December 2018, and was released for the Xbox One and PlayStation 4 in 2019.</p>",
                            DeveloperId = 22,
                            Name = "DayZ",
                            PublisherId = 22,
                            Website = "https://www.bohemia.net/games/dayz",
                            YouTubeChannel = "https://www.youtube.com/user/BohemiaInteract"
                        },
                        new
                        {
                            Id = 3,
                            Description = "<p>Dive into a transformed vibrant post-apocalyptic Hope County, Montana, 17 years after a global nuclear catastrophe. Lead the fight against the Highwaymen, as they seek to take over the last remaining resources.</p>",
                            DeveloperId = 12,
                            Name = "Far Cry: New Dawn",
                            PublisherId = 11,
                            Website = "https://far-cry.ubisoft.com/game/en-gb/home",
                            YouTubeChannel = "https://www.youtube.com/playlist?list=PLpwyzkZha0Z7G-o616hulBY-eXZrYzj-i"
                        },
                        new
                        {
                            Id = 4,
                            Description = "<p>Live the epic odyssey of a legendary Spartan hero, write your own epic odyssey and become a legendary Spartan hero in Assassin's Creed Odyssey, an inspiring adventure where you must forge your destiny and define your own path in a world on the brink of tearing itself apart. Influence how history unfolds as you experience a rich and ever-changing world shaped by your decisions.</p>",
                            DeveloperId = 28,
                            Name = "Assassin's Creed: Odyssey",
                            PublisherId = 11,
                            Website = "https://assassinscreed.ubisoft.com/game/en-gb/home",
                            YouTubeChannel = "https://www.youtube.com/user/assassinscreed"
                        },
                        new
                        {
                            Id = 5,
                            Description = "<p>In The Outer Worlds, you awake from hibernation on a colonist ship that was lost in transit to Halcyon, the furthest colony from Earth located at the edge of the galaxy, only to find yourself in the midst of a deep conspiracy threatening to destroy it. As you explore the furthest reaches of space and encounter various factions, all vying for power, the character you decide to become will determine how this player-driven story unfolds. In the corporate equation for the colony, you are the unplanned variable.</p>",
                            DeveloperId = 16,
                            Name = "The Outer Worlds",
                            PublisherId = 29,
                            Website = "https://outerworlds.obsidian.net/en"
                        },
                        new
                        {
                            Id = 6,
                            Description = "<p>A Plague Tale: Innocence, on PlayStation 4, Xbox One and PC, tells the grim story of two siblings fighting together for survival in the darkest hours of History. This new video game from Asobo Studio sends you on an emotional journey through the 14th century France, with gameplay combining adventure, action and stealth, supported by a compelling story. Follow the young Amicia and her little brother Hugo, who face the brutality of a ravaged world as they discover their purpose to expose a dark secret. On the run from the Inquisition's soldiers, surrounded by unstoppable swarms of rats incarnating the Black Death, Amicia and Hugo will learn to know and trust each other as they struggle for their lives against all odds.</p>",
                            DeveloperId = 20,
                            Name = "A Plague Tale: Innocence",
                            PublisherId = 19,
                            Website = "http://aplaguetale.com/"
                        },
                        new
                        {
                            Id = 7,
                            Description = "<p>Dishonored is an immersive first-person action game that casts you as a supernatural assassin driven by revenge. With Dishonored’s flexible combat system, creatively eliminate your targets as you combine the supernatural abilities, weapons and unusual gadgets at your disposal. Pursue your enemies under the cover of darkness or ruthlessly attack them head on with weapons drawn. The outcome of each mission plays out based on the choices you make.</p>",
                            DeveloperId = 7,
                            Name = "Dishonored",
                            PublisherId = 8,
                            Website = "https://dishonored.bethesda.net/"
                        },
                        new
                        {
                            Id = 8,
                            Description = "<p>Reprise your role as a supernatural assassin in Dishonored 2. Play your way in a world where mysticism and industry collide. Will you choose to play as Empress Emily Kaldwin or the Royal Protector, Corvo Attano? Will you stalk your way through the game unseen, make full use of its brutal combat system, or use a blend of both? How will you combine your character’s unique set of powers, weapons and gadgets to eliminate your enemies? The story responds to your choices, leading to intriguing outcomes, as you play through each of the game’s hand-crafted missions.</p>",
                            DeveloperId = 7,
                            Name = "Dishonored 2",
                            PublisherId = 8,
                            Website = "https://dishonored.bethesda.net/"
                        },
                        new
                        {
                            Id = 9,
                            Description = "<p>The Witcher: Wild Hunt is a story-driven, next-generation open world role-playing game set in a visually stunning fantasy universe full of meaningful choices and impactful consequences. In The Witcher you play as the professional monster hunter, Geralt of Rivia, tasked with finding a child of prophecy in a vast open world rich with merchant cities, viking pirate islands, dangerous mountain passes, and forgotten caverns to explore.</p>",
                            DeveloperId = 26,
                            Name = "The Witcher 3: Wild Hunt",
                            PublisherId = 3,
                            Website = "https://dishonored.bethesda.net/",
                            YouTubeChannel = "https://www.youtube.com/user/WitcherGame"
                        });
                });

            modelBuilder.Entity("GamesCollection.Models.GameGenre", b =>
                {
                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("GameId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("GameGenres");

                    b.HasData(
                        new
                        {
                            GameId = 1,
                            GenreId = 1
                        },
                        new
                        {
                            GameId = 1,
                            GenreId = 3
                        },
                        new
                        {
                            GameId = 2,
                            GenreId = 12
                        },
                        new
                        {
                            GameId = 2,
                            GenreId = 3
                        },
                        new
                        {
                            GameId = 3,
                            GenreId = 2
                        },
                        new
                        {
                            GameId = 3,
                            GenreId = 3
                        },
                        new
                        {
                            GameId = 4,
                            GenreId = 1
                        },
                        new
                        {
                            GameId = 4,
                            GenreId = 2
                        },
                        new
                        {
                            GameId = 5,
                            GenreId = 1
                        },
                        new
                        {
                            GameId = 5,
                            GenreId = 3
                        },
                        new
                        {
                            GameId = 6,
                            GenreId = 2
                        },
                        new
                        {
                            GameId = 7,
                            GenreId = 2
                        },
                        new
                        {
                            GameId = 7,
                            GenreId = 3
                        },
                        new
                        {
                            GameId = 8,
                            GenreId = 2
                        },
                        new
                        {
                            GameId = 8,
                            GenreId = 3
                        },
                        new
                        {
                            GameId = 9,
                            GenreId = 2
                        },
                        new
                        {
                            GameId = 9,
                            GenreId = 1
                        });
                });

            modelBuilder.Entity("GamesCollection.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GameGenreGameId")
                        .HasColumnType("int");

                    b.Property<int?>("GameGenreGenreId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GameGenreGameId", "GameGenreGenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Role-playing"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Shooter"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Platform"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Indie"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Puzzle"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Simulator"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Strategy"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Turn-based Strategy"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Real time Strategy"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Survival"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Sports"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Stealth"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Multiplayer"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Massive Multiplayer"
                        });
                });

            modelBuilder.Entity("GamesCollection.Models.Company", b =>
                {
                    b.HasOne("GamesCollection.Models.Company", "Parent")
                        .WithMany("Subsidiaries")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("GamesCollection.Models.Game", b =>
                {
                    b.HasOne("GamesCollection.Models.Company", "Developer")
                        .WithMany("DevelopedGames")
                        .HasForeignKey("DeveloperId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("GamesCollection.Models.Company", "Publisher")
                        .WithMany("PublishedGames")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("GamesCollection.Models.GameGenre", null)
                        .WithMany("Games")
                        .HasForeignKey("GameGenreGameId", "GameGenreGenreId");
                });

            modelBuilder.Entity("GamesCollection.Models.GameGenre", b =>
                {
                    b.HasOne("GamesCollection.Models.Game", "Game")
                        .WithMany("GameGenres")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GamesCollection.Models.Genre", "Genre")
                        .WithMany("GameGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GamesCollection.Models.Genre", b =>
                {
                    b.HasOne("GamesCollection.Models.GameGenre", null)
                        .WithMany("Genres")
                        .HasForeignKey("GameGenreGameId", "GameGenreGenreId");
                });
#pragma warning restore 612, 618
        }
    }
}
