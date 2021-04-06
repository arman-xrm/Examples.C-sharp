using System;

namespace ConsoleApp7
{

    class Program
    {
        static void Main(string[] args)
        {
            MathClass ob = new MathClass();
            MathClass.myDelegate myDelegateObj = ob.Sum;
            myDelegateObj += ob.Pow;
            myDelegateObj += MathClass.Div;

            myDelegateObj(5, 0);

            Action<double, double> delegateInstance = ob.Sum;
            delegateInstance += ob.Pow;
            delegateInstance += MathClass.Div;

            delegateInstance?.Invoke(5, 5);
            Func<double, double, double, double> funcDelegate = ob.Sum;
            funcDelegate += MathClass.Div;


            Action actionDelegate = delegate { Console.WriteLine(5 + 7); };
            Action actionDelegate1 = () =>
                {
                    Console.WriteLine(5 + 7);
                };
            Action<int, int> actionDelegate2 = (x, y) => Console.WriteLine(x + y);


            // Events
            CardManager instance = new CardManager();
            instance.OnAmount += PushNotification;
            instance.OnAmountWithdraw(10000);

            Console.ReadKey();

            GeoCoordinate ob1 = new GeoCoordinate(65, 120);
            GeoCoordinate ob2 = new GeoCoordinate(65, 120);
            GeoCoordinate ob3 = ob1 + ob2;
            Console.WriteLine(ob3.CoordinateX + " " + ob3.CoordinateY);
        }


        public static void PushNotification(double amount)
        {
            Console.WriteLine($"Your card transaction amount is {amount}");
        }
    }
}
