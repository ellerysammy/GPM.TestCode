using System;
using System.Collections.Generic;
using System.Text;
using TestCode.Interfaces.Models;

namespace TestCode.Interfaces
{
    public interface IFigureServices
    {
        IFigure Create(ThreeAxesOriginCoordinates coordinates);
        ThreeAxesOriginCoordinates[] CoordinatesInsideFigure();
    }
}
