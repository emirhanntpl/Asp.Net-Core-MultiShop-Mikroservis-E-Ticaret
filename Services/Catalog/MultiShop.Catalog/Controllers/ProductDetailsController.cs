using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.Dtos.ProductDetailsDtos;
using MultiShop.Catalog.Services.ProductDetailsDetailsServices;


namespace MultiShop.Catalog.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class ProductDetailsController : ControllerBase
    {
        private readonly IProductDetailsService _ProductDetailsService;

        public ProductDetailsController(IProductDetailsService ProductDetailsService)
        {
            _ProductDetailsService = ProductDetailsService;
        }


        [HttpGet]
        public async Task<IActionResult> ProductDetailsList()
        {
            var values = await _ProductDetailsService.GetAllProductDetailsAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductDetailsById(string id)
        {
            var values = await _ProductDetailsService.GetByIdProductDetailsAsync(id);

            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProductDetails(CreateProductDetailsDto createProductDetailsDto)
        {
            await _ProductDetailsService.CreateProductDetailsAsync(createProductDetailsDto);
            return Ok("Kategori eklendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProductDetails(string id)
        {
            await _ProductDetailsService.DeleteProductDetailsAsync(id);
            return Ok("Kategori silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProductDetails(UpdateProductDetailsDto updateProductDetailsDto)
        {
            await _ProductDetailsService.UpdateProductDetailsAsync(updateProductDetailsDto);
            return Ok("Kategori güncellendi.");


        }
    }
}

