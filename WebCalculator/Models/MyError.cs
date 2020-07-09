using System;
using System.Collections.Generic;

namespace WebCalculator.Models
{
    interface IMessage
    {
        public int ID { get; set; }
        public string Herder { get; set; }
        public string Message { get; set; }
        public string Show();

    }
    public class Error : IMessage
    {
        public int ID { get; set; }
        public string Herder { get; set; }
        public string Message { get; set; }

        public string Show()
        {
            return ID + " " + Herder + " " + Message;
        }

        public Error(int iD, string herder, string message)
        {
            ID = iD;
            Herder = herder ?? throw new ArgumentNullException(nameof(herder));
            Message = message ?? throw new ArgumentNullException(nameof(message));
        }
    }
    public abstract class Errors
    {
        public static List<Error> ListErrors = GetErrors();

        private static List<Error> GetErrors()
        {
            List<Error> errors = new List<Error>();

            errors.Add(new Error(1, "Error", "Все поля должны быть заполнены"));

            return errors;
        }
    }
}
