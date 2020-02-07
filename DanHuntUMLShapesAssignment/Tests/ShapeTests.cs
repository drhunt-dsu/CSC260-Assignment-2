﻿
using System;
using DanHuntUMLShapesAssignment.Shapes;
using NUnit.Framework;

namespace DanHuntUMLShapesAssignment.Tests
{
    class ShapeTests
    {
        public class ConstructorTests
        {
            private double _defaultSize;
            private AbstractShape sut;

            [SetUp]
            public void SetUp()
            {
                _defaultSize = AbstractShape.DefaultSize;
            }

            #region Square
            [Test]
            public void SquareDefaultConstructor()
            {
                sut = new Square();

                Assert.That(sut.CalculatePerimeter(), Is.EqualTo(_defaultSize * 4));
                Assert.That(sut.CalculateArea(), Is.EqualTo(Math.Pow(_defaultSize,2)));
            }

            [Test]
            public void SquareParameterizedConstructor()
            {
                var len = 10;
                sut = new Square(len);

                Assert.That(sut.CalculatePerimeter(), Is.EqualTo(len * 4));
                Assert.That(sut.CalculateArea(), Is.EqualTo(Math.Pow(len, 2)));
            }

            [Test]
            public void SquareCopyConstructor()
            {
                var len = 15;
                var squareToCopy = new Square(len);

                sut = new Square(squareToCopy);
                
                Assert.That(sut.CalculateArea(), Is.EqualTo(squareToCopy.CalculateArea()));
                Assert.That(sut.CalculatePerimeter(), Is.EqualTo(squareToCopy.CalculatePerimeter()));
            }
            #endregion
            #region Rectangle
            [Test]
            public void RectangleDefaultConstructor()
            {
                var sut = new Rectangle();

                Assert.That(sut.CalculatePerimeter(), Is.EqualTo(_defaultSize * 2 + _defaultSize * 4));
                Assert.That(sut.CalculateArea(), Is.EqualTo(_defaultSize * (_defaultSize * 2)));
            }

            [Test]
            public void RectangleParameterizedConstructor()
            {
                var width = 10;
                var height = 20;
                sut = new Rectangle(width, height);

                Assert.That(sut.CalculatePerimeter(), Is.EqualTo(2 * width + 2 * height));
                Assert.That(sut.CalculateArea(), Is.EqualTo(width * height));
            }

            [Test]
            public void RectangleCopyConstructor()
            {
                var width = 5;
                var height = 15;
                var rectangleToCopy = new Rectangle(width, height);

                sut = new Rectangle(rectangleToCopy);

                Assert.That(sut.CalculateArea(), Is.EqualTo(rectangleToCopy.CalculateArea()));
                Assert.That(sut.CalculatePerimeter(), Is.EqualTo(rectangleToCopy.CalculatePerimeter()));
            }
            #endregion
        }
    }
}
