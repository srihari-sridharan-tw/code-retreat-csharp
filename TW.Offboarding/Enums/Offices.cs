namespace TW.Offboarding.Enums;

using TW.Offboarding.Attributes;

public enum Offices
{
    [OfficeAttribute(1, "London", Countries.UNITED_KINGDOM, Status.ACTIVE)] LONDON,
    [OfficeAttribute(2, "San Francisco", Countries.UNITED_STATES, Status.ACTIVE)] SAN_FRANCISCO,
    [OfficeAttribute(3, "Dallas", Countries.UNITED_STATES, Status.ACTIVE)] DALLAS,
    [OfficeAttribute(4, "Melbourne", Countries.AUSTRALIA, Status.ACTIVE)] MELBOURNE,
    [OfficeAttribute(5, "Sydney", Countries.AUSTRALIA, Status.ACTIVE)] SYDNEY,
    [OfficeAttribute(6, "Bengaluru", Countries.INDIA, Status.ACTIVE)] BENGALURU,
    [OfficeAttribute(7, "Chennai", Countries.INDIA, Status.ACTIVE)] CHENNAI,
    [OfficeAttribute(8, "Coimbatore", Countries.INDIA, Status.ACTIVE)] COIMBATORE,
    [OfficeAttribute(9, "Noida", Countries.INDIA, Status.CLOSED)] NOIDA,
    [OfficeAttribute(10, "Hamburg", Countries.GERMANY, Status.ACTIVE)] HAMBURG,
    [OfficeAttribute(11, "Beijing", Countries.CHINA, Status.ACTIVE)] BEIJING,
    [OfficeAttribute(12, "Wuhan", Countries.CHINA, Status.ACTIVE)] WUHAN,
    [OfficeAttribute(13, "Sao Paulo", Countries.BRAZIL, Status.ACTIVE)] SAO_PAULO,
    [OfficeAttribute(14, "Toronto", Countries.CANADA, Status.CLOSED)] TORONTO
}
