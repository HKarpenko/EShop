using System;
using System.Collections.Generic;
using System.Text;

namespace e_Sport.Domain
{
    public class Adress
    {
        private static int counter = 1;
        public Adress(string country, string city, string homeAdress)
        {
            Country = country;
            City = city;
            HomeAdress = homeAdress;
            Id = counter;
            counter++;
        }
        public int Id { get; private set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string HomeAdress { get; set; }

        public string GetFullAdress()
        {
            return $"{Country}, {City}, {PostalCode}, {HomeAdress}";
        }
        public bool isValid()
        {
            return Country != null && City != null && HomeAdress != null;
        }
    }
}
