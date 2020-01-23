using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fit;
using System.Data;

namespace FitnesseTests
{
    public class KierownikWyswietlPojazdy : ColumnFixture
    {
        public DataSet WyswietlPojazdy()
        {

            DataSet ds = SetUpKierownik.kierownik.Wyswietl_spis_pojazdow();

            return ds;
        }

    }
}
