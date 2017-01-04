using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi2RESTCodeFirst.Models
{
    public class ProductDetailsDto
    {
        public string Name { get; set; }

        public string Category { get; set; }

        public int Price { get; set; }

        public List<Review> Reviews { get; set; }
    }
}