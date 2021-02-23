using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.OHX_SCHRIJFDB
{
    public partial class Ohxbag3WegvakEfnI
    {
        public int WvkId { get; set; }
        public DateTime BegindatumVastlegging { get; set; }
        public DateTime? EinddatumVastlegging { get; set; }
        public DateTime BegindatumWerkelijk { get; set; }
        public DateTime? EinddatumWerkelijk { get; set; }
        public int JteIdBegin { get; set; }
        public int JteIdEind { get; set; }
        public string Wegbeheerdersoort { get; set; }
        public byte? WbrId { get; set; }
        public string WegnummerFormeel { get; set; }
        public string WegnummerWerkelijk { get; set; }
        public string Wegdeelletter { get; set; }
        public string Hectometreringsletter { get; set; }
        public string BstCode { get; set; }
        public string RpeCode { get; set; }
        public string Rijrichting { get; set; }
        public int? SttId { get; set; }
        public decimal? WbgId { get; set; }
        public byte? GmeId { get; set; }
        public string HnrstrLinks { get; set; }
        public string HnrstrRechts { get; set; }
        public short? EHnrLinks { get; set; }
        public short? EHnrRechts { get; set; }
        public short? LHnrLinks { get; set; }
        public short? LHnrRechts { get; set; }
        public byte GonId { get; set; }
        public byte? Bronjaar { get; set; }
        public byte KlokBegin { get; set; }
        public byte KlokEind { get; set; }
        public string AdminRichting { get; set; }
        public string VerkeersbaanIndicator { get; set; }
        public bool? RelatiefBaanvolgnr { get; set; }
        public string TypeWijziging { get; set; }
        public string RedenWijziging { get; set; }
        public string Status { get; set; }
        public string WegtypeCode { get; set; }
        public decimal? SdeId { get; set; }
        public byte[] SeAnnoCadData { get; set; }
    }
}
