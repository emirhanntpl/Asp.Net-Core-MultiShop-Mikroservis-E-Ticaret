using IRepository;
using MultiShop.Order.Application.Features.Commands.AddressCommands;
using MultiShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.Handlers.OrderDetailHandlers
{
    internal class UpdateOrderDetailQueryHandler
    {

        private readonly IRepository<OrderDetail> _repository;

        public UpdateOrderDetailQueryHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }
        public async Task Handler(UpdateOrderDetailCommand command)
        {
            var values = await _repository.GetByIdAsync(command.AddressId);
            values.Detail = command.Detail;
            values.District = command.District;
            values.City = command.City;
            values.UserId = command.UserId;
            await _repository.UpdateAsync(values);
        }
    }
}
