using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Anthera_API.Models
{
    [Table("refresh_token")]
    public partial class RefreshToken
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("refresh_token_value")]
        [StringLength(255)]
        public string RefreshTokenValue { get; set; }
        [Column("is_invalidated")]
        public bool IsInvalidated { get; set; }
        [Column("issued_at", TypeName = "datetime")]
        public DateTime IssuedAt { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty("RefreshToken")]
        public virtual User User { get; set; }
    }
}
