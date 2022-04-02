using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Anthera_API.Models
{
    [Table("user")]
    public partial class User
    {
        public User()
        {
            RefreshToken = new HashSet<RefreshToken>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(14)]
        public string Name { get; set; }
        [Required]
        [Column("email_address")]
        [StringLength(255)]
        public string EmailAddress { get; set; }
        [Required]
        [Column("password")]
        [StringLength(255)]
        public string Password { get; set; }
        [Column("profile_picture_url", TypeName = "text")]
        public string ProfilePictureUrl { get; set; }
        [Column("last_online", TypeName = "datetime")]
        public DateTime LastOnline { get; set; }
        [Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }
        [Column("is_info_completed")]
        public bool IsInfoCompleted { get; set; }
        [Column("role_id")]
        public byte RoleId { get; set; }

        [ForeignKey(nameof(RoleId))]
        [InverseProperty("User")]
        public virtual Role Role { get; set; }
        [InverseProperty("User")]
        public virtual UserInfo UserInfo { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<RefreshToken> RefreshToken { get; set; }
    }
}
