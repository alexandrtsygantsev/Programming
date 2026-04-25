using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_WinFormsApp.Model
{
    internal class AppColors
    {
        // Цвета для валидации
        public static readonly Color ValidColor = Color.White;
        public static readonly Color InvalidColor = Color.LightPink;

        // Цвета для пересечения прямоугольников
        public static readonly Color CollisionColor = Color.FromArgb(127, 255, 127, 127);
        public static readonly Color NoCollisionColor = Color.LightGreen;

        // Цвета для времён года
        public static readonly Color SpringColor = Color.LightGreen;
        public static readonly Color SummerColor = Color.Yellow;
        public static readonly Color AutumnColor = Color.Orange;
        public static readonly Color WinterColor = Color.LightBlue;
    }
}
