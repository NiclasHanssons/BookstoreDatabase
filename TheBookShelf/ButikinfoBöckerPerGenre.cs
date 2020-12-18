using System;
using System.Collections.Generic;

#nullable disable

namespace Lab3TheBookShelf
{
    public partial class ButikinfoBöckerPerGenre
    {
        public string Butik { get; set; }
        public int? LagervärdeSek { get; set; }
        public string Genre { get; set; }
        public string Böcker { get; set; }
        public int? AntalBöcker { get; set; }
        public string Förlag { get; set; }
    }
}
