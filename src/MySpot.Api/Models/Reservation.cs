namespace MySpot.Api.Models;

public sealed class Reservation
{
    public Guid Id { get; set; }
    public string EmployeeName { get; set; }
    public string ParkingSpotName { get; set; }
    public string LicensePlate { get; set; }
    public DateTime Date { get; set; }
}