using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ExamSystemAppApi.Models
{
    public partial class ExamSystemContext : DbContext
    {
        public ExamSystemContext()
        {
        }

        public ExamSystemContext(DbContextOptions<ExamSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AnsSheet> AnsSheets { get; set; }
        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<QuestionSet> QuestionSets { get; set; }
        public virtual DbSet<QuestionSetOption> QuestionSetOptions { get; set; }
        public virtual DbSet<QuizOption> QuizOptions { get; set; }
        public virtual DbSet<QuizQuestion> QuizQuestions { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS; Initial Catalog=ExamSystem; Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AnsSheet>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.GivenMark).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SubmitedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Candidate>(entity =>
            {
                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.Mark).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MotherName).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NumberOfPersonInFamily).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<QuestionSet>(entity =>
            {
                entity.Property(e => e.CandidateType).HasMaxLength(50);

                entity.Property(e => e.Session).HasMaxLength(50);

                entity.Property(e => e.TimeDuration).HasColumnType("datetime");
            });

            modelBuilder.Entity<QuizOption>(entity =>
            {
                entity.HasKey(e => e.OptionId);

                entity.Property(e => e.Option1).HasMaxLength(50);
            });

            modelBuilder.Entity<QuizQuestion>(entity =>
            {
                entity.HasKey(e => e.QuestionId);

                entity.Property(e => e.Mark).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Question).IsRequired();

                entity.Property(e => e.QuestionType)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserType)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
