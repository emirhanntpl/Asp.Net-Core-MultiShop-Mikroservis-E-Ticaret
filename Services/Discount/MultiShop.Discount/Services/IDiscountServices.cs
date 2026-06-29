using MultiShop.Discount.Dtos;

namespace MultiShop.Discount.Services
{
    public interface IDiscountServices
    {

        Task<List<ResultCouponDto>> GetAllCouponsAsync();
        Task CreateCouponAsync(CreateCouponDto createCouponDto);
        Task DeleteCouponAsync(string id);
        Task UpdateCouponAsync(UpdateCouponDto updateCouponDto);
       Task<GetByIdCouponDto> GetByIdCouponAsync(string id);

    }
}
