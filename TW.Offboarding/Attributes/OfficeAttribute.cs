namespace TW.Offboarding.Attributes;

using System;
using TW.Offboarding.Enums;

public class OfficeAttribute : Attribute
{
    internal OfficeAttribute(int ID, string name, Countries country, Status status)
    {
        this.ID = ID;
        this.Name = Name;
        this.Country = country;
        this.Status = status;
    }

    public Countries Country { get; private set; }
    public int ID { get; private set; }
    public string Name { get; private set; }
    public Status Status { get; private set; }
}
