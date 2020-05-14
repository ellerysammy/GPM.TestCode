using System;
using System.Collections.Generic;
using System.Text;
using TestCode.Interfaces;
using TestCode.Interfaces.Models;

namespace TestCode.Implementations
{
    public class Cube : IFigure
    {
        private ThreeAxesOriginCoordinates Center { get; set; }
        public Cube(ThreeAxesOriginCoordinates coordinates)
        {
            this.Center = coordinates;
        }

        public int CubeSide { get; set; }

        public double CalculateArea()
        {
            double area = 6 * Math.Pow(CubeSide, 2);
            return area;
        }

        public double CalculateVolume()
        {
            double vol = Math.Pow(CubeSide, 3);
            return vol;
        }
    }
}
