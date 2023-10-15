using System;
using System.Data;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CalculatorQuest;
public class Calc
{
    private string[] _signs = {"-","+","*","/","%"};
    private string[] _vir = { ",","." };
    public string result;
    
    public Calc()
    {
    
    }
    
    public string Operator(string operation)
    {
        bool validOperation = false;
        if (operation.Substring(0,1) == "+" || operation.Substring(0,1) == "*" || operation.Substring(0,1) == "/" || operation.Substring(0,1) == "%" || operation.Substring(0,1) == ",")
        {
            return "No sign when you start (Except \"-\")";
        }

        if (operation.Length == 1)
        {
            return operation;
        }
        foreach (string signOp in _signs)
        {
            if (operation.Contains(signOp))
            {
                validOperation = true;
            }
        }
        if (!validOperation)
        {
            return "Please enter an operation";
        }
        int signs = 0;
        int vir = 0;
        foreach (char c in operation)
        {
            if (Array.IndexOf(_signs, c.ToString()) >= 0) 
            {
                signs++;
            }

            if (Array.IndexOf(_vir, c.ToString()) >= 0)
            {
                vir++;
            }
        }
        if (signs > 1 || signs == 0)
        {
            return "Only one operation please";
        }

        if (vir > 2 || signs < vir)
        {
            return "Only one comma per number please";
        }

        if (operation.Contains("/0") || operation.Contains("0/"))
        {
            return "Division by 0 is IMPOSSIBLE";
        }
        return new DataTable().Compute(operation,"").ToString()!;
    }

    public string posNeg(string nb)
    {
        if (string.IsNullOrEmpty(nb))
        {
            return "";
        }

        if (nb[0] == '-')
        {
            nb = nb.Substring(1);
        }
        else
        {
            nb = "-" + nb;
        }
        return nb;
    }
}