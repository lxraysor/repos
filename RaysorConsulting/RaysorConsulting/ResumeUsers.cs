namespace RaysorConsulting
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ResumeUsers : DbContext
    {
        public ResumeUsers()
            : base("name=ResumeUsers")
        {
        }

        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<EmailType> EmailTypes { get; set; }
        public virtual DbSet<OtherUser> OtherUsers { get; set; }
        public virtual DbSet<Recruiter> Recruiters { get; set; }
        public virtual DbSet<Resume> Resumes { get; set; }
        public virtual DbSet<ResumeOwner> ResumeOwners { get; set; }
        public virtual DbSet<ResumeType> ResumeTypes { get; set; }
        public virtual DbSet<UserHistory> UserHistories { get; set; }
        public virtual DbSet<UserQualification> UserQualifications { get; set; }
        public virtual DbSet<UserQuestion> UserQuestions { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserAnswer> UserAnswers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Email>()
                .Property(e => e.Email1)
                .IsUnicode(false);

            modelBuilder.Entity<EmailType>()
                .Property(e => e.EmailDescription)
                .IsUnicode(false);

            modelBuilder.Entity<OtherUser>()
                .Property(e => e.UserFirstName)
                .IsUnicode(false);

            modelBuilder.Entity<OtherUser>()
                .Property(e => e.UserLastName)
                .IsUnicode(false);

            modelBuilder.Entity<Recruiter>()
                .Property(e => e.RecruiterEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Recruiter>()
                .Property(e => e.RecruiterFirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Recruiter>()
                .Property(e => e.RecruiterLastName)
                .IsUnicode(false);

            modelBuilder.Entity<Recruiter>()
                .Property(e => e.RecruiterPhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Resume>()
                .Property(e => e.Resume1)
                .IsFixedLength();

            modelBuilder.Entity<ResumeOwner>()
                .Property(e => e.AdminFirstName)
                .IsUnicode(false);

            modelBuilder.Entity<ResumeOwner>()
                .Property(e => e.AdminLastName)
                .IsUnicode(false);

            modelBuilder.Entity<ResumeOwner>()
                .Property(e => e.AdminEmail)
                .IsUnicode(false);

            modelBuilder.Entity<ResumeOwner>()
                .Property(e => e.HashName)
                .IsUnicode(false);

            modelBuilder.Entity<ResumeType>()
                .Property(e => e.ResumeType1)
                .IsUnicode(false);

            modelBuilder.Entity<ResumeType>()
                .Property(e => e.ResumeTypeDesccription)
                .IsUnicode(false);

            modelBuilder.Entity<UserHistory>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<UserHistory>()
                .Property(e => e.UserHash)
                .IsFixedLength();

            modelBuilder.Entity<UserHistory>()
                .Property(e => e.UserSalt)
                .IsFixedLength();

            modelBuilder.Entity<UserQualification>()
                .Property(e => e.QualificationItem)
                .IsUnicode(false);

            modelBuilder.Entity<UserQualification>()
                .Property(e => e.QualificationDescription)
                .IsUnicode(false);

            modelBuilder.Entity<UserQuestion>()
                .Property(e => e.Question)
                .IsUnicode(false);

            modelBuilder.Entity<UserAnswer>()
                .Property(e => e.Answer)
                .IsUnicode(false);
        }
    }
}
