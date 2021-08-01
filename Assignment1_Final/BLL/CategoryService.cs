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
        static CategoryService()
        {
            AutoMapper.Mapper . Initialize(Config =>Config.AddProfile<MapperConfig.AutoMapperSettings>());
        }
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
        public static List<CategoryDetail> GetCategoryWithDetails()
        {
            var data = CategoryRepo.GetCategories();
            var cDetails = AutoMapper.Mapper.Map<List<Category>, List<CategoryDetail>>(data);
            return cDetails;
        }
        public static CategoryDetail GetCategoryDetail(int id)
        {
            var c = CategoryRepo.GetCategoryDetail(id);
            var catedetail = AutoMapper.Mapper.Map<Category, CategoryDetail>(c);
            return catedetail;
        }

    }
}
