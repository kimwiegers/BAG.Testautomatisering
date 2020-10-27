using FluentAssertions;
using OHx.Testautomatisering.Data;
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
            int nieuwStraatId, short nieuwWegbeheerderId)
        {
            var wegvakEfemeridenInsert = GetWegvakInsertData(wegvakId);
            var nieuwWegvak = wegvakEfemeridenInsert.SingleOrDefault(x => x.GmeId == nieuwGemeenteId);

            nieuwWegvak.BegindatumWerkelijk.Should().Be(nieuweBegindatumWerkelijk);
            nieuwWegvak.EinddatumWerkelijk.Should().BeNull();
            nieuwWegvak.SttId.Should().Be(nieuwStraatId);
            nieuwWegvak.WbrId.Should().Be(nieuwWegbeheerderId);
        }

        public void CheckOudWegvakEfemeridenInsert(long wegvakId, short oudGemeenteId, DateTime OudeBegindatumWerkelijk,
            DateTime OudeEinddatumWerkelijk, int oudStraatId, short oudWegbeheerderId)
        {
            var wegvakEfemeridenInsert = GetWegvakInsertData(wegvakId);
            var oudWegvak = wegvakEfemeridenInsert.SingleOrDefault(x => x.GmeId == oudGemeenteId);

            oudWegvak.BegindatumWerkelijk.Should().Be(OudeBegindatumWerkelijk);
            oudWegvak.EinddatumWerkelijk.Should().Be(OudeEinddatumWerkelijk);
            oudWegvak.SttId.Should().Be(oudStraatId);
            oudWegvak.WbrId.Should().Be(oudWegbeheerderId);
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
            int nieuwStraatId, short nieuwGemeenteId, DateTime bagUpdateDatum)
        {
            var wegvakEfemeriden = GetWegvakEfemeriden(wegvakId);

            var nieuwWegvak = wegvakEfemeriden.SingleOrDefault(x => x.BegindatumWerkelijk == nieuweBegindatumWerkelijk);
            nieuwWegvak.WbrId.Should().Be(nieuwWegbeheerderId);
            nieuwWegvak.SttId.Should().Be(nieuwStraatId);
            nieuwWegvak.GmeId.Should().Be(nieuwGemeenteId);
            nieuwWegvak.BegindatumVastlegging.Should().Be(bagUpdateDatum);
            nieuwWegvak.EinddatumWerkelijk.Should().BeNull();
            nieuwWegvak.EinddatumVastlegging.Should().BeNull();
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

        public int GetStraatId(string straatNaam, int gemeenteId)
        {
            var straat = _nwwDbContext.GgaStraten.Where(x => x.Naam == straatNaam && x.GmeId == gemeenteId).ToList();

            if (straat.Count() == 0)
            {
                throw new Exception($"Er is geen record gevonden in gga_straten voor de straat {straatNaam} in de gemeente met id {gemeenteId}");
            }

            return straat[0].Id;
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

            if (efnInsert.Count() == 0)
            {
                throw new Exception($"Er is geen record gevonden in wegvak_efn_diff voor wegvak {wegvakId}");
            }

            return efnInsert;
        }

        private List<NwwWegvakEfemeriden> GetWegvakEfemeriden(long wegvakId)
        {
            var wegvakEfemeride = _nwwDbContext.NwwWegvakEfemeriden.Where(x => x.WvkId == wegvakId).ToList();

            if (wegvakEfemeride.Count() != 3)
            {
                throw new Exception($"Er zijn geen 3 records gevonden in nww_wegvak_efemeriden voor wegvak {wegvakId}");
            }

            return wegvakEfemeride;
        }
        private OhxBagNwwWegvakEfnU GetWegvakUpdateData(long wegvakId)
        {
            var efnUpdate = _ohxSchrijfDbContext.OhxBagNwwWegvakEfnU.Where(x => x.WvkId == wegvakId).ToList();

            if (efnUpdate.Count() == 0)
            {
                throw new Exception($"Er is geen record in wegvak_efn_U voor wegvak {wegvakId}");
            }

            return efnUpdate[0];
        }
    }
}
