using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttestationOOP
{
    internal class View
    {

        // АЛГОРИТМ УДАЛЕНИЯ ОДНОГО ЭЛЕМЕНТА ИЗ СТРОКИ
        public string DeleteNumber(string number)
        {
            string newNumber = "";
            for(int i = 0; newNumber.Length < number.Length - 1; i++)
            {
                newNumber += number[i];
            }

            return newNumber;
        }


        // МЕТОД ПО ПРЕОБРАЗОВАНИЮ ПОЛЬЗОВАТЕЛЬСКОГО ВВОДА В ВИДЕ СТРОКИ В ЧИСЛО
        public double ParseNumber(string numberTb)
        {
            double number;
            if(numberTb.Equals("")) number = 0;
            else number = Double.Parse(numberTb.Replace(".", ","));
            return number;
        }


        
        // МЕТОД ПО СОЗДАНИЮ ПРОТИВОПОЛОЖНОГО ЧИСЛА
        public string OppositeNumber(string numberTb)
        {
            string OppositeNum = "";
     
            if (numberTb[0].Equals('-'))
            {
                for(int i = 1; i < numberTb.Length; i++)
                {
                    OppositeNum += numberTb[i];
                }
            }
            else OppositeNum = "-" + numberTb;

            return OppositeNum;
        }
    }
}
