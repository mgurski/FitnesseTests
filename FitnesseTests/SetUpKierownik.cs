using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_logic_layer.Users;
using Business_logic_layer.Users.Model;
using fitlibrary;

namespace FitnesseTests
{
    public class SetUpKierownik : DoFixture
    {
        public static Kierownik kierownik;

        public SetUpKierownik()
        {
            kierownik = new Kierownik();

            Zajezdnia zajezdnia = new Zajezdnia("1", "20", "Testowa", "Testy");

            Pojazd pojazd = new Pojazd("1", "33", "001", zajezdnia);

            List<Pojazd> pojazdy = new List<Pojazd>();

            pojazdy.Add(pojazd);

            pojazd = new Pojazd("2", "10", "002", zajezdnia);

            pojazdy.Add(pojazd);

            pojazd = new Pojazd("3", "A", "003", zajezdnia);

            pojazdy.Add(pojazd);

            pojazd = new Pojazd("4", "AH", "004", zajezdnia);

            pojazdy.Add(pojazd);

            pojazd = new Pojazd("5", "X10", "005", zajezdnia);

            pojazdy.Add(pojazd);

            kierownik.Pojazdy = pojazdy;

        }

    }
}
