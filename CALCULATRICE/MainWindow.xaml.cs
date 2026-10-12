
using System;
using System.Windows;

namespace CALCULATRICE
{
    public partial class MainWindow : Window
    {
        double NB1 = 0;
        double NB2 = 0;
        char Oper = ' ';

        public MainWindow()
        {
            InitializeComponent();
        }

        // CALCUL

        public double Calcul(double NB1, double NB2, char operation)
        {
            double Resultat = 0;

            switch (operation)
            {
                case '+':
                    Resultat = NB1 + NB2;
                    break;

                case '-':
                    Resultat = NB1 - NB2;
                    break;

                case '*':
                    Resultat = NB1 * NB2;
                    break;

                case '/':
                    if (NB2 == 0)
                    {
                        MessageBox.Show("Division par zéro impossible.");
                        return 0;
                    }

                    Resultat = NB1 / NB2;
                    break;
            }

            return Resultat;
        }

        // CHIFFRES

        private void BTN_One_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "0")
                TB_Display.Text = "1";
            else
                TB_Display.Text += "1";
        }

        private void BTN_Two_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "0")
                TB_Display.Text = "2";
            else
                TB_Display.Text += "2";
        }

        private void BTN_Three_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "0")
                TB_Display.Text = "3";
            else
                TB_Display.Text += "3";
        }

        private void BTN_Four_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "0")
                TB_Display.Text = "4";
            else
                TB_Display.Text += "4";
        }

        private void BTN_Five_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "0")
                TB_Display.Text = "5";
            else
                TB_Display.Text += "5";
        }

        private void BTN_Six_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "0")
                TB_Display.Text = "6";
            else
                TB_Display.Text += "6";
        }

        private void BTN_Seven_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "0")
                TB_Display.Text = "7";
            else
                TB_Display.Text += "7";
        }

        private void BTN_Eight_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "0")
                TB_Display.Text = "8";
            else
                TB_Display.Text += "8";
        }

        private void BTN_Nine_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "0")
                TB_Display.Text = "9";
            else
                TB_Display.Text += "9";
        }

        private void BTN_Zero_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "0")
                TB_Display.Text = "0";
            else
                TB_Display.Text += "0";
        }

        // ADDITION

        private void BTN_Add_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TB_Display.Text))
                return;

            NB1 = double.Parse(TB_Display.Text);
            Oper = '+';
            TB_Display.Text = "";
        }

        // SOUSTRACTION
       
        private void BTN_Subtract_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TB_Display.Text))
                return;

            NB1 = double.Parse(TB_Display.Text);
            Oper = '-';
            TB_Display.Text = "";
        }

        // MULTIPLICATION

        private void BTN_Multiply_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TB_Display.Text))
                return;

            NB1 = double.Parse(TB_Display.Text);
            Oper = '*';
            TB_Display.Text = "";
        }

        // DIVISION

        private void BTN_Divide_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TB_Display.Text))
                return;

            NB1 = double.Parse(TB_Display.Text);
            Oper = '/';
            TB_Display.Text = "";
        }

        // EGAL

        private void BTN_Equals_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TB_Display.Text))
                return;

            if (Oper == ' ')
                return;

            NB2 = double.Parse(TB_Display.Text);

            if (Oper == '/' && NB2 == 0)
            {
                MessageBox.Show("Division par zéro impossible.");
                return;
            }

            double resultat = Calcul(NB1, NB2, Oper);

            TB_Display.Text = resultat.ToString();

            NB1 = resultat;
            Oper = ' ';
        }

        // EFFACER

        private void BTN_Clear_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text = "0";
            NB1 = 0;
            NB2 = 0;
            Oper = ' ';
        }

        // SINUS

        private void BTN_Sinus_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(TB_Display.Text, out double nombre))
            {
                double radians = nombre * Math.PI / 180;
                double resultat = Math.Sin(radians);

                TB_Display.Text = Math.Round(resultat, 10).ToString();
            }
        }

        // COSINUS

        private void BTN_Cosinus_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(TB_Display.Text, out double nombre))
            {
                double radians = nombre * Math.PI / 180;
                double resultat = Math.Cos(radians);

                TB_Display.Text = Math.Round(resultat, 10).ToString();
            }
        }

        // TANGENTE

        private void BTN_Tangente_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(TB_Display.Text, out double nombre))
            {
                double radians = nombre * Math.PI / 180;

                if (Math.Abs(Math.Cos(radians)) < 0.0000000001)
                {
                    MessageBox.Show("Tangente non définie.");
                    return;
                }

                double resultat = Math.Tan(radians);

                TB_Display.Text = Math.Round(resultat, 10).ToString();
            }
        }
    }
}
