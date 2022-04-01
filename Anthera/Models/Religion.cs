using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Anthera_API.Models
{
    [Table("religion")]
    public partial class Religion
    {
        public Religion()
        {
            UserInfo = new HashSet<UserInfo>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("religion_name")]
        [StringLength(100)]
        public string ReligionName { get; set; }

        [InverseProperty("Religion")]
        public virtual ICollection<UserInfo> UserInfo { get; set; }
    }
}
