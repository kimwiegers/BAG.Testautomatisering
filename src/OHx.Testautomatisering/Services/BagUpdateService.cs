using FluentAssertions;
using OHx.Testautomatisering.NWADB;
using OHx.Testautomatisering.NWWDB;
using OHx.Testautomatisering.OHX_SCHRIJFDB;
using OHx.Testautomatisering.Testdata;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OHx.Testautomatisering.Services
{
    public class BagUpdateService : IBagUpdateService
    {
        private readonly OhxSchrijfDbContext _ohxSchrijfDbContext;
        private readonly NwaDbContext _nwaDbContext;
        private readonly NwwDbContext _nwwDbContext;
        private readonly WegvakTestData _wegvakTestData;

        public BagUpdateService(OhxSchrijfDbContext ohxSchrijfDbContext, NwaDbContext nwaDbContext, NwwDbContext nwwDbContext,
            WegvakTestData wegvakTestData)
        {
            _ohxSchrijfDbContext = ohxSchrijfDbContext;
            _nwaDbContext = nwaDbContext;
            _nwwDbContext = nwwDbContext;
            _wegvakTestData = wegvakTestData;
        }

        public void CheckWegvakEfemeridenDiff(long wegvakId, short nieuwGemeenteId, short oudGemeenteId, DateTime begindatumVastlegging, DateTime begindatumWerkelijkheid)
        {
            var wegvakEfemeridenDiff = GetWegvakDiffData(wegvakId);

            wegvakEfemeridenDiff.NewGmeId.Should().Be(nieuwGemeenteId);
            wegvakEfemeridenDiff.OldGmeId.Should().Be(oudGemeenteId);
            wegvakEfemeridenDiff.BegindatumVastlegging.Should().Be(begindatumVastlegging);
            wegvakEfemeridenDiff.BegindatumWerkelijk.Should().Be(begindatumWerkelijkheid);
        }

        public void CheckNieuwWegvakEfemeridenInsert(long wegvakId, short nieuwGemeenteId, DateTime nieuweBegindatumWerkelijk, 
            int nieuwStraatId, short nieuwWegbeheerderId, string wegbeheerderSoort)
        {
            var wegvakEfemeridenInsert = GetWegvakInsertData(wegvakId);
            var nieuwWegvak = wegvakEfemeridenInsert.SingleOrDefault(x => x.GmeId == nieuwGemeenteId);

            nieuwWegvak.BegindatumWerkelijk.Should().Be(nieuweBegindatumWerkelijk);
            nieuwWegvak.EinddatumWerkelijk.Should().BeNull();
            nieuwWegvak.SttId.Should().Be(nieuwStraatId);
            nieuwWegvak.WbrId.Should().Be(nieuwWegbeheerderId);
            nieuwWegvak.Wegbeheerdersoort.Should().Be(wegbeheerderSoort);
        }

        public void CheckOudWegvakEfemeridenInsert(long wegvakId, short oudGemeenteId, DateTime OudeBegindatumWerkelijk,
            DateTime OudeEinddatumWerkelijk, int oudStraatId, short oudWegbeheerderId, string wegbeheerderSoort)
        {
            var wegvakEfemeridenInsert = GetWegvakInsertData(wegvakId);
            var oudWegvak = wegvakEfemeridenInsert.SingleOrDefault(x => x.GmeId == oudGemeenteId);

            oudWegvak.BegindatumWerkelijk.Should().Be(OudeBegindatumWerkelijk);
            oudWegvak.EinddatumWerkelijk.Should().Be(OudeEinddatumWerkelijk);
            oudWegvak.SttId.Should().Be(oudStraatId);
            oudWegvak.WbrId.Should().Be(oudWegbeheerderId);
            oudWegvak.Wegbeheerdersoort.Should().Be(wegbeheerderSoort);
        }
        public void CheckWegvakEfemeridenUpdate(long wegvakId, DateTime begindatumWerkelijkOud,
             DateTime begindatumVastleggingOud)
        {
            var wegvakEfemeridenUpdate = GetWegvakUpdateData(wegvakId);

            wegvakEfemeridenUpdate.BegindatumWerkelijk.Should().Be(begindatumWerkelijkOud);
            wegvakEfemeridenUpdate.BegindatumVastlegging.Should().Be(begindatumVastleggingOud);
        }

        public void CheckOudeWegvakkenNwwWegvakEfemeriden(long wegvakId, DateTime oudeBegindatumVastlegging, short oudWegbeheerderId, 
            short oudGemeenteId, int oudStraatId, DateTime oudBegindatumWerkelijk, DateTime oudeEinddatumWerkelijk, DateTime bagUpdateDatum)
        {
            var wegvakEfemeriden = GetWegvakEfemeriden(wegvakId);

            if (wegvakEfemeriden.Count() != 3)
            {
                throw new Exception($"Er zijn geen 3 records gevonden in nww_wegvak_efemeriden voor wegvak {wegvakId}");
            }

            var oudWegvakEindVastlegging = wegvakEfemeriden.SingleOrDefault(x => x.EinddatumVastlegging == bagUpdateDatum.AddDays(-1));
            oudWegvakEindVastlegging.WbrId.Should().Be(oudWegbeheerderId);
            oudWegvakEindVastlegging.SttId.Should().Be(oudStraatId);
            oudWegvakEindVastlegging.GmeId.Should().Be(oudGemeenteId);
            oudWegvakEindVastlegging.BegindatumVastlegging.Should().Be(oudeBegindatumVastlegging);
            oudWegvakEindVastlegging.BegindatumWerkelijk.Should().Be(oudBegindatumWerkelijk);
            oudWegvakEindVastlegging.EinddatumWerkelijk.Should().BeNull();

            var oudWegvakEindWerkelijk = wegvakEfemeriden.SingleOrDefault(x => x.EinddatumWerkelijk == oudeEinddatumWerkelijk);
            oudWegvakEindWerkelijk.WbrId.Should().Be(oudWegbeheerderId);
            oudWegvakEindWerkelijk.SttId.Should().Be(oudStraatId);
            oudWegvakEindWerkelijk.GmeId.Should().Be(oudGemeenteId);
            oudWegvakEindWerkelijk.BegindatumVastlegging.Should().Be(bagUpdateDatum);
            oudWegvakEindWerkelijk.BegindatumWerkelijk.Should().Be(oudBegindatumWerkelijk);
            oudWegvakEindWerkelijk.EinddatumVastlegging.Should().BeNull();
        }

        public void CheckNieuwWegvakNwwWegvakEfemeriden(long wegvakId, DateTime nieuweBegindatumWerkelijk, short nieuwWegbeheerderId,
            int nieuwStraatId, short nieuwGemeenteId, DateTime bagUpdateDatum, string wegbeheerderSoort)
        {
            var wegvakEfemeriden = GetWegvakEfemeriden(wegvakId);

            if (wegvakEfemeriden.Count() != 3)
            {
                throw new Exception($"Er zijn geen 3 records gevonden in nww_wegvak_efemeriden voor wegvak {wegvakId}");
            }

            var nieuwWegvak = wegvakEfemeriden.SingleOrDefault(x => x.BegindatumWerkelijk == nieuweBegindatumWerkelijk);
            nieuwWegvak.WbrId.Should().Be(nieuwWegbeheerderId);
            nieuwWegvak.SttId.Should().Be(nieuwStraatId);
            nieuwWegvak.GmeId.Should().Be(nieuwGemeenteId);
            nieuwWegvak.BegindatumVastlegging.Should().Be(bagUpdateDatum);
            nieuwWegvak.EinddatumWerkelijk.Should().BeNull();
            nieuwWegvak.EinddatumVastlegging.Should().BeNull();
            nieuwWegvak.Wegbeheerdersoort.Should().Be(wegbeheerderSoort);
        }

        public short GetGemeenteId(string gemeentenaam)
        {
            var gemeenten = _nwaDbContext.GgaGemeenten.Where(x => x.Naam == gemeentenaam).ToList();

            if (gemeenten.Count() == 0 || gemeenten.Count() > 1)
            {
                throw new Exception($"Er is geen record/er zijn meerdere records gevonden in gga_gemeenten voor gemeente {gemeentenaam}");
            }

            return gemeenten[0].Id;
        }

        public string GetStraattype(string straatNaam, short gemeenteId)
        {
            var straat = GetStraat(gemeenteId, straatNaam);

            return straat.SttType;
        }

        public int GetStraatId(string straatNaam, short gemeenteId)
        {
            var straat = GetStraat(gemeenteId, straatNaam);

            return straat.Id;
        }

        public bool IsStraatPresentInBagUpdateStratenInsert(string straatNaam, short gemeenteId)
        {
            var straat = _ohxSchrijfDbContext.OhxBagupdateGgaStratenI.Any(x => x.Naam == straatNaam && x.GmeId == gemeenteId);

            return straat;
        }

        public short GetWegbeheerderIdGemeente(string gemeente)
        {
            var gemeentenaam = "GEM " + gemeente;

            var wegbeheerder = _nwwDbContext.NwwWegbeheerders.Where(x => x.Naam == gemeentenaam).ToList();

            if (wegbeheerder.Count() == 0)
            {
                throw new Exception($"Er is geen record gevonden in nww_wegbeheerders voor de gemeente {gemeentenaam}");

            }

            return wegbeheerder[0].Id;
        }

        public void WegvakIsNietMeegenomenInBagUpdateCheck(long wegvakId)
        {
            var wegvakDiff = _ohxSchrijfDbContext.OhxBagNwwWegvakEfnDiff.Where(x => x.WvkId == wegvakId).ToList();
            wegvakDiff.Should().HaveCount(0);

            var wegvakInsert = _ohxSchrijfDbContext.OhxBagNwwWegvakEfnI.Where(x => x.WvkId == wegvakId).ToList();
            wegvakInsert.Should().HaveCount(0);

            var wegvakUpdate = _ohxSchrijfDbContext.OhxBagNwwWegvakEfnU.Where(x => x.WvkId == wegvakId).ToList();
            wegvakUpdate.Should().HaveCount(0);
        }

        public void CheckFoutmeldingWegvak(long wegvakId, string melding)
        {
            var efnMelding = _ohxSchrijfDbContext.OhxBagNwwWegvakEfnMelding.Where(x => x.WvkId == wegvakId).ToList();

            if (efnMelding.Count() == 0)
            {
                throw new Exception($"Er is geen record gevonden in efn_melding voor de wegvakId {wegvakId}");
            }

            efnMelding[0].Melding.Should().Contain(melding);
        }

        public string GetWegbeheerderSoortFromWegvakEfemeriden(long wegvakId)
        {
            var wegvakEfemeride = GetWegvakEfemeriden(wegvakId);

            return wegvakEfemeride[0].Wegbeheerdersoort;
        }

        public string GetWegbeheerderSoortFromWegbeheerder(short wegbeheerderId)
        {
            var wegbeheerder = _nwwDbContext.NwwWegbeheerders.Where(x => x.Id == wegbeheerderId).ToList();

            if (!wegbeheerder.Any())
            {
                throw new Exception($"Er is geen record gevonden in nww_wegbeheerders voor wegbeheerder met Id {wegbeheerderId}");
            }

            return wegbeheerder[0].Soort;
        }

        public short GetGemeenteIdFromStraten(string straatnaam)
        {
            var straat = _nwwDbContext.GgaStraten.Where(x => x.Naam == straatnaam).ToList();

            if (!straat.Any())
            {
                throw new Exception($"Er is geen record gevonden in gga_straten voor de straat {straatnaam}");
            }

            return straat[0].GmeId;
        }

        public short? GetGemeenteIdFromWegvakefemeriden(long wegvakId)
        {
            var wegvakefemeride = _nwwDbContext.NwwWegvakEfemeriden.Where(x => x.WvkId == wegvakId).ToList();

            if (!wegvakefemeride.Any())
            {
                throw new Exception($"Er is geen record gevonden in nww_wegvak_efemeriden voor wegvakId {wegvakId}");
            }

            return wegvakefemeride[0].GmeId;
        }

        public void CheckHectopuntenInHectopuntenInsert(long wegvakId, int aantalHectopunten, DateTime oudeBegindatumWerkelijk, 
            DateTime nieuweBegindatumWerkelijk)
        {
            var hectoputenInsert = GetHectopuntenInsertData(wegvakId);

            hectoputenInsert.Count().Should().Be(aantalHectopunten * 2);

            hectoputenInsert.Count(x => x.WeeBegindatumWerkelijk == oudeBegindatumWerkelijk).Should().Be(aantalHectopunten);
            hectoputenInsert.Count(x => x.WeeBegindatumWerkelijk == nieuweBegindatumWerkelijk).Should().Be(aantalHectopunten);
        }

        public void CheckHectointervallenInHectointervallenInsert(long wegvakId, int aantalHectointervallen, DateTime oudeBegindatumWerkelijk,
            DateTime nieuweBegindatumWerkelijk)
        {
            var hectointervallenInsert = GetHectointervallenInsertData(wegvakId);

            hectointervallenInsert.Count().Should().Be(aantalHectointervallen * 2);

            hectointervallenInsert.Count(x => x.BegindatumWerkelijk == oudeBegindatumWerkelijk).Should().Be(aantalHectointervallen);
            hectointervallenInsert.Count(x => x.BegindatumWerkelijk == nieuweBegindatumWerkelijk).Should().Be(aantalHectointervallen);
        }

        public void CheckRoutesInWegvakInRoutesInsert(long wegvakId, int aantalRoutes, DateTime oudeBegindatumWerkelijk,
            DateTime nieuweBegindatumWerkelijk)
        {
            var wegvakInRoutesInsert = GetWegvakInRoutesInsertData(wegvakId);

            wegvakInRoutesInsert.Count().Should().Be(aantalRoutes * 2);

            wegvakInRoutesInsert.Count(x => x.WeeBegindatumWerkelijk == oudeBegindatumWerkelijk).Should().Be(aantalRoutes);
            wegvakInRoutesInsert.Count(x => x.WeeBegindatumWerkelijk == nieuweBegindatumWerkelijk).Should().Be(aantalRoutes);
        }

        public void CheckHectopuntenInNwwHectopunten(long wegvakId, int aantalHectopunten, DateTime oudeBeginDatumWerkelijk, DateTime datumBagUpdate,
            DateTime oudeBegindatumVastlegging, DateTime nieuweBegindatumWerkelijk)
        {
            var hectopunten = GetNwwHectopuntenData(wegvakId);

            hectopunten.Count().Should().Be(aantalHectopunten * 3);

            hectopunten.Count(x => x.WeeBegindatumVastlegging == oudeBegindatumVastlegging && 
            x.WeeBegindatumWerkelijk == oudeBeginDatumWerkelijk).Should().Be(aantalHectopunten);
            hectopunten.Count(x => x.WeeBegindatumVastlegging == datumBagUpdate && 
            x.WeeBegindatumWerkelijk == oudeBeginDatumWerkelijk).Should().Be(aantalHectopunten);
            hectopunten.Count(x => x.WeeBegindatumVastlegging == datumBagUpdate &&
            x.WeeBegindatumWerkelijk == nieuweBegindatumWerkelijk).Should().Be(aantalHectopunten);
        }

        public void CheckHectointervallenInNwwHectointervallen(long wegvakId, int aantalHectointervallen, DateTime oudeBeginDatumWerkelijk, DateTime datumBagUpdate,
            DateTime oudeBegindatumVastlegging, DateTime nieuweBegindatumWerkelijk)
        {
            var hectointervallen = GetNwwHectointervallenData(wegvakId);

            hectointervallen.Count().Should().Be(aantalHectointervallen * 3);

            hectointervallen.Count(x => x.BegindatumVastlegging == oudeBegindatumVastlegging &&
            x.BegindatumWerkelijk == oudeBeginDatumWerkelijk).Should().Be(aantalHectointervallen);
            hectointervallen.Count(x => x.BegindatumVastlegging == datumBagUpdate &&
            x.BegindatumWerkelijk == oudeBeginDatumWerkelijk).Should().Be(aantalHectointervallen);
            hectointervallen.Count(x => x.BegindatumVastlegging == datumBagUpdate &&
            x.BegindatumWerkelijk == nieuweBegindatumWerkelijk).Should().Be(aantalHectointervallen);
        }

        public void CheckRoutesInNwwWegvakInRoutes(long wegvakId, int aantalRoutes, DateTime oudeBeginDatumWerkelijk, DateTime datumBagUpdate,
            DateTime oudeBegindatumVastlegging, DateTime nieuweBegindatumWerkelijk)
        {
            var routes = GetNwwWegvakInroutesData(wegvakId);

            routes.Count().Should().Be(aantalRoutes * 3);

            routes.Count(x => x.WeeBegindatumVastlegging == oudeBegindatumVastlegging &&
            x.WeeBegindatumWerkelijk == oudeBeginDatumWerkelijk).Should().Be(aantalRoutes);
            routes.Count(x => x.WeeBegindatumVastlegging == datumBagUpdate &&
            x.WeeBegindatumWerkelijk == oudeBeginDatumWerkelijk).Should().Be(aantalRoutes);
            routes.Count(x => x.WeeBegindatumVastlegging == datumBagUpdate &&
            x.WeeBegindatumWerkelijk == nieuweBegindatumWerkelijk).Should().Be(aantalRoutes);
        }

        private List<OhxBagNwwHectointervallenI> GetHectointervallenInsertData(long wegvakId)
        {
            var hectointervallenInsert = _ohxSchrijfDbContext.OhxBagNwwHectointervallenI.Where(x => x.WvkId == wegvakId).ToList();

            if (!hectointervallenInsert.Any())
            {
                throw new Exception($"Er is geen record gevonden voor wegvak id {wegvakId} in de nww_hectointervallen_i tabel");
            }

            return hectointervallenInsert;
        }

        private List<OhxBagNwwWegvakInRoutesI> GetWegvakInRoutesInsertData(long wegvakId)
        {
            var wegvakInRoutesInsert = _ohxSchrijfDbContext.OhxBagNwwWegvakInRoutesI.Where(x => x.WeeWvkId == wegvakId).ToList();

            if (!wegvakInRoutesInsert.Any())
            {
                throw new Exception($"Er is geen record gevonden voor wegvak id {wegvakId} in de nww_hectointervallen_i tabel");
            }

            return wegvakInRoutesInsert;
        }

        private List<NwwHectopunten> GetNwwHectopuntenData(long wegvakId)
        {
            var hectopunten = _nwwDbContext.NwwHectopunten.Where(x => x.WeeWvkId == wegvakId).ToList();

            if (!hectopunten.Any())
            {
                throw new Exception($"Er is geen record gevonden voor wegvak id {wegvakId} in de nww_hectopunten tabel");
            }

            return hectopunten;
        }

        private List<NwwHectoIntervallen> GetNwwHectointervallenData(long wegvakId)
        {
            var hectointervallen = _nwwDbContext.NwwHectoIntervallen.Where(x => x.WvkId == wegvakId).ToList();

            if (!hectointervallen.Any())
            {
                throw new Exception($"Er is geen record gevonden voor wegvak id {wegvakId} in de nww_hecto_intervallen tabel");
            }

            return hectointervallen;
        }

        private List<NwwWegvakInRoutes> GetNwwWegvakInroutesData(long wegvakId)
        {
            var routes = _nwwDbContext.NwwWegvakInRoutes.Where(x => x.WeeWvkId == wegvakId).ToList();

            if (!routes.Any())
            {
                throw new Exception($"Er is geen record gevonden voor wegvak id {wegvakId} in de nww_wegvak_in_routes tabel");
            }

            return routes;
        }

        private List<OhxBagNwwHectopuntenI> GetHectopuntenInsertData(long wegvakId)
        {
            var hectopuntenInsert = _ohxSchrijfDbContext.OhxBagNwwHectopuntenI.Where(x => x.WeeWvkId == wegvakId).ToList();

            if (!hectopuntenInsert.Any())
            {
                throw new Exception($"Er is geen record gevonden voor wegvak id {wegvakId} in de nww_hectopunten_i tabel");
            }

            return hectopuntenInsert;
        }

        private OhxBagNwwWegvakEfnDiff GetWegvakDiffData(long wegvakId)
        {
            var efnDiff = _ohxSchrijfDbContext.OhxBagNwwWegvakEfnDiff.Where(x => x.WvkId == wegvakId).ToList();

            if (efnDiff.Count() == 0 || efnDiff.Count() > 1)
            {
                throw new Exception($"Er is geen record/er zijn meerdere records gevonden in wegvak_efn_diff voor wegvak {wegvakId}");
            }

            return efnDiff[0];
        }

        private List<OhxBagNwwWegvakEfnI> GetWegvakInsertData(long wegvakId)
        {
            var efnInsert = _ohxSchrijfDbContext.OhxBagNwwWegvakEfnI.Where(x => x.WvkId == wegvakId).ToList();

            if (!efnInsert.Any())
            {
                throw new Exception($"Er is geen record gevonden in wegvak_efn_diff voor wegvak {wegvakId}");
            }

            return efnInsert;
        }

        private List<NwwWegvakEfemeriden> GetWegvakEfemeriden(long wegvakId)
        {
            var wegvakEfemeride = _nwwDbContext.NwwWegvakEfemeriden.Where(x => x.WvkId == wegvakId).ToList();

            if (!wegvakEfemeride.Any())
            {
                throw new Exception($"Er zijn geen 3 records gevonden in nww_wegvak_efemeriden voor wegvak {wegvakId}");
            }

            return wegvakEfemeride;
        }
        private OhxBagNwwWegvakEfnU GetWegvakUpdateData(long wegvakId)
        {
            var efnUpdate = _ohxSchrijfDbContext.OhxBagNwwWegvakEfnU.Where(x => x.WvkId == wegvakId).ToList();

            if (!efnUpdate.Any())
            {
                throw new Exception($"Er is geen record in wegvak_efn_U voor wegvak {wegvakId}");
            }

            return efnUpdate[0];
        }

        private GgaStraten GetStraat(short gemeenteId, string straatNaam)
        {
            var straat = _nwwDbContext.GgaStraten.Where(x => x.Naam == straatNaam && x.GmeId == gemeenteId).ToList();

            if (straat.Count() == 0)
            {
                throw new Exception($"Er is geen record gevonden in gga_straten voor de straat {straatNaam} in de gemeente met id {gemeenteId}");
            }

            return straat[0];
        }
    }
}
