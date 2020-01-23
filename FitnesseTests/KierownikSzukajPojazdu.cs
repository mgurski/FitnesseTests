using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fit;
using Business_logic_layer.Users.Model;
using System.Data;


namespace FitnesseTests
{

    public class KierownikSzukajPojazdu : ColumnFixture
    {

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
