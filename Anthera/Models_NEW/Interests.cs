using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Anthera_API.Models_NEW
{
    [Table("interests")]
    public partial class Interests
    {
        public Interests()
        {
            UserInfoInterest = new HashSet<UserInfoInterest>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("interest_type", TypeName = "varchar(100)")]
        public string InterestType { get; set; }

        [InverseProperty("Interests")]
        public virtual ICollection<UserInfoInterest> UserInfoInterest { get; set; }
    }
}
