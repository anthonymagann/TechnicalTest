using System;
using System.Collections.Generic;

namespace TechnicalTest.Part2
{
    public static class VehicleWork
    {
        private static Dictionary<string, Action> VehicleDictionary()
        {
            return new Dictionary<string, Action>
            {
                {"car", DoCarWork},
                {"truck", DoTruckWork},
                {"train", DoTrainWork}
            };
        }

        public static void VehicleWorkResolve(string workString)
        {
            var dictionary = VehicleDictionary();

            if (dictionary.ContainsKey(workString))
                dictionary[workString].Invoke();
        }

        private static void DoCarWork()
        {
            Console.WriteLine("Some Car specific logic here");
        }

        private static void DoTruckWork()
        {
            Console.WriteLine("Some Truck specific logic here");
        }

        private static void DoTrainWork()
        {
            Console.WriteLine("Some Train specific logic here");
        }
    }
}