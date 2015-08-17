using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitFromScratch.Entity
{
    public class Square : Geometry
    {
        public double width { get; set; }
        public double Acreage()
        {
            return width * width;
        }

        public double Perimeter()
        {
            return width * 4;
        }
    }
}
