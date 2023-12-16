using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MarkBook.Data.Database.Model
{

    [Table("Student")]
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            Grades = new HashSet<Grade>();
            Subject_Student_Mark = new HashSet<Subject_Student_Mark>();
            Student_Parent = new HashSet<Student_Parent>();
        }

        [Key]
        public int id_student { get; set; }

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
        [StringLength(30)]
        public string country { get; set; }

        [Required]
        [StringLength(30)]
        public string region { get; set; }

        [Required]
        [StringLength(30)]
        public string district { get; set; }

        [Required]
        [StringLength(30)]
        public string city { get; set; }

        [Required]
        [StringLength(30)]
        public string street { get; set; }

        [Required]
        [StringLength(30)]
        public string house { get; set; }

        [StringLength(30)]
        public string apartment { get; set; }

        [StringLength(12)]
        public string phonenumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Grade> Grades { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subject_Student_Mark> Subject_Student_Mark { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Parent> Student_Parent { get; set; }
    }
}
