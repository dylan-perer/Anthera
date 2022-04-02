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
        public virtual DbSet<Gallery> Gallery { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<HairColour> HairColour { get; set; }
        public virtual DbSet<HereTo> HereTo { get; set; }
        public virtual DbSet<Interests> Interests { get; set; }
        public virtual DbSet<JobTitle> JobTitle { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<LanguageUserInfo> LanguageUserInfo { get; set; }
        public virtual DbSet<Logs> Logs { get; set; }
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
                    .HasName("UQ__children__0EABE7D439249921")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ChildrenType).IsUnicode(false);
            });

            modelBuilder.Entity<Drinking>(entity =>
            {
                entity.HasIndex(e => e.DrinkingType)
                    .HasName("UQ__drinking__9D739548D8CF50A8")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.DrinkingType).IsUnicode(false);
            });

            modelBuilder.Entity<EducationLevel>(entity =>
            {
                entity.HasIndex(e => e.EducationLevelName)
                    .HasName("UQ__educatio__24EB10603F035DD4")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.EducationLevelName).IsUnicode(false);
            });

            modelBuilder.Entity<EyeColour>(entity =>
            {
                entity.HasIndex(e => e.Colour)
                    .HasName("UQ__eye_colo__03FE598678C2BECD")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Colour).IsUnicode(false);
            });

            modelBuilder.Entity<Gallery>(entity =>
            {
                entity.HasKey(e => new { e.PhotoId, e.UserInfoId, e.UserInfouserId })
                    .HasName("PK__gallery__29B5C7E5934049B6");

                entity.HasOne(d => d.Photo)
                    .WithMany(p => p.Gallery)
                    .HasForeignKey(d => d.PhotoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKgallery940460");

                entity.HasOne(d => d.UserInfo)
                    .WithMany(p => p.Gallery)
                    .HasForeignKey(d => d.UserInfoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKgallery11138");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.HasIndex(e => e.GenderName)
                    .HasName("UQ__gender__2FB51D2740F78CA4")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.GenderName).IsUnicode(false);
            });

            modelBuilder.Entity<HairColour>(entity =>
            {
                entity.HasIndex(e => e.Colour)
                    .HasName("UQ__hair_col__03FE5986133AB4F5")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Colour).IsUnicode(false);
            });

            modelBuilder.Entity<HereTo>(entity =>
            {
                entity.HasIndex(e => e.HereToType)
                    .HasName("UQ__here_to__4A9F60AB33233E4E")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.HereToType).IsUnicode(false);
            });

            modelBuilder.Entity<Interests>(entity =>
            {
                entity.HasIndex(e => e.InterestType)
                    .HasName("UQ__interest__5D5CAFB64C9439E6")
                    .IsUnique();

                entity.Property(e => e.InterestType).IsUnicode(false);
            });

            modelBuilder.Entity<JobTitle>(entity =>
            {
                entity.HasIndex(e => e.Title)
                    .HasName("UQ__job_titl__E52A1BB3D27F2CBC")
                    .IsUnique();

                entity.Property(e => e.Title).IsUnicode(false);
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.HasIndex(e => e.LanguageName)
                    .HasName("UQ__language__9CE82383C6AE594F")
                    .IsUnique();

                entity.Property(e => e.LanguageName).IsUnicode(false);
            });

            modelBuilder.Entity<LanguageUserInfo>(entity =>
            {
                entity.HasKey(e => new { e.LanguageId, e.UserInfoId, e.UserInfouserId })
                    .HasName("PK__language__62B1F96BB0CEE489");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.LanguageUserInfo)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKlanguage_u96287");

                entity.HasOne(d => d.UserInfo)
                    .WithMany(p => p.LanguageUserInfo)
                    .HasForeignKey(d => d.UserInfoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKlanguage_u134759");
            });

            modelBuilder.Entity<Personality>(entity =>
            {
                entity.HasIndex(e => e.PersonalityName)
                    .HasName("UQ__personal__D7AAAD86739E3D06")
                    .IsUnique();

                entity.Property(e => e.PersonalityName).IsUnicode(false);
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
                    .HasName("UQ__preferen__DDDFBCA6429EADD4")
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
                    .HasName("UQ__relation__A286B4ADAAB939C2")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.RelationshipType).IsUnicode(false);
            });

            modelBuilder.Entity<Religion>(entity =>
            {
                entity.HasIndex(e => e.ReligionName)
                    .HasName("UQ__religion__07872CE4F9855B9D")
                    .IsUnique();

                entity.Property(e => e.ReligionName).IsUnicode(false);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasIndex(e => e.RoleName)
                    .HasName("UQ__role__783254B14C13C8ED")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.RoleName).IsUnicode(false);
            });

            modelBuilder.Entity<Sexuality>(entity =>
            {
                entity.HasIndex(e => e.SexualityType)
                    .HasName("UQ__sexualit__BCE6507958F6382F")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.SexualityType).IsUnicode(false);
            });

            modelBuilder.Entity<Smoking>(entity =>
            {
                entity.HasIndex(e => e.SmokingType)
                    .HasName("UQ__smoking__0BDBB74641097E2D")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.SmokingType).IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.EmailAddress)
                    .HasName("UQ__user__20C6DFF5DBDE39B2")
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
                    .HasName("UQ__user_inf__FB41DBCE48D66BDA")
                    .IsUnique();

                entity.HasIndex(e => e.UserId)
                    .HasName("UQ__user_inf__B9BE370ED9D06EA3")
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
                entity.HasKey(e => new { e.UserInfoId, e.InterestsId, e.UserInfouserId })
                    .HasName("PK__user_inf__A6F5C66765791702");

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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
