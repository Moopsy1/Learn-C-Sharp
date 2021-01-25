//using System.Data.Entity
namespace EntityFrameWork
{
    public class SchoolContext /*: DbContext*/
    {
        
        //the base, is the connection string. Or the Name as referenced
        public SchoolContext() : base("SchoolContext"){}

        //a set is a table in EF. so there is a students table, an enrollment table and a Course table
        public DbSet<Student> Students {get; set;}
        public DbSet<Enrollment> Enrollments {get; set;}
        public DbSet<Course> Courses {get; set;}



        
    }
}