using TicketClassLibrary;

namespace OresundBron;

public class OresundMC : AllVehicle
{
    private const double RegularPrice = 210;   // Normal pris for MC
    private const double BrobizzPrice = 73;     // BroBizz pris for MC

    public OresundMC(string licensePlate, DateTime date, bool hasBroBizz = false)
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
        return "Oresund MC";
    }
    
    
}