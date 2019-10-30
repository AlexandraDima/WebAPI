using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentBook.Models
{
    //Right now, the web API exposes the database entities to the client.The client receives data that maps 
    //directly to our database tables.However, that's not always a good idea. To change the shape of the data that we send to client,
    //we defined a data transfer object (DTO). A DTO is an object that defines how the data will be sent over the network.
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
    }
}