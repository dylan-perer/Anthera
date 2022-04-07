using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Anthera_API.Models
{
    [Table("show_preference_sex")]
    public partial class ShowPreferenceSex
    {
        [Key]
        [Column("id")]
        public byte Id { get; set; }
        [Required]
        [Column("sex")]
        [StringLength(10)]
        public string Sex { get; set; }
    }
}
