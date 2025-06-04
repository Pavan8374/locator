namespace Locator.Models.Response
{
    public class GeoLocationResponse
    {
        public string Ip { get; set; }
        public string ContinentCode { get; set; }
        public string ContinentName { get; set; }
        public string CountryCode2 { get; set; }
        public string CountryCode3 { get; set; }
        public string CountryName { get; set; }
        public string CountryNameOfficial { get; set; }
        public string CountryCapital { get; set; }
        public string StateProv { get; set; }
        public string StateCode { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public bool IsEu { get; set; }
        public string CallingCode { get; set; }
        public string CountryTld { get; set; }
        public string Languages { get; set; }
        public string CountryFlag { get; set; }
        public string GeonameId { get; set; }
        public string Isp { get; set; }
        public string ConnectionType { get; set; }
        public string Organization { get; set; }
        public string CountryEmoji { get; set; }
        public Currency Currency { get; set; }
        public TimeZone TimeZone { get; set; }
    }

    public class Currency
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
    }

    public class TimeZone
    {
        public string Name { get; set; }
        public int Offset { get; set; }
        public int OffsetWithDst { get; set; }
        public string CurrentTime { get; set; }
        public double CurrentTimeUnix { get; set; }
        public bool IsDst { get; set; }
        public int DstSavings { get; set; }
        public bool DstExists { get; set; }

        public DstStart DstStart { get; set; }

        public DstEnd DstEnd { get; set; }
    }

    public class DstStart
    {
        public string UtcTime { get; set; }
        public string Duration { get; set; }
        public bool Gap { get; set; }
        public string DateTimeAfter { get; set; }
        public string DateTimeBefore { get; set; }
        public bool Overlap { get; set; }
    }

    public class DstEnd
    {
        public string UtcTime { get; set; }
        public string Duration { get; set; }
        public bool Gap { get; set; }
        public string DateTimeAfter { get; set; }
        public string DateTimeBefore { get; set; }
        public bool Overlap { get; set; }
    }
}
