using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_1._3_LODU
{
    class Complex
    {
        public double x { get; set; } // вещественная часть
        public double y { get; set; } // мнимая часть

        // конструктор к.ч.
        public Complex (double a, double b)
        {
            x = a; y = b;
        }

        // сложение к.ч.
        public static Complex operator + (Complex a, Complex b)
        {
            return new Complex (a.x + b.x, a.y + b.y);
        }

        // вычитание к.ч.
        public static Complex operator - (Complex a, Complex b)
        {
            return new Complex(a.x - b.x, a.y - b.y);
        }

        // умножение на -1
        public static Complex operator -(Complex a)
        {
            return (new Complex(-1.0, 0.0) * a);
        }

        // умножение к.ч.
        public static Complex operator * (Complex a, Complex b)
        {
            double k = (a.x * b.x) - (a.y * b.y);
            k = Math.Round(k, 3);
            double j = (a.x * b.y) + (b.x * a.y);
            j = Math.Round(j, 3);


            return new Complex(k, j);
        }
        
        // умножение на действительного числа на к.ч.
        public static Complex operator * (double b, Complex a)
        {
            
            return ((new Complex(b, 0.0)) * a);
        }

        // деление к.ч.
        public static Complex operator / (Complex a, Complex b)
        {
            double k = ((a.x * b.x) + (a.y * b.y)) / (b.x * b.x + b.y * b.y);
            k = Math.Round(k, 3);
            double j = ((a.y * b.x) - (a.x * b.y)) / (b.x * b.x + b.y * b.y);
            j = Math.Round(j, 3);


            return new Complex(k, j);
        }

        public static Complex operator / (Complex a, double b)
        {
            return (a / (new Complex(b, 0.0)) );
        }


        /// <summary>
        /// Корень n-ой степени комплексного числа
        /// </summary>
        /// <param name="a">комплексное число</param>
        /// <param name="n">степень корня</param>
        /// <returns></returns>
        public static Complex Sqrt(Complex a, double n)
        {
            double r = Math.Sqrt(  Math.Abs( (a.x * a.x) + (a.y * a.y) )  );

            double arg;

            if (a.x < 0)
            {
                if (a.y<0)
                {
                    arg = Math.PI + Math.Atan(Math.Abs(a.y) / Math.Abs(a.x));
                }
                else
                {
                    arg = Math.PI - Math.Atan(a.y / Math.Abs(a.x));
                }
                
            }
            else if (a.x > 0)
            {
                if (a.y < 0)
                {
                    arg = 2.0 * Math.PI - Math.Atan(Math.Abs(a.y) / a.x);
                }
                else
                {
                    arg = Math.Atan(a.y / a.x);
                }
                 
            }
            else
            {
                if (a.y < 0)
                {
                    arg = (3.0 * Math.PI) / 2.0;
                }
                else if (a.y > 0)
                {
                    arg = Math.PI / 2.0;
                }
                else
                {
                    arg = 0;
                }

            }

            // C# выдаёт длинное число, если Cos(n) или Sin(n) == 0
            // Поэтому можно прибегнуть к некоторым преобразованиям

            double k_Cos = arg / n; // возможный косинус
            double j_Sin = arg / n; // возможный синус

            

            if ((k_Cos % ((Math.PI / 2.0) + Math.PI) == 0) && (k_Cos != 0)) // (Cos(n) == 0) И (n != 0)
            {
                k_Cos = 0; // если верно, то Cos(n) == 0
            }
            else // иначе вычисляем обычный Cos(n)
            {
                k_Cos = Math.Cos(k_Cos); // собственно Косинус
                k_Cos = Math.Round(k_Cos, 3); // округление до 3-х знаков после запятой
            }


            if (j_Sin % Math.PI == 0) // Sin(n) == 0
            {
                j_Sin = 0; // если верно, то Sin(n) == 0
            }
            else // иначе вычисляем обычный Sin(n)
            {
                j_Sin = Math.Sin(j_Sin); // собственно Синус
                j_Sin = Math.Round(j_Sin, 3); // округление до 3-х знаков после запятой
            }

            Complex p = new Complex(Math.Pow(r, 1.0 / n), 0);
            Complex m = new Complex(k_Cos, j_Sin);
            

            //double k = Math.Pow(r, 1.0 / n) * Math.Cos(arg / n);
            //double j = Math.Pow(r, 1.0 / n) * Math.Sin(arg / n);


            return p*m;
        }

        // равно
        public static bool operator == (Complex a, Complex b)
        {
            bool equal = false;
            if (a.x == b.x && Math.Abs(a.y) == Math.Abs(b.y))
            {
                equal = true;
            }

            return equal;
        }

        // не равно
        public static bool operator != (Complex a, Complex b)
        {
            bool equal = false;
            if ((a.x+Math.Abs(a.y)) != (b.x+Math.Abs(b.y)))
            {
                equal = true;
            }

            return equal;
        }




        public override string ToString()
        {
            string result;

            if (y == 0)
                result = $"{x}";
            else
            {
                if (y > 0)
                    result = $"{x} + {y}i";
                else
                    result = $"{x} {y}i";
            }


            return result;
        }
    }
}
