using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OHx.Testautomatisering
{
    public partial class NwwDbContext : DbContext
    {
        public NwwDbContext()
        {
        }

        public NwwDbContext(DbContextOptions<NwwDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<NwwWegvakEfemeriden> NwwWegvakEfemeriden { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseOracle("Data Source=(DESCRIPTION= (ADDRESS= (PROTOCOL=tcp) (HOST=tbnm.ad.rws.nl) (PORT=1526))(CONNECT_DATA= (SID=TBNM) (GLOBAL_NAME=TBNM.rws.nl))); User ID=NWW;Password=NWW;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "NWW");

            modelBuilder.Entity<NwwWegvakEfemeriden>(entity =>
            {
                entity.HasKey(e => new { e.WvkId, e.BegindatumVastlegging, e.BegindatumWerkelijk })
                    .HasName("NWW_WEE_PK");

                entity.ToTable("NWW_WEGVAK_EFEMERIDEN");

                entity.HasIndex(e => e.BstCode)
                    .HasName("NWW_WEE_BST_FK1_FRGN");

                entity.HasIndex(e => e.EinddatumVastlegging)
                    .HasName("NWW_WEE_EINDDATUM");

                entity.HasIndex(e => e.GmeId)
                    .HasName("NWW_WEE_GME_FK1_FRGN");

                entity.HasIndex(e => e.GonId)
                    .HasName("NWW_WEE_GON_FK1_FRGN");

                entity.HasIndex(e => e.JteIdBegin)
                    .HasName("NWW_WEE_2");

                entity.HasIndex(e => e.JteIdEind)
                    .HasName("NWW_WEE_3");

                entity.HasIndex(e => e.RpeCode)
                    .HasName("NWW_WEE_RPE_FK1_FRGN");

                entity.HasIndex(e => e.SdeId)
                    .HasName("NWW_WEE_SDE")
                    .IsUnique();

                entity.HasIndex(e => e.SttId)
                    .HasName("NWW_WEE_STT_FK1_FRGN");

                entity.HasIndex(e => e.WbgId)
                    .HasName("NWW_WEE_WBG_FK1_FRGN");

                entity.HasIndex(e => e.WbrId)
                    .HasName("NWW_WEE_WBR_FK1_FRGN");

                entity.HasIndex(e => e.Wegbeheerdersoort)
                    .HasName("NWW_WEE_BI1");

                entity.HasIndex(e => e.WegnummerFormeel)
                    .HasName("NWW_WEE_1");

                entity.HasIndex(e => e.WvkId)
                    .HasName("NWW_WEE_WVK_FK1_FRGN");

                entity.Property(e => e.WvkId)
                    .HasColumnName("WVK_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BegindatumVastlegging)
                    .HasColumnName("BEGINDATUM_VASTLEGGING")
                    .HasDefaultValueSql("trunc(sysdate)");

                entity.Property(e => e.BegindatumWerkelijk)
                    .HasColumnName("BEGINDATUM_WERKELIJK")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AdminRichting)
                    .HasColumnName("ADMIN_RICHTING")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Bronjaar)
                    .HasColumnName("BRONJAAR");

                entity.Property(e => e.BstCode)
                    .HasColumnName("BST_CODE")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EHnrLinks)
                    .HasColumnName("E_HNR_LINKS");

                entity.Property(e => e.EHnrRechts)
                    .HasColumnName("E_HNR_RECHTS");

                entity.Property(e => e.EinddatumVastlegging)
                    .HasColumnName("EINDDATUM_VASTLEGGING");

                entity.Property(e => e.EinddatumWerkelijk)
                    .HasColumnName("EINDDATUM_WERKELIJK");

                entity.Property(e => e.GmeId)
                    .HasColumnName("GME_ID");

                entity.Property(e => e.GonId)
                    .HasColumnName("GON_ID");

                entity.Property(e => e.Hectometreringsletter)
                    .HasColumnName("HECTOMETRERINGSLETTER")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.HnrstrLinks)
                    .HasColumnName("HNRSTR_LINKS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HnrstrRechts)
                    .HasColumnName("HNRSTR_RECHTS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.JteIdBegin)
                    .HasColumnName("JTE_ID_BEGIN");

                entity.Property(e => e.JteIdEind)
                    .HasColumnName("JTE_ID_EIND");

                entity.Property(e => e.KlokBegin)
                    .HasColumnName("KLOK_BEGIN");

                entity.Property(e => e.KlokEind)
                    .HasColumnName("KLOK_EIND");

                entity.Property(e => e.LHnrLinks)
                    .HasColumnName("L_HNR_LINKS");

                entity.Property(e => e.LHnrRechts)
                    .HasColumnName("L_HNR_RECHTS");

                entity.Property(e => e.RedenWijziging)
                    .HasColumnName("REDEN_WIJZIGING")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RelatiefBaanvolgnr)
                    .HasColumnName("RELATIEF_BAANVOLGNR");

                entity.Property(e => e.RelatieveHoogte)
                    .HasColumnName("RELATIEVE_HOOGTE");

                entity.Property(e => e.Rijrichting)
                    .IsRequired()
                    .HasColumnName("RIJRICHTING")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RpeCode)
                    .HasColumnName("RPE_CODE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SdeId)
                    .HasColumnName("SDE_ID");

                entity.Property(e => e.SeAnnoCadData)
                    .HasColumnName("SE_ANNO_CAD_DATA");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SttId)
                    .HasColumnName("STT_ID");

                entity.Property(e => e.TypeWijziging)
                    .HasColumnName("TYPE_WIJZIGING")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.VerkeersbaanIndicator)
                    .HasColumnName("VERKEERSBAAN_INDICATOR")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.WbgId)
                    .HasColumnName("WBG_ID");

                entity.Property(e => e.WbrId)
                    .HasColumnName("WBR_ID");

                entity.Property(e => e.Wegbeheerdersoort)
                    .IsRequired()
                    .HasColumnName("WEGBEHEERDERSOORT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Wegdeelletter)
                    .HasColumnName("WEGDEELLETTER")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.WegnummerFormeel)
                    .HasColumnName("WEGNUMMER_FORMEEL")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.WegnummerWerkelijk)
                    .HasColumnName("WEGNUMMER_WERKELIJK")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.WegtypeCode)
                    .HasColumnName("WEGTYPE_CODE")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.HasSequence("GGA_STT_SEQ1");

            modelBuilder.HasSequence("MDRS_839C7$");

            modelBuilder.HasSequence("MDRS_848A2$");

            modelBuilder.HasSequence("NWW_HTT_SEQ1");

            modelBuilder.HasSequence("NWW_HTT_SEQ2");

            modelBuilder.HasSequence("NWW_RTE_SEQ1");

            modelBuilder.HasSequence("NWW_WBG_SEQ1");

            modelBuilder.HasSequence("NWW_WBR_SEQ1");

            modelBuilder.HasSequence("NWW_WEE_SEQ1");

            modelBuilder.HasSequence("NWW_WEE_SEQ2");

            modelBuilder.HasSequence("R240");

            modelBuilder.HasSequence("R34");

            modelBuilder.HasSequence("R35");

            modelBuilder.HasSequence("R36");

            modelBuilder.HasSequence("SDE_LOGFILE_LID_GEN");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
