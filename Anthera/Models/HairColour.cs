using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Anthera.API.Models
{
    [Table("hair_colour")]
    public partial class HairColour
    {
        public HairColour()
        {
            UserInfo = new HashSet<UserInfo>();
        }

        [Key]
        [Column("id")]
        public byte Id { get; set; }
        [Required]
        [Column("colour", TypeName = "varchar(50)")]
        public string Colour { get; set; }

        [InverseProperty("HairColour")]
        public virtual ICollection<UserInfo> UserInfo { get; set; }
    }
}
