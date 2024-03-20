using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Moq;
using SportsStoreAPP.Components;
using SportsStoreAPP.Controllers;
using SportsStoreAPP.Interfaces;
using SportsStoreAPP.Models;
using SportsStoreAPP.Models.ViewModels;
using SportsStoreAPP.TagHelpers;
using Microsoft.AspNetCore.Routing;

namespace SportsStoreAPP.Tests
{
    internal class ProductControllerTests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void Can_Paginate()
        {
            // Arrange
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns((new Product[] {
            new Product{ ProductId = 1, Name = "P1"},
            new Product{ ProductId = 2, Name = "P2"},
            new Product{ ProductId = 3, Name = "P3"},
            new Product{ ProductId = 4, Name = "P4"},
            new Product{ ProductId = 5, Name = "P5"},
            }).AsQueryable());

            var controller = new ProductController(mock.Object);
            controller.PageSize = 3;

            // Act
            var getViewResult = controller.List(null!, 2) as ViewResult;
            var productsEnum = (ProductListViewModel?)getViewResult?.ViewData.Model;

            // Assert
            Product[]? prodArray = productsEnum?.Products?.ToArray();
            Assert.That(prodArray?.Length == 2);
            Assert.That(prodArray[0].Name, Is.EqualTo("P4"));
            Assert.That(prodArray[1].Name, Is.EqualTo("P5"));
        }

        [Test]
        public void Can_Generate_Page_Links()
        {
            var htmlHelper = new Mock<IHtmlHelper>();
            // Arrange
            PagingInfo info = new PagingInfo
            {
                CurrentPage = 2,
                TotalItems = 28,
                ItemsPerPage = 10
            };

            Func<int, string> pageUrl = x => $"/Page/{x}";

            // Act
            var result = PagingHelpers.PagingLinks(htmlHelper.Object, info, pageUrl);
            var writer = new StringWriter();
            result.WriteTo(writer, System.Text.Encodings.Web.HtmlEncoder.Default);
            var generatedHtml = writer.ToString();

            // Assert

            var expectedHtml = "<div><a href=\"/Page/1\">1</a><a class=\"selected\" href=\"/Page/2\">2</a><a href=\"/Page/3\">3</a></div>";

            Assert.That(generatedHtml, Is.Not.Null);
            //Assert.AreEqual(expectedHtml, generatedHtml);
            Assert.That(expectedHtml, Is.EqualTo(generatedHtml));

        }

        [Test]
        public void Can_Send_Pagination_View_Model()
        {
            var mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns((new Product[] {
                new Product{ProductId = 1, Name = "P1"},
                new Product{ProductId = 2, Name = "P2"},
                new Product{ProductId = 3, Name = "P3"},
                new Product{ProductId = 4, Name = "P4"},
                new Product{ProductId = 5, Name = "P5"}
            }).AsQueryable());

            // Arrange
            var controller = new ProductController(mock.Object) { PageSize = 3 };

            // Act
            var result = controller.List(null!, 2) as ViewResult;
            var data = (ProductListViewModel?)result?.ViewData.Model;

            // Assert
            var pageInfo = data?.PagingInfo;
            Assert.That(pageInfo, Is.Not.Null);
            Assert.That(pageInfo?.CurrentPage, Is.EqualTo(2));
            Assert.That(pageInfo?.ItemsPerPage, Is.EqualTo(3));
            Assert.That(pageInfo?.TotalItems, Is.EqualTo(5));
            Assert.That(pageInfo?.TotalPages, Is.EqualTo(2));
        }

        [Test]
        public void Can_Filter_Products()
        {
            var mock = new Mock<IProductRepository>();
            mock.Setup(p => p.Products).Returns((new Product[] {
            new Product{ ProductId = 1, Name = "P1", Category = "Cat1" },
            new Product{ ProductId = 2, Name = "P2", Category = "Cat2" },
            new Product{ ProductId = 3, Name = "P3", Category = "Cat1" },
            new Product{ ProductId = 4, Name = "P4", Category = "Cat2" },
            new Product{ ProductId = 5, Name = "P5", Category = "Cat3" },
            }).AsQueryable());

            // Arrange
            var controller = new ProductController(mock.Object);
            controller.PageSize = 3;

            // Act
            var result = controller.List("Cat2", 1) as ViewResult;
            var resultEnum = ((ProductListViewModel?)result?.ViewData.Model)?.Products?.ToArray();

            // Assert
            Assert.That(resultEnum?.Length, Is.EqualTo(2));
            Assert.That(resultEnum[0].Name == "P2", Is.EqualTo(resultEnum[0].Category == "Cat2"));
            Assert.That(resultEnum[1].Name == "P4", Is.EqualTo(resultEnum[1].Category == "Cat2"));
        }

