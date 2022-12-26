using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DMS.SalesManagement2023.Products
{
    public class ProductAppService_Tests : SalesManagement2023ApplicationTestBase
    {
        private readonly IProductAppService _productAppService;
        public ProductAppService_Tests()
        {
            _productAppService = GetRequiredService<IProductAppService>();
        }
        [Fact]
        public async Task Should_Get_Product_List()
        {
            //Act
            var output = await _productAppService.GetListAsync( new Volo.Abp.Application.Dtos.PagedAndSortedResultRequestDto() );
            //Assert 
            output.TotalCount.ShouldBe(4);
            output.Items.ShouldContain( x => x.Name.Contains("Acme Monochrome Laser Printer") );
        }
    }
}
