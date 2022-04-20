using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSteps
{
    internal class CreditCard : Card
    {
        public double CreditLimit;
        public double CreditPrice; 

        public CreditCard(string name, string number, double startBalance): base(name, number, startBalance)
        {
            CreditLimit = 100;
            CreditPrice = 10;           
        }

        public override void DecreaseBalance(double sum)
        {
            if (sum > Balance + CreditLimit)
            {
                throw new ArgumentException();
            }
            Balance -= sum;
        }
    }
}
