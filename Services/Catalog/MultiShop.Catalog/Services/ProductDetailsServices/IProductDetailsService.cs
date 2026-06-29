using MultiShop.Catalog.Dtos.ProductDetailsDtos;

namespace MultiShop.Catalog.Services.ProductDetailsDetailsServices
{
    public interface IProductDetailsService
    {
        Task<List<ResultProductDetailsDto>> GetAllProductDetailsAsync();

        Task CreateProductDetailsAsync(CreateProductDetailsDto createProductDetailsDto);

        Task UpdateProductDetailsAsync(UpdateProductDetailsDto updateProductDetailsDto);

        Task DeleteProductDetailsAsync(string id);

        Task<GetByIdProductDetailsDto> GetByIdProductDetailsAsync(string id);




    }
}
