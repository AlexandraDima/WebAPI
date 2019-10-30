using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RentBook.Models
{
    public class RentBookContext : DbContext
    {
        //Main class that coordinates EF functionality for a given data model
        //RentBookContext manages entity objects during run time, 
        //which includes populating objects with data from a database,
        //updating new data to the database.

        //The name of the connection string (which is added the Web.config file) 
        //that is used for the database 
        public RentBookContext() : base("name=RentBookContext")
        {
          
        }
        //Specify the tables we want to use
        //Create a DbSet property for each entity set.
        public System.Data.Entity.DbSet<RentBook.Models.Author> Authors { get; set; }

        public System.Data.Entity.DbSet<RentBook.Models.Book> Books { get; set; }
    }
}
