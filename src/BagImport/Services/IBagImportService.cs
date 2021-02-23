using OHx.Testautomatisering.NWADB;
using OHx.Testautomatisering.NWWDB;
using System.Collections.Generic;

namespace BagImport.Testautomatisering.Services
{
    public interface IBagImportService
    {
        int GetWoonplaatsId(string woonplaatsNaam);
        int GetWoonplaatsId(string woonplaatsNaam, int gemeenteId);
        int GetWoonplaatsIdFromGgaStraten(string straatnaam, int gemeenteId);
        string GetStraatType(string straatnaamOfficieel, int woonplaatsId, int gemeenteId);
        string GetStraatnaamOfficieel(string bagId);
        List<GgaStraten> GetListOfStratenBelongingToSpecificGemeenteAndWoonplaats(int gemeenteId, int woonplaatsId);
        List<GgaStraten> GetListOfStratenBelongingToSpecificGemeente(int gemeenteId);
        bool BestaatCombinatieWoonplaatsEnGemeente(int gemeenteId, int woonplaatsId);
        GgaStraten GetStraatData(string straatnaam, int gemeenteId, int woonplaatsId);
        GgaStraten GetStraatData(string bagId);
        GgaWoonplaatsen GetWoonplaatsData(string woonplaatsNaam);
    }
}
