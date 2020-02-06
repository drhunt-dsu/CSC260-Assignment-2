
using System;
using NUnit.Framework;

namespace DanHuntUMLShapesAssignment.Tests
{
    class ShapeTests
    {
        public class ConstructorTests
        {
            private double _defaultSize;

            [SetUp]
            public void SetUp()
            {
                _defaultSize = AbstractShape.DefaultSize;
            }

            [Test]
            public void SquareDefaultConstructor()
            {
                var sut = new Square();

                Assert.That(sut.CalculatePerimeter(), Is.EqualTo(_defaultSize * 4));
                Assert.That(sut.CalculateArea(), Is.EqualTo(Math.Pow(_defaultSize,2)));
            }

            [Test]
            public void SquareParameterizedConstructor()
            {
                var len = 10;
                var sut = new Square(len);

                Assert.That(sut.CalculatePerimeter(), Is.EqualTo(len * 4));
                Assert.That(sut.CalculateArea(), Is.EqualTo(Math.Pow(len, 2)));
            }

            [Test]
            public void SquareCopyConstructor()
            {
                var len = 15;
                var squareToCopy = new Square(len);

                var sut = new Square(squareToCopy);

                Assert.That(sut.CalculatePerimeter(), Is.EqualTo(len * 4));
                Assert.That(sut.CalculateArea(), Is.EqualTo(Math.Pow(len, 2)));
            }
        }
    }
}
