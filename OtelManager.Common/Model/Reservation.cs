using System;

namespace OtelManager.Common.Model
{
  public class Reservation
  {
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string SurName { get; set; }

    public string PhoneNumber { get; set; }

    public DateTimeOffset CheckInDate { get; set; }

   public DateTimeOffset CheckOutDate { get; set; }

    public int AdultCount { get; set; }

    public int ChildCount { get; set; }

    public int RoomId { get; set; }
    public bool IsBreakfast { get; set; }

    public bool IsDinner { get; set; }

    public int ReservationStatusId { get; set; }
  }
}
