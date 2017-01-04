using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApi2RESTCodeFirst.Models;

namespace WebApi2RESTCodeFirst.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Category { get; set; }

        public int Price { get; set; }

        //Navigation Property
        public ICollection<Review> Reviews { get; set; }
    }
}

/*
    To explain in EntityFramework code first approach, it uses these models to create the corresponding tables. 
    According to convention for both the Models the Id property will become the Primary key for that table.

    Here we are considering a One - Many relationship between a Products and Reviews table(assuming a product 
    can have multiple reviews).

    So the Products model is having a navigation property which is a collection and refers to the Review. 
    Similarly in Review table we have a navigation property for a Product(which is not a collection, as a 
    review can be associated to only one prpoduct). Review table contains a property ProductId which is the 
    Foreign key for the table.
*/
