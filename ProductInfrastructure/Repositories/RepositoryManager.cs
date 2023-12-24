using ProductDomain.Interfaces.Repositories;
using ProductInfrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInfrastructure.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly ProductDbContext _repositoryContext;
        private readonly Lazy<IProductRepository> _productRepository;
        private readonly Lazy<ICategoryTypeRepository> _categoryTypeRepository;
        private readonly Lazy<ITagRepository> _tagRepository;
        public RepositoryManager(ProductDbContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _productRepository = new Lazy<IProductRepository>(() => new ProductRepository(repositoryContext));
            _categoryTypeRepository = new Lazy<ICategoryTypeRepository>(() => new CategoryTypeRepository(repositoryContext));
            _tagRepository = new Lazy<ITagRepository>(() => new TagRepository(repositoryContext));
        }

        public IProductRepository ProductRepository => _productRepository.Value;
        public ICategoryTypeRepository CategoryTypeRepository => _categoryTypeRepository.Value;
        public ITagRepository TagRepository => _tagRepository.Value;
        public async Task SaveAsync() => _repositoryContext.SaveChanges();

    }
}
