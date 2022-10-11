using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    public class TransportExceptions : Exception
    {
        public TransportExceptions(string message, string error) : base(message)
        {
            Error = error;
        }
        public string Error { get; }
    }
    public class CarFuelConsumeExceptions : TransportExceptions
    {
        public CarFuelConsumeExceptions(string message, string error) : base(message, "carFuelConsume")
        {
            
        }
        public int fuelConsume { get; private set; }
    }

    public class TrainSpeedExceptions : TransportExceptions
    {
        public TrainSpeedExceptions(string message, string error) : base(message, "trainSpeed")
        {

        }
        public int trainSpeed { get; private set; }
    }
}
