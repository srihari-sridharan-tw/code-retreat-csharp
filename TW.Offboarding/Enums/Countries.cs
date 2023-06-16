namespace TW.Offboarding.Enums;

using TW.Offboarding.Attributes;

public enum Countries
{
    [CountryAttribute(1, "United Kingdom", "GBR", Status.ACTIVE)] UNITED_KINGDOM,
    [CountryAttribute(2, "United States", "USA", Status.ACTIVE)] UNITED_STATES,
    [CountryAttribute(3, "Australia", "AUS", Status.ACTIVE)] AUSTRALIA,
    [CountryAttribute(4, "India", "IND", Status.ACTIVE)] INDIA,
    [CountryAttribute(5, "Germany", "DEU", Status.ACTIVE)] GERMANY,
    [CountryAttribute(6, "China", "CHN", Status.ACTIVE)] CHINA,
    [CountryAttribute(7, "Brazil", "BRA", Status.ACTIVE)] BRAZIL,
    [CountryAttribute(8, "Canada", "CAN", Status.CLOSED)] CANADA
}
