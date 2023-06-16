namespace TW.Offboarding.Enums;

using TW.Offboarding.Attributes;
public enum Roles
{
    [RoleAttribute(1, "Developer")] DEVELOPER,
    [RoleAttribute(2, "Quality Analyst")] QUALITY_ANALYST,
    [RoleAttribute(3, "Business Analyst")] BUSINESS_ANALYST,
    [RoleAttribute(4, "Product Manager")] PRODUCT_MANAGER,
    [RoleAttribute(5, "Project Manager")] PROJECT_MANAGER,
    [RoleAttribute(6, "UI Developer")] UI_DEVELOPER,
    [RoleAttribute(7, "Experience Designer")] EXPERIENCE_DESIGNER,
    [RoleAttribute(8, "Mobile Developer")] MOBILE_DEVELOPER,
    [RoleAttribute(9, "Data Engineer")] DATA_ENGINEER,
    [RoleAttribute(10, "Data Scientist")] DATA_SCIENTIST,
    [RoleAttribute(11, "Infra Consultant")] INFRA_CONSULTANT,
}
