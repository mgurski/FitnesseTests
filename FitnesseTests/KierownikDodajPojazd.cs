using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fit;

namespace FitnesseTests
{
    public class KierownikDodajPojazd : ColumnFixture
    {

        public List<string> dane;

        public string DodajPojazd() {

            string answer = SetUpKierownik.kierownik.Dodaj_pojazd(dane[0], dane[1], dane[2], dane[3]);

            return answer;
        }


        public int GetIloscPojazdow()
        {
            int ilosc = SetUpKierownik.kierownik.Pojazdy.Count();

            return ilosc;
        }

    }
}
