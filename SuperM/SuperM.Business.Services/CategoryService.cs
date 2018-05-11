namespace SuperM.Business.Services
{
    using SuperM.Data.Entities;
    using SuperM.Data.Repositories;
    using System.Collections.Generic;
    using System.Linq;

    public class CategoryService
    {
        private SuperMContext Context;

        public CategoryService()
        {
            Context = new SuperMContext();
        }

        public List<Category> GetCategoryList()
        {
            var categorys = Context.Categories.ToList();
            return categorys;
        }

        public Category GetCategoryById(int categoryId)
        {
            Category category = Context.Categories.FirstOrDefault(x => x.CategoryId == categoryId);
            return category;
        }

        public List<Category> GetCategoryListByName(string name)
        {
            var categorys = Context.Categories.Where(x => x.Name.Contains(name)).ToList();
            return categorys;
        }

        public bool IsNameExisted(string name)
        {
            bool isNameExisted = false;
            isNameExisted = (Context.Categories.Count(x => x.Name == name) > 0);
            return isNameExisted;
        }

        public void Add(Category category)
        {
            Context.Categories.Add(category);
            Context.SaveChanges();
        }

        public void DeleteCategoryById(int categoryId)
        {
            Category category = GetCategoryById(categoryId);
            Context.Categories.Remove(category);
            Context.SaveChanges();
        }

        public void UpdateCategoryByCategory(Category category)
        {
            var Category = GetCategoryById(category.CategoryId);
            if (Category != null)
            {
                Category.CategoryId = category.CategoryId;
                Category.Name = category.Name;
            }
            Context.SaveChanges();
        }
    }
}
