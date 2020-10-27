using OHx.Testautomatisering.OHX_SCHRIJFDB;
using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.Services
{
    public interface IBagUpdateService
    {
        void CheckWegvakEfemeridenDiff(long wegvakId, short nieuwGemeenteId, short oudGemeenteId, 
            DateTime begindatumVastlegging, DateTime begindatumWerkelijkheid);
        void CheckOudWegvakEfemeridenInsert(long wegvakId, short oudGemeenteId, DateTime OudeBegindatumWerkelijk,
             DateTime OudeEinddatumWerkelijk, int oudStraatId, short oudWegbeheerderId);
        void CheckNieuwWegvakEfemeridenInsert(long wegvakId, short nieuwGemeenteId, DateTime nieuweBegindatumWerkelijk,
            int nieuwStraatId, short nieuwWegbeheerderId);
        void CheckWegvakEfemeridenUpdate(long wegvakId, DateTime begindatumWerkelijkOud,
             DateTime begindatumVastleggingOud);
        void CheckNieuwWegvakNwwWegvakEfemeriden(long wegvakId, DateTime nieuweBegindatumWerkelijk, short nieuwWegbeheerderId,
           int nieuwStraatId, short nieuwGemeenteId, DateTime bagUpdateDatum);
        void CheckOudeWegvakkenNwwWegvakEfemeriden(long wegvakId, DateTime oudeBegindatumVastlegging, short oudWegbeheerderId,
            short oudGemeenteId, int oudStraatId, DateTime oudBegindatumWerkelijk, DateTime oudeEinddatumWerkelijk, DateTime bagUpdateDatum);
        short GetWegbeheerderIdGemeente(string gemeente);
        short GetGemeenteId(string gemeentenaam);
        int GetStraatId(string straatNaam, int gemeenteId);
    }
}
