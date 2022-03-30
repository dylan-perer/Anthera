using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Anthera_API.Models
{
    [Table("language")]
    public partial class Language
    {
        public Language()
        {
            LanguageUserInfo = new HashSet<LanguageUserInfo>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("language_name")]
        [StringLength(100)]
        public string LanguageName { get; set; }

        [InverseProperty("Language")]
        public virtual ICollection<LanguageUserInfo> LanguageUserInfo { get; set; }
    }
}
