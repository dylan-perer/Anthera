using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Anthera_API.Models
{
    [Table("language_user_info")]
    public partial class LanguageUserInfo
    {
        [Key]
        [Column("language_id")]
        public int LanguageId { get; set; }
        [Key]
        [Column("user_info_id")]
        public int UserInfoId { get; set; }

        [ForeignKey(nameof(LanguageId))]
        [InverseProperty("LanguageUserInfo")]
        public virtual Language Language { get; set; }
        [ForeignKey(nameof(UserInfoId))]
        [InverseProperty("LanguageUserInfo")]
        public virtual UserInfo UserInfo { get; set; }
    }
}
