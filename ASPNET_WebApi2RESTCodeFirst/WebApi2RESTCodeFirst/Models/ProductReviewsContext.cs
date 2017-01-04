using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApi2RESTCodeFirst.Models
{
    /*
        Models/ProductReviewsContext.cs : Represents the derived context that manages all the data 
        operations with entities during runtime. It derives from System.Data.Entity.DbContext and 
        exposes a generic type DbSet<TEntity> for each class in the Models.
    */

    public class ProductReviewsContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ProductReviewsContext() : base("name=ProductReviewsContext")
        {
        }

        public System.Data.Entity.DbSet<WebApi2RESTCodeFirst.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<WebApi2RESTCodeFirst.Models.Review> Reviews { get; set; }
    }
}
