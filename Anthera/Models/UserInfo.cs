using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Anthera_API.Models
{
    [Table("user_info")]
    public partial class UserInfo
    {
        public UserInfo()
        {
            Gallery = new HashSet<Gallery>();
            LanguageUserInfo = new HashSet<LanguageUserInfo>();
            UserInfoInterests = new HashSet<UserInfoInterests>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("gender_id")]
        public byte GenderId { get; set; }
        [Column("dob", TypeName = "datetime")]
        public DateTime Dob { get; set; }
        [Required]
        [Column("city")]
        [StringLength(100)]
        public string City { get; set; }
        [Column("ip_address")]
        [StringLength(150)]
        public string IpAddress { get; set; }
        [Column("job_title_id")]
        public byte JobTitleId { get; set; }
        [Column("company_name")]
        [StringLength(30)]
        public string CompanyName { get; set; }
        [Column("school_university")]
        [StringLength(250)]
        public string SchoolUniversity { get; set; }
        [Column("about_me")]
        [StringLength(500)]
        public string AboutMe { get; set; }
        [Column("relationship_id")]
        public byte RelationshipId { get; set; }
        [Column("sexuality_id")]
        public byte SexualityId { get; set; }
        [Required]
        [Column("height")]
        [StringLength(40)]
        public string Height { get; set; }
        [Required]
        [Column("weight")]
        [StringLength(40)]
        public string Weight { get; set; }
        [Column("eye_colour_id")]
        public byte EyeColourId { get; set; }
        [Column("hair_colour_id")]
        public byte HairColourId { get; set; }
        [Column("children_id")]
        public byte ChildrenId { get; set; }
        [Column("smoking_id")]
        public byte SmokingId { get; set; }
        [Column("drinking_id")]
        public byte DrinkingId { get; set; }
        [Column("here_to_id")]
        public byte HereToId { get; set; }
        [Column("photo_limit")]
        public byte PhotoLimit { get; set; }

        [ForeignKey(nameof(ChildrenId))]
        [InverseProperty("UserInfo")]
        public virtual Children Children { get; set; }
        [ForeignKey(nameof(DrinkingId))]
        [InverseProperty("UserInfo")]
        public virtual Drinking Drinking { get; set; }
        [ForeignKey(nameof(EyeColourId))]
        [InverseProperty("UserInfo")]
        public virtual EyeColour EyeColour { get; set; }
        [ForeignKey(nameof(GenderId))]
        [InverseProperty("UserInfo")]
        public virtual Gender Gender { get; set; }
        [ForeignKey(nameof(HairColourId))]
        [InverseProperty("UserInfo")]
        public virtual HairColour HairColour { get; set; }
        [ForeignKey(nameof(HereToId))]
        [InverseProperty("UserInfo")]
        public virtual HereTo HereTo { get; set; }
        [ForeignKey(nameof(JobTitleId))]
        [InverseProperty("UserInfo")]
        public virtual JobTitle JobTitle { get; set; }
        [ForeignKey(nameof(RelationshipId))]
        [InverseProperty("UserInfo")]
        public virtual Relationship Relationship { get; set; }
        [ForeignKey(nameof(SexualityId))]
        [InverseProperty("UserInfo")]
        public virtual Sexuality Sexuality { get; set; }
        [ForeignKey(nameof(SmokingId))]
        [InverseProperty("UserInfo")]
        public virtual Smoking Smoking { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("UserInfo")]
        public virtual User User { get; set; }
        [InverseProperty("UserInfo")]
        public virtual ICollection<Gallery> Gallery { get; set; }
        [InverseProperty("UserInfo")]
        public virtual ICollection<LanguageUserInfo> LanguageUserInfo { get; set; }
        [InverseProperty("UserInfo")]
        public virtual ICollection<UserInfoInterests> UserInfoInterests { get; set; }
    }
}
