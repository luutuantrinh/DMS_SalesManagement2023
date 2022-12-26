using DMS.SalesManagement2023.Categories;
using DMS.SalesManagement2023.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace DMS.SalesManagement2023.Data
{
    public class ProductManagementDataSeedContributor: IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Category, Guid> _categoryRepository;
        private readonly IRepository<Product, Guid> _productRepository;
        public ProductManagementDataSeedContributor(IRepository<Category, Guid> categoryRepository, IRepository<Product, Guid> productRepository)
        {
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
        }
        public async Task SeedAsync(DataSeedContext context)
        {
            if(await _categoryRepository.CountAsync() > 0) { return; }
            var monitors = new Category { Name = "Monitors" };
            var printers = new Category { Name = "Printers" };
            await _categoryRepository
                .InsertManyAsync(new[] {monitors, printers });
            var monitor1 = new Product
            {
                Category = monitors,
                Name = "XP VH240a 23.8-Inch Full HD 1080p IPS LED Monitor",
                Price = 163,
                ReleaseDate = new DateTime (2022, 05, 24),
                StockState = ProductStockState.InStock
            };
            var monitor2 = new Product
            {
                Category = monitors,
                Name = "Clips 328E1CA 32-Inch Curved Monitor, 4K UHD",
                Price = 349,
                IsFreeCargo= true,
                ReleaseDate = new DateTime(2022, 11, 11),
                StockState = ProductStockState.PreOrder
            };
            var printer1 = new Product
            {
                Category = printers,
                Name = "First Acme Monochrome Laser Printer, Compact All-In One",
                Price = 199,
                ReleaseDate = new DateTime(2022, 06, 07),
                StockState = ProductStockState.NotAvailable
            };
            var printer2 = new Product
            {
                Category = printers,
                Name = "Second Acme Monochrome Laser Printer, Compact All-In One",
                Price = 299,
                ReleaseDate = new DateTime(2022, 06, 07),
                StockState = ProductStockState.PreOrder
            };
            await _productRepository
                .InsertManyAsync(new[] { monitor1, monitor2, printer1, printer2 });

        }
    }
}
