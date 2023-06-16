namespace TW.Offboarding.Enums;

using TW.Offboarding.Attributes;

public enum ExitChecklistItems
{
    [ExitChecklistItemAttribute(1, "Desk Keys", ExitChecklistItemCategory.ADMIN, ExitChecklistItemType.COUNTRY, 4)] DESK_KEYS,
    [ExitChecklistItemAttribute(2, "File Cabinet Keys", ExitChecklistItemCategory.ADMIN, ExitChecklistItemType.COUNTRY, 4)] FILE_CABINET_KEYS,
    [ExitChecklistItemAttribute(3, "Access Card", ExitChecklistItemCategory.ADMIN, ExitChecklistItemType.COUNTRY, 4)] ACCESS_CARD,
    [ExitChecklistItemAttribute(4, "Cell Phone", ExitChecklistItemCategory.ADMIN, ExitChecklistItemType.COUNTRY, 4)] CELL_PHONE,
    [ExitChecklistItemAttribute(5, "SIM Card", ExitChecklistItemCategory.ADMIN, ExitChecklistItemType.COUNTRY, 4)] SIM_CARD,
    [ExitChecklistItemAttribute(6, "Library Books", ExitChecklistItemCategory.ADMIN, ExitChecklistItemType.COUNTRY, 4)] LIBRARY_BOOKS,
    [ExitChecklistItemAttribute(7, "SEZ Card", ExitChecklistItemCategory.ADMIN, ExitChecklistItemType.COUNTRY, 8)] SEZ_CARD,
    [ExitChecklistItemAttribute(8, "Laptop", ExitChecklistItemCategory.ADMIN, ExitChecklistItemType.COUNTRY, 4)] LAPTOP,
    [ExitChecklistItemAttribute(9, "Monitors", ExitChecklistItemCategory.ADMIN, ExitChecklistItemType.COUNTRY, 4)] MONITORS,
    [ExitChecklistItemAttribute(10, "Charger", ExitChecklistItemCategory.ADMIN, ExitChecklistItemType.COUNTRY, 4)] CHARGER,
    [ExitChecklistItemAttribute(11, "RSA FOB", ExitChecklistItemCategory.ADMIN, ExitChecklistItemType.COUNTRY, 4)] RSA_FOB,
    [ExitChecklistItemAttribute(12, "Outstanding Expenses", ExitChecklistItemCategory.ADMIN, ExitChecklistItemType.COUNTRY, 4)] OUTSTANDING_EXPENSES,
    [ExitChecklistItemAttribute(13, "Sodexo Reimbursement", ExitChecklistItemCategory.ADMIN, ExitChecklistItemType.COUNTRY, 4)] SODEXO_REIMBURSEMENT,
    [ExitChecklistItemAttribute(14, "Exit Survey", ExitChecklistItemCategory.ADMIN, ExitChecklistItemType.COUNTRY, 4)] EXIT_SURVEY,
    [ExitChecklistItemAttribute(15, "Leave Encashment", ExitChecklistItemCategory.ADMIN, ExitChecklistItemType.COUNTRY, 4)] LEAVE_ENCASHMENT,
    [ExitChecklistItemAttribute(16, "Gratuity", ExitChecklistItemCategory.ADMIN, ExitChecklistItemType.COUNTRY, 4)] GRATUITY
}
