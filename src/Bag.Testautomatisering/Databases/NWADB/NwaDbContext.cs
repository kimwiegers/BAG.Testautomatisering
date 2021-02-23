using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OHx.Testautomatisering.NWADB
{
    public partial class NwaDbContext : DbContext
    {
        public NwaDbContext()
        {
        }

        public NwaDbContext(DbContextOptions<NwaDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<GgaCodeControls> GgaCodeControls { get; set; }
        public virtual DbSet<GgaGemeenteEfemeriden> GgaGemeenteEfemeriden { get; set; }
        public virtual DbSet<GgaGemeenteEfemeriden200512> GgaGemeenteEfemeriden200512 { get; set; }
        public virtual DbSet<GgaGemeenteEfemeriden779> GgaGemeenteEfemeriden779 { get; set; }
        public virtual DbSet<GgaGemeenten> GgaGemeenten { get; set; }
        public virtual DbSet<GgaGemeenten200512> GgaGemeenten200512 { get; set; }
        public virtual DbSet<GgaProvincies> GgaProvincies { get; set; }
        public virtual DbSet<GgaRefCodes> GgaRefCodes { get; set; }
        public virtual DbSet<GgaWoonplaatsen> GgaWoonplaatsen { get; set; }
        public virtual DbSet<GgaWoonplaatsen200512> GgaWoonplaatsen200512 { get; set; }
        public virtual DbSet<Mdrt83a4d> Mdrt83a4d { get; set; }
        public virtual DbSet<NwaDistricten> NwaDistricten { get; set; }
        public virtual DbSet<NwaRegionaleDiensten> NwaRegionaleDiensten { get; set; }
        public virtual DbSet<NwwGeometriebronnen> NwwGeometriebronnen { get; set; }
        public virtual DbSet<OhgVGemeenteEfemeridenA> OhgVGemeenteEfemeridenA { get; set; }
        public virtual DbSet<SdeLogfileData> SdeLogfileData { get; set; }
        public virtual DbSet<SdeLogfiles> SdeLogfiles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseOracle("Data Source=(DESCRIPTION= (ADDRESS= (PROTOCOL=tcp) (HOST=tbnm.ad.rws.nl) (PORT=1526))(CONNECT_DATA= (SID=TBNM) (GLOBAL_NAME=TBNM.rws.nl))); User ID=NWA;Password=NWA;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "NWA");

            modelBuilder.Entity<GgaCodeControls>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GGA_CODE_CONTROLS");

                entity.Property(e => e.CcComment)
                    .HasColumnName("CC_COMMENT")
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.CcDomain)
                    .IsRequired()
                    .HasColumnName("CC_DOMAIN")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CcNextValue)
                    .HasColumnName("CC_NEXT_VALUE");
            });

            modelBuilder.Entity<GgaGemeenteEfemeriden>(entity =>
            {
                entity.HasKey(e => new { e.GmeId, e.Begindatum })
                    .HasName("GEE_PK");

                entity.ToTable("GGA_GEMEENTE_EFEMERIDEN");

                entity.HasIndex(e => e.GmeId)
                    .HasName("GGA_GEE_GME_FK1_FRGN");

                entity.HasIndex(e => e.PveCode)
                    .HasName("GGA_GEE_PVE_FK1_FRGN");

                entity.HasIndex(e => e.SdeId)
                    .HasName("R30_SDE_ROWID_UK")
                    .IsUnique();

                entity.Property(e => e.GmeId)
                    .HasColumnName("GME_ID");

                entity.Property(e => e.Begindatum)
                    .HasColumnName("BEGINDATUM");

                entity.Property(e => e.Einddatum)
                    .HasColumnName("EINDDATUM");

                entity.Property(e => e.PveCode)
                    .IsRequired()
                    .HasColumnName("PVE_CODE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SdeId)
                    .HasColumnName("SDE_ID");

                entity.Property(e => e.SeAnnoCadData)
                    .HasColumnName("SE_ANNO_CAD_DATA");

                entity.HasOne(d => d.Gme)
                    .WithMany(p => p.GgaGemeenteEfemeriden)
                    .HasForeignKey(d => d.GmeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("GGA_GEE_GME_FK1");

                entity.HasOne(d => d.PveCodeNavigation)
                    .WithMany(p => p.GgaGemeenteEfemeriden)
                    .HasForeignKey(d => d.PveCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("GGA_GEE_PVE_FK1");
            });

            modelBuilder.Entity<GgaGemeenteEfemeriden200512>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GGA_GEMEENTE_EFEMERIDEN_200512");

                entity.Property(e => e.Begindatum)
                    .HasColumnName("BEGINDATUM");

                entity.Property(e => e.Einddatum)
                    .HasColumnName("EINDDATUM");

                entity.Property(e => e.GmeId)
                    .HasColumnName("GME_ID");

                entity.Property(e => e.PveCode)
                    .IsRequired()
                    .HasColumnName("PVE_CODE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SdeId)
                    .HasColumnName("SDE_ID");

                entity.Property(e => e.SeAnnoCadData)
                    .HasColumnName("SE_ANNO_CAD_DATA");
            });

            modelBuilder.Entity<GgaGemeenteEfemeriden779>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GGA_GEMEENTE_EFEMERIDEN_779");

                entity.Property(e => e.Begindatum)
                    .HasColumnName("BEGINDATUM");

                entity.Property(e => e.Einddatum)
                    .HasColumnName("EINDDATUM");

                entity.Property(e => e.GmeId)
                    .HasColumnName("GME_ID");

                entity.Property(e => e.PveCode)
                    .IsRequired()
                    .HasColumnName("PVE_CODE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SdeId)
                    .HasColumnName("SDE_ID");

                entity.Property(e => e.SeAnnoCadData)
                    .HasColumnName("SE_ANNO_CAD_DATA");
            });

            modelBuilder.Entity<GgaGemeenten>(entity =>
            {
                entity.ToTable("GGA_GEMEENTEN");

                entity.HasIndex(e => e.GmeIdInVln)
                    .HasName("GGA_GME_UK2")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID");

                entity.Property(e => e.EinddatumDialoog)
                    .HasColumnName("EINDDATUM_DIALOOG");

                entity.Property(e => e.GmeIdInVln)
                    .HasColumnName("GME_ID_IN_VLN");

                entity.Property(e => e.Naam)
                    .IsRequired()
                    .HasColumnName("NAAM")
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GgaGemeenten200512>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GGA_GEMEENTEN_200512");

                entity.Property(e => e.EinddatumDialoog)
                    .HasColumnName("EINDDATUM_DIALOOG");

                entity.Property(e => e.GmeIdInVln).HasColumnName("GME_ID_IN_VLN");

                entity.Property(e => e.Id)
                    .HasColumnName("ID");

                entity.Property(e => e.Naam)
                    .IsRequired()
                    .HasColumnName("NAAM")
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GgaProvincies>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("GGA_PVE_PK");

                entity.ToTable("GGA_PROVINCIES");

                entity.HasIndex(e => e.Id)
                    .HasName("GGA_PVE_UK2")
                    .IsUnique();

                entity.HasIndex(e => e.Naam)
                    .HasName("GGA_PVE_UK1")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID");

                entity.Property(e => e.Naam)
                    .IsRequired()
                    .HasColumnName("NAAM")
                    .HasMaxLength(24)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GgaRefCodes>(entity =>
            {
                entity.HasKey(e => new { e.RvDomain, e.RvLowValue })
                    .HasName("GGA_REF_PK");

                entity.ToTable("GGA_REF_CODES");

                entity.Property(e => e.RvDomain)
                    .HasColumnName("RV_DOMAIN")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RvLowValue)
                    .HasColumnName("RV_LOW_VALUE")
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.RvAbbreviation)
                    .HasColumnName("RV_ABBREVIATION")
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.RvHighValue)
                    .HasColumnName("RV_HIGH_VALUE")
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.RvMeaning)
                    .HasColumnName("RV_MEANING")
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.RvType)
                    .HasColumnName("RV_TYPE")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GgaWoonplaatsen>(entity =>
            {
                entity.ToTable("GGA_WOONPLAATSEN");

                entity.HasIndex(e => new { e.GmeId, e.NaamNen })
                    .HasName("GGA_WPS_UK1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID");

                entity.Property(e => e.BagId)
                    .HasColumnName("BAG_ID");

                entity.Property(e => e.GmeId)
                    .HasColumnName("GME_ID");

                entity.Property(e => e.NaamNen)
                    .IsRequired()
                    .HasColumnName("NAAM_NEN")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NaamOfficieel)
                    .HasColumnName("NAAM_OFFICIEEL")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NaamPtt)
                    .HasColumnName("NAAM_PTT")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Naamafkorting)
                    .HasColumnName("NAAMAFKORTING")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.Gme)
                    .WithMany(p => p.GgaWoonplaatsen)
                    .HasForeignKey(d => d.GmeId)
                    .HasConstraintName("GGA_WPS_GME_FK1");
            });

            modelBuilder.Entity<GgaWoonplaatsen200512>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("GGA_WOONPLAATSEN_200512");

                entity.Property(e => e.GmeId)
                    .HasColumnName("GME_ID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID");

                entity.Property(e => e.NaamNen)
                    .IsRequired()
                    .HasColumnName("NAAM_NEN")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NaamPtt)
                    .HasColumnName("NAAM_PTT")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Naamafkorting)
                    .HasColumnName("NAAMAFKORTING")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Mdrt83a4d>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MDRT_83A4D$");

                entity.Property(e => e.Info)
                    .HasColumnName("INFO");

                entity.Property(e => e.NodeId)
                    .HasColumnName("NODE_ID");

                entity.Property(e => e.NodeLevel)
                    .HasColumnName("NODE_LEVEL");
            });

            modelBuilder.Entity<NwaDistricten>(entity =>
            {
                entity.ToTable("NWA_DISTRICTEN");

                entity.HasIndex(e => e.Naam)
                    .HasName("NWA_DTT_UK2")
                    .IsUnique();

                entity.HasIndex(e => e.Nummer)
                    .HasName("NWA_DTT_UK1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID");

                entity.Property(e => e.Begindatum)
                    .HasColumnName("BEGINDATUM");

                entity.Property(e => e.Einddatum)
                    .HasColumnName("EINDDATUM");

                entity.Property(e => e.Naam)
                    .IsRequired()
                    .HasColumnName("NAAM")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Nummer).HasColumnName("NUMMER");

                entity.Property(e => e.RdtCode)
                    .IsRequired()
                    .HasColumnName("RDT_CODE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.RdtCodeNavigation)
                    .WithMany(p => p.NwaDistricten)
                    .HasForeignKey(d => d.RdtCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("NWA_DTT_RDT_FK");
            });

            modelBuilder.Entity<NwaRegionaleDiensten>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("NWA_RDT_PK");

                entity.ToTable("NWA_REGIONALE_DIENSTEN");

                entity.HasIndex(e => e.Naam)
                    .HasName("NWA_RDT_UK1")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Begindatum)
                    .HasColumnName("BEGINDATUM");

                entity.Property(e => e.Einddatum)
                    .HasColumnName("EINDDATUM");

                entity.Property(e => e.Naam)
                    .IsRequired()
                    .HasColumnName("NAAM")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NwwGeometriebronnen>(entity =>
            {
                entity.ToTable("NWW_GEOMETRIEBRONNEN");

                entity.HasIndex(e => e.Naam)
                    .HasName("NWW_GON_UK1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID");

                entity.Property(e => e.Naam)
                    .IsRequired()
                    .HasColumnName("NAAM")
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OhgVGemeenteEfemeridenA>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OHG_V_GEMEENTE_EFEMERIDEN_A");

                entity.Property(e => e.Begindatum)
                    .HasColumnName("BEGINDATUM");

                entity.Property(e => e.Einddatum)
                    .HasColumnName("EINDDATUM");

                entity.Property(e => e.GmeId)
                    .HasColumnName("GME_ID");

                entity.Property(e => e.Naam)
                    .IsRequired()
                    .HasColumnName("NAAM")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PveCode)
                    .IsRequired()
                    .HasColumnName("PVE_CODE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SdeId)
                    .HasColumnName("SDE_ID");
            });

            modelBuilder.Entity<SdeLogfileData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SDE_LOGFILE_DATA");

                entity.HasIndex(e => e.SdeRowId)
                    .HasName("SDE_LOGFILE_DATA_IDX2");

                entity.HasIndex(e => new { e.LogfileDataId, e.SdeRowId })
                    .HasName("SDE_LOGFILE_DATA_IDX1");

                entity.Property(e => e.LogfileDataId)
                    .HasColumnName("LOGFILE_DATA_ID");

                entity.Property(e => e.SdeRowId)
                    .HasColumnName("SDE_ROW_ID");
            });

            modelBuilder.Entity<SdeLogfiles>(entity =>
            {
                entity.HasKey(e => e.LogfileId)
                    .HasName("SDE_LOGFILES_PK");

                entity.ToTable("SDE_LOGFILES");

                entity.HasIndex(e => e.LogfileDataId)
                    .HasName("SDE_LOGFILES_UK2")
                    .IsUnique();

                entity.HasIndex(e => e.LogfileName)
                    .HasName("SDE_LOGFILES_UK")
                    .IsUnique();

                entity.Property(e => e.LogfileId)
                    .HasColumnName("LOGFILE_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Flags)
                    .HasColumnName("FLAGS");

                entity.Property(e => e.LogfileDataDb)
                    .HasColumnName("LOGFILE_DATA_DB")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.LogfileDataId)
                    .HasColumnName("LOGFILE_DATA_ID");

                entity.Property(e => e.LogfileDataOwner)
                    .HasColumnName("LOGFILE_DATA_OWNER")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.LogfileDataTable)
                    .HasColumnName("LOGFILE_DATA_TABLE")
                    .HasMaxLength(98)
                    .IsUnicode(false);

                entity.Property(e => e.LogfileName)
                    .IsRequired()
                    .HasColumnName("LOGFILE_NAME")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationId)
                    .HasColumnName("REGISTRATION_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.SessionTag)
                    .HasColumnName("SESSION_TAG")
                    .HasColumnType("NUMBER(38)");
            });

            modelBuilder.HasSequence("MDRS_83A4D$");

            modelBuilder.HasSequence("NWA_GEE_SEQ1");

            modelBuilder.HasSequence("NWA_GEE_SEQ2");

            modelBuilder.HasSequence("R230");

            modelBuilder.HasSequence("R30");

            modelBuilder.HasSequence("R36");

            modelBuilder.HasSequence("SDE_LOGFILE_LID_GEN");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
