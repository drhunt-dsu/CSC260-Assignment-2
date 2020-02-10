using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace DanHuntUMLShapesAssignment
{
    internal class Circle : AbstractShape
    {
        private double Radius;
        private const string KEY_RADIUS = "radius";

        //Default constructor
        public Circle()
        {
            Parameters = new Dictionary<string, double> {{KEY_RADIUS, DefaultSize}};
            Initialize();
        }

        //Parameterized Constructor
        public Circle(double side)
        {
            Parameters = new Dictionary<string, double> {{KEY_RADIUS, side }};
            Initialize();
        }

        //Copy Constructor
        public Circle(Circle circle)
        {
            Parameters = new Dictionary<string, double> {{ KEY_RADIUS, circle.Radius }};
            Initialize();
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        internal override void Initialize()
        {
            Name = "Circle";
            Parameters.TryGetValue(KEY_RADIUS, out Radius);
        }
    }
}
