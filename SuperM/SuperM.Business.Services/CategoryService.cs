namespace SuperM.Business.Services
{
    using SuperM.Data.Entities;
    using SuperM.Data.Repositories;
    using System.Collections.Generic;
    using System.Linq;

    public class CategoryService
    {
        private SuperMContext _context;

        public CategoryService()
        {
            _context = new SuperMContext();
        }

        public List<Category> GetCategoryList()
        {
            var categorys = _context.Categories.ToList();
            return categorys;
        }

        public Category GetCategoryById(int categoryId)
        {
            Category category = _context.Categories.FirstOrDefault(x => x.CategoryId == categoryId);
            return category;
        }

        public List<Category> GetCategoryListByName(string name)
        {
            var categorys = _context.Categories.Where(x => x.Name.Contains(name)).ToList();
            return categorys;
        }

        public bool IsNameExisted(string name)
        {
            bool isNameExisted = false;
            isNameExisted = (_context.Categories.Count(x => x.Name == name) > 0);
            return isNameExisted;
        }

        public void Add(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void DeleteCategoryById(int categoryId)
        {
            Category category = GetCategoryById(categoryId);
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }

        public void UpdateCategoryByCategory(Category category)
        {
            var Category = GetCategoryById(category.CategoryId);
            if (Category != null)
            {
                Category.CategoryId = category.CategoryId;
                Category.Name = category.Name;
            }
            _context.SaveChanges();
        }
    }
}
