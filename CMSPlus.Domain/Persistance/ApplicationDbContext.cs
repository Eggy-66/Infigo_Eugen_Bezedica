using System.Reflection;
using CMSPlus.Domain.Configurations;
using CMSPlus.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace CMSPlus.Domain.Persistance;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

        // DbSets for your entities
    public DbSet<TopicEntity> Topics { get; set; } = null!;
    public DbSet<CommentEntity> Comments { get; set; } = null!; 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new TopicEntityConfiguration());
                // Configure relationship between TopicEntity and CommentEntity
            builder.Entity<CommentEntity>()
            .HasOne(c => c.Topic)
            .WithMany(t => t.Comments)
            .HasForeignKey(c => c.TopicId)
            .OnDelete(DeleteBehavior.Cascade); // Cascade delete comments when a topic is deleted

        base.OnModelCreating(builder);
    }
}