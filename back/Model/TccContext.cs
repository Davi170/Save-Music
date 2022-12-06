using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace back.Model;

public partial class TccContext : DbContext
{
    public TccContext()
    {
    }

    public TccContext(DbContextOptions<TccContext> options)
        : base(options)
    {
    }

    public virtual DbSet<LoginPessoa> LoginPessoas { get; set; }

    public virtual DbSet<Musica> Musicas { get; set; }

    public virtual DbSet<Playlist> Playlists { get; set; }

    public virtual DbSet<UsuarioToken> UsuarioTokens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=SNCCHLAB02F23\\TEW_SQLEXPRESS;Initial Catalog=TCC;Integrated Security=SSPI;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LoginPessoa>(entity =>
        {
            entity.HasKey(e => e.PessoaId).HasName("PK__login_pe__434CC5DB5C6B1568");

            entity.ToTable("login_pessoa");

            entity.Property(e => e.PessoaId)
                .ValueGeneratedNever()
                .HasColumnName("pessoa_id");
            entity.Property(e => e.EmailPessoa)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email_pessoa");
            entity.Property(e => e.SenhaPessoa)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("senha_pessoa");
        });

        modelBuilder.Entity<Musica>(entity =>
        {
            entity.HasKey(e => e.IdMusica).HasName("PK__musicas__3B16D4E8956B9E20");

            entity.ToTable("musicas");

            entity.Property(e => e.IdMusica)
                .ValueGeneratedNever()
                .HasColumnName("id_musica");
            entity.Property(e => e.Duracao).HasColumnName("duracao");
            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Playlist>(entity =>
        {
            entity.HasKey(e => e.IdPlaylist).HasName("PK__playlist__666FAF75A346F993");

            entity.ToTable("playlist");

            entity.Property(e => e.IdPlaylist)
                .ValueGeneratedNever()
                .HasColumnName("id_playlist");
            entity.Property(e => e.Musicas)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("musicas");
            entity.Property(e => e.MusicasQnt).HasColumnName("musicas_qnt");
            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<UsuarioToken>(entity =>
        {
            entity.HasKey(e => e.UsuarioTokenId).HasName("PK__UsuarioT__32A3E80FCAADBE99");

            entity.ToTable("UsuarioToken");

            entity.Property(e => e.UsuarioTokenId)
                .ValueGeneratedNever()
                .HasColumnName("UsuarioTokenID");
            entity.Property(e => e.AccessToken)
                .HasMaxLength(52)
                .IsUnicode(false)
                .HasColumnName("Access_Token");
            entity.Property(e => e.ExpiresIn)
                .HasMaxLength(90)
                .IsUnicode(false)
                .HasColumnName("Expires_In");
            entity.Property(e => e.RefreshToken)
                .HasMaxLength(90)
                .IsUnicode(false)
                .HasColumnName("Refresh_Token");
            entity.Property(e => e.Scope)
                .HasMaxLength(90)
                .IsUnicode(false);
            entity.Property(e => e.TipoToken)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Token)
                .HasMaxLength(36)
                .IsUnicode(false);
            entity.Property(e => e.TokenType)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("Token_Type");
            entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

            entity.HasOne(d => d.Usuario).WithMany(p => p.UsuarioTokens)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("FK__UsuarioTo__Usuar__164452B1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
