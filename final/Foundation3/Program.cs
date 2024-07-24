using System;

namespace EventPlanning
{
    class Program
    {
        static void Main()
        {
            // examples of the events
            var lecture = new Lecture(
                "AI for Everyone",
                "A lecture on the future of AI technology.",
                new DateTime(2024, 8, 15),
                new TimeSpan(18, 30, 0),
                new Address("123 Tech Lane", "Innovation City", "CA", "90001"),
                "Dr. Jane Smith",
                150
            );

            var reception = new Reception(
                "Networking Night",
                "An evening to connect with professionals in the industry.",
                new DateTime(2024, 9, 10),
                new TimeSpan(19, 0, 0),
                new Address("456 Business Blvd", "Corporate Town", "NY", "10001"),
                "rsvp@networkingnight.com"
            );

            var outdoorGathering = new OutdoorGathering(
                "Summer Festival",
                "A festival celebrating summer with music and food.",
                new DateTime(2024, 7, 20),
                new TimeSpan(12, 0, 0),
                new Address("789 Park Ave", "Event City", "FL", "33101"),
                "Sunny with a high of 85°F"
            );

            // Displays the details of each event
            DisplayEventDetails(lecture);
            DisplayEventDetails(reception);
            DisplayEventDetails(outdoorGathering);
        }

        static void DisplayEventDetails(Event evnt)
        {
            Console.WriteLine("Basic Details:");
            Console.WriteLine(evnt.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("Full Details:");
            Console.WriteLine(evnt.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("Short Description:");
            Console.WriteLine(evnt.GetShortDescription());
            Console.WriteLine();
        }
    }
}
