﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

#nullable disable

namespace TheBookShelf
{
    [DebuggerDisplay("{Namn}")]

    public partial class Butiker
    {
        public Butiker()
        {
            Kunders = new HashSet<Kunder>();
            LagerSaldos = new HashSet<LagerSaldo>();
        }

        public int Id { get; set; }
        public string Namn { get; set; }
        public string Adress { get; set; }
        public string Stad { get; set; }
        public string Land { get; set; }

        public virtual ICollection<Kunder> Kunders { get; set; }
        public virtual ICollection<LagerSaldo> LagerSaldos { get; set; }
    }
}
