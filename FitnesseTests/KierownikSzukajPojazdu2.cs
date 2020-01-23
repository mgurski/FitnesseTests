using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fit;
using Business_logic_layer.Users.Model;

namespace FitnesseTests
{
    public class KierownikSzukajPojazdu2 : ColumnFixture
    {
        public List<string> dane;

        public string DodajPojazd()
        {

            string answer = SetUpKierownik.kierownik.Dodaj_pojazd(dane[0], dane[1], dane[2], dane[3]);

            return answer;
        }

        public string id_pojazdu;

        public string GetNumerPojazduSzukajPojazdu()
        {
            Pojazd pojazd = SetUpKierownik.kierownik.Szukaj_pojazdu(id_pojazdu);

            if (pojazd != null)
            {
                return pojazd.Numer_pojazdu;
            }
            return null;
        }

        public string GetIDPojazduSzukajPojazdu()
        {
            Pojazd pojazd = SetUpKierownik.kierownik.Szukaj_pojazdu(id_pojazdu);

            if (pojazd != null)
            {
                return pojazd.Id_pojazdu;
            }
            return null;
        }

    }
}
