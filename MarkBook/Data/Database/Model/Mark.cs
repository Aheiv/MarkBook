using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MarkBook.Data.Database.Model
{
    [Table("Mark")]
    public partial class Mark
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mark()
        {
            Subject_Student_Mark = new HashSet<Subject_Student_Mark>();
        }

        [Key]
        public int id_mark { get; set; }

        public int? grade { get; set; }

        [StringLength(2)]
        public string? appointment { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subject_Student_Mark> Subject_Student_Mark { get; set; }
    }
}
