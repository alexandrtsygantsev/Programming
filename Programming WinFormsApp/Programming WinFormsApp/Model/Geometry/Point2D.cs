using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_WinFormsApp.Model.Geometry
{
    internal class Point2D
    {
        private double x;
        private double y;

        public double X
        {
            get { return x; }
            private set //immutable
            {
                if (Validator.AssertOnPositiveValue(value, nameof(X)))
                {
                    x = value;
                }
            }
        }
        public double Y
        {
            get { return y; }
            private set //immutable
            {
                if (Validator.AssertOnPositiveValue(value, nameof(Y)))
                {
                    y = value;
                }
            }
        }
        public Point2D(double x, double y) {  X = x; Y = y; }
    }
}
