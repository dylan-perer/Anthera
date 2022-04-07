using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Anthera_API.Models
{
    [Table("drinking")]
    public partial class Drinking
    {
        public Drinking()
        {
            UserInfo = new HashSet<UserInfo>();
        }

        [Key]
        [Column("id")]
        public byte Id { get; set; }
        [Required]
        [Column("drinking_type")]
        [StringLength(50)]
        public string DrinkingType { get; set; }

        [InverseProperty("Drinking")]
        public virtual ICollection<UserInfo> UserInfo { get; set; }
    }
}
