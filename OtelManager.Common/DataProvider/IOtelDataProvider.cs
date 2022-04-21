using OtelManager.Common.Model;
using System.Collections.Generic;

namespace OtelManager.Common.DataProvider
{
  public interface IOtelDataProvider
  {
    IEnumerable<Reservation> LoadReservations();

    void SaveReservation(Reservation reservation);

    IEnumerable<Room> LoadRooms();

    IEnumerable<RoomType> LoadRoomTypes();

    IEnumerable<ReservationStatus> LoadReservationStatuses();
  }
}
