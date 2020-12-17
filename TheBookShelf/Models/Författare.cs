using System;
using System.Collections.Generic;
using System.Diagnostics;

#nullable disable

namespace TheBookShelf
{
    [DebuggerDisplay("{Förnamn} {Efternamn}")]

    public partial class Författare
    {
        public int Id { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public DateTime Födelsedatum { get; set; }
        public string Kön { get; set; }
        public string Nationalitet { get; set; }
    }
}
