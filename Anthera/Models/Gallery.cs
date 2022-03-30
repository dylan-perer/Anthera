using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Anthera_API.Models
{
    [Table("gallery")]
    public partial class Gallery
    {
        [Key]
        [Column("photo_id")]
        public int PhotoId { get; set; }
        [Key]
        [Column("user_info_id")]
        public int UserInfoId { get; set; }

        [ForeignKey(nameof(PhotoId))]
        [InverseProperty("Gallery")]
        public virtual Photo Photo { get; set; }
        [ForeignKey(nameof(UserInfoId))]
        [InverseProperty("Gallery")]
        public virtual UserInfo UserInfo { get; set; }
    }
}
