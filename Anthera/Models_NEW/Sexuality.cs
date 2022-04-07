using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Anthera_API.Models_NEW
{
    [Table("sexuality")]
    public partial class Sexuality
    {
        public Sexuality()
        {
            UserInfo = new HashSet<UserInfo>();
        }

        [Key]
        [Column("id")]
        public byte Id { get; set; }
        [Required]
        [Column("sexuality_type", TypeName = "varchar(50)")]
        public string SexualityType { get; set; }

        [InverseProperty("Sexuality")]
        public virtual ICollection<UserInfo> UserInfo { get; set; }
    }
}
