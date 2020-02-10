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
            #region Circle
            [Test]
            public void CircleDefaultConstructor()
            {
                var sut = new Circle();

                Assert.That(sut.CalculatePerimeter(), Is.EqualTo(2 * Math.PI * _defaultSize));
                Assert.That(sut.CalculateArea(), Is.EqualTo(Math.PI * Math.Pow(_defaultSize, 2)));
            }

            [Test]
            public void CircleParameterizedConstructor()
            {
                var radius = 10;
                sut = new Circle(radius);

                Assert.That(sut.CalculatePerimeter(), Is.EqualTo(2 * Math.PI * radius));
                Assert.That(sut.CalculateArea(), Is.EqualTo(Math.PI * Math.Pow(radius, 2)));
            }

            [Test]
            public void CircleCopyConstructor()
            {
                var radius = 5;
                var circleToCopy = new Circle(radius);

                sut = new Circle(circleToCopy);

                Assert.That(sut.CalculateArea(), Is.EqualTo(circleToCopy.CalculateArea()));
                Assert.That(sut.CalculatePerimeter(), Is.EqualTo(circleToCopy.CalculatePerimeter()));
            }
            #endregion
            #region Ellipse
            [Test]
            public void EllipseDefaultConstructor()
            {
                var sut = new Ellipse();

                Assert.That(sut.CalculatePerimeter(), Is.EqualTo(2 * Math.PI * 
                                                                      Math.Sqrt(
                                                                          (Math.Pow(_defaultSize, 2) + Math.Pow(_defaultSize, 2)) / 2)));
                Assert.That(sut.CalculateArea(), Is.EqualTo(Math.PI * _defaultSize * _defaultSize));
            }

            [Test]
            public void EllipseParameterizedConstructor()
            {
                var semiMajorAxis = 10;
                var semiMinorAxis = 20;
                sut = new Ellipse(semiMajorAxis, semiMinorAxis);

                Assert.That(sut.CalculatePerimeter(), Is.EqualTo(2 * Math.PI *
                                                                 Math.Sqrt(
                                                                     (Math.Pow(semiMajorAxis, 2) + Math.Pow(semiMinorAxis, 2)) / 2)));
                Assert.That(sut.CalculateArea(), Is.EqualTo(Math.PI * semiMajorAxis * semiMinorAxis));
            }

            [Test]
            public void EllipseCopyConstructor()
            {
                var semiMajorAxis = 5;
                var semiMinorAxis = 15;
                var EllipseToCopy = new Ellipse(semiMajorAxis, semiMinorAxis);

                sut = new Ellipse(EllipseToCopy);

                Assert.That(sut.CalculateArea(), Is.EqualTo(EllipseToCopy.CalculateArea()));
                Assert.That(sut.CalculatePerimeter(), Is.EqualTo(EllipseToCopy.CalculatePerimeter()));
            }
            #endregion
            #region Pentagon


            #endregion

        }
    }
}
