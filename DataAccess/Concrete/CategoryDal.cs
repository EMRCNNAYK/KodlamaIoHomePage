using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {

        List<Category> _category;
        public CategoryDal()
        {
            _category = new List<Category>()

    {
        new Category { CategoryId = 1, CategoryName = "Tümü" },
        new Category { CategoryId = 2, CategoryName = "Programlama" },
    };

            void Add(Category category)
            {
                _category.Add(category);

            }

            void Delete(Category category)
            {
                Category categoryToDelete = _category.SingleOrDefault(c => c.CategoryId == category.CategoryId);
                _category.Remove(categoryToDelete);
            }

            Category Get(int id)
            {
                return _category.SingleOrDefault(c => c.CategoryId == id);
            }

            List<Category> GetAll()
            {
                return _category.ToList();
            }

            void Update(Category category)
            {
                Category categoryToUpdate = _category.SingleOrDefault(c => c.CategoryId == category.CategoryId);
                categoryToUpdate.CategoryName = category.CategoryName;
            }
        }


        {

    }
}