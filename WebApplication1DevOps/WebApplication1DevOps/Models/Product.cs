using System;

namespace WebApplication1DevOps
{
    public class Product
    {
        public string ID { get; set; } = "";
        public string Name { get; set; }
        public Manufacturer ManufacturerOfProduct { get; set; }
        public decimal Price { get; set; }
    }
}
