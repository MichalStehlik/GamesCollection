﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamesCollection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GamesCollection.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private ApplicationDbContext _context;

        public string NameSort { get; set; }
        public string CountrySort { get; set; }
        public string CurrentNameFilter { get; set; }
        public string CurrentCountryFilter { get; set; }
        public string CurrentSort { get; set; }
        public IList<Company> Companies { get; set; }
        public SelectList CountriesList { get; set; }
        public IndexModel(ApplicationDbContext context, ILogger<IndexModel> logger)
        {
            _logger = logger;
            _context = context;
        }

        public async Task OnGet(string order, string search, string nameFilter, string countryFilter, int? ownerFilter = 0)
        {
            CountriesList = new SelectList(new List<string> { 
                "CZ", "FR", "GE", "PL", "SE", "US"
            });
            IQueryable<Company> companies = _context.Companies;
            Companies = await companies.AsNoTracking().ToListAsync();
        }
    }
}