using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillfactory.Module17._DesignPatternsAndSOLID
{
    public abstract class Account
    {
        // тип учетной записи
        public abstract string Type { get; }

        // баланс учетной записи
        public double Balance { get; set;}

        // процентная ставка
        public double Interest
        {
            get
            {
                return CalculateInterest();
            }
        }

        protected abstract double CalculateInterest();
        // Lets say there is a bunch of methods here, like ChangeBalance and more.
    }
}
