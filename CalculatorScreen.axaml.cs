using System;
using System.Windows;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace CalculatorQuest
{
    public partial class CalculatorScreen : Window
    {
        public CalculatorScreen()
        {
            InitializeComponent();
        }
        
        
        void ButtClick(object? sender, RoutedEventArgs args)
        {
            Button butt = (sender as Button)!;
            Operation.Content += butt.Content?.ToString();
            if (butt.Content == ".")
            {
                if (Operation.Content.ToString().Contains("."))
                {
                    return;
                }
            }
        }

        void ButtSend(object? sender, RoutedEventArgs args)
        {
            Calc _calc = new Calc();
            if (Operation.Content != "")
            {
                Result.Content = _calc.Operator(Operation.Content.ToString());
            }
            Operation.Content = "";
        }

        void ButtSupprOp(object? sender, RoutedEventArgs args)
        {
            Operation.Content = "";
        }
        void ButtSupprAll(object? sender, RoutedEventArgs args)
        {
            Operation.Content = "";
            Result.Content = "0";
        }
        void ButtSuppr1b1(object? sender, RoutedEventArgs args)
        {
            string calcul = Operation.Content.ToString();
            if (calcul.Length > 0)
            {
                Operation.Content = calcul.Remove(calcul.Length - 1, 1);
            }
        }

        void ButtChangeSign(object? sender, RoutedEventArgs args)
        {
            Calc _calc = new Calc();
            Operation.Content = _calc.posNeg(Operation.Content.ToString());
        }
    }
}