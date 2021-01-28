using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{

    public class Movie
    {
        /* classes are added for managing movies in a database.
          The apps model classes use Entity Framework Core (EF Core) to work with the database. 
         EF Core is an object-relational mapper (O/RM) that simplifies data access. 
         You write the model classes first, and EF Core creates the database.
        */

        //field named ID becomes the private key
        public int ID { get; set; }
        public string Title { get; set; }

        //using System.ComponentModel.DataAnnotations;
        /* [DataType(DataType.Date)]: The[DataType] attribute specifies the type of the data(Date). With this attribute:
        The user isn't required to enter time information in the date field.
        Only the date is displayed, not time information.*/

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }

    }
}
