using System.ComponentModel.DataAnnotations;

namespace MotoSerwis.Components.Account.Shared.Enums
{
    public enum MotorcycleServiceStatus
    {
        [Display(Name = "Przyjęty")]
        Received,
        [Display(Name = "Diagnozowanie")]
        Diagnosing,
        [Display(Name = "Oczekiwanie na części")]
        WaitingForParts,
        [Display(Name = "W naprawie")]
        UnderRepair,
        [Display(Name = "Testowanie")]
        Testing,
        [Display(Name = "Gotowy do odbioru")]
        ReadyForPickup,
        [Display(Name = "Odebrany")]
        PickedUp,
        [Display(Name = "Anulowany")]
        Cancelled
    }
}
