using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_WinFormsApp.Model
{
    internal class Ring
    {
        public Point2D Center {  get; set; }
        private double outRadius;
        private double innRadius;

        public double OutRadius
        {
            get {  return outRadius; }
            set
            {
                if ((Validator.AssertOnPositiveValue(value,nameof(outRadius))) && value > InnRadius)
                {
                    outRadius = value;
                }
                if (value <= InnRadius)
                {
                    throw new ArgumentException();
                }
            }
        }
        public double InnRadius
        {
            get { return innRadius; }
            set
            {
                if ((Validator.AssertOnPositiveValue(value, nameof(innRadius))) && value < OutRadius)
                {
                    innRadius = value;
                }
                if (value >= outRadius)
                {
                    throw new ArgumentException();
                }
            }
        }

        public double Area
        {
            get
            {
                return Math.PI * (Math.Pow(OutRadius, 2) - Math.Pow(InnRadius, 2));
            }
        }

        public Ring() { Center = new Point2D(0, 0); }

        public Ring(double centerX, double centerY, double outRadius, double innRadius)
        {
            Center = new Point2D(centerX, centerY);
            OutRadius = outRadius;
            InnRadius = innRadius;
        }

    }
}
