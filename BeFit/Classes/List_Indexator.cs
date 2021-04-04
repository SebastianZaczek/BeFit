using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit.Classes
{
    public static class List_Indexator
    {
        public static int ReturnTodaysMealIndex(List<Day_Meals> list)
        {
            return list.FindIndex(x => x.Date.Date == DateTime.Today);
        }
    }
}
