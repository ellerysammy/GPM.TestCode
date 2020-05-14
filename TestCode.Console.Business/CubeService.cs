using System;
using TestCode.Implementations;
using TestCode.Interfaces;
using TestCode.Interfaces.Models;

namespace TestCode.Console.Business
{
    public class CubeService : IFigureServices
    {
        public IFigure Create(ThreeAxesOriginCoordinates coordinates)
        {
            Cube cube = new Cube(coordinates);
            cube.CubeSide = (new Random()).Next(100); //Dummy code
            return cube;
        }

        public ThreeAxesOriginCoordinates[] CoordinatesInsideFigure()
        {
            //Dummy code
            return new ThreeAxesOriginCoordinates[2];
        }
    }
}
