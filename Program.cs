using System;
using System.Reflection.Metadata.Ecma335;

namespace IntroToC{
    class IntroToC
    {
        static void Main(string[] args)
        {
            Tool T1 = new(){
                ItemId= "1",
                Name= "Drill",
                Category="power tools",
                Description="used for drilling holes, scews, etc.",
                DailyRentalCost=35.00,
                ReplacementCost= 250.00,
                QuantityAvailable=5,
                MembershipDiscount=0.5
            };

            Tool T2 = new(){
                ItemId= "2",
                Name= "Skill Saw",
                Category="power tools",
                Description="handheld circular saw",
                DailyRentalCost=75.00,
                ReplacementCost= 300.00,
                QuantityAvailable=3,
                MembershipDiscount=0.25
            };

            Tool T3 = new(){
                ItemId= "3",
                Name= "Hand Plane",
                Category="hand tools",
                Description="used for smoothing and shaping wood",
                DailyRentalCost=15.00,
                ReplacementCost= 100.00,
                QuantityAvailable=3,
                MembershipDiscount=0.25
            };

            Tool T4 = new(){
                ItemId= "4",
                Name= "Hammer",
                Category="hand tools",
                Description="used for pounding nails",
                DailyRentalCost=10.00,
                ReplacementCost= 50.00,
                QuantityAvailable=10,
                MembershipDiscount=0.75
            };

            Tool T5 = new(){
                ItemId= "5",
                Name= "Screwdriver",
                Category="hand tools",
                Description="used for driving screws",
                DailyRentalCost=5.00,
                ReplacementCost= 25.00,
                QuantityAvailable=10,
                MembershipDiscount=0.75
            };

            Tool T6 = new(){
                ItemId= "6",
                Name= "Myter Saw",
                Category="power tools",
                Description="used for cutting angles in wood",
                DailyRentalCost=100.00,
                ReplacementCost= 500.00,
                QuantityAvailable=2,
                MembershipDiscount=0.15
            };

            Tool T7 = new(){
                ItemId= "7",
                Name= "Table Saw",
                Category="power tools",
                Description="used for cutting wood",
                DailyRentalCost=200.00,
                ReplacementCost= 1000.00,
                QuantityAvailable=1,
                MembershipDiscount=0.15
            };

            List<Tool> tools = new List<Tool>(){T1, T2, T3, T4, T5, T6, T7};
            Console.WriteLine("Itiem ID -----------------------------------------------");
            foreach (Tool t in tools){
                Console.WriteLine(t);
            }
            Console.WriteLine("Name ---------------------------------------------------");

            tools.Sort(new NameComparer());
            foreach (Tool t in tools){
                Console.WriteLine(t);
            }
            Console.WriteLine("Daily Rental Cost --------------------------------------");

            tools.Sort(new DailyRentalCostComparer());
            foreach (Tool t in tools){
                Console.WriteLine(t);
            }
            Console.WriteLine("Quantity Avaliable -------------------------------------");
            
            tools.Sort(new QuantityAvailableComparer());
            foreach (Tool t in tools){
                Console.WriteLine(t);
            }
            Console.WriteLine("Category -----------------------------------------------");
            
            tools.Sort(new CategoryComparer());
            foreach (Tool t in tools){
                Console.WriteLine(t);
            }
            Console.WriteLine("---------------------------------------------------");
        }
        public class NameComparer : IComparer<Tool>
        {
            public int Compare(Tool x, Tool y)
            {
                return x.Name.CompareTo(y.Name);
            }
        }

        public class DailyRentalCostComparer : IComparer<Tool>
        {
            public int Compare(Tool x, Tool y)
            {
                return x.DailyRentalCost.CompareTo(y.DailyRentalCost);
            }
        }

        public class QuantityAvailableComparer : IComparer<Tool>
        {
            public int Compare(Tool x, Tool y)
            {
                return x.QuantityAvailable.CompareTo(y.QuantityAvailable);
            }
        }

        public class CategoryComparer : IComparer<Tool>
        {
            public int Compare(Tool x, Tool y)
            {
                return x.Category.CompareTo(y.Category);
            }
        }
    }   
}

