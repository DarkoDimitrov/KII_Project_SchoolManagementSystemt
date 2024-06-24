using Microsoft.EntityFrameworkCore;
using SchoolManagmentSystem.Models.Entities;

namespace SchoolManagmentSystem.Data
{
    public class ApplicationDbContext: DbContext
    {
         public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
        
        }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Literature> Literatures { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Journal> Journals { get; set; }
        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            modelBuilder.Entity<Subject>()
                .HasMany(s => s.Students)
                .WithMany(s => s.Subjects);

            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.Subjects)
                .WithOne(s => s.Teacher);

            
            modelBuilder.Entity<Literature>()
                .HasDiscriminator<string>("LiteratureType")
                .HasValue<Book>("Book")
                .HasValue<Journal>("Journal")
                .HasValue<Article>("Article");
        }
    }
}
