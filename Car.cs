using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Car : Vehicle
    {
        private int _NumPass;
        public int NumPass
        {
            get
            {
                return this._NumPass;
            }
            set
            {
                this._NumPass = value;
            }
        }
    }
}
