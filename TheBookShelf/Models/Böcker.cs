using System;
using System.Collections.Generic;

#nullable disable

namespace TheBookShelf
{
    public partial class Böcker
    {
        public Böcker()
        {
            FörfattareBöckers = new HashSet<FörfattareBöcker>();
            LagerSaldos = new HashSet<LagerSaldo>();
        }

        public Böcker(
            long isbn,
            string titel,
            DateTime utgivningsdatum,
            int pris,
            int genreId,
            int sidor,
            int förlagsId,
            int vikt,
            string format,
            string språk,
            int? betygAvNiclas = null,
            int? översättareId = null,
            string originaltitel = null)
        {
            FörfattareBöckers = new HashSet<FörfattareBöcker>();
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
        public virtual ICollection<FörfattareBöcker> FörfattareBöckers { get; set; }
        public virtual ICollection<LagerSaldo> LagerSaldos { get; set; }

        public override string ToString()
        {
            return Titel; 
        }
    }
}
