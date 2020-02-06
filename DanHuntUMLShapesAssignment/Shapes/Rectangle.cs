using System;
using System.Collections.Generic;
using System.Text;

namespace DanHuntUMLShapesAssignment.Shapes
{
    internal class Rectangle : Square
    {
        //Inheriting from Square cause all rectangles are squares. In theory this is good for future use right?

        private double Width;

        private double Height;

        private const string KEY_WIDTH = "width";
        private const string KEY_HEIGHT = "height";

        //Default Constructor
        public Rectangle()
        {
            Parameters = new Dictionary<string, double>
            {
                {KEY_WIDTH, 2 * DefaultSize},
                {KEY_HEIGHT, DefaultSize}
            };
            Initialize();
        }

        //Parameterized Constructor
        public Rectangle(double width, double height)
        {
            Parameters = new Dictionary<string, double>
            {
                { KEY_WIDTH, width },
                { KEY_HEIGHT, height }
            };
            Initialize();
        }

        //Copy Constructor
        public Rectangle(Rectangle rectangleToCopy)
        {
            Parameters = new Dictionary<string, double>
            {
                { KEY_WIDTH, rectangleToCopy.Width },
                { KEY_HEIGHT, rectangleToCopy.Height }
            };
            Initialize();
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Height + 2 * Width;
        }

        internal override void Initialize()
        {
            Name = "Rectangle";
            Parameters.TryGetValue(KEY_WIDTH, out Width);
            Parameters.TryGetValue(KEY_HEIGHT, out Height);
        }

    }
}
