using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lab20___WpfApp.Models
{
    public static class MyCalcWork
    {
        public enum CalcOper
        {
            None,
            Summ,
            Subtraction,
            Multiplication,
            Division,
            Sqrt,
            Sqr,
            Percent,
            Reciproc,
            Negative
        }

        /* 
         * Основная команда вычисления
         * oper - значчение из перечесления CalcOper - выбор операции рассчета, 
         * a и b - параметры над которыми проводятся вычисления
         */
        public static double Calculator(CalcOper oper, double a, double b = 0)
        {
            double res = 0;
            switch (oper)
            {
                case CalcOper.Summ:
                    res = a + b;
                    break;

                case CalcOper.Subtraction:
                    res = a - b;
                    break;

                case CalcOper.Multiplication:
                    res = a * b;
                    break;

                case CalcOper.Division:
                    try
                    {
                        res = a / b;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка вычисления", MessageBoxButton.OK, MessageBoxImage.Error);
                        res = 0;
                    }
                    break;

                case CalcOper.Sqrt:
                    try
                    {
                        res = Math.Sqrt(a);
                    }
                    catch (Exception ex)
                    {
                        res = 0;
                        MessageBox.Show(ex.Message, "Ошибка вычисления", MessageBoxButton.OK, MessageBoxImage.Error);                        
                    }
                    break;

                case CalcOper.Sqr:
                    res = Math.Pow(a, 2);
                    break;

                case CalcOper.Percent:

                    if (b == 0)
                    {
                        b = a;
                    }
                    res = (a * b) / 100;
                    break;

                case CalcOper.Reciproc:
                    res = Math.Pow(a, -1);
                    break;

                case CalcOper.Negative:
                    res = (-1) * a;
                    break;

                default:
                    res = 0;
                    break;
            }
            return res;
        }

        
    }
}
