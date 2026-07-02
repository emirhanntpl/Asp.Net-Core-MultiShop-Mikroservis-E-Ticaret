using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.Commands.AddressCommands
{
    public class CreateAddressCommand
    {
        public int AddressId { get; set; }
        public string UserId { get; set; }
        public String District { get; set; }
        public string City { get; set; }
        public string Detail { get; set; }

    }
}
