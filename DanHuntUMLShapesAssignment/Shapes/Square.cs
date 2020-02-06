﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DanHuntUMLShapesAssignment
{
    internal class Square : AbstractShape
    {
        private double LengthOfSide;
        private const string KEY_SIDE = "side";

        //Default constructor
        public Square()
        {
            Parameters = new Dictionary<string, double> {{KEY_SIDE, DefaultSize}};
            Initialize();
        }

        //Parameterized Constructor
        public Square(double side)
        {
            Parameters = new Dictionary<string, double> {{KEY_SIDE, side }};
            Initialize();
        }

        //Copy Constructor
        public Square(Square square)
        {
            Parameters = new Dictionary<string, double> {{ KEY_SIDE, square.LengthOfSide }};
            Initialize();
        }

        public override double CalculateArea()
        {
            return Math.Pow(LengthOfSide, 2);
        }

        public override double CalculatePerimeter()
        {
            return LengthOfSide * 4;
        }

        internal override void Initialize()
        {
            Name = "Square";
            Parameters.TryGetValue(KEY_SIDE, out LengthOfSide);
        }
    }
}