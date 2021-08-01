using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class ProductRepo
    {
         static ImsDBEntities context;
         static ProductRepo()
        {
            context = new ImsDBEntities();
        }
         public static void AddProduct(Product model)
          {
              context.Products.Add(model);
              context.SaveChanges();
          }
       /* public static void AddProduct(Product c)
        {
            context.Products.Add(c);
            context.SaveChanges();
        }*/

        public static List<Product> GetAllProducts()
        {
            var data = context.Products.ToList();
            return data;
        }
        public static Product GetProduct(int id)
        {
            var data = context.Products.FirstOrDefault(e => e.id == id);
            return data;
        }
    }
}
