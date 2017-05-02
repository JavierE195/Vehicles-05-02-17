using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Vehicle
    {
        private string _VID;
        public string VID
        {
            get
            {
                return this._VID;
            }
            set
            {
                this._VID = value;
            }
        }
        private double _LastMaint;
        public double LastMaint
        {
            get
            {
                return this._LastMaint;
            }
            set
            {
                this._LastMaint = value;
            }
        }
        private double _LoadCap;
        public double LoadCap
        {
            get
            {
                return this._LoadCap;
            }
            set
            {
                this._LoadCap = value;
            }
        }


    }
}
