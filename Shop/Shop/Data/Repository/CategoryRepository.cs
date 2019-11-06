using System.Collections.Generic;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDbContext _dbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IEnumerable<Category> AllCategories => _dbContext.Categories;
    }
}