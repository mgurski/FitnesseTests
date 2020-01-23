using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fit;

namespace FitnesseTests
{
    public class KierownikUsunPojazd : ColumnFixture
    {

        public string id_pojazdu;

        public bool UsunPojazd()
        {
            return SetUpKierownik.kierownik.Usun_pojazd(id_pojazdu);

        }

        public int GetIloscPojazdow()
        {
            int ilosc = SetUpKierownik.kierownik.Pojazdy.Count();

            return ilosc;
        }

    }
}
