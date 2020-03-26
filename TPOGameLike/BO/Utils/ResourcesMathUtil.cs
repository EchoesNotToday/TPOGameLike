using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Utils
{
    public class ResourcesMathUtil
    {
        public static int? FactorialMath(Func<int?, int?> f, int? lvl)
        {
            int? res = null;
            for (int i = 1; i < lvl; i++)
            {
                res += f.Invoke(i);
            }
            return res;
        }
    }
}
