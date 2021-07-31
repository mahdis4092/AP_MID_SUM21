using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryRepo
    {
        static ImsDBEntities context;
        static CategoryRepo()
        {
            context = new ImsDBEntities();
        }
        public static List<string> GetCategoryNames()
        {
            var data = context.Categories.Select(e => e.name).ToList();
            return data;
        }
    }
}
