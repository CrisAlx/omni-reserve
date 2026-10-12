using OmniReserve.Domain.Enums;

namespace OmniReserve.Domain.Entities;

public class Room
{
    public Guid Id { get; private set; }
    public string RoomNumber { get; private set; } = string.Empty;
    public RoomType Type { get; private set; }
    public decimal PricePerNight { get; private set; }
    public bool IsAvailable { get; private set; }

    private Room() { }

    private Room(string roomNumber, RoomType type, decimal pricePerNight)
    {
        Id = Guid.NewGuid();
        RoomNumber = roomNumber;
        Type = type;
        PricePerNight = pricePerNight;
        IsAvailable = true;
    }

    public static Room Create(string roomNumber, RoomType type, decimal pricePerNight)
    {
        if (pricePerNight <= 0)
        {
            throw new Exception("El precio por noche debe ser mayor a cero.");
        }

        return new Room(roomNumber, type, pricePerNight);
    }
}