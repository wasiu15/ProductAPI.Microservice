using ProductDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDomain.Interfaces.Repositories
{
    public interface ICategoryTypeRepository
    {
        Task<ICollection<CategoryType>> GetCategoryTypes();
        Task<string> FindCategoryNameById(int id);
    }
}
