using Microsoft.Extensions.DependencyInjection;
using TestCode.Console.UnitTest.Fixtures;
using TestCode.Interfaces;
using TestCode.Interfaces.Models;
using Xunit;

namespace TestCode.Console.UnitTest
{
    public class CubeTest : IClassFixture<FigureFixture>
    {
        private readonly IFigureServices figureServices;
        private readonly ServiceProvider _serviceProvider;
        private readonly ThreeAxesOriginCoordinates coordinates;

        public CubeTest(FigureFixture idFixture)
        {
            _serviceProvider = idFixture.serviceProvider;

            figureServices = _serviceProvider.GetService<IFigureServices>();
            coordinates = idFixture.Coordinates;
        }

        [Fact]
        public void CreateCubeTest()
        {
            var cube = figureServices.Create(coordinates);

            Assert.NotNull(cube);
        }

        [Fact]
        public void CalculateAreaTest()
        {
            var cube = figureServices.Create(coordinates);
            var area = cube.CalculateArea();
            Assert.True(area > 0);
        }

        [Fact]
        public void CalculateVolumeTest()
        {
            var cube = figureServices.Create(coordinates);
            var volume = cube.CalculateVolume();
            Assert.True(volume > 0);
        }

        [Fact]
        public void CoordinatesInsideFigureTest()
        {
            var coordinates = figureServices.CoordinatesInsideFigure();
            Assert.NotEmpty(coordinates);
        }
    }
}
