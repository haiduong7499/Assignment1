using Assignment.BackEnd.Controllers;
using Assignment.BackEnd.Mappings;
using Assignment.Shared;
using Assignment.Test.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Assignment.Test.Controller
{
    public class ProductTestController : IClassFixture<SqliteInMemoryFixture>
    {
        private readonly SqliteInMemoryFixture _fixture;

        public ProductTestController(SqliteInMemoryFixture fixture)
        {
            _fixture = fixture;
            _fixture.CreateDatabase();
        }

        [Fact]
        public async Task GetProduct_Success()
        {
            //Arrange
            var dbContext = _fixture.Context;
            var mapper = ProductProfile.Get();
            var storage = FileStorageService.IStorageService();

            var category = UnitTest1.CategoryTest();
            await dbContext.AddAsync(category);
            await dbContext.SaveChangesAsync();

            var product = UnitTest1.TestProduct();
            await dbContext.AddAsync(product);
            await dbContext.SaveChangesAsync();

            var productController = new ProductController(dbContext, mapper, storage);
            //Act

            var result = await productController.GetProduct();
            //Assert
            var postProductResult = Assert.IsAssignableFrom<IEnumerable<ProductRespone>>(result);
            Assert.NotEmpty(postProductResult);
        }
        [Fact]
        public async Task GetProductById_Success()
        {
            //Arrange
            var dbContext = _fixture.Context;
            var mapper = ProductProfile.Get();
            var storage = FileStorageService.IStorageService();

            var category = UnitTest1.CategoryTest();
            await dbContext.AddAsync(category);
            await dbContext.SaveChangesAsync();

            var product = UnitTest1.TestProduct();
            await dbContext.AddAsync(product);
            await dbContext.SaveChangesAsync();

            var productController = new ProductController(dbContext, mapper, storage);
            //Act

            var result = await productController.GetProductByID(product.ProductId);
            //Assert
            var postProductResult = Assert.IsType<ActionResult<ProductRespone>>(result);
            var resultValue = Assert.IsType<ProductRespone>(postProductResult.Value);

            Assert.Equal("Name Product Test", resultValue.NameProduct);
            Assert.Equal("Description Test", resultValue.Description);
            Assert.Equal(1000, resultValue.Price);
            Assert.Equal(null, resultValue.ProductImg);
            Assert.Equal("CategoryId",resultValue.CategoryID);
            Assert.Equal(5, resultValue.Rate);
        }
    }
}
