using System.Collections.Generic;

namespace POH8Data
{
    public interface IRepository<T>
    {
        bool Lisaa(T o);
        bool Poista(int id);
        bool Muuta(T o);

        T Hae(int id);

        List<T> HaeKaikki();
    }
}
