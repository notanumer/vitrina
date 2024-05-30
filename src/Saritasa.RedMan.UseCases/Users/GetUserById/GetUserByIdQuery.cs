using MediatR;

namespace Saritasa.RedMan.UseCases.Users.GetUserById;

/// <summary>
/// Get user details by identifier.
/// </summary>
public record GetUserByIdQuery : IRequest<UserDetailsDto>
{
    /// <summary>
    /// User id.
    /// </summary>
    public int UserId { get; init; }
}
