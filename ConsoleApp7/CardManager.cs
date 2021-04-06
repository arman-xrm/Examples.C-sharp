using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class CardManager
    {
        public event Action<double> OnAmount;
        public double CardRestAmount { get; set; }
        public CardManager()
        {
            CardRestAmount = 186000;
        }
        public void OnAmountWithdraw(double amount)
        {
            if ((amount < 0 && Math.Abs(amount) < CardRestAmount) || amount > 0)
            {
                this.CardRestAmount += amount;
                OnAmount.Invoke(amount);
            }
            else
            {
                Console.WriteLine("You have insufficient resources");
            }
        }

    }
}
