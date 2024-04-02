using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttestationOOP
{
    internal class Model
    {
        private double FirstNumberUser;
        private double LastNumberUser;
        private char symbolOperand;
        private double TotalValue;



        public Model(double FirstNumber, double LastNumber, char Symbol)
        {
            this.FirstNumberUser = FirstNumber;
            this.LastNumberUser = LastNumber;
            this.symbolOperand = Symbol;
        }




        public double CalcValue()
        {
            switch (symbolOperand)
            {
                case '+':
                    TotalValue = FirstNumberUser + LastNumberUser;
                    break;
                case '-':
                    TotalValue = FirstNumberUser - LastNumberUser;
                    break;
                case '*':
                    TotalValue = FirstNumberUser * LastNumberUser;
                    break;
                case '/':
                    TotalValue = FirstNumberUser / LastNumberUser;
                    break;
                case '%':
                    TotalValue = FirstNumberUser % LastNumberUser;
                    break;
            }

            return TotalValue;
        }

    }
}
