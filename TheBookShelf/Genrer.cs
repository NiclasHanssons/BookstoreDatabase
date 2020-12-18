using System;
using System.Collections.Generic;

#nullable disable

namespace Lab3TheBookShelf
{
    public partial class Genrer
    {
        public Genrer()
        {
            Böckers = new HashSet<Böcker>();
        }

        public int Id { get; set; }
        public string Namn { get; set; }

        public virtual ICollection<Böcker> Böckers { get; set; }
    }
}
