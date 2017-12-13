using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Spell;
namespace CRUFLFormatAsBDT
{
    [ComVisible(true), ClassInterface(ClassInterfaceType.None), Guid("F8A163AA-FF92-4D3C-8F7E-E3C761B9CACF")]
    class FormatAsBDCurrency : IFormatAsBDCurrency
    {
        public string AmountInWords(decimal amount)
        {
            return SpellAmount.InWrods(amount);
        }
    }
}
