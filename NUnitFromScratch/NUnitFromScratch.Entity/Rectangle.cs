using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitFromScratch.Entity
{
    public class Rectangle : Geometry
    {
        public double width { get; set; }
        public double height { get; set; }
        public double Acreage()
        {
            return width * height;
        }

        public double Perimeter()
        {
            return (width + height) * 2;
        }
    }
}
