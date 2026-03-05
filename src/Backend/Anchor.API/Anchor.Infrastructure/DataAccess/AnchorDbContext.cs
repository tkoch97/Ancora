using Anchor.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Anchor.Infrastructure.DataAccess
{
    public class AnchorDbContext : DbContext
    {
        public AnchorDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Emotion> Emotions { get; set; }
        public DbSet<ScriptureReference> ScriptureReferences { get; set; }
        public DbSet<EmotionContent> EmotionContents { get; set; }
        public DbSet<EmotionScripture> EmotionScriptures { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<EmotionScripture>()
                .HasKey(es => new { es.EmotionId, es.ScriptureReferenceId });

            modelBuilder.Entity<ScriptureReference>()
                .HasIndex(s => new { s.Book, s.Chapter, s.VerseStart, s.VerseEnd }).IsUnique();

            modelBuilder.Entity<Emotion>()
                .HasOne(e => e.EmotionContent)
                .WithOne(ec => ec.Emotion)
                .HasForeignKey<EmotionContent>(ec => ec.EmotionId);

            modelBuilder.Entity<EmotionScripture>()
                .HasOne(es => es.Emotion) // Cada linha da tabela vai apontar apenas para uma emoção
                .WithMany(e => e.EmotionScriptures) // Uma emoção pode aparecer em várias linhas da tabela EmotionScriptures
                .HasForeignKey(es => es.EmotionId);

            modelBuilder.Entity<EmotionScripture>()
                .HasOne(es => es.ScriptureReference)
                .WithMany(e => e.EmotionScriptures)
                .HasForeignKey(es => es.ScriptureReferenceId);
        }
    }
}
