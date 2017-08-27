namespace App8
{
    class Party
    {
        public const int CostOfFoodPerPerson = 25;

        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }

        public virtual decimal Cost {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;
                if (NumberOfPeople > 12)
                    totalCost += 100;
                return totalCost;
            }
        }

        decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
                costOfDecorations = (NumberOfPeople * 15M) + 50M;
            else
                costOfDecorations = (NumberOfPeople * 7.5M) + 30M;
            return costOfDecorations;
        }

    }
}
