using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_WinFormsApp.Model
{
    internal class CollisionManager
    {
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            double centerX1 = rectangle1.Center.X;
            double centerY1 = rectangle1.Center.Y;
            double centerX2 = rectangle2.Center.X;
            double centerY2 = rectangle2.Center.Y;

            double width1 = rectangle1.Width / 2.0;
            double height1 = rectangle1.Length / 2.0;
            double width2 = rectangle2.Width / 2.0;
            double height2 = rectangle2.Length / 2.0;

            double dX = Math.Abs(centerX1 - centerX2);
            double dY = Math.Abs(centerY1 - centerY2);

            if (dX < (width1 + width2) && dY < (height1 + height2))
            {
                return true;  
            }
            else
            {
                return false; 
            }
        }
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double dX = ring1.Center.X - ring2.Center.X;
            double dY = ring2.Center.Y - ring1.Center.Y;

            double distance = Math.Sqrt(dX* dX + dY * dY);

            double radius = ring1.OutRadius + ring2.OutRadius;

            return (distance < radius);
        }
    }
}
