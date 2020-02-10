using System;
using System.Collections.Generic;
using System.Text;

namespace DanHuntUMLShapesAssignment.Shapes
{
    class Ellipse : AbstractShape
    {
        private double SemiMajorAxis;
        private double SemiMinorAxis;

        private const string KEY_SEMI_MAJOR_AXIS = "semiMajorAxis";
        private const string KEY_SEMI_MINOR_AXIS = "semiMinorAxis";

        //Default Constructor
        public Ellipse()
        {
            Parameters = new Dictionary<string, double>
            {
                { KEY_SEMI_MAJOR_AXIS, DefaultSize },
                { KEY_SEMI_MINOR_AXIS, DefaultSize }
            };
            Initialize();
        }

        //PrameterizedConstructor
        public Ellipse(double semiMajorAxis, double semiMinorAxis)
        {
            Parameters = new Dictionary<string, double>
            {
                {KEY_SEMI_MAJOR_AXIS, semiMajorAxis },
                {KEY_SEMI_MINOR_AXIS, semiMinorAxis }
            };
            Initialize();
        }

        //Copy Constructor
        public Ellipse(Ellipse ellipseToCopy)
        {
            Parameters = new Dictionary<string, double>
            {
                {KEY_SEMI_MAJOR_AXIS, ellipseToCopy.SemiMajorAxis },
                {KEY_SEMI_MINOR_AXIS, ellipseToCopy.SemiMinorAxis }
            };
            Initialize();
        }

        public override double CalculateArea()
        {
            return Math.PI * SemiMajorAxis * SemiMinorAxis;
        }

        public override double CalculatePerimeter()
        {
            //Using method A from https://www.mathsisfun.com/geometry/ellipse-perimeter.html
            //If there's a convention to write complex math, I do not know it
            return 2 * Math.PI * Math.Sqrt(
                       (Math.Pow(SemiMajorAxis, 2) + Math.Pow(SemiMinorAxis, 2)) / 2);
        }

        internal override void Initialize()
        {
            Name = "Ellipse";
            Parameters.TryGetValue(KEY_SEMI_MAJOR_AXIS, out SemiMajorAxis);
            Parameters.TryGetValue(KEY_SEMI_MINOR_AXIS, out SemiMinorAxis);
        }
    }
}
