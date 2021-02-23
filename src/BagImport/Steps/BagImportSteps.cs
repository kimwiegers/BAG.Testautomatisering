using Bag.Testautomatisering;
using BagImport.Testautomatisering.Models;
using BagImport.Testautomatisering.Services;
using FluentAssertions;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace BagImport.Testautomatisering.Steps
{
    [Binding]
    public class BagImportSteps
    {
        public readonly WoonplaatsData _woonplaatsData;
        public readonly GemeenteData _gemeenteData;
        private readonly StraatData _straatData;
        private readonly BagShared _bagShared;
        private readonly IBagImportService _bagImportService;
        public BagImportSteps(WoonplaatsData woonplaatsData, GemeenteData gemeenteData, BagShared bagShared, 
            StraatData straatData, IBagImportService bagImportService)
        {
            _gemeenteData = gemeenteData;
            _woonplaatsData = woonplaatsData;
            _straatData = straatData;
            _bagShared = bagShared;
            _bagImportService = bagImportService;
        }

        [Given(@"de gemeente '(.*)' na een gemeentelijke herindeling toegevoegd is aan de gemeente '(.*)'")]
        public void GegevenDeGemeenteNaEenGemeentelijkeHerindelingToegevoegdIsAanDeGemeente(string oudeGemeente, string nieuweGemeente)
        {
            _gemeenteData.OudeGemeente = oudeGemeente;
            _gemeenteData.NieuweGemeente = nieuweGemeente;
        }

        [Then(@"krijgen alle straten onder de gemeente '(.*)' in gga_straten de status '(.*)'")]
        public void DanKrijgenAlleStratenOnderDeGemeenteInGga_StratenDeStatus(string oudeGemeente, string status)
        {
            var straattype = _bagShared.StatusTransform(status);

            var gemeenteId = _bagShared.GetGemeenteId(oudeGemeente);
            var straatType = _bagShared.StatusTransform(status);

            //Check of de straten in Driebergen onder de gemeente Zeist de status 'vervallen' krijgen
            var straten = _bagImportService.GetListOfStratenBelongingToSpecificGemeente(gemeenteId);
            foreach (var straat in straten)
            {
                straat.SttType.Should().Be(straatType);
            }
        }


        [Given(@"de woonplaats '(.*)' na een gemeentelijke herindeling is verschoven van de gemeente '(.*)' naar de gemeente '(.*)'")]
        public void GegevenDeWoonplaatsNaEenGemeentelijkeHerindelingIsVerschovenVanDeGemeenteNaarDeGemeente(string woonplaats, string oudeGemeente, string nieuweGemeente)
        {
            _gemeenteData.OudeGemeente = oudeGemeente;
            _gemeenteData.NieuweGemeente = nieuweGemeente;
            _woonplaatsData.NieuweWoonplaats = woonplaats;
            _gemeenteData.OudGemeenteId = _bagShared.GetGemeenteId(_gemeenteData.OudeGemeente);
            _gemeenteData.NieuwGemeenteId = _bagShared.GetGemeenteId(_gemeenteData.NieuweGemeente);
        }

        [When(@"de BAG import is afgerond")]
        public void AlsDeBAGImportIsAfgerond()
        {
            //Hier eventueel job/proces aftrappen
        }

        [Then(@"krijgen alle straten in '(.*)' onder de gemeente '(.*)' in gga_straten de status '(.*)'")]
        public void DanKrijgenAlleStratenInOnderDeGemeenteInGga_StratenDeStatus(string woonplaats, string gemeente, string status)
        {
            var gemeenteId = _bagShared.GetGemeenteId(gemeente);
            var woonplaatsId = _bagImportService.GetWoonplaatsId(_woonplaatsData.NieuweWoonplaats);
            var straatType = _bagShared.StatusTransform(status);

            //Check of de straten in Driebergen onder de gemeente Zeist de status 'vervallen' krijgen
            var straten =_bagImportService.GetListOfStratenBelongingToSpecificGemeenteAndWoonplaats(gemeenteId, woonplaatsId);
            foreach (var straat in straten)
            {
                straat.SttType.Should().Be(straatType);
            }
        }

        [Then(@"worden de straten opgevoerd als horende bij gemeente '(.*)' in gga_straten met de status '(.*)'")]
        public void DanWordenDeStratenOpgevoerdAlsHorendeBijGemeenteInGga_StratenMetDeStatus(string gemeente, string status)
        {
            var straatType = _bagShared.StatusTransform(status);
            var gemeenteId = _bagShared.GetGemeenteId(gemeente);

            //Haal straatnaam op uit straten tabel van de woonplaats onder de vervallen gemeente
            var straten = _bagImportService.GetListOfStratenBelongingToSpecificGemeente(gemeenteId);
            var straatnaam = straten.FirstOrDefault(x => x.SttType == straatType).Naam;

            straatnaam.Should().NotBeNullOrEmpty();
        }

        [Then(@"worden de straten in de woonplaats '(.*)' opgevoerd als horende bij gemeente '(.*)' in gga_straten met de status '(.*)'")]
        public void DanWordenDeStratenInDeWoonplaatsOpgevoerdAlsHorendeBijGemeenteInGga_StratenMetDeStatus(string woonplaats, string gemeente, string status)
        {

            var straatType = _bagShared.StatusTransform(status);

            //Haal straatnaam op uit straten tabel van de woonplaats onder de vervallen gemeente
            var nieuwWoonplaatsId = _bagImportService.GetWoonplaatsId(woonplaats, _gemeenteData.NieuwGemeenteId);
            var straten = _bagImportService.GetListOfStratenBelongingToSpecificGemeenteAndWoonplaats(_gemeenteData.NieuwGemeenteId, nieuwWoonplaatsId);
            var straatnaam = straten.FirstOrDefault(x => x.SttType == straatType).Naam;

            straatnaam.Should().NotBeNullOrEmpty();
        }

        [Then(@"is in gga_woonplaatsen is een nieuw record aangemaakt voor '(.*)' als horende bij gemeente '(.*)'")]
        public void DanIsInGga_WoonplaatsenIsEenNieuwRecordAangemaaktVoorAlsHorendeBijGemeente(string woonplaats, string gemeente)
        {
            var nieuwGemeenteId = _bagShared.GetGemeenteId(_gemeenteData.NieuweGemeente);
            var woonplaatsId = _bagImportService.GetWoonplaatsId(_woonplaatsData.NieuweWoonplaats);

            //Check of de combinatie woonplaats Driebergen met gemeente Utrechtse Heuvelrug te vinden is
            _bagImportService.BestaatCombinatieWoonplaatsEnGemeente(nieuwGemeenteId, woonplaatsId);
        }

        [Given(@"de gemeente '(.*)' aangepast is naar '(.*)'")]
        public void GegevenDeGemeenteAangepastIsNaar(string oudeGemeente, string nieuweGemeente)
        {
            _gemeenteData.OudeGemeente = oudeGemeente;
            _gemeenteData.NieuweGemeente = nieuweGemeente;
        }

        [Then(@"is de naam in gga_gemeenten aangepast naar '(.*)'")]
        public void DanIsDeNaamInGga_GemeentenAangepastNaar(string gemeente)
        {
            //Check dat Bunning' niet meer terug te vinden is in gga_gemeenten
            _bagShared.GetGemeenteId(_gemeenteData.OudeGemeente).Should().Be(0);

            //Check dat Bunnik' toegevoegd is in gga_gemeenten
            _bagShared.GetGemeenteId(_gemeenteData.NieuweGemeente).Should().NotBe(0);
        }

        [Given(@"de woonplaats '(.*)' is hernaamd naar '(.*)'")]
        public void GegevenDeWoonplaatsIsHernaamdNaar(string oudeWoonplaats, string nieuweWoonplaats)
        {
            _woonplaatsData.Woonplaats = oudeWoonplaats;
            _woonplaatsData.NieuweWoonplaats = nieuweWoonplaats;
        }

        [Then(@"En is de naam in gga_woonplaatsen aangepast naar '(.*)'")]
        public void DanEnIsDeNaamInGga_WoonplaatsenAangepastNaar(string nieuweWoonplaats)
        {
            //Check dat 'Odin' niet meer is terug te vinden in gga_woonplaatsen
            var woonplaatsOud = _bagImportService.GetWoonplaatsData(_woonplaatsData.Woonplaats);
            woonplaatsOud.Status.Should().Be("V");

            //Check dat 'Odijk' is toegevoegd in gga_woonplaatsen
            var woonplaatsNieuw = _bagImportService.GetWoonplaatsData(_woonplaatsData.NieuweWoonplaats);
            woonplaatsNieuw.Status.Should().Be("P");
        }

        [Given(@"het BAG id van '(.*)' in '(.*)' gewijzigd is van (.*) naar (.*)")]
        public void GegevenHetBAGIdVanInGewijzigdIsVanNaar(string straatnaam, string woonplaats, string oudBagId, string nieuwBagId)
        {
            _straatData.Straatnaam = straatnaam;
            _straatData.OudBagId = oudBagId;
            _straatData.NieuwBagId = nieuwBagId;
            _woonplaatsData.Woonplaats = woonplaats;
        }

        [Then(@"krijgt de de straat met BAG id (.*) het type '(.*)'")]
        public void DanKrijgtDeDeStraatMetBAGIdHetType(string oudBagId, string status)
        {
            var straattype = _bagShared.StatusTransform(status);

            //Haal het straattype op en controleer of dit de juiste is
            _bagImportService.GetStraatData(_straatData.OudBagId).SttType.Should().Be(straattype);
        }

        [Given(@"de naam  van een straat is gewijzigd van '(.*)' naar '(.*)'")]
        public void GegevenDeNaamVanEenStraatIsGewijzigdVanNaar(string oudeStraatnaam, string nieuweStraatnaam)
        {
            _straatData.OudeStraatnaam = oudeStraatnaam;
            _straatData.NieuweStraatnaam = nieuweStraatnaam;
        }

        [Then(@"is er een nieuw record aangemaakt in gga_straten voor '(.*)' met BAG id '(.*)'")]
        public void DanIsErEenNieuwRecordAangemaaktInGga_StratenVoorMetBAGId(string nieuweStraatnaam, string bagId)
        {
            var straatId = _bagImportService.GetStraatData(_straatData.NieuwBagId).Id;
            straatId.Should().NotBe(0);

            var straatnaam = _bagImportService.GetStraatData(_straatData.NieuwBagId).NaamOfficieel;
            straatnaam.Should().Be(_straatData.NieuweStraatnaam);
        }

        [Given(@"de straat '(.*)' in de gemeente '(.*)' nog niet bekend is in de BN")]
        public void GegevenDeStraatInDeGemeenteNogNietBekendIsInDeBN(string straatnaam, string gemeente)
        {
            _straatData.Straatnaam = straatnaam;
            _gemeenteData.GemeenteId = _bagShared.GetGemeenteId(gemeente);
        }

        [Then(@"is de straat '(.*)' toegevoegd in gga_straten als '(.*)'")]
        [Then(@"is de straat '(.*)' geupdatet in gga_straten als '(.*)'")]
        public void DanIsDeStraatGeupdatetInGga_StratenAls(string straatnaam, string status)
        {
            var straattype = _bagShared.StatusTransform(status);
            var woonplaatsId = _bagImportService.GetWoonplaatsId(_woonplaatsData.Woonplaats);
            var gemeenteId = _bagShared.GetGemeenteId(woonplaatsId);

            //Check of de straat aanwezig is in gga_straten met de juiste straattype
            _bagImportService.GetStraatType(straatnaam, woonplaatsId, gemeenteId).Should().Be(straattype);
        }

        [Given(@"de straat '(.*)' in de woonplaats '(.*)' in BN staat als '(.*)'")]
        public void GegevenDeStraatInDeWoonplaatsInBNStaatAls(string straat, string woonplaats, string status)
        {
            _straatData.Straatnaam = straat;
            _woonplaatsData.Woonplaats = woonplaats;
        }

        [Given(@"de naam-gerelateerde velden zijn leeg")]
        public void GegevenDeNaam_GerelateerdeVeldenZijnLeeg()
        {
            //Eventueel in de toekomst check doen op lege velden voor de bag import
        }

        [Given(@"de straat is inmiddels bekend in BAG")]
        public void GegevenDeStraatIsInmiddelsBekendInBAG()
        {
            //Eventueel check in BAG implementeren
        }

        [Given(@"de straat is inmiddels vervallen in BAG")]
        public void GegevenDeStraatIsInmiddelsVervallenInBAG()
        {
            //Eventueel check in BAG implementeren
        }

        [Then(@"zijn de naam-gerelateerde velden van '(.*)' gevuld met de data die in BAG bekend is")]
        public void DanZijnDeNaam_GerelateerdeVeldenVanGevuldMetDeDataDieInBAGBekendIs(string straatnaam)
        {
            //Haal de naamgevingen op uit de database zoals ze aangevuld zijn door de BAG
            var woonplaatsId = _bagImportService.GetWoonplaatsId(_woonplaatsData.Woonplaats);
            var gemeenteId = _bagShared.GetGemeenteId(woonplaatsId);

            var straat = _bagImportService.GetStraatData(_straatData.Straatnaam, woonplaatsId, gemeenteId);
            var naamofficieelUitBag = straat.NaamOfficieel;
            var naamPttUitBag = straat.NaamPtt;
            var naamafkortingUitBag = straat.Naamafkorting;

            //Bepaal de juiste naamgevingen 
            var naamOfficieel = straatnaam;
            var naamPtt = straatnaam.ToUpper();
            var naamAfkorting = straatnaam.Substring(0, 5).ToUpper();

            //Controleer dat de naamgevingen juist gevuld zijn door de BAG
            naamofficieelUitBag.Should().Be(naamOfficieel);
            naamafkortingUitBag.Should().Be(naamAfkorting);
            naamPttUitBag.Should().Be(naamPtt);
        }

        [Given(@"de naam_ptt en naam_afkorting van de straat '(.*)' staan foutief in BN")]
        public void GegevenDeNaam_PttEnNaam_AfkortingVanDeStraatStaanFoutiefInBN(string straatnaam)
        {
            //Haal de naamgevingen op uit de database zoals ze aangevuld zijn door de BAG
            var woonplaatsId = _bagImportService.GetWoonplaatsId(_woonplaatsData.Woonplaats);
            var gemeenteId = _bagShared.GetGemeenteId(woonplaatsId);

            var straat = _bagImportService.GetStraatData(_straatData.Straatnaam, woonplaatsId, gemeenteId);
            var naamPttUitBn = straat.NaamPtt;
            var naamafkortingUitBn = straat.Naamafkorting;


            //Bepaal de juiste naamgevingen 
            var naamPtt = straatnaam.ToUpper();
            var naamafkorting = straatnaam.Substring(0, 5).ToUpper();

            //Controleer dat de naamgevingen inderdaad onjuist in BN staan
            naamafkortingUitBn.Should().NotBe(naamafkorting);
            naamPttUitBn.Should().NotBe(naamPtt);
        }

        [Given(@"de naam_officieel van de straat '(.*)' mist in de BN")]
        public void GegevenDeNaam_OfficieelVanDeStraatMistInDeBN(string straatnaam)
        {
            //Haal de naamgevingen op uit de database zoals ze aangevuld zijn door de BAG
            var woonplaatsId = _bagImportService.GetWoonplaatsId(_woonplaatsData.Woonplaats);
            var gemeenteId = _bagShared.GetGemeenteId(woonplaatsId);

            var straat = _bagImportService.GetStraatData(_straatData.Straatnaam, woonplaatsId, gemeenteId);
            var naamOfficieel = straat.NaamOfficieel;

            //Controleer of de naam_officieel kolom inderdaad leeg id
            naamOfficieel.Should().BeNullOrEmpty();
        }
    }
}
