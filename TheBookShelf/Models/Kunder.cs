using System;
using System.Collections.Generic;

#nullable disable

namespace TheBookShelf
{
    public partial class Kunder
    {
        public int Id { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public string Email { get; set; }
        public DateTime? Födelsedatum { get; set; }
        public string Kön { get; set; }
        public string Adress { get; set; }
        public string Stad { get; set; }
        public string Land { get; set; }
        public int? RegistreradButikId { get; set; }

        public virtual Butiker RegistreradButik { get; set; }
    }
}
