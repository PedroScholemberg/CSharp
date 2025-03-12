using Microsoft.CodeAnalysis.Editing;
using PizzeriaSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaSystem.Application.Interfaces
{
    internal interface ProductInterface
    {
        void createProdutct(string name, double price, string description);
        void deleteProduct(Product product);
        void updateProduct(string name , double price, string description);
    }
}
