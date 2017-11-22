using POH5Luokat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POH8Data
{
    public class TuoteRyhmaRepository : IRepository<TuoteRyhma>
    {
        DataContext _dc = new DataContext();

        public TuoteRyhma Hae(int id) {
            return (_dc.Ryhmat.Where(r => r.Id == id).SingleOrDefault());
        }

        public List<TuoteRyhma> HaeKaikki() {
            return (_dc.Ryhmat.ToList());
        }

        public bool Lisaa(TuoteRyhma o) {
            _dc.Ryhmat.Add(o);
            return (_dc.SaveChanges() == 1);
        }

        public bool Muuta(TuoteRyhma o) {
            var muutettava = Hae(o.Id);
            muutettava.Nimi = o.Nimi;
            muutettava.Kuvaus = o.Kuvaus;
            return (_dc.SaveChanges() == 1);
        }

        public bool Poista(int id) {
            _dc.Ryhmat.Remove(_dc.Ryhmat.FirstOrDefault(x => x.Id == id));
            return (_dc.SaveChanges() == 1);
        }
    }
}
