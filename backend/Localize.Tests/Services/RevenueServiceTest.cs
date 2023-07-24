using Localize.Domain.ExternalServices;
using Localize.Domain.Interfaces.ExternalServices;
using Localize.Domain.Interfaces.Repositories;
using Localize.Domain.Interfaces.Services;
using Localize.Domain.Models;
using Localize.Domain.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace Localize.Tests.Services
{
    public class RevenueServiceTest
    {
        private readonly IRevenueService _revenueService;
        private readonly Mock<IRevenueRepository> _repository;

        public RevenueServiceTest()
        {
            _repository = new Mock<IRevenueRepository>();
            _revenueService = new RevenueService(_repository.Object);
        }

        [Fact]
        public async Task DeveBuscarRevenuePorCnpj()
        {
            _repository.Setup(x => x.GetRevenueDataByCnpj("1111111111111"))
                .ReturnsAsync(new Revenue("11111111111111", "JSON"));

            var revenue = await _revenueService.GetRevenueDataByCnpj("1111111111111");

            Assert.NotNull(revenue);
            Assert.IsType<Revenue>(revenue);
        }

        [Fact]
        public async Task DeveSalvarRevenue()
        {
            _repository.Setup(x => x.SaveRevenueData(It.IsAny<Revenue>()));

            await _revenueService.SaveRevenueData(It.IsAny<Revenue>());

            _repository.Verify(x => x.SaveRevenueData(It.IsAny<Revenue>()), Times.Once);
        }
    }
}
