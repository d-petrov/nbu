using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator_MEF
{
    class Operation
    {
        private bool valid = false;

        public int Left { get; set; }
        public int Right { get; set; }
        public Char Symbol { get; set; }
        public bool Valid { get { return valid; } set { valid = value; } }
    }

}
