using System.Collections.Generic;
using System;

namespace EntityFrameWork
{
    public class Student
    {
        //the field called "ID" or <classname>ID will be the primary key
        public int ID {get; set;}
        //datafields of the ID
        public string LastName {get; set;}
        public string FirstMidName{get; set;}
        public DateTime EnrollmentDate{get; set;}

        //this public virtual is a collection as one student has many enrollments
        public virtual ICollection<Enrollment> Enrollments{get; set;}
        
    }

}