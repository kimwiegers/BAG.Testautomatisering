using OHx.Testautomatisering.NWWDB;
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
             DateTime OudeEinddatumWerkelijk, int oudStraatId, short oudWegbeheerderId, string wegbeheerderSoort);
        void CheckNieuwWegvakEfemeridenInsert(long wegvakId, short nieuwGemeenteId, DateTime nieuweBegindatumWerkelijk,
            int nieuwStraatId, short nieuwWegbeheerderId, string wegbeheerderSoort);
        void CheckWegvakEfemeridenUpdate(long wegvakId, DateTime begindatumWerkelijkOud,
             DateTime begindatumVastleggingOud);
        void CheckNieuwWegvakNwwWegvakEfemeriden(long wegvakId, DateTime nieuweBegindatumWerkelijk, short nieuwWegbeheerderId,
           int nieuwStraatId, short nieuwGemeenteId, DateTime bagUpdateDatum, string wegbeheerderSoort);
        void CheckOudeWegvakkenNwwWegvakEfemeriden(long wegvakId, DateTime oudeBegindatumVastlegging, short oudWegbeheerderId,
            short oudGemeenteId, int oudStraatId, DateTime oudBegindatumWerkelijk, DateTime oudeEinddatumWerkelijk, DateTime bagUpdateDatum);
        short GetWegbeheerderIdGemeente(string gemeente);
        short GetGemeenteId(string gemeentenaam);
        int GetStraatId(string straatNaam, short gemeenteId);
        void WegvakIsNietMeegenomenInBagUpdateCheck(long wegvakId);
        void CheckFoutmeldingWegvak(long wegvakId, string melding);
        string GetWegbeheerderSoortFromWegvakEfemeriden(long wegvakId);
        string GetWegbeheerderSoortFromWegbeheerder(short wegbeheerderId);
        string GetStraattype(string straatNaam, short gemeenteId);
        bool IsStraatPresentInBagUpdateStratenInsert(string straatNaam, short gemeenteId);
        short? GetGemeenteIdFromWegvakefemeriden(long wegvakId);
        short GetGemeenteIdFromStraten(string straatnaam);
        void CheckHectopuntenInHectopuntenInsert(long wegvakId, int aantalHectopunten, DateTime oudeBegindatumWerkelijk,
            DateTime nieuweBegindatumWerkelijk);
        void CheckHectopuntenInNwwHectopunten(long wegvakId, int aantalHectopunten, DateTime oudeBeginDatumWerkelijk, DateTime datumBagUpdate,
            DateTime oudeBegindatumVastlegging, DateTime nieuweBegindatumWerkelijk);
        void CheckHectointervallenInHectointervallenInsert(long wegvakId, int aantalHectointervallen, DateTime oudeBegindatumWerkelijk,
           DateTime nieuweBegindatumWerkelijk);
        void CheckHectointervallenInNwwHectointervallen(long wegvakId, int aantalHectointervallen, DateTime oudeBeginDatumWerkelijk, DateTime datumBagUpdate,
            DateTime oudeBegindatumVastlegging, DateTime nieuweBegindatumWerkelijk);
        void CheckRoutesInWegvakInRoutesInsert(long wegvakId, int aantalRoutes, DateTime oudeBegindatumWerkelijk,
            DateTime nieuweBegindatumWerkelijk);
        void CheckRoutesInNwwWegvakInRoutes(long wegvakId, int aantalRoutes, DateTime oudeBeginDatumWerkelijk, DateTime datumBagUpdate,
            DateTime oudeBegindatumVastlegging, DateTime nieuweBegindatumWerkelijk);
    }
}
