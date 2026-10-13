using OmniReserve.Application.Common.Interfaces;
using OmniReserve.Domain.Entities;

namespace OmniReserve.Infrastructure.Persistence.Repositories;

public class RoomRepository : IRoomRepository
{
    private readonly Dictionary<Guid, Room> _rooms = new();

    public async Task AddAsync(Room room)
    {
        _rooms[room.Id] = room;
 
    }

    public async Task<Room?> GetByIdAsync(Guid id)
    {
        _rooms.TryGetValue(id, out var room);
        return room;
    }
}