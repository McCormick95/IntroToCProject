using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToC{
    class Tool: IComparable<Tool>
    {
        private double _discount;

        // ItemId (ex. “178A”)
        public String ItemId{get; set;}

        // Name (ex. “Circular Saw”)
        public String Name{get; set;}

        // Category (ex. manual)
        public String Category {get; set;}

        // Description (“380 RPM, Cordless”)
        public String Description {get; set;}

        // DailyRentalCost (ex. 5.0)
        public double DailyRentalCost{get; set;}

        // ReplacementCost (ex. 125.0)
        public double ReplacementCost{get; set;}

        // QuantityAvailable (ex. 10)
        public int QuantityAvailable{get; set;}

        //MembershipDiscount
        public double MembershipDiscount{
            get{return _discount;}
            set{
                if (value < 0 || value > 1){
                    throw new ArgumentOutOfRangeException($"{_discount} is out of the acceptable range.");
                }
                _discount = value;
            }
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("featuring: ");
            return $@"
            Item ID: {ItemId} 
            Name: {Name} 
            Category: {Category} 
            Description: {Description}
            Daily Rental Cost: {DailyRentalCost}
            Replacement Cost: {ReplacementCost}
            Quantity Avaliable to Rent: {QuantityAvailable}
            Membership Discount Rate: {MembershipDiscount}";
        }

        public int CompareTo(Tool? other)
        {
            throw new NotImplementedException();
        }
    }
}

