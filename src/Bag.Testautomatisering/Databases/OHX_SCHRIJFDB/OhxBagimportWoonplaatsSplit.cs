using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.OHX_SCHRIJFDB
{
    public partial class OhxBagimportWoonplaatsSplit
    {
        public decimal? Id { get; set; }
        public string Identificatie { get; set; }
        public string Gemcode { get; set; }
        public string Gemnaam { get; set; }
        public string Status { get; set; }
        public string Naam { get; set; }
        public DateTime? Begindatumtijdvakgeldigheid { get; set; }
        public DateTime? Einddatumtijdvakgeldigheid { get; set; }
        public string Inonderzoek { get; set; }
        public string Documentnummer { get; set; }
        public DateTime? Documentdatum { get; set; }
        public string IndicatieGeconstateerd { get; set; }
        public string AanduidingInactief { get; set; }
        public decimal? AanduidingCorrectie { get; set; }
        public string Key { get; set; }
        public DateTime? Mutatiedatum { get; set; }
    }
}
