using Azure.Core.Pipeline;
using BierOpdracht.DataDb;
using BierOpdracht.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BierOpdracht.Controllers
{
    public class BeerController : Controller
    {

        private readonly BierDbContext _context;
        public BeerController(BierDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var BeerVMs = _context.Beers.Select(b => new BeerVM
            {
                Biernr = b.Biernr,
                Naam = b.Naam,
                Brouwernr = b.Brouwernr,
                Soortnr = b.Soortnr,
                Alcohol = b.Alcohol,
                Image = b.Image,

            }).ToList();

            ViewBag.Breweries = _context.Breweries
        .Select(b => new { b.Brouwernr, b.Naam })
        .ToList();

            return View(BeerVMs);
        }

        public IActionResult ShowBeers(String SelectedBrewery)
        {
            var filteredBeers = _context.Beers
                .Where(b => b.Brewery.Naam == SelectedBrewery)
                .Select(b => new BeerVM
                {
                    Biernr = b.Biernr,
                    Naam = b.Naam,
                    Alcohol = b.Alcohol,
                    Image = b.Image
                }).ToList();

            return PartialView("_BeerList", filteredBeers);
        }

    }
}