using Flashcards.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Flashcards.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Deck> Decks { get; set; }
        public DbSet<Flashcard> Flashcards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flashcard>()
                .HasMany(f => f.Tags)
                .WithMany(t => t.Flashcards)
                .UsingEntity<Dictionary<string, object>>(
                    "FlashcardTag", 
                    j => j.HasOne<Tag>().WithMany().HasForeignKey("TagId"),
                    j => j.HasOne<Flashcard>().WithMany().HasForeignKey("FlashcardId")
                );

            base.OnModelCreating(modelBuilder);
        }

    }
}
