using System;
namespace InterfaceExercise
{
    public class SUV: IVehicle, ICompany
    {
        public SUV()
        {
        }
        public string CargoSize { get; set; } = "27.0 cubic feet";
        public int NumberOfDoors { get; set; } = 4;
        public int NumberOfWheels { get; set; } = 4;
        public bool HasEngine { get; set; } = true;
        public string FuelType { get; set; } = "Diesel";
        public bool HasHonkNoise { get; set; } = true;
        public string Logo { get; set; } = "Audi";
        public string HeadQuaters { get; set; } = "Germany";
    }
}
