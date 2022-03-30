using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Anthera_API.Models
{
    [Table("preference")]
    public partial class Preference
    {
        [Column("user_info_id")]
        public int UserInfoId { get; set; }
        [Column("age")]
        public byte Age { get; set; }
        [Column("distance")]
        public byte Distance { get; set; }
        [Column("show_preference_sex_id")]
        public byte ShowPreferenceSexId { get; set; }

        [ForeignKey(nameof(ShowPreferenceSexId))]
        public virtual ShowPreferenceSex ShowPreferenceSex { get; set; }
        [ForeignKey(nameof(UserInfoId))]
        public virtual UserInfo UserInfo { get; set; }
    }
}
