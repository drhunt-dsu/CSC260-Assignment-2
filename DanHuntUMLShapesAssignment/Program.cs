//Dan Hunt
//daniel.hunt@trojans.dsu.edu
//CSC260 Assignment 2 - Shapes from UML Diagram

using System;
using System.Net;
using DanHuntUMLShapesAssignment.Shapes;

namespace DanHuntUMLShapesAssignment
{
    class Program
    {
        private static int _squareSideLength = 10;
        private static int _rectangleWidth = 10;
        private static int _rectangleHeight = 7;
        private static int _circleRadius = 3;
        private static int _elipseSemiMajorAxis = 13;
        private static int _elipseSemiMinorAxis = 8;
        private static int _pentagonSideLength = 23;

        private static AbstractShape[] _shapes;
        private static Square _square;
        private static Rectangle _rectangle;
        private static Circle _circle;
        private static Ellipse _ellipse;
        private static Pentagon _pentagon;

        static void Main(string[] args)
        {
            InitializeShapes();
            OutputAllShapeInfo();
        }

        /// <summary>
        /// Initialize all shape objects and the shapes array
        /// </summary>
        private static void InitializeShapes()
        {
            _square = new Square(_squareSideLength);
            _rectangle = new Rectangle(_rectangleWidth, _rectangleHeight);
            _circle = new Circle(_circleRadius);
            _ellipse = new Ellipse(_elipseSemiMajorAxis, _elipseSemiMinorAxis);
            _pentagon = new Pentagon(_pentagonSideLength);

            _shapes = new AbstractShape[] {_square, _rectangle,_circle, _ellipse, _pentagon};
        }

        /// <summary>
        /// Writes area & perimeters for all shapes
        /// </summary>
        private static void OutputAllShapeInfo()
        {
            foreach (var shape in _shapes)
            {
                OutputAreaAndPerimeter(shape);
            }
        }

        /// <summary>
        /// Writes a name, area, and perimeter of a shape to the console
        /// </summary>
        /// <param name="shape"></param>
        private static void OutputAreaAndPerimeter(AbstractShape shape)
        {
            var asteriskString = new string('*', (38-shape.Name.Length)/2); // I hate using magic numbers but not finding a great way to get this number dynamically
            Console.WriteLine($"{asteriskString}{shape.Name}{asteriskString}");
            Console.WriteLine($"Area:\t{Math.Round(shape.CalculateArea(), 2)}\tPerimeter:\t{Math.Round(shape.CalculatePerimeter(),2)}");
        }
    }
}

