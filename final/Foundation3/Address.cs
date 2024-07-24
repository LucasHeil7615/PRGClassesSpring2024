using System;

namespace EventPlanning
{
    public class Address
    {
        public string Street { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string ZipCode { get; private set; }

        //provides an address
        public Address(string street, string city, string state, string zipCode)
        {
            Street = street;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        // Puts the address into a string
        public override string ToString()
        {
            return $"{Street}, {City}, {State} {ZipCode}";
        }
    }
}
