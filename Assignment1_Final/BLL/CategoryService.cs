using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoryService
    {
        public static List<string>GetCategoryNames()
        {
            return CategoryRepo.GetCategoryNames();
        }
        public static List<CategoryModel>GetCategories()
        {
            var categories = CategoryRepo.GetCategories();
            List<CategoryModel> data = new List<CategoryModel>();
            foreach(var c in categories)
            {
                var dm = new CategoryModel()
                {
                    id = c.id,
                    name = c.name
                };
                data.Add(dm);
            }
            return data;


        }
        public static void AddCategory(CategoryModel cate)
        {
            var c = new Category() { id = cate.id, name = cate.name };
            CategoryRepo.AddCategory(c);
        }
    }
}