        [Test]
        public void Can_Select_Categories()
        {
            // Arrange
            var mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns((new Product[] {
                new Product{ ProductId = 1, Name = "P1", Category = "Apples"},
                new Product{ ProductId = 2, Name = "P2", Category = "Apples"},
                new Product{ ProductId = 3, Name = "P3", Category = "Plums"},
                new Product{ ProductId = 4, Name = "P4", Category = "Oranges"},
            }).AsQueryable());

            // Act
            var target = new NavigationMenuViewComponent(mock.Object);
            // можна так, це аналог двох речень нижче
            //var results = ((IEnumerable<string>)(target?.Invoke(null) as ViewViewComponentResult).ViewData.Model).ToArray();
            var result = target.Invoke() as ViewViewComponentResult;
            var categories = (result?.ViewData?.Model as IEnumerable<string>)?.ToArray();

            // Assert            
            Assert.That(categories, Is.Not.Null);
            Assert.That(result?.ViewName, Is.EqualTo("_Menu"));
            Assert.That(categories?.Count(), Is.EqualTo(3));
            Assert.That(categories[0], Is.EqualTo("Apples"));
            Assert.That(categories[1], Is.EqualTo("Oranges"));
            Assert.That(categories[2], Is.EqualTo("Plums"));
        }

        [Test]
        public void Indicates_Selected_Category()
        {
            // Arrange
            string categoryToSelect = "Apples";
            var mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns((new Product[] {
            new Product{ ProductId = 1, Name = "P1", Category="Apples" },
            new Product{ ProductId = 4, Name = "P2", Category="Oranges" }
            }).AsQueryable());

            var target = new NavigationMenuViewComponent(mock.Object);

            target.ViewComponentContext = new ViewComponentContext
            {
                ViewContext = new ViewContext
                { RouteData = new RouteData() }
            };

            // Act
            target.RouteData.Values["category"] = categoryToSelect;
            var result = (target.Invoke() as ViewViewComponentResult)?.ViewData?["SelectedCategory"];

            // Assert
            Assert.That(result, Is.EqualTo(categoryToSelect));
        }

        [Test]
        public void Generate_Category_Specific_Product_Count()
        {
            // Arrange
            var mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns((new Product[] {
                new Product{ ProductId = 1, Name = "P1", Category = "Cat1"},
                new Product{ ProductId = 2, Name = "P2", Category = "Cat2"},
                new Product{ ProductId = 3, Name = "P3", Category = "Cat1"},
                new Product{ ProductId = 4, Name = "P4", Category = "Cat2"},
                new Product{ ProductId = 5, Name = "P5", Category = "Cat3"},
            }).AsQueryable);

            var target = new ProductController(mock.Object);
            target.PageSize = 3;
            Func<ViewResult, ProductListViewModel> GetModel = result => (ProductListViewModel)result?.ViewData?.Model!;

            // Act
            int? res1 = GetModel((ViewResult)target.List("Cat1"))?.PagingInfo?.TotalItems;
            int? res2 = GetModel((ViewResult)target.List("Cat2"))?.PagingInfo?.TotalItems;
            int? res3 = GetModel((ViewResult)target.List("Cat3"))?.PagingInfo?.TotalItems;
            int? resAll = GetModel((ViewResult)target.List(null!))?.PagingInfo?.TotalItems;

            // Assert
            Assert.That(res1, Is.EqualTo(2));
            Assert.That(res2, Is.EqualTo(2));
            Assert.That(res3, Is.EqualTo(1));
            Assert.That(resAll, Is.EqualTo(5));
        }
    }
}
