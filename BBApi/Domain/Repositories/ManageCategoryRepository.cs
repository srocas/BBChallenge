using BBDomain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BBDomain.Repositories
{
    public class ManageCategoryRepository : IManageCategoryRepository
    {
        private readonly ApplicationDBContext _context;

        public ManageCategoryRepository(ApplicationDBContext context)
        {
            _context= context;
        }

        public List<Category> GetCategories() 
        {
            return _context.Categories.Include(s => s.SubCategories).ThenInclude(x => x.InteriorCategories).ToList(); 
        }

        public List<SubCategory> GetSubCategoriesByIdCategory(int idCategory)
        {
            return _context.SubCategories.Where(x => x.IdCategory == idCategory).ToList();
        }
        public List<InteriorCategory> GetInteriorCategoriesByIdSubCategory(int idSubCategory)
        {
            return _context.InteriorCategories.Where(x => x.IdSubCategory == idSubCategory).ToList();
        }

        public Category? GetCategory(int idCategory)
        {
            return _context.Categories.Where(x => x.Id == idCategory).FirstOrDefault();
        }
        public SubCategory? GetSubCategory(int idSubCategory)
        {
            return _context.SubCategories.Where(x => x.Id == idSubCategory).FirstOrDefault();
        }
        public InteriorCategory? GetInteriorCategory(int idInteriorCategory)
        {
            return _context.InteriorCategories.Where(x => x.Id == idInteriorCategory).FirstOrDefault();
        }
        public Category AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return category;
        }

        public SubCategory AddSubCategory(SubCategory subCategory)
        {
            _context.SubCategories.Add(subCategory);
            _context.SaveChanges();
            return subCategory;
        }
        public InteriorCategory AddInteriorCategory(InteriorCategory interiorCategory)
        {
            _context.InteriorCategories.Add(interiorCategory);
            _context.SaveChanges();
            return interiorCategory;
        }

        public Category EditCategory(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
            return category;
        }

        public SubCategory EditSubCategory(SubCategory subCategory)
        {
            _context.SubCategories.Update(subCategory);
            _context.SaveChanges();
            return subCategory;
        }
        public InteriorCategory EditInteriorCategory(InteriorCategory interiorCategory)
        {
            _context.InteriorCategories.Update(interiorCategory);
            _context.SaveChanges();
            return interiorCategory;
        }
        public Category DeleteCategory(Category category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
            return category;
        }

        public SubCategory DeleteSubCategory(SubCategory subCategory)
        {
            _context.SubCategories.Remove(subCategory);
            _context.SaveChanges();
            return subCategory;
        }
        public InteriorCategory DeleteInteriorCategory(InteriorCategory interiorCategory)
        {
            _context.InteriorCategories.Remove(interiorCategory);
            _context.SaveChanges();
            return interiorCategory;
        }
    }
}
