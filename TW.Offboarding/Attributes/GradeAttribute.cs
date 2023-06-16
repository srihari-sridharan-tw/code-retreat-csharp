namespace TW.Offboarding.Attributes;

using System;

public class GradeAttribute : Attribute
{
    public GradeAttribute(int ID, string name)
    {
        this.ID = ID;
        this.Name = name;
    }

    public int ID { get; private set; }
    public string Name { get; private set; }
}
