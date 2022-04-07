using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Anthera_API.Models
{
    [Table("eye_colour")]
    public partial class EyeColour
    {
        public EyeColour()
        {
            UserInfo = new HashSet<UserInfo>();
        }

        [Key]
        [Column("id")]
        public byte Id { get; set; }
        [Required]
        [Column("colour")]
        [StringLength(50)]
        public string Colour { get; set; }

        [InverseProperty("EyeColour")]
        public virtual ICollection<UserInfo> UserInfo { get; set; }
    }
}
