using FluentAssertions;
using OHx.Testautomatisering.Services;
using OHx.Testautomatisering.Testdata;
using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace OHx.Testautomatisering.Steps
{
    [Binding]
    class BAGUpdateSteps
    {
        private readonly IBagUpdateService _bagUpdateService;
        private readonly WegvakTestData _wegvakData;
        private static DateTime DatumBagUpdate = new DateTime(2020, 10, 27);

        public BAGUpdateSteps(IBagUpdateService bagUpdateService, WegvakTestData wegvakData)
        {
            _bagUpdateService = bagUpdateService;
            _wegvakData = wegvakData;
        }

        [Given(@"een gebruiker de grens van de gemeente '(.*)' heeft aangepast waardoor het wegvak met id (.*) onder gemeente '(.*)' komt te vallen")]
        public void GegevenEenGebruikerDeGrensVanDeGemeenteHeeftAangepastWaardoorHetWegvakMetIdOnderGemeenteKomtTeVallen(string oudeGemeente, long wegvakId, string nieuweGemeente)
        {
            var oudGemeenteId = _bagUpdateService.GetGemeenteId(oudeGemeente);
            var nieuwGemeenteId = _bagUpdateService.GetGemeenteId(nieuweGemeente);
            _wegvakData.WegvakId = wegvakId;
            _wegvakData.OudeGemeente = oudeGemeente;
            _wegvakData.OudGemeenteId = oudGemeenteId;
            _wegvakData.NieuweGemeente = nieuweGemeente;
            _wegvakData.NieuwGemeenteId = nieuwGemeenteId;
        }


        [Given(@"het wegvak verschuift door de aanpassing van de straat '(.*)' in '(.*)' naar '(.*)' in '(.*)'")]
        public void GegevenHetWegvakVerschuiftDoorDeAanpassingVanDeStraatInNaarIn(string oudeStraat, string oudeGemeente, string nieuweStraat, string nieuweGemeente)
        {
            var oudStraatId = _bagUpdateService.GetStraatId(oudeStraat, _wegvakData.OudGemeenteId);
            var nieuwStraatId = _bagUpdateService.GetStraatId(nieuweStraat, _wegvakData.NieuwGemeenteId);

            _wegvakData.OudStraatId = oudStraatId;
            _wegvakData.NieuwStraatId = nieuwStraatId;
        }

        [Given(@"'(.*)' is de wegbeheerder")]
        public void GegevenIsDeWegbeheerder(string wegbeheerder)
        {
            switch(wegbeheerder)
            {
                case "de gemeente":
                    _wegvakData.OudWegbeheerderId = _bagUpdateService.GetGemeenteId(_wegvakData.OudeGemeente);
                    _wegvakData.NieuwWegbeheerderId = _bagUpdateService.GetGemeenteId(_wegvakData.NieuweGemeente);
                    break;
                default:
                    throw new Exception($"{wegbeheerder} is niet geimplementeerd als wegbeheerder optie");
            }
        }

        [When(@"de Bag Update is afgerond")]
        public void AlsDeBagUpdateIsAfgerond()
        {
            //eventueel later aftrappen job toevoegen o.i.d.
        }

        [Then(@"is het wegvak meegenomen in de BAG update")]
        public void DanIsHetWegvakMeegenomenInDeBAGUpdate()
        {
            _bagUpdateService.CheckWegvakEfemeridenDiff(_wegvakData.WegvakId, _wegvakData.NieuwGemeenteId, 
                _wegvakData.OudGemeenteId, _wegvakData.OudeBegindatumVastlegging, _wegvakData.OudeBegindatumWerkelijk);

            _bagUpdateService.CheckOudWegvakEfemeridenInsert(_wegvakData.WegvakId, _wegvakData.OudGemeenteId, _wegvakData.OudeBegindatumWerkelijk,
                _wegvakData.OudeEinddatumWerkelijk,_wegvakData.OudStraatId, _wegvakData.OudWegbeheerderId);

            _bagUpdateService.CheckNieuwWegvakEfemeridenInsert(_wegvakData.WegvakId, _wegvakData.NieuwGemeenteId, _wegvakData.NieuweBegindatumWerkelijk,
                _wegvakData.NieuwStraatId, _wegvakData.NieuwWegbeheerderId);

            _bagUpdateService.CheckWegvakEfemeridenUpdate(_wegvakData.WegvakId, _wegvakData.OudeBegindatumWerkelijk, _wegvakData.OudeBegindatumVastlegging);
        }

        [Then(@"is het wegvak geupdatet in de NWW database")]
        public void DanIsHetWegvakGeupdatetInDeNWWDatabase()
        {
            _bagUpdateService.CheckOudeWegvakkenNwwWegvakEfemeriden(_wegvakData.WegvakId, _wegvakData.OudeBegindatumVastlegging, _wegvakData.OudWegbeheerderId, _wegvakData.OudGemeenteId, 
                _wegvakData.OudStraatId, _wegvakData.OudeBegindatumWerkelijk, _wegvakData.OudeEinddatumWerkelijk, DatumBagUpdate);

            _bagUpdateService.CheckNieuwWegvakEfemeridenInsert(_wegvakData.WegvakId, _wegvakData.NieuwGemeenteId, 
                _wegvakData.NieuweBegindatumWerkelijk, _wegvakData.NieuwStraatId, _wegvakData.NieuwWegbeheerderId);
        }
    }
}
