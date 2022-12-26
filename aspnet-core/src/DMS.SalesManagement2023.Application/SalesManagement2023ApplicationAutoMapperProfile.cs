using AutoMapper;
using DMS.SalesManagement2023.Products;

namespace DMS.SalesManagement2023;

public class SalesManagement2023ApplicationAutoMapperProfile : Profile
{
    public SalesManagement2023ApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Product, ProductDto>();
    }
}
