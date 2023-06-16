namespace TW.Offboarding.Domain.Entities;

using System;
using TW.Offboarding.Enums;

public class Employee
{
    public Grades Grade { get; private set; }
    public DateTime HireDate { get; private set; }
    public int ID { get; private set; }
    public String Name { get; private set; }
    public Offices Office { get; private set; }
    public Roles role { get; private set; }
}
