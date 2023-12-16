using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarkBook.Data.Database.Model
{

    [Table("Subject")]
    public partial class Subject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subject()
        {
            Schedules = new HashSet<Schedule>();
            Subject_Student_Mark = new HashSet<Subject_Student_Mark>();
        }

        [Key]
        public int id_subject { get; set; }

        [Required]
        [StringLength(20)]
        public string name { get; set; }

        [Required]
        [StringLength(30)]
        public string specialization { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule> Schedules { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subject_Student_Mark> Subject_Student_Mark { get; set; }
    }
}
