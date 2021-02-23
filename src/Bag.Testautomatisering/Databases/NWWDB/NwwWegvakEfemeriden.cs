using System;
using System.Collections.Generic;

namespace OHx.Testautomatisering.NWWDB
{
    public partial class NwwWegvakEfemeriden
    {
        public NwwWegvakEfemeriden()
        {
            NwwHectoIntervallen = new HashSet<NwwHectoIntervallen>();
            NwwHectopunten = new HashSet<NwwHectopunten>();
            NwwHuisnummers = new HashSet<NwwHuisnummers>();
            NwwWegvakInRoutes = new HashSet<NwwWegvakInRoutes>();
        }

        public long WvkId { get; set; }
        public DateTime BegindatumVastlegging { get; set; }
        public DateTime? EinddatumVastlegging { get; set; }
        public DateTime BegindatumWerkelijk { get; set; }
        public DateTime? EinddatumWerkelijk { get; set; }
        public long JteIdBegin { get; set; }
        public long JteIdEind { get; set; }
        public string Wegbeheerdersoort { get; set; }
        public short? WbrId { get; set; }
        public string WegnummerFormeel { get; set; }
        public string WegnummerWerkelijk { get; set; }
        public string Wegdeelletter { get; set; }
        public string Hectometreringsletter { get; set; }
        public string BstCode { get; set; }
        public string RpeCode { get; set; }
        public string Rijrichting { get; set; }
        public int? SttId { get; set; }
        public decimal? WbgId { get; set; }
        public short? GmeId { get; set; }
        public string HnrstrLinks { get; set; }
        public string HnrstrRechts { get; set; }
        public int? EHnrLinks { get; set; }
        public int? EHnrRechts { get; set; }
        public int? LHnrLinks { get; set; }
        public int? LHnrRechts { get; set; }
        public short GonId { get; set; }
        public short? Bronjaar { get; set; }
        public short KlokBegin { get; set; }
        public short KlokEind { get; set; }
        public string AdminRichting { get; set; }
        public string VerkeersbaanIndicator { get; set; }
        public short? RelatiefBaanvolgnr { get; set; }
        public short? RelatieveHoogte { get; set; }
        public string TypeWijziging { get; set; }
        public string RedenWijziging { get; set; }
        public string Status { get; set; }
        public string WegtypeCode { get; set; }
        public decimal SdeId { get; set; }
        public byte[] SeAnnoCadData { get; set; }

        public virtual GgaStraten Stt { get; set; }
        public virtual NwwWbrBenaming Wbg { get; set; }
        public virtual NwwWegbeheerders Wbr { get; set; }
        public virtual NwwWegvakken Wvk { get; set; }
        public virtual ICollection<NwwHectoIntervallen> NwwHectoIntervallen { get; set; }
        public virtual ICollection<NwwHectopunten> NwwHectopunten { get; set; }
        public virtual ICollection<NwwHuisnummers> NwwHuisnummers { get; set; }
        public virtual ICollection<NwwWegvakInRoutes> NwwWegvakInRoutes { get; set; }
    }
}
