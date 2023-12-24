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
    public class TagRepository : ITagRepository
    {
        private readonly ProductDbContext _dbContext;
        public TagRepository(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ICollection<Tag>> GetTags()
        {
            return (ICollection<Tag>)await _dbContext.Tags.ToListAsync();
        }

        public async Task<List<Tag>> GetTagNamesByIds(List<int> ids)
        {
            var result = new List<Tag>();
            foreach (var id in ids)
            {
                var getTagById = await _dbContext.Tags.Where(tag => tag.TagId == id).FirstOrDefaultAsync();
                if (getTagById != null)
                    result.Add(getTagById);
            }
            return result;
        }

    }
}
