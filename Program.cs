using System;
using System.Collections.Generic;
using System.Linq;

namespace vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Aeronca aeronca1= new Aeronca();
            Helicopter helicopter1= new Helicopter();

            List<IAirVehicle> flying= new List<IAirVehicle>();
            flying.Add(aeronca1);
            flying.Add(helicopter1);

            foreach(var x in flying){
                x.Fly();
                x.Drive();
            }

            Console.WriteLine("");


            FourWheeler newFour= new FourWheeler();
            Scooter newScoot= new Scooter();
            List<ILandVehicle> land= new List<ILandVehicle>();

            land.Add(newFour);
            land.Add(newScoot);

            foreach(var x in land){
                x.Drive();
            }
            Console.WriteLine("");

            JetSki newSki= new JetSki();
            Pontoon newToon = new Pontoon();
            List<IWaterVehicle> water= new List<IWaterVehicle>();

            water.Add(newSki);
            water.Add(newToon);
            foreach(var x in water){
                x.Drive();
            }
        }

        public interface IVehicle{

        } 

        public interface ILandVehicle{
            int Wheels { get; set; }
            int Doors { get; set; }
            int PassengerCapacity { get; set; }
            string TransmissionType { get; set; }
            double EngineVolume { get; set; }
            double MaxLandSpeed { get; set; }  
            void Start();
            void Stop();
            void Drive();
        }

        public interface IWaterVehicle{
            int Doors { get; set;} 
            int PassengerCapacity { get; set; }
            string TransmissionType { get; set; }
            double EngineVolume { get; set; }
            double MaxWaterSpeed { get; set; }
            void Start();
            void Stop();
            void Drive();
        }

        public interface IAirVehicle{
            int Wheels { get; set; }
            int Doors { get; set; }
            int PassengerCapacity { get; set; }
            string TransmissionType { get; set; }
            double EngineVolume { get; set; }
            bool Winged { get; set; }
            double MaxAirSpeed { get; set; }
            void Start();
            void Stop();
            void Fly();
            void Drive();
        }
        public class FourWheeler : ILandVehicle{
            public int Wheels {get; set;}= 4;
            public int PassengerCapacity { get; set; }=2;
            public int Doors { get; set; }=0;
            public string TransmissionType { get; set; }="Electric Shift";
            public double EngineVolume { get; set; }= 10.56;
            public double MaxLandSpeed { get; set; }= 45;
            public void Drive(){
                Console.WriteLine("The Four wheeler traverses through the woods and brush.");
            }
            public void Start()
            {
                Console.WriteLine("It starts with an electic whir of the gears clicking");
            }

            public void Stop()
            {
                throw new NotImplementedException();
            }
        }

             public class Scooter : ILandVehicle{
            public int Wheels {get; set;}= 2;
            public int PassengerCapacity { get; set; }=1;
            public int Doors { get; set; }=0;
            public string TransmissionType { get; set; }="One Speed";
            public double EngineVolume { get; set; }= 3.63;
            public double MaxLandSpeed { get; set; }= 25;
            public void Drive(){
                Console.WriteLine("The Scooter scoots around town in a casual manner.");
            }
            public void Start()
            {
                throw new NotImplementedException();
            }

            public void Stop()
            {
                throw new NotImplementedException();
            }
        }

        public class JetSki : IWaterVehicle
        {
            public int Doors { get; set; }=0;
            public int PassengerCapacity { get; set; }=2;
            public string TransmissionType { get; set; }="Throttle";
            public double EngineVolume { get; set; }=4.67;
            public double MaxWaterSpeed { get; set; }= 55.7;            

            public void Drive()
            {
                Console.WriteLine("The jetski zips through the waves with the greatest of ease");
            }
            public void Start()
            {
                throw new NotImplementedException();
            }

            public void Stop()
            {
                throw new NotImplementedException();
            }
        }

        public class Pontoon :IWaterVehicle{
            public int Doors { get; set; }=2;
            public int PassengerCapacity { get; set; }=10;
            public string TransmissionType { get; set; }="Automatic";
            public double EngineVolume { get; set; }=8.67;
            public double MaxWaterSpeed { get; set; }= 22.4;
           

            public void Drive()
            {
                Console.WriteLine("The Pontoon cruises over the water bobbing up and down on the waves.");
            }
            public void Start()
            {
                throw new NotImplementedException();
            }

            public void Stop()
            {
                throw new NotImplementedException();
            }
        }

        public class Helicopter :IAirVehicle{
            public int Wheels { get; set; }=0;
            public int Doors { get; set; }=2;
            public int PassengerCapacity { get; set; }=6;
            public bool Winged { get; set; }=false;
            public string TransmissionType { get; set; }="Rotor system";
            public double EngineVolume { get; set; }=14.03;
           
            public double MaxLandSpeed { get; set; }=15;
            public double MaxAirSpeed { get; set; }=249.10;

            public void Fly()
            {
                Console.WriteLine("The Helicopter chops through the air at a very fast pace.");
            }
            public void Drive(){
                Console.WriteLine("The helicopter moves slowly to an open area to being its takeoff");
            }
            public void Start()
            {
                throw new NotImplementedException();
            }

            public void Stop()
            {
                throw new NotImplementedException();
            }
        }

            public class Aeronca : IAirVehicle{
            public int Wheels { get; set; }=2;
            public int Doors { get; set; }=1;
            public int PassengerCapacity { get; set; }=2;
            public bool Winged { get; set; }=true;
            public string TransmissionType { get; set; }="Propellar system";
            public double EngineVolume { get; set; }=14.03;
            public double MaxLandSpeed { get; set; }=30;
            public double MaxAirSpeed { get; set; }=105;

            public void Fly()
            {
                Console.WriteLine("The Aeronca soars through the sky leisurely.");
            }
            public void Drive(){
                Console.WriteLine("It goes a moderate speed to build enough drag over its winds to gain it lift to fly.");
            }
            public void Start()
            {
                throw new NotImplementedException();
            }

            public void Stop()
            {
                throw new NotImplementedException();
            }
        }

    }
}
