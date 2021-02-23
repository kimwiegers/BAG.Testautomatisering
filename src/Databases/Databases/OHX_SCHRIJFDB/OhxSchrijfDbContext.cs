using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OHx.Testautomatisering.OHX_SCHRIJFDB
{
    public partial class OhxSchrijfDbContext : DbContext
    {
        public OhxSchrijfDbContext()
        {
        }

        public OhxSchrijfDbContext(DbContextOptions<OhxSchrijfDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<OhxBagGemeentenInit1> OhxBagGemeentenInit1 { get; set; }
        public virtual DbSet<OhxBagGgaGemeenteEfnI> OhxBagGgaGemeenteEfnI { get; set; }
        public virtual DbSet<OhxBagGgaGemeenteEfnU> OhxBagGgaGemeenteEfnU { get; set; }
        public virtual DbSet<OhxBagGgaGemeentenDiff> OhxBagGgaGemeentenDiff { get; set; }
        public virtual DbSet<OhxBagGgaGemeentenI> OhxBagGgaGemeentenI { get; set; }
        public virtual DbSet<OhxBagGgaGemeentenU> OhxBagGgaGemeentenU { get; set; }
        public virtual DbSet<OhxBagGgaStratenDiff> OhxBagGgaStratenDiff { get; set; }
        public virtual DbSet<OhxBagGgaStratenI> OhxBagGgaStratenI { get; set; }
        public virtual DbSet<OhxBagGgaStratenU> OhxBagGgaStratenU { get; set; }
        public virtual DbSet<OhxBagGgaWoonplaatsen> OhxBagGgaWoonplaatsen { get; set; }
        public virtual DbSet<OhxBagGgaWoonplaatsenDiff> OhxBagGgaWoonplaatsenDiff { get; set; }
        public virtual DbSet<OhxBagGgaWoonplaatsenInit1> OhxBagGgaWoonplaatsenInit1 { get; set; }
        public virtual DbSet<OhxBagMeldingen> OhxBagMeldingen { get; set; }
        public virtual DbSet<OhxBagNwgZoneEfnI> OhxBagNwgZoneEfnI { get; set; }
        public virtual DbSet<OhxBagNwgZoneEfnU> OhxBagNwgZoneEfnU { get; set; }
        public virtual DbSet<OhxBagNwgZoneZoneRelI> OhxBagNwgZoneZoneRelI { get; set; }
        public virtual DbSet<OhxBagNwgZoneZoneRelU> OhxBagNwgZoneZoneRelU { get; set; }
        public virtual DbSet<OhxBagNwgZonesI> OhxBagNwgZonesI { get; set; }
        public virtual DbSet<OhxBagNwgZonesU> OhxBagNwgZonesU { get; set; }
        public virtual DbSet<OhxBagNwwHectointervallenI> OhxBagNwwHectointervallenI { get; set; }
        public virtual DbSet<OhxBagNwwHectopuntenI> OhxBagNwwHectopuntenI { get; set; }
        public virtual DbSet<OhxBagNwwHectopuntenI3007> OhxBagNwwHectopuntenI3007 { get; set; }
        public virtual DbSet<OhxBagNwwHectopuntenI3107> OhxBagNwwHectopuntenI3107 { get; set; }
        public virtual DbSet<OhxBagNwwHectopuntenU> OhxBagNwwHectopuntenU { get; set; }
        public virtual DbSet<OhxBagNwwHectopuntenU3007> OhxBagNwwHectopuntenU3007 { get; set; }
        public virtual DbSet<OhxBagNwwHectopuntenU3107> OhxBagNwwHectopuntenU3107 { get; set; }
        public virtual DbSet<OhxBagNwwWeeDiff3007> OhxBagNwwWeeDiff3007 { get; set; }
        public virtual DbSet<OhxBagNwwWeeI3007Hp> OhxBagNwwWeeI3007Hp { get; set; }
        public virtual DbSet<OhxBagNwwWeeMelding3007> OhxBagNwwWeeMelding3007 { get; set; }
        public virtual DbSet<OhxBagNwwWeeMelding3107> OhxBagNwwWeeMelding3107 { get; set; }
        public virtual DbSet<OhxBagNwwWeeU3007Hp> OhxBagNwwWeeU3007Hp { get; set; }
        public virtual DbSet<OhxBagNwwWegbeheerdersI> OhxBagNwwWegbeheerdersI { get; set; }
        public virtual DbSet<OhxBagNwwWegbeheerdersU> OhxBagNwwWegbeheerdersU { get; set; }
        public virtual DbSet<OhxBagNwwWegvakEfnDiff> OhxBagNwwWegvakEfnDiff { get; set; }
        public virtual DbSet<OhxBagNwwWegvakEfnI> OhxBagNwwWegvakEfnI { get; set; }
        public virtual DbSet<OhxBagNwwWegvakEfnMelding> OhxBagNwwWegvakEfnMelding { get; set; }
        public virtual DbSet<OhxBagNwwWegvakEfnU> OhxBagNwwWegvakEfnU { get; set; }
        public virtual DbSet<OhxBagNwwWegvakEfnU3007> OhxBagNwwWegvakEfnU3007 { get; set; }
        public virtual DbSet<OhxBagNwwWegvakEfnU3107> OhxBagNwwWegvakEfnU3107 { get; set; }
        public virtual DbSet<OhxBagNwwWegvakInRoutesI> OhxBagNwwWegvakInRoutesI { get; set; }
        public virtual DbSet<OhxBagStraatnaamNen> OhxBagStraatnaamNen { get; set; }
        public virtual DbSet<OhxBagimportWoonplaatsSplit> OhxBagimportWoonplaatsSplit { get; set; }
        public virtual DbSet<OhxBagimportWpltsTestinput1> OhxBagimportWpltsTestinput1 { get; set; }
        public virtual DbSet<OhxBagupdateGgaStratenI> OhxBagupdateGgaStratenI { get; set; }
        public virtual DbSet<OhxBagupdateMeldingen> OhxBagupdateMeldingen { get; set; }
        public virtual DbSet<OhxBagupdateMeldingen3007> OhxBagupdateMeldingen3007 { get; set; }
        public virtual DbSet<OhxBagupdateMeldingen3107> OhxBagupdateMeldingen3107 { get; set; }
        public virtual DbSet<OhxBagupdateMeldingenAw> OhxBagupdateMeldingenAw { get; set; }
        public virtual DbSet<OhxBagupdateSttI3107> OhxBagupdateSttI3107 { get; set; }
        public virtual DbSet<OhxWerkgebiedenHv1> OhxWerkgebiedenHv1 { get; set; }
        public virtual DbSet<Ohxbag2HectointervallenI> Ohxbag2HectointervallenI { get; set; }
        public virtual DbSet<Ohxbag2HectopuntenU> Ohxbag2HectopuntenU { get; set; }
        public virtual DbSet<Ohxbag2UpdateMeldingen> Ohxbag2UpdateMeldingen { get; set; }
        public virtual DbSet<Ohxbag2UpdateStratenI> Ohxbag2UpdateStratenI { get; set; }
        public virtual DbSet<Ohxbag2WegbeheerdersI> Ohxbag2WegbeheerdersI { get; set; }
        public virtual DbSet<Ohxbag2WegbeheerdersU> Ohxbag2WegbeheerdersU { get; set; }
        public virtual DbSet<Ohxbag2WegvakEfnDiff> Ohxbag2WegvakEfnDiff { get; set; }
        public virtual DbSet<Ohxbag2WegvakEfnI> Ohxbag2WegvakEfnI { get; set; }
        public virtual DbSet<Ohxbag2WegvakEfnMelding> Ohxbag2WegvakEfnMelding { get; set; }
        public virtual DbSet<Ohxbag2WegvakEfnU> Ohxbag2WegvakEfnU { get; set; }
        public virtual DbSet<Ohxbag2WegvakInRoutesI> Ohxbag2WegvakInRoutesI { get; set; }
        public virtual DbSet<Ohxbag3HectointervallenI> Ohxbag3HectointervallenI { get; set; }
        public virtual DbSet<Ohxbag3HectopuntenI> Ohxbag3HectopuntenI { get; set; }
        public virtual DbSet<Ohxbag3HectopuntenU> Ohxbag3HectopuntenU { get; set; }
        public virtual DbSet<Ohxbag3UpdateMeldingen> Ohxbag3UpdateMeldingen { get; set; }
        public virtual DbSet<Ohxbag3UpdateStratenI> Ohxbag3UpdateStratenI { get; set; }
        public virtual DbSet<Ohxbag3WegbeheerdersI> Ohxbag3WegbeheerdersI { get; set; }
        public virtual DbSet<Ohxbag3WegbeheerdersU> Ohxbag3WegbeheerdersU { get; set; }
        public virtual DbSet<Ohxbag3WegvakEfnDiff> Ohxbag3WegvakEfnDiff { get; set; }
        public virtual DbSet<Ohxbag3WegvakEfnI> Ohxbag3WegvakEfnI { get; set; }
        public virtual DbSet<Ohxbag3WegvakEfnMelding> Ohxbag3WegvakEfnMelding { get; set; }
        public virtual DbSet<Ohxbag3WegvakEfnU> Ohxbag3WegvakEfnU { get; set; }
        public virtual DbSet<Ohxbag3WegvakInRoutesI> Ohxbag3WegvakInRoutesI { get; set; }
        public virtual DbSet<SdeLogfileData> SdeLogfileData { get; set; }
        public virtual DbSet<SdeLogfiles> SdeLogfiles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseOracle("Data Source=(DESCRIPTION= (ADDRESS= (PROTOCOL=tcp) (HOST=tbnm.ad.rws.nl) (PORT=1526))(CONNECT_DATA= (SID=TBNM) (GLOBAL_NAME=TBNM.rws.nl))); User ID=OHX_SCHRIJF;Password=SCHRIJF_OHX;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "OHX_SCHRIJF");
           
            modelBuilder.Entity<OhxBagGemeentenInit1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_GEMEENTEN_INIT1");

                entity.Property(e => e.Begindatumtijdvakgeldigheid)
                    .HasColumnName("BEGINDATUMTIJDVAKGELDIGHEID")
                    .HasColumnType("DATE");

                entity.Property(e => e.GemCode)
                    .HasColumnName("GEM_CODE")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.GmeId)
                    .HasColumnName("GME_ID")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.Naam)
                    .HasColumnName("NAAM")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PveCode)
                    .HasColumnName("PVE_CODE")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OhxBagGgaGemeenteEfnI>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_GGA_GEMEENTE_EFN_I");

                entity.Property(e => e.Begindatum)
                    .HasColumnName("BEGINDATUM")
                    .HasColumnType("DATE");

                entity.Property(e => e.Einddatum)
                    .HasColumnName("EINDDATUM")
                    .HasColumnType("DATE");

                entity.Property(e => e.GmeId)
                    .HasColumnName("GME_ID")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.PveCode)
                    .IsRequired()
                    .HasColumnName("PVE_CODE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SdeId)
                    .HasColumnName("SDE_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.SeAnnoCadData)
                    .HasColumnName("SE_ANNO_CAD_DATA")
                    .HasColumnType("BLOB");
            });

            modelBuilder.Entity<OhxBagGgaGemeenteEfnU>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_GGA_GEMEENTE_EFN_U");

                entity.Property(e => e.Begindatum)
                    .HasColumnName("BEGINDATUM")
                    .HasColumnType("DATE");

                entity.Property(e => e.Einddatum)
                    .HasColumnName("EINDDATUM")
                    .HasColumnType("DATE");

                entity.Property(e => e.GmeId)
                    .HasColumnName("GME_ID")
                    .HasColumnType("NUMBER(4)");
            });

            modelBuilder.Entity<OhxBagGgaGemeentenDiff>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_GGA_GEMEENTEN_DIFF");

                entity.Property(e => e.ChangeType)
                    .HasColumnName("CHANGE_TYPE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ImportAction)
                    .HasColumnName("IMPORT_ACTION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImportDate)
                    .HasColumnName("IMPORT_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.NewGmeId)
                    .HasColumnName("NEW_GME_ID")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.NewGmeName)
                    .HasColumnName("NEW_GME_NAME")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OldGmeId)
                    .HasColumnName("OLD_GME_ID")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.OldGmeName)
                    .HasColumnName("OLD_GME_NAME")
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OhxBagGgaGemeentenI>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_GGA_GEMEENTEN_I");

                entity.Property(e => e.EinddatumDialoog)
                    .HasColumnName("EINDDATUM_DIALOOG")
                    .HasColumnType("DATE");

                entity.Property(e => e.GmeIdInVln).HasColumnName("GME_ID_IN_VLN");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.Naam)
                    .IsRequired()
                    .HasColumnName("NAAM")
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OhxBagGgaGemeentenU>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_GGA_GEMEENTEN_U");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.Naam)
                    .HasColumnName("NAAM")
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OhxBagGgaStratenDiff>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_GGA_STRATEN_DIFF");

                entity.Property(e => e.BagId)
                    .HasColumnName("BAG_ID")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.GmeId)
                    .HasColumnName("GME_ID")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.GmeName)
                    .HasColumnName("GME_NAME")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ImportAction)
                    .HasColumnName("IMPORT_ACTION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImportDate)
                    .HasColumnName("IMPORT_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.StrId)
                    .HasColumnName("STR_ID")
                    .HasColumnType("NUMBER(8)");

                entity.Property(e => e.StrName)
                    .HasColumnName("STR_NAME")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.WpsId)
                    .HasColumnName("WPS_ID")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.WpsName)
                    .HasColumnName("WPS_NAME")
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OhxBagGgaStratenI>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_GGA_STRATEN_I");

                entity.Property(e => e.BagId)
                    .HasColumnName("BAG_ID")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.GmeId)
                    .HasColumnName("GME_ID")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER(8)");

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
                    .HasColumnName("WPS_ID")
                    .HasColumnType("NUMBER(4)");
            });

            modelBuilder.Entity<OhxBagGgaStratenU>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_GGA_STRATEN_U");

                entity.Property(e => e.BagId)
                    .HasColumnName("BAG_ID")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER(8)");

                entity.Property(e => e.Naam)
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
            });

            modelBuilder.Entity<OhxBagGgaWoonplaatsen>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_GGA_WOONPLAATSEN");

                entity.Property(e => e.BagId)
                    .HasColumnName("BAG_ID")
                    .HasColumnType("CHAR(4)");

                entity.Property(e => e.GmeId)
                    .HasColumnName("GME_ID")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER(4)");

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
            });

            modelBuilder.Entity<OhxBagGgaWoonplaatsenDiff>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_GGA_WOONPLAATSEN_DIFF");

                entity.Property(e => e.GmeId)
                    .HasColumnName("GME_ID")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.GmeName)
                    .HasColumnName("GME_NAME")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ImportAction)
                    .HasColumnName("IMPORT_ACTION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImportDate)
                    .HasColumnName("IMPORT_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.WpsId)
                    .HasColumnName("WPS_ID")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.WpsName)
                    .HasColumnName("WPS_NAME")
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OhxBagGgaWoonplaatsenInit1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_GGA_WOONPLAATSEN_INIT1");

                entity.Property(e => e.BagId)
                    .HasColumnName("BAG_ID")
                    .HasColumnType("CHAR(4)");

                entity.Property(e => e.Begindatumtijdvakgeldigheid)
                    .HasColumnName("BEGINDATUMTIJDVAKGELDIGHEID")
                    .HasColumnType("DATE");

                entity.Property(e => e.Gemcode)
                    .HasColumnName("GEMCODE")
                    .HasColumnType("CHAR(4)");

                entity.Property(e => e.Gemnaam)
                    .HasColumnName("GEMNAAM")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.GmeId)
                    .HasColumnName("GME_ID")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.Naam)
                    .HasColumnName("NAAM")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NaamNen)
                    .HasColumnName("NAAM_NEN")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NaamNenOrigineel)
                    .HasColumnName("NAAM_NEN_ORIGINEEL")
                    .HasMaxLength(24)
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
                    .HasColumnName("STATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OhxBagMeldingen>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_MELDINGEN");

                entity.Property(e => e.Melding)
                    .HasColumnName("MELDING")
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OhxBagNwgZoneEfnI>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_NWG_ZONE_EFN_I");

                entity.Property(e => e.Begindatum)
                    .HasColumnName("BEGINDATUM")
                    .HasColumnType("DATE");

                entity.Property(e => e.Einddatum)
                    .HasColumnName("EINDDATUM")
                    .HasColumnType("DATE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.SeAnnoCadData)
                    .HasColumnName("SE_ANNO_CAD_DATA")
                    .HasColumnType("BLOB");

                entity.Property(e => e.ZneCode)
                    .IsRequired()
                    .HasColumnName("ZNE_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ZneZntCode)
                    .IsRequired()
                    .HasColumnName("ZNE_ZNT_CODE")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OhxBagNwgZoneEfnU>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_NWG_ZONE_EFN_U");

                entity.Property(e => e.Begindatum)
                    .HasColumnName("BEGINDATUM")
                    .HasColumnType("DATE");

                entity.Property(e => e.Einddatum)
                    .HasColumnName("EINDDATUM")
                    .HasColumnType("DATE");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.ZneCode)
                    .IsRequired()
                    .HasColumnName("ZNE_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ZneZntCode)
                    .IsRequired()
                    .HasColumnName("ZNE_ZNT_CODE")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OhxBagNwgZoneZoneRelI>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_NWG_ZONE_ZONE_REL_I");

                entity.Property(e => e.Begindatum)
                    .HasColumnName("BEGINDATUM")
                    .HasColumnType("DATE");

                entity.Property(e => e.Einddatum)
                    .HasColumnName("EINDDATUM")
                    .HasColumnType("DATE");

                entity.Property(e => e.Volgnummer).HasColumnName("VOLGNUMMER");

                entity.Property(e => e.ZneCode)
                    .IsRequired()
                    .HasColumnName("ZNE_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ZneCodeSub)
                    .IsRequired()
                    .HasColumnName("ZNE_CODE_SUB")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ZneZntCode)
                    .IsRequired()
                    .HasColumnName("ZNE_ZNT_CODE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ZneZntCodeSub)
                    .IsRequired()
                    .HasColumnName("ZNE_ZNT_CODE_SUB")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OhxBagNwgZoneZoneRelU>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_NWG_ZONE_ZONE_REL_U");

                entity.Property(e => e.Begindatum)
                    .HasColumnName("BEGINDATUM")
                    .HasColumnType("DATE");

                entity.Property(e => e.Einddatum)
                    .HasColumnName("EINDDATUM")
                    .HasColumnType("DATE");

                entity.Property(e => e.ZneCode)
                    .IsRequired()
                    .HasColumnName("ZNE_CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ZneCodeSub)
                    .IsRequired()
                    .HasColumnName("ZNE_CODE_SUB")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ZneZntCode)
                    .IsRequired()
                    .HasColumnName("ZNE_ZNT_CODE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ZneZntCodeSub)
                    .IsRequired()
                    .HasColumnName("ZNE_ZNT_CODE_SUB")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OhxBagNwgZonesI>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_NWG_ZONES_I");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Naam)
                    .IsRequired()
                    .HasColumnName("NAAM")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ZntCode)
                    .IsRequired()
                    .HasColumnName("ZNT_CODE")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OhxBagNwgZonesU>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_NWG_ZONES_U");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Naam)
                    .IsRequired()
                    .HasColumnName("NAAM")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ZntCode)
                    .IsRequired()
                    .HasColumnName("ZNT_CODE")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OhxBagNwwHectointervallenI>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_NWW_HECTOINTERVALLEN_I");

                entity.Property(e => e.BaanpositieTovWol)
                    .HasColumnName("BAANPOSITIE_TOV_WOL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Beginafstand).HasColumnName("BEGINAFSTAND");

                entity.Property(e => e.BegindatumVastlegging)
                    .HasColumnName("BEGINDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.BegindatumWerkelijk)
                    .HasColumnName("BEGINDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.Beginkilometrering)
                    .HasColumnName("BEGINKILOMETRERING")
                    .HasColumnType("NUMBER(6,3)");

                entity.Property(e => e.Eindafstand).HasColumnName("EINDAFSTAND");

                entity.Property(e => e.Eindkilometrering)
                    .HasColumnName("EINDKILOMETRERING")
                    .HasColumnType("NUMBER(6,3)");

                entity.Property(e => e.WvkId).HasColumnName("WVK_ID");
            });

            modelBuilder.Entity<OhxBagNwwHectopuntenI>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_NWW_HECTOPUNTEN_I");

                entity.Property(e => e.Afstand).HasColumnName("AFSTAND");

                entity.Property(e => e.Einddatum)
                    .HasColumnName("EINDDATUM")
                    .HasColumnType("DATE");

                entity.Property(e => e.Hectometrering)
                    .HasColumnName("HECTOMETRERING")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.SdeId)
                    .HasColumnName("SDE_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.SeAnnoCadData)
                    .HasColumnName("SE_ANNO_CAD_DATA")
                    .HasColumnType("BLOB");

                entity.Property(e => e.WeeBegindatumVastlegging)
                    .HasColumnName("WEE_BEGINDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.WeeBegindatumWerkelijk)
                    .HasColumnName("WEE_BEGINDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.WeeWvkId).HasColumnName("WEE_WVK_ID");
            });

            modelBuilder.Entity<OhxBagNwwHectopuntenI3007>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_NWW_HECTOPUNTEN_I_3007");

                entity.Property(e => e.Afstand).HasColumnName("AFSTAND");

                entity.Property(e => e.Einddatum)
                    .HasColumnName("EINDDATUM")
                    .HasColumnType("DATE");

                entity.Property(e => e.Hectometrering)
                    .HasColumnName("HECTOMETRERING")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.SdeId)
                    .HasColumnName("SDE_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.SeAnnoCadData)
                    .HasColumnName("SE_ANNO_CAD_DATA")
                    .HasColumnType("BLOB");

                entity.Property(e => e.WeeBegindatumVastlegging)
                    .HasColumnName("WEE_BEGINDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.WeeBegindatumWerkelijk)
                    .HasColumnName("WEE_BEGINDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.WeeWvkId).HasColumnName("WEE_WVK_ID");
            });

            modelBuilder.Entity<OhxBagNwwHectopuntenI3107>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_NWW_HECTOPUNTEN_I_3107");

                entity.Property(e => e.Afstand).HasColumnName("AFSTAND");

                entity.Property(e => e.Einddatum)
                    .HasColumnName("EINDDATUM")
                    .HasColumnType("DATE");

                entity.Property(e => e.Hectometrering)
                    .HasColumnName("HECTOMETRERING")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.SdeId)
                    .HasColumnName("SDE_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.SeAnnoCadData)
                    .HasColumnName("SE_ANNO_CAD_DATA")
                    .HasColumnType("BLOB");

                entity.Property(e => e.WeeBegindatumVastlegging)
                    .HasColumnName("WEE_BEGINDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.WeeBegindatumWerkelijk)
                    .HasColumnName("WEE_BEGINDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.WeeWvkId).HasColumnName("WEE_WVK_ID");
            });

            modelBuilder.Entity<OhxBagNwwHectopuntenU>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_NWW_HECTOPUNTEN_U");

                entity.Property(e => e.Hectometrering)
                    .HasColumnName("HECTOMETRERING")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.WeeBegindatumVastlegging)
                    .HasColumnName("WEE_BEGINDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.WeeBegindatumWerkelijk)
                    .HasColumnName("WEE_BEGINDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.WeeWvkId).HasColumnName("WEE_WVK_ID");
            });

            modelBuilder.Entity<OhxBagNwwHectopuntenU3007>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_NWW_HECTOPUNTEN_U_3007");

                entity.Property(e => e.Hectometrering)
                    .HasColumnName("HECTOMETRERING")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.WeeBegindatumVastlegging)
                    .HasColumnName("WEE_BEGINDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.WeeBegindatumWerkelijk)
                    .HasColumnName("WEE_BEGINDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.WeeWvkId).HasColumnName("WEE_WVK_ID");
            });

            modelBuilder.Entity<OhxBagNwwHectopuntenU3107>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_NWW_HECTOPUNTEN_U_3107");

                entity.Property(e => e.Hectometrering)
                    .HasColumnName("HECTOMETRERING")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.WeeBegindatumVastlegging)
                    .HasColumnName("WEE_BEGINDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.WeeBegindatumWerkelijk)
                    .HasColumnName("WEE_BEGINDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.WeeWvkId).HasColumnName("WEE_WVK_ID");
            });

            modelBuilder.Entity<OhxBagNwwWeeDiff3007>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_NWW_WEE_DIFF_3007");

                entity.Property(e => e.BegindatumVastlegging)
                    .HasColumnName("BEGINDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.BegindatumWerkelijk)
                    .HasColumnName("BEGINDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.ChangeType)
                    .HasColumnName("CHANGE_TYPE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NewGmeId)
                    .HasColumnName("NEW_GME_ID")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.NewGmeName)
                    .HasColumnName("NEW_GME_NAME")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.NewStraatnaam)
                    .HasColumnName("NEW_STRAATNAAM")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NewSttId)
                    .HasColumnName("NEW_STT_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.OldGmeId)
                    .HasColumnName("OLD_GME_ID")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.OldGmeName)
                    .HasColumnName("OLD_GME_NAME")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.OldStraatnaam)
                    .HasColumnName("OLD_STRAATNAAM")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OldSttId)
                    .HasColumnName("OLD_STT_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.UpdateAction)
                    .HasColumnName("UPDATE_ACTION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("UPDATE_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.WvkId).HasColumnName("WVK_ID");
            });

            modelBuilder.Entity<OhxBagNwwWeeI3007Hp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_NWW_WEE_I_3007_HP");

                entity.Property(e => e.AdminRichting)
                    .HasColumnName("ADMIN_RICHTING")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BegindatumVastlegging)
                    .HasColumnName("BEGINDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.BegindatumWerkelijk)
                    .HasColumnName("BEGINDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.Bronjaar)
                    .HasColumnName("BRONJAAR")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.BstCode)
                    .HasColumnName("BST_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EHnrLinks).HasColumnName("E_HNR_LINKS");

                entity.Property(e => e.EHnrRechts).HasColumnName("E_HNR_RECHTS");

                entity.Property(e => e.EinddatumVastlegging)
                    .HasColumnName("EINDDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.EinddatumWerkelijk)
                    .HasColumnName("EINDDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.GmeId)
                    .HasColumnName("GME_ID")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.GonId)
                    .HasColumnName("GON_ID")
                    .HasColumnType("NUMBER(2)");

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

                entity.Property(e => e.JteIdBegin).HasColumnName("JTE_ID_BEGIN");

                entity.Property(e => e.JteIdEind).HasColumnName("JTE_ID_EIND");

                entity.Property(e => e.KlokBegin)
                    .HasColumnName("KLOK_BEGIN")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.KlokEind)
                    .HasColumnName("KLOK_EIND")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.LHnrLinks).HasColumnName("L_HNR_LINKS");

                entity.Property(e => e.LHnrRechts).HasColumnName("L_HNR_RECHTS");

                entity.Property(e => e.RedenWijziging)
                    .HasColumnName("REDEN_WIJZIGING")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RelatiefBaanvolgnr).HasColumnName("RELATIEF_BAANVOLGNR");

                entity.Property(e => e.RelatieveHoogte)
                    .HasColumnName("RELATIEVE_HOOGTE")
                    .HasColumnType("NUMBER(2)");

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
                    .HasColumnName("SDE_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.SeAnnoCadData)
                    .HasColumnName("SE_ANNO_CAD_DATA")
                    .HasColumnType("BLOB");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SttId)
                    .HasColumnName("STT_ID")
                    .HasColumnType("NUMBER(8)");

                entity.Property(e => e.TypeWijziging)
                    .HasColumnName("TYPE_WIJZIGING")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.VerkeersbaanIndicator)
                    .HasColumnName("VERKEERSBAAN_INDICATOR")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.WbgId)
                    .HasColumnName("WBG_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.WbrId)
                    .HasColumnName("WBR_ID")
                    .HasColumnType("NUMBER(4)");

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

                entity.Property(e => e.WvkId).HasColumnName("WVK_ID");
            });

            modelBuilder.Entity<OhxBagNwwWeeMelding3007>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_NWW_WEE_MELDING_3007");

                entity.Property(e => e.BegindatumVastlegging)
                    .HasColumnName("BEGINDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.BegindatumWerkelijk)
                    .HasColumnName("BEGINDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.ChangeType)
                    .HasColumnName("CHANGE_TYPE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.GmeId)
                    .HasColumnName("GME_ID")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.GmeNaam)
                    .HasColumnName("GME_NAAM")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.Melding)
                    .HasColumnName("MELDING")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.NaamOfficieel)
                    .HasColumnName("NAAM_OFFICIEEL")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.NewGmeId)
                    .HasColumnName("NEW_GME_ID")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.NewGmeNaam)
                    .HasColumnName("NEW_GME_NAAM")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.NewNaamOfficieel)
                    .HasColumnName("NEW_NAAM_OFFICIEEL")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.NewSttId)
                    .HasColumnName("NEW_STT_ID")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.SttId)
                    .HasColumnName("STT_ID")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.UpdateAction)
                    .HasColumnName("UPDATE_ACTION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("UPDATE_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.WvkId).HasColumnName("WVK_ID");
            });

            modelBuilder.Entity<OhxBagNwwWeeMelding3107>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_NWW_WEE_MELDING_3107");

                entity.Property(e => e.BegindatumVastlegging)
                    .HasColumnName("BEGINDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.BegindatumWerkelijk)
                    .HasColumnName("BEGINDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.ChangeType)
                    .HasColumnName("CHANGE_TYPE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.GmeId)
                    .HasColumnName("GME_ID")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.GmeNaam)
                    .HasColumnName("GME_NAAM")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.Melding)
                    .HasColumnName("MELDING")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.NaamOfficieel)
                    .HasColumnName("NAAM_OFFICIEEL")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.NewGmeId)
                    .HasColumnName("NEW_GME_ID")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.NewGmeNaam)
                    .HasColumnName("NEW_GME_NAAM")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.NewNaamOfficieel)
                    .HasColumnName("NEW_NAAM_OFFICIEEL")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.NewSttId)
                    .HasColumnName("NEW_STT_ID")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.SttId)
                    .HasColumnName("STT_ID")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.UpdateAction)
                    .HasColumnName("UPDATE_ACTION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("UPDATE_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.WvkId).HasColumnName("WVK_ID");
            });

            modelBuilder.Entity<OhxBagNwwWeeU3007Hp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_NWW_WEE_U_3007_HP");

                entity.Property(e => e.BegindatumVastlegging)
                    .HasColumnName("BEGINDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.BegindatumWerkelijk)
                    .HasColumnName("BEGINDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.EinddatumVastlegging)
                    .HasColumnName("EINDDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.WvkId).HasColumnName("WVK_ID");
            });

            modelBuilder.Entity<OhxBagNwwWegbeheerdersI>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_NWW_WEGBEHEERDERS_I");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER(4)");

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

            modelBuilder.Entity<OhxBagNwwWegbeheerdersU>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_NWW_WEGBEHEERDERS_U");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER(4)");

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

            modelBuilder.Entity<OhxBagNwwWegvakEfnDiff>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_NWW_WEGVAK_EFN_DIFF");

                entity.Property(e => e.BegindatumVastlegging)
                    .HasColumnName("BEGINDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.BegindatumWerkelijk)
                    .HasColumnName("BEGINDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.ChangeType)
                    .HasColumnName("CHANGE_TYPE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NewGmeId)
                    .HasColumnName("NEW_GME_ID");

                entity.Property(e => e.NewGmeName)
                    .HasColumnName("NEW_GME_NAME")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.NewStraatnaam)
                    .HasColumnName("NEW_STRAATNAAM")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NewSttId)
                    .HasColumnName("NEW_STT_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.OldGmeId)
                    .HasColumnName("OLD_GME_ID");

                entity.Property(e => e.OldGmeName)
                    .HasColumnName("OLD_GME_NAME")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.OldStraatnaam)
                    .HasColumnName("OLD_STRAATNAAM")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OldSttId)
                    .HasColumnName("OLD_STT_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.UpdateAction)
                    .HasColumnName("UPDATE_ACTION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("UPDATE_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.WvkId).HasColumnName("WVK_ID");
            });

            modelBuilder.Entity<OhxBagNwwWegvakEfnI>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_NWW_WEGVAK_EFN_I");

                entity.Property(e => e.AdminRichting)
                    .HasColumnName("ADMIN_RICHTING")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BegindatumVastlegging)
                    .HasColumnName("BEGINDATUM_VASTLEGGING")
                    .HasDefaultValueSql("trunc(sysdate) ");

                entity.Property(e => e.BegindatumWerkelijk)
                    .HasColumnName("BEGINDATUM_WERKELIJK");

                entity.Property(e => e.Bronjaar)
                    .HasColumnName("BRONJAAR");

                entity.Property(e => e.BstCode)
                    .HasColumnName("BST_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EHnrLinks).HasColumnName("E_HNR_LINKS");

                entity.Property(e => e.EHnrRechts).HasColumnName("E_HNR_RECHTS");

                entity.Property(e => e.EinddatumVastlegging)
                    .HasColumnName("EINDDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

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

                entity.Property(e => e.JteIdBegin).HasColumnName("JTE_ID_BEGIN");

                entity.Property(e => e.JteIdEind).HasColumnName("JTE_ID_EIND");

                entity.Property(e => e.KlokBegin)
                    .HasColumnName("KLOK_BEGIN");

                entity.Property(e => e.KlokEind)
                    .HasColumnName("KLOK_EIND");

                entity.Property(e => e.LHnrLinks).HasColumnName("L_HNR_LINKS");

                entity.Property(e => e.LHnrRechts).HasColumnName("L_HNR_RECHTS");

                entity.Property(e => e.RedenWijziging)
                    .HasColumnName("REDEN_WIJZIGING")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RelatiefBaanvolgnr).HasColumnName("RELATIEF_BAANVOLGNR");

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

                entity.Property(e => e.WvkId).HasColumnName("WVK_ID");
            });

            modelBuilder.Entity<OhxBagNwwWegvakEfnMelding>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_NWW_WEGVAK_EFN_MELDING");

                entity.Property(e => e.BegindatumVastlegging)
                    .HasColumnName("BEGINDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.BegindatumWerkelijk)
                    .HasColumnName("BEGINDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.ChangeType)
                    .HasColumnName("CHANGE_TYPE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.GmeId)
                    .HasColumnName("GME_ID")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.GmeNaam)
                    .HasColumnName("GME_NAAM")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.Melding)
                    .HasColumnName("MELDING")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.NaamOfficieel)
                    .HasColumnName("NAAM_OFFICIEEL")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.NewGmeId)
                    .HasColumnName("NEW_GME_ID")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.NewGmeNaam)
                    .HasColumnName("NEW_GME_NAAM")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.NewNaamOfficieel)
                    .HasColumnName("NEW_NAAM_OFFICIEEL")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.NewSttId)
                    .HasColumnName("NEW_STT_ID")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.Query)
                    .HasColumnName("QUERY")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.SttId)
                    .HasColumnName("STT_ID")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.UpdateAction)
                    .HasColumnName("UPDATE_ACTION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("UPDATE_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.WvkId).HasColumnName("WVK_ID");
            });

            modelBuilder.Entity<OhxBagNwwWegvakEfnU>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_NWW_WEGVAK_EFN_U");

                entity.Property(e => e.BegindatumVastlegging)
                    .HasColumnName("BEGINDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.BegindatumWerkelijk)
                    .HasColumnName("BEGINDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.EinddatumVastlegging)
                    .HasColumnName("EINDDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.WvkId).HasColumnName("WVK_ID");
            });

            modelBuilder.Entity<OhxBagNwwWegvakEfnU3007>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_NWW_WEGVAK_EFN_U_3007");

                entity.Property(e => e.BegindatumVastlegging)
                    .HasColumnName("BEGINDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.BegindatumWerkelijk)
                    .HasColumnName("BEGINDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.EinddatumVastlegging)
                    .HasColumnName("EINDDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.WvkId).HasColumnName("WVK_ID");
            });

            modelBuilder.Entity<OhxBagNwwWegvakEfnU3107>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_NWW_WEGVAK_EFN_U_3107");

                entity.Property(e => e.BegindatumVastlegging)
                    .HasColumnName("BEGINDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.BegindatumWerkelijk)
                    .HasColumnName("BEGINDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.EinddatumVastlegging)
                    .HasColumnName("EINDDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.WvkId).HasColumnName("WVK_ID");
            });

            modelBuilder.Entity<OhxBagNwwWegvakInRoutesI>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_NWW_WEGVAK_IN_ROUTES_I");

                entity.Property(e => e.RteId).HasColumnName("RTE_ID");

                entity.Property(e => e.WeeBegindatumVastlegging)
                    .HasColumnName("WEE_BEGINDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.WeeBegindatumWerkelijk)
                    .HasColumnName("WEE_BEGINDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.WeeWvkId).HasColumnName("WEE_WVK_ID");
            });

            modelBuilder.Entity<OhxBagStraatnaamNen>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAG_STRAATNAAM_NEN");

                entity.Property(e => e.Nen)
                    .HasColumnName("NEN")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Straatnaam)
                    .IsRequired()
                    .HasColumnName("STRAATNAAM")
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OhxBagimportWoonplaatsSplit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAGIMPORT_WOONPLAATS_SPLIT");

                entity.Property(e => e.AanduidingCorrectie)
                    .HasColumnName("AANDUIDING_CORRECTIE")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.AanduidingInactief)
                    .HasColumnName("AANDUIDING_INACTIEF")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Begindatumtijdvakgeldigheid)
                    .HasColumnName("BEGINDATUMTIJDVAKGELDIGHEID")
                    .HasColumnType("DATE");

                entity.Property(e => e.Documentdatum)
                    .HasColumnName("DOCUMENTDATUM")
                    .HasColumnType("DATE");

                entity.Property(e => e.Documentnummer)
                    .HasColumnName("DOCUMENTNUMMER")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Einddatumtijdvakgeldigheid)
                    .HasColumnName("EINDDATUMTIJDVAKGELDIGHEID")
                    .HasColumnType("DATE");

                entity.Property(e => e.Gemcode)
                    .HasColumnName("GEMCODE")
                    .HasColumnType("CHAR(4)");

                entity.Property(e => e.Gemnaam)
                    .HasColumnName("GEMNAAM")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Identificatie)
                    .HasColumnName("IDENTIFICATIE")
                    .HasColumnType("CHAR(4)");

                entity.Property(e => e.IndicatieGeconstateerd)
                    .HasColumnName("INDICATIE_GECONSTATEERD")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Inonderzoek)
                    .HasColumnName("INONDERZOEK")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Key)
                    .HasColumnName("KEY")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Mutatiedatum)
                    .HasColumnName("MUTATIEDATUM")
                    .HasColumnType("DATE");

                entity.Property(e => e.Naam)
                    .HasColumnName("NAAM")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OhxBagimportWpltsTestinput1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAGIMPORT_WPLTS_TESTINPUT1");

                entity.HasIndex(e => e.Id)
                    .HasName("R60067747_SDE_ROWID_UK")
                    .IsUnique();

                entity.Property(e => e.AanduidingCorrectie)
                    .HasColumnName("AANDUIDING_CORRECTIE")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.AanduidingInactief)
                    .HasColumnName("AANDUIDING_INACTIEF")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Begindatumtijdvakgeldigheid)
                    .HasColumnName("BEGINDATUMTIJDVAKGELDIGHEID")
                    .HasColumnType("DATE");

                entity.Property(e => e.Documentdatum)
                    .HasColumnName("DOCUMENTDATUM")
                    .HasColumnType("DATE");

                entity.Property(e => e.Documentnummer)
                    .HasColumnName("DOCUMENTNUMMER")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.Einddatumtijdvakgeldigheid)
                    .HasColumnName("EINDDATUMTIJDVAKGELDIGHEID")
                    .HasColumnType("DATE");

                entity.Property(e => e.Gemcode)
                    .HasColumnName("GEMCODE")
                    .HasColumnType("CHAR(4)");

                entity.Property(e => e.Gemnaam)
                    .HasColumnName("GEMNAAM")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Identificatie)
                    .HasColumnName("IDENTIFICATIE")
                    .HasColumnType("CHAR(4)");

                entity.Property(e => e.IndicatieGeconstateerd)
                    .HasColumnName("INDICATIE_GECONSTATEERD")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Inonderzoek)
                    .HasColumnName("INONDERZOEK")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Key)
                    .HasColumnName("KEY")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Mutatiedatum)
                    .HasColumnName("MUTATIEDATUM")
                    .HasColumnType("DATE");

                entity.Property(e => e.Naam)
                    .HasColumnName("NAAM")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SeAnnoCadData)
                    .HasColumnName("SE_ANNO_CAD_DATA")
                    .HasColumnType("BLOB");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OhxBagupdateGgaStratenI>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAGUPDATE_GGA_STRATEN_I");

                entity.Property(e => e.BagId)
                    .HasColumnName("BAG_ID")
                    .HasColumnType("CHAR(16)");

                entity.Property(e => e.GmeId)
                    .HasColumnName("GME_ID")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER(8)");

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
                    .HasColumnName("WPS_ID")
                    .HasColumnType("NUMBER(4)");
            });

            modelBuilder.Entity<OhxBagupdateMeldingen>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAGUPDATE_MELDINGEN");

                entity.Property(e => e.Melding)
                    .HasColumnName("MELDING")
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OhxBagupdateMeldingen3007>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAGUPDATE_MELDINGEN_3007");

                entity.Property(e => e.Melding)
                    .HasColumnName("MELDING")
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OhxBagupdateMeldingen3107>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAGUPDATE_MELDINGEN_3107");

                entity.Property(e => e.Melding)
                    .HasColumnName("MELDING")
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OhxBagupdateMeldingenAw>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAGUPDATE_MELDINGEN_AW");

                entity.Property(e => e.Melding)
                    .HasColumnName("MELDING")
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OhxBagupdateSttI3107>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_BAGUPDATE_STT_I_3107");

                entity.Property(e => e.BagId)
                    .HasColumnName("BAG_ID")
                    .HasColumnType("CHAR(16)");

                entity.Property(e => e.GmeId)
                    .HasColumnName("GME_ID")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER(8)");

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
                    .HasColumnName("WPS_ID")
                    .HasColumnType("NUMBER(4)");
            });

            modelBuilder.Entity<OhxWerkgebiedenHv1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHX_WERKGEBIEDEN_HV1");

                entity.Property(e => e.Creatiedatum)
                    .HasColumnName("CREATIEDATUM")
                    .HasColumnType("DATE");

                entity.Property(e => e.FmeJobId)
                    .HasColumnName("FME_JOB_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Gebruiker)
                    .HasColumnName("GEBRUIKER")
                    .HasMaxLength(100);

                entity.Property(e => e.GebruikerId)
                    .HasColumnName("GEBRUIKER_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.JobId)
                    .HasColumnName("JOB_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.JobStatus).HasColumnName("JOB_STATUS");

                entity.Property(e => e.JobType).HasColumnName("JOB_TYPE");

                entity.Property(e => e.Objectid)
                    .HasColumnName("OBJECTID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.Omschrijving)
                    .HasColumnName("OMSCHRIJVING")
                    .HasMaxLength(200);

                entity.Property(e => e.Uitcheckdatum)
                    .HasColumnName("UITCHECKDATUM")
                    .HasColumnType("DATE");
            });

            modelBuilder.Entity<Ohxbag2HectointervallenI>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHXBAG_2_HECTOINTERVALLEN_I");

                entity.Property(e => e.BaanpositieTovWol)
                    .HasColumnName("BAANPOSITIE_TOV_WOL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Beginafstand).HasColumnName("BEGINAFSTAND");

                entity.Property(e => e.BegindatumVastlegging)
                    .HasColumnName("BEGINDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.BegindatumWerkelijk)
                    .HasColumnName("BEGINDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.Beginkilometrering)
                    .HasColumnName("BEGINKILOMETRERING")
                    .HasColumnType("NUMBER(6,3)");

                entity.Property(e => e.Eindafstand).HasColumnName("EINDAFSTAND");

                entity.Property(e => e.Eindkilometrering)
                    .HasColumnName("EINDKILOMETRERING")
                    .HasColumnType("NUMBER(6,3)");

                entity.Property(e => e.WvkId).HasColumnName("WVK_ID");
            });

            modelBuilder.Entity<Ohxbag2HectopuntenU>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHXBAG_2_HECTOPUNTEN_U");

                entity.Property(e => e.Hectometrering)
                    .HasColumnName("HECTOMETRERING")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.WeeBegindatumVastlegging)
                    .HasColumnName("WEE_BEGINDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.WeeBegindatumWerkelijk)
                    .HasColumnName("WEE_BEGINDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.WeeWvkId).HasColumnName("WEE_WVK_ID");
            });

            modelBuilder.Entity<Ohxbag2UpdateMeldingen>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHXBAG_2_UPDATE_MELDINGEN");

                entity.Property(e => e.Melding)
                    .HasColumnName("MELDING")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ohxbag2UpdateStratenI>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHXBAG_2_UPDATE_STRATEN_I");

                entity.Property(e => e.GmeId)
                    .HasColumnName("GME_ID")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER(8)");

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
                    .HasColumnName("WPS_ID")
                    .HasColumnType("NUMBER(4)");
            });

            modelBuilder.Entity<Ohxbag2WegbeheerdersI>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHXBAG_2_WEGBEHEERDERS_I");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER(4)");

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
            });

            modelBuilder.Entity<Ohxbag2WegbeheerdersU>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHXBAG_2_WEGBEHEERDERS_U");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER(4)");

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
            });

            modelBuilder.Entity<Ohxbag2WegvakEfnDiff>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHXBAG_2_WEGVAK_EFN_DIFF");

                entity.Property(e => e.BegindatumVastlegging)
                    .HasColumnName("BEGINDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.BegindatumWerkelijk)
                    .HasColumnName("BEGINDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.ChangeType)
                    .HasColumnName("CHANGE_TYPE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NewGmeId)
                    .HasColumnName("NEW_GME_ID")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.NewGmeName)
                    .HasColumnName("NEW_GME_NAME")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.NewStraatnaam)
                    .HasColumnName("NEW_STRAATNAAM")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NewSttId)
                    .HasColumnName("NEW_STT_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.OldGmeId)
                    .HasColumnName("OLD_GME_ID")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.OldGmeName)
                    .HasColumnName("OLD_GME_NAME")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.OldStraatnaam)
                    .HasColumnName("OLD_STRAATNAAM")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OldSttId)
                    .HasColumnName("OLD_STT_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.UpdateAction)
                    .HasColumnName("UPDATE_ACTION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("UPDATE_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.WvkId).HasColumnName("WVK_ID");
            });

            modelBuilder.Entity<Ohxbag2WegvakEfnI>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHXBAG_2_WEGVAK_EFN_I");

                entity.Property(e => e.AdminRichting)
                    .HasColumnName("ADMIN_RICHTING")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BegindatumVastlegging)
                    .HasColumnName("BEGINDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.BegindatumWerkelijk)
                    .HasColumnName("BEGINDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.Bronjaar)
                    .HasColumnName("BRONJAAR")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.BstCode)
                    .HasColumnName("BST_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EHnrLinks).HasColumnName("E_HNR_LINKS");

                entity.Property(e => e.EHnrRechts).HasColumnName("E_HNR_RECHTS");

                entity.Property(e => e.EinddatumVastlegging)
                    .HasColumnName("EINDDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.EinddatumWerkelijk)
                    .HasColumnName("EINDDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.GmeId)
                    .HasColumnName("GME_ID")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.GonId)
                    .HasColumnName("GON_ID")
                    .HasColumnType("NUMBER(2)");

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

                entity.Property(e => e.JteIdBegin).HasColumnName("JTE_ID_BEGIN");

                entity.Property(e => e.JteIdEind).HasColumnName("JTE_ID_EIND");

                entity.Property(e => e.KlokBegin)
                    .HasColumnName("KLOK_BEGIN")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.KlokEind)
                    .HasColumnName("KLOK_EIND")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.LHnrLinks).HasColumnName("L_HNR_LINKS");

                entity.Property(e => e.LHnrRechts).HasColumnName("L_HNR_RECHTS");

                entity.Property(e => e.RedenWijziging)
                    .HasColumnName("REDEN_WIJZIGING")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RelatiefBaanvolgnr).HasColumnName("RELATIEF_BAANVOLGNR");

                entity.Property(e => e.Rijrichting)
                    .HasColumnName("RIJRICHTING")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RpeCode)
                    .HasColumnName("RPE_CODE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SdeId)
                    .HasColumnName("SDE_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.SeAnnoCadData)
                    .HasColumnName("SE_ANNO_CAD_DATA")
                    .HasColumnType("BLOB");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SttId)
                    .HasColumnName("STT_ID")
                    .HasColumnType("NUMBER(8)");

                entity.Property(e => e.TypeWijziging)
                    .HasColumnName("TYPE_WIJZIGING")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.VerkeersbaanIndicator)
                    .HasColumnName("VERKEERSBAAN_INDICATOR")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.WbgId)
                    .HasColumnName("WBG_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.WbrId)
                    .HasColumnName("WBR_ID")
                    .HasColumnType("NUMBER(4)");

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

                entity.Property(e => e.WvkId).HasColumnName("WVK_ID");
            });

            modelBuilder.Entity<Ohxbag2WegvakEfnMelding>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHXBAG_2_WEGVAK_EFN_MELDING");

                entity.Property(e => e.BegindatumVastlegging)
                    .HasColumnName("BEGINDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.BegindatumWerkelijk)
                    .HasColumnName("BEGINDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.ChangeType)
                    .HasColumnName("CHANGE_TYPE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.GmeId)
                    .HasColumnName("GME_ID")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.GmeNaam)
                    .HasColumnName("GME_NAAM")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.Melding)
                    .HasColumnName("MELDING")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.NaamOfficieel)
                    .HasColumnName("NAAM_OFFICIEEL")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.NewGmeId)
                    .HasColumnName("NEW_GME_ID")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.NewGmeNaam)
                    .HasColumnName("NEW_GME_NAAM")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.NewNaamOfficieel)
                    .HasColumnName("NEW_NAAM_OFFICIEEL")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.NewSttId)
                    .HasColumnName("NEW_STT_ID")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.SttId)
                    .HasColumnName("STT_ID")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.UpdateAction)
                    .HasColumnName("UPDATE_ACTION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("UPDATE_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.WvkId).HasColumnName("WVK_ID");
            });

            modelBuilder.Entity<Ohxbag2WegvakEfnU>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHXBAG_2_WEGVAK_EFN_U");

                entity.Property(e => e.BegindatumVastlegging)
                    .HasColumnName("BEGINDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.BegindatumWerkelijk)
                    .HasColumnName("BEGINDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.EinddatumVastlegging)
                    .HasColumnName("EINDDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.WvkId).HasColumnName("WVK_ID");
            });

            modelBuilder.Entity<Ohxbag2WegvakInRoutesI>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHXBAG_2_WEGVAK_IN_ROUTES_I");

                entity.Property(e => e.RteId).HasColumnName("RTE_ID");

                entity.Property(e => e.WeeBegindatumVastlegging)
                    .HasColumnName("WEE_BEGINDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.WeeBegindatumWerkelijk)
                    .HasColumnName("WEE_BEGINDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.WeeWvkId).HasColumnName("WEE_WVK_ID");
            });

            modelBuilder.Entity<Ohxbag3HectointervallenI>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHXBAG_3_HECTOINTERVALLEN_I");

                entity.Property(e => e.BaanpositieTovWol)
                    .HasColumnName("BAANPOSITIE_TOV_WOL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Beginafstand).HasColumnName("BEGINAFSTAND");

                entity.Property(e => e.BegindatumVastlegging)
                    .HasColumnName("BEGINDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.BegindatumWerkelijk)
                    .HasColumnName("BEGINDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.Beginkilometrering)
                    .HasColumnName("BEGINKILOMETRERING")
                    .HasColumnType("NUMBER(6,3)");

                entity.Property(e => e.Eindafstand).HasColumnName("EINDAFSTAND");

                entity.Property(e => e.Eindkilometrering)
                    .HasColumnName("EINDKILOMETRERING")
                    .HasColumnType("NUMBER(6,3)");

                entity.Property(e => e.WvkId).HasColumnName("WVK_ID");
            });

            modelBuilder.Entity<Ohxbag3HectopuntenI>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHXBAG_3_HECTOPUNTEN_I");

                entity.Property(e => e.Afstand).HasColumnName("AFSTAND");

                entity.Property(e => e.Einddatum)
                    .HasColumnName("EINDDATUM")
                    .HasColumnType("DATE");

                entity.Property(e => e.Hectometrering)
                    .HasColumnName("HECTOMETRERING")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.SdeId)
                    .HasColumnName("SDE_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.SeAnnoCadData)
                    .HasColumnName("SE_ANNO_CAD_DATA")
                    .HasColumnType("BLOB");

                entity.Property(e => e.WeeBegindatumVastlegging)
                    .HasColumnName("WEE_BEGINDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.WeeBegindatumWerkelijk)
                    .HasColumnName("WEE_BEGINDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.WeeWvkId).HasColumnName("WEE_WVK_ID");
            });

            modelBuilder.Entity<Ohxbag3HectopuntenU>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHXBAG_3_HECTOPUNTEN_U");

                entity.Property(e => e.Hectometrering)
                    .HasColumnName("HECTOMETRERING")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.WeeBegindatumVastlegging)
                    .HasColumnName("WEE_BEGINDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.WeeBegindatumWerkelijk)
                    .HasColumnName("WEE_BEGINDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.WeeWvkId).HasColumnName("WEE_WVK_ID");
            });

            modelBuilder.Entity<Ohxbag3UpdateMeldingen>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHXBAG_3_UPDATE_MELDINGEN");

                entity.Property(e => e.Melding)
                    .HasColumnName("MELDING")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ohxbag3UpdateStratenI>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHXBAG_3_UPDATE_STRATEN_I");

                entity.Property(e => e.GmeId)
                    .HasColumnName("GME_ID")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER(8)");

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
                    .HasColumnName("WPS_ID")
                    .HasColumnType("NUMBER(4)");
            });

            modelBuilder.Entity<Ohxbag3WegbeheerdersI>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHXBAG_3_WEGBEHEERDERS_I");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER(4)");

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
            });

            modelBuilder.Entity<Ohxbag3WegbeheerdersU>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHXBAG_3_WEGBEHEERDERS_U");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("CODE")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER(4)");

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
            });

            modelBuilder.Entity<Ohxbag3WegvakEfnDiff>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHXBAG_3_WEGVAK_EFN_DIFF");

                entity.Property(e => e.BegindatumVastlegging)
                    .HasColumnName("BEGINDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.BegindatumWerkelijk)
                    .HasColumnName("BEGINDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.ChangeType)
                    .HasColumnName("CHANGE_TYPE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NewGmeId)
                    .HasColumnName("NEW_GME_ID")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.NewGmeName)
                    .HasColumnName("NEW_GME_NAME")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.NewStraatnaam)
                    .HasColumnName("NEW_STRAATNAAM")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NewSttId)
                    .HasColumnName("NEW_STT_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.OldGmeId)
                    .HasColumnName("OLD_GME_ID")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.OldGmeName)
                    .HasColumnName("OLD_GME_NAME")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.OldStraatnaam)
                    .HasColumnName("OLD_STRAATNAAM")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OldSttId)
                    .HasColumnName("OLD_STT_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.UpdateAction)
                    .HasColumnName("UPDATE_ACTION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("UPDATE_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.WvkId).HasColumnName("WVK_ID");
            });

            modelBuilder.Entity<Ohxbag3WegvakEfnI>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHXBAG_3_WEGVAK_EFN_I");

                entity.Property(e => e.AdminRichting)
                    .HasColumnName("ADMIN_RICHTING")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BegindatumVastlegging)
                    .HasColumnName("BEGINDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.BegindatumWerkelijk)
                    .HasColumnName("BEGINDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.Bronjaar)
                    .HasColumnName("BRONJAAR")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.BstCode)
                    .HasColumnName("BST_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EHnrLinks).HasColumnName("E_HNR_LINKS");

                entity.Property(e => e.EHnrRechts).HasColumnName("E_HNR_RECHTS");

                entity.Property(e => e.EinddatumVastlegging)
                    .HasColumnName("EINDDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.EinddatumWerkelijk)
                    .HasColumnName("EINDDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.GmeId)
                    .HasColumnName("GME_ID")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.GonId)
                    .HasColumnName("GON_ID")
                    .HasColumnType("NUMBER(2)");

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

                entity.Property(e => e.JteIdBegin).HasColumnName("JTE_ID_BEGIN");

                entity.Property(e => e.JteIdEind).HasColumnName("JTE_ID_EIND");

                entity.Property(e => e.KlokBegin)
                    .HasColumnName("KLOK_BEGIN")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.KlokEind)
                    .HasColumnName("KLOK_EIND")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.LHnrLinks).HasColumnName("L_HNR_LINKS");

                entity.Property(e => e.LHnrRechts).HasColumnName("L_HNR_RECHTS");

                entity.Property(e => e.RedenWijziging)
                    .HasColumnName("REDEN_WIJZIGING")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RelatiefBaanvolgnr).HasColumnName("RELATIEF_BAANVOLGNR");

                entity.Property(e => e.Rijrichting)
                    .HasColumnName("RIJRICHTING")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RpeCode)
                    .HasColumnName("RPE_CODE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SdeId)
                    .HasColumnName("SDE_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.SeAnnoCadData)
                    .HasColumnName("SE_ANNO_CAD_DATA")
                    .HasColumnType("BLOB");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SttId)
                    .HasColumnName("STT_ID")
                    .HasColumnType("NUMBER(8)");

                entity.Property(e => e.TypeWijziging)
                    .HasColumnName("TYPE_WIJZIGING")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.VerkeersbaanIndicator)
                    .HasColumnName("VERKEERSBAAN_INDICATOR")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.WbgId)
                    .HasColumnName("WBG_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.WbrId)
                    .HasColumnName("WBR_ID")
                    .HasColumnType("NUMBER(4)");

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

                entity.Property(e => e.WvkId).HasColumnName("WVK_ID");
            });

            modelBuilder.Entity<Ohxbag3WegvakEfnMelding>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHXBAG_3_WEGVAK_EFN_MELDING");

                entity.Property(e => e.BegindatumVastlegging)
                    .HasColumnName("BEGINDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.BegindatumWerkelijk)
                    .HasColumnName("BEGINDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.ChangeType)
                    .HasColumnName("CHANGE_TYPE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.GmeId)
                    .HasColumnName("GME_ID")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.GmeNaam)
                    .HasColumnName("GME_NAAM")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.Melding)
                    .HasColumnName("MELDING")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.NaamOfficieel)
                    .HasColumnName("NAAM_OFFICIEEL")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.NewGmeId)
                    .HasColumnName("NEW_GME_ID")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.NewGmeNaam)
                    .HasColumnName("NEW_GME_NAAM")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.NewNaamOfficieel)
                    .HasColumnName("NEW_NAAM_OFFICIEEL")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.NewSttId)
                    .HasColumnName("NEW_STT_ID")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.SttId)
                    .HasColumnName("STT_ID")
                    .HasColumnType("CHAR(200)");

                entity.Property(e => e.UpdateAction)
                    .HasColumnName("UPDATE_ACTION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("UPDATE_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.WvkId).HasColumnName("WVK_ID");
            });

            modelBuilder.Entity<Ohxbag3WegvakEfnU>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHXBAG_3_WEGVAK_EFN_U");

                entity.Property(e => e.BegindatumVastlegging)
                    .HasColumnName("BEGINDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.BegindatumWerkelijk)
                    .HasColumnName("BEGINDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.EinddatumVastlegging)
                    .HasColumnName("EINDDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.WvkId).HasColumnName("WVK_ID");
            });

            modelBuilder.Entity<Ohxbag3WegvakInRoutesI>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OHXBAG_3_WEGVAK_IN_ROUTES_I");

                entity.Property(e => e.RteId).HasColumnName("RTE_ID");

                entity.Property(e => e.WeeBegindatumVastlegging)
                    .HasColumnName("WEE_BEGINDATUM_VASTLEGGING")
                    .HasColumnType("DATE");

                entity.Property(e => e.WeeBegindatumWerkelijk)
                    .HasColumnName("WEE_BEGINDATUM_WERKELIJK")
                    .HasColumnType("DATE");

                entity.Property(e => e.WeeWvkId).HasColumnName("WEE_WVK_ID");
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
                    .HasColumnName("LOGFILE_DATA_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.SdeRowId)
                    .HasColumnName("SDE_ROW_ID")
                    .HasColumnType("NUMBER(38)");
            });

            modelBuilder.Entity<SdeLogfiles>(entity =>
            {
                entity.HasKey(e => e.LogfileId)
                    .HasName("SDE_LOGFILES_PK");

                entity.ToTable("SDE_LOGFILES");

                entity.HasIndex(e => e.LogfileName)
                    .HasName("SDE_LOGFILES_UK")
                    .IsUnique();

                entity.Property(e => e.LogfileId)
                    .HasColumnName("LOGFILE_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.ColumnName)
                    .HasColumnName("COLUMN_NAME")
                    .HasMaxLength(32);

                entity.Property(e => e.Flags)
                    .HasColumnName("FLAGS")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.LogfileDataDb)
                    .HasColumnName("LOGFILE_DATA_DB")
                    .HasMaxLength(32);

                entity.Property(e => e.LogfileDataId)
                    .HasColumnName("LOGFILE_DATA_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.LogfileDataOwner)
                    .HasColumnName("LOGFILE_DATA_OWNER")
                    .HasMaxLength(32);

                entity.Property(e => e.LogfileDataTable)
                    .HasColumnName("LOGFILE_DATA_TABLE")
                    .HasMaxLength(98);

                entity.Property(e => e.LogfileName)
                    .IsRequired()
                    .HasColumnName("LOGFILE_NAME")
                    .HasMaxLength(256);

                entity.Property(e => e.RegistrationId)
                    .HasColumnName("REGISTRATION_ID")
                    .HasColumnType("NUMBER(38)");

                entity.Property(e => e.SessionTag)
                    .HasColumnName("SESSION_TAG")
                    .HasColumnType("NUMBER(38)");
            });
           
            modelBuilder.HasSequence("FME_INDEX_SEQ");

            modelBuilder.HasSequence("MDRS_8A4F9$");

            modelBuilder.HasSequence("MDRS_8A705$");

            modelBuilder.HasSequence("MDRS_8A7A4$");

            modelBuilder.HasSequence("MDRS_8A8B5$");

            modelBuilder.HasSequence("R60067747");

            modelBuilder.HasSequence("SDE_LOGFILE_LID_GEN");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
