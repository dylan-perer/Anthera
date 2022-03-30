﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Anthera_API.Models
{
    [Table("interests")]
    public partial class Interests
    {
        public Interests()
        {
            UserInfoInterests = new HashSet<UserInfoInterests>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("interest_type")]
        [StringLength(100)]
        public string InterestType { get; set; }

        [InverseProperty("Interests")]
        public virtual ICollection<UserInfoInterests> UserInfoInterests { get; set; }
    }
}