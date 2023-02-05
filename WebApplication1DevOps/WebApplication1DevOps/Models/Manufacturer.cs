using System;

namespace WebApplication1DevOps
{
    public class Manufacturer
    {
        public string CountryName { get; set; }
        public string CompanyName { get; set; }
        public Manufacturer(string country, string company)
        {
            CountryName = country;
            CompanyName = company;
        }
    }
}
