using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PP_1._3_LODU
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<TextBox> textBoxes = new List<TextBox>();
        double C1 = 0;
        double C2 = 0;
        double C3 = 0;
        double C4 = 0;
        double C5 = 0;
        bool x = false;

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string answer="";


            if (!isDouble(ref C1, ref C2, ref C3, ref C4, ref C5))
                MessageBox.Show("Вы где-то накосячили...");
            else
            {
                if (C1 != 0)
                {
                    // Формула Феррари (F_Ferrari)
                }
                else if (C2 != 0)
                {
                    // Формула Кардано (F_Kardano)
                    answer = F_notKordano(C2, C3, C4, C5);
                }
                else if (C3 != 0)
                {
                    // квадратное уравнение (DoubleTrubble)---
                    answer = DoubleTrubble(C3, C4, C5);
                }
                else if (C4 != 0)
                {
                    // Легкость бытия (EasyPeazy)---
                    answer = EasyPeazy(C4, C5);
                }
                else if (C5 != 0)
                {
                    // ну это просто (GGWP)---
                    answer = "y = 0";
                }
                else
                    answer = "Бесконечное множество решений";

            }


            textBlock_Answer.Text = answer;            
        }




        #region ПРОВЕРКА НА ЧИСЛО
        /// <summary>
        /// Проверка, является ли введённый коэффициент числом. Если да, то возвращает коэффициент.
        /// </summary>
        /// <param name="C1">коэф. 1</param>
        /// <param name="C2">коэф. 2</param>
        /// <param name="C3">коэф. 3</param>
        /// <param name="C4">коэф. 4</param>
        /// <param name="C5">коэф. 5</param>
        /// <returns></returns>
        private bool isDouble(ref double C1
                            , ref double C2
                            , ref double C3
                            , ref double C4
                            , ref double C5)
        {
            #region Если пусто, то присваиваем 0
            if (a1.Text == "")
                a1.Text = "0";
            if (a2.Text == "")
                a2.Text = "0";
            if (a3.Text == "")
                a3.Text = "0";
            if (a4.Text == "")
                a4.Text = "0";
            if (a5.Text == "")
                a5.Text = "0";
            #endregion

            bool correct = true; // является ли введённая строка числом
                        
            // a1 - не число
            if (!double.TryParse(a1.Text, out C1))
            {
                a1.Background = (Brush)System.ComponentModel.TypeDescriptor
                .GetConverter(typeof(Brush)).ConvertFromInvariantString("Pink");
                correct = false;
            }
            else if (C1> double.MaxValue)
            {
                a1.Background = (Brush)System.ComponentModel.TypeDescriptor
                .GetConverter(typeof(Brush)).ConvertFromInvariantString("Pink");
                correct = false;
            }

            // a2 - не число
            if (!double.TryParse(a2.Text, out C2))
            {
                a2.Background = (Brush)System.ComponentModel.TypeDescriptor
                .GetConverter(typeof(Brush)).ConvertFromInvariantString("Pink");
                correct = false;
            }
            else if (C2 > double.MaxValue)
            {
                a2.Background = (Brush)System.ComponentModel.TypeDescriptor
                .GetConverter(typeof(Brush)).ConvertFromInvariantString("Pink");
                correct = false;
            }

            // a3 - не число
            if (!double.TryParse(a3.Text, out C3))
            {
                a3.Background = (Brush)System.ComponentModel.TypeDescriptor
                .GetConverter(typeof(Brush)).ConvertFromInvariantString("Pink");
                correct = false;
            }
            else if (C3 > double.MaxValue)
            {
                a3.Background = (Brush)System.ComponentModel.TypeDescriptor
                .GetConverter(typeof(Brush)).ConvertFromInvariantString("Pink");
                correct = false;
            }

            // a4 - не число
            if (!double.TryParse(a4.Text, out C4))
            {
                a4.Background = (Brush)System.ComponentModel.TypeDescriptor
                .GetConverter(typeof(Brush)).ConvertFromInvariantString("Pink");
                correct = false;
            }
            else if (C4 > double.MaxValue)
            {
                a4.Background = (Brush)System.ComponentModel.TypeDescriptor
                .GetConverter(typeof(Brush)).ConvertFromInvariantString("Pink");
                correct = false;
            }

            // a5 - не число
            if (!double.TryParse(a5.Text, out C5))
            {
                a5.Background = (Brush)System.ComponentModel.TypeDescriptor
                .GetConverter(typeof(Brush)).ConvertFromInvariantString("Pink");
                correct = false;
            }
            else if (C5 > double.MaxValue)
            {
                a5.Background = (Brush)System.ComponentModel.TypeDescriptor
                .GetConverter(typeof(Brush)).ConvertFromInvariantString("Pink");
                correct = false;
            }

            return correct;
            // если проверка пройдена, то вернётся true, иначе false
            
        }




        #endregion

        #region СБРОС ЦВЕТА
        // СБРОС ЦВЕТА а1
        private void ResetColor_1(object sender, RoutedEventArgs e)
        {
            a1.Background = (Brush)System.ComponentModel.TypeDescriptor
                .GetConverter(typeof(Brush)).ConvertFromInvariantString("White");
        }

        // СБРОС ЦВЕТА а2
        private void ResetColor_2(object sender, RoutedEventArgs e)
        {
            a2.Background = (Brush)System.ComponentModel.TypeDescriptor
                .GetConverter(typeof(Brush)).ConvertFromInvariantString("White");
        }

        // СБРОС ЦВЕТА а3
        private void ResetColor_3(object sender, RoutedEventArgs e)
        {
            a3.Background = (Brush)System.ComponentModel.TypeDescriptor
                .GetConverter(typeof(Brush)).ConvertFromInvariantString("White");
        }

        // СБРОС ЦВЕТА а4
        private void ResetColor_4(object sender, RoutedEventArgs e)
        {            
            a4.Background = (Brush)System.ComponentModel.TypeDescriptor
                .GetConverter(typeof(Brush)).ConvertFromInvariantString("White");
        }

        // СБРОС ЦВЕТА а5
        private void ResetColor_5(object sender, RoutedEventArgs e)
        {
            a5.Background = (Brush)System.ComponentModel.TypeDescriptor
                .GetConverter(typeof(Brush)).ConvertFromInvariantString("White");
        }
        #endregion


        // СДЕЛАНО
        /// <summary>
        ///  Макс. порядок - 1
        /// </summary>
        /// <param name="a1">коэф - 1</param>
        /// <param name="a2">коэф - 2</param>
        /// <returns></returns>
        private string EasyPeazy(double a1, double a2)
        {
            string answer;

            a2 = 0 -a2;

            if (a2 % a1 == 0.0)
                answer = $"y = C1*e^( ({a2 / a1})x )";
            else
                answer = $"y = C1*e^( ({a2}/{a1})x )";

            return answer;
        }


        // СДЕЛАНО
        #region Double Trubble
        /// <summary>
        /// Макс. порядок - 2
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        private string DoubleTrubble(double a, double b, double c)
        {
            string answer;
            double D = find_Discriminant(a, b, c);

            if (D > 0)
            {
                answer = D_isBiggerThenZero(a, b, D);
            }
            else if (D < 0)
            {
                answer = D_isSmallerThenZero(a, b, D);
            }
            else
            {
                answer = D_isZero(a, b);
            }

            return answer;
        }


        /// <summary>
        /// Нахождение дискриминанта
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        private double find_Discriminant(double a, double b, double c)
        {
            double D = b * b - 4 * a * c;

            return D;
        }

        // Дискриминант больше 0
        private string D_isBiggerThenZero(double a, double b, double D)
        {
            double k1, k2;
            string answer;

            k2 = (-b + Math.Sqrt(D)) / (2 * a);
            k1 = (-b - Math.Sqrt(D)) / (2 * a);

            k1 = Math.Round(k1, 3);
            k2 = Math.Round(k2, 3);

            if (k1 != k2)
            {
                answer = $"y = C1*e^( ({k1})x ) + C2*e^( ({k2})x )";
            }
            else
            {
                answer = $"y = C1*e^( ({k1})x ) + C2*x*e^( ({k2})x )";
            }

            return answer;
        }

        // Дискриминант равен 0
        private string D_isZero(double a, double b)
        {
            double k = (-b) / (2 * a);
            k = Math.Round(k, 3);

            string answer = $"y = C1*e^( ({k})x ) + C2*x*e^( ({k})x )";
            return answer;
        }

        // Дискриминант меньше 0
        private string D_isSmallerThenZero(double a, double b, double D)
        {
            double k1, k2;
            string answer, alpha, beta;

            k1 = (-b + Math.Sqrt(-D)) / (2 * a);
            k2 = (-b - Math.Sqrt(-D)) / (2 * a);

            k1 = Math.Round(k1, 3);
            k2 = Math.Round(k2, 3);

            alpha = $"({-b}/{2*a})x";
            beta = $"(√{-D}/{2*a})x";

            if (k1 == k2)
            {
                answer = $"y = e^( {alpha} ) * (C1*Cos( {beta} ) + C2*Sin( {beta} ))";
            }
            else
            {
                answer = $"y = e^( {alpha} ) * (C1*Cos( {beta} ) + C2*x*Sin( {beta} ))";
            }

            return answer;
        }

        #endregion



        private string F_Kordano(double a, double b, double c, double d)
        {
            string answer = "";
            double x1, x2, x3, x1_i, x2_i, x3_i;
            double y1, y2, y3, y1_i, y2_i, y3_i;
            double k1, k2;
            

            double p = (3.0 * a * c - b * b) / (3.0 * a * a);
            p = Math.Round(p, 2);

            double q = (2.0 * b * b * b - 9.0 * a * b * c + 27.0 * a * a * d) / (27.0 * a * a * a);
            q = Math.Round(q, 2);

            double Q = (Math.Pow(p / 3.0, 3)) + (Math.Pow(q / 2.0, 2));



            //if (Q >= 0.01 && Q< 0.02)
            //    Q = 0.0;

            double R = (2.0*Math.Pow((double)a, 3) - 9.0*(double)a*(double)b + 27.0*(double)c) / (54.0);
            

            double alpha = Math.Pow(((-q / 2.0) + Math.Sqrt(Q)), 1/3);
            alpha = Math.Round(alpha, 2);
            double beta = Math.Pow(((-q / 2.0) - Math.Sqrt(Q)), 1/3);
            beta = Math.Round(beta, 2);
            
           

            if (Q > 0) // СДЕЛАНО
            {
                Q = Math.Round(Q, 2);


                k1 = -q / 2 + Math.Sqrt(Q);
                if (k1 < 0) // k1 -
                {
                    k1 *= -1;
                    k1 = Math.Pow(k1, 1.0 / 3.0); // возведение ^3V
                    k1 = Math.Round(k1, 2);
                    k1 *= -1;
                }
                else // k2 +
                {
                    k1 = Math.Pow(k1, 1.0 / 3.0); // возведение ^3V
                    k1 = Math.Round(k1, 2);
                }


                k2 = -q / 2 - Math.Sqrt(Q);
                if (k2 < 0) // k2 -
                {
                    k2 *= -1;
                    k2 = Math.Pow(k2, 1.0 / 3.0); // возведение ^3V
                    k2 = Math.Round(k2, 2);
                    k2 *= -1;
                }
                else // k2 +
                {
                    k2 = Math.Pow(k2, 1.0 / 3.0); // возведение ^3V
                    k2 = Math.Round(k2, 2);
                }


                y1 = k1+k2;
                y1 = Math.Round(y1, 2);

                y2 = -(k1 + k2) / 2.0;
                y2 = Math.Round(y2, 2);
                y2_i = ((k1 - k2) * Math.Sqrt(3)) / 2;
                y2_i = Math.Round(y2_i, 2);

                y3 = -(k1 + k2) / 2.0;
                y3 = Math.Round(y3, 2);
                y3_i = -((k1 - k2) * Math.Sqrt(3)) / 2;
                y3_i = Math.Round(y3_i, 2);


                x1 = y1 - b / (3.0 * a);
                x1 = Math.Round(x1, 2);

                x2 = y2 - b / (3.0 * a);
                x2 = Math.Round(x2, 2);
                x2_i = y2_i;

                x3 = y3 - b / (3.0 * a);
                x3 = Math.Round(x3, 2);
                x3_i = y3_i;

                answer = $"q: {q} \n" +
                     $"p: {p} \n" +
                     $"Q: {Q} \n" +
                     $"R: {R} \n" +
                     $"alpha: {alpha} \n" +
                     $"beta: {beta} \n" +
                     $"y1: {y1} \n" +
                     $"y2: {y2} | {y2_i} i \n" +
                     $"y3: {y3} | {y3_i} i \n" +
                     $"k1: {k1} \n" +
                     $"k2: {k2} \n" +
                     $"-------------------------- \n" +
                     $"x1: {x1} \n" +
                     $"x2: {x2} + ({x2_i})i \n" +
                     $"x3: {x3} + ({x3_i})i \n" +
                     $"\n" +
                     $"y12 = ^3V( {-(q / 2.0) + Q} ) - {p} / 3*^3V( {-(q / 2.0) + Q} )";
            }
            else if (Q < 0)
            {
                Q = Math.Round(Q, 2);


                y1 = 1;
                y2 = 2;
                y3 = 3;

                x1 = 1;
                x2 = 2;
                x3 = 3;







                answer = $"q: {q} \n" +
                     $"p: {p} \n" +
                     $"Q: {Q} \n" +
                     $"R: {R} \n" +
                     $"alpha: {alpha} \n" +
                     $"beta: {beta} \n" +
                     $"y1: {y1} \n" +
                     $"y2: {y2} \n" +
                     $"y3: {y3} \n" +
                     $"-------------------------- \n" +
                     $"x1: {x1} \n" +
                     $"x2: {x2} \n" +
                     $"x3: {x3} \n" +
                     $"\n" +
                     $"y12 = ^3V( {-(q / 2.0) + Q} ) - {p} / 3*^3V( {-(q / 2.0) + Q} )";
            }
            else // СДЕЛАНО
            {
                Q = Math.Round(Q, 2);

                y1 = -2 * Math.Pow(q/2.0, 1.0 / 3.0);
                y2 = Math.Pow(q/2.0, 1.0 / 3.0);
                y3 = y2;

                x1 = y1 - b / (3.0 * a);
                x1 = Math.Round(x1, 2);
                x2 = y2 - b / (3.0 * a);
                x2 = Math.Round(x2, 2);
                x3 = y3 - b / (3.0 * a);
                x3 = Math.Round(x3, 2);

                answer = $"q: {q} \n" +
                     $"p: {p} \n" +
                     $"Q: {Q} \n" +
                     $"R: {R} \n" +
                     $"alpha: {alpha} \n" +
                     $"beta: {beta} \n" +
                     $"y1: {y1} \n" +
                     $"y2: {y2} \n" +
                     $"y3: {y3} \n" +
                     $"-------------------------- \n" +
                     $"x1: {x1} \n" +
                     $"x2: {x2} \n" +
                     $"x3: {x3} \n" +
                     $"\n" +
                     $"y12 = ^3V( {-(q / 2.0) + Q} ) - {p} / 3*^3V( {-(q / 2.0) + Q} )";

            }


            return answer;
        }



        private string F_notKordano(double a, double b, double c, double d)
        {
            string answer = "";
            double x1, x2, x3, x1_i, x2_i, x3_i;
            double y1, y2, y3, y1_i, y2_i, y3_i;
            double k1, k2;
            double F;
            double chis, znam;


            double p = (3.0 * a * c - b * b) / (3.0 * a * a);
            double q = ((2.0 * b * b * b) - (9.0 * a * b * c) + (27.0 * a * a * d)) / (27.0 * a * a * a);

            double S = (4 * Math.Pow(3.0 * a * c - b * b, 3.0) + Math.Pow(2.0 * b * b * b - 9.0 * a * b * c + 27.0 * a * a * d, 2.0)) / (2916.0 * Math.Pow(a, 6.0));

            // расчёт F
            #region F
            if (q < 0)
            {
                chis = Math.Sqrt(  Math.Abs( ((q * q) / 4.0) + ((p * p * p) / 27.0) )  );
                znam = -q / 2.0;
                F = Math.Atan(chis / znam);
            }
            else if (q > 0)
            {
                chis = Math.Sqrt(Math.Abs(((q * q) / 4.0) + ((p * p * p) / 27.0)));
                znam = -q / 2.0;
                F = Math.Atan(chis / znam) + Math.PI;
            }
            else
            {
                F = Math.PI / 2.0;
            }
            #endregion


            if (S > 0)
            {
                S_isBiggerThenZero(out x1, out x2, out x3, out x2_i, out x3_i, q, p, a, b);
                
                answer = $"y = C1*e^( ({x1})x ) + e^( ({x2})x ) * ( C2*Cos( ({x2_i})x ) + C3*Sin( ({x3_i})x ) )";
            }
            else if (S < 0)
            {
                S_isSmallerThenZero(out x1, out x2, out x3, F, p, a, b);

                answer = $"y = C1*e^( ({x1})x ) + C2*e^( ({x2})x ) + C3*e^( ({x3})x )";
            }
            else
            {
                S_isZero(out x1, out x2, out x3, q, a, b);
                
                if (x1 == x2)
                {
                    answer = $"y = C1*e^( ({x1})x ) + C2*x*e^( ({x2})x ) + C3*e^( ({x3})x )";
                }
                else if (x1 == x3)
                {
                    answer = $"y = C1*e^( ({x1})x ) + C2*e^( ({x2})x ) + C3*x*e^( ({x3})x )";
                }
                else if (x2 == x3)
                {
                    answer = $"y = C1*e^( ({x1})x ) + C2*e^( ({x2})x ) + C3*x*e^( ({x3})x )";
                }
                else if (x1 == x2 && x2 == x3)
                {
                    answer = $"y = C1*e^( ({x1})x ) + C2*x*e^( ({x2})x ) + C3*x^(2)*e^( ({x3})x )";
                }
                else
                {
                    answer = $"y = C1*e^( ({x1})x ) + C2*e^( ({x2})x ) + C3*e^( ({x3})x )";
                }

            }

            



            return answer;
        }


        // РАБОТАЕТ - ДИСКРИМИНАНТ БОЛЬШЕ 0
        private void S_isBiggerThenZero(out double x1, out double x2, out double x3,
                                                         out double x2_i, out double x3_i, 
                                          double q, double p, double a, double b)
        {
            double plus, minus;
            

            double q4_p27 = ((q*q) / 4.0) + ((p*p*p) / 27.0);
            if (q4_p27 < 0)
            {
                q4_p27 = Math.Abs(q4_p27);
                q4_p27 = Math.Sqrt(q4_p27);
                q4_p27 *= -1;
            }
            else
            {
                q4_p27 = Math.Sqrt(q4_p27);
            }

            plus = (-q / 2.0) + q4_p27;
            if (plus < 0)
            {
                plus = Math.Abs(plus);
                plus = Math.Pow(plus, 1.0 / 3.0);
                plus *= -1;
            }
            else
            {
                plus = Math.Pow(plus, 1.0 / 3.0);
            }

            minus = (-q / 2.0) - q4_p27;
            if (minus < 0)
            {
                minus = Math.Abs(minus);
                minus = Math.Pow(minus, 1.0 / 3.0);
                minus *= -1;
            }
            else
            {
                minus = Math.Pow(minus, 1.0 / 3.0);
            }

            x1 = plus + minus - (b / (3.0 * a));

            // X_2 = x2 + x2_i
            x2 = (-1.0 / 2.0) * (plus + minus) - (b / (3.0 * a));
            x2_i = (Math.Sqrt(3.0) / 2.0) * (plus - minus);

            // X_3 = x3 - x3_i
            x3 = (-1.0 / 2.0) * (plus + minus) - (b / (3.0 * a));
            x3_i = (Math.Sqrt(3.0) / 2.0) * (plus - minus);


            #region Округление
            x1 = Math.Round(x1, 2);

            x2 = Math.Round(x2, 2);
            x2_i = Math.Round(x2_i, 2);

            x3 = Math.Round(x3, 2);
            x3_i = Math.Round(x3_i, 2);
            #endregion

        }


        // РАБОТАЕТ - ДИСКРИМИНАНТ МЕНЬШЕ 0
        private void S_isSmallerThenZero(out double x1, out double x2, out double x3, double F, double p, double a, double b)
        {
            double p2 = -p / 3.0;

            if (p2 < 0)
            {
                p2 = Math.Abs(p2);
                p2 = Math.Sqrt(p2);
                p2 *= -1;
            }
            else
            {
                p2 = Math.Sqrt(p2);
            }

            x1 = 2 * p2 * Math.Cos( (F + 2 * Math.PI) / 3.0 ) - (b/(3.0*a));
            x3 = 2 * p2 * Math.Cos(F / 3.0) - (b / (3.0 * a));
            x2 = 2 * p2 * Math.Cos( (F + 4 * Math.PI) / 3.0 ) - (b/(3.0*a));

            #region Округление
            x1 = Math.Round(x1, 2);

            x2 = Math.Round(x2, 2);

            x3 = Math.Round(x3, 2);
            #endregion
        }



        // РАБОТАЕТ - ДИСКРИМИНАНТ РАВЕН 0
        private void S_isZero(out double x1, out double x2, out double x3, double q, double a, double b)
        {
            double q2 = -q / 2.0;
            if (q2 < 0)
            {
                q2 = Math.Abs(q2);
                q2 = Math.Pow(q2, 1.0 / 3.0);
                q2 *= -1;
            }
            else
            {
                q2 = Math.Pow(q2, 1.0 / 3.0);
            }

            x1 = 2.0 * q2 - (b / (3.0 * a));
            x2 = -q2 - (b / (3.0 * a));
            x3 = -q2 - (b / (3.0 * a));

            #region Округление
            x1 = Math.Round(x1, 2);
            x2 = Math.Round(x2, 2);
            x3 = Math.Round(x3, 2);
            #endregion

        }

    }
}
