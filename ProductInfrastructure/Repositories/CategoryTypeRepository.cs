using Microsoft.EntityFrameworkCore;
using ProductDomain.Interfaces.Repositories;
using ProductDomain.Models;
using ProductInfrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInfrastructure.Repositories
{
    public class CategoryTypeRepository : ICategoryTypeRepository
    {
        private readonly ProductDbContext _dbContext;
        public CategoryTypeRepository(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ICollection<CategoryType>> GetCategoryTypes()
        {
            return await _dbContext.categoryTypes.ToListAsync();
        }

        public async Task<string> FindCategoryNameById(int id)
        {
            return await _dbContext.categoryTypes.Where(type => type.Id == id).Select(category => category.Name).FirstOrDefaultAsync();
        }
    }
}
