namespace TicketClassLibrary;

public class MC:Car
{
    public MC(string licensePlate, DateTime date)
    {
        LicensePlate = licensePlate;
        Date = date;
    }
    
    public new double Price { get; } = 125; 
    
    public new string Vehicletype()
    {
        return "MC";
    }
}