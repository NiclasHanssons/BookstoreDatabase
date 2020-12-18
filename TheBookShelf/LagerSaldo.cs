using System;
using System.Collections.Generic;

#nullable disable

namespace Lab3TheBookShelf
{
    public partial class LagerSaldo
    {
        public int ButikId { get; set; }
        public long Isbn { get; set; }
        public int? Antal { get; set; }

        public virtual Butiker Butik { get; set; }
        public virtual Böcker IsbnNavigation { get; set; }
    }
}
