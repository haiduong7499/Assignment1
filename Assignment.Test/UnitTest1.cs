using System;
using Xunit;
using Assignment.BackEnd;
using Assignment.CustomerSite;
using Assignment.Shared;
using Assignment.BackEnd.Models;

namespace Assignment.Test
{
    public static class UnitTest1
    {
        public static Product TestProduct() => new Product
        {
            ProductId = "ProductId",
            NameProduct = "Name Product Test",
            Description = "Description Test",
            Price = 1000,
            ProductImg = "addimage",
            CreateDate = DateTime.Now.Date,
            UpdateDate = DateTime.Now.Date,
            CategoryID = "CategoryId",
            Rate = 5,

        };
        public static ProductRequest TestProductRequest() => new ProductRequest
        {
            NameProduct = "Name Product Test",
            Description = "Description Test",
            Price = 1000,
            ProductImg = null,
            Rate = 5,
            CategoryID = "CategoryId",
        };

        public static ProductRespone TestProductRes() => new ProductRespone
        {
            ProductId = "ProductId",
            NameProduct = "Name Product Test",
            Description = "Description Test",
            Price = 1000,
            ProductImg = "addimage",
            Rate = 5,
            CategoryID = "CategoryId",
            NameCategory = "Name Category Test"
        };

        public static Category CategoryTest() => new Category
        {
            CategoryId = "CategoryId",
            Name = "Name Test",
            Description = "Description Test",
        };

        public static Rating RatingTest() => new Rating
        {
            ID = 99,
            Comments = "Comments Test",
            PublishDate = DateTime.Now.Date,
            ProductId = "ProductId",
            Rate = 5
        };

        public static RatingRespone RatingResTest() => new RatingRespone
        {
            Comments = "Comments Test",
            PublishDate = DateTime.Now.Date,
            ProductId = "ProductId",
            Rate = 5
        };
        public static RatingRequest RatingRequestTest() => new RatingRequest
        {
            Comments = "Comments Test",
            ProductId = "ProductId",
            Rate = 5
        };




    }
}
