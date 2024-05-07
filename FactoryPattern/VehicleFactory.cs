﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public VehicleFactory()
        {
            public static IVehicle GetVehicle(int WheelCount)
            {
                switch (WheelCount)
                {
                    case 2:
                        return new Motorcycle();

                        case 4:
                        return new Car();

                        default:new Car();
                }
            }
        }
    }
}