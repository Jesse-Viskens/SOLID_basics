using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    public static class VehicleFactory
    {
        //public static IVehicle Build(int chosenValue)
        //{
        //    switch (chosenValue)
        //    {
        //        case 1:
        //            return new Unicycle();
        //        case 2:
        //            return new Motorbike();
        //        case 3:
        //            return new Car();
        //        default:
        //            return new Truck();
        //    }
        //}
        public static IVehicle Build(string chosenValue, string naam)
        {
            int aantalWielen = 0;
            var y = Type.GetType($"Factory_Pattern.{chosenValue}");
            Object[] args = { naam};
            IVehicle vehicle = (IVehicle)Activator.CreateInstance(y,args);
            return vehicle;

        }
    }
}
