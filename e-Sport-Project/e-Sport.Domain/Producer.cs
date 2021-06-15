using System;
using System.Collections.Generic;
using System.Text;

namespace e_Sport.Domain
{
    public class Producer
    {
        private static int counter = 1;
        public Producer()
        {
            Id = counter;
            counter++;
        }
        public Producer(string name)
        {
            Name = name;
            Id = counter;
            counter++;
        }
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string VAT { get; set; }
    }
}
