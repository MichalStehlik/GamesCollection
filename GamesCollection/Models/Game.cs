using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GamesCollection.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Website { get; set; }
        public string YouTubeChannel { get; set; }
        public ICollection<GameGenre> Genres { get; set; }
        public Company Developer { get; set; }
        public Company Publisher { get; set; }
        public int DeveloperId { get; set; }
        public int PublisherId { get; set; }
    }
}
