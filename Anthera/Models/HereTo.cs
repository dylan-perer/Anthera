using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Anthera_API.Models
{
    [Table("here_to")]
    public partial class HereTo
    {
        public HereTo()
        {
            UserInfo = new HashSet<UserInfo>();
        }

        [Key]
        [Column("id")]
        public byte Id { get; set; }
        [Required]
        [Column("here_to_type")]
        [StringLength(40)]
        public string HereToType { get; set; }

        [InverseProperty("HereTo")]
        public virtual ICollection<UserInfo> UserInfo { get; set; }
    }
}
