namespace TW.Offboarding.Domain.Entities;

using System;

public class EmployeeExitChecklistItem
{
    public DateTime CompletedOn { get; private set; }
    public int ExitChecklistItemID { get; private set; }
    public bool IsCompleted { get; private set; }
    public int TerminationID { get; private set; }
}
