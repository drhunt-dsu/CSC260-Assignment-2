using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework.Constraints;

namespace DanHuntUMLShapesAssignment.Shapes
{
    class Pentagon : AbstractShape
    {
        private double LengthOfSide;
        private const string KEY_SIDE = "side";

        //Default Constructor
        public Pentagon()
        {
            Parameters = new Dictionary<string, double>{{KEY_SIDE, DefaultSize}};
            Initialize();
        }

        //Parameterized Constructor
        public Pentagon(double side)
        {
            Parameters = new Dictionary<string, double> { { KEY_SIDE, side } };
            Initialize();
        }
        //Copy Constructor
        public Pentagon(Pentagon pentagonToCopy)
        {
            Parameters = new Dictionary<string, double> { { KEY_SIDE, pentagonToCopy.LengthOfSide } };
            Initialize();
        }

        public override double CalculateArea()
        {
            //Formula from https://www.google.com/search?q=pentagon+area
            var innerRoot = 5 * (5 + 2 * Math.Sqrt(5));
            return 0.25 * Math.Sqrt(innerRoot) * Math.Pow(LengthOfSide, 2);
        }

        public override double CalculatePerimeter()
        {
            return 5 * LengthOfSide;
        }

        internal override void Initialize()
        {
            Name = "Pentagon";
            Parameters.TryGetValue(KEY_SIDE, out LengthOfSide);
        }
    }
}
