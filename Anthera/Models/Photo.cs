using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Anthera_API.Models
{
    [Table("photo")]
    public partial class Photo
    {
        public Photo()
        {
            Gallery = new HashSet<Gallery>();
        }

        [Key]
        [Column("id")]
        public byte Id { get; set; }
        [Required]
        [Column("photo_url", TypeName = "text")]
        public string PhotoUrl { get; set; }

        [InverseProperty("Photo")]
        public virtual ICollection<Gallery> Gallery { get; set; }
    }
}
