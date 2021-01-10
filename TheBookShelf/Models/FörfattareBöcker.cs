using System;
using System.Collections.Generic;

#nullable disable

namespace TheBookShelf
{
    public partial class FörfattareBöcker
    {
        public int FörfattareId { get; set; }
        public long Isbn { get; set; }

        public virtual Författare Författare { get; set; }
        public virtual Böcker IsbnFörfattare { get; set; }
    }
}
