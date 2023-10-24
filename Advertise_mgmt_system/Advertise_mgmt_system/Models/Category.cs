using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Advertise_mgmt_system.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Advertise Name")]
        public string Adv_Name { get; set; }
        [Required]
        public string Adv_Theme { get; set; }
        [DisplayName("Advertise Description")]
        public string Adv_Description { get; set; }

    }
}

