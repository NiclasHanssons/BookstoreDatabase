using System;
using System.Collections.Generic;

#nullable disable

namespace TheBookShelf
{
    public partial class Förlag
    {
        public Förlag()
        {
            Böckers = new HashSet<Böcker>();
        }

        public int Id { get; set; }
        public string Namn { get; set; }
        public string Adress { get; set; }
        public string Stad { get; set; }
        public string Land { get; set; }

        public virtual ICollection<Böcker> Böckers { get; set; }
    }
}
