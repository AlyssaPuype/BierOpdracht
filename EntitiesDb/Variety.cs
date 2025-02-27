﻿using System;
using System.Collections.Generic;

namespace BierOpdracht.EntitiesDb;

public partial class Variety
{
    public int Soortnr { get; set; }

    public string Soortnaam { get; set; } = null!;

    public virtual ICollection<Beer> Beers { get; set; } = new List<Beer>();
}
