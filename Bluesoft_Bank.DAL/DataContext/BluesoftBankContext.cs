using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Bluesoft_Bank.DAL.DataContext;

public partial class BluesoftBankContext : DbContext
{
    public BluesoftBankContext()
    {
    }

    public BluesoftBankContext(DbContextOptions<BluesoftBankContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<PersonaNatural> PersonaNaturals { get; set; }

    public virtual DbSet<TipoCuenta> TipoCuenta { get; set; }

    public virtual DbSet<TipoTransaccion> TipoTransaccions { get; set; }

    public virtual DbSet<Transaccion> Transaccions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(local);DataBase=Bluesoft_Bank;Integrated Security=true;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Empresa__3214EC078C4333AA");

            entity.ToTable("Empresa");

            entity.Property(e => e.Contraseña).HasMaxLength(250);
            entity.Property(e => e.Correo).HasMaxLength(100);
            entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.TipoCuenta).WithMany(p => p.Empresas)
                .HasForeignKey(d => d.TipoCuentaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Empresa__TipoCue__7C4F7684");
        });

        modelBuilder.Entity<PersonaNatural>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PersonaN__3214EC079937C2BE");

            entity.ToTable("PersonaNatural");

            entity.Property(e => e.Contraseña).HasMaxLength(250);
            entity.Property(e => e.Correo).HasMaxLength(100);
            entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.TipoCuenta).WithMany(p => p.PersonaNaturals)
                .HasForeignKey(d => d.TipoCuentaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PersonaNa__TipoC__00200768");
        });

        modelBuilder.Entity<TipoCuenta>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TipoCuen__3214EC07E20394C2");

            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<TipoTransaccion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TipoTran__3214EC0709EEBAB6");

            entity.ToTable("TipoTransaccion");

            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Transaccion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Transacc__3214EC0703E2CC26");

            entity.ToTable("Transaccion");

            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Valor).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Empresa).WithMany(p => p.Transaccions)
                .HasForeignKey(d => d.EmpresaId)
                .HasConstraintName("FK__Transacci__Empre__06CD04F7");

            entity.HasOne(d => d.PersonaNatural).WithMany(p => p.Transaccions)
                .HasForeignKey(d => d.PersonaNaturalId)
                .HasConstraintName("FK__Transacci__Perso__05D8E0BE");

            entity.HasOne(d => d.TipoCuenta).WithMany(p => p.Transaccions)
                .HasForeignKey(d => d.TipoCuentaId)
                .HasConstraintName("FK__Transacci__TipoC__04E4BC85");

            entity.HasOne(d => d.TipoTransaccion).WithMany(p => p.Transaccions)
                .HasForeignKey(d => d.TipoTransaccionId)
                .HasConstraintName("FK__Transacci__TipoT__03F0984C");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
