namespace TW.Offboarding.Attributes;

using System;
using TW.Offboarding.Enums;

public class CountryAttribute : Attribute
{

    public CountryAttribute(int ID, string name, string iso3Code, Status status)
    {
        this.ID = ID;
        this.Name = name;
        this.ISO3Code = iso3Code;
        this.Status = status;
    }

    public int ID { get; private set; }
    public string ISO3Code { get; private set; }
    public string Name { get; private set; }
    public Status Status { get; private set; }
}
