using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Anthera_API.Models_NEW
{
    [Table("user_info_interest")]
    public partial class UserInfoInterest
    {
        [Key]
        [Column("user_info_id")]
        public int UserInfoId { get; set; }
        [Key]
        [Column("interests_id")]
        public int InterestsId { get; set; }
        [Key]
        [Column("user_infouser_id")]
        public int UserInfouserId { get; set; }

        [ForeignKey(nameof(InterestsId))]
        [InverseProperty("UserInfoInterest")]
        public virtual Interests Interests { get; set; }
        [ForeignKey(nameof(UserInfoId))]
        [InverseProperty("UserInfoInterest")]
        public virtual UserInfo UserInfo { get; set; }
    }
}
