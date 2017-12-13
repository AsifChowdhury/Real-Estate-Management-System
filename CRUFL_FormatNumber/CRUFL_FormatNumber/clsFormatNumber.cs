using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spell;
namespace CRUFL_FormatNumber
{
    public class clsFormatNumber
    {
        internal static string NumToWord(decimal amount)
        {
            
            return SpellAmount.InWrods(amount);
        }


    }
}
