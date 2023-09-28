using BBApplication.DTOs;

namespace BBApplication.Services
{
    public interface IManageCategoryService
    {
        public List<CategoryDTO> GetCategories();
        public List<SubCategoryDTO> GetSubCategoriesByIdCategory(int idCategory);
        public List<InteriorCategoryDTO> GetInteriorCategoriesByIdSubCategory(int idSubCategory);
        public bool AddCategory(CategoryDTO categoryDTO);
        public bool AddSubCategory(SubCategoryDTO subCategoryDTO);
        public bool AddInteriorCategory(InteriorCategoryDTO interiorCategoryDTO);
        public bool EditCategory(CategoryDTO categoryDTO);
        public bool EditSubCategory(SubCategoryDTO subCategoryDTO);
        public bool EditInteriorCategory(InteriorCategoryDTO interiorCategoryDTO);
        public bool DeleteCategory(int idCategory);
        public bool DeleteSubCategory(int idSubcategory);
        public bool DeleteInteriorCategory(int idInteriorCategory);
    }
}
