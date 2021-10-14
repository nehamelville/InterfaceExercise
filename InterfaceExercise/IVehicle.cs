using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {
       public int NumberOfWheels { get; set; }
       public bool HasEngine { get; set; }
       public string FuelType { get; set; }
       public bool HasHonkNoise { get; set; }


    }
}
