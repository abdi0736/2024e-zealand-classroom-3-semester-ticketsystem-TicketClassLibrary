using TicketClassLibrary;

namespace OresundBron;

public class OresundCar: AllVehicle
{
    private const double RegularPrice = 410;  // Normal pris for Bil
    private const double BrobizzPrice = 161;   // BroBizz pris for Bil

    public OresundCar(string licensePlate, DateTime date, bool hasBroBizz = false)
    {
        LicensePlate = licensePlate;
        Date = date;
        Price = ApplyBroBizzDiscount(RegularPrice, hasBroBizz);
    }

    public override double ApplyBroBizzDiscount(double basePrice, bool hasBroBizz)
    {
        return hasBroBizz ? BrobizzPrice : RegularPrice;
    }

    public override string Vehicletype()
    {
        return "Oresund car";
    }
}