using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.Queries.OrderDetailsQueries
{
    public class GetOrderDetailByIdQuery
    {
        public GetOrderDetailByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
