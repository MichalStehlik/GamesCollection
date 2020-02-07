using System;
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

        public IList<Company> Companies { get; set; }
        public IList<SelectListItem> CountriesList { get; set; }

        [BindProperty]
        public string Order { get; set; }
        [BindProperty]
        public string Search { get; set; }
        [BindProperty]
        public string NameFilter { get; set; }
        [BindProperty]
        public string CountryFilter { get; set; }
        [BindProperty]
        public int OwnerFilter { get; set; }
        public IndexModel(ApplicationDbContext context, ILogger<IndexModel> logger)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            CountriesList = new List<SelectListItem> {
                new SelectListItem { Text = "CZ", Value = "CZ"},
                new SelectListItem { Text = "FR", Value = "FR"},
                new SelectListItem { Text = "GE", Value = "GE"},
                new SelectListItem { Text = "PL", Value = "PL"},
                new SelectListItem { Text = "SE", Value = "SE"},
                new SelectListItem { Text = "US", Value = "US"},
                new SelectListItem { Text = "CA", Value = "CA"},
            };
            IQueryable<Company> companies = _context.Companies;
            Companies = new List<Company>();
        }
    }
}
