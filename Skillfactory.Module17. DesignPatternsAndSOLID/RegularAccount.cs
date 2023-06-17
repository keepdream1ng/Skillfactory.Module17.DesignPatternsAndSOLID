using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillfactory.Module17._DesignPatternsAndSOLID
{
    public class RegularAccount : Account
    {
        // тип учетной записи
        public override string Type { get; } = "Обычный";

        protected override double CalculateInterest()
        {
            double interest;
            // расчет процентной ставки обычного аккаунта по правилам банка
            interest = this.Balance * 0.4;

            if (this.Balance < 1000)
            {
                interest -= this.Balance * 0.2;
            }

            if (this.Balance >= 1000)
            {
                interest -= this.Balance * 0.4;
            }

            return interest;
        }
    }
}
