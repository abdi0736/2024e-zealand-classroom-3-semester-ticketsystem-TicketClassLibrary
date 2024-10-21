using System.Runtime.InteropServices.Marshalling;

using System;

namespace TicketClassLibrary;

/// <summary>
/// Repræsenterer en bil med en nummerplade, dato, pris og køretøjstype.
/// </summary>
public class Car : AllVehicle
{
    private const double RegularPrice = 240; // Standardpris for biler
    private const double BrobizzDiscount = 0.05; // 5% BroBizz-rabat

    /// <summary>
    /// Initialiserer en ny instans af <see cref="Car"/>-klassen med nummerplade, dato og BroBizz-rabatstatus.
    /// </summary>
    /// <param name="licensePlate">Bilens nummerplade.</param>
    /// <param name="date">Datoen, der er knyttet til bilen.</param>
    /// <param name="hasBroBizz">Angiver, om bilen har en BroBizz-rabat.</param>
    public Car(string licensePlate, DateTime date, bool hasBroBizz = false)
    {
        LicensePlate = licensePlate;
        Date = date;

        // Beregn den endelige pris baseret på dato og om BroBizz er anvendt
        Price = CalculateFinalPrice(RegularPrice, hasBroBizz, date);
    }

    /// <summary>
    /// Beregner den endelige pris efter at have anvendt weekend- og BroBizz-rabatter.
    /// </summary>
    /// <param name="basePrice">Bilens grundpris.</param>
    /// <param name="hasBroBizz">Angiver, om BroBizz-rabatten skal anvendes.</param>
    /// <param name="date">Datoen for bilens passage.</param>
    /// <returns>Den endelige pris efter alle relevante rabatter er anvendt.</returns>
    private double CalculateFinalPrice(double basePrice, bool hasBroBizz, DateTime date)
    {
        // Anvend weekendrabat, hvis relevant
        if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
        {
            basePrice *= 0.8; // 20% weekendrabat
        }

        // Anvend BroBizz-rabat, hvis relevant
        if (hasBroBizz)
        {
            basePrice *= (1 - BrobizzDiscount); // 5% BroBizz-rabat
        }

        return basePrice;
    }

    /// <summary>
    /// Anvender BroBizz-rabatten på bilens grundpris.
    /// </summary>
    /// <param name="basePrice">Bilens grundpris.</param>
    /// <param name="hasBroBizz">Angiver, om BroBizz-rabatten skal anvendes.</param>
    /// <returns>Prisen efter BroBizz-rabat.</returns>
    public override double ApplyBroBizzDiscount(double basePrice, bool hasBroBizz)
    {
        return hasBroBizz ? basePrice * (1 - BrobizzDiscount) : basePrice;
    }

    /// <summary>
    /// Returnerer køretøjstypen, som er "Car".
    /// </summary>
    public override string Vehicletype()
    {
        return "Car";
    }
    
}