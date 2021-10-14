using System;
namespace InterfaceExercise
{
    public class Truck: IVehicle, ICompany
    {
        public Truck()
        {
        }
        public string BedSize { get; set; } = "6ft";
        public int Doors { get; set; } = 2;
        public int NumberOfWheels { get; set; } = 8;
        public bool HasEngine { get; set; } = true;
        public string FuelType { get; set; } = "Diesel";
        public bool HasHonkNoise { get; set; } = true;
        public string Logo { get; set; } = "Benz";
        public string HeadQuaters { get; set; } = "Germany";
    }
}
