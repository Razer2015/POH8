using POH5Luokat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POH8Data
{
    public class ToimittajaRepository : IRepository<Toimittaja>
    {
        DataContext _dc = new DataContext();

        public Toimittaja Hae(int id) {
            return (_dc.Toimittajat.Where(r => r.Id == id).SingleOrDefault());
        }

        public List<Toimittaja> HaeKaikki() {
            return (_dc.Toimittajat.ToList());
        }

        public bool Lisaa(Toimittaja o) {
            _dc.Toimittajat.Add(o);
            return (_dc.SaveChanges() == 1);
        }

        public bool Muuta(Toimittaja o) {
            var muutettava = Hae(o.Id);
            muutettava.Nimi = o.Nimi;
            muutettava.YhteysHenkilo = o.YhteysHenkilo;
            muutettava.YhteysTitteli = o.YhteysTitteli;
            muutettava.Katuosoite = o.Katuosoite;
            muutettava.Kaupunki = o.Kaupunki;
            muutettava.PostiKoodi = o.PostiKoodi;
            muutettava.Maa = o.Maa;
            return (_dc.SaveChanges() == 1);
        }

        public bool Poista(int id) {
            _dc.Toimittajat.Remove(_dc.Toimittajat.FirstOrDefault(x => x.Id == id));
            return (_dc.SaveChanges() == 1);
        }
    }
}
