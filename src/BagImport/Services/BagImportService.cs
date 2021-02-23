using FluentAssertions;
using OHx.Testautomatisering.NWADB;
using OHx.Testautomatisering.NWWDB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BagImport.Testautomatisering.Services
{
    public class BagImportService : IBagImportService
    {
        private readonly NwaDbContext _nwaDbContext;
        private readonly NwwDbContext _nwwDbContext;
        public BagImportService(NwaDbContext nwaDbContext, NwwDbContext nwwDbContext)
        {
            _nwaDbContext = nwaDbContext;
            _nwwDbContext = nwwDbContext;
        }

        public string GetStraatType(string straatnaamOfficieel, int woonplaatsId, int gemeenteId)
        {
            var straat = _nwwDbContext.GgaStraten.Where(x => x.NaamOfficieel == straatnaamOfficieel
            && x.WpsId == woonplaatsId && x.GmeId == gemeenteId).ToList();

            if (!straat.Any())
            {
                throw new Exception($"Er is geen record gevonden in gga_straten voor {straatnaamOfficieel}");
            }

            return straat[0].SttType;
        }

        public string GetStraatnaamOfficieel(string bagId)
        {
            var straat = _nwwDbContext.GgaStraten.Where(x => x.BagId == bagId).ToList();

            if (!straat.Any())
            {
                throw new Exception($"Er is geen record gevonden in gga_straten voor bagId {bagId}");
            }

            return straat[0].NaamOfficieel;
        }

        public int GetWoonplaatsId(string woonplaatsNaam)
        {
            var woonplaats = _nwaDbContext.GgaWoonplaatsen.Where(x => x.NaamOfficieel == woonplaatsNaam).ToList();

            if (!woonplaats.Any())
            {
                return 0;
            }

            return woonplaats[0].Id;
        }

        public int GetWoonplaatsId(string woonplaatsNaam, int gemeenteId)
        {
            var woonplaats = _nwaDbContext.GgaWoonplaatsen.Where(x => x.NaamOfficieel == woonplaatsNaam && x.GmeId == gemeenteId).ToList();

            if (!woonplaats.Any())
            {
                return 0;
            }

            return woonplaats[0].Id;
        }

        public int GetWoonplaatsIdFromGgaStraten(string straatnaam, int gemeenteId)
        {
            var woonplaats = _nwwDbContext.GgaStraten.Where(x => x.NaamOfficieel == straatnaam && x.GmeId == gemeenteId).ToList();

            if (!woonplaats.Any())
            {
                return 0;
            }

            return woonplaats[0].WpsId;
        }

        public GgaWoonplaatsen GetWoonplaatsData(string woonplaatsNaam)
        {
            var woonplaats = _nwaDbContext.GgaWoonplaatsen.Where(x => x.NaamOfficieel == woonplaatsNaam).ToList();

            if (!woonplaats.Any())
            {
                throw new Exception($"Geen woonplaats gevonden voor {woonplaatsNaam}");
            }

            return woonplaats[0];
        }

        public bool BestaatCombinatieWoonplaatsEnGemeente(int gemeenteId, int woonplaatsId)
        {
            var woonplaats = _nwaDbContext.GgaWoonplaatsen.Where(x => x.Id == woonplaatsId && x.GmeId == gemeenteId).ToList();

            if (!woonplaats.Any())
            {
                return false;
            }

            return true;
        }

        public GgaStraten GetStraatData(string straatnaam, int gemeenteId, int woonplaatsId)
        {
            var straat = _nwwDbContext.GgaStraten.Where(x => x.Naam == straatnaam && x.GmeId == gemeenteId &&
             x.WpsId == woonplaatsId).ToList();

            if (!straat.Any())
            {
                throw new Exception($"Geen record gevonden voor straat {straatnaam}");
            }

            return straat[0];
        }

        public GgaStraten GetStraatData(string bagId)
        {
            var straat = _nwwDbContext.GgaStraten.Where(x => x.BagId == bagId).ToList();

            if (!straat.Any())
            {
                throw new Exception($"Geen record gevonden voor bagId {bagId}");
            }

            return straat[0];
        }

        public List<GgaStraten> GetListOfStratenBelongingToSpecificGemeenteAndWoonplaats(int gemeenteId, int woonplaatsId)
        {
            var straten = _nwwDbContext.GgaStraten.Where(x => x.GmeId == gemeenteId && x.WpsId == woonplaatsId).ToList();

            if (!straten.Any())
            {
                throw new Exception($"Geen straten gevonden onder gemeenteId {gemeenteId} en woonplaatsId {woonplaatsId}");
            }

            List<GgaStraten> stratenMetBagId = new List<GgaStraten>();

            foreach (var straat in straten)
            {
                if (straat.BagId != null && straat.BagId != "")
                {
                    stratenMetBagId.Add(straat);
                }
            }

            return stratenMetBagId;
        }

        public List<GgaStraten> GetListOfStratenBelongingToSpecificGemeente(int gemeenteId)
        {
            var straten = _nwwDbContext.GgaStraten.Where(x => x.GmeId == gemeenteId).ToList();

            if (!straten.Any())
            {
                throw new Exception($"Geen straten gevonden onder gemeenteId {gemeenteId}");
            }

            List<GgaStraten> stratenMetBagId = new List<GgaStraten>();

            foreach(var straat in straten)
            {
                if (straat.BagId != null && straat.BagId != "")
                {
                    stratenMetBagId.Add(straat);
                }
            }

            return stratenMetBagId;
        }
    }
}
