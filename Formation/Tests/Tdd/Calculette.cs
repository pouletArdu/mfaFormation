using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tdd
{
    internal class Calculette
    {
        internal int Add(string v)
        {
            if(string.IsNullOrEmpty(v)) return 0;
            var values = v.Split(',');
            return values.Sum(x =>
            {
                if (int.Parse(x) < 0) throw new ApplicationException();
                return int.Parse(x);
            } );
        }
    }
}
