using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Converters;

namespace _222_Darinskaya_Basmanov
{
    internal class Helper
    {
        static public double sh(double x)
        {
            return (Math.Pow(Math.E, x) - Math.Pow(Math.E, -x)) / 2.0;
        }

        static public double Function(double f, double x, double y)
        {
            if (x * y > 0)
            {
                return Math.Pow((f + y), 2) - Math.Sqrt(f * y);
            }
            else if (x * y < 0)
            {
                return Math.Pow((f + y), 2) + Math.Sqrt(Math.Abs(f * y));
            }
            else if (x * y == 0)
            {
                return Math.Pow((f + y), 2) + 1;
            }
            return -1;
        }
    }
}
