using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToC{
    class Tool: IComparable<Tool>
    {
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("featuring: ");
            return $"{Name}({Year}) - {NumEpisodes} episodes, {names}";
        }

        public int CompareTo(Tool? other)
        {
            throw new NotImplementedException();
        }
    }
}

