using System.Collections.Generic;

namespace DanHuntUMLShapesAssignment
{
    public abstract class AbstractShape
    {
        /// <summary>
        /// Default size to be used for parameterless constructors
        /// </summary>
        internal const double DefaultSize = 5; 

        /// <summary>
        /// Holds key/value pairs for calculating size & area 
        /// </summary>
        internal Dictionary<string, double> Parameters;

        public string Name;

        /// <summary>
        /// Calculates area for the given shape
        /// </summary>
        /// <returns> The area of the shape</returns>
        public abstract double CalculateArea();

        /// <summary>
        /// Calculates perimeter for the given shape
        /// </summary>
        /// <returns>Perimeter of the object</returns>
        public abstract double CalculatePerimeter();

        /// <summary>
        /// Initializes all the individual parameters of the object from the parameters dictionary
        /// </summary>
        internal abstract void Initialize();
    }
}
