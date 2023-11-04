using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules //utilities olduğu için class çıplak kalabilir
    {
        public static IResult Run(params IResult[] logics) //params tipinde istediğimiz kadar parametre verebileceğiz 
        {
            foreach (var result in logics)
            {
                if (!result.Success) //başarısız olan iş kurallarını business'a bildiriyoruz
                {
                    return result;
                }
            }

            return null;
        }
    }
}
