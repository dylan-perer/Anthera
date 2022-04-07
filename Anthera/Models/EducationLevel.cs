using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Anthera_API.Models
{
    [Table("education_level")]
    public partial class EducationLevel
    {
        public EducationLevel()
        {
            UserInfo = new HashSet<UserInfo>();
        }

        [Key]
        [Column("id")]
        public byte Id { get; set; }
        [Required]
        [Column("education_level_name", TypeName = "varchar(100)")]
        public string EducationLevelName { get; set; }

        [InverseProperty("EducationLevel")]
        public virtual ICollection<UserInfo> UserInfo { get; set; }
    }
}
