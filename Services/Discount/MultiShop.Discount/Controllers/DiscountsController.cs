using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Discount.Dtos;
using MultiShop.Discount.Services;

namespace MultiShop.Discount.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountsController : ControllerBase
    {
        private readonly IDiscountServices _discountServices;

        public DiscountsController(IDiscountServices discountServices)
        {
            _discountServices = discountServices;
        }
        [HttpGet]
        public async Task<IActionResult> DiscountCouponList()
        {
            var values = await _discountServices.GetAllCouponsAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDiscountCouponById(string id)
        {
            var values = await _discountServices.GetByIdCouponAsync(id);
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateDiscountCoupon(CreateCouponDto createCouponDto)
        {
            await _discountServices.CreateCouponAsync(createCouponDto);
            return Ok("Kupon eklendi.");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteDiscountCoupon(string id)
        {
            await _discountServices.DeleteCouponAsync(id);
            return Ok("Kupon silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateDiscountCoupon(UpdateCouponDto updateCouponDto)
        {
            await _discountServices.UpdateCouponAsync(updateCouponDto);
            return Ok("Kupon güncellendi.");
        }
    }
}
