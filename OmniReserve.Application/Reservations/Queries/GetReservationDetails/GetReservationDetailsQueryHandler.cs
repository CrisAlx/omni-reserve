using MediatR;
using OmniReserve.Application.Common.Interfaces;

namespace OmniReserve.Application.Reservations.Queries.GetReservationDetails;

public class GetReservationDetailsQueryHandler : IRequestHandler<GetReservationDetailsQuery, ReservationDetailsDto>
{
    private readonly IReservationRepository _reservationRepository;

    public GetReservationDetailsQueryHandler(IReservationRepository reservationRepository)
    {
        _reservationRepository = reservationRepository;
    }

    public async Task<ReservationDetailsDto> Handle(GetReservationDetailsQuery request, CancellationToken cancellationToken)
    {
        var reservation = await _reservationRepository.GetReservationWithDetailsAsync(request.ReservationId);
        
        return null!;
    }
}