using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyEstimator
{

    class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople = 0;
        public decimal CostOfBeveragesPerPerson = 0.0M;
        public decimal CostOfDecorations = 0.0M;

        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
                CostOfBeveragesPerPerson = 5.00M;
            else
                CostOfBeveragesPerPerson = 20.00M;
        }

        public void CalculateCostOfDecorations(bool fancyOption)
        {
            if (fancyOption)
                CostOfDecorations = (15.00M * NumberOfPeople) + 50.00M;
            else
                CostOfDecorations = (7.50M * NumberOfPeople) + 50.00M;
        }

        public decimal CalculateCost(bool healthyOption)
        {
            decimal CostOfFood;

            CostOfFood = ((CostOfFoodPerPerson + CostOfBeveragesPerPerson) * NumberOfPeople) +
                CostOfDecorations;
            if (healthyOption)
                CostOfFood *= 0.95M;
            return CostOfFood;
        }
    }
}
