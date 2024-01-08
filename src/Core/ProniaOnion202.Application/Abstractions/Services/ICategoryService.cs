
using ProniaOnion202.Application.DTOs.Categories;

namespace ProniaOnion202.Application.Abstractions.Services
{
    public interface ICategoryService
    {
        Task<ICollection<CategoryItemDto>> GetAllAsync(int page, int take);
        //Task<GetCategoryDto> GetAsync(int id);
        Task CreateAsync(CategoryCreateDto categoryDto);
        Task SoftDeleteAsync(int id);
    }
}
