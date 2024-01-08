using ProniaOnion202.Application.Abstractions.Repositories;
using ProniaOnion202.Domain.Entities;
using ProniaOnion202.Persistence.Contexts;


namespace ProniaOnion202.Persistence.Implementations.Repositories
{
    internal class CategoryRepository:Repository<Category>,ICategoryRepository
    {
        public CategoryRepository(AppDbContext context):base(context)
        {

        }
    }
}
