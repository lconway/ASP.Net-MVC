using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner
{
    class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;

        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }

        public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healthyOption)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;
        }

        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += ((CalculateCostOfBeveragesPerPerson() + CostOfFoodPerPerson) * NumberOfPeople);
                if (HealthyOption)
                    return totalCost * 0.95M;
                else
                    return totalCost;
            }
        }

        private decimal CalculateCostOfDecorations()
        {
            if (FancyDecorations)
                return ((50.00M / NumberOfPeople) + 15.00M) * NumberOfPeople;
            else
                return ((30.00M / NumberOfPeople) + 7.50M) * NumberOfPeople;
        }

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            if (HealthyOption)
                return 5.00M;
            else
                return 20.00M;
        }
    }
}
