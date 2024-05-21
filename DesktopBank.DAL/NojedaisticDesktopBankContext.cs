using System;
using System.Collections.Generic;
using DesktopBank.BusinessObjects.Generated.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace DesktopBank.DAL;

public partial class NojedaisticDesktopBankContext : DbContext
{
    public NojedaisticDesktopBankContext()
    {
    }

    public NojedaisticDesktopBankContext(DbContextOptions<NojedaisticDesktopBankContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Card> Cards { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

    public virtual DbSet<Operation> Operations { get; set; }

    public virtual DbSet<OperationCode> OperationCodes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("server=sql.bsite.net\\MSSQL2016;user=nojedaistic_DesktopBank;password=1234;TrustServerCertificate=True;");
        //optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["sqlBank"]?.ConnectionString); // get from App.Config

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.AccountId).HasName("PK__Account__349DA5865303325F");

            entity.ToTable("Account");

            entity.HasIndex(e => e.AccountAlias, "UQ__Account__2822EFBDF023D9ED").IsUnique();

            entity.HasIndex(e => e.AccountCbu, "UQ__Account__BFE55AC2C18DC6A5").IsUnique();

            entity.Property(e => e.AccountId).HasColumnName("AccountID");
            entity.Property(e => e.AccountAlias)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.AccountBalance)
                .HasDefaultValueSql("((0.00))")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AccountCbu).HasColumnName("AccountCBU");
            entity.Property(e => e.AccountNumber).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.AccountCurrencyNavigation).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.AccountCurrency)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Account__Account__5D60DB10");

            entity.HasOne(d => d.User).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Account__UserID__5B78929E");
        });

        modelBuilder.Entity<Card>(entity =>
        {
            entity.HasKey(e => e.CardId).HasName("PK__Card__55FECD8EC0264D91");

            entity.ToTable("Card");

            entity.Property(e => e.CardId).HasColumnName("CardID");
            entity.Property(e => e.CardAccountId).HasColumnName("CardAccountID");
            entity.Property(e => e.CardCvv).HasColumnName("CardCVV");
            entity.Property(e => e.CardExpirationDate).HasColumnType("date");
            entity.Property(e => e.CardNumber)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

            entity.HasOne(d => d.CardAccount).WithMany(p => p.Cards)
                .HasForeignKey(d => d.CardAccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Card__CardAccoun__69C6B1F5");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.ClientId).HasName("PK__Client__E67E1A047D55DBAA");

            entity.ToTable("Client");

            entity.HasIndex(e => e.ClientEmail, "UQ__Client__AD48A6FFD7AEDBB2").IsUnique();

            entity.HasIndex(e => e.ClientCuil, "UQ__Client__BFF6AAB7D53D2FB2").IsUnique();

            entity.Property(e => e.ClientId).HasColumnName("ClientID");
            entity.Property(e => e.ClientCuil).HasColumnName("ClientCUIL");
            entity.Property(e => e.ClientEmail)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ClientName)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.ClientSurname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<Currency>(entity =>
        {
            entity.HasKey(e => e.CurrencyId).HasName("PK__Currency__14470B1054A35CFB");

            entity.ToTable("Currency");

            entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");
            entity.Property(e => e.CurrencyName)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.CurrencySign)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Operation>(entity =>
        {
            entity.HasKey(e => e.OperationId).HasName("PK__Operatio__A4F5FC64D44483FE");

            entity.ToTable("Operation");

            entity.Property(e => e.OperationId).HasColumnName("OperationID");
            entity.Property(e => e.DestinationAccountId).HasColumnName("DestinationAccountID");
            entity.Property(e => e.OperationAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OperationCodeId).HasColumnName("OperationCodeID");
            entity.Property(e => e.OperationDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.OperationNote)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SourceAccountId).HasColumnName("SourceAccountID");

            entity.HasOne(d => d.DestinationAccount).WithMany(p => p.OperationDestinationAccounts)
                .HasForeignKey(d => d.DestinationAccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Operation__Desti__6501FCD8");

            entity.HasOne(d => d.OperationCode).WithMany(p => p.Operations)
                .HasForeignKey(d => d.OperationCodeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Operation__Opera__66EA454A");

            entity.HasOne(d => d.SourceAccount).WithMany(p => p.OperationSourceAccounts)
                .HasForeignKey(d => d.SourceAccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Operation__Sourc__640DD89F");
        });

        modelBuilder.Entity<OperationCode>(entity =>
        {
            entity.HasKey(e => e.OperationCodeId).HasName("PK__Operatio__687AFC4144B86271");

            entity.ToTable("OperationCode");

            entity.Property(e => e.OperationCodeId)
                .ValueGeneratedOnAdd()
                .HasColumnName("OperationCodeID");
            entity.Property(e => e.OperationCode1).HasColumnName("OperationCode");
            entity.Property(e => e.OperationCodeDescription)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCAC6FD63FA7");

            entity.HasIndex(e => e.UserName, "UQ__Users__C9F28456430873BF").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.ClientId).HasColumnName("ClientID");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UserName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UserPassword)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.Client).WithMany(p => p.Users)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Users__ClientID__51EF2864");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
