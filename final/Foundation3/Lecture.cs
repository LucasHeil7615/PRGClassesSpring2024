using System;

namespace EventPlanning
{
    // Derived class for Lecture events
    public class Lecture : Event
    {
        public string Speaker { get; private set; }
        public int Capacity { get; private set; }

       //gets the basic details for the lecture 
        public Lecture(string title, string description, DateTime date, TimeSpan time, Address location, string speaker, int capacity)
            : base(title, description, date, time, location)
        {
            Speaker = speaker;
            Capacity = capacity;
        }

        //gets the Full details for the lecture 
        public override string GetFullDetails()
        {
            return $"{GetStandardDetails()}\nEvent Type: Lecture\nSpeaker: {Speaker}\nCapacity: {Capacity}";
        }

        // provides a short descritpion for the lecture
        public override string GetShortDescription()
        {
            return $"Lecture: {Title}\nDate: {Date.ToShortDateString()}";
        }
    }
}
