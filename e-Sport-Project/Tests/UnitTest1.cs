using e_Sport.Domain.ProductAggregate;
using e_Sport.Infrastructure.Repositories;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class Tests
    {
        ProductMSSQL rep;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ProductGetAllTest()
        {
            rep = new ProductMSSQL();
            IEnumerable<Product> prs = rep.GetAll();

            foreach(Product p in prs)
            {
                Console.WriteLine($"Id :{p.Id}, Name: {p.Name}, Producer name: {p.Producer?.Name}, Comments: {p.Comments?.FirstOrDefault()?.Text}");
            }
            Assert.IsTrue(prs.Count() > 0);
        }

        [Test]
        public void ProductFindTest()
        {
            rep = new ProductMSSQL();
            Product p = rep.Find(1);
            Console.WriteLine($"Id :{p.Id}, Name: {p.Name}, Producer name: {p.Producer?.Name}, Comments: {p.Comments?.FirstOrDefault()?.Text}");

            Assert.IsNotNull(p);
        }

        [Test]
        public void ProductAddTest()
        {
            rep = new ProductMSSQL();
            Product newInstance = new Product("Highlettes High Parallel Letes", 203.55m);

            rep.Add(newInstance);

            Product finded = rep.Find(newInstance.Id);

            Console.WriteLine($"Id :{newInstance.Id}, Name: {newInstance.Name}, Producer name: {newInstance.Producer?.Name}, Comments: {newInstance.Comments?.FirstOrDefault()?.Text}");

            Assert.IsNotNull(finded);

            rep.Remove(newInstance.Id);
        }

        [Test]
        public void ProductDeleteTest()
        {
            rep = new ProductMSSQL();
            Product newInstance = new Product("Highlettes High Parallel Letes", 203.55m);

            rep.Add(newInstance);

            Assert.IsTrue(rep.Remove(newInstance.Id));
        }

    }
}