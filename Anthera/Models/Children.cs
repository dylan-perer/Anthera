﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Anthera_API.DELETE_Models
{
    [Table("children")]
    public partial class Children
    {
        public Children()
        {
            UserInfo = new HashSet<UserInfo>();
        }

        [Key]
        [Column("id")]
        public byte Id { get; set; }
        [Required]
        [Column("children_type")]
        [StringLength(50)]
        public string ChildrenType { get; set; }

        [InverseProperty("Children")]
        public virtual ICollection<UserInfo> UserInfo { get; set; }
    }
}
