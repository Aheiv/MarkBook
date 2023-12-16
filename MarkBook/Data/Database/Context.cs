using MarkBook.Data.Database.Model;
using Microsoft.EntityFrameworkCore;

namespace MarkBook.Data.Database
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
           : base(options)
        {
        }

        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<Mark> Marks { get; set; }
        public virtual DbSet<Parent> Parents { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<Specialization> Specializations { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Student_Parent> Student_Parent { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Subject_Student_Mark> Subject_Student_Mark { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
	}
}
