namespace TicketClassLibrary;

public class MC : AllVehicle
{
    /// <summary>
    /// Initialiserer en ny instans af <see cref="MC"/>-klassen med en nummerplade og dato.
    /// </summary>
    /// <param name="licensePlate">Nummerpladen på motorcyklen.</param>
    /// <param name="date">Datoen, der er knyttet til motorcyklen.</param>
    public MC(string licensePlate, DateTime date)
    {
        LicensePlate = licensePlate;
        Date = date;
        Price = 125; // Fast pris for MC
    }

    /// <summary>
    /// Overstyrer den abstrakte metode for at anvende BroBizz-rabat til motorcykler.
    /// </summary>
    /// <param name="basePrice">Grundprisen for motorcyklen.</param>
    /// <param name="hasBroBizz">Angiver om BroBizz-rabat skal anvendes.</param>
    /// <returns>Prisen efter BroBizz-rabat.</returns>
    public override double ApplyBroBizzDiscount(double basePrice, bool hasBroBizz)
    {
        return 125; // MC-prisen forbliver fast på 125
    }

    /// <summary>
    /// Returnerer køretøjstypen, som er "MC".
    /// </summary>
    public override string Vehicletype()
    {
        return "MC";
    }
    
}