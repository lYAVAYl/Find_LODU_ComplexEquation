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
        private string Out_text = "Введите уравнение...";
        private string equation;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void ResetText()
        {
            textBox_Equation.Text = Out_text;
        }

        private void EnterEquation(object sender, RoutedEventArgs e)
        {
            if (textBox_Equation.Text == Out_text)
                textBox_Equation.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox_Equation.Text == "" || textBox_Equation.Text == Out_text)
                MessageBox.Show("Вы ничего не ввели!");
            else
            {
                equation = textBox_Equation.Text;
                MessageBox.Show(equation);
            }
        }
    }
}
