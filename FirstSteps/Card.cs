using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSteps
{
    internal class Card
    {
        public double Balance;

        public string HolderName;
        public string Number;

        public Card(string name, string number, double startBalance) 
        {
            HolderName = name;
            Number = number;        
            Balance = startBalance;        
        }
        public void IncreaseBalance(double sum) 
        {
            Balance += sum;
        }

        public virtual void DecreaseBalance(double sum)
        {
            if (sum > Balance)
            {
                throw new ArgumentException();
            }
            Balance -= sum;
        }

        public double GetBalance()
        {
            return Balance;        
        }

    }
}
