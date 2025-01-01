using Microsoft.AspNetCore.Mvc;
using Moq;
using SportsStoreAPP.Controllers;
using SportsStoreAPP.Interfaces;
using SportsStoreAPP.Models;
using SportsStoreAPP.Models.ViewModels;

namespace SportsStoreAPP.Tests
{
    internal class CartTests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void Can_Add_New_Lines()
        {
            // Arrange
            var product1 = new Product { ProductId = 1, Name = "P1" };
            var product2 = new Product { ProductId = 2, Name = "P2" };
            var target = new Cart();

            // Act
            target.AddItem(product1, 1);
            target.AddItem(product2, 1);
            CartLine[] results = target.Lines.ToArray();

            // Assert
            Assert.That(results.Length, Is.EqualTo(2));
            Assert.That(product1, Is.EqualTo(results[0].Product));
            Assert.That(product2, Is.EqualTo(results[1].Product));
        }

        [Test]
        public void Can_Add_Quantity_For_Existing_Lines()
        {
            // Arrange
            var product1 = new Product { ProductId = 1, Name = "P1" };
            var product2 = new Product { ProductId = 2, Name = "P2" };

            var target = new Cart();

            // Act
            target.AddItem(product1, 1);
            target.AddItem(product2, 1);
            target.AddItem(product1, 10);
            CartLine[] results = target.Lines.OrderBy(c => c.Product?.ProductId).ToArray();

            // Assert
            Assert.That(results.Length, Is.EqualTo(2));
            Assert.That(results[0].Quantity, Is.EqualTo(11));
            Assert.That(results[1].Quantity, Is.EqualTo(1));
        }

        [Test]
        public void Can_Remove_Line()
        {
            // Arrange
            var product1 = new Product { ProductId = 1, Name = "P1" };
            var product2 = new Product { ProductId = 2, Name = "P2" };
            var product3 = new Product { ProductId = 3, Name = "P3" };

            var target = new Cart();

            target.AddItem(product1, 1);
            target.AddItem(product2, 3);
            target.AddItem(product3, 5);
            target.AddItem(product2, 1);

            // Act
            target.RemoveLine(product2);

            // Assert
            Assert.That(target.Lines.Where(c => c.Product == product2).Count(), Is.EqualTo(0));
            Assert.That(target.Lines.Count, Is.EqualTo(2));
        }

        [Test]
        public void Calculate_Cart_Total()
        {
            // Arrange
            var product1 = new Product { ProductId = 1, Name = "P1", Price = 100M };
            var product2 = new Product { ProductId = 2, Name = "P2", Price = 50M };

            var target = new Cart();

            target.AddItem(product1, 1);
            target.AddItem(product2, 1);
            target.AddItem(product1, 3);

            // Act
            decimal result = target.ComputeTotalValue();

            // Assert
            Assert.That(result, Is.EqualTo(450M));
        }

        [Test]
        public void Can_Clear_Contents()
        {
            // Arrange
            var product1 = new Product { ProductId = 1, Name = "P1", Price = 100M };
            var product2 = new Product { ProductId = 2, Name = "P2", Price = 50M };

            var target = new Cart();

            target.AddItem(product1, 1);
            target.AddItem(product2, 1);

            // Act
            target.Clear();

            // Assert
            Assert.That(target.Lines.Count(), Is.EqualTo(0));
        }
    }
}
