using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarkBook.Data.Database.Model
{

    [Table("Specialization")]
    public partial class Specialization
    {
        [Key]
        public int id_specialization { get; set; }

        [Required]
        [StringLength(30)]
        public string type { get; set; }

        public int id_teacher { get; set; }

        public virtual Teacher Teacher { get; set; }
    }
}
