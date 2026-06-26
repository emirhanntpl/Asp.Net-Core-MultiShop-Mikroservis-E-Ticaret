using AutoMapper;
using MultiShop.Catalog.Controllers.Entities;
using MultiShop.Catalog.Dtos.CategoryDtos;
using MultiShop.Catalog.Dtos.ProductDetailsDtos;
using MultiShop.Catalog.Dtos.ProductDtos;
using MultiShop.Catalog.Dtos.ProductImageDtos;

namespace MultiShop.Catalog.Mapping
{
    public class GeneralMapping : Profile
    {

        public GeneralMapping() {

            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, GetByIdCategoryDto>().ReverseMap();



            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product,CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, GetByIdProductDto>().ReverseMap();


            CreateMap<ProductDetails, CreateProductDetailsDto>().ReverseMap();
            CreateMap<ProductDetails, ResultProductDetailsDto>().ReverseMap();
            CreateMap<ProductDetails, UpdateProductDetailsDto>().ReverseMap();
            CreateMap<ProductDetails, GetByIdProductDetailsDto>().ReverseMap();


            CreateMap<ProductImages, CreateProductImageDto>().ReverseMap();
            CreateMap<ProductImages, ResultProductImageDto>().ReverseMap();
            CreateMap<ProductImages, UpdateProductImageDto>().ReverseMap();
            CreateMap<ProductImages, GetByIdProductImageDto>().ReverseMap();
        
        
        
        
        
        
        
        
        }





    }
}
