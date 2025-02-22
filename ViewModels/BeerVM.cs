using BierOpdracht.EntitiesDb;

namespace BierOpdracht.ViewModels
{
    public class BeerVM
    {
        public int Biernr { get; set; }

        public string Naam { get; set; } = null!;

        public int Brouwernr { get; set; }

        public int Soortnr { get; set; }

        public decimal? Alcohol { get; set; }

        public string? Image { get; set; }

        public virtual Brewery BrouwernrNavigation { get; set; } = null!;

        public virtual Variety SoortnrNavigation { get; set; } = null!;

    }
}
