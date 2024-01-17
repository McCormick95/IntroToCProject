using System;
using System.Reflection.Metadata.Ecma335;

namespace IntroToC{
    class IntroToC
    {
        static void Main(string[] args)
        {
            Tool T1 = new(){
                ItemId= "1",
                Name= "testTool",
                Category="power tools",
                Description="test description",
                DailyRentalCost=35.00,
                ReplacementCost= 250.00,
                QuantityAvailable=5,
                MembershipDiscount=0.5
            };
            Console.WriteLine(T1);

        }
    }
}

