using OtelManager.Common.DataProvider;
using OtelManager.Common.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace OtelManager.DataAccess
{
  public class OtelDataProvider : IOtelDataProvider
  {
    public IEnumerable<Reservation> LoadReservations()
    {
      return new List<Reservation>
      {
        new Reservation
        {
          Id = 1,
          FirstName = "Ahmet",
          SurName =  "Yılmaz",
          PhoneNumber = "05491234567",
          CheckInDate = new DateTime(2022, 10, 1),
          CheckOutDate = new DateTime(2022, 10, 5),
          AdultCount = 3,
          ChildCount = 1,
          RoomId = 1,
          IsBreakfast = true,
          IsDinner = false,
          ReservationStatusId = 1
        },
        new Reservation
        {
          Id = 2,
          FirstName = "Mehmet",
          SurName =  "Çelik",
          PhoneNumber = "05321234567",
          CheckInDate = new DateTime(2022, 10, 5),
          CheckOutDate = new DateTime(2022, 10, 7),
          AdultCount = 2,
          ChildCount = 0,
          RoomId = 2,
          IsBreakfast = true,
          IsDinner = true,
          ReservationStatusId = 2
        },
        new Reservation
        {
          Id = 3,
          FirstName = "Mert Berke",
          SurName =  "Göze",
          PhoneNumber = "05308769880",
          CheckInDate = new DateTime(2022, 12, 10),
          CheckOutDate = new DateTime(2022, 12, 15),
          AdultCount = 1,
          ChildCount = 0,
          RoomId = 2,
          IsBreakfast = false,
          IsDinner = true,
          ReservationStatusId = 2
        }
      };
    }

    public void SaveReservation(Reservation reservation)
    {
      Debug.WriteLine($"Reservation saved: {reservation.FirstName}");
    }

    public IEnumerable<ReservationStatus> LoadReservationStatuses()
    {
      return new List<ReservationStatus>
      {
        new ReservationStatus{ Id = 1, StatusName = "Ödenecek" },
        new ReservationStatus{ Id = 2, StatusName = "Ödendi" },
        new ReservationStatus{ Id = 3, StatusName = "İptal" },
      };
    }

    public IEnumerable<Room> LoadRooms()
    {
      return new List<Room>
      {
        new Room
        {
          Id = 1,
          RoomName = "Deniz Manzaralı - 2221",
          BedCount =  4,
          RoomTypeId = 3,
          AdultPrice = 200,
          ChildPrice = 100
        },
        new Room
        {
          Id = 2,
          RoomName = "Doğa Manzaralı - 2222",
          BedCount =  2,
          RoomTypeId = 1,
          AdultPrice = 250,
          ChildPrice = 100
        }
      };
    }
        
    public IEnumerable<RoomType> LoadRoomTypes()
    {
      return new List<RoomType>
      {
        new RoomType{ Id = 1, RoomTypeName = "Deniz manzaralı" },
        new RoomType{ Id = 2, RoomTypeName = "Doğa manzaralı" },
        new RoomType{ Id = 3, RoomTypeName = "Sokak manzarlı" },
      };
    }


    }
}