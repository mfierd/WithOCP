using System;
using System.Collections.Generic;
using System.Text;

namespace CouponWithOCP
{
    class CouponCashback : Coupon
    {
        public double discNominal;

        public CouponCashback(double discNominal)
        {
            this.discNominal = discNominal;
        }

        public override double calculate(double originPrice)
        {
            return originPrice - discNominal;
        }

    }
}
