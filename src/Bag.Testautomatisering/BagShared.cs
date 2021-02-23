using OHx.Testautomatisering.NWADB;
using System;
using System.Linq;

namespace Bag.Testautomatisering
{
    public class BagShared
    {
        private NwaDbContext _context;

        public BagShared()
        {
            _context = new NwaDbContext();
        }
        public short GetGemeenteId(string gemeentenaam)
        {
            var gemeenten = _context.GgaGemeenten.Where(x => x.Naam == gemeentenaam).ToList();

            if (gemeenten.Count() == 0 || gemeenten.Count() > 1)
            {
                return 0;
            }

            return gemeenten[0].Id;
        }

        public short GetGemeenteId(int woonplaatsId)
        {
            var woonplaats = _context.GgaWoonplaatsen.Where(x => x.Id == woonplaatsId).ToList();

            if (!woonplaats.Any())
            {
                throw new Exception($"Geen woonplaats gevonden met id {woonplaatsId}");
            }

            return (short)woonplaats[0].GmeId;
        }

        public string StatusTransform(string status)
        {
            switch (status.ToLower())
            {
                case "bag-straat":
                    return "P";
                case "vervallen":
                    return "V";
                case "rws-straat":
                case "rijkswaterstaat-straat":
                    return "A";
                default:
                    throw new Exception($"{status} is geen geldige optie");

            }
        }
    }
}
