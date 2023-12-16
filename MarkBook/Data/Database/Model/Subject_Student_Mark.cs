using System.ComponentModel.DataAnnotations;

namespace MarkBook.Data.Database.Model
{
    public partial class Subject_Student_Mark
    {
        [Key]
        public int id_subject_student_mark { get; set; }

        public int id_subject { get; set; }

        public int id_student { get; set; }

        public int id_mark { get; set; }

        public virtual Mark Mark { get; set; }

        public virtual Student Student { get; set; }

        public virtual Subject Subject { get; set; }
    }
}
