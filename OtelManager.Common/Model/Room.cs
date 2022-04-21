using System;

namespace OtelManager.Common.Model
{
  public class Room
  {
    public string RoomName { get; set; }
    public int Id { get; set; }
    public int BedCount { get; set; }
    public int RoomTypeId { get; set; }
    public int AdultPrice { get; set; }
    public int ChildPrice { get; set; }
  }
}
