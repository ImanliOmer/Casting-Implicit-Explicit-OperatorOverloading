using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingImplicitExplicitOperatorOverloading.Helper
{
    enum currency { Usd, euro, trl }
    internal class Help
    {
        public void Exchange(Enum obj, double azn)
        {
            bool isenumOrnot = false;
            if (obj is currency)
            {
                isenumOrnot = true;
                DifferentCurrencys(obj, azn);
            }

            if (isenumOrnot == false)
            {
                Console.WriteLine(" You enter false currency !");
            }
        }
        public void DifferentCurrencys(Enum currencys, double azn)
        {
            if (currencys is currency.euro)
            {
                azn = azn / 2;
                Console.WriteLine($" (EUR) Hazirki Rusuma gore: {azn} manatdir");
                return;
            }
            if (currencys is currency.Usd)
            {
                azn = azn / 1.7;
                Console.WriteLine($" (USD) Hazzirki Rusuma gore: {azn} manatdir");
                return;
            }
            if (currencys is currency.trl)
            {
                azn = azn * 8.59;
                Console.WriteLine($" (TRL) Hazzirki Rusuma gore: {azn} manatdir");
                return;
            }
        }


    }
}
