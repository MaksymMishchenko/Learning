using Castle.Components.DictionaryAdapter.Xml;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NuGet.Frameworks;
using SportsStoreAPP.Controllers;
using SportsStoreAPP.Interfaces;
using SportsStoreAPP.Models;

namespace SportsStoreAPP.Tests
{
    internal class AdminControllerTests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void Index_Contains_All_Products()
        {
            // Arrange
            var mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns((new Product[] {
                new Product{ ProductId = 1, Name = "P1" },
                new Product{ ProductId = 2, Name = "P2" },
                new Product{ ProductId = 3, Name = "P3" },
            }).AsQueryable());

            var target = new AdminController(mock.Object);

            // Act
            var result = GetViewModel<IEnumerable<Product>>(target.Index())?.ToArray();

            // Assert
            Assert.That(result.Length, Is.EqualTo(3));
            Assert.That(result[0].Name, Is.EqualTo("P1"));
            Assert.That(result[1].Name, Is.EqualTo("P2"));
            Assert.That(result[2].Name, Is.EqualTo("P3"));
        }

        [Test]
        public void Can_Edit_Product()
        {
            // Arrange
            var mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns((new Product[] {
                new Product { ProductId = 1, Name = "P1" },
                new Product { ProductId = 2, Name = "P2" },
                new Product { ProductId = 3, Name = "P3" },
            }).AsQueryable());

            var target = new AdminController(mock.Object);

            // Act
            var p1 = GetViewModel<Product>(target.Edit(1));
            var p2 = GetViewModel<Product>(target.Edit(2));
            var p3 = GetViewModel<Product>(target.Edit(3));

            // Assert

            Assert.That(p1.ProductId, Is.EqualTo(1));
            Assert.That(p2.ProductId, Is.EqualTo(2));
            Assert.That(p3.ProductId, Is.EqualTo(3));
        }

        [Test]
        public void Cannot_Edit_Non_Existent_Product()
        {
            // Arrange
            var mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns((new Product[] {
                new Product { ProductId = 1, Name = "P1" },
                new Product { ProductId = 2, Name = "P2" },
                new Product { ProductId = 3, Name = "P3" },
            }).AsQueryable());

            var target = new AdminController(mock.Object);

            // Act
            var product = GetViewModel<Product>(target.Edit(4));

            // Assert

            Assert.Null(product);
        }

        private T GetViewModel<T>(IActionResult result) where T : class
        {
            return (result as ViewResult)?.ViewData.Model as T;
        }
    }
}
