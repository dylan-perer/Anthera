using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Anthera_API.Models
{
    [Table("preference")]
    public partial class Preference
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("age_min")]
        public byte AgeMin { get; set; }
        [Column("age_max")]
        public byte AgeMax { get; set; }
        [Column("distance")]
        public byte Distance { get; set; }
        [Column("preference_sex_id")]
        public byte PreferenceSexId { get; set; }

        [ForeignKey(nameof(PreferenceSexId))]
        [InverseProperty("Preference")]
        public virtual PreferenceSex PreferenceSex { get; set; }
        [InverseProperty("Preference")]
        public virtual UserInfo UserInfo { get; set; }
    }
}
