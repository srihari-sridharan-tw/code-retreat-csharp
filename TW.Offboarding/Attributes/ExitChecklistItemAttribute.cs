namespace TW.Offboarding.Attributes;

using System;
using TW.Offboarding.Enums;

public class ExitChecklistItemAttribute : Attribute
{
    public ExitChecklistItemAttribute(
        int ID,
        string description,
        ExitChecklistItemCategory category,
        ExitChecklistItemType regionType,
        int regionID)
    {
        this.ID = ID;
        this.Description = description;
        this.Category = category;
        this.RegionType = regionType;
        this.RegionID = regionID;
    }

    public ExitChecklistItemCategory Category { get; private set; }
    public string Description { get; private set; }
    public int ID { get; private set; }
    public int RegionID { get; private set; }
    public ExitChecklistItemType RegionType { get; private set; }
}
