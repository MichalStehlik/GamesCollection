using GamesCollection.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesCollection.Services
{
    public class GamesStorageService
    {
        private ApplicationDbContext _context;
        private ILogger<GamesStorageService> _logger;

        public GamesStorageService(ApplicationDbContext context, ILogger<GamesStorageService> logger)
        {
            _context = context;
            _logger = logger;
        }
    }
}
