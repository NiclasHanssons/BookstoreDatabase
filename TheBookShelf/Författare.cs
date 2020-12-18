using System;
using System.Collections.Generic;

#nullable disable

namespace Lab3TheBookShelf
{
    public partial class Författare
    {
        public Författare()
        {
            FörfattareBöckers = new HashSet<FörfattareBöcker>();
        }

        public int Id { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public DateTime Födelsedatum { get; set; }
        public string Kön { get; set; }
        public string Nationalitet { get; set; }

        public virtual ICollection<FörfattareBöcker> FörfattareBöckers { get; set; }
    }
}
