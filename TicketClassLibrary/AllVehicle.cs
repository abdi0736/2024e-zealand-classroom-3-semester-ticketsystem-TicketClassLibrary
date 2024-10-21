namespace TicketClassLibrary;

/// <summary>
/// Abstrakt basisklasse for køretøjer. Indeholder fælles funktionalitet som nummerplade, dato og pris.
/// </summary>
public abstract class AllVehicle
{
    private string _licensePlate = string.Empty;

    /// <summary>
    /// Henter eller sætter nummerpladen med maksimalt 7 karakterer.
    /// Kaster en fejl, hvis nummerpladen overstiger denne grænse.
    /// </summary>
    public string LicensePlate
    {
        get => _licensePlate;
        set
        {
            if (value.Length > 7)
            {
                throw new ArgumentException("Nummerplade kan ikke overstige 7 karakter.");
            }

            _licensePlate = value ?? throw new ArgumentNullException(nameof(value), "Nummerplade kan ikke være null.");
        }
    }
    
    /// <summary>
    /// Abstrakt metode til at beregne BroBizz-rabat. Skal implementeres af afledte klasser.
    /// </summary>
    /// <param name="basePrice">Grundprisen før rabat.</param>
    /// <param name="hasBroBizz">Angiver, om BroBizz-rabatten skal anvendes.</param>
    /// <returns>Prisen efter BroBizz-rabatten er anvendt.</returns>
    public abstract double ApplyBroBizzDiscount(double basePrice, bool hasBroBizz);

    /// <summary>
    /// Henter eller sætter datoen, der er knyttet til køretøjet.
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Henter prisen for køretøjet. Bliver sat af afledte klasser.
    /// </summary>
    public virtual double Price { get; protected set; }

    /// <summary>
    /// Returnerer køretøjstypen. Skal overstyres af afledte klasser for at specificere den faktiske type.
    /// </summary>
    /// <returns>Køretøjstypen som en streng.</returns>
    public virtual string Vehicletype()
    {
        return "Ukendt køretøj";
    }
}