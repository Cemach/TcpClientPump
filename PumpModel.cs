using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFormMVC
{
    public class PumpModel
    {
        public double InletPressure;
        public double OutletPressure;
        public double Temperature;
        public double Velocity;

        public PumpModel()
        {
            this.InletPressure = 50;
            this.OutletPressure = 101;
            this.Temperature = 52;
            this.Velocity = 100;
        }
    }
}
