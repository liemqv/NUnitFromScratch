using System;
using NUnit.Framework;
using NSubstitute;
using NUnitFromScratch.Entity;
using NUnitFromScratch.Bussiness;

namespace NUnitFromScratch.UnitTest
{
    [TestFixture]
    public class Geometry_Bussiness_Test
    {
        [TestCase]
        public void Geometry_Bussicess_Test_Acreage()
        {
            var geometry = Substitute.For<GeometryBussiness>();
            Rectangle rec = new Rectangle();
            rec.width = 6;
            rec.height = 2;
            var arc = geometry.Acreage(rec);
            Assert.AreEqual(12, arc);

            Square squ = new Square();
            squ.width = 4;
            arc = geometry.Acreage(squ);
            Assert.AreEqual(16, arc);
        }

        [TestCase]
        public void Geometry_Bussicess_Test_Perimeter()
        {
            var geometry = Substitute.For<GeometryBussiness>();
            Rectangle rec = new Rectangle();
            rec.width = 6;
            rec.height = 2;
            var per = geometry.Perimeter(rec);
            Assert.AreEqual(16, per);

            Square squ = new Square();
            squ.width = 4;
            per = geometry.Perimeter(squ);
            Assert.AreEqual(16, per);
        }
    }
}
