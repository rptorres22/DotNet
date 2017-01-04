using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi2Example.Models;

namespace WebApi2Example.Controllers
{
    /*
        To keep the example simple, products are stored in a fixed array inside the controller class. Of course, in a real application, you would 
        query a database or use some other external data source.

        The controller defines two methods that return products:

        The GetAllProducts method returns the entire list of products as an IEnumerable<Product> type.
        The  GetProduct method looks up a single product by its ID.
        That's it! You have a working web API.  Each method on the controller corresponds to one or more URIs:

        Controller Method	URI
        GetAllProducts	    /api/products
        GetProduct	        /api/products/id


        For the GetProduct method, the id in the URI is a placeholder. For example, to get the product with ID of 5, the URI is api/products/5.
    */

    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
