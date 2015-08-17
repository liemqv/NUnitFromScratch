using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitFromScratch.Entity;

namespace NUnitFromScratch.Bussiness
{
    public class GeometryBussiness
    {
        public double Acreage(Geometry geometry)
        {
            return geometry.Acreage();
        }

        public double Perimeter(Geometry geometry)
        {
            return geometry.Perimeter();
        }
    }
}
