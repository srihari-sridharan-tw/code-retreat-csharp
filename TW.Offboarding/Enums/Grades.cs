namespace TW.Offboarding.Enums;

using TW.Offboarding.Attributes;

public enum Grades
{
    [GradeAttribute(1, "Consultant Graduate")] CONSULTANT_GRADUATE,
    [GradeAttribute(2, "Consultant")] CONSULTANT,
    [GradeAttribute(3, "Senior Consultant")] SENIOR_CONSULTANT,
    [GradeAttribute(4, "Lead Consultant")] LEAD_CONSULTANT,
    [GradeAttribute(5, "Principal Consultant")] PRINCIPAL_CONSULTANT,
    [GradeAttribute(6, "Director")] DIRECTOR
}
