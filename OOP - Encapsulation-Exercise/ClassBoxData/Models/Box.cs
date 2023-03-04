using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBoxData.Models
{
    public class Box
    {
        private const string PropertyValueExeptionMessage =
            "{0} cannot be zero or negative.";

        private double lenght;
        private double width;
        private double height;

        public Box(double lenght, double width, double height)
        {
            Length = lenght;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get 
            { 
                return lenght; 
            }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(PropertyValueExeptionMessage, nameof(Length)));
                }

                lenght = value;
            }
        }

        public double Width
        {
            get 
            { 
                return width; 
            }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(PropertyValueExeptionMessage, nameof(Width)));
                }

                width = value;
            }
        }

        public double Height
        {
            get 
            { 
                return height;
            }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(PropertyValueExeptionMessage, nameof(Height)));
                }

                height = value;
            }
        }

        public double SurfaceArea() => 2 * Length * Width + LateralSurfaceArea();

        public double LateralSurfaceArea() => 2 * Length * Height + 2 * Width * Height;

        public double Volume() => Length * Width * Height;
    }
}
