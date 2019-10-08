using System.Collections.Generic;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDbContent _dbContent;

        public CategoryRepository(AppDbContent appDbContent)
        {
            _dbContent = appDbContent;
        }

        public IEnumerable<Category> AllCategories => _dbContent.Categories;
    }
}