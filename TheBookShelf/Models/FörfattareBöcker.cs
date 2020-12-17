using System;
using System.Collections.Generic;
using System.Diagnostics;

#nullable disable

namespace TheBookShelf
{
    [DebuggerDisplay("{FörfattareId}")]

    public partial class FörfattareBöcker
    {
        public int FörfattareId { get; set; }
        public long Isbn { get; set; }

        public virtual Författare Författare { get; set; }
        public virtual Böcker IsbnFörfattare { get; set; }
    }
}
