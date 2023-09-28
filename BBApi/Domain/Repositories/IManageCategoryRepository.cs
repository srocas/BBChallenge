using BBDomain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BBDomain.Repositories
{
    public interface IManageCategoryRepository
    {
        public List<Category> GetCategories();
        public List<SubCategory> GetSubCategoriesByIdCategory(int idCategory);
        public List<InteriorCategory> GetInteriorCategoriesByIdSubCategory(int idSubCategory);
        public Category? GetCategory(int idCategory);
        public SubCategory? GetSubCategory(int idSubCategory);
        public InteriorCategory? GetInteriorCategory(int idInteriorCategory);
        public Category AddCategory(Category category);
        public SubCategory AddSubCategory(SubCategory subCategory);
        public InteriorCategory AddInteriorCategory(InteriorCategory interiorCategory);
        public Category EditCategory(Category category);
        public SubCategory EditSubCategory(SubCategory subCategory);
        public InteriorCategory EditInteriorCategory(InteriorCategory interiorCategory);
        public Category DeleteCategory(Category category);
        public SubCategory DeleteSubCategory(SubCategory subCategory);
        public InteriorCategory DeleteInteriorCategory(InteriorCategory interiorCategory);
    }
}
