using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProductDomain.Interfaces.Repositories
{
    public interface IRepositoryManager
    {
        IProductRepository ProductRepository { get; }
        ICategoryTypeRepository CategoryTypeRepository { get; }
        ITagRepository TagRepository { get; }
        Task SaveAsync();
    }
}
