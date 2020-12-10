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
            _wegvakData.OudeStraatnaam = oudeStraat;
            _wegvakData.NieuweStraatnaam = nieuweStraat;
        }

        [Given(@"de nieuwe straat is niet gevonden")]
        public void GegevenDeNieuweStraatIsNietGevonden()
        {
            _wegvakData.NieuwStraatId = _bagUpdateService.GetStraatId(_wegvakData.OudeStraatnaam, _wegvakData.NieuwGemeenteId);
        }

        [Given(@"'(.*)' is de wegbeheerder")]
        public void GegevenIsDeWegbeheerder(string wegbeheerder)
        {
            switch(wegbeheerder)
            {
                case "de gemeente":
                    _wegvakData.OudWegbeheerderId = _bagUpdateService.GetGemeenteId(_wegvakData.OudeGemeente);
                    _wegvakData.NieuwWegbeheerderId = _bagUpdateService.GetGemeenteId(_wegvakData.NieuweGemeente);
                    _wegvakData.WegbeheerderSoort = "G";
                    break;
                case "Berlijn":
                case "Sofia":
                case "Nicosia":
                case "Tallinn":
                    _wegvakData.OudWegbeheerderId = _bagUpdateService.GetGemeenteId(wegbeheerder);
                    _wegvakData.NieuwWegbeheerderId = _bagUpdateService.GetGemeenteId(wegbeheerder);
                    _wegvakData.WegbeheerderSoort = _bagUpdateService.GetWegbeheerderSoortFromWegbeheerder(_wegvakData.OudWegbeheerderId);
                    break;
                case "de provincie":
                    _wegvakData.OudWegbeheerderId = _bagUpdateService.GetGemeenteId(_wegvakData.OudeGemeente);
                    _wegvakData.NieuwWegbeheerderId = _bagUpdateService.GetGemeenteId(_wegvakData.OudeGemeente);
                    _wegvakData.WegbeheerderSoort = "P";
                    break;
                default:
                    throw new Exception($"{wegbeheerder} is niet geimplementeerd als wegbeheerder optie");
            }
        }

        [Given(@"de straat '(.*)' is nog niet bekend in BAG")]
        public void GegevenDeStraatIsNogNietBekendInBAG(string oudestraat)
        {
            //Deze stap eventueel gebruiken voor inserts
        }


        [Given(@"de wegbeheerdersoort staat onjuist in de wegvakken tabel")]
        public void GegevenDeWegbeheerdersoortStaatOnjuistInDeWegvakkenTabel()
        {
            var wegbeheerdersoortWegbeheerders = _bagUpdateService.GetWegbeheerderSoortFromWegbeheerder(_wegvakData.OudWegbeheerderId);
            var wegbeheerderSoortEfemeriden = _bagUpdateService.GetWegbeheerderSoortFromWegvakEfemeriden(_wegvakData.WegvakId);

            wegbeheerderSoortEfemeriden.Should().NotBeEquivalentTo(wegbeheerdersoortWegbeheerders);
        }

        [Given(@"een gebruiker de grens van de gemeente '(.*)' heeft aangepast waardoor het wegvak met id (.*) onder on onbekende gemeente komt te vallen")]
        public void GegevenEenGebruikerDeGrensVanDeGemeenteHeeftAangepastWaardoorHetWegvakMetIdOnderOnOnbekendeGemeenteKomtTeVallen(string gemeente, long wegvakId)
        {
            _wegvakData.WegvakId = wegvakId;
        }

        [Given(@"een gebruiker de grens van de gemeente '(.*)' heeft aangepast waardoor minder dan twee meter van het wegvak met id (.*) in de gemeente '(.*)' komt te liggen")]
        public void GegevenEenGebruikerDeGrensVanDeGemeenteHeeftAangepastWaardoorMinderDanTweeMeterVanHetWegvakMetIdInDeGemeenteKomtTeLiggen(string oudeGemeente, long wegvakId, string nieuweGemeente)
        {
            _wegvakData.WegvakId = wegvakId;
            _wegvakData.NieuwGemeenteId = _bagUpdateService.GetGemeenteId(nieuweGemeente);
        }

        [Given(@"de gemeente staat verkeerd in de wegvakken tabel")]
        public void GegevenDeGemeenteStaatVerkeerdInDeWegvakkenTabel()
        {
            var gemeenteIdStraten = _bagUpdateService.GetGemeenteIdFromStraten(_wegvakData.OudeStraatnaam);
            var gemeenteIdWegvakefemeriden = _bagUpdateService.GetGemeenteIdFromWegvakefemeriden(_wegvakData.WegvakId);

            gemeenteIdStraten.Should().NotBe(gemeenteIdWegvakefemeriden);
        }

        [Given(@"het wegvak heeft (.*) hectopunten")]
        public void GegevenHetWegvakHeeftHectopunten(int aantalHectopunten)
        {
            _wegvakData.AantalHectopunten = aantalHectopunten;
        }

        [Given(@"het wegvak heeft (.*) hectointerval")]
        public void GegevenHetWegvakHeeftHectointerval(int aantalhectointervallen)
        {
            _wegvakData.AantalHectointervallen = aantalhectointervallen;
        }

        [Given(@"het wegvak is onderdeel van (.*) routes")]
        public void GegevenHetWegvakIsOnderdeelVanRoutes(int aantalRoutes)
        {
            _wegvakData.AantalRoutes = aantalRoutes;
        }

        [When(@"de Bag Update is afgerond")]
        public void AlsDeBagUpdateIsAfgerond()
        {
            //eventueel later aftrappen job toevoegen o.i.d.
        }

        [Then(@"zijn de hectopunten meegenomen in de BAG update")]
        public void DanZijnDeHectopuntenMeegenomenInDeBAGUpdate()
        {
            _bagUpdateService.CheckHectopuntenInHectopuntenInsert(_wegvakData.WegvakId, _wegvakData.AantalHectopunten,
                _wegvakData.OudeBegindatumWerkelijk, _wegvakData.NieuweBegindatumWerkelijk);
        }

        [Then(@"zijn de hectointervallen meegenomen in de BAG update")]
        public void DanZijnDeHectointervallenMeegenomenInDeBAGUpdate()
        {
            _bagUpdateService.CheckHectointervallenInHectointervallenInsert(_wegvakData.WegvakId, _wegvakData.AantalHectointervallen,
               _wegvakData.OudeBegindatumWerkelijk, _wegvakData.NieuweBegindatumWerkelijk);
        }

        [Then(@"zijn de routes meegenomen in de BAG update")]
        public void DanZijnDeRoutesMeegenomenInDeBAGUpdate()
        {
            _bagUpdateService.CheckRoutesInWegvakInRoutesInsert(_wegvakData.WegvakId, _wegvakData.AantalRoutes,
                _wegvakData.OudeBegindatumWerkelijk, _wegvakData.NieuweBegindatumWerkelijk);
        }

        [Then(@"zijn de hectopunten geupdatet in de NWW database")]
        public void DanZijnDeHectopuntenGeupdatetInDeNWWDatabase()
        {
            _bagUpdateService.CheckHectopuntenInNwwHectopunten(_wegvakData.WegvakId, _wegvakData.AantalHectopunten,
                _wegvakData.OudeBegindatumWerkelijk, DatumBagUpdate, _wegvakData.OudeBegindatumVastlegging, _wegvakData.NieuweBegindatumWerkelijk);
        }

        [Then(@"zijn de hectointervallen geupdatet in de NWW database")]
        public void DanZijnDeHectointervallenGeupdatetInDeNWWDatabase()
        {
            _bagUpdateService.CheckHectointervallenInNwwHectointervallen(_wegvakData.WegvakId, _wegvakData.AantalHectointervallen,
               _wegvakData.OudeBegindatumWerkelijk, DatumBagUpdate, _wegvakData.OudeBegindatumVastlegging, _wegvakData.NieuweBegindatumWerkelijk);
        }

        [Then(@"zijn de routes geupdatet in de NWW database")]
        public void DanZijnDeRoutesGeupdatetInDeNWWDatabase()
        {
            _bagUpdateService.CheckRoutesInNwwWegvakInRoutes(_wegvakData.WegvakId, _wegvakData.AantalRoutes,
               _wegvakData.OudeBegindatumWerkelijk, DatumBagUpdate, _wegvakData.OudeBegindatumVastlegging, _wegvakData.NieuweBegindatumWerkelijk);
        }

        [Then(@"is het wegvak niet meegenomen in de BAG Update")]
        public void DanIsHetWegvakNietMeegenomenInDeBAGUpdate()
        {
            _bagUpdateService.WegvakIsNietMeegenomenInBagUpdateCheck(_wegvakData.WegvakId);
        }

        [Then(@"is er een melding betreffende '(.*)' weggeschreven in de meldingen tabel")]
        public void DanIsErEenMeldingBetreffendeWeggeschrevenInDeMeldingenTabel(string meldingOnderwerp)
        {
            string melding;
            switch (meldingOnderwerp)
            {
                case "de lengte van het wegvak dat in de nieuwe gemeente ligt":
                    melding = "Geometrie van wegvak moet single line zijn en wegvak mag niet kleiner zijn dan 2 meter.";
                    break;
                case "de lengte van het wegvak dat uit de eigen gemeente mag steken":
                    melding = "Een wegvak mag niet meer dan 10 meter buiten de eigen gemeente steken.";
                    break;
                case "de wegbeheerder":
                    melding = "De wegbeheerdersoort van een wegvak-efemeriden moet gelijk zijn aan de wegbeheerdersoort van de bijbehorende wegbeheerder";
                    break;
                case "de gemeente":
                    melding = "De gemeente van een wegvak-efemeride moet gelijk zijn aan de gemeente van de bijbehorende straat";
                    break;
                default:
                    throw new Exception($"{meldingOnderwerp} is niet geimplementeerd als wegbeheerder optie");
            }

            _bagUpdateService.CheckFoutmeldingWegvak(_wegvakData.WegvakId, melding);
        }

        [Then(@"is het wegvak meegenomen in de BAG update")]
        public void DanIsHetWegvakMeegenomenInDeBAGUpdate()
        {
            _bagUpdateService.CheckWegvakEfemeridenDiff(_wegvakData.WegvakId, _wegvakData.NieuwGemeenteId, 
                _wegvakData.OudGemeenteId, _wegvakData.OudeBegindatumVastlegging, _wegvakData.OudeBegindatumWerkelijk);

            _bagUpdateService.CheckOudWegvakEfemeridenInsert(_wegvakData.WegvakId, _wegvakData.OudGemeenteId, _wegvakData.OudeBegindatumWerkelijk,
                _wegvakData.OudeEinddatumWerkelijk,_wegvakData.OudStraatId, _wegvakData.OudWegbeheerderId, _wegvakData.WegbeheerderSoort);

            _bagUpdateService.CheckNieuwWegvakEfemeridenInsert(_wegvakData.WegvakId, _wegvakData.NieuwGemeenteId, _wegvakData.NieuweBegindatumWerkelijk,
                _wegvakData.NieuwStraatId, _wegvakData.NieuwWegbeheerderId, _wegvakData.WegbeheerderSoort);

            _bagUpdateService.CheckWegvakEfemeridenUpdate(_wegvakData.WegvakId, _wegvakData.OudeBegindatumWerkelijk, _wegvakData.OudeBegindatumVastlegging);
        }

        [Then(@"is het wegvak geupdatet in de NWW database")]
        public void DanIsHetWegvakGeupdatetInDeNWWDatabase()
        {
            _bagUpdateService.CheckOudeWegvakkenNwwWegvakEfemeriden(_wegvakData.WegvakId, _wegvakData.OudeBegindatumVastlegging, _wegvakData.OudWegbeheerderId, _wegvakData.OudGemeenteId, 
                _wegvakData.OudStraatId, _wegvakData.OudeBegindatumWerkelijk, _wegvakData.OudeEinddatumWerkelijk, DatumBagUpdate);

            _bagUpdateService.CheckNieuwWegvakEfemeridenInsert(_wegvakData.WegvakId, _wegvakData.NieuwGemeenteId, 
                _wegvakData.NieuweBegindatumWerkelijk, _wegvakData.NieuwStraatId, _wegvakData.NieuwWegbeheerderId, _wegvakData.WegbeheerderSoort);
        }

        [Then(@"is de straat '(.*)' toegevoegd als vervallen straat in de NWW database")]
        public void DanIsDeStraatToegevoegdAlsVervallenStraatInDeNWWDatabase(string oudeStraat)
        {
            _bagUpdateService.IsStraatPresentInBagUpdateStratenInsert(oudeStraat, _wegvakData.NieuwGemeenteId).Should().BeTrue();

            var straatType = _bagUpdateService.GetStraattype(oudeStraat, _wegvakData.NieuwGemeenteId);

            straatType.ToLower().Should().Be("v");
        }

    }
}
