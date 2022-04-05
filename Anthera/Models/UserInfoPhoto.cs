using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Anthera_API.Models
{
    [Table("user_info_photo")]
    public partial class UserInfoPhoto
    {
        [Key]
        [Column("photo_id")]
        public byte PhotoId { get; set; }
        [Key]
        [Column("user_info_id")]
        public int UserInfoId { get; set; }

        [ForeignKey(nameof(PhotoId))]
        [InverseProperty("UserInfoPhoto")]
        public virtual Photo Photo { get; set; }
        [ForeignKey(nameof(UserInfoId))]
        [InverseProperty("UserInfoPhoto")]
        public virtual UserInfo UserInfo { get; set; }
    }
}
