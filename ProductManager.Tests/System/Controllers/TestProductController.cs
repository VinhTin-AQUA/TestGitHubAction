using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using ProductManager.API.Controllers;
using ProductManager.API.Repositories;
using ProductManager.Tests.Fixtures;

namespace ProductManager.Tests.System.Controllers
{
    public class TestProductController
    {
        [Fact]
        public void Get_OnSuccess_ReturnStatusCode200()
        {
            var productRepository = new Mock<IProductRepository>();

            productRepository.Setup(repo => repo.GetAllProducts())
                .Returns(ProductFixture.GetTestUsers());

            var sut = new ProductController(productRepository.Object);

            var result = (OkObjectResult) sut.GetAllProducts();
            
            // assert --> đưa ra kết quả khẳng định mong muốn   
            result.StatusCode.Should().Be(200);
        }
    }
}