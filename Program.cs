using System;
namespace CalculatorQuest
{
    class Program
    {
        static void Main(string[] str)
        {
            Calc c = new Calc();
            Debug.WriteLine(c.Operator("18+7"));
            Debug.WriteLine(c.Operator("100%3"));
            Debug.WriteLine(c.Operator("73/0"));
            Debug.WriteLine(c.Operator(""));
            Debug.WriteLine(c.Operator("18+32/5%3.14"));
        }
    }
}