using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.CustomerSite.ViewComponents;
using Assignment.Shared;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Xunit;
namespace Assignment.Test.ViewComponent
{
    
    namespace AssignmentEcommerce_Test.ViewComponents
    {
        public class ProductCardTest : IClassFixture<SqliteInMemoryFixture>
        {
            private readonly SqliteInMemoryFixture _fixture;

            public ProductCardTest(SqliteInMemoryFixture fixture)
            {
                _fixture = fixture;
                _fixture.CreateDatabase();
            }

            [Fact]
            public async Task ProductCard_ShouldReturns_NotNullView()
            {
                //Arrange
                var product = UnitTest1.TestProductRes();

                var viewComponent = new ProductViewComponent();

                //Act
                var result = await viewComponent.InvokeAsync(product) as ViewViewComponentResult;

                //Assert
                Assert.NotNull(result);
            }

            [Fact]
            public async Task ProductCard_ShouldReturns_CorrectModelType()
            {
                //Arrange
                var product = UnitTest1.TestProductRes();

                var viewComponent = new ProductViewComponent();

                //Act
                var result = await viewComponent.InvokeAsync(product) as ViewViewComponentResult;

                //Assert
                Assert.IsType<ProductRespone>(result?.ViewData.Model);
            }

            [Fact]
            public async Task ProductCard_ShouldReturns_CorrectViewType()
            {
                //Arrange
                var product = UnitTest1.TestProductRes();

                var viewComponent = new ProductViewComponent();

                //Act
                var result = await viewComponent.InvokeAsync(product) as ViewViewComponentResult;

                //Assert
                Assert.IsType<ViewViewComponentResult>(result);
            }

            [Fact]
            public async Task ProductCard_ShouldReturns_CorrectViewName()
            {
                //Arrange
                var product = UnitTest1.TestProductRes();

                var viewComponent = new ProductViewComponent();

                //Act
                var result = await viewComponent.InvokeAsync(product) as ViewViewComponentResult;

                //Assert
                Assert.Equal("Default", result?.ViewName);
            }
        }
    }
}
