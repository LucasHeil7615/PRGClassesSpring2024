using System;

namespace EventPlanning
{
    // Derived class for Reception events
    public class Reception : Event
    {
        public string RsvpEmail { get; private set; }

       //gets the basic details for reception
        public Reception(string title, string description, DateTime date, TimeSpan time, Address location, string rsvpEmail)
            : base(title, description, date, time, location)
        {
            RsvpEmail = rsvpEmail;
        }

        // gets the full deatils for reception event
        public override string GetFullDetails()
        {
            return $"{GetStandardDetails()}\nEvent Type: Reception\nRSVP Email: {RsvpEmail}";
        }

        //   // provides a short description of the reception 
        public override string GetShortDescription()
        {
            return $"Reception: {Title}\nDate: {Date.ToShortDateString()}";
        }
    }
}
