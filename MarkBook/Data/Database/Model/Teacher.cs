using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarkBook.Data.Database.Model
{

    [Table("Teacher")]
    public partial class Teacher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Teacher()
        {
            Schedules = new HashSet<Schedule>();
            Specializations = new HashSet<Specialization>();
        }

        [Key]
        public int id_teacher { get; set; }

        [Required]
        [StringLength(30)]
        public string surname { get; set; }

        [Required]
        [StringLength(30)]
        public string name { get; set; }

        [StringLength(30)]
        public string patronymic { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule> Schedules { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Specialization> Specializations { get; set; }
    }
}
