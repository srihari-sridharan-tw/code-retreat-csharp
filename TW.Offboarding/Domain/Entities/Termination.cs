namespace TW.Offboarding.Domain.Entities;

using System;
using System.Collections.Generic;
using TW.Offboarding.Enums;

public class Termination
{
    public Employee Employee { get; private set; }
    public List<EmployeeExitChecklistItem> ExitCheckList { get; private set; } = new();
    public int ID { get; private set; }
    public DateTime InitiatedOn { get; private set; }
    public DateTime LastWorkingDate { get; private set; }
    public string Reason { get; private set; }
    public TerminationStatus Status { get; private set; }
}
