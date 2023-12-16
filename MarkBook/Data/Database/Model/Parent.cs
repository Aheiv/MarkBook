using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MarkBook.Data.Database.Model
{

    [Table("Parent")]
    public partial class Parent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Parent()
        {
            Student_Parent = new HashSet<Student_Parent>();
        }

        [Key]
        public int id_parent { get; set; }

        [Required]
        [StringLength(30)]
        public string surname { get; set; }

        [Required]
        [StringLength(30)]
        public string name { get; set; }

        [StringLength(30)]
        public string patronymic { get; set; }

        [Required]
        [StringLength(3)]
        public string gender { get; set; }

        [Column(TypeName = "date")]
        public DateTime date_of_birth { get; set; }

        [Required]
        [StringLength(12)]
        public string phonenumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Parent> Student_Parent { get; set; }
    }
}
