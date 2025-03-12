using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaSystem.Application.Interfaces
{
    internal interface PaymentInterface
    {
        void payment(double totalPrice, int installments);
    }
}
