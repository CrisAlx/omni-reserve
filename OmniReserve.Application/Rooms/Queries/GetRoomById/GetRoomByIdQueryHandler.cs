using MediatR;
using OmniReserve.Domain.Enums;

namespace OmniReserve.Application.Rooms.Queries.GetRoomById;

public class GetRoomByIdQueryHandler : IRequestHandler<GetRoomByIdQuery, RoomResponseDto>
{
    public void Handle(GetRoomByIdQuery request)
    {
        var response = new RoomResponseDto(
            request.RoomId,
            "101");
    }
}