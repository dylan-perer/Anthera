using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Anthera.API.Models
{
    [Table("preference_sex")]
    public partial class PreferenceSex
    {
        public PreferenceSex()
        {
            Preference = new HashSet<Preference>();
        }

        [Key]
        [Column("id")]
        public byte Id { get; set; }
        [Required]
        [Column("sex", TypeName = "varchar(10)")]
        public string Sex { get; set; }

        [InverseProperty("PreferenceSex")]
        public virtual ICollection<Preference> Preference { get; set; }
    }
}
