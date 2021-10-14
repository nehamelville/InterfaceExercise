using System;
namespace InterfaceExercise
{
    public class Car: IVehicle,ICompany
    {
        public Car()
        {
        }
        public string TrunkSize { get; set; } = "14.0 cubic feet";
        public int Doors { get; set; } = 4;

        public int NumberOfWheels { get; set; } = 4;
        public bool HasEngine { get; set; } = true;
        public string FuelType { get; set; } = "Petrol";
        public bool HasHonkNoise { get; set; } = true;
        public string Logo { get; set; } = "BMW";
        public string HeadQuaters { get; set; } = "Germany";
    }
}

