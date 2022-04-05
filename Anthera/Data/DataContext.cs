using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Anthera_API.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Anthera_API.Data
{
    public partial class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Children> Children { get; set; }
        public virtual DbSet<Drinking> Drinking { get; set; }
        public virtual DbSet<EducationLevel> EducationLevel { get; set; }
        public virtual DbSet<EyeColour> EyeColour { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<HairColour> HairColour { get; set; }
        public virtual DbSet<HereTo> HereTo { get; set; }
        public virtual DbSet<Interests> Interests { get; set; }
        public virtual DbSet<JobTitle> JobTitle { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<Personality> Personality { get; set; }
        public virtual DbSet<Photo> Photo { get; set; }
        public virtual DbSet<Preference> Preference { get; set; }
        public virtual DbSet<PreferenceSex> PreferenceSex { get; set; }
        public virtual DbSet<RefreshToken> RefreshToken { get; set; }
        public virtual DbSet<Relationship> Relationship { get; set; }
        public virtual DbSet<Religion> Religion { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Sexuality> Sexuality { get; set; }
        public virtual DbSet<Smoking> Smoking { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }
        public virtual DbSet<UserInfoInterests> UserInfoInterests { get; set; }
        public virtual DbSet<UserInfoLanguage> UserInfoLanguage { get; set; }
        public virtual DbSet<UserInfoPhoto> UserInfoPhoto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Anthera;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Children>(entity =>
            {
                entity.HasIndex(e => e.ChildrenType)
                    .HasName("UQ__children__0EABE7D4A796D31E")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ChildrenType).IsUnicode(false);
            });

            modelBuilder.Entity<Drinking>(entity =>
            {
                entity.HasIndex(e => e.DrinkingType)
                    .HasName("UQ__drinking__9D739548DC099D96")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.DrinkingType).IsUnicode(false);
            });

            modelBuilder.Entity<EducationLevel>(entity =>
            {
                entity.HasIndex(e => e.EducationLevelName)
                    .HasName("UQ__educatio__24EB1060112D1D22")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.EducationLevelName).IsUnicode(false);
            });

            modelBuilder.Entity<EyeColour>(entity =>
            {
                entity.HasIndex(e => e.Colour)
                    .HasName("UQ__eye_colo__03FE5986A437B02E")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Colour).IsUnicode(false);
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.HasIndex(e => e.GenderName)
                    .HasName("UQ__gender__2FB51D27CB4A17C5")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.GenderName).IsUnicode(false);
            });

            modelBuilder.Entity<HairColour>(entity =>
            {
                entity.HasIndex(e => e.Colour)
                    .HasName("UQ__hair_col__03FE598631A62760")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Colour).IsUnicode(false);
            });

            modelBuilder.Entity<HereTo>(entity =>
            {
                entity.HasIndex(e => e.HereToType)
                    .HasName("UQ__here_to__4A9F60AB16BC6A61")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.HereToType).IsUnicode(false);
            });

            modelBuilder.Entity<Interests>(entity =>
            {
                entity.HasIndex(e => e.InterestType)
                    .HasName("UQ__interest__5D5CAFB6FDE17064")
                    .IsUnique();

                entity.Property(e => e.InterestType).IsUnicode(false);
            });

            modelBuilder.Entity<JobTitle>(entity =>
            {
                entity.HasIndex(e => e.Title)
                    .HasName("UQ__job_titl__E52A1BB33161B7D5")
                    .IsUnique();

                entity.Property(e => e.Title).IsUnicode(false);
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.HasIndex(e => e.LanguageName)
                    .HasName("UQ__language__9CE82383553CBCD2")
                    .IsUnique();

                entity.Property(e => e.LanguageName).IsUnicode(false);
            });

            modelBuilder.Entity<Personality>(entity =>
            {
                entity.HasIndex(e => e.PersonalityName)
                    .HasName("UQ__personal__D7AAAD86B3D74A76")
                    .IsUnique();

                entity.Property(e => e.PersonalityName).IsUnicode(false);
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Preference>(entity =>
            {
                entity.HasOne(d => d.PreferenceSex)
                    .WithMany(p => p.Preference)
                    .HasForeignKey(d => d.PreferenceSexId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKpreference611362");
            });

            modelBuilder.Entity<PreferenceSex>(entity =>
            {
                entity.HasIndex(e => e.Sex)
                    .HasName("UQ__preferen__DDDFBCA63D361C03")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Sex).IsUnicode(false);
            });

            modelBuilder.Entity<RefreshToken>(entity =>
            {
                entity.Property(e => e.RefreshTokenValue).IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RefreshToken)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKrefresh_to567261");
            });

            modelBuilder.Entity<Relationship>(entity =>
            {
                entity.HasIndex(e => e.RelationshipType)
                    .HasName("UQ__relation__A286B4AD976FE285")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.RelationshipType).IsUnicode(false);
            });

            modelBuilder.Entity<Religion>(entity =>
            {
                entity.HasIndex(e => e.ReligionName)
                    .HasName("UQ__religion__07872CE48FED83DD")
                    .IsUnique();

                entity.Property(e => e.ReligionName).IsUnicode(false);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasIndex(e => e.RoleName)
                    .HasName("UQ__role__783254B18ECE14E4")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.RoleName).IsUnicode(false);
            });

            modelBuilder.Entity<Sexuality>(entity =>
            {
                entity.HasIndex(e => e.SexualityType)
                    .HasName("UQ__sexualit__BCE65079DC69C0FE")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.SexualityType).IsUnicode(false);
            });

            modelBuilder.Entity<Smoking>(entity =>
            {
                entity.HasIndex(e => e.SmokingType)
                    .HasName("UQ__smoking__0BDBB746FCFE473A")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.SmokingType).IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.EmailAddress)
                    .HasName("UQ__user__20C6DFF5896676B6")
                    .IsUnique();

                entity.Property(e => e.EmailAddress).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKuser994439");
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.HasIndex(e => e.PreferenceId)
                    .HasName("UQ__user_inf__FB41DBCEE86C1957")
                    .IsUnique();

                entity.HasIndex(e => e.UserId)
                    .HasName("UQ__user_inf__B9BE370EF9BB56E3")
                    .IsUnique();

                entity.Property(e => e.AboutMe).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.CompanyName).IsUnicode(false);

                entity.Property(e => e.Height)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('I''d prefer not to say')");

                entity.Property(e => e.IpAddress).IsUnicode(false);

                entity.Property(e => e.PhotoLimit).HasDefaultValueSql("((6))");

                entity.Property(e => e.SchoolUniversity).IsUnicode(false);

                entity.Property(e => e.Weight)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('I''d prefer not to say')");

                entity.HasOne(d => d.Children)
                    .WithMany(p => p.UserInfo)
                    .HasForeignKey(d => d.ChildrenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKuser_info865355");

                entity.HasOne(d => d.Drinking)
                    .WithMany(p => p.UserInfo)
                    .HasForeignKey(d => d.DrinkingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKuser_info390466");

                entity.HasOne(d => d.EducationLevel)
                    .WithMany(p => p.UserInfo)
                    .HasForeignKey(d => d.EducationLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKuser_info490875");

                entity.HasOne(d => d.EyeColour)
                    .WithMany(p => p.UserInfo)
                    .HasForeignKey(d => d.EyeColourId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKuser_info751412");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.UserInfo)
                    .HasForeignKey(d => d.GenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKuser_info498432");

                entity.HasOne(d => d.HairColour)
                    .WithMany(p => p.UserInfo)
                    .HasForeignKey(d => d.HairColourId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKuser_info890322");

                entity.HasOne(d => d.HereTo)
                    .WithMany(p => p.UserInfo)
                    .HasForeignKey(d => d.HereToId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKuser_info830718");

                entity.HasOne(d => d.JobTitle)
                    .WithMany(p => p.UserInfo)
                    .HasForeignKey(d => d.JobTitleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKuser_info963064");

                entity.HasOne(d => d.Personality)
                    .WithMany(p => p.UserInfo)
                    .HasForeignKey(d => d.PersonalityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKuser_info129223");

                entity.HasOne(d => d.Preference)
                    .WithOne(p => p.UserInfo)
                    .HasForeignKey<UserInfo>(d => d.PreferenceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKuser_info558053");

                entity.HasOne(d => d.Relationship)
                    .WithMany(p => p.UserInfo)
                    .HasForeignKey(d => d.RelationshipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKuser_info718147");

                entity.HasOne(d => d.Religion)
                    .WithMany(p => p.UserInfo)
                    .HasForeignKey(d => d.ReligionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKuser_info800964");

                entity.HasOne(d => d.Sexuality)
                    .WithMany(p => p.UserInfo)
                    .HasForeignKey(d => d.SexualityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKuser_info840976");

                entity.HasOne(d => d.Smoking)
                    .WithMany(p => p.UserInfo)
                    .HasForeignKey(d => d.SmokingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKuser_info916383");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.UserInfo)
                    .HasForeignKey<UserInfo>(d => d.UserId)
                    .HasConstraintName("FKuser_info674202");
            });

            modelBuilder.Entity<UserInfoInterests>(entity =>
            {
                entity.HasKey(e => new { e.UserInfoId, e.InterestsId })
                    .HasName("PK__user_inf__1C22770AE60A6FEA");

                entity.HasOne(d => d.Interests)
                    .WithMany(p => p.UserInfoInterests)
                    .HasForeignKey(d => d.InterestsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKuser_info_489534");

                entity.HasOne(d => d.UserInfo)
                    .WithMany(p => p.UserInfoInterests)
                    .HasForeignKey(d => d.UserInfoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKuser_info_102071");
            });

            modelBuilder.Entity<UserInfoLanguage>(entity =>
            {
                entity.HasKey(e => new { e.LanguageId, e.UserInfoId })
                    .HasName("PK__user_inf__D86648068B62FA43");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.UserInfoLanguage)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKuser_info_393481");

                entity.HasOne(d => d.UserInfo)
                    .WithMany(p => p.UserInfoLanguage)
                    .HasForeignKey(d => d.UserInfoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKuser_info_837564");
            });

            modelBuilder.Entity<UserInfoPhoto>(entity =>
            {
                entity.HasKey(e => new { e.PhotoId, e.UserInfoId })
                    .HasName("PK__user_inf__936276880A74A1E1");

                entity.HasOne(d => d.Photo)
                    .WithMany(p => p.UserInfoPhoto)
                    .HasForeignKey(d => d.PhotoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKuser_info_956427");

                entity.HasOne(d => d.UserInfo)
                    .WithMany(p => p.UserInfoPhoto)
                    .HasForeignKey(d => d.UserInfoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKuser_info_972894");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
