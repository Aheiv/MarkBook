using System.ComponentModel.DataAnnotations;

namespace MarkBook.Data.Database.Model
{
    public partial class Student_Parent
    {
        [Key]
        public int id_student_parent { get; set; }

        public int id_student { get; set; }

        public int id_parent { get; set; }

        public virtual Parent Parent { get; set; }

        public virtual Student Student { get; set; }
    }
}
