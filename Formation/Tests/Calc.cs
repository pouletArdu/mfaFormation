using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tests
{
    internal class Calc
    {
        public int Add(string input){
            
            if(input == "") return 0;
            
            var format = input.Split(",");
            var res = 0;
            foreach (var e in format)
            {
                var number = Int32.Parse(e);
                res += number;           
            }
            return res;
        }
    }
}