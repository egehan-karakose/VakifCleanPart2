using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCodeSample
{
    public class DiscountManager
    {
        /*
         * 1. İsimler yanlış
         * 2. Sihirli Sayılar
         * 3. Hata olasılığı
         * 4. Okunabilir değil
         * 5. Kodlar tekrar ediyor: DRY
         * 
         * xx: Summary comment eksik
         */

        public enum CustomerStatus
        {
            NotRegistered = 1,
            SimpleCustomer = 2,
            ValuableCustomer = 3,
            MostValuableCustomer = 4,
            VIPCustomer = 5
        }

        private const int max_discount_for_loyalty = 5;
        private const decimal simple_customers_discount = 0.1m;
        private const decimal valuable_customers_discount = 0.3m;
        private const decimal most_valuable_customers_discount = 0.5m;



        public decimal ApplyDiscount(decimal price, CustomerStatus customerStatus, int timeOfHavingAccountInYears)
        {
            decimal priceAfterDiscount = 0;
            decimal discountForLoyaltyInPercentage = (timeOfHavingAccountInYears > max_discount_for_loyalty) ? (decimal)max_discount_for_loyalty / 100 : (decimal)timeOfHavingAccountInYears / 100;
            switch (customerStatus)
            {
                case CustomerStatus.NotRegistered:
                    priceAfterDiscount = price;
                    break;
                case CustomerStatus.SimpleCustomer:
                    priceAfterDiscount = calculateDiscountedPrice(price, discountForLoyaltyInPercentage, simple_customers_discount);
                    break;
                case CustomerStatus.ValuableCustomer:
                    priceAfterDiscount = calculateDiscountedPrice(price, discountForLoyaltyInPercentage, valuable_customers_discount);
                    break;
                case CustomerStatus.MostValuableCustomer:
                    priceAfterDiscount = calculateDiscountedPrice(price, discountForLoyaltyInPercentage, most_valuable_customers_discount);
                    break;
                default:
                    break;
            }

            return priceAfterDiscount;

        }

        private static decimal calculateDiscountedPrice(decimal price, decimal discountForLoyaltyInPercentage, decimal discountRate)
        {
            decimal priceAfterDiscount = price - (discountRate * price);
            priceAfterDiscount = priceAfterDiscount - (discountForLoyaltyInPercentage * priceAfterDiscount);
            return priceAfterDiscount;
        }
    }
}
