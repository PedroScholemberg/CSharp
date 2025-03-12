using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaSystem.Domain.Entities
{
    public class Product
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        Product(int id, string name, string description, double price) 
        { 
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Description = description;
        }
        Product(string name, string description, double price)
        {
            this.Name = name;
            this.Price = price;
            this.Description = description;
        }
    }
}
