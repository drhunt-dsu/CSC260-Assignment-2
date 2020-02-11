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

        private static AbstractShape[] _parameterizedShapesArray;
        private static Square _square;
        private static Rectangle _rectangle;
        private static Circle _circle;
        private static Ellipse _ellipse;
        private static Pentagon _pentagon;

        static void Main(string[] args)
        {
            InitializeShapes();
            OutputShapes(GetDefaultShapes(), "Default");
            OutputShapes(_parameterizedShapesArray, "Parameterized");
            OutputShapes(GetCopyShapes(), "Copy");
        }

        /// <summary>
        /// Initialize all parameterized shape objects
        /// </summary>
        private static void InitializeShapes()
        {
            _square = new Square(_squareSideLength);
            _rectangle = new Rectangle(_rectangleWidth, _rectangleHeight);
            _circle = new Circle(_circleRadius);
            _ellipse = new Ellipse(_elipseSemiMajorAxis, _elipseSemiMinorAxis);
            _pentagon = new Pentagon(_pentagonSideLength);

            _parameterizedShapesArray = new AbstractShape[] { _square, _rectangle, _circle, _ellipse, _pentagon };
        }

        /// <summary>
        /// Writes area & perimeters for all shapes
        /// </summary>
        private static void OutputShapes(AbstractShape[] shapes, string name)
        {
            Console.WriteLine(); //just add a line break
            OutputBoderLine('=', name);
            foreach (var shape in _parameterizedShapesArray)
            {
                OutputAreaAndPerimeter(shape);
            }
        }

        /// <summary>
        /// Get an array of AbstractShapes with copy constructors
        /// Requires parameterized array to be initialized first
        /// </summary>
        /// <returns></returns>
        private static AbstractShape[] GetCopyShapes()
        {
            return new AbstractShape[]
            {
                new Square(_square),
                new Rectangle(_rectangle),
                new Circle(_circle),
                new Ellipse(_ellipse),
                new Pentagon(_pentagon)
            };
        }

        /// <summary>
        /// Get an array of AbstractShapes with default constructors
        /// </summary>
        /// <returns></returns>
        private static AbstractShape[] GetDefaultShapes()
        {
            return new AbstractShape[]
            {
                new Square(),
                new Rectangle(),
                new Circle(),
                new Ellipse(),
                new Pentagon()
            };
        }

        /// <summary>
        /// Writes a name, area, and perimeter of a shape to the console
        /// </summary>
        /// <param name="shape"></param>
        private static void OutputAreaAndPerimeter(AbstractShape shape)
        {
            OutputBoderLine('*', shape.Name);
            var roundedPerimeter = Math.Round(shape.CalculatePerimeter(), 2);
            var roundedArea = Math.Round(shape.CalculateArea(), 2);
            Console.WriteLine($"Area:\t{roundedArea}\tPerimeter:\t{roundedPerimeter}");
        }


        /// <summary>
        /// Outputs a fixed length border string for use between shapes or sections
        /// </summary>
        /// <param name="boderChar">repeated character that makes up the border</param>
        /// <param name="name">Name to be displayed in the center of the border</param>
        private static void OutputBoderLine(char boderChar, string name)
        {
            var borderString = new string(boderChar, (38-name.Length)/2);
            Console.WriteLine($"{borderString}{name}{borderString}");
        }
    }
}

