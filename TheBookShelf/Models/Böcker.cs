﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

#nullable disable

namespace TheBookShelf
{
    [DebuggerDisplay("{Titel}")]

    public partial class Böcker
    {
        public Böcker()
        {
            LagerSaldos = new HashSet<LagerSaldo>();
        }

        public long Isbn { get; set; }
        public string Titel { get; set; }
        public DateTime Utgivningsdatum { get; set; }
        public int Pris { get; set; }
        public int GenreId { get; set; }
        public int Sidor { get; set; }
        public int? BetygAvNiclas { get; set; }
        public int FörlagsId { get; set; }
        public int? Vikt { get; set; }
        public int? ÖversättareId { get; set; }
        public string Format { get; set; }
        public string Originaltitel { get; set; }
        public string Språk { get; set; }

        public virtual Förlag Förlags { get; set; }
        public virtual Genrer Genre { get; set; }
        public virtual Översättare Översättare { get; set; }
        public virtual ICollection<LagerSaldo> LagerSaldos { get; set; }

        public virtual ICollection<FörfattareBöcker> Författare { get; set; }

    }
}
