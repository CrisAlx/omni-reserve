using FluentValidation;

namespace OmniReserve.Application.Rooms.Commands.CreateRoom;

public class CreateRoomCommandValidator : AbstractValidator<CreateRoomCommand>
{
    public CreateRoomCommandValidator()
    {
        RuleFor(v => v.RoomNumber)
            .NotEmpty().WithMessage("El número de habitación es obligatorio.")
            .MaximumLength(5).WithMessage("El número de habitación no debe superar los 5 caracteres.");

        RuleFor(v => v.PricePerNight)
            .GreaterThan(0).WithMessage("El precio por noche debe ser mayor a 0.");
    }
}