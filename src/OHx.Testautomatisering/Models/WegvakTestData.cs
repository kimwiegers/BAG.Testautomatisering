using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;

namespace OHx.Testautomatisering.Testdata
{
    public class WegvakTestData
    {
        public long WegvakId { get; set; }
        public string OudeGemeente { get; set; }
        public string NieuweGemeente { get; set; }
        public short OudGemeenteId { get; set; }
        public short NieuwGemeenteId { get; set; }
        public int OudStraatId { get; set; }
        public int NieuwStraatId { get; set; }
        public short OudWegbeheerderId { get; set; }
        public short NieuwWegbeheerderId { get; set; }
        public string WegbeheerderSoort { get; set; }
        public string OudeStraatnaam { get; set; }
        public string NieuweStraatnaam { get; set; }
        public int AantalHectopunten { get; set; }
        public DateTime OudeBegindatumWerkelijk { get; set; } = new DateTime(2018, 6, 1);
        public DateTime OudeBegindatumVastlegging { get; set; } = new DateTime(2018, 1, 1);
        public DateTime OudeEinddatumWerkelijk { get; set; } = new DateTime(2018, 12, 31);
        public DateTime NieuweBegindatumWerkelijk { get; set; } = new DateTime(2019, 1, 1);
    }
}
