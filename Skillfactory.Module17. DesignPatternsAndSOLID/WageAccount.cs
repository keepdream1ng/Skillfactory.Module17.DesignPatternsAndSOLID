using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillfactory.Module17._DesignPatternsAndSOLID
{
    public class WageAccount : Account
    {
        // тип учетной записи
        public override string Type { get; } = "Зарплатный";

        protected override double CalculateInterest()
        {
            double interest;

            // расчет процентной ставки зарплатного аккаунта по правилам банка
            interest = this.Balance * 0.5;

            return interest;
        }
    }
}
