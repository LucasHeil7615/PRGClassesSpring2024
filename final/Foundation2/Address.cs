namespace OrderSystem
{
    public class Address
    {
        private string streetAddress;
        private string city;
        private string stateOrProvince;
        private string country;

        public Address(string streetAddress, string city, string stateOrProvince, string country)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.stateOrProvince = stateOrProvince;
            this.country = country;
        }

        public string StreetAddress => streetAddress;
        public string City => city;
        public string StateOrProvince => stateOrProvince;
        public string Country => country;

        // Checks if the address is in the USA
        public bool IsInUSA()
        {
            return country.ToLower() == "usa";
        }

        // Formats the address as a single string
        public override string ToString()
        {
            return $"{streetAddress}\n{city}, {stateOrProvince}\n{country}";
        }
    }
}
