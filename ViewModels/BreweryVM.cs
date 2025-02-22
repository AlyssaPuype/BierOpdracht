using BierOpdracht.EntitiesDb;

namespace BierOpdracht.ViewModels
{
    public class BreweryVM
    {
        public int Brouwernr { get; set; }

        public string Naam { get; set; } = null!;

        public string Adres { get; set; } = null!;

        public string Postcode { get; set; } = null!;

        public string Gemeente { get; set; } = null!;

        public decimal? Omzet { get; set; }

        public virtual ICollection<Beer> Beers { get; set; } = new List<Beer>();
    }
}
