using System;

namespace EventPlanning
{
    public abstract class Event
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime Date { get; private set; }
        public TimeSpan Time { get; private set; }
        public Address Location { get; private set; }

        // Constructor to initialize the event details
        protected Event(string title, string description, DateTime date, TimeSpan time, Address location)
        {
            Title = title;
            Description = description;
            Date = date;
            Time = time;
            Location = location;
        }

        //generates basic event details
        public string GetStandardDetails()
        {
            return $"Title: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time}\nAddress: {Location}";
        }

        //generates full and short description, must be implemented in derived classes
        public abstract string GetFullDetails();
        public abstract string GetShortDescription();
    }
}
