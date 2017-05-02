using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Truck : Vehicle
    {
        private int _NumAxels;
        public int NumAxels
        {
            get
            {
                return this._NumAxels;
            }
            set
            {
                this._NumAxels = value;
            }
        }
    }
}
