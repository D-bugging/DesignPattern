using FactoryMethod.Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Factories
{
    class CarTransport : Transport
    {
        public override IVehicle CreateTransport()
        {
            return new Car();
        }
    }
}
