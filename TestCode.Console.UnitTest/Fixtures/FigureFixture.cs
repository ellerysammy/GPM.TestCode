using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using TestCode.Console.Business;
using TestCode.Interfaces;
using TestCode.Interfaces.Models;

namespace TestCode.Console.UnitTest.Fixtures
{
    public class FigureFixture : IDisposable
    {

        public ServiceProvider serviceProvider;

        //Dummy code
        public ThreeAxesOriginCoordinates Coordinates{
            get
            {
                return new ThreeAxesOriginCoordinates {
                    X = (new Random()).Next(100),
                    Y = (new Random()).Next(100),
                    Z = (new Random()).Next(100)
                };
            }
        }
        public FigureFixture()
        {
            IServiceCollection serviceCollection = InitializeServiceCollection();
            AddInjectionBusiness(serviceCollection);
            serviceProvider = serviceCollection.BuildServiceProvider();
        }

        private void AddInjectionBusiness(IServiceCollection serviceCollection)
        {
            serviceCollection
            .AddTransient<IFigureServices, CubeService>();


        }

        private IServiceCollection InitializeServiceCollection()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            return serviceCollection;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
