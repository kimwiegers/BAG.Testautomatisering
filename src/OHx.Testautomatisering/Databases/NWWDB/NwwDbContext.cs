using Microsoft.EntityFrameworkCore;

namespace OHx.Testautomatisering.NWWDB
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

        public virtual DbSet<GgaStraten> GgaStraten { get; set; }
        public virtual DbSet<NwwHectoIntervallen> NwwHectoIntervallen { get; set; }
        public virtual DbSet<NwwHectopunten> NwwHectopunten { get; set; }
        public virtual DbSet<NwwHuisnummers> NwwHuisnummers { get; set; }
        public virtual DbSet<NwwJuncties> NwwJuncties { get; set; }
        public virtual DbSet<NwwRoutes> NwwRoutes { get; set; }
        public virtual DbSet<NwwTussenvoegsels> NwwTussenvoegsels { get; set; }
        public virtual DbSet<NwwWbrBenaming> NwwWbrBenaming { get; set; }
        public virtual DbSet<NwwWegbeheerders> NwwWegbeheerders { get; set; }
        public virtual DbSet<NwwWegvakEfemeriden> NwwWegvakEfemeriden { get; set; }
        public virtual DbSet<NwwWegvakInRoutes> NwwWegvakInRoutes { get; set; }
        public virtual DbSet<NwwWegvakRelaties> NwwWegvakRelaties { get; set; }
        public virtual DbSet<NwwWegvakken> NwwWegvakken { get; set; }

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

            modelBuilder.Entity<GgaStraten>(entity =>
            {
                entity.ToTable("GGA_STRATEN");

                entity.HasIndex(e => e.GmeId)
                    .HasName("GGA_STT_GME_FK1_FRGN");

                entity.HasIndex(e => e.NaamOfficieel)
                    .HasName("GGA_STT_2");

                entity.HasIndex(e => e.WpsId)
                    .HasName("GGA_STT_WPS_FK1_FRGN");

                entity.HasIndex(e => new { e.Naam, e.GmeId, e.WpsId })
                    .HasName("GGA_STT_UK1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID");

                entity.Property(e => e.BagId)
                    .HasColumnName("BAG_ID");

                entity.Property(e => e.GmeId)
                    .HasColumnName("GME_ID");

                entity.Property(e => e.Naam)
                    .IsRequired()
                    .HasColumnName("NAAM")
                    .HasMaxLength(29)
                    .IsUnicode(false);

                entity.Property(e => e.NaamOfficieel)
                    .HasColumnName("NAAM_OFFICIEEL")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NaamPtt)
                    .HasColumnName("NAAM_PTT")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Naamafkorting)
                    .HasColumnName("NAAMAFKORTING")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SttType)
                    .IsRequired()
                    .HasColumnName("STT_TYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.WpsId)
                    .HasColumnName("WPS_ID");
            });

            modelBuilder.Entity<NwwHectoIntervallen>(entity =>
            {
                entity.HasKey(e => new { e.WvkId, e.BegindatumVastlegging, e.BegindatumWerkelijk, e.Beginafstand })
                    .HasName("NWW_HIL_PK");

                entity.ToTable("NWW_HECTO_INTERVALLEN");

                entity.HasIndex(e => new { e.WvkId, e.BegindatumVastlegging, e.BegindatumWerkelijk })
                    .HasName("NWW_HIL_WEE_FK1_FRGN");

                entity.Property(e => e.WvkId)
                    .HasColumnName("WVK_ID");

                entity.Property(e => e.BegindatumVastlegging)
                    .HasColumnName("BEGINDATUM_VASTLEGGING");

                entity.Property(e => e.BegindatumWerkelijk)
                    .HasColumnName("BEGINDATUM_WERKELIJK");

                entity.Property(e => e.Beginafstand)
                    .HasColumnName("BEGINAFSTAND");

                entity.Property(e => e.BaanpositieTovWol)
                    .HasColumnName("BAANPOSITIE_TOV_WOL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Beginkilometrering)
                    .HasColumnName("BEGINKILOMETRERING");

                entity.Property(e => e.Eindafstand)
                    .HasColumnName("EINDAFSTAND");

                entity.Property(e => e.Eindkilometrering)
                    .HasColumnName("EINDKILOMETRERING");

                entity.HasOne(d => d.NwwWegvakEfemeriden)
                    .WithMany(p => p.NwwHectoIntervallen)
                    .HasForeignKey(d => new { d.WvkId, d.BegindatumVastlegging, d.BegindatumWerkelijk })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("NWW_HIL_WEE_FK1");
            });

            modelBuilder.Entity<NwwHectopunten>(entity =>
            {
                entity.HasKey(e => new { e.WeeWvkId, e.WeeBegindatumVastlegging, e.WeeBegindatumWerkelijk, e.Hectometrering })
                    .HasName("NWW_HTT_PK");

                entity.ToTable("NWW_HECTOPUNTEN");

                entity.HasIndex(e => e.SdeId)
                    .HasName("R34_SDE_ROWID_UK")
                    .IsUnique();

                entity.HasIndex(e => new { e.WeeWvkId, e.WeeBegindatumVastlegging, e.WeeBegindatumWerkelijk })
                    .HasName("NWW_HTT_WEE_FK1_FRGN");

                entity.HasIndex(e => new { e.WeeWvkId, e.WeeBegindatumVastlegging, e.WeeBegindatumWerkelijk, e.Afstand })
                    .HasName("NWW_HTT_UK2")
                    .IsUnique();

                entity.Property(e => e.WeeWvkId)
                    .HasColumnName("WEE_WVK_ID");

                entity.Property(e => e.WeeBegindatumVastlegging)
                    .HasColumnName("WEE_BEGINDATUM_VASTLEGGING");

                entity.Property(e => e.WeeBegindatumWerkelijk)
                    .HasColumnName("WEE_BEGINDATUM_WERKELIJK");

                entity.Property(e => e.Hectometrering)
                    .HasColumnName("HECTOMETRERING");

                entity.Property(e => e.Afstand)
                    .HasColumnName("AFSTAND");

                entity.Property(e => e.Einddatum)
                    .HasColumnName("EINDDATUM");

                entity.Property(e => e.SdeId)
                    .HasColumnName("SDE_ID");

                entity.Property(e => e.SeAnnoCadData)
                    .HasColumnName("SE_ANNO_CAD_DATA");

                entity.HasOne(d => d.Wee)
                    .WithMany(p => p.NwwHectopunten)
                    .HasForeignKey(d => new { d.WeeWvkId, d.WeeBegindatumVastlegging, d.WeeBegindatumWerkelijk })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("NWW_HTT_WEE_FK1");
            });

            modelBuilder.Entity<NwwHuisnummers>(entity =>
            {
                entity.HasAlternateKey(x => x.Id);

                entity.ToTable("NWW_HUISNUMMERS");

                entity.HasIndex(e => new { e.WvkId, e.BegindatumVastlegging, e.BegindatumWerkelijk, e.Huisnummer, e.HuisnummerLetter, e.HuisnummerToevoeging })
                    .HasName("NWW_HNR_UK1")
                    .IsUnique();

                entity.Property(e => e.Afstand).HasColumnName("AFSTAND");

                entity.Property(e => e.BegindatumVastlegging)
                    .HasColumnName("BEGINDATUM_VASTLEGGING");

                entity.Property(e => e.BegindatumWerkelijk)
                    .HasColumnName("BEGINDATUM_WERKELIJK");

                entity.Property(e => e.Huisnummer).HasColumnName("HUISNUMMER");

                entity.Property(e => e.HuisnummerLetter)
                    .HasColumnName("HUISNUMMER_LETTER")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HuisnummerToevoeging)
                    .HasColumnName("HUISNUMMER_TOEVOEGING")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.WvkId).HasColumnName("WVK_ID");

                entity.Property(e => e.Zijde)
                    .IsRequired()
                    .HasColumnName("ZIJDE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.NwwWegvakEfemeriden)
                    .WithMany(p => p.NwwHuisnummers)
                    .HasForeignKey(d => new { d.WvkId, d.BegindatumVastlegging, d.BegindatumWerkelijk })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("NWW_HNR_WEE_FK1");
            });

            modelBuilder.Entity<NwwJuncties>(entity =>
            {
                entity.ToTable("NWW_JUNCTIES");

                entity.HasIndex(e => e.SotId)
                    .HasName("NWW_JTE_SOT_FK1_FRGN");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SoMutatiedatum)
                    .HasColumnName("SO_MUTATIEDATUM");

                entity.Property(e => e.SotId)
                    .HasColumnName("SOT_ID");
            });

            modelBuilder.Entity<NwwRoutes>(entity =>
            {
                entity.ToTable("NWW_ROUTES");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Routeletter)
                    .IsRequired()
                    .HasColumnName("ROUTELETTER")
                    .IsUnicode(false);

                entity.Property(e => e.Routenummer)
                    .HasColumnName("ROUTENUMMER");
            });

            modelBuilder.Entity<NwwTussenvoegsels>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NWW_TUSSENVOEGSELS");

                entity.Property(e => e.Naar)
                    .HasColumnName("NAAR")
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.Van)
                    .HasColumnName("VAN")
                    .HasMaxLength(240)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NwwWbrBenaming>(entity =>
            {
                entity.ToTable("NWW_WBR_BENAMING");

                entity.Property(e => e.Id)
                    .HasColumnName("ID");

                entity.Property(e => e.GmeId)
                    .HasColumnName("GME_ID");

                entity.Property(e => e.Naam)
                    .HasColumnName("NAAM")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Nummer)
                    .HasColumnName("NUMMER")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Wegnummer)
                    .HasColumnName("WEGNUMMER")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NwwWegbeheerders>(entity =>
            {
                entity.ToTable("NWW_WEGBEHEERDERS");

                entity.HasIndex(e => new { e.Code, e.Soort })
                    .HasName("NWW_WBR_UK1")
                    .IsUnique();

                entity.HasIndex(e => new { e.Naam, e.Soort })
                    .HasName("NWW_WBR_UK2")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Link)
                    .HasColumnName("LINK")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Naam)
                    .IsRequired()
                    .HasColumnName("NAAM")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Soort)
                    .IsRequired()
                    .HasColumnName("SOORT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Telefoonnummer)
                    .HasColumnName("TELEFOONNUMMER")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

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
                    .HasColumnName("WVK_ID");

                entity.Property(e => e.BegindatumVastlegging)
                    .HasColumnName("BEGINDATUM_VASTLEGGING")
                    .HasDefaultValueSql("trunc(sysdate)");

                entity.Property(e => e.BegindatumWerkelijk)
                    .HasColumnName("BEGINDATUM_WERKELIJK");

                entity.Property(e => e.AdminRichting)
                    .HasColumnName("ADMIN_RICHTING")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Bronjaar)
                    .HasColumnName("BRONJAAR");

                entity.Property(e => e.BstCode)
                    .HasColumnName("BST_CODE")
                    .HasMaxLength(4)
                    .IsUnicode(false);

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

                entity.HasOne(d => d.Stt)
                    .WithMany(p => p.NwwWegvakEfemeriden)
                    .HasForeignKey(d => d.SttId)
                    .HasConstraintName("NWW_WEE_STT_FK1");

                entity.HasOne(d => d.Wbg)
                    .WithMany(p => p.NwwWegvakEfemeriden)
                    .HasForeignKey(d => d.WbgId)
                    .HasConstraintName("NWW_WEE_WBG_FK1");

                entity.HasOne(d => d.Wbr)
                    .WithMany(p => p.NwwWegvakEfemeriden)
                    .HasForeignKey(d => d.WbrId)
                    .HasConstraintName("NWW_WEE_WBR_FK1");

                entity.HasOne(d => d.Wvk)
                    .WithMany(p => p.NwwWegvakEfemeriden)
                    .HasForeignKey(d => d.WvkId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("NWW_WEE_WVK_FK1");
            });

            modelBuilder.Entity<NwwWegvakInRoutes>(entity =>
            {
                entity.HasKey(e => new { e.WeeWvkId, e.WeeBegindatumVastlegging, e.WeeBegindatumWerkelijk, e.RteId })
                    .HasName("NWW_WIR_PK");

                entity.ToTable("NWW_WEGVAK_IN_ROUTES");

                entity.HasIndex(e => e.RteId)
                    .HasName("NWW_WIR_RTE_FK1_FRGN");

                entity.HasIndex(e => new { e.WeeWvkId, e.WeeBegindatumVastlegging, e.WeeBegindatumWerkelijk })
                    .HasName("NWW_WIR_WEE_FK1_FRGN");

                entity.Property(e => e.WeeWvkId)
                    .HasColumnName("WEE_WVK_ID");

                entity.Property(e => e.WeeBegindatumVastlegging)
                    .HasColumnName("WEE_BEGINDATUM_VASTLEGGING");

                entity.Property(e => e.WeeBegindatumWerkelijk)
                    .HasColumnName("WEE_BEGINDATUM_WERKELIJK");

                entity.Property(e => e.RteId)
                    .HasColumnName("RTE_ID");

                entity.HasOne(d => d.Rte)
                    .WithMany(p => p.NwwWegvakInRoutes)
                    .HasForeignKey(d => d.RteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("NWW_WIR_RTE_FK1");

                entity.HasOne(d => d.Wee)
                    .WithMany(p => p.NwwWegvakInRoutes)
                    .HasForeignKey(d => new { d.WeeWvkId, d.WeeBegindatumVastlegging, d.WeeBegindatumWerkelijk })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("NWW_WIR_WEE_FK1");
            });

            modelBuilder.Entity<NwwWegvakRelaties>(entity =>
            {
                entity.HasKey(e => new { e.WvkIdOpvolger, e.WvkIdVoorganger })
                    .HasName("NWW_WRE_PK");

                entity.ToTable("NWW_WEGVAK_RELATIES");

                entity.HasIndex(e => e.WvkIdOpvolger)
                    .HasName("NWW_WRE_WVK_FK1_FRGN");

                entity.HasIndex(e => e.WvkIdVoorganger)
                    .HasName("NWW_WRE_WVK_FK2_FRGN");

                entity.Property(e => e.WvkIdOpvolger)
                    .HasColumnName("WVK_ID_OPVOLGER");

                entity.Property(e => e.WvkIdVoorganger)
                    .HasColumnName("WVK_ID_VOORGANGER");

                entity.HasOne(d => d.WvkIdOpvolgerNavigation)
                    .WithMany(p => p.NwwWegvakRelatiesWvkIdOpvolgerNavigation)
                    .HasForeignKey(d => d.WvkIdOpvolger)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("NWW_WRE_WVK_FK1");

                entity.HasOne(d => d.WvkIdVoorgangerNavigation)
                    .WithMany(p => p.NwwWegvakRelatiesWvkIdVoorgangerNavigation)
                    .HasForeignKey(d => d.WvkIdVoorganger)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("NWW_WRE_WVK_FK2");
            });

            modelBuilder.Entity<NwwWegvakken>(entity =>
            {
                entity.ToTable("NWW_WEGVAKKEN");

                entity.HasIndex(e => e.JteIdBegin)
                    .HasName("NWW_WVK_JTE_FK1_FRGN");

                entity.HasIndex(e => e.JteIdEind)
                    .HasName("NWW_WVK_JTE_FK2_FRGN");

                entity.HasIndex(e => e.SokId)
                    .HasName("NWW_WVK_SOK_FK1_FRGN");

                entity.HasIndex(e => e.SotId)
                    .HasName("NWW_WVK_SOT_FK1_FRGN");

                entity.HasIndex(e => e.VknIdGeheel)
                    .HasName("NWW_WVK_VKN_FK3_FRGN");

                entity.HasIndex(e => e.VknIdLinks)
                    .HasName("NWW_WVK_VKN_FK1_FRGN");

                entity.HasIndex(e => e.VknIdRechts)
                    .HasName("NWW_WVK_VKN_FK2_FRGN");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GedwongenRijrichting)
                    .HasColumnName("GEDWONGEN_RIJRICHTING")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.JteIdBegin)
                    .HasColumnName("JTE_ID_BEGIN");

                entity.Property(e => e.JteIdEind)
                    .HasColumnName("JTE_ID_EIND");

                entity.Property(e => e.SoMutatiedatum)
                    .HasColumnName("SO_MUTATIEDATUM");

                entity.Property(e => e.SokId)
                    .HasColumnName("SOK_ID");

                entity.Property(e => e.SotId)
                    .HasColumnName("SOT_ID");

                entity.Property(e => e.VknIdGeheel)
                    .HasColumnName("VKN_ID_GEHEEL");

                entity.Property(e => e.VknIdLinks)
                    .HasColumnName("VKN_ID_LINKS");

                entity.Property(e => e.VknIdRechts)
                    .HasColumnName("VKN_ID_RECHTS");

                entity.HasOne(d => d.JteIdBeginNavigation)
                    .WithMany(p => p.NwwWegvakkenJteIdBeginNavigation)
                    .HasForeignKey(d => d.JteIdBegin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("NWW_WVK_JTE_FK1");

                entity.HasOne(d => d.JteIdEindNavigation)
                    .WithMany(p => p.NwwWegvakkenJteIdEindNavigation)
                    .HasForeignKey(d => d.JteIdEind)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("NWW_WVK_JTE_FK2");
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
