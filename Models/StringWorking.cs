using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static Lab20___WpfApp.Models.MyCalcWork;

namespace Lab20___WpfApp.Models
{
    static public class StringWorking
    {
        /*
         * Конвертация строкового значения операции в CalcOper
         * strOper - строковое значение операции
         */
        public static CalcOper ConvertStrToCalcOper(string strOper)
        {
            CalcOper res;
            switch (strOper)
            {
                case "+":
                    res = CalcOper.Summ;
                    break;

                case "-":
                    res = CalcOper.Subtraction;
                    break;

                case "x":
                    res = CalcOper.Multiplication;
                    break;

                case "÷":
                    res = CalcOper.Division;
                    break;

                case "√x":
                    res = CalcOper.Sqrt;
                    break;

                case "x²":
                    res = CalcOper.Sqr;
                    break;

                case "%":
                    res = CalcOper.Percent;
                    break;

                case "1/x":
                    res = CalcOper.Reciproc;
                    break;

                case "±":
                    res = CalcOper.Negative;
                    break;

                default:
                    res = CalcOper.None;
                    break;
            }
            return res;
        }

        /* 
         * Проверка на корректности ввода числовой последовательности в формате String
         * str - Строковый параметр запроса, 
         * doubleData - ссылка для получения конвертации строки в Double 
         */
        static public bool DataStrToDouble(string strData, ref double doubleData)
        {
            bool res = true;
            doubleData = 0;
            try
            {
                doubleData = Convert.ToDouble(strData);
            }
            catch (Exception ex)
            {
                res = false;
               // MessageBox.Show(ex.Message, "Ошибка ввода данных", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return res;
        }

        /*
         * Добавление символа в строку
         * str - исходная строка
         * chr - добавляемый сивол, тип string
         */
        public static string StrEnterData(string str, string chr)
        {
            string res = str;
            if ((str == "0") && (chr != ","))
            {
                res = chr;
            }
            else
            {
                res += chr;
            }

            return res;
        }

        /*
         * Удаление последнего символа из строки
         * str - исходная строка
         */
        public static string StrBackSpace(string str)
        {
            string strRes = "";
            if (str.Length > 1)
            {
                strRes = str.Remove(str.Length - 1);//удаляем последний символ из строки
            }
            else
            {
                if (str.Length > 0)
                {
                    strRes = "0";
                }
            }
            return strRes;
        }
    }
}
