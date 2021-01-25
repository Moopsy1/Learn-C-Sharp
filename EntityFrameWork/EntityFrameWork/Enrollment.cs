namespace EntityFrameWork
{
    public enum Grade{
        A, B, C, D, F
    }


    public class Enrollment
    {
        public int EnrollmentID {get; set;}
        //courseID is a foreign key, hence the ID suffix on the name
        public int CourseID {get; set;}
        public int StudentID{get; set;}
        //varname? means the variable is nullable
        public Grade? Grade{get; set;}
        
        //the virual methods are the containers for the relationships
        //on a many to one or a many to many, the public virual must be a container
        //eg here we relate a course to a student in a 1-1 relationship
        public virtual Course Course {get; set;}
        public virtual Student Student {get; set;}

    }
}