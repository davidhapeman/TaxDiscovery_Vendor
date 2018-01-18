using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendor.Classes
{
    public class clsConversionFunctions
    {
        public int getNewTaxTypeID(string origDB, string origTaxType)
        {
            int taxTypeID = 0;

            switch (origDB.ToUpper())
            {
                case "TTRACKERERIE40":
                    switch (origTaxType)
                    {
                        case "1": taxTypeID = 1; break; //County
                        case "2": taxTypeID = 2; break; //Muni
                        case "3": taxTypeID = 3; break; //School
                        case "5": taxTypeID = 4; break; //Street Light
                        case "4": taxTypeID = 7; break; //School Reduction
                        case "6": taxTypeID = 8; break; //Township Reduction
                        default: break;
                    }
                    break;
                default:
                    break;
            }

            return taxTypeID;
        }
    }
}
