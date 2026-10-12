using MediatR;
using OmniReserve.Application.Common.Interfaces;
using OmniReserve.Domain.Entities;

namespace OmniReserve.Application.Rooms.Commands.CreateRoom;

public class CreateRoomCommandHandler : IRequestHandler<CreateRoomCommand, Guid>
{
    private readonly IRoomRepository _roomRepository;

    public CreateRoomCommandHandler(IRoomRepository roomRepository)
    {
        _roomRepository = roomRepository;
    }

    public async Task<Guid> Handle(CreateRoomCommand request, CancellationToken cancellationToken)
    {
        // Se instancia la entidad utilizando el método estático verificado de la capa de Dominio
        var room = Room.Create(
            request.RoomNumber,
            request.Type,
            request.PricePerNight
        );

        await _roomRepository.AddAsync(room);

        return room.Id;
    }
}