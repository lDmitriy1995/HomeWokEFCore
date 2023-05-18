public class Hotel
{
    public int HotelId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public List<Room> Rooms { get; set; }
    public List<Reservation> Reservations { get; set; }
}

public class Room
{
    public int RoomId { get; set; }
    public string Number { get; set; }
    public int HotelId { get; set; }
    public Hotel Hotel { get; set; }
    public RoomType Type { get; set; }
    public List<Reservation> Reservations { get; set; }
}

public enum RoomType
{
    Standard,
    Deluxe,
    Suite
}

public class Reservation
{
    public int ReservationId { get; set; }
    public int RoomId { get; set; }
    public Room Room { get; set; }
    public int GuestId { get; set; }
    public Guest Guest { get; set; }
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
}

public class Guest
{
    public int GuestId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public List<Reservation> Reservations { get; set; }
}

//Каждый отель(Hotel) может иметь несколько комнат (Room).
//Каждая комната(Room) принадлежит одному отелю (Hotel).
//Каждая комната(Room) может иметь несколько бронирований (Reservation).
//Каждое бронирование(Reservation) ссылается на одну комнату (Room) и одного гостя (Guest).
//Каждый гость(Guest) может иметь несколько бронирований (Reservation).
//Также в модели присутствует перечисление RoomType, которое определяет типы комнат (например, Standard, Deluxe, Suite). 