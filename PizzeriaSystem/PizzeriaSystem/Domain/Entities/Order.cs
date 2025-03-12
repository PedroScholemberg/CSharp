using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaSystem.Domain.Entities
{
    public class Order
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; }

        public void addProduto(Product product)
        {
            Products.Add(product);
        }
        public void removeProduto(Product product)
        {
            Products.Remove(product);
        }

        Order(int id, string name, string description)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
        }
        Order(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }
    }
}
