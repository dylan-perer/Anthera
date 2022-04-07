﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Anthera_API.Models_NEW
{
    [Table("relationship")]
    public partial class Relationship
    {
        public Relationship()
        {
            UserInfo = new HashSet<UserInfo>();
        }

        [Key]
        [Column("id")]
        public sbyte Id { get; set; }
        [Required]
        [Column("relationship_type", TypeName = "varchar(50)")]
        public string RelationshipType { get; set; }

        [InverseProperty("Relationship")]
        public virtual ICollection<UserInfo> UserInfo { get; set; }
    }
}
