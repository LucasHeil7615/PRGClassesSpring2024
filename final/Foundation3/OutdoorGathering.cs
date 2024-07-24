using System;

namespace EventPlanning
{
    public class OutdoorGathering : Event
    {
        public string WeatherForecast { get; private set; }

        
        //gets the basic details for outdoorGatherings
        public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address location, string weatherForecast)
            : base(title, description, date, time, location)
        {
            WeatherForecast = weatherForecast;
        }

        // gets the full deatils of the outdoor event
        public override string GetFullDetails()
        {
            return $"{GetStandardDetails()}\nEvent Type: Outdoor Gathering\nWeather Forecast: {WeatherForecast}";
        }

        // provides a short description for the outdoor event
        public override string GetShortDescription()
        {
            return $"Outdoor Gathering: {Title}\nDate: {Date.ToShortDateString()}";
        }
    }
}
