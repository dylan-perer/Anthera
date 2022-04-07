using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Anthera_API.Models_NEW
{
    [Table("user_info_language")]
    public partial class UserInfoLanguage
    {
        [Key]
        [Column("language_id")]
        public int LanguageId { get; set; }
        [Key]
        [Column("user_info_id")]
        public int UserInfoId { get; set; }
        [Key]
        [Column("user_infouser_id")]
        public int UserInfouserId { get; set; }

        [ForeignKey(nameof(LanguageId))]
        [InverseProperty("UserInfoLanguage")]
        public virtual Language Language { get; set; }
        [ForeignKey(nameof(UserInfoId))]
        [InverseProperty("UserInfoLanguage")]
        public virtual UserInfo UserInfo { get; set; }
    }
}
