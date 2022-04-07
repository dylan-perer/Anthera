using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Anthera_API.Models
{
    [Table("gender")]
    public partial class Gender
    {
        public Gender()
        {
            UserInfo = new HashSet<UserInfo>();
        }

        [Key]
        [Column("id")]
        public byte Id { get; set; }
        [Required]
        [Column("gender_name", TypeName = "varchar(50)")]
        public string GenderName { get; set; }

        [InverseProperty("Gender")]
        public virtual ICollection<UserInfo> UserInfo { get; set; }
    }
}
