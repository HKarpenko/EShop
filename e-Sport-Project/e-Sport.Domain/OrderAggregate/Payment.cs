using System;
using System.Collections.Generic;
using System.Text;
using e_Sport.Domain.Interfaces;

namespace e_Sport.Domain.OrderAggregate
{
    public class Payment : IEntity
    {
        private static int counter = 1;
        public Payment(string system)
        {
            PayingSystem = system;
            Id = counter;
            counter++;
        }
        public int Id { get; set; }
        public bool IsPayed { get; set; }
        public string PayingSystem { get; set; }
        public DateTime PayingDate { get; set; }

    }
}
