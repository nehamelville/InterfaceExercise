using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car();
            Truck truck1 = new Truck();
            SUV suv1 = new SUV();

            Console.WriteLine($"Car Logo: { car1.Logo}\nHeadQuaters: {car1.HeadQuaters}\nHas Engine:{car1.HasEngine}\n" +
                $"Number of Doors: {car1.Doors}\nFuel Type: { car1.FuelType}\nHonk Noise: {(car1.HasHonkNoise?"Yes":"No")}" +
                $"\nNumber Of Wheels: {car1.NumberOfWheels}\nTrunk Size: {car1.TrunkSize}\n\n\n");

            Console.WriteLine($"Truck Logo: {truck1.Logo}\nHeadQuaters: {truck1.HeadQuaters}\nHas Engine:{truck1.HasEngine}\n" +
                $"Number of Doors: {truck1.Doors}\nFuel Type: {truck1.FuelType}\nHonk Noise: {(truck1.HasHonkNoise?"Yes":"No")}" +
                $"\nNumber Of Wheels: {truck1.NumberOfWheels}\nBed Size: {truck1.BedSize}\n\n\n");

            Console.WriteLine($"SUV Logo: {suv1.Logo}\nHeadQuaters: {suv1.HeadQuaters}\nHas Engine:{suv1.HasEngine}\n" +
              $"Number of Doors: {suv1.NumberOfDoors}\nFuel Type: {suv1.FuelType}\nHonk Noise: {(suv1.HasHonkNoise ?"yes":"No")}" +
              $"\nNumber Of Wheels: {suv1.NumberOfWheels}\nBed Size: {suv1.CargoSize}\n\n\n");



            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
