using POH5Luokat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POH8Data
{
    public class TuoteRepository : IRepository<Tuote>
    {
        DataContext _dc = new DataContext();

        public Tuote Hae(int id) {
            return (_dc.Tuotteet.Where(r => r.Id == id).SingleOrDefault());
        }

        public List<Tuote> HaeKaikki() {
            return (_dc.Tuotteet.ToList());
        }

        public bool Lisaa(Tuote o) {
            _dc.Tuotteet.Add(o);
            return (_dc.SaveChanges() == 1);
        }

        public bool Muuta(Tuote o) {
            var muutettava = Hae(o.Id);
            muutettava.Nimi = o.Nimi;
            muutettava.ToimittajaId = o.ToimittajaId;
            muutettava.RyhmaId = o.RyhmaId;
            muutettava.YksikkoKuvaus = o.YksikkoKuvaus;
            muutettava.YksikkoHinta = o.YksikkoHinta;
            muutettava.VarastoSaldo = o.VarastoSaldo;
            muutettava.TilausSaldo = o.TilausSaldo;
            muutettava.HalytysRaja = o.HalytysRaja;
            muutettava.EiKaytossa = o.EiKaytossa;
            return (_dc.SaveChanges() == 1);
        }

        public bool Poista(int id) {
            _dc.Tuotteet.Remove(_dc.Tuotteet.FirstOrDefault(x => x.Id == id));
            return (_dc.SaveChanges() == 1);
        }
    }
}
