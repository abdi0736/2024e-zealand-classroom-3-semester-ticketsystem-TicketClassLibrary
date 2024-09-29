namespace TicketClassLibrary;

/// <summary>
/// Represents a car with a license plate, date, price, and vehicle type.
/// </summary>
public class Car
{
    
    private string _licensePlate;
    public string LicensePlate
    {
        get => _licensePlate;
        set
        {
            if (value.Length > 7)
            {
                throw new ArgumentException("Nummerplade kan ikke overstige 7 karakter.");
            }
            _licensePlate = value;
        }
    }
    
    /// <summary>
    /// Gets or sets the date with the car.
    /// </summary>
    public DateTime Date { get; set; }
    
    
    /// <summary>
    /// Gets the price of the car, which is fixed at 240.
    /// </summary>  
    public double Price { get; } = 240;
    
    

    /// <summary>
    /// Returns the vehicle type, which is always "Car".
    /// </summary>
    /// <returns>The string "Car".</returns>
    public string Vehicletype()
    {
        return "Car";
    }
    
}

    
    
    

