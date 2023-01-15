using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BikeZilla.Extension
{
    public class YearTillDateRangeAnnotation:RangeAttribute
    {
        public YearTillDateRangeAnnotation(int start) : base(start, DateTime.Now.Year)
        {
            
        }
    }
}
