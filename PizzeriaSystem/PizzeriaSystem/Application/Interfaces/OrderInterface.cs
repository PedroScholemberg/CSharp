using PizzeriaSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaSystem.Application.Interfaces
{
    internal interface OrderInterface
    {
        void createOrder(List<Product> products, double totalPrice);
        void updateOrder(List<Product> products, double totalPrice);
        void deleteOrder(Order order);
    }
}
