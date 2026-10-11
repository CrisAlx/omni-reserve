using MediatR;
using OmniReserve.Domain.Enums;

namespace OmniReserve.Application.Rooms.Queries.GetRoomById;

public class GetRoomByIdQueryHandler : IRequestHandler<GetRoomByIdQuery, RoomResponseDto>
{
    public Task<RoomResponseDto> Handle(GetRoomByIdQuery request, CancellationToken cancellationToken)
    {
        // Simulando que obtenemos los datos de la base de datos
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