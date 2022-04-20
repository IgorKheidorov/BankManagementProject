using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSteps
{
    // Class bank
    internal class Bank
    {
        public string BankName;
        public Card[] Cards;
        int issuedCardsNumber;
        int MaxNumberOfCards;

        public Bank(int cardsCount) 
        {
            Cards = new Card[cardsCount];
            issuedCardsNumber = 0;
            MaxNumberOfCards = cardsCount;
        }

        public void IssueCreditCard(string name, double startBalance) 
        {
            if (name == "Johny Walker")
            {
                Cards[issuedCardsNumber] = new CreditCard(name, issuedCardsNumber.ToString(), startBalance);
            }
            else 
            {
                Cards[issuedCardsNumber] = new Card(name, issuedCardsNumber.ToString(), startBalance);
            }
            issuedCardsNumber++;
        }

        public string GetCardsNumbers() 
        {
            string numbers = "";

            for (int index = 0; index < issuedCardsNumber; index++)
            {
                numbers += Cards[index].Number;
                numbers += " ";
            }

            return numbers;        
        }

        public bool TransferMoney(string sourceCardNumber, string targetCardNumber, double sum) 
        {
            Card sourceCard = null, targetCard = null;

            for (int index = 0; index < issuedCardsNumber; index++)
            {
                if (Cards[index].Number == sourceCardNumber)
                {
                    sourceCard = Cards[index];
                }
                else if (Cards[index].Number == targetCardNumber)
                {
                    targetCard = Cards[index];    
                }
            }

            if (sourceCard == null || targetCard == null)
            {
                return false;
            }

            sourceCard.DecreaseBalance(sum);
            targetCard.IncreaseBalance(sum);

            return true;
        
        }



    }
}
