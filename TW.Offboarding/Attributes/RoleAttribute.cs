namespace TW.Offboarding.Attributes;

using System;

public class RoleAttribute : Attribute
{
    internal RoleAttribute(int ID, String name)
    {
        this.Name = name;
        this.ID = ID;
    }

    public int ID { get; private set; }
    public string Name { get; private set; }
}
