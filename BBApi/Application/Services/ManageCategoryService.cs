using AutoMapper;
using BBApplication.DTOs;
using BBDomain.Entities;
using BBDomain.Repositories;

namespace BBApplication.Services
{
    public class ManageCategoryService : IManageCategoryService
    {
        private readonly IMapper _mapper;
        private readonly IManageCategoryRepository _manageCategoryRepository;
        public ManageCategoryService(IMapper mapper, IManageCategoryRepository manageCategoryRepository)
        {
            _manageCategoryRepository = manageCategoryRepository;
            _mapper = mapper;
        }

        public List<CategoryDTO> GetCategories()
        {
            return _mapper.Map<List<CategoryDTO>>( _manageCategoryRepository.GetCategories());
        }
        public List<SubCategoryDTO> GetSubCategoriesByIdCategory(int idCategory)
        {
            return _mapper.Map<List<SubCategoryDTO>>(_manageCategoryRepository.GetSubCategoriesByIdCategory(idCategory));
        }
        public List<InteriorCategoryDTO> GetInteriorCategoriesByIdSubCategory(int idSubCategory)
        {
            return _mapper.Map<List<InteriorCategoryDTO>>(_manageCategoryRepository.GetInteriorCategoriesByIdSubCategory(idSubCategory));
        }
        public bool AddCategory(CategoryDTO categoryDTO)
        {
            var category = _mapper.Map<Category>(categoryDTO);
            return _manageCategoryRepository.AddCategory(category).Id > 0;
        }
        public bool AddSubCategory(SubCategoryDTO subCategoryDTO)
        {
            var subCategory = _mapper.Map<SubCategory>(subCategoryDTO);
            return _manageCategoryRepository.AddSubCategory(subCategory).Id > 0;
        }
        public bool AddInteriorCategory(InteriorCategoryDTO interiorCategoryDTO)
        {
            var interiorCategory = _mapper.Map<InteriorCategory>(interiorCategoryDTO);
            return _manageCategoryRepository.AddInteriorCategory(interiorCategory).Id > 0;
        }
        public bool EditCategory(CategoryDTO categoryDTO)
        {
            var category = _manageCategoryRepository.GetCategory(categoryDTO.Id);
            if (category is null)
            {
                return false;
            }

            category.Active = categoryDTO.Active;
            category.Static = categoryDTO.Static;
            category.Title= categoryDTO.Title;
            category.Description= categoryDTO.Description;
            category.Name = categoryDTO.Name;
            category.PrettyUrl = categoryDTO.PrettyUrl;
            category.Thumbnail = categoryDTO.Thumbnail;

            return _manageCategoryRepository.EditCategory(category).Id > 0;
        }
        public bool EditSubCategory(SubCategoryDTO subCategoryDTO)
        {
            var subCategory = _manageCategoryRepository.GetSubCategory(subCategoryDTO.Id);
            if (subCategory is null) return false;

            subCategory.Active = subCategoryDTO.Active;
            subCategory.Static = subCategoryDTO.Static;
            subCategory.Title = subCategoryDTO.Title;
            subCategory.Description = subCategoryDTO.Description;
            subCategory.Name = subCategoryDTO.Name;
            subCategory.PrettyUrl = subCategoryDTO.PrettyUrl;
            subCategory.Thumbnail = subCategoryDTO.Thumbnail;

            return _manageCategoryRepository.EditSubCategory(subCategory).Id > 0;
        }
        public bool EditInteriorCategory(InteriorCategoryDTO interiorCategoryDTO)
        {
            var interiorCategory = _manageCategoryRepository.GetInteriorCategory(interiorCategoryDTO.Id);
            if (interiorCategory is null) return false;

            interiorCategory.Active = interiorCategoryDTO.Active;
            interiorCategory.Static = interiorCategoryDTO.Static;
            interiorCategory.Title = interiorCategoryDTO.Title;
            interiorCategory.Description = interiorCategoryDTO.Description;
            interiorCategory.Name = interiorCategoryDTO.Name;
            interiorCategory.PrettyUrl = interiorCategoryDTO.PrettyUrl;
            interiorCategory.Thumbnail = interiorCategoryDTO.Thumbnail;

            return _manageCategoryRepository.EditInteriorCategory(interiorCategory).Id > 0;
        }
        public bool DeleteCategory(int idCategory)
        {
            var category = _manageCategoryRepository.GetCategory(idCategory);

            if (category is null) return false;
            _manageCategoryRepository.DeleteCategory(category);
            return true;
        }
        public bool DeleteSubCategory(int idSubcategory)
        {
            var subCategory = _manageCategoryRepository.GetSubCategory(idSubcategory);

            if (subCategory is null) return false;
            _manageCategoryRepository.DeleteSubCategory(subCategory);
            return true;
        }
        public bool DeleteInteriorCategory(int idInteriorCategory)
        {
            var interiorCategory = _manageCategoryRepository.GetInteriorCategory(idInteriorCategory);

            if (interiorCategory is null) return false;
            _manageCategoryRepository.DeleteInteriorCategory(interiorCategory);
            return true;
        }
    }
}
