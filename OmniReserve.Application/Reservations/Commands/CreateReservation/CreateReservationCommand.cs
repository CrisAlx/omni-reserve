using MediatR;

namespace OmniReserve.Application.Reservations.Commands.CreateReservation;

public record CreateReservationCommand(
    Guid RoomId,
    Guid UserId,
    DateTime StartDate,
    DateTime EndDate,
    decimal TotalPrice
) : IRequest<Guid>;