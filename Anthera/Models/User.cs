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
            UserInfo = new HashSet<UserInfo>();
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

        [InverseProperty("User")]
        public virtual ICollection<UserInfo> UserInfo { get; set; }
    }
}
