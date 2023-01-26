using Microsoft.AspNetCore.Mvc;
using MySpot.Api.Models;

namespace MySpot.Api.Controllers;

[ApiController]
[Route("/api/reservations")]
public sealed class ReservationsController : ControllerBase
{
    private static string[] _parkingSpotNames = { "P1", "P2", "P3", "P4", "P5" };
    private readonly List<Reservation> _reservations = new();

    [HttpGet]
    public ActionResult<IEnumerable<Reservation>> GetReservations()
    {
        return Ok(_reservations);
    }

    [HttpGet("{id:Guid}")]
    public ActionResult<Reservation> GetReservation(Guid id)
    {
        var reservation = _reservations.FirstOrDefault(x => x.Id == id);
        if (reservation is null)
        {
            return NotFound();
        }

        return Ok(id);
    }

    [HttpPost]
    public ActionResult CreateReservation(Reservation reservation)
    {
        _reservations.Add(reservation);
        return Ok();
    }

    [HttpPut("{id:Guid}")]
    public ActionResult UpdateReservation(Guid id)
    {
        return Ok();
    }

    [HttpDelete("{id:Guid}")]
    public ActionResult DeleteReservation(Guid id)
    {
        return NoContent();
    }
}