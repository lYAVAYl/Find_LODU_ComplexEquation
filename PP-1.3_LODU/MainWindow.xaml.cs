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
                }
                else if (C3 != 0)
                {
                    // квадратное уравнение (DoubleTrubble)---
                    answer = DoubleTrubble(C3, C4, C5);
                    MessageBox.Show(answer);
                }
                else if (C4 != 0)
                {
                    // Легкость бытия (EasyPeazy)---
                    answer = EasyPeazy(C4, C5);
                    MessageBox.Show(answer);
                }
                else if (C5 != 0)
                {
                    // ну это просто (GGWP)---
                    MessageBox.Show("y = 0");
                }
                else
                    MessageBox.Show("Бесконечное множество решений");

            }



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

            // a2 - не число
            if (!double.TryParse(a2.Text, out C2))
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

            // a4 - не число
            if (!double.TryParse(a4.Text, out C4))
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




    }
}
