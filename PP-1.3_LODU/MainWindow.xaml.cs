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
using System.Numerics;

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
            double nothing;


            if (!isDouble(ref C1, ref C2, ref C3, ref C4, ref C5))
                MessageBox.Show("Вы где-то накосячили...");
            else
            {
                if (C1 != 0)
                {
                    // Формула Феррари (F_Ferrari)
                    answer = F_Ferrari(C1, C2, C3, C4, C5);
                }
                else if (C2 != 0)
                {
                    // Формула Кардано (F_Kardano)
                    answer = F_Kordano(C2, C3, C4, C5);
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
                    answer = "  y = 0";
                }
                else
                    answer = "  Бесконечное множество решений";

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
            string answer = "";

            a2 *= -1;

            answer = $"  y = C1*e^( ({Math.Round(a2 / a1, 2)})x )";

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
                answer = $"  y = C1*e^( ({k1})x ) + C2*e^( ({k2})x )";
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

            string answer = $"  y = C1*e^( ({k})x ) + C2*x*e^( ({k})x )";
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
                answer = $"  y = e^( {alpha} ) * (C1*Cos( {beta} ) + C2*Sin( {beta} ))";
            }
            else
            {
                answer = $"  y = e^( {alpha} ) * (C1*Cos( {beta} ) + C2*Sin( {beta} ))";
            }

            return answer;
        }

        #endregion
        
        // СДЕЛАНО
        #region F_notKordano

        /// <summary>
        /// Макс. порядок - 3
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        private string F_Kordano(double a, double b, double c, double d)
        {
            string answer = "";
            double x1, x2, x3, x1_i=0.0, x2_i=0.0, x3_i=0.0;
            double F;
            double chis, znam;


            double p = (3.0 * a * c - b * b) / (3.0 * a * a);
            double q = ((2.0 * b * b * b) - (9.0 * a * b * c) + (27.0 * a * a * d)) / (27.0 * a * a * a);
            double S = (4 * Math.Pow(3.0 * a * c - b * b, 3.0) + Math.Pow(2.0 * b * b * b - 9.0 * a * b * c + 27.0 * a * a * d, 2.0)) / (2916.0 * Math.Pow(a, 6.0));

            // расчёт F
            #region press F
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


            if (S > 0) // Дискриминант больше 0
            {
                S_isBiggerThenZero(out x1, out x2, out x3, out x2_i, out x3_i, q, p, a, b);
                
                answer = $"  y = C1*e^( ({x1})x ) + e^( ({x2})x ) * ( C2*Cos( ({x2_i})x ) + C3*Sin( ({x3_i})x ) )";
            }
            else if (S < 0) // Дискриминант меньше
            {
                S_isSmallerThenZero(out x1, out x2, out x3, F, p, a, b);

                answer = $"  y = C1*e^( ({x1})x ) + C2*e^( ({x2})x ) + C3*e^( ({x3})x )";
            }
            else // Дискриминант равен 0
            {
                S_isZero(out x1, out x2, out x3, q, a, b);
                
                if (x1 == x2 && x2 == x3)
                {
                    answer = $"  y = C1*e^( ({x1})x ) + C2*x*e^( ({x2})x ) + C3*x^(2)*e^( ({x3})x )";
                }
                else if (x1 == x2)
                {
                    answer = $"  y = C1*e^( ({x1})x ) + C2*x*e^( ({x2})x ) + C3*e^( ({x3})x )";
                }
                else if (x1 == x3)
                {
                    answer = $"  y = C1*e^( ({x1})x ) + C2*e^( ({x2})x ) + C3*x*e^( ({x3})x )";
                }
                else if (x2 == x3)
                {
                    answer = $"  y = C1*e^( ({x1})x ) + C2*e^( ({x2})x ) + C3*x*e^( ({x3})x )";
                }                
                else
                {
                    answer = $"  y = C1*e^( ({x1})x ) + C2*e^( ({x2})x ) + C3*e^( ({x3})x )";
                }

            }
            

            return answer;
        }

        #region Дискриминант кубического уравнения
        
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

        #endregion

        #endregion

        /// <summary>
        /// МАКС. ПОРЯДОК - 4
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private string F_Ferrari(double a, double b, double c, double d, double e)
        {
            string answer = "";


            Complex x1 = new Complex(0.0, 0.0);
            Complex x2 = new Complex(0.0, 0.0);
            Complex x3 = new Complex(0.0, 0.0);
            Complex x4 = new Complex(0.0, 0.0);

            // имена всех переменных взяты из Формулы Феррари

            Complex A = new Complex(a, 0.0);
            Complex B = new Complex(b, 0.0);
            Complex C = new Complex(c, 0.0);
            Complex D = new Complex(d, 0.0);
            Complex E = new Complex(e, 0.0);


            double alpha = (-(3.0 * b * b) / (8.0 * a * a)) + (c / a);
            alpha = Math.Round(alpha, 3);
            double beta = ((b * b * b) / (8.0 * a * a * a)) - ((b * c) / (2.0 * a * a)) + (d / a);
            beta = Math.Round(beta, 3);
            double gamma = ((-3.0 * (b * b * b * b)) / (256.0 * a * a * a * a)) + ((b * b * c) / (16.0 * a * a * a)) - ((b * d) / (4.0 * a * a)) + (e / a);
            gamma = Math.Round(gamma, 3);

            if (double.IsInfinity(alpha) || double.IsInfinity(beta) || double.IsInfinity(gamma))
            {
                answer = "Переполнение!";
            }
            else
            {



                Complex Alpha = new Complex(alpha, 0.0);
                Complex Beta = new Complex(beta, 0.0);
                Complex Gamma = new Complex(gamma, 0.0);

                Complex P = new Complex(0.0, 0.0);
                Complex Q = new Complex(0.0, 0.0);
                Complex R = new Complex(0.0, 0.0);
                Complex U = new Complex(0.0, 0.0);
                Complex Y = new Complex(0.0, 0.0);
                Complex W = new Complex(0.0, 0.0);




                if (Beta.x == 0 && Beta.y == 0)
                {
                    x1 = (-(B / (4.0 * A)) - Complex.Sqrt(((-Alpha - Complex.Sqrt((Alpha * Alpha) - (4.0 * Gamma), 2.0)) / 2.0), 2.0));

                    x2 = (-(B / (4.0 * A)) - Complex.Sqrt(((-Alpha + Complex.Sqrt((Alpha * Alpha) - (4.0 * Gamma), 2.0)) / 2.0), 2.0));

                    x3 = (-(B / (4.0 * A)) + Complex.Sqrt(((-Alpha - Complex.Sqrt((Alpha * Alpha) - (4.0 * Gamma), 2.0)) / 2.0), 2.0));

                    x4 = (-(B / (4.0 * A)) + Complex.Sqrt(((-Alpha + Complex.Sqrt((Alpha * Alpha) - (4.0 * Gamma), 2.0)) / 2.0), 2.0));

                }
                else
                {
                    P = ((-((Alpha * Alpha) / (12.0))) - (Gamma));
                    P.x = Math.Round(P.x, 3);
                    P.y = Math.Round(P.y, 3);

                    Q = (((Alpha * Gamma) / 3.0) - ((Beta * Beta) / 8.0) - ((Alpha * Alpha * Alpha) / 108.0));
                    Q.x = Math.Round(Q.x, 3);
                    Q.y = Math.Round(Q.y, 3);

                    R = (-(Q / 2.0) - (Complex.Sqrt((((Q * Q) / 4.0) + ((P * P * P) / 27.0)), 2.0)));
                    R.x = Math.Round(R.x, 3);
                    R.y = Math.Round(R.y, 3);

                    U = Complex.Sqrt(R, 3.0);
                    U.x = Math.Round(U.x, 3);
                    U.y = Math.Round(U.y, 3);

                    Y = (-((5.0 * Alpha) / 6.0) + (U));
                    Y.x = Math.Round(Y.x, 3);
                    Y.y = Math.Round(Y.y, 3);

                    if (U.x == 0 && U.y == 0)
                    {
                        Y = (Y - (Complex.Sqrt(Q, 3.0)));
                        Y.x = Math.Round(Y.x, 3);
                        Y.y = Math.Round(Y.y, 3);
                    }
                    else
                    {
                        Y = (Y + ((-P) / (3.0 * U)));
                        Y.x = Math.Round(Y.x, 3);
                        Y.y = Math.Round(Y.y, 3);
                    }


                    W = (Complex.Sqrt(((Alpha) + (2.0 * Y)), 2.0));
                    W.x = Math.Round(W.x, 3);
                    W.y = Math.Round(W.y, 3);


                    x1 = (((-B) / (4.0 * A)) + ((W - Complex.Sqrt(-((3.0 * Alpha) + (2.0 * Y) + ((2.0 * Beta) / W)), 2.0)) / 2.0));
                    x2 = (((-B) / (4.0 * A)) - ((W - Complex.Sqrt(-((3.0 * Alpha) + (2.0 * Y) - ((2.0 * Beta) / W)), 2.0)) / 2.0));
                    x3 = (((-B) / (4.0 * A)) - ((W + Complex.Sqrt(-((3.0 * Alpha) + (2.0 * Y) - ((2.0 * Beta) / W)), 2.0)) / 2.0));
                    x4 = (((-B) / (4.0 * A)) + ((W + Complex.Sqrt(-((3.0 * Alpha) + (2.0 * Y) + ((2.0 * Beta) / W)), 2.0)) / 2.0));

                }


                x1.x = Math.Round(x1.x, 2);
                x1.y = Math.Round(x1.y, 2);

                x2.x = Math.Round(x2.x, 2);
                x2.y = Math.Round(x2.y, 2);

                x3.x = Math.Round(x3.x, 2);
                x3.y = Math.Round(x3.y, 2);

                x4.x = Math.Round(x4.x, 2);
                x4.y = Math.Round(x4.y, 2);


                // вывод ответа
                #region ответ
                if (x1 == x2 && x2 == x3 && x3 == x4)
                {
                    if (x1.y != 0)
                    {
                        answer = $"y = e^({x1.x}x) * (C1*Cos({Math.Abs(x1.y)}x) + C2*Sin({Math.Abs(x2.y)}x)) + x*e^({x1.x}) * (C1^(2)*Cos({Math.Abs(x3.y)}x) + C2^(2)*Sin({Math.Abs(x4.y)}x))";
                    }
                    else
                    {
                        answer = $"y = C1e^(({x1})x) + C2*x*e^(({x2})x) + C3*x^(2)*e^(({x3})x) + C4*x^(3)*e^(({x4})x)";
                    }
                }
                else if (x1 == x2)
                {
                    if (x3 == x4)
                    {
                        answer = $"y = e^({x1.x}x) * (C1*Cos({Math.Abs(x1.y)}x) + C2*Sin({Math.Abs(x2.y)}x)) + e^({x3.x}x) * (C3*Cos({Math.Abs(x3.y)}x) + C4*Sin({Math.Abs(x4.y)}x))";
                    }
                    else
                    {
                        answer = $"y = e^({x1.x}x) * (C1*Cos({Math.Abs(x1.y)}x) + CC2*Sin({Math.Abs(x2.y)}x)) + C3e^({x3}x) + C4e^({x4}x)";
                    }
                }
                else if (x1 == x3)
                {
                    if (x2 == x4)
                    {
                        answer = $"y = e^({x1.x}x) * (C1*Cos({Math.Abs(x1.y)}x) + C3*Sin({Math.Abs(x3.y)}x)) + e^({x2.x}x) * (C2*Cos({Math.Abs(x2.y)}x) + C4*Sin({Math.Abs(x4.y)}x))";
                    }
                    else
                    {
                        answer = $"y = e^({x1.x}x) * (C1*Cos({Math.Abs(x1.y)}x) + C3*Sin({Math.Abs(x3.y)}x)) + C2e^({x2}x) + C4e^({x4}x)";
                    }
                }
                else if (x1 == x4)
                {
                    if (x2 == x3)
                    {
                        answer = $"y = e^({x1.x}x) * (C1*Cos({Math.Abs(x1.y)}x) + C4*Sin({Math.Abs(x4.y)}x)) + e^({x2.x}x) * (C2*Cos({Math.Abs(x2.y)}x) + C3*Sin({Math.Abs(x3.y)}x))";
                    }
                    else
                    {
                        answer = $"y = e^({x1.x}x) * (C1*Cos({Math.Abs(x1.y)}x) + C4*Sin({Math.Abs(x4.y)}x)) + C2e^({x2}x) + C3e^({x3}x)";
                    }
                }
                else if (x2 == x3)
                {
                    answer = $"y = e^({x2.x}x) * (C2*Cos({Math.Abs(x2.y)}x) + C3*Sin({Math.Abs(x3.y)}x)) + C1e^({x1}x) + C4e^({x4}x)";
                }
                else if (x2 == x4)
                {
                    answer = $"y = e^({x2.x}x) * (C2*Cos({Math.Abs(x2.y)}x) + C4*Sin({Math.Abs(x4.y)}x)) + C1e^({x1}x) + C3e^({x3}x)";
                }
                else if (x3 == x4)
                {
                    answer = $"y = e^({x3.x}x) * (C3*Cos({Math.Abs(x3.y)}x) + C4*Sin({Math.Abs(x4.y)}x)) + C1e^({x1}x) + C2e^({x2}x)";
                }
                else if (x1 != x2 && x2 != x3 && x3 != x4)
                {
                    answer = $"y = C1e^(({x1})x) + C2e^(({x2})x) + C3e^(({x3})x) + C4e^(({x4})x)";
                }
                #endregion


            }

            return answer;
        }

        // очистка
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            a1.Text = "";
            a2.Text = "";
            a3.Text = "";
            a4.Text = "";
            a5.Text = "";

            textBlock_Answer.Text = "";
        }
    }
}
