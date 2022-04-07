using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Anthera_API.DELETE_Models
{
    [Table("job_title")]
    public partial class JobTitle
    {
        public JobTitle()
        {
            UserInfo = new HashSet<UserInfo>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("title")]
        [StringLength(100)]
        public string Title { get; set; }

        [InverseProperty("JobTitle")]
        public virtual ICollection<UserInfo> UserInfo { get; set; }
    }
}
