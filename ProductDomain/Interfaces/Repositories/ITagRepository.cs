using ProductDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDomain.Interfaces.Repositories
{
    public interface ITagRepository
    {
        Task<ICollection<Tag>> GetTags();
        Task<List<Tag>> GetTagNamesByIds(List<int> ids);
    }
}
