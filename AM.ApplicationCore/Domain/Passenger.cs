using System;
using System.Collections.Generic;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PassportNumber { get; set; }
        public string TelNumber { get; set; }
        public ICollection<Flight> Flights { get; set; }

       // public bool CheckProfile(string firstName, string lastName)
        //{
          //  return this.FirstName == firstName
          //      && this.LastName == lastName;
        //}

        // CheckProfile : 3 paramètres, email optionnel
        public bool CheckProfile(string firstName, string lastName, string email = null)
        {
            if (email == null)
            {
                return this.FirstName == firstName
                    && this.LastName == lastName;
            }
            else
            {
                return this.FirstName == firstName
                    && this.LastName == lastName
                    && this.EmailAddress == email;
            }
        }
        public virtual void PassengerType()
        {
            Console.WriteLine("I am a passenger");
        }
        public override string ToString()
        {
            return "FirstName : " + FirstName
                + "  /LastName : " + LastName
                + "  /EmailAddress : " + EmailAddress;
        }
    }
}
