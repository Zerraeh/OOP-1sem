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
    public class CarMultiplierExceptions : TransportExceptions
    {
        public CarMultiplierExceptions(string message, string error) : base(message, "CarMult")
        {

        }
        public override string Message { get { return "OutOfRange"; } }
    }

    public class TrainSpeedExceptions : TransportExceptions
    {
        public TrainSpeedExceptions(string message, string error) : base(message, "trainSpeed")
        {

        }
        public int trainSpeed { get; private set; }
    }

    public class CarMoveException : TransportExceptions
    {
        public CarMoveException(string message, string error) : base(message, "carMovable")
        {
            error = Convert.ToString(speed);
        }
        public int speed { get; set; }
    }
    
    public class expressTrainExpeption : TransportExceptions
    {
        public expressTrainExpeption(string message, string error) : base(message, "expressIsNot")
        {

        }
    }
    public class expressTrainExpeptionMove : TrainSpeedExceptions
    {
        public expressTrainExpeptionMove(string message, string error) : base(message, "expressIsNot")
        {

        }
    }
}
