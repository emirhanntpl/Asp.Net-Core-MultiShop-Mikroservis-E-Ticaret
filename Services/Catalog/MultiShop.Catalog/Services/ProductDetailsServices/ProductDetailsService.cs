using AutoMapper;
using MongoDB.Driver;
using MultiShop.Catalog.Controllers.Entities;
using MultiShop.Catalog.Dtos.ProductDetailsDtos;
using MultiShop.Catalog.Settings;

namespace MultiShop.Catalog.Services.ProductDetailsDetailsServices
{
    public class ProductDetailsService: IProductDetailsService
    {

        private readonly IMongoCollection<ProductDetails> _ProductDetailsCollection;
        private readonly IMapper _mapper;

        public ProductDetailsService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {

            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _ProductDetailsCollection = database.GetCollection<ProductDetails>(_databaseSettings.ProductDetailsCollectionName);
            _mapper = mapper;
        }

        public async Task CreateProductDetailsAsync(CreateProductDetailsDto createProductDetailsDto)
        {
            var values = _mapper.Map<ProductDetails>(createProductDetailsDto);
            await _ProductDetailsCollection.InsertOneAsync(values);
        }

        public async Task DeleteProductDetailsAsync(string id)
        {
            await _ProductDetailsCollection.DeleteOneAsync(x => x.ProductDetailsID == id);
        }

        public async Task<List<ResultProductDetailsDto>> GetAllProductDetailsAsync()
        {
            var values = await _ProductDetailsCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultProductDetailsDto>>(values);
        }

        public async Task<GetByIdProductDetailsDto> GetByIdProductDetailsAsync(string id)
        {

            var values = await _ProductDetailsCollection.Find(x => x.ProductDetailsID == id).FirstOrDefaultAsync();

            return _mapper.Map<GetByIdProductDetailsDto>(values);
        }

        public async Task UpdateProductDetailsAsync(UpdateProductDetailsDto updateProductDetailsDto)
        {
            var values = _mapper.Map<ProductDetails>(updateProductDetailsDto);
            await _ProductDetailsCollection.ReplaceOneAsync(x => x.ProductDetailsID == updateProductDetailsDto.ProductDetailsID, values);

        }
    }
}
