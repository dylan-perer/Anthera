using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Anthera.API.Models
{
    [Table("personality")]
    public partial class Personality
    {
        public Personality()
        {
            UserInfo = new HashSet<UserInfo>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("personality_name", TypeName = "varchar(100)")]
        public string PersonalityName { get; set; }

        [InverseProperty("Personality")]
        public virtual ICollection<UserInfo> UserInfo { get; set; }
    }
}
