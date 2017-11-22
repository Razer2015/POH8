using System.Collections.Generic;

namespace POH5Luokat
{
    public class Tuote : IId, INimi
    {
        public int Id { get; private set; }
        public string Nimi { get; set; }

        public int? ToimittajaId { get; set; }
        public int? RyhmaId { get; set; }
        public string YksikkoKuvaus { get; set; }
        public decimal? YksikkoHinta { get; set; }
        public short? VarastoSaldo { get; set; }
        public short? TilausSaldo { get; set; }
        public short? HalytysRaja { get; set; }
        public bool EiKaytossa { get; set; }

        public virtual Toimittaja Toimittaja { get; set; }
        public virtual TuoteRyhma Ryhma { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Tuote() {
            Toimittaja = null;
            Ryhma = null;
        }

        /// <summary>
        /// Additional Constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nimi"></param>
        public Tuote(int id, string nimi) : this() {
            this.Id = id;
            this.Nimi = nimi;
        }

        public override string ToString() {
            return ($"{Id} {Nimi}");
        }
    }
}
