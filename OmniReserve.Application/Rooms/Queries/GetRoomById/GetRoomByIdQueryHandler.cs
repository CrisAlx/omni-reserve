using MediatR;
using OmniReserve.Domain.Enums;

namespace OmniReserve.Application.Rooms.Queries.GetRoomById;

public class GetRoomByIdQueryHandler : IRequestHandler<GetRoomByIdQuery, RoomResponseDto>
{
    public Task<RoomResponseDto> Handle(GetRoomByIdQuery request, CancellationToken cancellationToken)
    {
        var response = new RoomResponseDto(
            request.RoomId,
            "101",
            RoomType.Single.ToString(),
            150.00m,
            true
        );

        return Task.FromResult(response);
    }
}