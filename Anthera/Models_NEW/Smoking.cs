using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Anthera_API.Models_NEW
{
    [Table("smoking")]
    public partial class Smoking
    {
        public Smoking()
        {
            UserInfo = new HashSet<UserInfo>();
        }

        [Key]
        [Column("id")]
        public byte Id { get; set; }
        [Required]
        [Column("smoking_type", TypeName = "varchar(50)")]
        public string SmokingType { get; set; }

        [InverseProperty("Smoking")]
        public virtual ICollection<UserInfo> UserInfo { get; set; }
    }
}
